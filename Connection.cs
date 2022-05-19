using System.Configuration;

namespace LoginApp
{
    public static class Connection
    {
        public static string ConnectionString
            => @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ethan\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30";

    }
}