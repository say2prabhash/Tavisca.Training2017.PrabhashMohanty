using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Chat_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            // server side
            try
            {


                ServerConnection();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }
            Console.ReadLine();
        }
        public static async Task CallServer()
        {
            
                bool check = true;
                while (check)
                {
                    string str = "";
                    IPAddress ipAdress = IPAddress.Parse("192.168.6.53");
                    TcpListener myList = new TcpListener(ipAdress, 8000);
                    // TcpListener myList1 = new TcpListener(ipAdress, 8001);
                    // Start Listeneting at the specified port
                    myList.Start();

                    Console.WriteLine("Server running - Port: 8000");
                    Console.WriteLine("Local end point:" + myList.LocalEndpoint);
                    Socket s = myList.AcceptSocket();
                    // When accepted
                    Console.WriteLine("Connection accepted from " + s.RemoteEndPoint);
                    str = s.ToString();
                   
                        byte[] b = new byte[100];
                        int k = s.Receive(b);
                        Console.WriteLine("Recieved...");

                        for (int i = 0; i < k; i++)
                        {
                            Console.Write(Convert.ToChar(b[i]));
                        }
                        ASCIIEncoding asen = new ASCIIEncoding();
                        s.Send(asen.GetBytes("Automatic message: " + "String received by server!"));
                        Console.WriteLine("\n Automatic message sent!");
                //Task.Delay(200);
                s.Close();
//Task.Delay(200);
                        myList.Stop();
                        
                   
                }
            
        }

    

    public static async void ServerConnection()
    {
        //Program p = new Program();
        await CallServer();
    }

    
        }
    }

