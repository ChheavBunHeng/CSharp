using EnrollLibrary;
using System.Data.SqlClient;

namespace WinFormsStudents
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
            try
            {
                Helper.LoadConfiguration("appsettings.json");
                Connection = Helper.MakeConnection();
                Helper.CreateProcedures();
                Helper.GenerateRequiredCommands();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Preparing Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Application.Run(new ViewForm());
        }

        public static SqlConnection Connection { get; set; } = null!;
    }
}