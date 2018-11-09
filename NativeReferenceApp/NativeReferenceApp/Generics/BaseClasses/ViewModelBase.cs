using System;

namespace SharedProject.Generic.BaseClasses
{
    public delegate void ErrorCallback(ErrorBase error);
    public delegate void BindingCallback(Object bindingInfo);

    public class ViewModelBase
    {
        protected ModuleAdapterBase _moduleAdapter;
        protected ErrorBase _error;

        public BindingCallback Notify { get; set; }

        public ViewModelBase() { }

        void Pause() { }

        void Resume() { }

        void Cancel() { }
    }
}
