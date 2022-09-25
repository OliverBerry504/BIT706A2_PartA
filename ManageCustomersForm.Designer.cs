
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.tb_find = new System.Windows.Forms.TextBox();
            this.btn_find = new System.Windows.Forms.Button();
            this.lst_all_cust = new System.Windows.Forms.ListBox();
            this.btn_main_menu = new System.Windows.Forms.Button();
            this.lb_cust_details = new System.Windows.Forms.Label();
            this.btn_mng_accs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(46, 76);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(151, 25);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "New Customer";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(46, 139);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(151, 25);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Delete Selection";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(46, 107);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(151, 26);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit Selection";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // tb_find
            // 
            this.tb_find.Location = new System.Drawing.Point(46, 41);
            this.tb_find.Name = "tb_find";
            this.tb_find.Size = new System.Drawing.Size(51, 23);
            this.tb_find.TabIndex = 3;
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(103, 39);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(94, 25);
            this.btn_find.TabIndex = 4;
            this.btn_find.Text = "Find by ID";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // lst_all_cust
            // 
            this.lst_all_cust.FormattingEnabled = true;
            this.lst_all_cust.ItemHeight = 15;
            this.lst_all_cust.Location = new System.Drawing.Point(214, 41);
            this.lst_all_cust.Name = "lst_all_cust";
            this.lst_all_cust.Size = new System.Drawing.Size(157, 184);
            this.lst_all_cust.TabIndex = 6;
            // 
            // btn_main_menu
            // 
            this.btn_main_menu.Location = new System.Drawing.Point(46, 201);
            this.btn_main_menu.Name = "btn_main_menu";
            this.btn_main_menu.Size = new System.Drawing.Size(151, 25);
            this.btn_main_menu.TabIndex = 7;
            this.btn_main_menu.Text = "Main Menu";
            this.btn_main_menu.UseVisualStyleBackColor = true;
            this.btn_main_menu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // lb_cust_details
            // 
            this.lb_cust_details.AutoSize = true;
            this.lb_cust_details.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lb_cust_details.Location = new System.Drawing.Point(268, 23);
            this.lb_cust_details.Name = "lb_cust_details";
            this.lb_cust_details.Size = new System.Drawing.Size(0, 15);
            this.lb_cust_details.TabIndex = 5;
            // 
            // btn_mng_accs
            // 
            this.btn_mng_accs.Location = new System.Drawing.Point(46, 170);
            this.btn_mng_accs.Name = "btn_mng_accs";
            this.btn_mng_accs.Size = new System.Drawing.Size(151, 25);
            this.btn_mng_accs.TabIndex = 8;
            this.btn_mng_accs.Text = "Manage  Accounts";
            this.btn_mng_accs.UseVisualStyleBackColor = true;
            this.btn_mng_accs.Click += new System.EventHandler(this.Btn_mng_accs_Click);
            // 
            // ManageCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 248);
            this.Controls.Add(this.btn_mng_accs);
            this.Controls.Add(this.btn_main_menu);
            this.Controls.Add(this.lst_all_cust);
            this.Controls.Add(this.lb_cust_details);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.tb_find);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Name = "ManageCustomersForm";
            this.Text = "Manage";
            this.Controls.SetChildIndex(this.btn_add, 0);
            this.Controls.SetChildIndex(this.btn_delete, 0);
            this.Controls.SetChildIndex(this.btn_edit, 0);
            this.Controls.SetChildIndex(this.tb_find, 0);
            this.Controls.SetChildIndex(this.btn_find, 0);
            this.Controls.SetChildIndex(this.lb_cust_details, 0);
            this.Controls.SetChildIndex(this.lst_all_cust, 0);
            this.Controls.SetChildIndex(this.btn_main_menu, 0);
            this.Controls.SetChildIndex(this.btn_mng_accs, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox tb_find;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.ListBox lst_all_cust;
        private System.Windows.Forms.Button btn_main_menu;
        private System.Windows.Forms.Label lb_cust_details;
        private System.Windows.Forms.Button btn_mng_accs;
    }
}