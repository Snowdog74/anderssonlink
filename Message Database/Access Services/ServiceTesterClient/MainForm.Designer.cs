namespace ServiceTesterClient
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.OrderServiceTabPage = new System.Windows.Forms.TabPage();
            this.putOrderButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.currencyTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deliveryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.orderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.itemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.itemNumberTextBox = new System.Windows.Forms.TextBox();
            this.recipientTextBox = new System.Windows.Forms.TextBox();
            this.senderTextBox = new System.Windows.Forms.TextBox();
            this.orderToDeleteTextBox = new System.Windows.Forms.TextBox();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.getOrdersButton = new System.Windows.Forms.Button();
            this.responseTextBox = new System.Windows.Forms.TextBox();
            this.InvoiceServiceTabPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.OrderServiceTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.OrderServiceTabPage);
            this.tabControl1.Controls.Add(this.InvoiceServiceTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(360, 581);
            this.tabControl1.TabIndex = 0;
            // 
            // OrderServiceTabPage
            // 
            this.OrderServiceTabPage.Controls.Add(this.putOrderButton);
            this.OrderServiceTabPage.Controls.Add(this.label9);
            this.OrderServiceTabPage.Controls.Add(this.textTextBox);
            this.OrderServiceTabPage.Controls.Add(this.label8);
            this.OrderServiceTabPage.Controls.Add(this.currencyTextBox);
            this.OrderServiceTabPage.Controls.Add(this.label7);
            this.OrderServiceTabPage.Controls.Add(this.quantityLabel);
            this.OrderServiceTabPage.Controls.Add(this.priceTextBox);
            this.OrderServiceTabPage.Controls.Add(this.quantityTextBox);
            this.OrderServiceTabPage.Controls.Add(this.label6);
            this.OrderServiceTabPage.Controls.Add(this.label5);
            this.OrderServiceTabPage.Controls.Add(this.deliveryDateTimePicker);
            this.OrderServiceTabPage.Controls.Add(this.orderDateTimePicker);
            this.OrderServiceTabPage.Controls.Add(this.label4);
            this.OrderServiceTabPage.Controls.Add(this.label3);
            this.OrderServiceTabPage.Controls.Add(this.label2);
            this.OrderServiceTabPage.Controls.Add(this.label1);
            this.OrderServiceTabPage.Controls.Add(this.itemDescriptionTextBox);
            this.OrderServiceTabPage.Controls.Add(this.itemNumberTextBox);
            this.OrderServiceTabPage.Controls.Add(this.recipientTextBox);
            this.OrderServiceTabPage.Controls.Add(this.senderTextBox);
            this.OrderServiceTabPage.Controls.Add(this.orderToDeleteTextBox);
            this.OrderServiceTabPage.Controls.Add(this.deleteOrderButton);
            this.OrderServiceTabPage.Controls.Add(this.getOrdersButton);
            this.OrderServiceTabPage.Controls.Add(this.responseTextBox);
            this.OrderServiceTabPage.Location = new System.Drawing.Point(4, 22);
            this.OrderServiceTabPage.Name = "OrderServiceTabPage";
            this.OrderServiceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrderServiceTabPage.Size = new System.Drawing.Size(352, 555);
            this.OrderServiceTabPage.TabIndex = 0;
            this.OrderServiceTabPage.Text = "OrderService";
            this.OrderServiceTabPage.UseVisualStyleBackColor = true;
            // 
            // putOrderButton
            // 
            this.putOrderButton.Location = new System.Drawing.Point(258, 236);
            this.putOrderButton.Name = "putOrderButton";
            this.putOrderButton.Size = new System.Drawing.Size(88, 23);
            this.putOrderButton.TabIndex = 24;
            this.putOrderButton.Text = "PutOrder()";
            this.putOrderButton.UseVisualStyleBackColor = true;
            this.putOrderButton.Click += new System.EventHandler(this.putOrderButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Text:";
            // 
            // textTextBox
            // 
            this.textTextBox.Location = new System.Drawing.Point(93, 239);
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(100, 20);
            this.textTextBox.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Currency:";
            // 
            // currencyTextBox
            // 
            this.currencyTextBox.Location = new System.Drawing.Point(93, 213);
            this.currencyTextBox.Name = "currencyTextBox";
            this.currencyTextBox.Size = new System.Drawing.Size(100, 20);
            this.currencyTextBox.TabIndex = 20;
            this.currencyTextBox.Text = "SEK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Price:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(38, 164);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(49, 13);
            this.quantityLabel.TabIndex = 18;
            this.quantityLabel.Text = "Quantity:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(93, 187);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 17;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(93, 161);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "DeliveryDate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "OrderDate:";
            // 
            // deliveryDateTimePicker
            // 
            this.deliveryDateTimePicker.Location = new System.Drawing.Point(93, 135);
            this.deliveryDateTimePicker.Name = "deliveryDateTimePicker";
            this.deliveryDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.deliveryDateTimePicker.TabIndex = 13;
            // 
            // orderDateTimePicker
            // 
            this.orderDateTimePicker.Location = new System.Drawing.Point(93, 109);
            this.orderDateTimePicker.Name = "orderDateTimePicker";
            this.orderDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.orderDateTimePicker.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ItemDescription:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ItemNumber:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Recipient:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sender:";
            // 
            // itemDescriptionTextBox
            // 
            this.itemDescriptionTextBox.Location = new System.Drawing.Point(93, 82);
            this.itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            this.itemDescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemDescriptionTextBox.TabIndex = 7;
            // 
            // itemNumberTextBox
            // 
            this.itemNumberTextBox.Location = new System.Drawing.Point(93, 56);
            this.itemNumberTextBox.Name = "itemNumberTextBox";
            this.itemNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemNumberTextBox.TabIndex = 6;
            // 
            // recipientTextBox
            // 
            this.recipientTextBox.Location = new System.Drawing.Point(93, 30);
            this.recipientTextBox.Name = "recipientTextBox";
            this.recipientTextBox.Size = new System.Drawing.Size(100, 20);
            this.recipientTextBox.TabIndex = 5;
            // 
            // senderTextBox
            // 
            this.senderTextBox.Location = new System.Drawing.Point(93, 4);
            this.senderTextBox.Name = "senderTextBox";
            this.senderTextBox.Size = new System.Drawing.Size(100, 20);
            this.senderTextBox.TabIndex = 4;
            // 
            // orderToDeleteTextBox
            // 
            this.orderToDeleteTextBox.Location = new System.Drawing.Point(207, 267);
            this.orderToDeleteTextBox.Name = "orderToDeleteTextBox";
            this.orderToDeleteTextBox.Size = new System.Drawing.Size(45, 20);
            this.orderToDeleteTextBox.TabIndex = 3;
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Location = new System.Drawing.Point(258, 265);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(88, 23);
            this.deleteOrderButton.TabIndex = 2;
            this.deleteOrderButton.Text = "DeleteOrder()";
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // getOrdersButton
            // 
            this.getOrdersButton.Location = new System.Drawing.Point(258, 528);
            this.getOrdersButton.Name = "getOrdersButton";
            this.getOrdersButton.Size = new System.Drawing.Size(91, 23);
            this.getOrdersButton.TabIndex = 1;
            this.getOrdersButton.Text = "GetOrders()";
            this.getOrdersButton.UseVisualStyleBackColor = true;
            this.getOrdersButton.Click += new System.EventHandler(this.getOrdersButton_Click);
            // 
            // responseTextBox
            // 
            this.responseTextBox.Location = new System.Drawing.Point(14, 294);
            this.responseTextBox.Multiline = true;
            this.responseTextBox.Name = "responseTextBox";
            this.responseTextBox.Size = new System.Drawing.Size(332, 228);
            this.responseTextBox.TabIndex = 0;
            // 
            // InvoiceServiceTabPage
            // 
            this.InvoiceServiceTabPage.Location = new System.Drawing.Point(4, 22);
            this.InvoiceServiceTabPage.Name = "InvoiceServiceTabPage";
            this.InvoiceServiceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.InvoiceServiceTabPage.Size = new System.Drawing.Size(352, 555);
            this.InvoiceServiceTabPage.TabIndex = 1;
            this.InvoiceServiceTabPage.Text = "InvoiceService";
            this.InvoiceServiceTabPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 605);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Service Tester Client";
            this.tabControl1.ResumeLayout(false);
            this.OrderServiceTabPage.ResumeLayout(false);
            this.OrderServiceTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage OrderServiceTabPage;
        private System.Windows.Forms.TabPage InvoiceServiceTabPage;
        private System.Windows.Forms.TextBox orderToDeleteTextBox;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.Button getOrdersButton;
        private System.Windows.Forms.TextBox responseTextBox;
        private System.Windows.Forms.TextBox itemDescriptionTextBox;
        private System.Windows.Forms.TextBox itemNumberTextBox;
        private System.Windows.Forms.TextBox recipientTextBox;
        private System.Windows.Forms.TextBox senderTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker orderDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker deliveryDateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button putOrderButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox currencyTextBox;
    }
}

