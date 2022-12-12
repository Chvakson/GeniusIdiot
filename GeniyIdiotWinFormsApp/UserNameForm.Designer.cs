namespace GeniyIdiotWinFormsApp
{
    partial class UserNameForm
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
            this.InputUserNameButton = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputUserNameButton
            // 
            this.InputUserNameButton.Location = new System.Drawing.Point(184, 233);
            this.InputUserNameButton.Name = "InputUserNameButton";
            this.InputUserNameButton.Size = new System.Drawing.Size(120, 23);
            this.InputUserNameButton.TabIndex = 1;
            this.InputUserNameButton.Text = "Ввод";
            this.InputUserNameButton.UseVisualStyleBackColor = true;
            this.InputUserNameButton.Click += new System.EventHandler(this.InputUserNameButton_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameLabel.Location = new System.Drawing.Point(173, 85);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(150, 21);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "Введите ваши ФИО";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(12, 184);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(476, 23);
            this.userNameTextBox.TabIndex = 3;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 307);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.InputUserNameButton);
            this.Name = "UserForm";
            this.Text = "userForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button InputUserNameButton;
        private Label userNameLabel;
        private TextBox userNameTextBox;
    }
}