namespace PharmacyTaskManager
{
    partial class SearchMedicineForm
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
            this.selectionLbl = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.itemList = new System.Windows.Forms.ListBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.selectionBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // selectionLbl
            // 
            this.selectionLbl.AutoSize = true;
            this.selectionLbl.Location = new System.Drawing.Point(18, 48);
            this.selectionLbl.Name = "selectionLbl";
            this.selectionLbl.Size = new System.Drawing.Size(35, 13);
            this.selectionLbl.TabIndex = 1;
            this.selectionLbl.Text = "select";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(21, 112);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(121, 20);
            this.searchTextBox.TabIndex = 2;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Location = new System.Drawing.Point(18, 91);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(59, 13);
            this.searchLbl.TabIndex = 3;
            this.searchLbl.Text = "search key";
            // 
            // itemList
            // 
            this.itemList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(71)))));
            this.itemList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemList.Dock = System.Windows.Forms.DockStyle.Right;
            this.itemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemList.ForeColor = System.Drawing.Color.Khaki;
            this.itemList.FormattingEnabled = true;
            this.itemList.HorizontalScrollbar = true;
            this.itemList.ItemHeight = 16;
            this.itemList.Location = new System.Drawing.Point(254, 0);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(329, 387);
            this.itemList.TabIndex = 4;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Turquoise;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.ForeColor = System.Drawing.Color.Black;
            this.searchBtn.Location = new System.Drawing.Point(132, 151);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(88, 33);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // selectionBox
            // 
            this.selectionBox.FormattingEnabled = true;
            this.selectionBox.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Unit",
            "Price",
            "Production Date",
            "Expriation Date",
            "Type"});
            this.selectionBox.Location = new System.Drawing.Point(21, 67);
            this.selectionBox.Name = "selectionBox";
            this.selectionBox.Size = new System.Drawing.Size(199, 21);
            this.selectionBox.TabIndex = 6;
            this.selectionBox.SelectedIndexChanged += new System.EventHandler(this.selectionBox_SelectedIndexChanged);
            // 
            // SearchMedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 387);
            this.Controls.Add(this.selectionBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.selectionLbl);
            this.Name = "SearchMedicineForm";
            this.Text = "SearchMedicineForm";
            this.Load += new System.EventHandler(this.SearchMedicineForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label selectionLbl;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.ListBox itemList;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ComboBox selectionBox;
    }
}