using System.Configuration;

namespace CourseWorkApp
{
    public class TransferContext
    {
        public ApplicationDataContext context { get; set; }
        public string username { get; set; }
    }
    public static class Program
    {

        [STAThread]
        static void Main()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm(connectionString, out TransferContext context));
            if(context.context != null)
            {
                var logic = new Logic(context);
                Application.Run(new MainForm(logic));
            }
        }
    }
}