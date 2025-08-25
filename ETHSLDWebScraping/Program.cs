namespace ETHSLDWebScraping
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            if (args.Length != 0 && args.Length == 2) 
            {
                try
                {
                    int from = int.Parse(args[0]);
                    int to = int.Parse(args[1]);
                    Application.Run(new Form(from, to));
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Application.Run(new Form());
            }
        }
    }
}