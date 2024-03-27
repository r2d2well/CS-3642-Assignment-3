namespace CS_3642_Assignment__3
{
    partial class MoviePerdictionForm
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
            label = new Label();
            TrainButton = new Button();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(324, 184);
            label.Name = "label";
            label.Size = new Size(91, 38);
            label.TabIndex = 0;
            label.Text = "label1";
            // 
            // TrainButton
            // 
            TrainButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TrainButton.Location = new Point(303, 246);
            TrainButton.Name = "TrainButton";
            TrainButton.Size = new Size(134, 34);
            TrainButton.TabIndex = 1;
            TrainButton.Text = "Train Perceptron";
            TrainButton.UseVisualStyleBackColor = true;
            TrainButton.Click += TrainButton_Click;
            // 
            // MoviePerdictionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(TrainButton);
            Controls.Add(label);
            Name = "MoviePerdictionForm";
            Text = "Movie Perdiction Demo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Button TrainButton;
    }
}