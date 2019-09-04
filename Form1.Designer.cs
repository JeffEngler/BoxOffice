namespace BoxOffice

{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddBandBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveBandBTN = new System.Windows.Forms.Button();
            this.TotalCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(46, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(569, 359);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // AddBandBTN
            // 
            this.AddBandBTN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddBandBTN.Location = new System.Drawing.Point(138, 392);
            this.AddBandBTN.Name = "AddBandBTN";
            this.AddBandBTN.Size = new System.Drawing.Size(122, 23);
            this.AddBandBTN.TabIndex = 1;
            this.AddBandBTN.Text = "Add Band";
            this.AddBandBTN.UseVisualStyleBackColor = true;
            this.AddBandBTN.Click += new System.EventHandler(this.AddBandBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Box Office!";
            // 
            // RemoveBandBTN
            // 
            this.RemoveBandBTN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RemoveBandBTN.Location = new System.Drawing.Point(10, 392);
            this.RemoveBandBTN.Name = "RemoveBandBTN";
            this.RemoveBandBTN.Size = new System.Drawing.Size(122, 23);
            this.RemoveBandBTN.TabIndex = 3;
            this.RemoveBandBTN.Text = "Remove Band";
            this.RemoveBandBTN.UseVisualStyleBackColor = true;
            this.RemoveBandBTN.Click += new System.EventHandler(this.RemoveBandBTN_Click);
            // 
            // TotalCountLabel
            // 
            this.TotalCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TotalCountLabel.AutoSize = true;
            this.TotalCountLabel.Location = new System.Drawing.Point(506, 397);
            this.TotalCountLabel.Name = "TotalCountLabel";
            this.TotalCountLabel.Size = new System.Drawing.Size(95, 17);
            this.TotalCountLabel.TabIndex = 4;
            this.TotalCountLabel.Text = "Total count: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 453);
            this.Controls.Add(this.TotalCountLabel);
            this.Controls.Add(this.RemoveBandBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBandBTN);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(675, 1000);
            this.MinimumSize = new System.Drawing.Size(675, 150);
            this.Name = "Form1";
            this.Text = "Box Office";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button AddBandBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveBandBTN;
        private System.Windows.Forms.Label TotalCountLabel;
    }
}

