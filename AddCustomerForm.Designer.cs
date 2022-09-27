
namespace BIT706_A3_OliverBerry
{
    partial class AddCustomerForm
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
            this.tb_add = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lb_input = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_add
            // 
            this.tb_add.Location = new System.Drawing.Point(111, 39);
            this.tb_add.Name = "tb_add";
            this.tb_add.Size = new System.Drawing.Size(148, 23);
            this.tb_add.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(144, 77);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(115, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Submit";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // lb_input
            // 
            this.lb_input.AutoSize = true;
            this.lb_input.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lb_input.Location = new System.Drawing.Point(21, 42);
            this.lb_input.Name = "lb_input";
            this.lb_input.Size = new System.Drawing.Size(84, 15);
            this.lb_input.TabIndex = 3;
            this.lb_input.Text = "Add Customer";
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(21, 77);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(117, 23);
            this.btn_return.TabIndex = 4;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 136);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.lb_input);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_add);
            this.Name = "AddCustomerForm";
            this.Text = "AddCustomerForm";
            this.Controls.SetChildIndex(this.tb_add, 0);
            this.Controls.SetChildIndex(this.btn_add, 0);
            this.Controls.SetChildIndex(this.lb_input, 0);
            this.Controls.SetChildIndex(this.btn_return, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_add;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lb_input;
        private System.Windows.Forms.Button btn_return;
    }
}