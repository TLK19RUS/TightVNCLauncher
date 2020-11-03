using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TightVNCLauncher
{
    class THost
    {
        public string Name { get; private set; }
        public string Host { get; private set; }
        public string Password { get; private set; }
        public bool connected;

        public string Display
        {
            get
            {
                if (this.connected)
                {
                    return this.Name + " connected";
                }
                else
                {
                    return this.Name;
                }
            }
        }

        public THost(string name, string host, string password)
        {
            this.Name = name;
            this.Host = host;
            this.Password = password;
            this.connected = false;
        }
    }
}
