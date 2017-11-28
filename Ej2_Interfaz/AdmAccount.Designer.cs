namespace Ej2_Interfaz
{
    partial class AdmAccount
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
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bAddMov = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_IdClient = new System.Windows.Forms.Label();
            this.l_IdAccount = new System.Windows.Forms.Label();
            this.bShowLastMov = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(139, 124);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(175, 20);
            this.tbAmount.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Amount";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(139, 87);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(175, 20);
            this.tbDescription.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Description";
            // 
            // bAddMov
            // 
            this.bAddMov.Location = new System.Drawing.Point(165, 176);
            this.bAddMov.Name = "bAddMov";
            this.bAddMov.Size = new System.Drawing.Size(98, 23);
            this.bAddMov.TabIndex = 24;
            this.bAddMov.Text = "Add Movement";
            this.bAddMov.UseVisualStyleBackColor = true;
            this.bAddMov.Click += new System.EventHandler(this.bAddMov_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "IdCliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "idAccount:";
            // 
            // l_IdClient
            // 
            this.l_IdClient.AutoSize = true;
            this.l_IdClient.Location = new System.Drawing.Point(83, 9);
            this.l_IdClient.Name = "l_IdClient";
            this.l_IdClient.Size = new System.Drawing.Size(0, 13);
            this.l_IdClient.TabIndex = 31;
            // 
            // l_IdAccount
            // 
            this.l_IdAccount.AutoSize = true;
            this.l_IdAccount.Location = new System.Drawing.Point(83, 41);
            this.l_IdAccount.Name = "l_IdAccount";
            this.l_IdAccount.Size = new System.Drawing.Size(0, 13);
            this.l_IdAccount.TabIndex = 32;
            // 
            // bShowLastMov
            // 
            this.bShowLastMov.Location = new System.Drawing.Point(698, 204);
            this.bShowLastMov.Name = "bShowLastMov";
            this.bShowLastMov.Size = new System.Drawing.Size(131, 23);
            this.bShowLastMov.TabIndex = 33;
            this.bShowLastMov.Text = "Show Last Movements";
            this.bShowLastMov.UseVisualStyleBackColor = true;
            this.bShowLastMov.Click += new System.EventHandler(this.bShowLastMov_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(392, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(437, 167);
            this.dataGridView1.TabIndex = 34;
            // 
            // AdmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 239);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bShowLastMov);
            this.Controls.Add(this.l_IdAccount);
            this.Controls.Add(this.l_IdClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bAddMov);
            this.Name = "AdmAccount";
            this.Text = "AdmAccount";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bAddMov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_IdClient;
        private System.Windows.Forms.Label l_IdAccount;
        private System.Windows.Forms.Button bShowLastMov;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}