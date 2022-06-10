using System;
using System.Windows.Forms;

namespace guest_app
{
    static class ConnectionString
    {
        public static string SqliteString() 
        {
            return @"Data Source=" + System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile) + @"\Documents\guest_app\data.sqlite";
        }
    }
    static class CurrentForms
    {
        public static Form1 form1;
        public static Customer customer;
        public static Visit visit;
        public static TotalTable table;
    }
    internal static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CurrentForms.form1 = new Form1();
            Application.Run(CurrentForms.form1);
        }
    }
}

