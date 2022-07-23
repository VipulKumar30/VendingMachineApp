namespace VendingMachineApp
{
    partial class Form1
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
            this.cmb_products = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_RemoveAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_totalAmt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView_products = new System.Windows.Forms.ListView();
            this.col1 = new System.Windows.Forms.ColumnHeader();
            this.col2 = new System.Windows.Forms.ColumnHeader();
            this.col3 = new System.Windows.Forms.ColumnHeader();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_products
            // 
            this.cmb_products.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_products.FormattingEnabled = true;
            this.cmb_products.Location = new System.Drawing.Point(62, 59);
            this.cmb_products.Name = "cmb_products";
            this.cmb_products.Size = new System.Drawing.Size(216, 28);
            this.cmb_products.TabIndex = 0;
            this.cmb_products.SelectedIndexChanged += new System.EventHandler(this.cmb_products_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(675, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selected Products";
            // 
            // btn_RemoveAll
            // 
            this.btn_RemoveAll.Location = new System.Drawing.Point(386, 59);
            this.btn_RemoveAll.Name = "btn_RemoveAll";
            this.btn_RemoveAll.Size = new System.Drawing.Size(110, 45);
            this.btn_RemoveAll.TabIndex = 7;
            this.btn_RemoveAll.Text = "Clear";
            this.btn_RemoveAll.UseVisualStyleBackColor = true;
            this.btn_RemoveAll.Click += new System.EventHandler(this.btn_RemoveAll_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_totalAmt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(675, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 208);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total";
            // 
            // lbl_totalAmt
            // 
            this.lbl_totalAmt.AutoSize = true;
            this.lbl_totalAmt.Location = new System.Drawing.Point(78, 38);
            this.lbl_totalAmt.Name = "lbl_totalAmt";
            this.lbl_totalAmt.Size = new System.Drawing.Size(17, 20);
            this.lbl_totalAmt.TabIndex = 3;
            this.lbl_totalAmt.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total :";
            // 
            // listView_products
            // 
            this.listView_products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col1,
            this.col2,
            this.col3});
            this.listView_products.HideSelection = false;
            this.listView_products.Location = new System.Drawing.Point(675, 59);
            this.listView_products.Name = "listView_products";
            this.listView_products.Size = new System.Drawing.Size(282, 264);
            this.listView_products.TabIndex = 10;
            this.listView_products.UseCompatibleStateImageBehavior = false;
            this.listView_products.View = System.Windows.Forms.View.Details;
            // 
            // col1
            // 
            this.col1.Text = "Items";
            this.col1.Width = 200;
            // 
            // col2
            // 
            this.col2.Text = "Count";
            this.col2.Width = 80;
            // 
            // col3
            // 
            this.col3.Width = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 614);
            this.Controls.Add(this.listView_products);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_RemoveAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_products);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_products;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_RemoveAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView_products;
        private System.Windows.Forms.ColumnHeader col1;
        private System.Windows.Forms.ColumnHeader col2;
        private System.Windows.Forms.Label lbl_totalAmt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader col3;
    }
}
