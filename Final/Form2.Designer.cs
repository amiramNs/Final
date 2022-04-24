
namespace Final
{
    partial class Form2
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
            this.Lbl_FoodType = new System.Windows.Forms.Label();
            this.Cmb_FoodType = new System.Windows.Forms.ComboBox();
            this.Btn_NewOrder = new System.Windows.Forms.Button();
            this.Btn_NewOrderDetail = new System.Windows.Forms.Button();
            this.Lbl_CountFood = new System.Windows.Forms.Label();
            this.Txt_CountFood = new System.Windows.Forms.TextBox();
            this.Dgv_OrderDetail = new System.Windows.Forms.DataGridView();
            this.NameFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_OrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_FoodType
            // 
            this.Lbl_FoodType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_FoodType.AutoSize = true;
            this.Lbl_FoodType.Location = new System.Drawing.Point(797, 9);
            this.Lbl_FoodType.Name = "Lbl_FoodType";
            this.Lbl_FoodType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_FoodType.Size = new System.Drawing.Size(72, 25);
            this.Lbl_FoodType.TabIndex = 0;
            this.Lbl_FoodType.Text = "نوع غذا:";
            // 
            // Cmb_FoodType
            // 
            this.Cmb_FoodType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmb_FoodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_FoodType.FormattingEnabled = true;
            this.Cmb_FoodType.Location = new System.Drawing.Point(609, 6);
            this.Cmb_FoodType.Name = "Cmb_FoodType";
            this.Cmb_FoodType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb_FoodType.Size = new System.Drawing.Size(182, 33);
            this.Cmb_FoodType.TabIndex = 1;
            // 
            // Btn_NewOrder
            // 
            this.Btn_NewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_NewOrder.Location = new System.Drawing.Point(201, 475);
            this.Btn_NewOrder.Name = "Btn_NewOrder";
            this.Btn_NewOrder.Size = new System.Drawing.Size(485, 47);
            this.Btn_NewOrder.TabIndex = 2;
            this.Btn_NewOrder.Text = "ثبت نهایی سفارش";
            this.Btn_NewOrder.UseVisualStyleBackColor = true;
            this.Btn_NewOrder.Click += new System.EventHandler(this.Btn_NewOrder_Click);
            // 
            // Btn_NewOrderDetail
            // 
            this.Btn_NewOrderDetail.Location = new System.Drawing.Point(12, 4);
            this.Btn_NewOrderDetail.Name = "Btn_NewOrderDetail";
            this.Btn_NewOrderDetail.Size = new System.Drawing.Size(173, 34);
            this.Btn_NewOrderDetail.TabIndex = 3;
            this.Btn_NewOrderDetail.Text = "افزودن به سفارش";
            this.Btn_NewOrderDetail.UseVisualStyleBackColor = true;
            this.Btn_NewOrderDetail.Click += new System.EventHandler(this.Btn_NewOrderDetail_Click);
            // 
            // Lbl_CountFood
            // 
            this.Lbl_CountFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_CountFood.AutoSize = true;
            this.Lbl_CountFood.Location = new System.Drawing.Point(461, 9);
            this.Lbl_CountFood.Name = "Lbl_CountFood";
            this.Lbl_CountFood.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_CountFood.Size = new System.Drawing.Size(56, 25);
            this.Lbl_CountFood.TabIndex = 4;
            this.Lbl_CountFood.Text = "تعداد:";
            // 
            // Txt_CountFood
            // 
            this.Txt_CountFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_CountFood.Location = new System.Drawing.Point(281, 6);
            this.Txt_CountFood.Name = "Txt_CountFood";
            this.Txt_CountFood.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_CountFood.Size = new System.Drawing.Size(150, 31);
            this.Txt_CountFood.TabIndex = 5;
            // 
            // Dgv_OrderDetail
            // 
            this.Dgv_OrderDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_OrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_OrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameFood,
            this.Count});
            this.Dgv_OrderDetail.Location = new System.Drawing.Point(12, 44);
            this.Dgv_OrderDetail.Name = "Dgv_OrderDetail";
            this.Dgv_OrderDetail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Dgv_OrderDetail.RowHeadersWidth = 62;
            this.Dgv_OrderDetail.RowTemplate.Height = 33;
            this.Dgv_OrderDetail.Size = new System.Drawing.Size(857, 425);
            this.Dgv_OrderDetail.TabIndex = 6;
            // 
            // NameFood
            // 
            this.NameFood.HeaderText = "نوع غذا";
            this.NameFood.MinimumWidth = 8;
            this.NameFood.Name = "NameFood";
            this.NameFood.Width = 150;
            // 
            // Count
            // 
            this.Count.HeaderText = "تعداد";
            this.Count.MinimumWidth = 8;
            this.Count.Name = "Count";
            this.Count.Width = 150;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 521);
            this.Controls.Add(this.Dgv_OrderDetail);
            this.Controls.Add(this.Txt_CountFood);
            this.Controls.Add(this.Lbl_CountFood);
            this.Controls.Add(this.Btn_NewOrderDetail);
            this.Controls.Add(this.Btn_NewOrder);
            this.Controls.Add(this.Cmb_FoodType);
            this.Controls.Add(this.Lbl_FoodType);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_OrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_FoodType;
        private System.Windows.Forms.ComboBox Cmb_FoodType;
        private System.Windows.Forms.Button Btn_NewOrder;
        private System.Windows.Forms.Button Btn_NewOrderDetail;
        private System.Windows.Forms.Label Lbl_CountFood;
        private System.Windows.Forms.TextBox Txt_CountFood;
        private System.Windows.Forms.DataGridView Dgv_OrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}