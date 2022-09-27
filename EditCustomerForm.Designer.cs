
namespace BIT706_A3_OliverBerry
{
    partial class EditCustomerForm
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
            this.btn_return = new System.Windows.Forms.Button();
            this.lb_input = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.tb_edit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(25, 75);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(117, 23);
            this.btn_return.TabIndex = 8;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.Btn_return_Click);
            // 
            // lb_input
            // 
            this.lb_input.AutoSize = true;
            this.lb_input.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lb_input.Location = new System.Drawing.Point(25, 41);
            this.lb_input.Name = "lb_input";
            this.lb_input.Size = new System.Drawing.Size(82, 15);
            this.lb_input.TabIndex = 7;
            this.lb_input.Text = "Edit Customer";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(148, 75);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(115, 23);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
            // 
            // tb_edit
            // 
            this.tb_edit.Location = new System.Drawing.Point(115, 38);
            this.tb_edit.Name = "tb_edit";
            this.tb_edit.Size = new System.Drawing.Size(148, 23);
            this.tb_edit.TabIndex = 5;
            // 
            // EditCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 136);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.lb_input);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.tb_edit);
            this.Name = "EditCustomerForm";
            this.Text = "EditCustomerForm";
            this.Controls.SetChildIndex(this.tb_edit, 0);
            this.Controls.SetChildIndex(this.btn_edit, 0);
            this.Controls.SetChildIndex(this.lb_input, 0);
            this.Controls.SetChildIndex(this.btn_return, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Label lb_input;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox tb_edit;
    }
}