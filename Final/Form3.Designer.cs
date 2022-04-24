
namespace Final
{
    partial class Form3
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
            this.Lbl_NameFoodType = new System.Windows.Forms.Label();
            this.Lbl_PriceFood = new System.Windows.Forms.Label();
            this.Txt_NameFoodType = new System.Windows.Forms.TextBox();
            this.Txt_PriceFood = new System.Windows.Forms.TextBox();
            this.Btn_NewFoodType = new System.Windows.Forms.Button();
            this.Dgv_FoodType = new System.Windows.Forms.DataGridView();
            this.NameFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_FoodType)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_NameFoodType
            // 
            this.Lbl_NameFoodType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_NameFoodType.AutoSize = true;
            this.Lbl_NameFoodType.Location = new System.Drawing.Point(729, 9);
            this.Lbl_NameFoodType.Name = "Lbl_NameFoodType";
            this.Lbl_NameFoodType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_NameFoodType.Size = new System.Drawing.Size(68, 25);
            this.Lbl_NameFoodType.TabIndex = 0;
            this.Lbl_NameFoodType.Text = "نام غذا:";
            // 
            // Lbl_PriceFood
            // 
            this.Lbl_PriceFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_PriceFood.AutoSize = true;
            this.Lbl_PriceFood.Location = new System.Drawing.Point(447, 9);
            this.Lbl_PriceFood.Name = "Lbl_PriceFood";
            this.Lbl_PriceFood.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_PriceFood.Size = new System.Drawing.Size(89, 25);
            this.Lbl_PriceFood.TabIndex = 1;
            this.Lbl_PriceFood.Text = "قیمت غذا:";
            // 
            // Txt_NameFoodType
            // 
            this.Txt_NameFoodType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NameFoodType.Location = new System.Drawing.Point(573, 6);
            this.Txt_NameFoodType.Name = "Txt_NameFoodType";
            this.Txt_NameFoodType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_NameFoodType.Size = new System.Drawing.Size(150, 31);
            this.Txt_NameFoodType.TabIndex = 2;
            // 
            // Txt_PriceFood
            // 
            this.Txt_PriceFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_PriceFood.Location = new System.Drawing.Point(291, 6);
            this.Txt_PriceFood.Name = "Txt_PriceFood";
            this.Txt_PriceFood.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_PriceFood.Size = new System.Drawing.Size(150, 31);
            this.Txt_PriceFood.TabIndex = 3;
            // 
            // Btn_NewFoodType
            // 
            this.Btn_NewFoodType.Location = new System.Drawing.Point(12, 4);
            this.Btn_NewFoodType.Name = "Btn_NewFoodType";
            this.Btn_NewFoodType.Size = new System.Drawing.Size(168, 34);
            this.Btn_NewFoodType.TabIndex = 4;
            this.Btn_NewFoodType.Text = "ثبت";
            this.Btn_NewFoodType.UseVisualStyleBackColor = true;
            this.Btn_NewFoodType.Click += new System.EventHandler(this.Btn_NewFoodType_Click);
            // 
            // Dgv_FoodType
            // 
            this.Dgv_FoodType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_FoodType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_FoodType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameFood,
            this.PriceFood});
            this.Dgv_FoodType.Location = new System.Drawing.Point(12, 43);
            this.Dgv_FoodType.Name = "Dgv_FoodType";
            this.Dgv_FoodType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Dgv_FoodType.RowHeadersWidth = 62;
            this.Dgv_FoodType.RowTemplate.Height = 33;
            this.Dgv_FoodType.Size = new System.Drawing.Size(776, 395);
            this.Dgv_FoodType.TabIndex = 5;
            // 
            // NameFood
            // 
            this.NameFood.HeaderText = "نام غذا";
            this.NameFood.MinimumWidth = 8;
            this.NameFood.Name = "NameFood";
            this.NameFood.Width = 150;
            // 
            // PriceFood
            // 
            this.PriceFood.HeaderText = "قیمت غذا";
            this.PriceFood.MinimumWidth = 8;
            this.PriceFood.Name = "PriceFood";
            this.PriceFood.Width = 150;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dgv_FoodType);
            this.Controls.Add(this.Btn_NewFoodType);
            this.Controls.Add(this.Txt_PriceFood);
            this.Controls.Add(this.Txt_NameFoodType);
            this.Controls.Add(this.Lbl_PriceFood);
            this.Controls.Add(this.Lbl_NameFoodType);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_FoodType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_NameFoodType;
        private System.Windows.Forms.Label Lbl_PriceFood;
        private System.Windows.Forms.TextBox Txt_NameFoodType;
        private System.Windows.Forms.TextBox Txt_PriceFood;
        private System.Windows.Forms.Button Btn_NewFoodType;
        private System.Windows.Forms.DataGridView Dgv_FoodType;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceFood;
    }
}