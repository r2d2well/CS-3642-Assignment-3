namespace CS_3642_Assignment__3
{
    partial class MainMenuForm
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
            MoviePerdictionButton = new Button();
            BlockImageButton = new Button();
            SuspendLayout();
            // 
            // MoviePerdictionButton
            // 
            MoviePerdictionButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MoviePerdictionButton.Location = new Point(526, 163);
            MoviePerdictionButton.Name = "MoviePerdictionButton";
            MoviePerdictionButton.Size = new Size(262, 126);
            MoviePerdictionButton.TabIndex = 0;
            MoviePerdictionButton.Text = "Movie Perdiction Demo";
            MoviePerdictionButton.UseVisualStyleBackColor = true;
            MoviePerdictionButton.Click += MoviePerdictionButton_Click;
            // 
            // BlockImageButton
            // 
            BlockImageButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BlockImageButton.Location = new Point(12, 163);
            BlockImageButton.Name = "BlockImageButton";
            BlockImageButton.Size = new Size(262, 126);
            BlockImageButton.TabIndex = 1;
            BlockImageButton.Text = "4 Block Image";
            BlockImageButton.UseVisualStyleBackColor = true;
            BlockImageButton.Click += BlockImageButton_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(BlockImageButton);
            Controls.Add(MoviePerdictionButton);
            Name = "MainMenuForm";
            Text = "Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button MoviePerdictionButton;
        private Button BlockImageButton;
    }
}