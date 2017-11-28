using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace HW6_NorthWind
{
    public partial class HW6_NorthWind : OOP.FrmLogOn
    {

       
        public HW6_NorthWind()
        {
            InitializeComponent();
        }

        ClsNorthWind NW = new ClsNorthWind();
        private void AllProducttool_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = NW.GetProducts();
        }
        


        private void SearchName_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = NW.GetName(txtname.Text);

        }

        private void SearchUnitPrice_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            if (txtprice1.Text == "" || txtprice2.Text == "")
            { MessageBox.Show("請輸入完整範圍值"); }
            else
            {
                int Aprice, Bprice;

                if (!int.TryParse(txtprice1.Text, out Aprice))
                { MessageBox.Show("大哥要整數啊!!"); txtprice1.Text = ""; } //消除錯誤值
                if (!int.TryParse(txtprice2.Text, out Bprice))
                { MessageBox.Show("大哥要整數啊!!"); txtprice2.Text = ""; } //消除錯誤值
                dataGridView1.DataSource = NW.GetProductUnitPrice(Aprice, Bprice);
            }
        }

        private void AllCategory_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = NW.Categories();

        }
    }
}
