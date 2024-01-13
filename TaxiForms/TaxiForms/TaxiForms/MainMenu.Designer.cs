using Taxi;

namespace TaxiForms
{
    partial class MainMenu
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.addressesInputPanel = new System.Windows.Forms.Panel();
            this.enterPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.enterPhoneNumberLabel = new System.Windows.Forms.Label();
            this.enterNameTextBox = new System.Windows.Forms.TextBox();
            this.enterUserNameLabel = new System.Windows.Forms.Label();
            this.destinationHouseNumberTextBox = new System.Windows.Forms.TextBox();
            this.destinationStreetTextBox = new System.Windows.Forms.TextBox();
            this.startEntranseNumberTextBox = new System.Windows.Forms.TextBox();
            this.startHouseNumberTextBox = new System.Windows.Forms.TextBox();
            this.startStreetTextBox = new System.Windows.Forms.TextBox();
            this.destinationHouseNumberLabel = new System.Windows.Forms.Label();
            this.destinationStreetLabel = new System.Windows.Forms.Label();
            this.entranceNumberLabel = new System.Windows.Forms.Label();
            this.startHouseNumberLabel = new System.Windows.Forms.Label();
            this.startStreetLabel = new System.Windows.Forms.Label();
            this.destinationAddressLabel = new System.Windows.Forms.Label();
            this.startAddressArticleLabel = new System.Windows.Forms.Label();
            this.taxiChoiceButton = new System.Windows.Forms.Button();
            this.deliveryChoiceButton = new System.Windows.Forms.Button();
            this.addressesInputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Yellow;
            this.welcomeLabel.Font = new System.Drawing.Font("Century Gothic", 31.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(154, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(566, 65);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "ВАС ВІТАЄ КПІ ТАКСІ";
            // 
            // addressesInputPanel
            // 
            this.addressesInputPanel.BackColor = System.Drawing.Color.Yellow;
            this.addressesInputPanel.Controls.Add(this.enterPhoneNumberTextBox);
            this.addressesInputPanel.Controls.Add(this.enterPhoneNumberLabel);
            this.addressesInputPanel.Controls.Add(this.enterNameTextBox);
            this.addressesInputPanel.Controls.Add(this.enterUserNameLabel);
            this.addressesInputPanel.Controls.Add(this.destinationHouseNumberTextBox);
            this.addressesInputPanel.Controls.Add(this.destinationStreetTextBox);
            this.addressesInputPanel.Controls.Add(this.startEntranseNumberTextBox);
            this.addressesInputPanel.Controls.Add(this.welcomeLabel);
            this.addressesInputPanel.Controls.Add(this.startHouseNumberTextBox);
            this.addressesInputPanel.Controls.Add(this.startStreetTextBox);
            this.addressesInputPanel.Controls.Add(this.destinationHouseNumberLabel);
            this.addressesInputPanel.Controls.Add(this.destinationStreetLabel);
            this.addressesInputPanel.Controls.Add(this.entranceNumberLabel);
            this.addressesInputPanel.Controls.Add(this.startHouseNumberLabel);
            this.addressesInputPanel.Controls.Add(this.startStreetLabel);
            this.addressesInputPanel.Controls.Add(this.destinationAddressLabel);
            this.addressesInputPanel.Controls.Add(this.startAddressArticleLabel);
            this.addressesInputPanel.Location = new System.Drawing.Point(96, 52);
            this.addressesInputPanel.Name = "addressesInputPanel";
            this.addressesInputPanel.Size = new System.Drawing.Size(863, 511);
            this.addressesInputPanel.TabIndex = 1;
            // 
            // enterPhoneNumberTextBox
            // 
            this.enterPhoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterPhoneNumberTextBox.Location = new System.Drawing.Point(358, 179);
            this.enterPhoneNumberTextBox.Name = "enterPhoneNumberTextBox";
            this.enterPhoneNumberTextBox.Size = new System.Drawing.Size(279, 51);
            this.enterPhoneNumberTextBox.TabIndex = 15;
            // 
            // enterPhoneNumberLabel
            // 
            this.enterPhoneNumberLabel.AutoSize = true;
            this.enterPhoneNumberLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterPhoneNumberLabel.Location = new System.Drawing.Point(23, 178);
            this.enterPhoneNumberLabel.Name = "enterPhoneNumberLabel";
            this.enterPhoneNumberLabel.Size = new System.Drawing.Size(338, 50);
            this.enterPhoneNumberLabel.TabIndex = 14;
            this.enterPhoneNumberLabel.Text = "Номер телефону:";
            // 
            // enterNameTextBox
            // 
            this.enterNameTextBox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterNameTextBox.Location = new System.Drawing.Point(236, 102);
            this.enterNameTextBox.Name = "enterNameTextBox";
            this.enterNameTextBox.Size = new System.Drawing.Size(401, 51);
            this.enterNameTextBox.TabIndex = 13;
            // 
            // enterUserNameLabel
            // 
            this.enterUserNameLabel.AutoSize = true;
            this.enterUserNameLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterUserNameLabel.Location = new System.Drawing.Point(23, 101);
            this.enterUserNameLabel.Name = "enterUserNameLabel";
            this.enterUserNameLabel.Size = new System.Drawing.Size(210, 50);
            this.enterUserNameLabel.TabIndex = 12;
            this.enterUserNameLabel.Text = "Ваше ім\'я:";
            // 
            // destinationHouseNumberTextBox
            // 
            this.destinationHouseNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.destinationHouseNumberTextBox.Location = new System.Drawing.Point(617, 379);
            this.destinationHouseNumberTextBox.Name = "destinationHouseNumberTextBox";
            this.destinationHouseNumberTextBox.Size = new System.Drawing.Size(228, 51);
            this.destinationHouseNumberTextBox.TabIndex = 11;
            // 
            // destinationStreetTextBox
            // 
            this.destinationStreetTextBox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.destinationStreetTextBox.Location = new System.Drawing.Point(617, 319);
            this.destinationStreetTextBox.Name = "destinationStreetTextBox";
            this.destinationStreetTextBox.Size = new System.Drawing.Size(228, 51);
            this.destinationStreetTextBox.TabIndex = 10;
            // 
            // startEntranseNumberTextBox
            // 
            this.startEntranseNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startEntranseNumberTextBox.Location = new System.Drawing.Point(193, 445);
            this.startEntranseNumberTextBox.Name = "startEntranseNumberTextBox";
            this.startEntranseNumberTextBox.Size = new System.Drawing.Size(228, 51);
            this.startEntranseNumberTextBox.TabIndex = 9;
            // 
            // startHouseNumberTextBox
            // 
            this.startHouseNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startHouseNumberTextBox.Location = new System.Drawing.Point(193, 385);
            this.startHouseNumberTextBox.Name = "startHouseNumberTextBox";
            this.startHouseNumberTextBox.Size = new System.Drawing.Size(228, 51);
            this.startHouseNumberTextBox.TabIndex = 8;
            // 
            // startStreetTextBox
            // 
            this.startStreetTextBox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startStreetTextBox.Location = new System.Drawing.Point(193, 323);
            this.startStreetTextBox.Name = "startStreetTextBox";
            this.startStreetTextBox.Size = new System.Drawing.Size(228, 51);
            this.startStreetTextBox.TabIndex = 7;
            // 
            // destinationHouseNumberLabel
            // 
            this.destinationHouseNumberLabel.AutoSize = true;
            this.destinationHouseNumberLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.destinationHouseNumberLabel.Location = new System.Drawing.Point(447, 382);
            this.destinationHouseNumberLabel.Name = "destinationHouseNumberLabel";
            this.destinationHouseNumberLabel.Size = new System.Drawing.Size(160, 45);
            this.destinationHouseNumberLabel.TabIndex = 6;
            this.destinationHouseNumberLabel.Text = "Будинок*";
            // 
            // destinationStreetLabel
            // 
            this.destinationStreetLabel.AutoSize = true;
            this.destinationStreetLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.destinationStreetLabel.Location = new System.Drawing.Point(447, 320);
            this.destinationStreetLabel.Name = "destinationStreetLabel";
            this.destinationStreetLabel.Size = new System.Drawing.Size(142, 45);
            this.destinationStreetLabel.TabIndex = 5;
            this.destinationStreetLabel.Text = "Вулиця*";
            // 
            // entranceNumberLabel
            // 
            this.entranceNumberLabel.AutoSize = true;
            this.entranceNumberLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entranceNumberLabel.Location = new System.Drawing.Point(23, 445);
            this.entranceNumberLabel.Name = "entranceNumberLabel";
            this.entranceNumberLabel.Size = new System.Drawing.Size(119, 45);
            this.entranceNumberLabel.TabIndex = 4;
            this.entranceNumberLabel.Text = "Під\'їзд";
            // 
            // startHouseNumberLabel
            // 
            this.startHouseNumberLabel.AutoSize = true;
            this.startHouseNumberLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startHouseNumberLabel.Location = new System.Drawing.Point(23, 385);
            this.startHouseNumberLabel.Name = "startHouseNumberLabel";
            this.startHouseNumberLabel.Size = new System.Drawing.Size(160, 45);
            this.startHouseNumberLabel.TabIndex = 3;
            this.startHouseNumberLabel.Text = "Будинок*";
            // 
            // startStreetLabel
            // 
            this.startStreetLabel.AutoSize = true;
            this.startStreetLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startStreetLabel.Location = new System.Drawing.Point(23, 323);
            this.startStreetLabel.Name = "startStreetLabel";
            this.startStreetLabel.Size = new System.Drawing.Size(142, 45);
            this.startStreetLabel.TabIndex = 2;
            this.startStreetLabel.Text = "Вулиця*";
            // 
            // destinationAddressLabel
            // 
            this.destinationAddressLabel.AutoSize = true;
            this.destinationAddressLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.destinationAddressLabel.Location = new System.Drawing.Point(447, 258);
            this.destinationAddressLabel.Name = "destinationAddressLabel";
            this.destinationAddressLabel.Size = new System.Drawing.Size(119, 50);
            this.destinationAddressLabel.TabIndex = 1;
            this.destinationAddressLabel.Text = "Куди:";
            // 
            // startAddressArticleLabel
            // 
            this.startAddressArticleLabel.AutoSize = true;
            this.startAddressArticleLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startAddressArticleLabel.Location = new System.Drawing.Point(23, 258);
            this.startAddressArticleLabel.Name = "startAddressArticleLabel";
            this.startAddressArticleLabel.Size = new System.Drawing.Size(152, 50);
            this.startAddressArticleLabel.TabIndex = 0;
            this.startAddressArticleLabel.Text = "Звідки:";
            // 
            // taxiChoiceButton
            // 
            this.taxiChoiceButton.BackColor = System.Drawing.Color.Yellow;
            this.taxiChoiceButton.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.taxiChoiceButton.Location = new System.Drawing.Point(311, 569);
            this.taxiChoiceButton.Name = "taxiChoiceButton";
            this.taxiChoiceButton.Size = new System.Drawing.Size(205, 90);
            this.taxiChoiceButton.TabIndex = 2;
            this.taxiChoiceButton.Text = "Таксі";
            this.taxiChoiceButton.UseVisualStyleBackColor = false;
            this.taxiChoiceButton.Click += new System.EventHandler(this.taxiChoiceButton_Click);
            // 
            // deliveryChoiceButton
            // 
            this.deliveryChoiceButton.BackColor = System.Drawing.Color.Yellow;
            this.deliveryChoiceButton.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deliveryChoiceButton.Location = new System.Drawing.Point(564, 569);
            this.deliveryChoiceButton.Name = "deliveryChoiceButton";
            this.deliveryChoiceButton.Size = new System.Drawing.Size(205, 90);
            this.deliveryChoiceButton.TabIndex = 3;
            this.deliveryChoiceButton.Text = "Доставка";
            this.deliveryChoiceButton.UseVisualStyleBackColor = false;
            this.deliveryChoiceButton.Click += new System.EventHandler(this.deliveryChoiceButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TaxiForms.Properties.Resources.map;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1026, 712);
            this.Controls.Add(this.deliveryChoiceButton);
            this.Controls.Add(this.taxiChoiceButton);
            this.Controls.Add(this.addressesInputPanel);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.addressesInputPanel.ResumeLayout(false);
            this.addressesInputPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label welcomeLabel;
        private Panel addressesInputPanel;
        private Label destinationAddressLabel;
        private Label startAddressArticleLabel;
        private Label startStreetLabel;
        private Label startHouseNumberLabel;
        private Label destinationHouseNumberLabel;
        private Label destinationStreetLabel;
        private Label entranceNumberLabel;
        private TextBox startEntranseNumberTextBox;
        private TextBox startHouseNumberTextBox;
        private TextBox startStreetTextBox;
        private TextBox destinationHouseNumberTextBox;
        private TextBox destinationStreetTextBox;
        private Button taxiChoiceButton;
        private Button deliveryChoiceButton;
        private TextBox enterPhoneNumberTextBox;
        private Label enterPhoneNumberLabel;
        private TextBox enterNameTextBox;
        private Label enterUserNameLabel;

        public Taxi.TaxiCompany MyTaxiCompany { get; set; }

    }
}