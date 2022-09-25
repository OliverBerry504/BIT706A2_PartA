
namespace BIT706_A3_OliverBerry
{
    partial class SelectAccountForm
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
            this.rb_Everyday = new System.Windows.Forms.RadioButton();
            this.rb_Investment = new System.Windows.Forms.RadioButton();
            this.rb_Omni = new System.Windows.Forms.RadioButton();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rb_Everyday
            // 
            this.rb_Everyday.AutoSize = true;
            this.rb_Everyday.Location = new System.Drawing.Point(49, 39);
            this.rb_Everyday.Name = "rb_Everyday";
            this.rb_Everyday.Size = new System.Drawing.Size(72, 19);
            this.rb_Everyday.TabIndex = 1;
            this.rb_Everyday.TabStop = true;
            this.rb_Everyday.Text = "Everyday";
            this.rb_Everyday.UseVisualStyleBackColor = true;
            // 
            // rb_Investment
            // 
            this.rb_Investment.AutoSize = true;
            this.rb_Investment.Location = new System.Drawing.Point(49, 64);
            this.rb_Investment.Name = "rb_Investment";
            this.rb_Investment.Size = new System.Drawing.Size(84, 19);
            this.rb_Investment.TabIndex = 2;
            this.rb_Investment.TabStop = true;
            this.rb_Investment.Text = "Investment";
            this.rb_Investment.UseVisualStyleBackColor = true;
            // 
            // rb_Omni
            // 
            this.rb_Omni.AutoSize = true;
            this.rb_Omni.Location = new System.Drawing.Point(49, 89);
            this.rb_Omni.Name = "rb_Omni";
            this.rb_Omni.Size = new System.Drawing.Size(55, 19);
            this.rb_Omni.TabIndex = 3;
            this.rb_Omni.TabStop = true;
            this.rb_Omni.Text = "Omni";
            this.rb_Omni.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(49, 123);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(130, 123);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 5;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.Btn_create_Click);
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 172);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.rb_Omni);
            this.Controls.Add(this.rb_Investment);
            this.Controls.Add(this.rb_Everyday);
            this.Name = "CreateAccountForm";
            this.Text = "CreateAccountForm";
            this.Controls.SetChildIndex(this.rb_Everyday, 0);
            this.Controls.SetChildIndex(this.rb_Investment, 0);
            this.Controls.SetChildIndex(this.rb_Omni, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.btn_create, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_Everyday;
        private System.Windows.Forms.RadioButton rb_Investment;
        private System.Windows.Forms.RadioButton rb_Omni;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_create;
    }
}