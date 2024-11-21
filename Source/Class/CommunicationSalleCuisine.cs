using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Class
{
    public class CommunicationSalleCuisine
    {
        private byte[] bytes = new byte[1024];
        private IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
        private static IPAddress ipAddress = IPAddress.Parse("192.168.0.5");
        private IPEndPoint remoteEP = new IPEndPoint(ipAddress, 8651);

        // Create a TCP/IP  socket.  
        Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

        public CommunicationSalleCuisine()
        {
            Thread th = new Thread(run_communication);
            th.Start();
            sender.Connect(remoteEP);
        }

        private void run_communication()
        {
            
            while (true)
            {
                try
                {
                    int bytesRec = sender.Receive(bytes);
                    Console.WriteLine("Echoed test = {0}", Encoding.ASCII.GetString(bytes, 0, bytesRec));
                }
                catch { }
                
            }
            
        }
        public void AddSale(string a, int b)
        {
            // TODO implement here
        }

        public void GetPlatFromCuisine()
        {
           //todo nimporte koa
        }

        public void GetPropre()
        {
            // TODO implement here
        }

        public void SendCommande()
        {
            try
            {
                Console.WriteLine("Socket connected to {0}",
                sender.RemoteEndPoint.ToString());

                // Encode the data string into a byte array.  
                byte[] msg = Encoding.ASCII.GetBytes("Fourchette,5,Assiette,15,paul,3,falcort,5<EOF>");

                // Send the data through the socket.  
                int bytesSent = sender.Send(msg);
            }
            catch
            {

            }
        }
    }


    /// <summary>
    /// @param string 
    /// @param int
    /// </summary>
    
}
