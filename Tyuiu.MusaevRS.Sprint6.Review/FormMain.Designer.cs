
namespace Tyuiu.MusaevRS.Sprint6.Review
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut = new System.Windows.Forms.DataGridView();
            this.groupBoxText = new System.Windows.Forms.GroupBox();
            this.buttonDoneMatrix = new System.Windows.Forms.Button();
            this.labelEndDiap = new System.Windows.Forms.Label();
            this.labelStartDiap = new System.Windows.Forms.Label();
            this.labelStartMassive = new System.Windows.Forms.Label();
            this.labelCountColums = new System.Windows.Forms.Label();
            this.labelSelectedRow = new System.Windows.Forms.Label();
            this.labelEndMassive = new System.Windows.Forms.Label();
            this.labelRowCount = new System.Windows.Forms.Label();
            this.textBoxEndMassive = new System.Windows.Forms.TextBox();
            this.textBoxSelectedRow = new System.Windows.Forms.TextBox();
            this.textBoxEndDiap = new System.Windows.Forms.TextBox();
            this.textBoxCountColums = new System.Windows.Forms.TextBox();
            this.textBoxStartMassive = new System.Windows.Forms.TextBox();
            this.textBoxStartDiap = new System.Windows.Forms.TextBox();
            this.textBoxCountRow = new System.Windows.Forms.TextBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBoxCondition.SuspendLayout();
            this.groupBoxOutPut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut)).BeginInit();
            this.groupBoxText.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.textBoxCondition);
            this.groupBoxCondition.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(351, 135);
            this.groupBoxCondition.TabIndex = 0;
            this.groupBoxCondition.TabStop = false;
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition.Location = new System.Drawing.Point(6, 10);
            this.textBoxCondition.Multiline = true;
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.ReadOnly = true;
            this.textBoxCondition.Size = new System.Drawing.Size(339, 119);
            this.textBoxCondition.TabIndex = 0;
            this.textBoxCondition.Text = resources.GetString("textBoxCondition.Text");
            this.textBoxCondition.TextChanged += new System.EventHandler(this.textBoxCondition_TextChanged);
            // 
            // groupBoxOutPut
            // 
            this.groupBoxOutPut.Controls.Add(this.dataGridViewOutPut);
            this.groupBoxOutPut.Location = new System.Drawing.Point(12, 153);
            this.groupBoxOutPut.Name = "groupBoxOutPut";
            this.groupBoxOutPut.Size = new System.Drawing.Size(351, 285);
            this.groupBoxOutPut.TabIndex = 1;
            this.groupBoxOutPut.TabStop = false;
            this.groupBoxOutPut.Text = "Вывод";
            // 
            // dataGridViewOutPut
            // 
            this.dataGridViewOutPut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut.ColumnHeadersVisible = false;
            this.dataGridViewOutPut.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewOutPut.Name = "dataGridViewOutPut";
            this.dataGridViewOutPut.ReadOnly = true;
            this.dataGridViewOutPut.RowHeadersVisible = false;
            this.dataGridViewOutPut.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewOutPut.Size = new System.Drawing.Size(339, 260);
            this.dataGridViewOutPut.TabIndex = 0;
            // 
            // groupBoxText
            // 
            this.groupBoxText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxText.Controls.Add(this.buttonDoneMatrix);
            this.groupBoxText.Controls.Add(this.labelEndDiap);
            this.groupBoxText.Controls.Add(this.labelStartDiap);
            this.groupBoxText.Controls.Add(this.labelStartMassive);
            this.groupBoxText.Controls.Add(this.labelCountColums);
            this.groupBoxText.Controls.Add(this.labelSelectedRow);
            this.groupBoxText.Controls.Add(this.labelEndMassive);
            this.groupBoxText.Controls.Add(this.labelRowCount);
            this.groupBoxText.Controls.Add(this.textBoxEndMassive);
            this.groupBoxText.Controls.Add(this.textBoxSelectedRow);
            this.groupBoxText.Controls.Add(this.textBoxEndDiap);
            this.groupBoxText.Controls.Add(this.textBoxCountColums);
            this.groupBoxText.Controls.Add(this.textBoxStartMassive);
            this.groupBoxText.Controls.Add(this.textBoxStartDiap);
            this.groupBoxText.Controls.Add(this.textBoxCountRow);
            this.groupBoxText.Location = new System.Drawing.Point(369, 58);
            this.groupBoxText.Name = "groupBoxText";
            this.groupBoxText.Size = new System.Drawing.Size(431, 380);
            this.groupBoxText.TabIndex = 2;
            this.groupBoxText.TabStop = false;
            // 
            // buttonDoneMatrix
            // 
            this.buttonDoneMatrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonDoneMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDoneMatrix.Location = new System.Drawing.Point(52, 181);
            this.buttonDoneMatrix.Name = "buttonDoneMatrix";
            this.buttonDoneMatrix.Size = new System.Drawing.Size(306, 73);
            this.buttonDoneMatrix.TabIndex = 2;
            this.buttonDoneMatrix.Text = "Построить матрицу и вывести ответ";
            this.buttonDoneMatrix.UseVisualStyleBackColor = false;
            this.buttonDoneMatrix.Click += new System.EventHandler(this.buttonDoneMatrix_Click);
            // 
            // labelEndDiap
            // 
            this.labelEndDiap.AutoSize = true;
            this.labelEndDiap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEndDiap.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelEndDiap.Location = new System.Drawing.Point(291, 59);
            this.labelEndDiap.Name = "labelEndDiap";
            this.labelEndDiap.Size = new System.Drawing.Size(97, 15);
            this.labelEndDiap.TabIndex = 1;
            this.labelEndDiap.Text = "Конец диапазона";
            // 
            // labelStartDiap
            // 
            this.labelStartDiap.AutoSize = true;
            this.labelStartDiap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStartDiap.Location = new System.Drawing.Point(187, 59);
            this.labelStartDiap.Name = "labelStartDiap";
            this.labelStartDiap.Size = new System.Drawing.Size(95, 15);
            this.labelStartDiap.TabIndex = 1;
            this.labelStartDiap.Text = "Старт диапазона";
            // 
            // labelStartMassive
            // 
            this.labelStartMassive.AutoSize = true;
            this.labelStartMassive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStartMassive.Location = new System.Drawing.Point(33, 104);
            this.labelStartMassive.Name = "labelStartMassive";
            this.labelStartMassive.Size = new System.Drawing.Size(85, 15);
            this.labelStartMassive.TabIndex = 1;
            this.labelStartMassive.Text = "Старт массива";
            // 
            // labelCountColums
            // 
            this.labelCountColums.AutoSize = true;
            this.labelCountColums.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCountColums.Location = new System.Drawing.Point(125, 16);
            this.labelCountColums.Name = "labelCountColums";
            this.labelCountColums.Size = new System.Drawing.Size(118, 15);
            this.labelCountColums.TabIndex = 1;
            this.labelCountColums.Text = "Количество столбцов";
            // 
            // labelSelectedRow
            // 
            this.labelSelectedRow.AutoSize = true;
            this.labelSelectedRow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSelectedRow.Location = new System.Drawing.Point(268, 106);
            this.labelSelectedRow.Name = "labelSelectedRow";
            this.labelSelectedRow.Size = new System.Drawing.Size(104, 15);
            this.labelSelectedRow.TabIndex = 1;
            this.labelSelectedRow.Text = "Выбранная строка";
            // 
            // labelEndMassive
            // 
            this.labelEndMassive.AutoSize = true;
            this.labelEndMassive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEndMassive.Location = new System.Drawing.Point(143, 106);
            this.labelEndMassive.Name = "labelEndMassive";
            this.labelEndMassive.Size = new System.Drawing.Size(87, 15);
            this.labelEndMassive.TabIndex = 1;
            this.labelEndMassive.Text = "Конец массива";
            // 
            // labelRowCount
            // 
            this.labelRowCount.AutoSize = true;
            this.labelRowCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRowCount.Location = new System.Drawing.Point(18, 16);
            this.labelRowCount.Name = "labelRowCount";
            this.labelRowCount.Size = new System.Drawing.Size(100, 15);
            this.labelRowCount.TabIndex = 1;
            this.labelRowCount.Text = "Количество строк";
            // 
            // textBoxEndMassive
            // 
            this.textBoxEndMassive.Location = new System.Drawing.Point(147, 124);
            this.textBoxEndMassive.Name = "textBoxEndMassive";
            this.textBoxEndMassive.Size = new System.Drawing.Size(75, 20);
            this.textBoxEndMassive.TabIndex = 0;
            // 
            // textBoxSelectedRow
            // 
            this.textBoxSelectedRow.Location = new System.Drawing.Point(268, 124);
            this.textBoxSelectedRow.Name = "textBoxSelectedRow";
            this.textBoxSelectedRow.Size = new System.Drawing.Size(100, 20);
            this.textBoxSelectedRow.TabIndex = 0;
            // 
            // textBoxEndDiap
            // 
            this.textBoxEndDiap.Location = new System.Drawing.Point(294, 75);
            this.textBoxEndDiap.Name = "textBoxEndDiap";
            this.textBoxEndDiap.Size = new System.Drawing.Size(93, 20);
            this.textBoxEndDiap.TabIndex = 0;
            // 
            // textBoxCountColums
            // 
            this.textBoxCountColums.Location = new System.Drawing.Point(147, 32);
            this.textBoxCountColums.Name = "textBoxCountColums";
            this.textBoxCountColums.Size = new System.Drawing.Size(75, 20);
            this.textBoxCountColums.TabIndex = 0;
            // 
            // textBoxStartMassive
            // 
            this.textBoxStartMassive.Location = new System.Drawing.Point(37, 124);
            this.textBoxStartMassive.Name = "textBoxStartMassive";
            this.textBoxStartMassive.Size = new System.Drawing.Size(73, 20);
            this.textBoxStartMassive.TabIndex = 0;
            // 
            // textBoxStartDiap
            // 
            this.textBoxStartDiap.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxStartDiap.Location = new System.Drawing.Point(198, 77);
            this.textBoxStartDiap.Name = "textBoxStartDiap";
            this.textBoxStartDiap.Size = new System.Drawing.Size(74, 20);
            this.textBoxStartDiap.TabIndex = 0;
            // 
            // textBoxCountRow
            // 
            this.textBoxCountRow.Location = new System.Drawing.Point(33, 32);
            this.textBoxCountRow.Name = "textBoxCountRow";
            this.textBoxCountRow.Size = new System.Drawing.Size(73, 20);
            this.textBoxCountRow.TabIndex = 0;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxResult.Controls.Add(this.textBoxResult);
            this.groupBoxResult.Location = new System.Drawing.Point(369, 12);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(431, 40);
            this.groupBoxResult.TabIndex = 3;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Ответ";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(6, 14);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 463);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxText);
            this.Controls.Add(this.groupBoxOutPut);
            this.Controls.Add(this.groupBoxCondition);
            this.Name = "FormMain";
            this.Text = "Sprint 6 | MusaevRS | TaskReview | V26";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            this.groupBoxOutPut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut)).EndInit();
            this.groupBoxText.ResumeLayout(false);
            this.groupBoxText.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.GroupBox groupBoxOutPut;
        private System.Windows.Forms.DataGridView dataGridViewOutPut;
        private System.Windows.Forms.GroupBox groupBoxText;
        private System.Windows.Forms.Label labelEndDiap;
        private System.Windows.Forms.Label labelStartDiap;
        private System.Windows.Forms.Label labelStartMassive;
        private System.Windows.Forms.Label labelCountColums;
        private System.Windows.Forms.Label labelSelectedRow;
        private System.Windows.Forms.Label labelEndMassive;
        private System.Windows.Forms.Label labelRowCount;
        private System.Windows.Forms.TextBox textBoxEndMassive;
        private System.Windows.Forms.TextBox textBoxSelectedRow;
        private System.Windows.Forms.TextBox textBoxEndDiap;
        private System.Windows.Forms.TextBox textBoxCountColums;
        private System.Windows.Forms.TextBox textBoxStartMassive;
        private System.Windows.Forms.TextBox textBoxStartDiap;
        private System.Windows.Forms.TextBox textBoxCountRow;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonDoneMatrix;
    }
}

