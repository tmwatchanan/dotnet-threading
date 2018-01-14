using System;
using System.Threading;

namespace dotnet_threading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            ServerClass serverObject = new ServerClass();
            Thread InstanceCaller = new Thread(new ThreadStart(serverObject.InstanceMethod));
            // Start the thread.
            InstanceCaller.Start();
            Console.WriteLine("The Main() thread calls this after " + "starting the new InstanceCaller thread.");

            Thread StaticCaller = new Thread(new ThreadStart(ServerClass.StaticMethod));
            // Start the thread.
            StaticCaller.Start();
            Console.WriteLine("The Main() thread calls this after " + "starting the new StaticCaller thread.");
        }
    }
}
