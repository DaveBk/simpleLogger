using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace SimpleLogger
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            log.Debug("Developer: Program was run");
            log.Info("Developer: program is running ");
            log.Warn("Developer: we are close to tried to divide by zero again");

            var i = 0;

            try
            {
                var x = 10 / i;
            }
            catch (DivideByZeroException ex)
            {
                log.Error("Developer: we tried to divide by zero again");
            }

            Console.ReadLine();
        }

    }
}
