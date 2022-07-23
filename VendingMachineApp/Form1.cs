using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachineApp
{
    public partial class Form1 : Form
    {
        Product product;
        public Form1()
        {
            InitializeComponent();

            product = new Product();
            LoadData();
        }
        void LoadData()
        {
            foreach (KeyValuePair<string,double> item in product.GetProducts())
            {
                cmb_products.Items.Add(item);
            }
        }

        private void btn_RemoveAll_Click(object sender, EventArgs e)
        {
            if (listView_products.Items.Count>0)
            {
                listView_products.Items.Clear();
                lbl_totalAmt.Text = "0";
            }
        }

        private void cmb_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_products.SelectedIndex>=0)
            {

            int sno = 1;
            KeyValuePair<string,double> itm = (KeyValuePair<string,double>)cmb_products.SelectedItem;

            ListViewItem itmss = new ListViewItem();
            itmss.Text = itm.Key.ToString();
            itmss.SubItems.Add(sno.ToString());
            itmss.SubItems.Add(itm.Value.ToString());

            if (!checkItem(itmss,itm.Key.ToString()))
            {
                listView_products.Items.Add(itmss);
                
            }
            else
            {
                foreach (ListViewItem item in listView_products.Items)
                {
                    if (item.SubItems[0].Text == itm.Key.ToString())
                    {
                        item.SubItems[1].Text = (Convert.ToInt32(item.SubItems[1].Text) + 1).ToString();
                    }
                }
            }

            lbl_totalAmt.Text = CalculateAmount();
                cmb_products.SelectedIndex = -1;
            }
        }

        bool checkItem(ListViewItem selectedItems, string itm)
        {
            bool res = false;

            foreach (ListViewItem item in listView_products.Items)
            {
                if (item.SubItems[0].Text == itm)
                {
                    res = true;
                }
            }

            return res;
        }
        string CalculateAmount()
        {
            double amount = 0;

            foreach (ListViewItem item in listView_products.Items)
            {
                amount += Convert.ToDouble(item.SubItems[1].Text) * Convert.ToDouble(item.SubItems[2].Text);
            }

            return amount.ToString();
        }
    }
}
