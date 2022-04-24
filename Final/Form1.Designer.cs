
namespace Final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_New = new System.Windows.Forms.Button();
            this.Btn_FoodType = new System.Windows.Forms.Button();
            this.Dgv_Order = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceTotule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Order)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_New
            // 
            this.Btn_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_New.Location = new System.Drawing.Point(747, 582);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(342, 36);
            this.Btn_New.TabIndex = 0;
            this.Btn_New.Text = "جدید";
            this.Btn_New.UseVisualStyleBackColor = true;
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // Btn_FoodType
            // 
            this.Btn_FoodType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_FoodType.Location = new System.Drawing.Point(12, 582);
            this.Btn_FoodType.Name = "Btn_FoodType";
            this.Btn_FoodType.Size = new System.Drawing.Size(338, 36);
            this.Btn_FoodType.TabIndex = 1;
            this.Btn_FoodType.Text = "افزودن نوع غذا";
            this.Btn_FoodType.UseVisualStyleBackColor = true;
            this.Btn_FoodType.Click += new System.EventHandler(this.Btn_FoodType_Click);
            // 
            // Dgv_Order
            // 
            this.Dgv_Order.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DescriptionOrder,
            this.PriceTotule});
            this.Dgv_Order.Location = new System.Drawing.Point(12, 12);
            this.Dgv_Order.Name = "Dgv_Order";
            this.Dgv_Order.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Dgv_Order.RowHeadersWidth = 62;
            this.Dgv_Order.Size = new System.Drawing.Size(1077, 564);
            this.Dgv_Order.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "شماره سفارش";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Width = 150;
            // 
            // DescriptionOrder
            // 
            this.DescriptionOrder.HeaderText = "شرح سفارش";
            this.DescriptionOrder.MinimumWidth = 8;
            this.DescriptionOrder.Name = "DescriptionOrder";
            this.DescriptionOrder.Width = 150;
            // 
            // PriceTotule
            // 
            this.PriceTotule.HeaderText = "مبلغ کل سفارش";
            this.PriceTotule.MinimumWidth = 8;
            this.PriceTotule.Name = "PriceTotule";
            this.PriceTotule.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 630);
            this.Controls.Add(this.Dgv_Order);
            this.Controls.Add(this.Btn_FoodType);
            this.Controls.Add(this.Btn_New);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Order)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_New;
        private System.Windows.Forms.Button Btn_FoodType;
        private System.Windows.Forms.DataGridView Dgv_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceTotule;
    }
}

