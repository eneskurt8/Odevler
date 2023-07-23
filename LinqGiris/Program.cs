using System.Data.SqlClient;
using System.Net.Sockets;

namespace LinqGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Select * from Customers", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<Customer> customerList = new List<Customer>();
            while (dr.Read())
            {
                customerList.Add(new Customer
                {
                    CustomerID = dr["CustomerID"].ToString(),
                    Address = dr["Address"].ToString(),
                    CompanyName = dr["CompanyName"].ToString(),
                    City = dr["City"].ToString(),
                    ContactName = dr["ContactName"].ToString(),
                    ContactTitle = dr["ContactTitle"].ToString(),
                    Country = dr["Country"].ToString(),
                    Fax = dr["Fax"].ToString(),
                    Phone = dr["Phone"].ToString(),
                    PostalCode = dr["PostalCode"].ToString(),
                    Region = dr["Region"].ToString(),

                });
            }
                conn.Close();
                dr.Close();


                Console.WriteLine("Veritabanından çekilen musteri sayisi : " + customerList.Count);






            

        }
    }
}