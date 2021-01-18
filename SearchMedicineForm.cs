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
    public partial class SearchMedicineForm : Form
    {
        private const string FILE_PATH = "MedicineList.txt";

        public SearchMedicineForm()
        {
            InitializeComponent();
        }
        
        private void selectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (selectionBox.SelectedIndex)
            {
                case 0:
                    searchLbl.Text = "ID(integer)";
                    break;
                case 1:
                    searchLbl.Text = "Name(String)";
                    break;
                case 2:
                    searchLbl.Text = "Unit(int)";
                    break;
                case 3:
                    searchLbl.Text = "Price(double)";
                    break;
                case 4:
                    searchLbl.Text = "Production Date(dd/mm/yy)";
                    break;
                case 5:
                    searchLbl.Text = "Expiration Date(dd/mm/yy)";
                    break;
                case 6:
                    searchLbl.Text = "Type(Tablet, Liquid, Syringe)";
                    break;
                default :
                    searchLbl.Text = "Search Key";
                    break;
            }
        }


        private void SearchMedicineForm_Load(object sender, EventArgs e)
        {
            selectionBox.SelectedIndex = 0;
            searchBtn.Enabled = false;
        }

        private void filterData(string line, string keyword)
        {
            string[] words = line.Split(',');
            string[] category;
            string word = " ";
            switch (selectionBox.SelectedIndex)
            {
                case 0:
                    category = words[0].Trim().Split(' ');
                    word = category[1];
                    break;
                case 1:
                    category = words[1].Trim().Split(' ');
                    word = category[1];
                    break;
                case 2:
                    category = words[2].Trim().Split(' ');
                    word = category[1];
                    break;
                case 3:
                    category = words[3].Trim().Split(' ');
                    word = category[1];
                    break;
                case 4:
                    category = words[4].Trim().Split(' ');
                    word = category[2];
                    break;
                case 5:
                    category = words[5].Trim().Split(' ');
                    word = category[2];
                    break;
                case 6:
                    category = words[6].Trim().Split(' ');
                    word = category[1];
                    break;
                default:
                    category = words[0].Trim().Split(' ');
                    break;
            }
            if(word == keyword)
            {
                itemList.Items.Add(line);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            itemList.Items.Clear();
            string line;
            using (StreamReader sr = new StreamReader(FILE_PATH))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    filterData(line, searchTextBox.Text);
                }
                
            }
                
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextBox.Text == " ")
                searchBtn.Enabled = false;
            else
                searchBtn.Enabled = true;
        }


    }
}
