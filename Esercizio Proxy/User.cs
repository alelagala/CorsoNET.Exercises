using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Proxy
{
    public class User
    {
        public string _username;
        private string _password;
        private int _IP;

        public User(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public void ServerConnection(Proxy proxy, Server server)
        {
            _IP = proxy.IP();
            server.Access(this);
            Logger.Log(this,1);
        }
        public void ServerDisconnection(Proxy proxy, Server server)
        {
            _IP = proxy.IP();
            server.Deconnect(this);
            Logger.Log(this,0);
        }
        public int IP { get { return _IP; } }
        public string Username { get { return _username; } }
    }
}
