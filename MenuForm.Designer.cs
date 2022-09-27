
namespace BIT706_A3_OliverBerry
{
    partial class MenuForm
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
            this.btn_mng_cst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mng_cst
            // 
            this.btn_mng_cst.Location = new System.Drawing.Point(49, 71);
            this.btn_mng_cst.Name = "btn_mng_cst";
            this.btn_mng_cst.Size = new System.Drawing.Size(144, 23);
            this.btn_mng_cst.TabIndex = 0;
            this.btn_mng_cst.Text = "Load Customer Data";
            this.btn_mng_cst.UseVisualStyleBackColor = true;
            this.btn_mng_cst.Click += new System.EventHandler(this.Btn_mng_cst_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 154);
            this.Controls.Add(this.btn_mng_cst);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Controls.SetChildIndex(this.btn_mng_cst, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mng_cst;
    }
}