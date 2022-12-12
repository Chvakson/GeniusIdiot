namespace GeniyIdiotWinFormsApp
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
            this.StartTestingButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ShowResultsButton = new System.Windows.Forms.Button();
            this.AddQuestionButton = new System.Windows.Forms.Button();
            this.RemoveQuestionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartTestingButton
            // 
            this.StartTestingButton.Location = new System.Drawing.Point(38, 37);
            this.StartTestingButton.Name = "StartTestingButton";
            this.StartTestingButton.Size = new System.Drawing.Size(304, 23);
            this.StartTestingButton.TabIndex = 0;
            this.StartTestingButton.Text = "Начать тестирование";
            this.StartTestingButton.UseVisualStyleBackColor = true;
            this.StartTestingButton.Click += new System.EventHandler(this.StartTestingButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(38, 363);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(304, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ShowResultsButton
            // 
            this.ShowResultsButton.Location = new System.Drawing.Point(38, 79);
            this.ShowResultsButton.Name = "ShowResultsButton";
            this.ShowResultsButton.Size = new System.Drawing.Size(304, 23);
            this.ShowResultsButton.TabIndex = 3;
            this.ShowResultsButton.Text = "Результаты тестирования";
            this.ShowResultsButton.UseVisualStyleBackColor = true;
            this.ShowResultsButton.Click += new System.EventHandler(this.ShowResultsButton_Click);
            // 
            // AddQuestionButton
            // 
            this.AddQuestionButton.Location = new System.Drawing.Point(38, 120);
            this.AddQuestionButton.Name = "AddQuestionButton";
            this.AddQuestionButton.Size = new System.Drawing.Size(304, 23);
            this.AddQuestionButton.TabIndex = 4;
            this.AddQuestionButton.Text = "Добавить новый вопрос";
            this.AddQuestionButton.UseVisualStyleBackColor = true;
            this.AddQuestionButton.Click += new System.EventHandler(this.AddQuestionButton_Click);
            // 
            // RemoveQuestionButton
            // 
            this.RemoveQuestionButton.Location = new System.Drawing.Point(38, 163);
            this.RemoveQuestionButton.Name = "RemoveQuestionButton";
            this.RemoveQuestionButton.Size = new System.Drawing.Size(304, 23);
            this.RemoveQuestionButton.TabIndex = 5;
            this.RemoveQuestionButton.Text = "Удалить вопрос";
            this.RemoveQuestionButton.UseVisualStyleBackColor = true;
            this.RemoveQuestionButton.Click += new System.EventHandler(this.RemoveQuestionButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 450);
            this.Controls.Add(this.RemoveQuestionButton);
            this.Controls.Add(this.AddQuestionButton);
            this.Controls.Add(this.ShowResultsButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StartTestingButton);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button StartTestingButton;
        private Button ExitButton;
        private Button ShowResultsButton;
        private Button AddQuestionButton;
        private Button RemoveQuestionButton;
    }
}