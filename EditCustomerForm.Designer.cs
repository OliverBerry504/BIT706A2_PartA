
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.lbInput = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbEdit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(25, 75);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(117, 23);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbInput.Location = new System.Drawing.Point(25, 41);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(82, 15);
            this.lbInput.TabIndex = 7;
            this.lbInput.Text = "Edit Customer";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(148, 75);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // tbEdit
            // 
            this.tbEdit.Location = new System.Drawing.Point(115, 38);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Size = new System.Drawing.Size(148, 23);
            this.tbEdit.TabIndex = 5;
            // 
            // EditCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 136);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lbInput);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbEdit);
            this.Name = "EditCustomerForm";
            this.Text = "EditCustomerForm";
            this.Controls.SetChildIndex(this.tbEdit, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.lbInput, 0);
            this.Controls.SetChildIndex(this.btnReturn, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbEdit;
    }
}