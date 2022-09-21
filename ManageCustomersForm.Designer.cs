
namespace BIT706_A3_OliverBerry
{
    partial class ManageCustomersForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lstAllCst = new System.Windows.Forms.ListBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.lbCstDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(46, 139);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 25);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "New Customer";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(46, 76);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(151, 25);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Selection";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(46, 107);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(151, 26);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit Selection";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(46, 41);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(51, 23);
            this.tbFind.TabIndex = 3;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(103, 39);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(94, 25);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find by ID";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // lstAllCst
            // 
            this.lstAllCst.FormattingEnabled = true;
            this.lstAllCst.ItemHeight = 15;
            this.lstAllCst.Location = new System.Drawing.Point(214, 41);
            this.lstAllCst.Name = "lstAllCst";
            this.lstAllCst.Size = new System.Drawing.Size(157, 154);
            this.lstAllCst.TabIndex = 6;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(46, 170);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(151, 25);
            this.btnMainMenu.TabIndex = 7;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // lbCstDetails
            // 
            this.lbCstDetails.AutoSize = true;
            this.lbCstDetails.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbCstDetails.Location = new System.Drawing.Point(268, 23);
            this.lbCstDetails.Name = "lbCstDetails";
            this.lbCstDetails.Size = new System.Drawing.Size(0, 15);
            this.lbCstDetails.TabIndex = 5;
            // 
            // ManageCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 231);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.lstAllCst);
            this.Controls.Add(this.lbCstDetails);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "ManageCustomersForm";
            this.Text = "Manage";
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.tbFind, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.lbCstDetails, 0);
            this.Controls.SetChildIndex(this.lstAllCst, 0);
            this.Controls.SetChildIndex(this.btnMainMenu, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ListBox lstAllCst;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label lbCstDetails;
    }
}