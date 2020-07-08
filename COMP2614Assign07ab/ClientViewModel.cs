
using COMP2614Assign07ab.Common;
using COMP2614Assign07ab.Data;

namespace COMP2614Assign07ab
{
    public class ClientViewModel : ClientViewModelBase 
    { 
        public ClientViewModel()
        {
            this.Clients = Repository.GetClientList();
            this.Client = new Client();
        }
        private Client client;
        public Client Client
        {
            get { return client; }
            set
            {
                client = value;
                OnPropertyChanged();
            }
        }
        public ClientList Clients { get; set; }
        public void SetDisplayClient(Client client)
        {
            this.Client = new Client
            {
                ClientCode = client.ClientCode,
                CompanyName = client.CompanyName,
                Address1 = client.Address1,
                Address2 = client.Address2,
                City = client.City,
                Province = client.Province,
                PostalCode = client.PostalCode,
                YTDSales = client.YTDSales,
                CreditHold = client.CreditHold,
                Notes = client.Notes
            };
        }
        public Client GetDisplayClient()
        {
            OnPropertyChanged("Client");
            return this.Client;
        }
    }
}
