namespace WinformsH5
{
    partial class UserControlProduct
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cbProductCount = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(0, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(84, 15);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(3, 36);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 15);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbProductCount
            // 
            this.cbProductCount.AutoSize = true;
            this.cbProductCount.Location = new System.Drawing.Point(3, 75);
            this.cbProductCount.Name = "cbProductCount";
            this.cbProductCount.Size = new System.Drawing.Size(74, 19);
            this.cbProductCount.TabIndex = 1;
            this.cbProductCount.Text = "No Stock";
            this.cbProductCount.UseVisualStyleBackColor = true;
            this.cbProductCount.CheckedChanged += new System.EventHandler(this.cbProductCount_CheckedChanged);
            // 
            // UserControlProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.cbProductCount);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProductName);
            this.Name = "UserControlProduct";
            this.Size = new System.Drawing.Size(89, 108);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        public Label lblPrice;
        public Label lblProductName;
        public CheckBox cbProductCount;
    }
}
