namespace CoffeeShopSystem
{
    partial class Mainscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainscreen));
            this.MainscreenHeader = new System.Windows.Forms.Label();
            this.MainscreenIDLabel = new System.Windows.Forms.Label();
            this.MainscreenCoffeeNameLabel = new System.Windows.Forms.Label();
            this.MainscreenTypeLabel = new System.Windows.Forms.Label();
            this.MainscreenQuantityLabel = new System.Windows.Forms.Label();
            this.MainscreenPaymentLabel = new System.Windows.Forms.Label();
            this.MainscreenIDTextbox = new System.Windows.Forms.TextBox();
            this.MainscreenCoffeeNameComboBox = new System.Windows.Forms.ComboBox();
            this.MainscreenTypeComboBox = new System.Windows.Forms.ComboBox();
            this.MainscreenQuantityComboBox = new System.Windows.Forms.ComboBox();
            this.MainscreenPaymentTextBox = new System.Windows.Forms.TextBox();
            this.Dgv1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCoffee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainscreenInsertButton = new System.Windows.Forms.Button();
            this.MainscreenClearButton = new System.Windows.Forms.Button();
            this.MainscreenExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainscreenHeader
            // 
            this.MainscreenHeader.AutoSize = true;
            this.MainscreenHeader.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainscreenHeader.Location = new System.Drawing.Point(648, 22);
            this.MainscreenHeader.Name = "MainscreenHeader";
            this.MainscreenHeader.Size = new System.Drawing.Size(234, 35);
            this.MainscreenHeader.TabIndex = 0;
            this.MainscreenHeader.Text = "Cleveland Coffee Shop";
            this.MainscreenHeader.Click += new System.EventHandler(this.Label1_Click);
            // 
            // MainscreenIDLabel
            // 
            this.MainscreenIDLabel.AutoSize = true;
            this.MainscreenIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainscreenIDLabel.Location = new System.Drawing.Point(15, 73);
            this.MainscreenIDLabel.Name = "MainscreenIDLabel";
            this.MainscreenIDLabel.Size = new System.Drawing.Size(34, 20);
            this.MainscreenIDLabel.TabIndex = 1;
            this.MainscreenIDLabel.Text = "ID: ";
            // 
            // MainscreenCoffeeNameLabel
            // 
            this.MainscreenCoffeeNameLabel.AutoSize = true;
            this.MainscreenCoffeeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainscreenCoffeeNameLabel.Location = new System.Drawing.Point(15, 127);
            this.MainscreenCoffeeNameLabel.Name = "MainscreenCoffeeNameLabel";
            this.MainscreenCoffeeNameLabel.Size = new System.Drawing.Size(111, 20);
            this.MainscreenCoffeeNameLabel.TabIndex = 2;
            this.MainscreenCoffeeNameLabel.Text = "Coffee Name: ";
            // 
            // MainscreenTypeLabel
            // 
            this.MainscreenTypeLabel.AutoSize = true;
            this.MainscreenTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainscreenTypeLabel.Location = new System.Drawing.Point(15, 177);
            this.MainscreenTypeLabel.Name = "MainscreenTypeLabel";
            this.MainscreenTypeLabel.Size = new System.Drawing.Size(51, 20);
            this.MainscreenTypeLabel.TabIndex = 3;
            this.MainscreenTypeLabel.Text = "Type: ";
            // 
            // MainscreenQuantityLabel
            // 
            this.MainscreenQuantityLabel.AutoSize = true;
            this.MainscreenQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainscreenQuantityLabel.Location = new System.Drawing.Point(15, 236);
            this.MainscreenQuantityLabel.Name = "MainscreenQuantityLabel";
            this.MainscreenQuantityLabel.Size = new System.Drawing.Size(80, 20);
            this.MainscreenQuantityLabel.TabIndex = 4;
            this.MainscreenQuantityLabel.Text = "Quantity:  ";
            // 
            // MainscreenPaymentLabel
            // 
            this.MainscreenPaymentLabel.AutoSize = true;
            this.MainscreenPaymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainscreenPaymentLabel.Location = new System.Drawing.Point(15, 293);
            this.MainscreenPaymentLabel.Name = "MainscreenPaymentLabel";
            this.MainscreenPaymentLabel.Size = new System.Drawing.Size(79, 20);
            this.MainscreenPaymentLabel.TabIndex = 5;
            this.MainscreenPaymentLabel.Text = "Payment: ";
            // 
            // MainscreenIDTextbox
            // 
            this.MainscreenIDTextbox.Location = new System.Drawing.Point(146, 72);
            this.MainscreenIDTextbox.Name = "MainscreenIDTextbox";
            this.MainscreenIDTextbox.Size = new System.Drawing.Size(169, 20);
            this.MainscreenIDTextbox.TabIndex = 6;
            this.MainscreenIDTextbox.TextChanged += new System.EventHandler(this.MainscreenIDTextbox_TextChanged);
            this.MainscreenIDTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainscreenIDTextbox_KeyPress);
            // 
            // MainscreenCoffeeNameComboBox
            // 
            this.MainscreenCoffeeNameComboBox.FormattingEnabled = true;
            this.MainscreenCoffeeNameComboBox.Items.AddRange(new object[] {
            "Latte",
            "Cappuccino",
            "Chocolate"});
            this.MainscreenCoffeeNameComboBox.Location = new System.Drawing.Point(146, 127);
            this.MainscreenCoffeeNameComboBox.Name = "MainscreenCoffeeNameComboBox";
            this.MainscreenCoffeeNameComboBox.Size = new System.Drawing.Size(169, 21);
            this.MainscreenCoffeeNameComboBox.TabIndex = 7;
            // 
            // MainscreenTypeComboBox
            // 
            this.MainscreenTypeComboBox.FormattingEnabled = true;
            this.MainscreenTypeComboBox.Items.AddRange(new object[] {
            "Frapp",
            "Iced",
            "Hot"});
            this.MainscreenTypeComboBox.Location = new System.Drawing.Point(146, 175);
            this.MainscreenTypeComboBox.Name = "MainscreenTypeComboBox";
            this.MainscreenTypeComboBox.Size = new System.Drawing.Size(169, 21);
            this.MainscreenTypeComboBox.TabIndex = 8;
            // 
            // MainscreenQuantityComboBox
            // 
            this.MainscreenQuantityComboBox.FormattingEnabled = true;
            this.MainscreenQuantityComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.MainscreenQuantityComboBox.Location = new System.Drawing.Point(146, 236);
            this.MainscreenQuantityComboBox.Name = "MainscreenQuantityComboBox";
            this.MainscreenQuantityComboBox.Size = new System.Drawing.Size(169, 21);
            this.MainscreenQuantityComboBox.TabIndex = 9;
            // 
            // MainscreenPaymentTextBox
            // 
            this.MainscreenPaymentTextBox.Location = new System.Drawing.Point(146, 293);
            this.MainscreenPaymentTextBox.Name = "MainscreenPaymentTextBox";
            this.MainscreenPaymentTextBox.Size = new System.Drawing.Size(169, 20);
            this.MainscreenPaymentTextBox.TabIndex = 10;
            // 
            // Dgv1
            // 
            this.Dgv1.BackgroundColor = System.Drawing.Color.White;
            this.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameCoffee,
            this.Type,
            this.Quantity,
            this.Payment});
            this.Dgv1.Location = new System.Drawing.Point(389, 72);
            this.Dgv1.Name = "Dgv1";
            this.Dgv1.ReadOnly = true;
            this.Dgv1.Size = new System.Drawing.Size(493, 212);
            this.Dgv1.TabIndex = 11;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // NameCoffee
            // 
            this.NameCoffee.HeaderText = "Name Coffee";
            this.NameCoffee.Name = "NameCoffee";
            this.NameCoffee.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Payment";
            this.Payment.Name = "Payment";
            this.Payment.ReadOnly = true;
            // 
            // MainscreenInsertButton
            // 
            this.MainscreenInsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainscreenInsertButton.Location = new System.Drawing.Point(401, 312);
            this.MainscreenInsertButton.Name = "MainscreenInsertButton";
            this.MainscreenInsertButton.Size = new System.Drawing.Size(75, 29);
            this.MainscreenInsertButton.TabIndex = 12;
            this.MainscreenInsertButton.Text = "Insert";
            this.MainscreenInsertButton.UseVisualStyleBackColor = true;
            this.MainscreenInsertButton.Click += new System.EventHandler(this.MainscreenInsertButton_Click);
            // 
            // MainscreenClearButton
            // 
            this.MainscreenClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainscreenClearButton.Location = new System.Drawing.Point(515, 312);
            this.MainscreenClearButton.Name = "MainscreenClearButton";
            this.MainscreenClearButton.Size = new System.Drawing.Size(75, 29);
            this.MainscreenClearButton.TabIndex = 13;
            this.MainscreenClearButton.Text = "Clear";
            this.MainscreenClearButton.UseVisualStyleBackColor = true;
            this.MainscreenClearButton.Click += new System.EventHandler(this.MainscreenClearButton_Click);
            // 
            // MainscreenExitButton
            // 
            this.MainscreenExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainscreenExitButton.Location = new System.Drawing.Point(807, 397);
            this.MainscreenExitButton.Name = "MainscreenExitButton";
            this.MainscreenExitButton.Size = new System.Drawing.Size(75, 29);
            this.MainscreenExitButton.TabIndex = 14;
            this.MainscreenExitButton.Text = "Exit";
            this.MainscreenExitButton.UseVisualStyleBackColor = true;
            this.MainscreenExitButton.Click += new System.EventHandler(this.MainscreenExitButton_Click);
            // 
            // Mainscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(911, 452);
            this.Controls.Add(this.MainscreenExitButton);
            this.Controls.Add(this.MainscreenClearButton);
            this.Controls.Add(this.MainscreenInsertButton);
            this.Controls.Add(this.Dgv1);
            this.Controls.Add(this.MainscreenPaymentTextBox);
            this.Controls.Add(this.MainscreenQuantityComboBox);
            this.Controls.Add(this.MainscreenTypeComboBox);
            this.Controls.Add(this.MainscreenCoffeeNameComboBox);
            this.Controls.Add(this.MainscreenIDTextbox);
            this.Controls.Add(this.MainscreenPaymentLabel);
            this.Controls.Add(this.MainscreenQuantityLabel);
            this.Controls.Add(this.MainscreenTypeLabel);
            this.Controls.Add(this.MainscreenCoffeeNameLabel);
            this.Controls.Add(this.MainscreenIDLabel);
            this.Controls.Add(this.MainscreenHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainscreen";
            this.Text = "CLEVELAND COFFEE SHOP";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainscreenHeader;
        private System.Windows.Forms.Label MainscreenIDLabel;
        private System.Windows.Forms.Label MainscreenCoffeeNameLabel;
        private System.Windows.Forms.Label MainscreenTypeLabel;
        private System.Windows.Forms.Label MainscreenQuantityLabel;
        private System.Windows.Forms.Label MainscreenPaymentLabel;
        private System.Windows.Forms.TextBox MainscreenIDTextbox;
        private System.Windows.Forms.ComboBox MainscreenCoffeeNameComboBox;
        private System.Windows.Forms.ComboBox MainscreenTypeComboBox;
        private System.Windows.Forms.ComboBox MainscreenQuantityComboBox;
        private System.Windows.Forms.TextBox MainscreenPaymentTextBox;
        private System.Windows.Forms.DataGridView Dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCoffee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.Button MainscreenInsertButton;
        private System.Windows.Forms.Button MainscreenClearButton;
        private System.Windows.Forms.Button MainscreenExitButton;
    }
}

