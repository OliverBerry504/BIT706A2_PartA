
namespace BIT706_A3_OliverBerry
{
    partial class ManageAccountsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.selectAcc = new System.Windows.Forms.ComboBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnAddInterest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDeposit
            // 
            this.BtnDeposit.Location = new System.Drawing.Point(35, 142);
            this.BtnDeposit.Name = "BtnDeposit";
            this.BtnDeposit.Size = new System.Drawing.Size(107, 23);
            this.BtnDeposit.TabIndex = 0;
            this.BtnDeposit.Text = "Deposit";
            this.BtnDeposit.UseVisualStyleBackColor = true;
            this.BtnDeposit.Click += new System.EventHandler(this.BtnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(148, 142);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(104, 23);
            this.btnWithdraw.TabIndex = 4;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.BtnWithdraw_Click);
            // 
            // selectAcc
            // 
            this.selectAcc.FormattingEnabled = true;
            this.selectAcc.Location = new System.Drawing.Point(131, 56);
            this.selectAcc.Name = "selectAcc";
            this.selectAcc.Size = new System.Drawing.Size(121, 23);
            this.selectAcc.TabIndex = 5;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(131, 100);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(121, 23);
            this.textBoxAmount.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount NZD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select account";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(35, 204);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(0, 15);
            this.lbInfo.TabIndex = 8;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(35, 171);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(107, 23);
            this.btnInfo.TabIndex = 9;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // btnAddInterest
            // 
            this.btnAddInterest.Location = new System.Drawing.Point(149, 171);
            this.btnAddInterest.Name = "btnAddInterest";
            this.btnAddInterest.Size = new System.Drawing.Size(103, 23);
            this.btnAddInterest.TabIndex = 10;
            this.btnAddInterest.Text = "Add Interest";
            this.btnAddInterest.UseVisualStyleBackColor = true;
            this.btnAddInterest.Click += new System.EventHandler(this.BtnAddInterest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 247);
            this.Controls.Add(this.btnAddInterest);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectAcc);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.BtnDeposit);
            this.Name = "Form1";
            this.Controls.SetChildIndex(this.BtnDeposit, 0);
            this.Controls.SetChildIndex(this.btnWithdraw, 0);
            this.Controls.SetChildIndex(this.selectAcc, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBoxAmount, 0);
            this.Controls.SetChildIndex(this.lbInfo, 0);
            this.Controls.SetChildIndex(this.btnInfo, 0);
            this.Controls.SetChildIndex(this.btnAddInterest, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.ComboBox selectAcc;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnAddInterest;
    }
}

