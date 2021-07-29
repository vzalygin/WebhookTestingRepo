using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace ConsoleClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("ConsoleClient for DevОленька project.");
            var connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/hub")
                .WithAutomaticReconnect()
                .Build();
            connection.On(
                "Send",
                () =>
                {
                    Console.WriteLine("New push!");
                });
            Console.WriteLine("Connection is configured");

            var isConnected = false;
            while (!isConnected)
            {
                try
                {
                    Console.WriteLine("Trying to connect to server...");
                    await connection.StartAsync();
                    Console.WriteLine("Successful!");
                    isConnected = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(
                        $"Err:\n" + 
                        $"{e.Message}\n" +
                        $"Try again in 5 sec..."
                    );
                    Thread.Sleep(5000);
                }
            }
            
            Console.WriteLine("Ready to work!");
            
            Console.ReadLine();
        }
    }
}