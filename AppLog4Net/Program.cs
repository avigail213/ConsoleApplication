using log4net.Config;
using log4net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLog4Net
{
    public class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            
            XmlConfigurator.Configure();

            // Get input from user
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            Stopwatch stopwatch = Stopwatch.StartNew();

            // Loop for input number of iterations
            for (int i = 0; i < input; i++)
            {
                
            }

            stopwatch.Stop();

            // Print execution time
            Console.WriteLine($"Execution time: {stopwatch.ElapsedMilliseconds} ms");

            // Log execution time
            //ILog log = LogManager.GetLogger(typeof(Program));
            log.Info($"Input: {input} - Time: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
