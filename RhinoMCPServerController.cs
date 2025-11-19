using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino;

namespace RhinoMCPPlugin
{
    class RhinoMCPServerController
    {
        private static RhinoMCPServer server;

        public static void StartServer()
        {
            if (server == null)
            {
                server = new RhinoMCPServer();
            }

            server.Start();
            RhinoApp.WriteLine("Server started.");
        }

        public static void StopServer()
        {
            if (server != null)
            {
                server.Stop();
                server = null;
                RhinoApp.WriteLine("Server stopped.");
            }
        }

        public static bool IsServerRunning()
        {
            return server != null;
        }
    }
}
