using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Messaging;
using System.Security.Principal;
using System.Security.Permissions;

public class Program{
    public static void Main(){
        
    }
    static void DoLongOperation()
    {
        var operationId = Guid.NewGuid();
        CallContext.LogicalSetData("OperationId", operationId);

        DoSomeStepOfOperation();

        CallContext.FreeNamedDataSlot("OperationId");
    }
    static void DoSomeStepOfOperation()
    {
        // 在这里记录日志。
        Trace.WriteLine("In operation: " +
        CallContext.LogicalGetData("OperationId"));
    }
}