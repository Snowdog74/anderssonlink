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
            this.label21 = new System.Windows.Forms.Label();
            this.invoiceCountry = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.invoiceCity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.invoiceZipcode = new System.Windows.Forms.TextBox();
            this.sendInvoiceButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.invoiceStreet = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.invoiceCurrency = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.invoiceAmount = new System.Windows.Forms.TextBox();
            this.invoiceReference = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.invoiceDueDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.invoiceItemDescription = new System.Windows.Forms.TextBox();
            this.invoiceNumber = new System.Windows.Forms.TextBox();
            this.invoiceRecipient = new System.Windows.Forms.TextBox();
            this.invoiceSender = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.OrderServiceTabPage.SuspendLayout();
            this.InvoiceServiceTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.OrderServiceTabPage);
            this.tabControl1.Controls.Add(this.InvoiceServiceTabPage);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
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
            this.OrderServiceTabPage.Cursor = System.Windows.Forms.Cursors.Default;
            this.OrderServiceTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderServiceTabPage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OrderServiceTabPage.Location = new System.Drawing.Point(4, 22);
            this.OrderServiceTabPage.Name = "OrderServiceTabPage";
            this.OrderServiceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrderServiceTabPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OrderServiceTabPage.Size = new System.Drawing.Size(352, 555);
            this.OrderServiceTabPage.TabIndex = 0;
            this.OrderServiceTabPage.Text = "OrderService";
            this.OrderServiceTabPage.UseVisualStyleBackColor = true;
            // 
            // putOrderButton
            // 
            this.putOrderButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.putOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.putOrderButton.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.putOrderButton.Location = new System.Drawing.Point(258, 236);
            this.putOrderButton.Name = "putOrderButton";
            this.putOrderButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.putOrderButton.Size = new System.Drawing.Size(88, 23);
            this.putOrderButton.TabIndex = 24;
            this.putOrderButton.Text = "PutOrder()";
            this.putOrderButton.UseVisualStyleBackColor = true;
            this.putOrderButton.Click += new System.EventHandler(this.putOrderButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.label9.Location = new System.Drawing.Point(56, 242);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Text:";
            // 
            // textTextBox
            // 
            this.textTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textTextBox.Location = new System.Drawing.Point(93, 239);
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textTextBox.Size = new System.Drawing.Size(100, 20);
            this.textTextBox.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.label8.Location = new System.Drawing.Point(35, 216);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Currency:";
            // 
            // currencyTextBox
            // 
            this.currencyTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.currencyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.currencyTextBox.Location = new System.Drawing.Point(93, 213);
            this.currencyTextBox.Name = "currencyTextBox";
            this.currencyTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.currencyTextBox.Size = new System.Drawing.Size(100, 20);
            this.currencyTextBox.TabIndex = 20;
            this.currencyTextBox.Text = "SEK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.label7.Location = new System.Drawing.Point(53, 190);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Price:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.quantityLabel.Location = new System.Drawing.Point(38, 164);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.quantityLabel.Size = new System.Drawing.Size(49, 13);
            this.quantityLabel.TabIndex = 18;
            this.quantityLabel.Text = "Quantity:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.priceTextBox.Location = new System.Drawing.Point(93, 187);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 17;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.quantityTextBox.Location = new System.Drawing.Point(93, 161);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.label6.Location = new System.Drawing.Point(16, 141);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "DeliveryDate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.label5.Location = new System.Drawing.Point(28, 115);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "OrderDate:";
            // 
            // deliveryDateTimePicker
            // 
            this.deliveryDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryDateTimePicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.deliveryDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.deliveryDateTimePicker.Location = new System.Drawing.Point(93, 135);
            this.deliveryDateTimePicker.Name = "deliveryDateTimePicker";
            this.deliveryDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deliveryDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.deliveryDateTimePicker.TabIndex = 13;
            // 
            // orderDateTimePicker
            // 
            this.orderDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDateTimePicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.orderDateTimePicker.Location = new System.Drawing.Point(93, 109);
            this.orderDateTimePicker.Name = "orderDateTimePicker";
            this.orderDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.orderDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.orderDateTimePicker.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.label4.Location = new System.Drawing.Point(4, 85);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ItemDescription:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.label3.Location = new System.Drawing.Point(20, 59);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ItemNumber:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.label2.Location = new System.Drawing.Point(32, 33);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Recipient:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.label1.Location = new System.Drawing.Point(43, 7);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sender:";
            // 
            // itemDescriptionTextBox
            // 
            this.itemDescriptionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.itemDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDescriptionTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.itemDescriptionTextBox.Location = new System.Drawing.Point(93, 82);
            this.itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            this.itemDescriptionTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.itemDescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemDescriptionTextBox.TabIndex = 7;
            // 
            // itemNumberTextBox
            // 
            this.itemNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.itemNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNumberTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.itemNumberTextBox.Location = new System.Drawing.Point(93, 56);
            this.itemNumberTextBox.Name = "itemNumberTextBox";
            this.itemNumberTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.itemNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemNumberTextBox.TabIndex = 6;
            // 
            // recipientTextBox
            // 
            this.recipientTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.recipientTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipientTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.recipientTextBox.Location = new System.Drawing.Point(93, 30);
            this.recipientTextBox.Name = "recipientTextBox";
            this.recipientTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.recipientTextBox.Size = new System.Drawing.Size(100, 20);
            this.recipientTextBox.TabIndex = 5;
            // 
            // senderTextBox
            // 
            this.senderTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.senderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senderTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.senderTextBox.Location = new System.Drawing.Point(93, 4);
            this.senderTextBox.Name = "senderTextBox";
            this.senderTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.senderTextBox.Size = new System.Drawing.Size(100, 20);
            this.senderTextBox.TabIndex = 4;
            // 
            // orderToDeleteTextBox
            // 
            this.orderToDeleteTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderToDeleteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderToDeleteTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.orderToDeleteTextBox.Location = new System.Drawing.Point(207, 267);
            this.orderToDeleteTextBox.Name = "orderToDeleteTextBox";
            this.orderToDeleteTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.orderToDeleteTextBox.Size = new System.Drawing.Size(45, 20);
            this.orderToDeleteTextBox.TabIndex = 3;
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.deleteOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteOrderButton.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.deleteOrderButton.Location = new System.Drawing.Point(258, 265);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deleteOrderButton.Size = new System.Drawing.Size(88, 23);
            this.deleteOrderButton.TabIndex = 2;
            this.deleteOrderButton.Text = "DeleteOrder()";
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // getOrdersButton
            // 
            this.getOrdersButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.getOrdersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getOrdersButton.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.getOrdersButton.Location = new System.Drawing.Point(258, 528);
            this.getOrdersButton.Name = "getOrdersButton";
            this.getOrdersButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.getOrdersButton.Size = new System.Drawing.Size(91, 23);
            this.getOrdersButton.TabIndex = 1;
            this.getOrdersButton.Text = "GetOrders()";
            this.getOrdersButton.UseVisualStyleBackColor = true;
            this.getOrdersButton.Click += new System.EventHandler(this.getOrdersButton_Click);
            // 
            // responseTextBox
            // 
            this.responseTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.responseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responseTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.responseTextBox.Location = new System.Drawing.Point(14, 294);
            this.responseTextBox.Multiline = true;
            this.responseTextBox.Name = "responseTextBox";
            this.responseTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.responseTextBox.Size = new System.Drawing.Size(332, 228);
            this.responseTextBox.TabIndex = 0;
            // 
            // InvoiceServiceTabPage
            // 
            this.InvoiceServiceTabPage.Controls.Add(this.label21);
            this.InvoiceServiceTabPage.Controls.Add(this.invoiceCountry);
            this.InvoiceServiceTabPage.Controls.Add(this.label20);
            this.InvoiceServiceTabPage.Controls.Add(this.invoiceCity);
            this.InvoiceServiceTabPage.Controls.Add(this.label14);
            this.InvoiceServiceTabPage.Controls.Add(this.invoiceZipcode);
            this.InvoiceServiceTabPage.Controls.Add(this.sendInvoiceButton);
            this.InvoiceServiceTabPage.Controls.Add(this.label10);
            this.InvoiceServiceTabPage.Controls.Add(this.invoiceStreet);
            this.InvoiceServiceTabPage.Controls.Add(this.label11);
            this.InvoiceServiceTabPage.Controls.Add(this.invoiceCurrency);
            this.InvoiceServiceTabPage.Controls.Add(this.label12);
            this.InvoiceServiceTabPage.Controls.Add(this.label13);
            this.InvoiceServiceTabPage.Controls.Add(this.invoiceAmount);
            this.InvoiceServiceTabPage.Controls.Add(this.invoiceReference);
            this.InvoiceServiceTabPage.Controls.Add(this.label15);
            this.InvoiceServiceTabPage.Controls.Add(this.invoiceDueDate);
            this.InvoiceServiceTabPage.Controls.Add(this.label16);
            this.InvoiceServiceTabPage.Controls.Add(this.label17);
            this.InvoiceServiceTabPage.Controls.Add(this.label18);
            this.InvoiceServiceTabPage.Controls.Add(this.label19);
            this.InvoiceServiceTabPage.Controls.Add(this.invoiceItemDescription);
            this.InvoiceServiceTabPage.Controls.Add(this.invoiceNumber);
            this.InvoiceServiceTabPage.Controls.Add(this.invoiceRecipient);
            this.InvoiceServiceTabPage.Controls.Add(this.invoiceSender);
            this.InvoiceServiceTabPage.Cursor = System.Windows.Forms.Cursors.Default;
            this.InvoiceServiceTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceServiceTabPage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InvoiceServiceTabPage.Location = new System.Drawing.Point(4, 22);
            this.InvoiceServiceTabPage.Name = "InvoiceServiceTabPage";
            this.InvoiceServiceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.InvoiceServiceTabPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InvoiceServiceTabPage.Size = new System.Drawing.Size(352, 555);
            this.InvoiceServiceTabPage.TabIndex = 1;
            this.InvoiceServiceTabPage.Text = "InvoiceService";
            this.InvoiceServiceTabPage.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Cursor = System.Windows.Forms.Cursors.Default;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.label21.Location = new System.Drawing.Point(42, 296);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label21.Size = new System.Drawing.Size(46, 13);
            this.label21.TabIndex = 51;
            this.label21.Text = "Country:";
            // 
            // invoiceCountry
            // 
            this.invoiceCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.invoiceCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceCountry.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.invoiceCountry.Location = new System.Drawing.Point(94, 293);
            this.invoiceCountry.Name = "invoiceCountry";
            this.invoiceCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.invoiceCountry.Size = new System.Drawing.Size(100, 20);
            this.invoiceCountry.TabIndex = 50;
            this.invoiceCountry.Text = "SE";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Cursor = System.Windows.Forms.Cursors.Default;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.label20.Location = new System.Drawing.Point(61, 270);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label20.Size = new System.Drawing.Size(27, 13);
            this.label20.TabIndex = 49;
            this.label20.Text = "City:";
            // 
            // invoiceCity
            // 
            this.invoiceCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.invoiceCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceCity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.invoiceCity.Location = new System.Drawing.Point(94, 267);
            this.invoiceCity.Name = "invoiceCity";
            this.invoiceCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.invoiceCity.Size = new System.Drawing.Size(100, 20);
            this.invoiceCity.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.label14.Location = new System.Drawing.Point(39, 244);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Zipcode:";
            // 
            // invoiceZipcode
            // 
            this.invoiceZipcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.invoiceZipcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceZipcode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.invoiceZipcode.Location = new System.Drawing.Point(94, 241);
            this.invoiceZipcode.Name = "invoiceZipcode";
            this.invoiceZipcode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.invoiceZipcode.Size = new System.Drawing.Size(100, 20);
            this.invoiceZipcode.TabIndex = 46;
            // 
            // sendInvoiceButton
            // 
            this.sendInvoiceButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.sendInvoiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendInvoiceButton.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.sendInvoiceButton.Location = new System.Drawing.Point(258, 291);
            this.sendInvoiceButton.Name = "sendInvoiceButton";
            this.sendInvoiceButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sendInvoiceButton.Size = new System.Drawing.Size(88, 23);
            this.sendInvoiceButton.TabIndex = 45;
            this.sendInvoiceButton.Text = "SendInvoice()";
            this.sendInvoiceButton.UseVisualStyleBackColor = true;
            this.sendInvoiceButton.Click += new System.EventHandler(this.sendInvoiceButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.label10.Location = new System.Drawing.Point(50, 218);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Street:";
            // 
            // invoiceStreet
            // 
            this.invoiceStreet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.invoiceStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceStreet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.invoiceStreet.Location = new System.Drawing.Point(94, 215);
            this.invoiceStreet.Name = "invoiceStreet";
            this.invoiceStreet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.invoiceStreet.Size = new System.Drawing.Size(100, 20);
            this.invoiceStreet.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.label11.Location = new System.Drawing.Point(36, 192);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Currency:";
            // 
            // invoiceCurrency
            // 
            this.invoiceCurrency.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.invoiceCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceCurrency.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.invoiceCurrency.Location = new System.Drawing.Point(94, 189);
            this.invoiceCurrency.Name = "invoiceCurrency";
            this.invoiceCurrency.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.invoiceCurrency.Size = new System.Drawing.Size(100, 20);
            this.invoiceCurrency.TabIndex = 41;
            this.invoiceCurrency.Text = "SEK";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.label12.Location = new System.Drawing.Point(42, 166);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Amount:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.label13.Location = new System.Drawing.Point(28, 140);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Reference:";
            // 
            // invoiceAmount
            // 
            this.invoiceAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.invoiceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceAmount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.invoiceAmount.Location = new System.Drawing.Point(94, 163);
            this.invoiceAmount.Name = "invoiceAmount";
            this.invoiceAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.invoiceAmount.Size = new System.Drawing.Size(100, 20);
            this.invoiceAmount.TabIndex = 38;
            // 
            // invoiceReference
            // 
            this.invoiceReference.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.invoiceReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceReference.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.invoiceReference.Location = new System.Drawing.Point(94, 137);
            this.invoiceReference.Name = "invoiceReference";
            this.invoiceReference.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.invoiceReference.Size = new System.Drawing.Size(100, 20);
            this.invoiceReference.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Cursor = System.Windows.Forms.Cursors.Default;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.label15.Location = new System.Drawing.Point(35, 117);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "DueDate:";
            // 
            // invoiceDueDate
            // 
            this.invoiceDueDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceDueDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.invoiceDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceDueDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.invoiceDueDate.Location = new System.Drawing.Point(94, 111);
            this.invoiceDueDate.Name = "invoiceDueDate";
            this.invoiceDueDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.invoiceDueDate.Size = new System.Drawing.Size(151, 20);
            this.invoiceDueDate.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Cursor = System.Windows.Forms.Cursors.Default;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.label16.Location = new System.Drawing.Point(5, 87);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label16.Size = new System.Drawing.Size(83, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "ItemDescription:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Cursor = System.Windows.Forms.Cursors.Default;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.label17.Location = new System.Drawing.Point(9, 61);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "InvoiceNumber";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.label18.Location = new System.Drawing.Point(33, 35);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "Recipient:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Cursor = System.Windows.Forms.Cursors.Default;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.label19.Location = new System.Drawing.Point(44, 9);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "Sender:";
            // 
            // invoiceItemDescription
            // 
            this.invoiceItemDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.invoiceItemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceItemDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.invoiceItemDescription.Location = new System.Drawing.Point(94, 84);
            this.invoiceItemDescription.Name = "invoiceItemDescription";
            this.invoiceItemDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.invoiceItemDescription.Size = new System.Drawing.Size(100, 20);
            this.invoiceItemDescription.TabIndex = 28;
            // 
            // invoiceNumber
            // 
            this.invoiceNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.invoiceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.invoiceNumber.Location = new System.Drawing.Point(94, 58);
            this.invoiceNumber.Name = "invoiceNumber";
            this.invoiceNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.invoiceNumber.Size = new System.Drawing.Size(100, 20);
            this.invoiceNumber.TabIndex = 27;
            // 
            // invoiceRecipient
            // 
            this.invoiceRecipient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.invoiceRecipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceRecipient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.invoiceRecipient.Location = new System.Drawing.Point(94, 32);
            this.invoiceRecipient.Name = "invoiceRecipient";
            this.invoiceRecipient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.invoiceRecipient.Size = new System.Drawing.Size(100, 20);
            this.invoiceRecipient.TabIndex = 26;
            // 
            // invoiceSender
            // 
            this.invoiceSender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.invoiceSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceSender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.invoiceSender.Location = new System.Drawing.Point(94, 6);
            this.invoiceSender.Name = "invoiceSender";
            this.invoiceSender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.invoiceSender.Size = new System.Drawing.Size(100, 20);
            this.invoiceSender.TabIndex = 25;
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
            this.InvoiceServiceTabPage.ResumeLayout(false);
            this.InvoiceServiceTabPage.PerformLayout();
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
        private System.Windows.Forms.Button sendInvoiceButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox invoiceStreet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox invoiceCurrency;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox invoiceAmount;
        private System.Windows.Forms.TextBox invoiceReference;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker invoiceDueDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox invoiceItemDescription;
        private System.Windows.Forms.TextBox invoiceNumber;
        private System.Windows.Forms.TextBox invoiceRecipient;
        private System.Windows.Forms.TextBox invoiceSender;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox invoiceCountry;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox invoiceCity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox invoiceZipcode;
    }
}

