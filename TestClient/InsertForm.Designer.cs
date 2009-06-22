namespace TestClient
{
    partial class InsertForm
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
            this.insertButton = new System.Windows.Forms.Button();
            this.ArticleNoLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.orderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.deliveryDateLabel = new System.Windows.Forms.Label();
            this.deliveryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.piecePriceLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.currencyLabel = new System.Windows.Forms.Label();
            this.recipientLabel = new System.Windows.Forms.Label();
            this.itemNumberField = new System.Windows.Forms.TextBox();
            this.itemDescriptionField = new System.Windows.Forms.TextBox();
            this.quantityField = new System.Windows.Forms.TextBox();
            this.priceField = new System.Windows.Forms.TextBox();
            this.senderField = new System.Windows.Forms.TextBox();
            this.textField = new System.Windows.Forms.TextBox();
            this.currencyField = new System.Windows.Forms.TextBox();
            this.recipientField = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(248, 329);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 0;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // ArticleNoLabel
            // 
            this.ArticleNoLabel.AutoSize = true;
            this.ArticleNoLabel.Location = new System.Drawing.Point(8, 64);
            this.ArticleNoLabel.Name = "ArticleNoLabel";
            this.ArticleNoLabel.Size = new System.Drawing.Size(67, 13);
            this.ArticleNoLabel.TabIndex = 1;
            this.ArticleNoLabel.Text = "ItemNumber:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(8, 88);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(83, 13);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "ItemDescription:";
            this.DescriptionLabel.Click += new System.EventHandler(this.DescriptionLabel_Click);
            // 
            // orderDatePicker
            // 
            this.orderDatePicker.Location = new System.Drawing.Point(120, 114);
            this.orderDatePicker.Name = "orderDatePicker";
            this.orderDatePicker.Size = new System.Drawing.Size(200, 20);
            this.orderDatePicker.TabIndex = 3;
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Location = new System.Drawing.Point(8, 114);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(60, 13);
            this.orderDateLabel.TabIndex = 4;
            this.orderDateLabel.Text = "Order date:";
            // 
            // deliveryDateLabel
            // 
            this.deliveryDateLabel.AutoSize = true;
            this.deliveryDateLabel.Location = new System.Drawing.Point(8, 140);
            this.deliveryDateLabel.Name = "deliveryDateLabel";
            this.deliveryDateLabel.Size = new System.Drawing.Size(72, 13);
            this.deliveryDateLabel.TabIndex = 6;
            this.deliveryDateLabel.Text = "Delivery date:";
            // 
            // deliveryDatePicker
            // 
            this.deliveryDatePicker.Location = new System.Drawing.Point(120, 140);
            this.deliveryDatePicker.Name = "deliveryDatePicker";
            this.deliveryDatePicker.Size = new System.Drawing.Size(200, 20);
            this.deliveryDatePicker.TabIndex = 5;
            // 
            // piecePriceLabel
            // 
            this.piecePriceLabel.AutoSize = true;
            this.piecePriceLabel.Location = new System.Drawing.Point(8, 192);
            this.piecePriceLabel.Name = "piecePriceLabel";
            this.piecePriceLabel.Size = new System.Drawing.Size(34, 13);
            this.piecePriceLabel.TabIndex = 7;
            this.piecePriceLabel.Text = "Price:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(8, 166);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(49, 13);
            this.quantityLabel.TabIndex = 8;
            this.quantityLabel.Text = "Quantity:";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(8, 12);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(44, 13);
            this.customerLabel.TabIndex = 9;
            this.customerLabel.Text = "Sender:";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(8, 251);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(31, 13);
            this.infoLabel.TabIndex = 12;
            this.infoLabel.Text = "Text:";
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.Location = new System.Drawing.Point(8, 221);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(52, 13);
            this.currencyLabel.TabIndex = 13;
            this.currencyLabel.Text = "Currency:";
            // 
            // recipientLabel
            // 
            this.recipientLabel.AutoSize = true;
            this.recipientLabel.Location = new System.Drawing.Point(8, 38);
            this.recipientLabel.Name = "recipientLabel";
            this.recipientLabel.Size = new System.Drawing.Size(55, 13);
            this.recipientLabel.TabIndex = 14;
            this.recipientLabel.Text = "Recipient:";
            // 
            // itemNumberField
            // 
            this.itemNumberField.Location = new System.Drawing.Point(120, 64);
            this.itemNumberField.Name = "itemNumberField";
            this.itemNumberField.Size = new System.Drawing.Size(100, 20);
            this.itemNumberField.TabIndex = 15;
            // 
            // itemDescriptionField
            // 
            this.itemDescriptionField.Location = new System.Drawing.Point(120, 88);
            this.itemDescriptionField.Name = "itemDescriptionField";
            this.itemDescriptionField.Size = new System.Drawing.Size(100, 20);
            this.itemDescriptionField.TabIndex = 16;
            // 
            // quantityField
            // 
            this.quantityField.Location = new System.Drawing.Point(120, 166);
            this.quantityField.Name = "quantityField";
            this.quantityField.Size = new System.Drawing.Size(100, 20);
            this.quantityField.TabIndex = 17;
            // 
            // priceField
            // 
            this.priceField.Location = new System.Drawing.Point(120, 192);
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(100, 20);
            this.priceField.TabIndex = 18;
            // 
            // senderField
            // 
            this.senderField.Location = new System.Drawing.Point(120, 12);
            this.senderField.Name = "senderField";
            this.senderField.Size = new System.Drawing.Size(100, 20);
            this.senderField.TabIndex = 19;
            // 
            // textField
            // 
            this.textField.Location = new System.Drawing.Point(120, 251);
            this.textField.Name = "textField";
            this.textField.Size = new System.Drawing.Size(100, 20);
            this.textField.TabIndex = 22;
            // 
            // currencyField
            // 
            this.currencyField.Location = new System.Drawing.Point(120, 221);
            this.currencyField.Name = "currencyField";
            this.currencyField.Size = new System.Drawing.Size(100, 20);
            this.currencyField.TabIndex = 23;
            this.currencyField.Text = "SEK";
            // 
            // recipientField
            // 
            this.recipientField.Location = new System.Drawing.Point(120, 38);
            this.recipientField.Name = "recipientField";
            this.recipientField.Size = new System.Drawing.Size(100, 20);
            this.recipientField.TabIndex = 24;
            this.recipientField.Text = "karl.bengtsson_gmail";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(167, 329);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 25;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 358);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.recipientField);
            this.Controls.Add(this.currencyField);
            this.Controls.Add(this.textField);
            this.Controls.Add(this.senderField);
            this.Controls.Add(this.priceField);
            this.Controls.Add(this.quantityField);
            this.Controls.Add(this.itemDescriptionField);
            this.Controls.Add(this.itemNumberField);
            this.Controls.Add(this.recipientLabel);
            this.Controls.Add(this.currencyLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.piecePriceLabel);
            this.Controls.Add(this.deliveryDateLabel);
            this.Controls.Add(this.deliveryDatePicker);
            this.Controls.Add(this.orderDateLabel);
            this.Controls.Add(this.orderDatePicker);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.ArticleNoLabel);
            this.Controls.Add(this.insertButton);
            this.Name = "InsertForm";
            this.Text = "InsertForm";
            this.Load += new System.EventHandler(this.InsertForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Label ArticleNoLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.DateTimePicker orderDatePicker;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.Label deliveryDateLabel;
        private System.Windows.Forms.DateTimePicker deliveryDatePicker;
        private System.Windows.Forms.Label piecePriceLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label currencyLabel;
        private System.Windows.Forms.Label recipientLabel;
        private System.Windows.Forms.TextBox itemNumberField;
        private System.Windows.Forms.TextBox itemDescriptionField;
        private System.Windows.Forms.TextBox quantityField;
        private System.Windows.Forms.TextBox priceField;
        private System.Windows.Forms.TextBox senderField;
        private System.Windows.Forms.TextBox textField;
        private System.Windows.Forms.TextBox currencyField;
        private System.Windows.Forms.TextBox recipientField;
        private System.Windows.Forms.Button cancelButton;
    }
}