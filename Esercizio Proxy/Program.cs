using System;

namespace Esercizio_Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var logger=Logger.getInstance();
            var p = Proxy.Getinstance();
            User u1 = new User("Alex", "redwwad");
            User u2 = new User("Marco", "r34236e");
            User u3 = new User("Luca", "r23889r4d");

            Server s1 = new Server("server1");

            u1.ServerConnection(p, s1);
            u2.ServerConnection(p, s1);
            u3.ServerConnection(p, s1);
            u2.ServerDisconnection(p, s1);
            u3.ServerDisconnection(p, s1);
        }
    }













    
}
