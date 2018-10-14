using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace PBrickCommander
{
    public sealed class AsyncLabelViewModel : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        private readonly Action<Action> invokeOnMainThread;
        private readonly Func<string, Task> setAsync;
        private string _text;
        private Exception setTextException;

        public string Text {
            get => _text;
            set {
                if (setAsync == null) {
                    throw new InvalidOperationException();
                }
                try {
                    setAsync(value.Trim()).GetAwaiter().GetResult();
                }
                catch (Exception ex) {
                    _text = value;
                    setTextException = ex;
                    OnErrorsChanged(nameof(Text));
                }
            }
        }

        public AsyncState AsyncState { get; private set; } = AsyncState.Waiting;

        public bool HasErrors => setTextException != null;
        
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public AsyncLabelViewModel(Task<string> getter, Action<Action> invokeOnMainThread)
        {
            if (getter == null) {
                throw new ArgumentNullException(nameof(getter));
            }
            this.invokeOnMainThread = invokeOnMainThread ?? throw new ArgumentNullException(nameof(invokeOnMainThread));

            getter.ContinueWith(t => {
                if (!t.IsCanceled && !t.IsFaulted) {
                    _text = t.Result;
                    OnPropertyChanged(nameof(Text));
                    AsyncState = AsyncState.Completed;
                }
                else {
                    AsyncState = AsyncState.Failed;
                }
                OnPropertyChanged(nameof(AsyncState));
            });
        }

        public AsyncLabelViewModel(Func<IObserver<string>, Task<IDisposable>> subscribeAsync,
            Action<Action> invokeOnMainThread)
        {
            if (subscribeAsync == null) {
                throw new ArgumentNullException(nameof(subscribeAsync));
            }

            var observer = Observer.Create<string>(x => {
                _text = x;
                OnPropertyChanged(nameof(Text));
                if (setTextException != null) {
                    setTextException = null;
                    OnErrorsChanged(nameof(Text));
                }
            });

            // TODO: await disposer and dispose at appropriate time
            subscribeAsync(observer);
            this.invokeOnMainThread = invokeOnMainThread ?? throw new ArgumentNullException(nameof(invokeOnMainThread));
        }

        public AsyncLabelViewModel(Func<IObserver<string>, Task<IDisposable>> subscribeAsync,
            Func<string, Task> setAsync, Action<Action> invokeOnMainThread)
            : this(subscribeAsync, invokeOnMainThread)
        {
            this.setAsync = setAsync ?? throw new ArgumentNullException(nameof(setAsync));
        }

        private void OnPropertyChanged(string propertyName)
        {
            invokeOnMainThread(() => {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            });
        }

        private void OnErrorsChanged(string propertyName)
        {
            invokeOnMainThread(() => {
                ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(nameof(Text)));
            });
        }

        public IEnumerable GetErrors(string propertyName)
        {
            switch (propertyName) {
                case nameof(Text):
                    if (setTextException != null) {
                        yield return setTextException;
                    }
                    break;
            }
        }
    }
}
