/*
 * Author: Arturo Gamez Ortega
 * COMP 2614
 * Assignment 07 ab
 * Jul-02-2020
 */
using COMP2614Assign07ab.Common;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace COMP2614Assign07ab
{
    public partial class MainForm : Form
    {
        private ClientViewModel clientVM;
        public MainForm()
        {
            InitializeComponent();
        }
        //Loading the main form
        private void MainForm_Load(object sender, EventArgs e)
        {
            clientVM = new ClientViewModel();
            setBindings();
            setupDataGridView();
        }

        private void setBindings()
        {
            dataGridViewClients.AutoGenerateColumns = false;
            dataGridViewClients.DataSource = clientVM.Clients;
        }
        private void setupDataGridView()
        {
            dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClients.MultiSelect = false;
            dataGridViewClients.AllowUserToAddRows = false;
            dataGridViewClients.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewClients.AllowUserToOrderColumns = false;
            dataGridViewClients.AllowUserToResizeColumns = false;
            dataGridViewClients.AllowUserToResizeRows = false;
            dataGridViewClients.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.Name = "clientCode";
            id.DataPropertyName = "ClientCode";
            id.HeaderText = "Client Code";
            id.Width = 60;
            id.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            id.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(id);


            DataGridViewTextBoxColumn companyN = new DataGridViewTextBoxColumn();
            companyN.Name = "companyName";
            companyN.DataPropertyName = "CompanyName";
            companyN.HeaderText = "Company Name";
            companyN.Width = 100;
            companyN.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            companyN.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            companyN.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(companyN);


            DataGridViewTextBoxColumn add1 = new DataGridViewTextBoxColumn();
            add1.Name = "address1";
            add1.DataPropertyName = "Address1";
            add1.HeaderText = "Address 1";
            add1.Width = 100;
            add1.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            add1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            add1.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(add1);


            DataGridViewTextBoxColumn add2 = new DataGridViewTextBoxColumn();
            add2.Name = "address2";
            add2.DataPropertyName = "Address2";
            add2.HeaderText = "Address 2";
            add2.Width = 55;
            add2.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            add2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            add2.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(add2);


            DataGridViewTextBoxColumn city = new DataGridViewTextBoxColumn();
            city.Name = "city";
            city.DataPropertyName = "City";
            city.HeaderText = "City";
            city.Width = 55;
            city.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            city.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            city.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(city);

            DataGridViewTextBoxColumn province = new DataGridViewTextBoxColumn();
            province.Name = "province";
            province.DataPropertyName = "Province";
            province.HeaderText = "Province";
            province.Width = 60;
            province.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            province.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            province.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(province);

            DataGridViewTextBoxColumn postalC = new DataGridViewTextBoxColumn();
            postalC.Name = "postalCode";
            postalC.DataPropertyName = "PostalCode";
            postalC.HeaderText = "Postal Code";
            postalC.Width = 60;
            postalC.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            postalC.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            postalC.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(postalC);

            DataGridViewTextBoxColumn ytdSales = new DataGridViewTextBoxColumn();
            ytdSales.Name = "ytdSales";
            ytdSales.DataPropertyName = "YTDSales";
            ytdSales.HeaderText = "YTD Sales";
            ytdSales.Width = 60;
            ytdSales.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            ytdSales.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ytdSales.DefaultCellStyle.Format = "N2";
            ytdSales.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(ytdSales);

            DataGridViewCheckBoxColumn creditH = new DataGridViewCheckBoxColumn();
            creditH.Name = "creditHold";
            creditH.DataPropertyName = "CreditHold";
            creditH.HeaderText = "Credit Hold";
            creditH.Width = 30;
            creditH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            creditH.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(creditH);

            DataGridViewTextBoxColumn notes = new DataGridViewTextBoxColumn();
            notes.Name = "notes";
            notes.DataPropertyName = "Notes";
            notes.HeaderText = "Notes";
            notes.Width = 90;
            notes.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            notes.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(notes);
        }
        //hold the information from the row selected
        private void dataGridViewClients_SelectionChanged(object sender, EventArgs e)
        {
            int index = dataGridViewClients.CurrentRow.Index;

            Client client = clientVM.Clients[index];
            clientVM.SetDisplayClient(client);
        }
        //shows a dialog form and sends to it the information of the row selected
        private void buttonEditRecord_Click(object sender, EventArgs e)
        {
            EditDialog dig = new EditDialog();
            dig.ClientVM = this.clientVM;
            DialogResult result = dig.ShowDialog();
            if(result == DialogResult.OK)
            {
                int index = dataGridViewClients.CurrentRow.Index;
                Client client = clientVM.GetDisplayClient();
                clientVM.Clients[index] = client;
            }
            dig.Dispose();
        }
    }
}
