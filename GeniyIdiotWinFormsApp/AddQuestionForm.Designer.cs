namespace GeniyIdiotWinFormsApp
{
    partial class AddQuestionForm
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
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.InputQuestionTextBox = new System.Windows.Forms.TextBox();
            this.InputAnswerTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.userInputErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userInputErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(21, 22);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(119, 15);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Text = "Введите ваш вопрос";
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Location = new System.Drawing.Point(21, 116);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(167, 15);
            this.AnswerLabel.TabIndex = 1;
            this.AnswerLabel.Text = "Введите ответ на ваш вопрос";
            // 
            // InputQuestionTextBox
            // 
            this.InputQuestionTextBox.Location = new System.Drawing.Point(21, 65);
            this.InputQuestionTextBox.Name = "InputQuestionTextBox";
            this.InputQuestionTextBox.Size = new System.Drawing.Size(613, 23);
            this.InputQuestionTextBox.TabIndex = 2;
            this.InputQuestionTextBox.TextChanged += new System.EventHandler(this.InputQuestionTextBox_TextChanged);
            // 
            // InputAnswerTextBox
            // 
            this.InputAnswerTextBox.Location = new System.Drawing.Point(21, 151);
            this.InputAnswerTextBox.Name = "InputAnswerTextBox";
            this.InputAnswerTextBox.Size = new System.Drawing.Size(613, 23);
            this.InputAnswerTextBox.TabIndex = 3;
            this.InputAnswerTextBox.TextChanged += new System.EventHandler(this.InputAnswerTextBox_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(289, 215);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // userInputErrorProvider
            // 
            this.userInputErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.userInputErrorProvider.ContainerControl = this;
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 261);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.InputAnswerTextBox);
            this.Controls.Add(this.InputQuestionTextBox);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.QuestionLabel);
            this.Name = "AddQuestionForm";
            this.Text = "AddQuestionForm";
            ((System.ComponentModel.ISupportInitialize)(this.userInputErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label QuestionLabel;
        private Label AnswerLabel;
        private TextBox InputQuestionTextBox;
        private TextBox InputAnswerTextBox;
        private Button AddButton;
        private ErrorProvider userInputErrorProvider;
    }
}