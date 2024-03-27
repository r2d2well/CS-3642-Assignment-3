namespace CS_3642_Assignment__3
{
    partial class BlockImageForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BrightDarkLabel = new Label();
            WeightLabel1 = new Label();
            WeightLabel2 = new Label();
            WeightLabel3 = new Label();
            WeightLabel4 = new Label();
            BiasLabel = new Label();
            TrainPerceptronButton = new Button();
            SuspendLayout();
            // 
            // BrightDarkLabel
            // 
            BrightDarkLabel.AutoSize = true;
            BrightDarkLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BrightDarkLabel.Location = new Point(363, 394);
            BrightDarkLabel.Name = "BrightDarkLabel";
            BrightDarkLabel.Size = new Size(65, 28);
            BrightDarkLabel.TabIndex = 0;
            BrightDarkLabel.Text = "Bright";
            // 
            // WeightLabel1
            // 
            WeightLabel1.AutoSize = true;
            WeightLabel1.Location = new Point(28, 71);
            WeightLabel1.Name = "WeightLabel1";
            WeightLabel1.Size = new Size(71, 20);
            WeightLabel1.TabIndex = 1;
            WeightLabel1.Text = "Weight 1:";
            // 
            // WeightLabel2
            // 
            WeightLabel2.AutoSize = true;
            WeightLabel2.Location = new Point(28, 140);
            WeightLabel2.Name = "WeightLabel2";
            WeightLabel2.Size = new Size(71, 20);
            WeightLabel2.TabIndex = 2;
            WeightLabel2.Text = "Weight 2:";
            // 
            // WeightLabel3
            // 
            WeightLabel3.AutoSize = true;
            WeightLabel3.Location = new Point(28, 210);
            WeightLabel3.Name = "WeightLabel3";
            WeightLabel3.Size = new Size(71, 20);
            WeightLabel3.TabIndex = 3;
            WeightLabel3.Text = "Weight 3:";
            // 
            // WeightLabel4
            // 
            WeightLabel4.AutoSize = true;
            WeightLabel4.Location = new Point(28, 273);
            WeightLabel4.Name = "WeightLabel4";
            WeightLabel4.Size = new Size(71, 20);
            WeightLabel4.TabIndex = 4;
            WeightLabel4.Text = "Weight 4:";
            // 
            // BiasLabel
            // 
            BiasLabel.AutoSize = true;
            BiasLabel.Location = new Point(28, 331);
            BiasLabel.Name = "BiasLabel";
            BiasLabel.Size = new Size(39, 20);
            BiasLabel.TabIndex = 5;
            BiasLabel.Text = "Bias:";
            // 
            // TrainPerceptronButton
            // 
            TrainPerceptronButton.Location = new Point(650, 196);
            TrainPerceptronButton.Name = "TrainPerceptronButton";
            TrainPerceptronButton.Size = new Size(138, 49);
            TrainPerceptronButton.TabIndex = 6;
            TrainPerceptronButton.Text = "Train Perceptron";
            TrainPerceptronButton.UseVisualStyleBackColor = true;
            TrainPerceptronButton.Click += TrainPerceptronButton_Click;
            // 
            // BlockImageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(TrainPerceptronButton);
            Controls.Add(BiasLabel);
            Controls.Add(WeightLabel4);
            Controls.Add(WeightLabel3);
            Controls.Add(WeightLabel2);
            Controls.Add(WeightLabel1);
            Controls.Add(BrightDarkLabel);
            Name = "BlockImageForm";
            Text = "4 Block Image";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BrightDarkLabel;
        private Label WeightLabel1;
        private Label WeightLabel2;
        private Label WeightLabel3;
        private Label WeightLabel4;
        private Label BiasLabel;
        private Button TrainPerceptronButton;
    }
}