using System;
using System.Net;  
using System.Net.Sockets;  
using System.Text; 

namespace RPNclient
{
    class Program
    {  
        static void Main()
        {
            string command;
            string result;
            Console.WriteLine("Insert command");
            command = Console.ReadLine();
            command += "<EOF>";
            result = StartClient(command);
            Console.WriteLine(result);
        }

        public static string StartClient(string command)
        {  
            // Data buffer for incoming data.  
            byte[] bytes = new byte[1024];
            string strRec = string.Empty;
    
            // Connect to a remote device.  
            try {  
                // Establish the remote endpoint for the socket.  
                // This example uses port 11000 on the local computer.  
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());  
                IPAddress ipAddress = ipHostInfo.AddressList[0];  
                IPEndPoint remoteEP = new IPEndPoint(ipAddress,11000);  
    
                // Create a TCP/IP  socket.  
                Socket sender = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp );  
    
                // Connect the socket to the remote endpoint. Catch any errors.  
                try {  
                    sender.Connect(remoteEP);  
    
                    Console.WriteLine("Socket connected to {0}",  
                        sender.RemoteEndPoint.ToString());  
    
                    // Encode the data string into a byte array.  
                    byte[] msg = Encoding.ASCII.GetBytes(command);  
    
                    // Send the data through the socket.  
                    int bytesSent = sender.Send(msg);  
    
                    // Receive the response from the remote device.  
                    int bytesRec = sender.Receive(bytes);  
                    strRec = Encoding.ASCII.GetString(bytes,0,bytesRec);
    
                    // Release the socket.  
                    sender.Shutdown(SocketShutdown.Both);  
                    sender.Close();  
    
                } catch (ArgumentNullException ane) {  
                    Console.WriteLine("ArgumentNullException : {0}",ane.ToString());  
                } catch (SocketException se) {  
                    Console.WriteLine("SocketException : {0}",se.ToString());  
                } catch (Exception e) {  
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());  
                }  
    
                } catch (Exception e) {  
                    Console.WriteLine( e.ToString());  
                }

                return strRec;
        }   
    }
}