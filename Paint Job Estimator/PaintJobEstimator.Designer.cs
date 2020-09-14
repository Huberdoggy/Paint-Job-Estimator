namespace Paint_Job_Estimator
{
    partial class PaintJobEstimator
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
            this.informationGroupBox = new System.Windows.Forms.GroupBox();
            this.pricePerGallonTextBox = new System.Windows.Forms.TextBox();
            this.wallSpaceTextBox = new System.Windows.Forms.TextBox();
            this.pricePerGallonLabel = new System.Windows.Forms.Label();
            this.wallSpaceLabel = new System.Windows.Forms.Label();
            this.totalPaintGallonsTextbox = new System.Windows.Forms.TextBox();
            this.totalJobCostTextbox = new System.Windows.Forms.TextBox();
            this.totalLaborHoursTextbox = new System.Windows.Forms.TextBox();
            this.totalLaborChargesTextbox = new System.Windows.Forms.TextBox();
            this.totalCostOfPaintTextBox = new System.Windows.Forms.TextBox();
            this.totalPaintGallonsLabel = new System.Windows.Forms.Label();
            this.totalLaborHoursLabel = new System.Windows.Forms.Label();
            this.totalCostOfPaintLabel = new System.Windows.Forms.Label();
            this.totalLaborChargesLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateJobButton = new System.Windows.Forms.Button();
            this.totalJobCostLabel = new System.Windows.Forms.Label();
            this.informationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // informationGroupBox
            // 
            this.informationGroupBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.informationGroupBox.Controls.Add(this.pricePerGallonTextBox);
            this.informationGroupBox.Controls.Add(this.wallSpaceTextBox);
            this.informationGroupBox.Controls.Add(this.pricePerGallonLabel);
            this.informationGroupBox.Controls.Add(this.wallSpaceLabel);
            this.informationGroupBox.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.informationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.informationGroupBox.Name = "informationGroupBox";
            this.informationGroupBox.Size = new System.Drawing.Size(307, 129);
            this.informationGroupBox.TabIndex = 0;
            this.informationGroupBox.TabStop = false;
            this.informationGroupBox.Text = "Information";
            // 
            // pricePerGallonTextBox
            // 
            this.pricePerGallonTextBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.pricePerGallonTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pricePerGallonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePerGallonTextBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.pricePerGallonTextBox.Location = new System.Drawing.Point(180, 94);
            this.pricePerGallonTextBox.Name = "pricePerGallonTextBox";
            this.pricePerGallonTextBox.Size = new System.Drawing.Size(100, 20);
            this.pricePerGallonTextBox.TabIndex = 3;
            // 
            // wallSpaceTextBox
            // 
            this.wallSpaceTextBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.wallSpaceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wallSpaceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wallSpaceTextBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.wallSpaceTextBox.Location = new System.Drawing.Point(180, 44);
            this.wallSpaceTextBox.Name = "wallSpaceTextBox";
            this.wallSpaceTextBox.Size = new System.Drawing.Size(100, 20);
            this.wallSpaceTextBox.TabIndex = 2;
            // 
            // pricePerGallonLabel
            // 
            this.pricePerGallonLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePerGallonLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pricePerGallonLabel.Location = new System.Drawing.Point(27, 81);
            this.pricePerGallonLabel.Name = "pricePerGallonLabel";
            this.pricePerGallonLabel.Size = new System.Drawing.Size(158, 30);
            this.pricePerGallonLabel.TabIndex = 1;
            this.pricePerGallonLabel.Text = "Enter The Price Per Gallon Of Paint:";
            // 
            // wallSpaceLabel
            // 
            this.wallSpaceLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wallSpaceLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.wallSpaceLabel.Location = new System.Drawing.Point(27, 34);
            this.wallSpaceLabel.Name = "wallSpaceLabel";
            this.wallSpaceLabel.Size = new System.Drawing.Size(158, 30);
            this.wallSpaceLabel.TabIndex = 0;
            this.wallSpaceLabel.Text = "Enter The Required Wall Space (ft. sq):\r\n";
            // 
            // totalPaintGallonsTextbox
            // 
            this.totalPaintGallonsTextbox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.totalPaintGallonsTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPaintGallonsTextbox.Enabled = false;
            this.totalPaintGallonsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPaintGallonsTextbox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.totalPaintGallonsTextbox.Location = new System.Drawing.Point(198, 178);
            this.totalPaintGallonsTextbox.Name = "totalPaintGallonsTextbox";
            this.totalPaintGallonsTextbox.Size = new System.Drawing.Size(100, 20);
            this.totalPaintGallonsTextbox.TabIndex = 1;
            this.totalPaintGallonsTextbox.Visible = false;
            // 
            // totalJobCostTextbox
            // 
            this.totalJobCostTextbox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.totalJobCostTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalJobCostTextbox.Enabled = false;
            this.totalJobCostTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalJobCostTextbox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.totalJobCostTextbox.Location = new System.Drawing.Point(198, 330);
            this.totalJobCostTextbox.Name = "totalJobCostTextbox";
            this.totalJobCostTextbox.Size = new System.Drawing.Size(100, 20);
            this.totalJobCostTextbox.TabIndex = 5;
            this.totalJobCostTextbox.Visible = false;
            // 
            // totalLaborHoursTextbox
            // 
            this.totalLaborHoursTextbox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.totalLaborHoursTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLaborHoursTextbox.Enabled = false;
            this.totalLaborHoursTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLaborHoursTextbox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.totalLaborHoursTextbox.Location = new System.Drawing.Point(198, 216);
            this.totalLaborHoursTextbox.Name = "totalLaborHoursTextbox";
            this.totalLaborHoursTextbox.Size = new System.Drawing.Size(100, 20);
            this.totalLaborHoursTextbox.TabIndex = 2;
            this.totalLaborHoursTextbox.Visible = false;
            // 
            // totalLaborChargesTextbox
            // 
            this.totalLaborChargesTextbox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.totalLaborChargesTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLaborChargesTextbox.Enabled = false;
            this.totalLaborChargesTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLaborChargesTextbox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.totalLaborChargesTextbox.Location = new System.Drawing.Point(198, 292);
            this.totalLaborChargesTextbox.Name = "totalLaborChargesTextbox";
            this.totalLaborChargesTextbox.Size = new System.Drawing.Size(100, 20);
            this.totalLaborChargesTextbox.TabIndex = 4;
            this.totalLaborChargesTextbox.Visible = false;
            // 
            // totalCostOfPaintTextBox
            // 
            this.totalCostOfPaintTextBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.totalCostOfPaintTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostOfPaintTextBox.Enabled = false;
            this.totalCostOfPaintTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostOfPaintTextBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.totalCostOfPaintTextBox.Location = new System.Drawing.Point(198, 254);
            this.totalCostOfPaintTextBox.Name = "totalCostOfPaintTextBox";
            this.totalCostOfPaintTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalCostOfPaintTextBox.TabIndex = 3;
            this.totalCostOfPaintTextBox.Visible = false;
            // 
            // totalPaintGallonsLabel
            // 
            this.totalPaintGallonsLabel.AutoSize = true;
            this.totalPaintGallonsLabel.BackColor = System.Drawing.Color.Black;
            this.totalPaintGallonsLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPaintGallonsLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.totalPaintGallonsLabel.Location = new System.Drawing.Point(34, 179);
            this.totalPaintGallonsLabel.Name = "totalPaintGallonsLabel";
            this.totalPaintGallonsLabel.Size = new System.Drawing.Size(153, 15);
            this.totalPaintGallonsLabel.TabIndex = 6;
            this.totalPaintGallonsLabel.Text = "Total Gallons Required:";
            this.totalPaintGallonsLabel.Visible = false;
            // 
            // totalLaborHoursLabel
            // 
            this.totalLaborHoursLabel.AutoSize = true;
            this.totalLaborHoursLabel.BackColor = System.Drawing.Color.Black;
            this.totalLaborHoursLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLaborHoursLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.totalLaborHoursLabel.Location = new System.Drawing.Point(34, 217);
            this.totalLaborHoursLabel.Name = "totalLaborHoursLabel";
            this.totalLaborHoursLabel.Size = new System.Drawing.Size(142, 15);
            this.totalLaborHoursLabel.TabIndex = 7;
            this.totalLaborHoursLabel.Text = "Total Hours Of Labor:";
            this.totalLaborHoursLabel.Visible = false;
            // 
            // totalCostOfPaintLabel
            // 
            this.totalCostOfPaintLabel.AutoSize = true;
            this.totalCostOfPaintLabel.BackColor = System.Drawing.Color.Black;
            this.totalCostOfPaintLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostOfPaintLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.totalCostOfPaintLabel.Location = new System.Drawing.Point(34, 255);
            this.totalCostOfPaintLabel.Name = "totalCostOfPaintLabel";
            this.totalCostOfPaintLabel.Size = new System.Drawing.Size(128, 15);
            this.totalCostOfPaintLabel.TabIndex = 8;
            this.totalCostOfPaintLabel.Text = "Total Cost Of Paint:";
            this.totalCostOfPaintLabel.Visible = false;
            // 
            // totalLaborChargesLabel
            // 
            this.totalLaborChargesLabel.AutoSize = true;
            this.totalLaborChargesLabel.BackColor = System.Drawing.Color.Black;
            this.totalLaborChargesLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLaborChargesLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.totalLaborChargesLabel.Location = new System.Drawing.Point(34, 293);
            this.totalLaborChargesLabel.Name = "totalLaborChargesLabel";
            this.totalLaborChargesLabel.Size = new System.Drawing.Size(138, 15);
            this.totalLaborChargesLabel.TabIndex = 9;
            this.totalLaborChargesLabel.Text = "Total Labor Charges:";
            this.totalLaborChargesLabel.Visible = false;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.IndianRed;
            this.clearButton.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clearButton.Location = new System.Drawing.Point(354, 195);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(125, 40);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.IndianRed;
            this.exitButton.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exitButton.Location = new System.Drawing.Point(354, 257);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 40);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateJobButton
            // 
            this.calculateJobButton.BackColor = System.Drawing.Color.IndianRed;
            this.calculateJobButton.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateJobButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.calculateJobButton.Location = new System.Drawing.Point(354, 64);
            this.calculateJobButton.Name = "calculateJobButton";
            this.calculateJobButton.Size = new System.Drawing.Size(125, 40);
            this.calculateJobButton.TabIndex = 6;
            this.calculateJobButton.Text = "Calculate Job";
            this.calculateJobButton.UseVisualStyleBackColor = false;
            this.calculateJobButton.Click += new System.EventHandler(this.calculateJobButton_Click);
            // 
            // totalJobCostLabel
            // 
            this.totalJobCostLabel.AutoSize = true;
            this.totalJobCostLabel.BackColor = System.Drawing.Color.Black;
            this.totalJobCostLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalJobCostLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.totalJobCostLabel.Location = new System.Drawing.Point(34, 331);
            this.totalJobCostLabel.Name = "totalJobCostLabel";
            this.totalJobCostLabel.Size = new System.Drawing.Size(146, 15);
            this.totalJobCostLabel.TabIndex = 10;
            this.totalJobCostLabel.Text = "Total Cost Of The Job:";
            this.totalJobCostLabel.Visible = false;
            // 
            // PaintJobEstimator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Paint_Job_Estimator.Properties.Resources.tag_fitti;
            this.ClientSize = new System.Drawing.Size(493, 360);
            this.Controls.Add(this.calculateJobButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalJobCostLabel);
            this.Controls.Add(this.totalLaborChargesLabel);
            this.Controls.Add(this.totalCostOfPaintLabel);
            this.Controls.Add(this.totalLaborHoursLabel);
            this.Controls.Add(this.totalPaintGallonsLabel);
            this.Controls.Add(this.totalCostOfPaintTextBox);
            this.Controls.Add(this.totalLaborChargesTextbox);
            this.Controls.Add(this.totalLaborHoursTextbox);
            this.Controls.Add(this.totalJobCostTextbox);
            this.Controls.Add(this.totalPaintGallonsTextbox);
            this.Controls.Add(this.informationGroupBox);
            this.Name = "PaintJobEstimator";
            this.Text = "Kyle\'s Paint Job Estimator";
            this.informationGroupBox.ResumeLayout(false);
            this.informationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox informationGroupBox;
        private System.Windows.Forms.Label pricePerGallonLabel;
        private System.Windows.Forms.Label wallSpaceLabel;
        private System.Windows.Forms.TextBox pricePerGallonTextBox;
        private System.Windows.Forms.TextBox wallSpaceTextBox;
        private System.Windows.Forms.TextBox totalPaintGallonsTextbox;
        private System.Windows.Forms.TextBox totalJobCostTextbox;
        private System.Windows.Forms.TextBox totalLaborHoursTextbox;
        private System.Windows.Forms.TextBox totalLaborChargesTextbox;
        private System.Windows.Forms.TextBox totalCostOfPaintTextBox;
        private System.Windows.Forms.Label totalPaintGallonsLabel;
        private System.Windows.Forms.Label totalLaborHoursLabel;
        private System.Windows.Forms.Label totalCostOfPaintLabel;
        private System.Windows.Forms.Label totalLaborChargesLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateJobButton;
        private System.Windows.Forms.Label totalJobCostLabel;
    }
}

