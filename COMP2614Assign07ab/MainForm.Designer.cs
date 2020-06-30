namespace COMP2614Assign07ab
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelSku = new System.Windows.Forms.Label();
            this.textBoxSKU = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.labelExtension = new System.Windows.Forms.Label();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.checkBoxTaxable = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(37, 32);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(49, 13);
            this.labelQuantity.TabIndex = 0;
            this.labelQuantity.Text = "&Quantity:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(110, 29);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 1;
            // 
            // labelSku
            // 
            this.labelSku.AutoSize = true;
            this.labelSku.Location = new System.Drawing.Point(37, 68);
            this.labelSku.Name = "labelSku";
            this.labelSku.Size = new System.Drawing.Size(32, 13);
            this.labelSku.TabIndex = 2;
            this.labelSku.Text = "&SKU:";
            // 
            // textBoxSKU
            // 
            this.textBoxSKU.Location = new System.Drawing.Point(110, 65);
            this.textBoxSKU.Name = "textBoxSKU";
            this.textBoxSKU.Size = new System.Drawing.Size(100, 20);
            this.textBoxSKU.TabIndex = 3;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(37, 102);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "&Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(110, 99);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescription.TabIndex = 5;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(37, 136);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(31, 13);
            this.labelCost.TabIndex = 6;
            this.labelCost.Text = "&Cost:";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(110, 133);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxCost.TabIndex = 7;
            // 
            // labelExtension
            // 
            this.labelExtension.AutoSize = true;
            this.labelExtension.Location = new System.Drawing.Point(37, 171);
            this.labelExtension.Name = "labelExtension";
            this.labelExtension.Size = new System.Drawing.Size(56, 13);
            this.labelExtension.TabIndex = 8;
            this.labelExtension.Text = "&Extension:";
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.Location = new System.Drawing.Point(110, 168);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(100, 20);
            this.textBoxExtension.TabIndex = 9;
            // 
            // checkBoxTaxable
            // 
            this.checkBoxTaxable.AutoSize = true;
            this.checkBoxTaxable.Location = new System.Drawing.Point(40, 216);
            this.checkBoxTaxable.Name = "checkBoxTaxable";
            this.checkBoxTaxable.Size = new System.Drawing.Size(64, 17);
            this.checkBoxTaxable.TabIndex = 10;
            this.checkBoxTaxable.Text = "&Taxable";
            this.checkBoxTaxable.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(135, 210);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Sa&ve";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(596, 169);
            this.dataGridView1.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxTaxable);
            this.Controls.Add(this.textBoxExtension);
            this.Controls.Add(this.labelExtension);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxSKU);
            this.Controls.Add(this.labelSku);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelSku;
        private System.Windows.Forms.TextBox textBoxSKU;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label labelExtension;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.CheckBox checkBoxTaxable;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

