using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2614Assign07ab
{
    public partial class EditDialog : Form
    {
        public ClientViewModel ClientVM { get; set; }
        public EditDialog()
        {
            InitializeComponent();
        }

        private void ClientEditDialog_Load(object sender, EventArgs e)
        {
            setBindings();
        }
        public void setBindings()
        {
            textBoxCompanyN.DataBindings.Add("Text", ClientVM, "Client.CompanyName");
            textBoxAddress1.DataBindings.Add("Text", ClientVM, "Client.Address1");
            textBoxAddress2.DataBindings.Add("Text", ClientVM, "Client.Address2");
            textBoxCity.DataBindings.Add("Text", ClientVM, "Client.City");
            textBoxProvince.DataBindings.Add("Text", ClientVM, "Client.Province");
            textBoxPostalCode.DataBindings.Add("Text", ClientVM, "Client.PostalCode");
            textBoxYTDSales.DataBindings.Add("Text", ClientVM, "Client.YTDSales",
                                                true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");
            checkBoxCreditHold.DataBindings.Add("Checked", ClientVM, "Client.CreditHold");
            textBoxNotes.DataBindings.Add("Text", ClientVM, "Client.Notes");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
