namespace GeniyIdiotWinFormsApp
{
    partial class UserResultsForm
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
            this.ResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrueAnswersCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiagnozeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultsDataGridView
            // 
            this.ResultsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.ResultsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.ResultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.TrueAnswersCountColumn,
            this.DiagnozeColumn});
            this.ResultsDataGridView.Location = new System.Drawing.Point(0, 2);
            this.ResultsDataGridView.Name = "ResultsDataGridView";
            this.ResultsDataGridView.RowTemplate.Height = 25;
            this.ResultsDataGridView.Size = new System.Drawing.Size(435, 232);
            this.ResultsDataGridView.TabIndex = 0;
            // 
            // ФИО
            // 
            this.ФИО.HeaderText = "NameColumn";
            this.ФИО.Name = "ФИО";
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NameColumn.HeaderText = "ФИО";
            this.NameColumn.Name = "NameColumn";
            // 
            // TrueAnswersCountColumn
            // 
            this.TrueAnswersCountColumn.HeaderText = "Количество правильных ответов";
            this.TrueAnswersCountColumn.Name = "TrueAnswersCountColumn";
            this.TrueAnswersCountColumn.Width = 213;
            // 
            // DiagnozeColumn
            // 
            this.DiagnozeColumn.HeaderText = "Диагноз";
            this.DiagnozeColumn.Name = "DiagnozeColumn";
            this.DiagnozeColumn.Width = 77;
            // 
            // UserResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 241);
            this.Controls.Add(this.ResultsDataGridView);
            this.Name = "UserResultsForm";
            this.Text = "UserResultsForm";
            this.Load += new System.EventHandler(this.UserResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView ResultsDataGridView;
        private DataGridViewTextBoxColumn ФИО;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn TrueAnswersCountColumn;
        private DataGridViewTextBoxColumn DiagnozeColumn;
    }
}