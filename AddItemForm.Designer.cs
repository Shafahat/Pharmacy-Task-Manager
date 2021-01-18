namespace PharmacyTaskManager
{
    partial class AddItemForm
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.priceLbl = new System.Windows.Forms.Label();
            this.unitTxt = new System.Windows.Forms.TextBox();
            this.unitLbl = new System.Windows.Forms.Label();
            this.saveItemBtn = new System.Windows.Forms.Button();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.typeLbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.productionDateLbl = new System.Windows.Forms.Label();
            this.expirationDateLbl = new System.Windows.Forms.Label();
            this.unitQuantityLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(29, 33);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(33, 13);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "name";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(77, 33);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(200, 20);
            this.nameTxt.TabIndex = 1;
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(77, 68);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(200, 20);
            this.priceTxt.TabIndex = 3;
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(29, 68);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(30, 13);
            this.priceLbl.TabIndex = 2;
            this.priceLbl.Text = "price";
            // 
            // unitTxt
            // 
            this.unitTxt.Location = new System.Drawing.Point(77, 103);
            this.unitTxt.Name = "unitTxt";
            this.unitTxt.Size = new System.Drawing.Size(200, 20);
            this.unitTxt.TabIndex = 5;
            // 
            // unitLbl
            // 
            this.unitLbl.AutoSize = true;
            this.unitLbl.Location = new System.Drawing.Point(29, 103);
            this.unitLbl.Name = "unitLbl";
            this.unitLbl.Size = new System.Drawing.Size(24, 13);
            this.unitLbl.TabIndex = 4;
            this.unitLbl.Text = "unit";
            // 
            // saveItemBtn
            // 
            this.saveItemBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.saveItemBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveItemBtn.FlatAppearance.BorderSize = 2;
            this.saveItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveItemBtn.ForeColor = System.Drawing.Color.White;
            this.saveItemBtn.Location = new System.Drawing.Point(464, 250);
            this.saveItemBtn.Name = "saveItemBtn";
            this.saveItemBtn.Size = new System.Drawing.Size(93, 34);
            this.saveItemBtn.TabIndex = 6;
            this.saveItemBtn.Text = "Submit";
            this.saveItemBtn.UseVisualStyleBackColor = false;
            this.saveItemBtn.Click += new System.EventHandler(this.SaveItemBtn_Click);
            // 
            // typeBox
            // 
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Tablet",
            "Lyquid",
            "Syringe"});
            this.typeBox.Location = new System.Drawing.Point(77, 143);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(200, 21);
            this.typeBox.TabIndex = 7;
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(29, 146);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(27, 13);
            this.typeLbl.TabIndex = 8;
            this.typeLbl.Text = "type";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-mm-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(357, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(91, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-mm-yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(357, 139);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(91, 20);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // productionDateLbl
            // 
            this.productionDateLbl.AutoSize = true;
            this.productionDateLbl.Location = new System.Drawing.Point(324, 40);
            this.productionDateLbl.Name = "productionDateLbl";
            this.productionDateLbl.Size = new System.Drawing.Size(81, 13);
            this.productionDateLbl.TabIndex = 11;
            this.productionDateLbl.Text = "production date";
            // 
            // expirationDateLbl
            // 
            this.expirationDateLbl.AutoSize = true;
            this.expirationDateLbl.Location = new System.Drawing.Point(324, 110);
            this.expirationDateLbl.Name = "expirationDateLbl";
            this.expirationDateLbl.Size = new System.Drawing.Size(76, 13);
            this.expirationDateLbl.TabIndex = 12;
            this.expirationDateLbl.Text = "expiration date";
            // 
            // unitQuantityLbl
            // 
            this.unitQuantityLbl.AutoSize = true;
            this.unitQuantityLbl.Location = new System.Drawing.Point(283, 106);
            this.unitQuantityLbl.Name = "unitQuantityLbl";
            this.unitQuantityLbl.Size = new System.Drawing.Size(13, 13);
            this.unitQuantityLbl.TabIndex = 13;
            this.unitQuantityLbl.Text = "_";
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 313);
            this.Controls.Add(this.unitQuantityLbl);
            this.Controls.Add(this.expirationDateLbl);
            this.Controls.Add(this.productionDateLbl);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.saveItemBtn);
            this.Controls.Add(this.unitTxt);
            this.Controls.Add(this.unitLbl);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.nameLbl);
            this.Name = "AddItemForm";
            this.Text = "AddItemForm";
            this.Load += new System.EventHandler(this.AddItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.TextBox unitTxt;
        private System.Windows.Forms.Label unitLbl;
        private System.Windows.Forms.Button saveItemBtn;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label productionDateLbl;
        private System.Windows.Forms.Label expirationDateLbl;
        private System.Windows.Forms.Label unitQuantityLbl;
    }
}