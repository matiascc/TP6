namespace Ej2_Interfaz
{
    partial class Form1
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
            this.bSearchClientId = new System.Windows.Forms.Button();
            this.bAddClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIdForSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDocNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.cbDocType = new System.Windows.Forms.ComboBox();
            this.bSearchClientNumDoc = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bAccountsDebt = new System.Windows.Forms.Button();
            this.dgvAccountsDebt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountsDebt)).BeginInit();
            this.SuspendLayout();
            // 
            // bSearchClientId
            // 
            this.bSearchClientId.Location = new System.Drawing.Point(272, 22);
            this.bSearchClientId.Name = "bSearchClientId";
            this.bSearchClientId.Size = new System.Drawing.Size(96, 23);
            this.bSearchClientId.TabIndex = 0;
            this.bSearchClientId.Text = "Search Client";
            this.bSearchClientId.UseVisualStyleBackColor = true;
            this.bSearchClientId.Click += new System.EventHandler(this.bSearchClientId_Click);
            // 
            // bAddClient
            // 
            this.bAddClient.Location = new System.Drawing.Point(179, 289);
            this.bAddClient.Name = "bAddClient";
            this.bAddClient.Size = new System.Drawing.Size(75, 23);
            this.bAddClient.TabIndex = 1;
            this.bAddClient.Text = "Add Client";
            this.bAddClient.UseVisualStyleBackColor = true;
            this.bAddClient.Click += new System.EventHandler(this.bAddClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // tbIdForSearch
            // 
            this.tbIdForSearch.Location = new System.Drawing.Point(100, 24);
            this.tbIdForSearch.Name = "tbIdForSearch";
            this.tbIdForSearch.Size = new System.Drawing.Size(156, 20);
            this.tbIdForSearch.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "DocumentType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DocumentNumber";
            // 
            // tbDocNum
            // 
            this.tbDocNum.Location = new System.Drawing.Point(132, 174);
            this.tbDocNum.Name = "tbDocNum";
            this.tbDocNum.Size = new System.Drawing.Size(175, 20);
            this.tbDocNum.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "FirstName";
            // 
            // tbFName
            // 
            this.tbFName.Location = new System.Drawing.Point(132, 211);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(175, 20);
            this.tbFName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "LastName";
            // 
            // tbLName
            // 
            this.tbLName.Location = new System.Drawing.Point(132, 246);
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(175, 20);
            this.tbLName.TabIndex = 11;
            // 
            // cbDocType
            // 
            this.cbDocType.FormattingEnabled = true;
            this.cbDocType.Location = new System.Drawing.Point(132, 131);
            this.cbDocType.Name = "cbDocType";
            this.cbDocType.Size = new System.Drawing.Size(175, 21);
            this.cbDocType.TabIndex = 14;
            // 
            // bSearchClientNumDoc
            // 
            this.bSearchClientNumDoc.Location = new System.Drawing.Point(272, 62);
            this.bSearchClientNumDoc.Name = "bSearchClientNumDoc";
            this.bSearchClientNumDoc.Size = new System.Drawing.Size(96, 23);
            this.bSearchClientNumDoc.TabIndex = 15;
            this.bSearchClientNumDoc.Text = "Search Client";
            this.bSearchClientNumDoc.UseVisualStyleBackColor = true;
            this.bSearchClientNumDoc.Click += new System.EventHandler(this.bSearchClientNumDoc_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "NumDoc";
            // 
            // bAccountsDebt
            // 
            this.bAccountsDebt.Location = new System.Drawing.Point(686, 289);
            this.bAccountsDebt.Name = "bAccountsDebt";
            this.bAccountsDebt.Size = new System.Drawing.Size(121, 23);
            this.bAccountsDebt.TabIndex = 18;
            this.bAccountsDebt.Text = "Accounts with Debt";
            this.bAccountsDebt.UseVisualStyleBackColor = true;
            this.bAccountsDebt.Click += new System.EventHandler(this.bAccountsDebt_Click);
            // 
            // dgvAccountsDebt
            // 
            this.dgvAccountsDebt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountsDebt.Location = new System.Drawing.Point(412, 22);
            this.dgvAccountsDebt.Name = "dgvAccountsDebt";
            this.dgvAccountsDebt.ReadOnly = true;
            this.dgvAccountsDebt.Size = new System.Drawing.Size(395, 244);
            this.dgvAccountsDebt.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 330);
            this.Controls.Add(this.dgvAccountsDebt);
            this.Controls.Add(this.bAccountsDebt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bSearchClientNumDoc);
            this.Controls.Add(this.cbDocType);
            this.Controls.Add(this.tbLName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbFName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDocNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIdForSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAddClient);
            this.Controls.Add(this.bSearchClientId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountsDebt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSearchClientId;
        private System.Windows.Forms.Button bAddClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIdForSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDocNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.ComboBox cbDocType;
        private System.Windows.Forms.Button bSearchClientNumDoc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bAccountsDebt;
        private System.Windows.Forms.DataGridView dgvAccountsDebt;
    }
}

