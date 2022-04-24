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
    public partial class Form3 : Form
    {
       static RipositoryFoodType _ripositoryFoodType = new RipositoryFoodType();
        public Form3()
        {
            InitializeComponent();
            var food = _ripositoryFoodType.GetFoods();
            food.ForEach(food => Dgv_FoodType.Rows.Add(food.NameFood, food.PriceFood));
        }

        private void Btn_NewFoodType_Click(object sender, EventArgs e)
        {
            string showMessage="";
            try
            {
                if(Txt_PriceFood.Text =="")
                {
                    Txt_PriceFood.Text = "0";
                }
                var foodType = new FoodType(Txt_NameFoodType.Text, int.Parse(Txt_PriceFood.Text));
                _ripositoryFoodType.AddFood(foodType);
                showMessage = "!!با موفقیت ثبت شد";
                Dgv_FoodType.Rows.Add(foodType.NameFood, foodType.PriceFood);
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
    }
}
