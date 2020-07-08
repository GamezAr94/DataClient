using COMP2614Assign07ab.Common;
using COMP2614Assign07ab.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign07ab.Business
{
    class ClientValidation
    {
        private static readonly List<string> errors;
        public static string Errormessage
        {
            get
            {
                string message = "";
                foreach(string line in errors)
                {
                    message += line + "\r\n";
                }
                return message;
            }
        }
        static ClientValidation()
        {
            errors = new List<string>();
        }
        public static int AddClient(Client client)
        {
            if (validate(client))
            {
                return Repository.AddClient(client);
            }
            else
            {
                return -1;
            }
        }
        public static int UpdateClient(Client client)
        {
            if (validate(client))
            {
                return Repository.UpdateClient(client);
            }
            else
            {
                return -1;
            }
        }
        public static ClientList GetClients()
        {
            return Repository.GetClientList();
        }
        public static int DeleteClient(Client client)
        {
            return Repository.DeleteClient(client);
        }
        private static bool validate(Client client)
        {
            errors.Clear();
            if (string.IsNullOrWhiteSpace(client.ClientCode))
            {
                errors.Add("ClientCode cannot be empty.");
            }
            if (string.IsNullOrWhiteSpace(client.CompanyName))
            {
                errors.Add("CompanyName cannot be empty.");
            }
            if (string.IsNullOrWhiteSpace(client.Address1))
            {
                errors.Add("Address1 cannot be empty.");
            }
            if (string.IsNullOrWhiteSpace(client.Province))
            {
                errors.Add("Province cannot be null or empty.");
            }
            if(client.YTDSales < 0)
            {
                errors.Add("YTDSales cannot be less than zero.");
            }
            return !(errors.Count > 0);
        }
    }
}
