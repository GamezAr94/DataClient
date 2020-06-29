namespace COMP2614Assign07ab
{
    class Client
    {
        public string ClientCode { get; private set; }
        public string CompanyName { get; private set; }
        public string Address1 { get; private set; }
        public string Address2 { get; private set; }
        public string City { get; private set; }
        public string Province { get; private set; }
        public string PostalCode { get; private set; }
        public decimal YTDSales { get; private set; }
        public bool CreditHold { get; private set; }
        public string Notes { get; private set; }

        public Client(string clientCode, string companyName, string address1, string address2, string city,
                    string province, string postalCode, decimal YTDSales, bool creditHold, string notes)
        {
            this.ClientCode = clientCode;
            this.CompanyName = companyName;
            this.Address1 = address1;
            this.Address2 = Address2;
            this.City = city;
            this.Province = province;
            this.PostalCode = postalCode;
            this.YTDSales = YTDSales;
            this.CreditHold = creditHold;
            this.Notes = notes;
        }
    }
}