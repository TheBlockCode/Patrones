using System;
namespace Singleton.Ejm1
{
   
    class ConsoleLogger:Logger
    {
        public void Log(String msg)
        {
            Console.WriteLine(msg + " registrado por consola");
        }
    }
}
