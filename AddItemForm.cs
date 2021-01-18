using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PharmacyTaskManager
{
    public partial class AddItemForm : Form
    {
        private const string FILE_PATH = "MedicineList.txt";

        Item item;
        int ID;

        public AddItemForm()
        {
            InitializeComponent(); 
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            saveItemBtn.Enabled = false;
            typeBox.SelectedIndex = 0;
            unitQuantityLbl.Text = "pills";
            ID = lastIndex() + 1;
        }

        private void clear()
        {
            nameTxt.Text = "";
            unitTxt.Text = "";
            priceTxt.Text = "";
            typeBox.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            unitQuantityLbl.Text = "pills";
        }

        private void SaveItemBtn_Click(object sender, EventArgs e)
        {       

            string name;
            int unitQuantity;
            double price;

            try
            {
                name = nameTxt.Text;
                unitQuantity = Convert.ToInt32(unitTxt.Text);
                price = Convert.ToDouble(priceTxt.Text);

                switch (typeBox.SelectedIndex)
                {
                    case 0:
                        item = new Tablet(ID, name, unitQuantity, price, dateTimePicker1.Value, dateTimePicker2.Value);
                        break;
                    case 1:
                        item = new Liquid(ID, name, unitQuantity, price, dateTimePicker1.Value, dateTimePicker2.Value);
                        break;
                    case 2:
                        item = new Syringe(ID, name, unitQuantity, price, dateTimePicker1.Value, dateTimePicker2.Value);
                        break;
                }                
                saveFile(item);
                
                clear();
                ID++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }


        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if (nameTxt.Text != "")
                saveItemBtn.Enabled = true;
            else
                saveItemBtn.Enabled = false;
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (typeBox.SelectedIndex)
            {
                case 0:
                    unitQuantityLbl.Text = "pills";
                    break;
                case 1:
                    unitQuantityLbl.Text = "m^3";
                    break;
                case 2:
                    unitQuantityLbl.Text = "pieces";
                    break;
            }
        }

        private void saveFile(Item item)
        {

                File.AppendAllText(FILE_PATH, item.ToString());
                

        }
        private int lastIndex()
        {
            int lastID = 0;
            if (new FileInfo(FILE_PATH).Length != 0)
            {
                string lastLine = File.ReadLines(FILE_PATH).Last();
                string[] words = lastLine.Split(',');
                string id = words[0];                
                lastID = (int)Char.GetNumericValue(id[id.Length - 1]);
            }
            return lastID;
        }


    }
}
