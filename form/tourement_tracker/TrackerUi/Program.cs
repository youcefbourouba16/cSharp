namespace TrackerUi
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // intialize the dataBabe
            Tourament_library.globalConfig.InitializingConnection(true, true);
            Application.Run(new creatPrize());
        }
    }
}