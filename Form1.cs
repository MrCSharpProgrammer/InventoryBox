using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryBox
{
    public partial class Form1 : Form
    {
        public string IDString;
        public string ProductNameString;
        public string ProductDescriptionString;
        public string PriceString;
        public string StockString;

        public Form1()
        {
            InitializeComponent();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //initializing strings
            IDString = IDBox.Text.ToString();
            ProductNameString = ProductBox.Text.ToString();
            ProductDescriptionString = DescriptionBox.Text.ToString();
            PriceString = PriceBox.Text.ToString();
            StockString = StockBox.Text.ToString();

            ListViewItem LVItem = new ListViewItem(IDString);
            LVItem.SubItems.Add(ProductNameString);
            LVItem.SubItems.Add(ProductDescriptionString);
            LVItem.SubItems.Add(PriceString);
            LVItem.SubItems.Add(StockString);
            ListView1.Items.Add(LVItem);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Question_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select the product in the list you want to remove and then click the remove item button, alternatively you can click the clear all buton to clear the list. ");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ListView1.Clear();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            ListView1.Items.Remove(ListView1.SelectedItems[0]);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ListView1.SelectedItems.Clear();

            for (int i = ListView1.Items.Count - 1; i >= 0; i--)
            {
                if (ListView1.Items[i].ToString().ToLower().Contains(Searchbar.Text.ToLower()))
                {
                    ListView1.Items[i].Selected = true;
                    ListView1.Select();
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
