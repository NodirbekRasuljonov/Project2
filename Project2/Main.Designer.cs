namespace Project2
{
    partial class Main
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
            this.addDonnerButton = new System.Windows.Forms.Button();
            this.allRecordsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addDonnerButton
            // 
            this.addDonnerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addDonnerButton.Location = new System.Drawing.Point(55, 129);
            this.addDonnerButton.Name = "addDonnerButton";
            this.addDonnerButton.Size = new System.Drawing.Size(189, 44);
            this.addDonnerButton.TabIndex = 0;
            this.addDonnerButton.Text = "Add Donner";
            this.addDonnerButton.UseVisualStyleBackColor = true;
            this.addDonnerButton.Click += new System.EventHandler(this.addDonnerButton_Click);
            // 
            // allRecordsButton
            // 
            this.allRecordsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.allRecordsButton.Location = new System.Drawing.Point(55, 189);
            this.allRecordsButton.Name = "allRecordsButton";
            this.allRecordsButton.Size = new System.Drawing.Size(189, 44);
            this.allRecordsButton.TabIndex = 1;
            this.allRecordsButton.Text = "All Records";
            this.allRecordsButton.UseVisualStyleBackColor = true;
            this.allRecordsButton.Click += new System.EventHandler(this.allRecordsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(55, 332);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(189, 44);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(71, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Blood Bank";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(279, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.allRecordsButton);
            this.Controls.Add(this.addDonnerButton);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addDonnerButton;
        private Button allRecordsButton;
        private Button exitButton;
        private Label label1;
    }
}