namespace ScreenProtect
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
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InstructionsLabel.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.Location = new System.Drawing.Point(0, 0);
            this.InstructionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(816, 382);
            this.InstructionsLabel.TabIndex = 1;
            this.InstructionsLabel.Text = "Please Do not press anything or click anywhere, some process is going on and it m" +
    "ay cause the computer to overload.";
            this.InstructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InstructionsLabel.Click += new System.EventHandler(this.InstructionsLabel_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(202, 19);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(544, 79);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "!!! CAUTION !!!";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 382);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.InstructionsLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.Label TitleLabel;
    }
}

