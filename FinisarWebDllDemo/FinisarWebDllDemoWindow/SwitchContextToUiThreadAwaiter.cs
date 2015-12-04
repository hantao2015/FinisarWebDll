using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
 

namespace FinisarWebDllDemoWindow
{
    public class SwitchContextToUiThreadAwaiter {
    private readonly Dispatcher uiContext;

    public SwitchContextToUiThreadAwaiter(Dispatcher uiContext)
    {
        this.uiContext = uiContext;
    }

    public SwitchContextToUiThreadAwaiter GetAwaiter()
    {
        return this;
    }

    public bool IsCompleted { get { return false; } }

    public void OnCompleted(Action continuation)
    {
        this.uiContext.Invoke(new Action(continuation));
    }

    public void GetResult() { }
}
}

