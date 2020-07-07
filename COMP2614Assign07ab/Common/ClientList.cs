using System.Linq;
using System.ComponentModel;

namespace COMP2614Assign07ab.Common
{
    public class ClientList:BindingList<Client>
    {
        //Lambda expressions
        public decimal TotalYTSales => this.Sum(x => x.YTDSales);
        public int CreditHoldCount => this.Count(x => x.CreditHold == true);

        #region Expression-bodied methods
        /*
         // TotalYTSales methods
        public decimal TotalYTSales1
        {
            get
            {
                return TotalSales();
            }
        }

        public decimal TotalSales()
        {
            decimal sum = 0;
            foreach (Client a in this)
            {
                sum += a.YTDSales;
            }
            return sum;
        }


        // CreditHoldCount Method
        public int CreditHoldCount1
        {
            get
            {
                return totalHolds();
            }
        }

        private int totalHolds()
        {
            int total = 0;
            foreach(Client c in this)
            {
                if (c.CreditHold)
                {
                    ++total;
                }
            }
            return total;
        }
        */
        #endregion
    }
}
