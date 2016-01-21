using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Caliburn.Micro.TestingHelpers
{
    public class TestablePlatformProvider : IPlatformProvider
    {
        public void BeginOnUIThread(Action action) { action(); }
        public Task OnUIThreadAsync(Action action) { return Task.Run(action); }
        public void OnUIThread(Action action) { action(); }
        public object GetFirstNonGeneratedView(object view) { return view; }
        public void ExecuteOnFirstLoad(object view, Action<object> handler) { handler(view); }
        public void ExecuteOnLayoutUpdated(object view, Action<object> handler) { handler(view); }
        Action IPlatformProvider.GetViewCloseAction(object viewModel, ICollection<object> views, bool? dialogResult)
        {
            return GetViewCloseAction(viewModel, views, dialogResult);
        }

        public Action GetViewCloseAction(object viewModel, ICollection<object> views, bool? dialogResult)
        {
            return () => CloseActionFor(viewModel, views, dialogResult);
        }
        public bool InDesignMode { get; set; }

        public Action<object, ICollection<object>, bool?> CloseActionFor { get; set; }
    }
}