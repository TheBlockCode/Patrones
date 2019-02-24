using System;
using Libs;
namespace Singleton.Ejm1
{
    
    class FileLogger: Logger
    {
        private static FileLogger logger;

       
        private FileLogger()
        {

        }

        public static FileLogger getFileLogger()
        {
            if (logger == null)
            {
                logger = new FileLogger();
            }
            return logger;

        }

        public void Log(String msg)
        {
            FileUtil futil = new FileUtil();


            futil.WriteToFile(msg, "log.txt");
        }
    }
}
