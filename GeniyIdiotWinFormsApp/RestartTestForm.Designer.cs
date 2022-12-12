namespace GeniyIdiotWinFormsApp
{
    partial class RestartTestForm
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
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.RestartTestBabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(39, 150);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(75, 23);
            this.YesButton.TabIndex = 0;
            this.YesButton.Text = "Да";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(145, 150);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(87, 23);
            this.NoButton.TabIndex = 1;
            this.NoButton.Text = "Нет";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // RestartTestBabel
            // 
            this.RestartTestBabel.AutoSize = true;
            this.RestartTestBabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RestartTestBabel.Location = new System.Drawing.Point(39, 68);
            this.RestartTestBabel.Name = "RestartTestBabel";
            this.RestartTestBabel.Size = new System.Drawing.Size(193, 19);
            this.RestartTestBabel.TabIndex = 2;
            this.RestartTestBabel.Text = "Хотите снова пройти тест?";
            // 
            // RestartTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 215);
            this.Controls.Add(this.RestartTestBabel);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Name = "RestartTestForm";
            this.Text = "Restart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button YesButton;
        private Button NoButton;
        private Label RestartTestBabel;
    }
}