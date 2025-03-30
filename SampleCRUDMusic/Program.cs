using SampleCRUDMusic.Data;

namespace SampleCRUDMusic
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDbContext context = new AppDbContext();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new AlbumsMainForm(context));
        }
    }
}