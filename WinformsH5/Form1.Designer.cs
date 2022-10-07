namespace WinformsH5
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
            this.panelProducts = new System.Windows.Forms.Panel();
            this.txtUserEnteredAmount = new System.Windows.Forms.TextBox();
            this.btn01USD = new System.Windows.Forms.Button();
            this.btn05USD = new System.Windows.Forms.Button();
            this.btn1USD = new System.Windows.Forms.Button();
            this.btn20USD = new System.Windows.Forms.Button();
            this.btn10USD = new System.Windows.Forms.Button();
            this.btn5USD = new System.Windows.Forms.Button();
            this.lblToPay = new System.Windows.Forms.Label();
            this.lblReturnedMoney = new System.Windows.Forms.Label();
            this.lblEnteredPrice = new System.Windows.Forms.Label();
            this.lblReturnMoney = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.lblUserEnteredMoney = new System.Windows.Forms.Label();
            this.panelOperation = new System.Windows.Forms.Panel();
            this.panelOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProducts
            // 
            this.panelProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProducts.AutoScroll = true;
            this.panelProducts.Location = new System.Drawing.Point(0, 0);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(546, 251);
            this.panelProducts.TabIndex = 1;
            // 
            // txtUserEnteredAmount
            // 
            this.txtUserEnteredAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserEnteredAmount.Location = new System.Drawing.Point(3, 3);
            this.txtUserEnteredAmount.Name = "txtUserEnteredAmount";
            this.txtUserEnteredAmount.Size = new System.Drawing.Size(261, 23);
            this.txtUserEnteredAmount.TabIndex = 0;
            this.txtUserEnteredAmount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn01USD
            // 
            this.btn01USD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn01USD.Location = new System.Drawing.Point(3, 42);
            this.btn01USD.Name = "btn01USD";
            this.btn01USD.Size = new System.Drawing.Size(58, 23);
            this.btn01USD.TabIndex = 1;
            this.btn01USD.Text = "0,1 USD";
            this.btn01USD.UseVisualStyleBackColor = true;
            this.btn01USD.Click += new System.EventHandler(this.btnUSD_Click);
            // 
            // btn05USD
            // 
            this.btn05USD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn05USD.Location = new System.Drawing.Point(99, 42);
            this.btn05USD.Name = "btn05USD";
            this.btn05USD.Size = new System.Drawing.Size(58, 23);
            this.btn05USD.TabIndex = 1;
            this.btn05USD.Text = "0,5 USD";
            this.btn05USD.UseVisualStyleBackColor = true;
            this.btn05USD.Click += new System.EventHandler(this.btnUSD_Click);
            // 
            // btn1USD
            // 
            this.btn1USD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1USD.Location = new System.Drawing.Point(194, 42);
            this.btn1USD.Name = "btn1USD";
            this.btn1USD.Size = new System.Drawing.Size(58, 23);
            this.btn1USD.TabIndex = 1;
            this.btn1USD.Text = "1 USD";
            this.btn1USD.UseVisualStyleBackColor = true;
            this.btn1USD.Click += new System.EventHandler(this.btnUSD_Click);
            // 
            // btn20USD
            // 
            this.btn20USD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn20USD.Location = new System.Drawing.Point(194, 84);
            this.btn20USD.Name = "btn20USD";
            this.btn20USD.Size = new System.Drawing.Size(58, 23);
            this.btn20USD.TabIndex = 1;
            this.btn20USD.Text = "20 USD";
            this.btn20USD.UseVisualStyleBackColor = true;
            this.btn20USD.Click += new System.EventHandler(this.btnUSD_Click);
            // 
            // btn10USD
            // 
            this.btn10USD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10USD.Location = new System.Drawing.Point(99, 84);
            this.btn10USD.Name = "btn10USD";
            this.btn10USD.Size = new System.Drawing.Size(58, 23);
            this.btn10USD.TabIndex = 1;
            this.btn10USD.Text = "10 USD";
            this.btn10USD.UseVisualStyleBackColor = true;
            this.btn10USD.Click += new System.EventHandler(this.btnUSD_Click);
            // 
            // btn5USD
            // 
            this.btn5USD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5USD.Location = new System.Drawing.Point(6, 84);
            this.btn5USD.Name = "btn5USD";
            this.btn5USD.Size = new System.Drawing.Size(58, 23);
            this.btn5USD.TabIndex = 1;
            this.btn5USD.Text = "5 USD";
            this.btn5USD.UseVisualStyleBackColor = true;
            this.btn5USD.Click += new System.EventHandler(this.btnUSD_Click);
            // 
            // lblToPay
            // 
            this.lblToPay.AutoSize = true;
            this.lblToPay.Location = new System.Drawing.Point(6, 126);
            this.lblToPay.Name = "lblToPay";
            this.lblToPay.Size = new System.Drawing.Size(41, 15);
            this.lblToPay.TabIndex = 2;
            this.lblToPay.Text = "To Pay";
            // 
            // lblReturnedMoney
            // 
            this.lblReturnedMoney.AutoSize = true;
            this.lblReturnedMoney.Location = new System.Drawing.Point(99, 178);
            this.lblReturnedMoney.Name = "lblReturnedMoney";
            this.lblReturnedMoney.Size = new System.Drawing.Size(19, 15);
            this.lblReturnedMoney.TabIndex = 2;
            this.lblReturnedMoney.Text = "0$";
            // 
            // lblEnteredPrice
            // 
            this.lblEnteredPrice.AutoSize = true;
            this.lblEnteredPrice.Location = new System.Drawing.Point(6, 150);
            this.lblEnteredPrice.Name = "lblEnteredPrice";
            this.lblEnteredPrice.Size = new System.Drawing.Size(87, 15);
            this.lblEnteredPrice.TabIndex = 2;
            this.lblEnteredPrice.Text = "Entered Money";
            // 
            // lblReturnMoney
            // 
            this.lblReturnMoney.AutoSize = true;
            this.lblReturnMoney.Location = new System.Drawing.Point(6, 178);
            this.lblReturnMoney.Name = "lblReturnMoney";
            this.lblReturnMoney.Size = new System.Drawing.Size(82, 15);
            this.lblReturnMoney.TabIndex = 2;
            this.lblReturnMoney.Text = "Return Money";
            // 
            // btnPay
            // 
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Location = new System.Drawing.Point(99, 216);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(58, 23);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Location = new System.Drawing.Point(98, 126);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(19, 15);
            this.lblTotalPayment.TabIndex = 4;
            this.lblTotalPayment.Text = "0$";
            // 
            // lblUserEnteredMoney
            // 
            this.lblUserEnteredMoney.AutoSize = true;
            this.lblUserEnteredMoney.Location = new System.Drawing.Point(99, 150);
            this.lblUserEnteredMoney.Name = "lblUserEnteredMoney";
            this.lblUserEnteredMoney.Size = new System.Drawing.Size(19, 15);
            this.lblUserEnteredMoney.TabIndex = 4;
            this.lblUserEnteredMoney.Text = "0$";
            // 
            // panelOperation
            // 
            this.panelOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOperation.AutoSize = true;
            this.panelOperation.Controls.Add(this.lblUserEnteredMoney);
            this.panelOperation.Controls.Add(this.lblTotalPayment);
            this.panelOperation.Controls.Add(this.btnPay);
            this.panelOperation.Controls.Add(this.lblReturnMoney);
            this.panelOperation.Controls.Add(this.lblEnteredPrice);
            this.panelOperation.Controls.Add(this.lblReturnedMoney);
            this.panelOperation.Controls.Add(this.lblToPay);
            this.panelOperation.Controls.Add(this.btn5USD);
            this.panelOperation.Controls.Add(this.btn10USD);
            this.panelOperation.Controls.Add(this.btn20USD);
            this.panelOperation.Controls.Add(this.btn1USD);
            this.panelOperation.Controls.Add(this.btn05USD);
            this.panelOperation.Controls.Add(this.btn01USD);
            this.panelOperation.Controls.Add(this.txtUserEnteredAmount);
            this.panelOperation.Location = new System.Drawing.Point(546, 0);
            this.panelOperation.Name = "panelOperation";
            this.panelOperation.Size = new System.Drawing.Size(267, 251);
            this.panelOperation.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 251);
            this.Controls.Add(this.panelProducts);
            this.Controls.Add(this.panelOperation);
            this.MinimumSize = new System.Drawing.Size(829, 290);
            this.Name = "Form1";
            this.Text = "Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelOperation.ResumeLayout(false);
            this.panelOperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelProducts;
        private TextBox txtUserEnteredAmount;
        private Button btn01USD;
        private Button btn05USD;
        private Button btn1USD;
        private Button btn20USD;
        private Button btn10USD;
        private Button btn5USD;
        private Label lblToPay;
        private Label lblReturnedMoney;
        private Label lblEnteredPrice;
        private Label lblReturnMoney;
        private Button btnPay;
        private Label lblTotalPayment;
        private Label lblUserEnteredMoney;
        private Panel panelOperation;
    }
}