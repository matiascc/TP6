namespace Ej2_Interfaz
{
    partial class AdmClient
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
            this.tbOverdraftLimit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bAddAccount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbAccounts = new System.Windows.Forms.ComboBox();
            this.bConfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.l_Id = new System.Windows.Forms.Label();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.bInfoCuentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOverdraftLimit
            // 
            this.tbOverdraftLimit.Location = new System.Drawing.Point(131, 152);
            this.tbOverdraftLimit.Name = "tbOverdraftLimit";
            this.tbOverdraftLimit.Size = new System.Drawing.Size(175, 20);
            this.tbOverdraftLimit.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "OverdraftLimit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select an Account";
            // 
            // bAddAccount
            // 
            this.bAddAccount.Location = new System.Drawing.Point(169, 199);
            this.bAddAccount.Name = "bAddAccount";
            this.bAddAccount.Size = new System.Drawing.Size(98, 23);
            this.bAddAccount.TabIndex = 16;
            this.bAddAccount.Text = "Add Account";
            this.bAddAccount.UseVisualStyleBackColor = true;
            this.bAddAccount.Click += new System.EventHandler(this.bAddAccount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(131, 115);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(175, 20);
            this.tbName.TabIndex = 21;
            // 
            // cbAccounts
            // 
            this.cbAccounts.FormattingEnabled = true;
            this.cbAccounts.Location = new System.Drawing.Point(131, 57);
            this.cbAccounts.Name = "cbAccounts";
            this.cbAccounts.Size = new System.Drawing.Size(175, 21);
            this.cbAccounts.TabIndex = 24;
            // 
            // bConfirm
            // 
            this.bConfirm.Location = new System.Drawing.Point(351, 55);
            this.bConfirm.Name = "bConfirm";
            this.bConfirm.Size = new System.Drawing.Size(75, 23);
            this.bConfirm.TabIndex = 25;
            this.bConfirm.Text = "Confirm";
            this.bConfirm.UseVisualStyleBackColor = true;
            this.bConfirm.Click += new System.EventHandler(this.bConfirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Id:";
            // 
            // l_Id
            // 
            this.l_Id.AutoSize = true;
            this.l_Id.Location = new System.Drawing.Point(38, 13);
            this.l_Id.Name = "l_Id";
            this.l_Id.Size = new System.Drawing.Size(0, 13);
            this.l_Id.TabIndex = 27;
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Location = new System.Drawing.Point(463, 13);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.ReadOnly = true;
            this.dgvCuentas.Size = new System.Drawing.Size(357, 184);
            this.dgvCuentas.TabIndex = 28;
            // 
            // bInfoCuentas
            // 
            this.bInfoCuentas.Location = new System.Drawing.Point(745, 213);
            this.bInfoCuentas.Name = "bInfoCuentas";
            this.bInfoCuentas.Size = new System.Drawing.Size(75, 23);
            this.bInfoCuentas.TabIndex = 29;
            this.bInfoCuentas.Text = "Info Cuentas";
            this.bInfoCuentas.UseVisualStyleBackColor = true;
            this.bInfoCuentas.Click += new System.EventHandler(this.bInfoCuentas_Click);
            // 
            // AdmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 254);
            this.Controls.Add(this.bInfoCuentas);
            this.Controls.Add(this.dgvCuentas);
            this.Controls.Add(this.l_Id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bConfirm);
            this.Controls.Add(this.cbAccounts);
            this.Controls.Add(this.tbOverdraftLimit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAddAccount);
            this.Name = "AdmClient";
            this.Text = "AdmClient";
            this.Load += new System.EventHandler(this.AdmClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbOverdraftLimit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAddAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbAccounts;
        private System.Windows.Forms.Button bConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_Id;
        private System.Windows.Forms.DataGridView dgvCuentas;
        private System.Windows.Forms.Button bInfoCuentas;
    }
}