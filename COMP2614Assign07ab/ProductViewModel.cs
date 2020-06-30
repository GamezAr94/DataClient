using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace COMP2614Assign07ab
{
    class ProductViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ProductViewModel()
        {
            this.Clients = DatabaseConnection.GetClietList();
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
