using System;

namespace TestOpc
{
    public sealed class OpcBridgeSupport : IDisposable
    {
        Type opcBridgeServerType;
        object opcBridgeServerObject;

        public OpcBridgeSupport()
        {
            opcBridgeServerType = Type.GetTypeFromProgID("OpcBridgeServer.Application");
            if (opcBridgeServerType != null)
            {
                try
                {
                    opcBridgeServerObject = Activator.CreateInstance(opcBridgeServerType);
                    InitOPC();
                }
                catch
                {
                    opcBridgeServerType = null;
                }
            }
        }

        public void Dispose()
        {
            if (opcBridgeServerType != null)
            {
                try
                {
                    FinitOPC();
                }
                catch
                {
                    opcBridgeServerType = null;
                }
            }
        }

        public void InitOPC()
        {
            if (opcBridgeServerType != null)
            {
                opcBridgeServerType.InvokeMember("InitOPC",
                    System.Reflection.BindingFlags.InvokeMethod,
                    null, opcBridgeServerObject, new object[] { });
            }
        }

        public void FinitOPC()
        {
            if (opcBridgeServerType != null)
            {
                opcBridgeServerType.InvokeMember("FinitOPC",
                    System.Reflection.BindingFlags.InvokeMethod,
                    null, opcBridgeServerObject, new object[] { });
            }
        }

        public string GetServers()
        {
            if (opcBridgeServerType != null)
                return (string)opcBridgeServerType.InvokeMember("GetServers",
                            System.Reflection.BindingFlags.InvokeMethod,
                            null, opcBridgeServerObject, new object[] { });
            else
                return String.Empty;
        }

        public string GetProps(string server)
        {
            if (opcBridgeServerType != null)
                return (string)opcBridgeServerType.InvokeMember("GetProps",
                        System.Reflection.BindingFlags.InvokeMethod,
                        null, opcBridgeServerObject, new object[] { server });
            else
                return String.Empty;
        }

        public void AddItem(string server, string group, string param)
        {
            if (opcBridgeServerType != null)
            {
                opcBridgeServerType.InvokeMember("AddItem",
                    System.Reflection.BindingFlags.InvokeMethod,
                    null, opcBridgeServerObject, new object[] { server, group, param });
            }
        }

        public string FetchItem(string server, string group, string param)
        {
            if (opcBridgeServerType != null)
                return (string)opcBridgeServerType.InvokeMember("FetchItem",
                        System.Reflection.BindingFlags.InvokeMethod,
                        null, opcBridgeServerObject, new object[] { server, group, param });
            else
                return String.Empty;
        }

    }

}
