namespace SysforeShopping
{
    partial class MainWindow
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
            this.gbxShoppingCart = new System.Windows.Forms.GroupBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboProductItems = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSubCategories = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCategories = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGenerateOrder = new System.Windows.Forms.Button();
            this.gbxShoppingCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxShoppingCart
            // 
            this.gbxShoppingCart.Controls.Add(this.txtTotalPrice);
            this.gbxShoppingCart.Controls.Add(this.label7);
            this.gbxShoppingCart.Controls.Add(this.txtQuantity);
            this.gbxShoppingCart.Controls.Add(this.label6);
            this.gbxShoppingCart.Controls.Add(this.txtUnitPrice);
            this.gbxShoppingCart.Controls.Add(this.label5);
            this.gbxShoppingCart.Controls.Add(this.cboProductItems);
            this.gbxShoppingCart.Controls.Add(this.label4);
            this.gbxShoppingCart.Controls.Add(this.cboSubCategories);
            this.gbxShoppingCart.Controls.Add(this.label3);
            this.gbxShoppingCart.Controls.Add(this.cboCategories);
            this.gbxShoppingCart.Controls.Add(this.label2);
            this.gbxShoppingCart.Controls.Add(this.txtOrderId);
            this.gbxShoppingCart.Controls.Add(this.lblOrderID);
            this.gbxShoppingCart.Location = new System.Drawing.Point(13, 13);
            this.gbxShoppingCart.Name = "gbxShoppingCart";
            this.gbxShoppingCart.Size = new System.Drawing.Size(1064, 561);
            this.gbxShoppingCart.TabIndex = 0;
            this.gbxShoppingCart.TabStop = false;
            this.gbxShoppingCart.Text = "Shopping Cart";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(206, 429);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(222, 25);
            this.txtTotalPrice.TabIndex = 105;
            this.txtTotalPrice.TextChanged += new System.EventHandler(this.txtTotalPrice_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total Price:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(206, 366);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(222, 25);
            this.txtQuantity.TabIndex = 104;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Enter Quantity:";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(206, 303);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(222, 25);
            this.txtUnitPrice.TabIndex = 103;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unit Price:";
            // 
            // cboProductItems
            // 
            this.cboProductItems.FormattingEnabled = true;
            this.cboProductItems.Location = new System.Drawing.Point(206, 240);
            this.cboProductItems.Name = "cboProductItems";
            this.cboProductItems.Size = new System.Drawing.Size(512, 25);
            this.cboProductItems.TabIndex = 102;
            this.cboProductItems.SelectedIndexChanged += new System.EventHandler(this.cboProductItems_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Product Items:";
            // 
            // cboSubCategories
            // 
            this.cboSubCategories.FormattingEnabled = true;
            this.cboSubCategories.Location = new System.Drawing.Point(206, 177);
            this.cboSubCategories.Name = "cboSubCategories";
            this.cboSubCategories.Size = new System.Drawing.Size(512, 25);
            this.cboSubCategories.TabIndex = 101;
            this.cboSubCategories.SelectedIndexChanged += new System.EventHandler(this.cboSubCategories_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product Sub Categories:";
            // 
            // cboCategories
            // 
            this.cboCategories.FormattingEnabled = true;
            this.cboCategories.Location = new System.Drawing.Point(206, 114);
            this.cboCategories.Name = "cboCategories";
            this.cboCategories.Size = new System.Drawing.Size(512, 25);
            this.cboCategories.TabIndex = 100;
            this.cboCategories.SelectedIndexChanged += new System.EventHandler(this.cboCategories_SelectedIndexChanged);
            this.cboCategories.DropDownClosed += new System.EventHandler(this.cboCategories_DropDownClosed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Cagtegories:";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(206, 51);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(700, 25);
            this.txtOrderId.TabIndex = 1;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(6, 51);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(64, 18);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "Order ID:";
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.Location = new System.Drawing.Point(844, 597);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 33);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnGenerateOrder
            // 
            this.btnGenerateOrder.AutoSize = true;
            this.btnGenerateOrder.Location = new System.Drawing.Point(937, 597);
            this.btnGenerateOrder.Name = "btnGenerateOrder";
            this.btnGenerateOrder.Size = new System.Drawing.Size(141, 33);
            this.btnGenerateOrder.TabIndex = 2;
            this.btnGenerateOrder.Text = "Generate Order";
            this.btnGenerateOrder.UseVisualStyleBackColor = true;
            this.btnGenerateOrder.Click += new System.EventHandler(this.btnGenerateOrder_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 652);
            this.Controls.Add(this.btnGenerateOrder);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gbxShoppingCart);
            this.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sysfore Shopping App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.gbxShoppingCart.ResumeLayout(false);
            this.gbxShoppingCart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxShoppingCart;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboProductItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboSubCategories;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGenerateOrder;
    }
}

