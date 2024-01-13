using Taxi;

namespace TaxiForms
{
    partial class TaxiChoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.taxiChoicePanel = new System.Windows.Forms.Panel();
            this.chooseAdditionalOptionsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.chooseAdditionalOptionsLabel = new System.Windows.Forms.Label();
            this.chooseCarClassCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.chooseAutoCLassLabel = new System.Windows.Forms.Label();
            this.taxiLabel = new System.Windows.Forms.Label();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.taxiChoicePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 31.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "КПІ ТАКСІ";
            // 
            // taxiChoicePanel
            // 
            this.taxiChoicePanel.BackColor = System.Drawing.Color.Yellow;
            this.taxiChoicePanel.Controls.Add(this.chooseAdditionalOptionsCheckedListBox);
            this.taxiChoicePanel.Controls.Add(this.chooseAdditionalOptionsLabel);
            this.taxiChoicePanel.Controls.Add(this.chooseCarClassCheckedListBox);
            this.taxiChoicePanel.Controls.Add(this.chooseAutoCLassLabel);
            this.taxiChoicePanel.Controls.Add(this.taxiLabel);
            this.taxiChoicePanel.Location = new System.Drawing.Point(341, 162);
            this.taxiChoicePanel.Name = "taxiChoicePanel";
            this.taxiChoicePanel.Size = new System.Drawing.Size(445, 319);
            this.taxiChoicePanel.TabIndex = 2;
            // 
            // chooseAdditionalOptionsCheckedListBox
            // 
            this.chooseAdditionalOptionsCheckedListBox.BackColor = System.Drawing.Color.Yellow;
            this.chooseAdditionalOptionsCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chooseAdditionalOptionsCheckedListBox.CheckOnClick = true;
            this.chooseAdditionalOptionsCheckedListBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseAdditionalOptionsCheckedListBox.FormattingEnabled = true;
            this.chooseAdditionalOptionsCheckedListBox.Items.AddRange(new object[] {
            "Діти",
            "Тварини"});
            this.chooseAdditionalOptionsCheckedListBox.Location = new System.Drawing.Point(242, 127);
            this.chooseAdditionalOptionsCheckedListBox.Name = "chooseAdditionalOptionsCheckedListBox";
            this.chooseAdditionalOptionsCheckedListBox.Size = new System.Drawing.Size(167, 114);
            this.chooseAdditionalOptionsCheckedListBox.TabIndex = 5;
            // 
            // chooseAdditionalOptionsLabel
            // 
            this.chooseAdditionalOptionsLabel.AutoSize = true;
            this.chooseAdditionalOptionsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chooseAdditionalOptionsLabel.Location = new System.Drawing.Point(237, 80);
            this.chooseAdditionalOptionsLabel.Name = "chooseAdditionalOptionsLabel";
            this.chooseAdditionalOptionsLabel.Size = new System.Drawing.Size(186, 41);
            this.chooseAdditionalOptionsLabel.TabIndex = 4;
            this.chooseAdditionalOptionsLabel.Text = "Додатково:";
            // 
            // chooseCarClassCheckedListBox
            // 
            this.chooseCarClassCheckedListBox.BackColor = System.Drawing.Color.Yellow;
            this.chooseCarClassCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chooseCarClassCheckedListBox.CheckOnClick = true;
            this.chooseCarClassCheckedListBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseCarClassCheckedListBox.FormattingEnabled = true;
            this.chooseCarClassCheckedListBox.Items.AddRange(new object[] {
            "Економ",
            "Комфорт",
            "Бізнес",
            "Мінібус"});
            this.chooseCarClassCheckedListBox.Location = new System.Drawing.Point(25, 124);
            this.chooseCarClassCheckedListBox.Name = "chooseCarClassCheckedListBox";
            this.chooseCarClassCheckedListBox.Size = new System.Drawing.Size(167, 190);
            this.chooseCarClassCheckedListBox.TabIndex = 3;
            this.chooseCarClassCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chooseCarClassCheckedListBox_ItemCheck);
            // 
            // chooseAutoCLassLabel
            // 
            this.chooseAutoCLassLabel.AutoSize = true;
            this.chooseAutoCLassLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chooseAutoCLassLabel.Location = new System.Drawing.Point(16, 80);
            this.chooseAutoCLassLabel.Name = "chooseAutoCLassLabel";
            this.chooseAutoCLassLabel.Size = new System.Drawing.Size(167, 41);
            this.chooseAutoCLassLabel.TabIndex = 1;
            this.chooseAutoCLassLabel.Text = "Клас авто:";
            // 
            // taxiLabel
            // 
            this.taxiLabel.AutoSize = true;
            this.taxiLabel.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.taxiLabel.Location = new System.Drawing.Point(141, 16);
            this.taxiLabel.Name = "taxiLabel";
            this.taxiLabel.Size = new System.Drawing.Size(125, 59);
            this.taxiLabel.TabIndex = 0;
            this.taxiLabel.Text = "Таксі";
            // 
            // createOrderButton
            // 
            this.createOrderButton.BackColor = System.Drawing.Color.LawnGreen;
            this.createOrderButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createOrderButton.Location = new System.Drawing.Point(341, 487);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(445, 62);
            this.createOrderButton.TabIndex = 6;
            this.createOrderButton.Text = "створити замовлення";
            this.createOrderButton.UseVisualStyleBackColor = false;
            this.createOrderButton.Click += new System.EventHandler(this.createOrderButton_Click);
            // 
            // TaxiChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TaxiForms.Properties.Resources.map;
            this.ClientSize = new System.Drawing.Size(1026, 712);
            this.Controls.Add(this.createOrderButton);
            this.Controls.Add(this.taxiChoicePanel);
            this.Controls.Add(this.label1);
            this.Name = "TaxiChoice";
            this.Text = "TaxiChoice";
            this.taxiChoicePanel.ResumeLayout(false);
            this.taxiChoicePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel taxiChoicePanel;
        private Label taxiLabel;
        private CheckedListBox chooseAdditionalOptionsCheckedListBox;
        private Label chooseAdditionalOptionsLabel;
        private CheckedListBox chooseCarClassCheckedListBox;
        private Label chooseAutoCLassLabel;
        private Button createOrderButton;

        public Customer MyCustomer { get; set; }
        public Address DestinationAddress { get; set; }

        public StartPoint StartAddress { get; set; }
    }
}