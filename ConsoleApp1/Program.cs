using AdoNET.Models;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sqlconnection conn = new sqlconnection("server=.; database=nortwind; ıntegrated security=true; trustservercertificate=true;");
            sqlcommand cmd = new sqlcommand("select * from customers", conn);

            conn.open();

            sqldatareader dr = cmd.executereader();
            while (dr.read())
            {
                console.writeline(dr["customerıd"]);
            }
            conn.close();




        }
    }
}