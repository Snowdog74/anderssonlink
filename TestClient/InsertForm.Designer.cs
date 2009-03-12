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
            this.customerNoLabel = new System.Windows.Forms.Label();
            this.customerOrderNoLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.currencyLabel = new System.Windows.Forms.Label();
            this.recipientLabel = new System.Windows.Forms.Label();
            this.articleNoField = new System.Windows.Forms.TextBox();
            this.descriptionField = new System.Windows.Forms.TextBox();
            this.quantityField = new System.Windows.Forms.TextBox();
            this.piecePriceField = new System.Windows.Forms.TextBox();
            this.customerField = new System.Windows.Forms.TextBox();
            this.customerNoField = new System.Windows.Forms.TextBox();
            this.customerOrderNoField = new System.Windows.Forms.TextBox();
            this.infoField = new System.Windows.Forms.TextBox();
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
            this.ArticleNoLabel.Location = new System.Drawing.Point(8, 9);
            this.ArticleNoLabel.Name = "ArticleNoLabel";
            this.ArticleNoLabel.Size = new System.Drawing.Size(53, 13);
            this.ArticleNoLabel.TabIndex = 1;
            this.ArticleNoLabel.Text = "ArticleNo:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(8, 33);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "Description:";
            // 
            // orderDatePicker
            // 
            this.orderDatePicker.Location = new System.Drawing.Point(120, 59);
            this.orderDatePicker.Name = "orderDatePicker";
            this.orderDatePicker.Size = new System.Drawing.Size(200, 20);
            this.orderDatePicker.TabIndex = 3;
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Location = new System.Drawing.Point(8, 59);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(60, 13);
            this.orderDateLabel.TabIndex = 4;
            this.orderDateLabel.Text = "Order date:";
            // 
            // deliveryDateLabel
            // 
            this.deliveryDateLabel.AutoSize = true;
            this.deliveryDateLabel.Location = new System.Drawing.Point(8, 85);
            this.deliveryDateLabel.Name = "deliveryDateLabel";
            this.deliveryDateLabel.Size = new System.Drawing.Size(72, 13);
            this.deliveryDateLabel.TabIndex = 6;
            this.deliveryDateLabel.Text = "Delivery date:";
            // 
            // deliveryDatePicker
            // 
            this.deliveryDatePicker.Location = new System.Drawing.Point(120, 85);
            this.deliveryDatePicker.Name = "deliveryDatePicker";
            this.deliveryDatePicker.Size = new System.Drawing.Size(200, 20);
            this.deliveryDatePicker.TabIndex = 5;
            // 
            // piecePriceLabel
            // 
            this.piecePriceLabel.AutoSize = true;
            this.piecePriceLabel.Location = new System.Drawing.Point(8, 137);
            this.piecePriceLabel.Name = "piecePriceLabel";
            this.piecePriceLabel.Size = new System.Drawing.Size(63, 13);
            this.piecePriceLabel.TabIndex = 7;
            this.piecePriceLabel.Text = "Piece price:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(8, 111);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(49, 13);
            this.quantityLabel.TabIndex = 8;
            this.quantityLabel.Text = "Quantity:";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(8, 163);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(54, 13);
            this.customerLabel.TabIndex = 9;
            this.customerLabel.Text = "Customer:";
            // 
            // customerNoLabel
            // 
            this.customerNoLabel.AutoSize = true;
            this.customerNoLabel.Location = new System.Drawing.Point(8, 189);
            this.customerNoLabel.Name = "customerNoLabel";
            this.customerNoLabel.Size = new System.Drawing.Size(72, 13);
            this.customerNoLabel.TabIndex = 10;
            this.customerNoLabel.Text = "Customer no: ";
            // 
            // customerOrderNoLabel
            // 
            this.customerOrderNoLabel.AutoSize = true;
            this.customerOrderNoLabel.Location = new System.Drawing.Point(8, 215);
            this.customerOrderNoLabel.Name = "customerOrderNoLabel";
            this.customerOrderNoLabel.Size = new System.Drawing.Size(96, 13);
            this.customerOrderNoLabel.TabIndex = 11;
            this.customerOrderNoLabel.Text = "Customer order no:";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(8, 241);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(28, 13);
            this.infoLabel.TabIndex = 12;
            this.infoLabel.Text = "Info:";
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.Location = new System.Drawing.Point(8, 267);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(52, 13);
            this.currencyLabel.TabIndex = 13;
            this.currencyLabel.Text = "Currency:";
            // 
            // recipientLabel
            // 
            this.recipientLabel.AutoSize = true;
            this.recipientLabel.Location = new System.Drawing.Point(8, 293);
            this.recipientLabel.Name = "recipientLabel";
            this.recipientLabel.Size = new System.Drawing.Size(55, 13);
            this.recipientLabel.TabIndex = 14;
            this.recipientLabel.Text = "Recipient:";
            // 
            // articleNoField
            // 
            this.articleNoField.Location = new System.Drawing.Point(120, 9);
            this.articleNoField.Name = "articleNoField";
            this.articleNoField.Size = new System.Drawing.Size(100, 20);
            this.articleNoField.TabIndex = 15;
            // 
            // descriptionField
            // 
            this.descriptionField.Location = new System.Drawing.Point(120, 33);
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.Size = new System.Drawing.Size(100, 20);
            this.descriptionField.TabIndex = 16;
            // 
            // quantityField
            // 
            this.quantityField.Location = new System.Drawing.Point(120, 111);
            this.quantityField.Name = "quantityField";
            this.quantityField.Size = new System.Drawing.Size(100, 20);
            this.quantityField.TabIndex = 17;
            // 
            // piecePriceField
            // 
            this.piecePriceField.Location = new System.Drawing.Point(120, 137);
            this.piecePriceField.Name = "piecePriceField";
            this.piecePriceField.Size = new System.Drawing.Size(100, 20);
            this.piecePriceField.TabIndex = 18;
            // 
            // customerField
            // 
            this.customerField.Location = new System.Drawing.Point(120, 163);
            this.customerField.Name = "customerField";
            this.customerField.Size = new System.Drawing.Size(100, 20);
            this.customerField.TabIndex = 19;
            // 
            // customerNoField
            // 
            this.customerNoField.Location = new System.Drawing.Point(120, 189);
            this.customerNoField.Name = "customerNoField";
            this.customerNoField.Size = new System.Drawing.Size(100, 20);
            this.customerNoField.TabIndex = 20;
            // 
            // customerOrderNoField
            // 
            this.customerOrderNoField.Location = new System.Drawing.Point(120, 215);
            this.customerOrderNoField.Name = "customerOrderNoField";
            this.customerOrderNoField.Size = new System.Drawing.Size(100, 20);
            this.customerOrderNoField.TabIndex = 21;
            // 
            // infoField
            // 
            this.infoField.Location = new System.Drawing.Point(120, 241);
            this.infoField.Name = "infoField";
            this.infoField.Size = new System.Drawing.Size(100, 20);
            this.infoField.TabIndex = 22;
            // 
            // currencyField
            // 
            this.currencyField.Location = new System.Drawing.Point(120, 267);
            this.currencyField.Name = "currencyField";
            this.currencyField.Size = new System.Drawing.Size(100, 20);
            this.currencyField.TabIndex = 23;
            this.currencyField.Text = "SEK";
            // 
            // recipientField
            // 
            this.recipientField.Location = new System.Drawing.Point(120, 293);
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
            this.Controls.Add(this.infoField);
            this.Controls.Add(this.customerOrderNoField);
            this.Controls.Add(this.customerNoField);
            this.Controls.Add(this.customerField);
            this.Controls.Add(this.piecePriceField);
            this.Controls.Add(this.quantityField);
            this.Controls.Add(this.descriptionField);
            this.Controls.Add(this.articleNoField);
            this.Controls.Add(this.recipientLabel);
            this.Controls.Add(this.currencyLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.customerOrderNoLabel);
            this.Controls.Add(this.customerNoLabel);
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
        private System.Windows.Forms.Label customerNoLabel;
        private System.Windows.Forms.Label customerOrderNoLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label currencyLabel;
        private System.Windows.Forms.Label recipientLabel;
        private System.Windows.Forms.TextBox articleNoField;
        private System.Windows.Forms.TextBox descriptionField;
        private System.Windows.Forms.TextBox quantityField;
        private System.Windows.Forms.TextBox piecePriceField;
        private System.Windows.Forms.TextBox customerField;
        private System.Windows.Forms.TextBox customerNoField;
        private System.Windows.Forms.TextBox customerOrderNoField;
        private System.Windows.Forms.TextBox infoField;
        private System.Windows.Forms.TextBox currencyField;
        private System.Windows.Forms.TextBox recipientField;
        private System.Windows.Forms.Button cancelButton;
    }
}