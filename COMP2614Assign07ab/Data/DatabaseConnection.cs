using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using COMP2614Assign07ab.Common;

namespace COMP2614Assign07ab.Data
{
    class DatabaseConnection
    {
        private static readonly string connString = @"Server=tcp:comp2614.database.windows.net,1433; 
                                                        Initial Catalog=comp2614; 
                                                        User ID=student; 
                                                        Password=iLOVEpho!; 
                                                        Encrypt=True; 
                                                        TrustServerCertificate=False; 
                                                        Connection Timeout=30;";
        public static ClientList GetClietList()
        {
            ClientList clients;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT *
                                FROM Client1042699;";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    conn.Open();

                    clients = new ClientList();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        string clientCode;
                        string companyName;
                        string address1;
                        string address2;
                        string city;
                        string province;
                        string postalCode;
                        decimal ytdSales;
                        bool creditHold;
                        string notes;
                        while (reader.Read())
                        {
                            clientCode = reader["ClientCode"] as string;
                            companyName = reader["CompanyName"] as string;
                            address1 = reader["Address1"] as string;
                            address2 = reader.IsDBNull(3)?null:reader["Address2"] as string;
                            city = reader.IsDBNull(4)?null:reader["City"] as string;
                            province = reader["Province"] as string;
                            postalCode = reader.IsDBNull(6) ? null:reader["PostalCode"] as string;
                            ytdSales =(decimal)reader["YTDSales"];
                            creditHold = (bool)reader["CreditHold"];
                            notes = reader.IsDBNull(9) ? null : reader["Notes"] as string;
                            clients.Add(new Client() { 
                                ClientCode = clientCode, 
                                CompanyName = companyName, 
                                Address1 = address1, 
                                Address2 = address2,
                                City= city,
                                Province = province,
                                PostalCode = postalCode, 
                                YTDSales = ytdSales,
                                CreditHold = creditHold, 
                                Notes = notes 
                            });
                        }
                    }
                }
                return clients;
            }
        }
    }
}
