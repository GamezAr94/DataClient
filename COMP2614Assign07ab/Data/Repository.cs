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
    class Repository
    {
        private static readonly string connString = @"Server=tcp:comp2614.database.windows.net,1433; 
                                                        Initial Catalog=comp2614; 
                                                        User ID=student; 
                                                        Password=iLOVEpho!; 
                                                        Encrypt=True; 
                                                        TrustServerCertificate=False; 
                                                        Connection Timeout=30;";
        public static ClientList GetClientList()
        {
            ClientList clients;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT ClientCode, CompanyName, Address1, Address2, City, Province, PostalCode, YTDSales, CreditHold, Notes
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
        public static int AddClient(Client client)
        {
            int rowsAffected;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = $@"INSERT INTO Client1042699 
                        (CompanyName, Address1, Address2, City, Provnce, PostalCode, YTDSales, CreditHold, Notes)
                        VALUES (@companyName, @address1, @address2, @city, @province, @postalCode, @ytdSales, @creditHold, @notes);";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("companyName", client.CompanyName);
                    cmd.Parameters.AddWithValue("address1", client.Address1);
                    cmd.Parameters.AddWithValue("address2", (object)client.Address2??DBNull.Value);
                    cmd.Parameters.AddWithValue("city", (object)client.City ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("province", client.Province);
                    cmd.Parameters.AddWithValue("postalCode", (object)client.PostalCode??DBNull.Value);
                    cmd.Parameters.AddWithValue("ytdSales",client.YTDSales);
                    cmd.Parameters.AddWithValue("creditHold", client.CreditHold);
                    cmd.Parameters.AddWithValue("notes", (object)client.Notes ?? DBNull.Value);

                    conn.Open();

                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
                return rowsAffected;
        }
        public static int UpdateClient(Client client)
        {
            int rowsAffected;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = $@"UPDATE Client1042699
                                SET CompanyName = @companyName,
                                Address1 = @address1,
                                Address2 = @address2,
                                City = @city,
                                Province = @province,
                                PostalCode = @postalCode,
                                YTDSales = @ytdSales,
                                CreditHold = @creditHold,
                                Notes = @notes
                                WHERE ClientCode = @clientCode;";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("companyName", client.CompanyName);
                    cmd.Parameters.AddWithValue("address1", client.Address1);
                    cmd.Parameters.AddWithValue("address2", (object)client.Address2 ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("city", (object)client.City ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("province", client.Province);
                    cmd.Parameters.AddWithValue("postalCode", (object)client.PostalCode ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("ytdSales", client.YTDSales);
                    cmd.Parameters.AddWithValue("creditHold", client.CreditHold);
                    cmd.Parameters.AddWithValue("notes", (object)client.Notes ?? DBNull.Value);

                    conn.Open();

                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
        public static int DeleteClient(Client client)
        {
            int rowsAffected;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = $@"DELETE Client1042699
                                WHERE ClientCode = @clientCode;";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("clientCode", client.ClientCode);

                    conn.Open();

                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
    }
}
