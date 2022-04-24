using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA;

namespace Final
{
    public partial class Form1 : Form
    {
        static RiposiroryOrder _riposiroryOrder = new RiposiroryOrder();
        public Form1()
        {
            InitializeComponent();
            var order = _riposiroryOrder.GetOrders();
            order.ForEach(order => Dgv_Order.Rows.Add(order.Id, order.DescriptionOrder, order.PriceTotule));
        }

        private void Btn_FoodType_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Dgv_Order.Rows.Clear();
            var order = _riposiroryOrder.GetOrders();
            order.ForEach(order => Dgv_Order.Rows.Add(order.Id, order.DescriptionOrder, order.PriceTotule));
        }
    }
}
