using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DA;

namespace Final
{
    public partial class Form2 : Form
    {
        static RipositoryFoodType _ripositoryFoodType = new RipositoryFoodType();
        static RiposiroryOrder _riposiroryOrder = new RiposiroryOrder();
        List<OrderDetail> orderDetails = new List<OrderDetail>();
        public Form2()
        {
            InitializeComponent();
            var food = _ripositoryFoodType.GetFoods();
            food.ForEach(food => Cmb_FoodType.Items.Add(food.NameFood));
            Cmb_FoodType.SelectedIndex = 0;
        }

        private void Btn_NewOrderDetail_Click(object sender, EventArgs e)
        {
            string showMessage = "";
            try
            {
                if (Txt_CountFood.Text == "")
                {
                    Txt_CountFood.Text = "0";
                }
                var food = _ripositoryFoodType.GetFood(Cmb_FoodType.Text);
                OrderDetail orderDetail = new OrderDetail(food, int.Parse(Txt_CountFood.Text));
                orderDetails.Add(orderDetail);
                showMessage = "!!با موفقیت ثبت شد";
                Dgv_OrderDetail.Rows.Add(Cmb_FoodType.Text, int.Parse(Txt_CountFood.Text));
            }
            catch (Exception ex)
            {
                showMessage = ex.Message;
            }
           finally
            {
                MessageBox.Show(showMessage);
            }
        }

        private void Btn_NewOrder_Click(object sender, EventArgs e)
        {
            var order = new Order(orderDetails);
            _riposiroryOrder.AddOrder(order);
            this.Close();
        }
    }
}
