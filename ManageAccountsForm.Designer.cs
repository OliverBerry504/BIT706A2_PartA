
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
            this.btn_deposit = new System.Windows.Forms.Button();
            this.btn_withdraw = new System.Windows.Forms.Button();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.lb_amount_nzd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_info = new System.Windows.Forms.Label();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_add_Interest = new System.Windows.Forms.Button();
            this.lst_all_accs = new System.Windows.Forms.ListBox();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_transfer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_deposit
            // 
            this.btn_deposit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_deposit.Location = new System.Drawing.Point(24, 195);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(157, 23);
            this.btn_deposit.TabIndex = 0;
            this.btn_deposit.Text = "Deposit";
            this.btn_deposit.UseVisualStyleBackColor = true;
            this.btn_deposit.Click += new System.EventHandler(this.Btn_deposit_Click);
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_withdraw.Location = new System.Drawing.Point(24, 224);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Size = new System.Drawing.Size(157, 23);
            this.btn_withdraw.TabIndex = 4;
            this.btn_withdraw.Text = "Withdraw";
            this.btn_withdraw.UseVisualStyleBackColor = true;
            this.btn_withdraw.Click += new System.EventHandler(this.Btn_withdraw_Click);
            // 
            // tb_amount
            // 
            this.tb_amount.Location = new System.Drawing.Point(106, 137);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Size = new System.Drawing.Size(75, 23);
            this.tb_amount.TabIndex = 7;
            // 
            // lb_amount_nzd
            // 
            this.lb_amount_nzd.AutoSize = true;
            this.lb_amount_nzd.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_amount_nzd.Location = new System.Drawing.Point(25, 142);
            this.lb_amount_nzd.Name = "lb_amount_nzd";
            this.lb_amount_nzd.Size = new System.Drawing.Size(78, 15);
            this.lb_amount_nzd.TabIndex = 6;
            this.lb_amount_nzd.Text = "Amount NZD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select account";
            // 
            // lb_info
            // 
            this.lb_info.AutoSize = true;
            this.lb_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_info.Location = new System.Drawing.Point(3, 5);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(0, 15);
            this.lb_info.TabIndex = 8;
            // 
            // btn_info
            // 
            this.btn_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_info.Location = new System.Drawing.Point(190, 108);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(165, 23);
            this.btn_info.TabIndex = 9;
            this.btn_info.Text = "Account Info";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.Btn_info_Click);
            // 
            // btn_add_Interest
            // 
            this.btn_add_Interest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_add_Interest.Location = new System.Drawing.Point(190, 79);
            this.btn_add_Interest.Name = "btn_add_Interest";
            this.btn_add_Interest.Size = new System.Drawing.Size(165, 23);
            this.btn_add_Interest.TabIndex = 10;
            this.btn_add_Interest.Text = "Add Interest";
            this.btn_add_Interest.UseVisualStyleBackColor = true;
            this.btn_add_Interest.Click += new System.EventHandler(this.Btn_add_interest_Click);
            // 
            // lst_all_accs
            // 
            this.lst_all_accs.FormattingEnabled = true;
            this.lst_all_accs.ItemHeight = 15;
            this.lst_all_accs.Location = new System.Drawing.Point(24, 52);
            this.lst_all_accs.Name = "lst_all_accs";
            this.lst_all_accs.Size = new System.Drawing.Size(157, 79);
            this.lst_all_accs.TabIndex = 11;
            // 
            // btn_return
            // 
            this.btn_return.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_return.Location = new System.Drawing.Point(24, 253);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(157, 23);
            this.btn_return.TabIndex = 12;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.Btn_return_Click);
            // 
            // btn_create
            // 
            this.btn_create.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_create.Location = new System.Drawing.Point(24, 166);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(157, 23);
            this.btn_create.TabIndex = 14;
            this.btn_create.Text = "Create Account";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.Btn_create_Click);
            // 
            // btn_transfer
            // 
            this.btn_transfer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_transfer.Location = new System.Drawing.Point(190, 52);
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.Size = new System.Drawing.Size(165, 23);
            this.btn_transfer.TabIndex = 16;
            this.btn_transfer.Text = "Transfer";
            this.btn_transfer.UseVisualStyleBackColor = true;
            this.btn_transfer.Click += new System.EventHandler(this.Btn_transfer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lb_info);
            this.panel1.Location = new System.Drawing.Point(190, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 136);
            this.panel1.TabIndex = 17;
            // 
            // ManageAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 290);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_transfer);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.lst_all_accs);
            this.Controls.Add(this.btn_add_Interest);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.tb_amount);
            this.Controls.Add(this.lb_amount_nzd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_withdraw);
            this.Controls.Add(this.btn_deposit);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "ManageAccountsForm";
            this.Controls.SetChildIndex(this.btn_deposit, 0);
            this.Controls.SetChildIndex(this.btn_withdraw, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lb_amount_nzd, 0);
            this.Controls.SetChildIndex(this.tb_amount, 0);
            this.Controls.SetChildIndex(this.btn_info, 0);
            this.Controls.SetChildIndex(this.btn_add_Interest, 0);
            this.Controls.SetChildIndex(this.lst_all_accs, 0);
            this.Controls.SetChildIndex(this.btn_return, 0);
            this.Controls.SetChildIndex(this.btn_create, 0);
            this.Controls.SetChildIndex(this.btn_transfer, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_deposit;
        private System.Windows.Forms.Button btn_withdraw;
        private System.Windows.Forms.TextBox tb_amount;
        private System.Windows.Forms.Label lb_amount_nzd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_info;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_add_Interest;
        private System.Windows.Forms.ListBox lst_all_accs;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_transfer;
        private System.Windows.Forms.Panel panel1;
    }
}

