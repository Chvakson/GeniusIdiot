namespace GeniyIdiotWinFormsApp
{
    partial class RemoveQuestionForm
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
            this.QuestionsListDataGridView = new System.Windows.Forms.DataGridView();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.NumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnswerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionsListDataGridView
            // 
            this.QuestionsListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.QuestionsListDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.QuestionsListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuestionsListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberColumn,
            this.TextColumn,
            this.AnswerColumn});
            this.QuestionsListDataGridView.Location = new System.Drawing.Point(2, 1);
            this.QuestionsListDataGridView.Name = "QuestionsListDataGridView";
            this.QuestionsListDataGridView.RowTemplate.Height = 25;
            this.QuestionsListDataGridView.Size = new System.Drawing.Size(552, 180);
            this.QuestionsListDataGridView.TabIndex = 0;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(305, 205);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Удалить";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // NumberColumn
            // 
            this.NumberColumn.HeaderText = "№";
            this.NumberColumn.Name = "NumberColumn";
            this.NumberColumn.Width = 45;
            // 
            // TextColumn
            // 
            this.TextColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TextColumn.HeaderText = "Текст вопроса";
            this.TextColumn.Name = "TextColumn";
            this.TextColumn.Width = 110;
            // 
            // AnswerColumn
            // 
            this.AnswerColumn.HeaderText = "Ответ";
            this.AnswerColumn.Name = "AnswerColumn";
            this.AnswerColumn.Width = 63;
            // 
            // RemoveQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 252);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.QuestionsListDataGridView);
            this.Name = "RemoveQuestionForm";
            this.Text = "RemoveQuestionForm";
            this.Load += new System.EventHandler(this.RemoveQuestionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView QuestionsListDataGridView;
        private Button RemoveButton;
        private DataGridViewTextBoxColumn NumberColumn;
        private DataGridViewTextBoxColumn TextColumn;
        private DataGridViewTextBoxColumn AnswerColumn;
    }
}