namespace Project_1___Section_3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateBMILabel = new System.Windows.Forms.Label();
            this.yourResultLabel = new System.Windows.Forms.Label();
            this.weightRangePictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.imageListWeightRange = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.weightRangePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.Location = new System.Drawing.Point(32, 72);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(181, 16);
            this.weightLabel.TabIndex = 0;
            this.weightLabel.Text = "Enter your weight (in pounds):";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(40, 131);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(173, 16);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "Enter your height (in inches):";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(224, 72);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 2;
            this.weightTextBox.Text = "0.00";
            this.weightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(224, 127);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 3;
            this.heightTextBox.Text = "0.00";
            this.heightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(171, 163);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 38);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "&Calculate BMI";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(110, 433);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 38);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(234, 433);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 38);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateBMILabel
            // 
            this.calculateBMILabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculateBMILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBMILabel.Location = new System.Drawing.Point(224, 217);
            this.calculateBMILabel.Name = "calculateBMILabel";
            this.calculateBMILabel.Size = new System.Drawing.Size(100, 23);
            this.calculateBMILabel.TabIndex = 7;
            this.calculateBMILabel.Text = "0.00";
            this.calculateBMILabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yourResultLabel
            // 
            this.yourResultLabel.AutoSize = true;
            this.yourResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourResultLabel.Location = new System.Drawing.Point(107, 224);
            this.yourResultLabel.Name = "yourResultLabel";
            this.yourResultLabel.Size = new System.Drawing.Size(78, 16);
            this.yourResultLabel.TabIndex = 8;
            this.yourResultLabel.Text = "Your BMI is:";
            // 
            // weightRangePictureBox
            // 
            this.weightRangePictureBox.Location = new System.Drawing.Point(148, 247);
            this.weightRangePictureBox.Name = "weightRangePictureBox";
            this.weightRangePictureBox.Size = new System.Drawing.Size(120, 170);
            this.weightRangePictureBox.TabIndex = 9;
            this.weightRangePictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(136, 22);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(144, 24);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "BMI Calculator";
            // 
            // imageListWeightRange
            // 
            this.imageListWeightRange.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListWeightRange.ImageStream")));
            this.imageListWeightRange.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListWeightRange.Images.SetKeyName(0, "bmi underweight.jpg");
            this.imageListWeightRange.Images.SetKeyName(1, "bmi healthy.jpg");
            this.imageListWeightRange.Images.SetKeyName(2, "bmi overweight.jpg");
            this.imageListWeightRange.Images.SetKeyName(3, "bmi obese.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 499);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.weightRangePictureBox);
            this.Controls.Add(this.yourResultLabel);
            this.Controls.Add(this.calculateBMILabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.weightLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P1S3 BMI Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.weightRangePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label calculateBMILabel;
        private System.Windows.Forms.Label yourResultLabel;
        private System.Windows.Forms.PictureBox weightRangePictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ImageList imageListWeightRange;
    }
}

