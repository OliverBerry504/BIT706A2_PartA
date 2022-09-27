
namespace BIT706_A3_OliverBerry
{
    partial class TransferForm
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
            this.lst_acc_to = new System.Windows.Forms.ListBox();
            this.btn_transfer = new System.Windows.Forms.Button();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.btn_return = new System.Windows.Forms.Button();
            this.lb_acc_to = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_acc_to
            // 
            this.lst_acc_to.FormattingEnabled = true;
            this.lst_acc_to.ItemHeight = 15;
            this.lst_acc_to.Location = new System.Drawing.Point(41, 51);
            this.lst_acc_to.Name = "lst_acc_to";
            this.lst_acc_to.Size = new System.Drawing.Size(235, 79);
            this.lst_acc_to.TabIndex = 1;
            // 
            // btn_transfer
            // 
            this.btn_transfer.Location = new System.Drawing.Point(147, 136);
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.Size = new System.Drawing.Size(129, 24);
            this.btn_transfer.TabIndex = 2;
            this.btn_transfer.Text = "Transfer";
            this.btn_transfer.UseVisualStyleBackColor = true;
            this.btn_transfer.Click += new System.EventHandler(this.Btn_transfer_Click);
            // 
            // tb_amount
            // 
            this.tb_amount.Location = new System.Drawing.Point(41, 137);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Size = new System.Drawing.Size(100, 23);
            this.tb_amount.TabIndex = 3;
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(41, 166);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(100, 23);
            this.btn_return.TabIndex = 4;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.Btn_return_Click);
            // 
            // lb_acc_to
            // 
            this.lb_acc_to.AutoSize = true;
            this.lb_acc_to.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_acc_to.Location = new System.Drawing.Point(41, 29);
            this.lb_acc_to.Name = "lb_acc_to";
            this.lb_acc_to.Size = new System.Drawing.Size(165, 15);
            this.lb_acc_to.TabIndex = 5;
            this.lb_acc_to.Text = "Select account to transfer too:";
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 206);
            this.Controls.Add(this.lb_acc_to);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.tb_amount);
            this.Controls.Add(this.btn_transfer);
            this.Controls.Add(this.lst_acc_to);
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.Controls.SetChildIndex(this.lst_acc_to, 0);
            this.Controls.SetChildIndex(this.btn_transfer, 0);
            this.Controls.SetChildIndex(this.tb_amount, 0);
            this.Controls.SetChildIndex(this.btn_return, 0);
            this.Controls.SetChildIndex(this.lb_acc_to, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_acc_to;
        private System.Windows.Forms.Button btn_transfer;
        private System.Windows.Forms.TextBox tb_amount;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Label lb_acc_to;
    }
}