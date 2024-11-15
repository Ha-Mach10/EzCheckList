using System.Reactive.Disposables;

using Prism.Mvvm;
using Prism.Navigation;

namespace EzDialogDriver.Core.Mvvm
{
    public abstract class ViewModelBase : BindableBase, IDestructible
    {
        protected CompositeDisposable _disposables;


        protected ViewModelBase()
        {
            _disposables = new CompositeDisposable();
        }

        public virtual void Destroy()
        {
            _disposables.Dispose();
        }
    }
}
