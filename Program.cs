using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace PLSQL_Crack_Pass
{
    public class Program
    {
        static void Main(string[] args)
        {
            string judgePath = "-p";
            if (args.Length == 2 && args[0].Equals(judgePath, StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    _PrintResults(args);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
               
            }
            else
            {
                Console.WriteLine("Usage: PLSQLCrackPass.exe -p user.prefs_Path");
                Console.WriteLine(@"       PLSQLCrackPass.exe -p ""C:\Program Files\PLSQL Developer 14\Preferences\user.prefs""");
            }

        }
        private static void _PrintResults(string[] args)
        {
         
            string path = args[1];
            var settings = new Settings(path);
            try
            {
                var logins = settings.GetLogins();
                foreach (var login in logins)
                {
                    Console.WriteLine("Result! '{0}'", login);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! '{0}'", ex.Message);
            }
        
        }
    }
}
