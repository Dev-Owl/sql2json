using System;

namespace sql2json
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                printUsage();
                return;
            }
            try
            {
                new Sql2Json(args).Validate().Run();
            }
            catch (StopException)
            {
            }
            catch (Exception)
            {
                Console.WriteLine("Error, see message before");
            }

        }

        private static void printUsage()
        {
            Console.WriteLine("sql2json [connectionstring] [query/path to query file] [targetfile]");
            Console.WriteLine("[targetfile] - optional");
        }
    }
}
