namespace GeniusIdiotWindowsFormsApp1
{
    partial class StartTestingForm
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
            this.nextButton = new System.Windows.Forms.Button();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.questionTextLable = new System.Windows.Forms.Label();
            this.userAnswerErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.userAnswerTextBox = new System.Windows.Forms.TextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TimerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userAnswerErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nextButton.Location = new System.Drawing.Point(129, 285);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(240, 29);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "Ответить";
            this.nextButton.UseCompatibleTextRendering = true;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionNumberLabel.Location = new System.Drawing.Point(203, 29);
            this.questionNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(86, 19);
            this.questionNumberLabel.TabIndex = 1;
            this.questionNumberLabel.Text = "Вопрос №1";
            // 
            // questionTextLable
            // 
            this.questionTextLable.AutoSize = true;
            this.questionTextLable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionTextLable.Location = new System.Drawing.Point(43, 129);
            this.questionTextLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionTextLable.Name = "questionTextLable";
            this.questionTextLable.Size = new System.Drawing.Size(104, 19);
            this.questionTextLable.TabIndex = 2;
            this.questionTextLable.Text = "Текст вопроса";
            // 
            // userAnswerErrorProvider
            // 
            this.userAnswerErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.userAnswerErrorProvider.ContainerControl = this;
            // 
            // userAnswerTextBox
            // 
            this.userAnswerTextBox.Location = new System.Drawing.Point(43, 236);
            this.userAnswerTextBox.Name = "userAnswerTextBox";
            this.userAnswerTextBox.Size = new System.Drawing.Size(398, 23);
            this.userAnswerTextBox.TabIndex = 4;
            this.userAnswerTextBox.TextChanged += new System.EventHandler(this.userAnswerTextBox_TextChanged);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimerLabel.Location = new System.Drawing.Point(387, 68);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(42, 31);
            this.TimerLabel.TabIndex = 5;
            this.TimerLabel.Text = "10";
            // 
            // StartTestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 353);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.userAnswerTextBox);
            this.Controls.Add(this.questionTextLable);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.nextButton);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "StartTestingForm";
            this.Text = "GENIUS/IDIOT";
            this.Load += new System.EventHandler(this.StartTestingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userAnswerErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.Label questionTextLable;
        private ErrorProvider userAnswerErrorProvider;
        private TextBox userAnswerTextBox;
        private System.Windows.Forms.Timer Timer;
        private Label TimerLabel;
    }
}

