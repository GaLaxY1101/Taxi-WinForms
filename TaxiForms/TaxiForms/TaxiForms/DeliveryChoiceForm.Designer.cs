using Taxi;

namespace TaxiForms
{
    partial class DeliveryChoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryChoiceForm));
            this.deliveryChoicePanel = new System.Windows.Forms.Panel();
            this.deliveryBuLorryLabel = new System.Windows.Forms.Label();
            this.deliveryByCarLabel = new System.Windows.Forms.Label();
            this.deliveryLabel = new System.Windows.Forms.Label();
            this.deliveryChoicePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // deliveryChoicePanel
            // 
            this.deliveryChoicePanel.BackColor = System.Drawing.Color.Yellow;
            this.deliveryChoicePanel.Controls.Add(this.deliveryBuLorryLabel);
            this.deliveryChoicePanel.Controls.Add(this.deliveryByCarLabel);
            this.deliveryChoicePanel.Controls.Add(this.deliveryLabel);
            this.deliveryChoicePanel.Location = new System.Drawing.Point(233, 208);
            this.deliveryChoicePanel.Name = "deliveryChoicePanel";
            this.deliveryChoicePanel.Size = new System.Drawing.Size(561, 293);
            this.deliveryChoicePanel.TabIndex = 3;
            // 
            // deliveryBuLorryLabel
            // 
            this.deliveryBuLorryLabel.AutoSize = true;
            this.deliveryBuLorryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deliveryBuLorryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deliveryBuLorryLabel.Location = new System.Drawing.Point(306, 107);
            this.deliveryBuLorryLabel.Name = "deliveryBuLorryLabel";
            this.deliveryBuLorryLabel.Padding = new System.Windows.Forms.Padding(10);
            this.deliveryBuLorryLabel.Size = new System.Drawing.Size(206, 112);
            this.deliveryBuLorryLabel.TabIndex = 3;
            this.deliveryBuLorryLabel.Text = "Вантажне\r\n(50-500 кг)";
            this.deliveryBuLorryLabel.Click += new System.EventHandler(this.deliveryBuLorryLabel_Click);
            // 
            // deliveryByCarLabel
            // 
            this.deliveryByCarLabel.AutoSize = true;
            this.deliveryByCarLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deliveryByCarLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deliveryByCarLabel.Location = new System.Drawing.Point(47, 107);
            this.deliveryByCarLabel.Name = "deliveryByCarLabel";
            this.deliveryByCarLabel.Padding = new System.Windows.Forms.Padding(10);
            this.deliveryByCarLabel.Size = new System.Drawing.Size(170, 112);
            this.deliveryByCarLabel.TabIndex = 2;
            this.deliveryByCarLabel.Text = "Легкове\r\n(0-50 кг)";
            this.deliveryByCarLabel.Click += new System.EventHandler(this.deliveryByCarLabel_Click);
            // 
            // deliveryLabel
            // 
            this.deliveryLabel.AutoSize = true;
            this.deliveryLabel.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deliveryLabel.Location = new System.Drawing.Point(171, 0);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(220, 59);
            this.deliveryLabel.TabIndex = 1;
            this.deliveryLabel.Text = "Доставка";
            // 
            // DeliveryChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1026, 712);
            this.Controls.Add(this.deliveryChoicePanel);
            this.Name = "DeliveryChoiceForm";
            this.Text = "DeliveryChoiceForm";
            this.deliveryChoicePanel.ResumeLayout(false);
            this.deliveryChoicePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel deliveryChoicePanel;
        private Label deliveryBuLorryLabel;
        private Label deliveryByCarLabel;
        private Label deliveryLabel;

        public Customer MyCustomer { get; set; }
        public Address DestinationAddress { get; set; }

        public StartPoint StartAddress { get; set; }
    }
}