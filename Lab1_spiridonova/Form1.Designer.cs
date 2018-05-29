namespace Lab1_spiridonova
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Solve2 = new System.Windows.Forms.Button();
			this.Solve1 = new System.Windows.Forms.Button();
			this.addRowsColumns = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.resetBtn = new System.Windows.Forms.Button();
			this.errorLabel = new System.Windows.Forms.Label();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.ZtextBox = new System.Windows.Forms.TextBox();
			this.YtextBox = new System.Windows.Forms.TextBox();
			this.XtextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.successLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 72);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(374, 221);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Solve2
			// 
			this.Solve2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Solve2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Solve2.Location = new System.Drawing.Point(392, 72);
			this.Solve2.Name = "Solve2";
			this.Solve2.Size = new System.Drawing.Size(191, 106);
			this.Solve2.TabIndex = 9;
			this.Solve2.Text = "Gauss Implementation";
			this.Solve2.UseVisualStyleBackColor = false;
			this.Solve2.Click += new System.EventHandler(this.Solve2_Click);
			// 
			// Solve1
			// 
			this.Solve1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Solve1.FlatAppearance.BorderSize = 2;
			this.Solve1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Solve1.Location = new System.Drawing.Point(392, 184);
			this.Solve1.Name = "Solve1";
			this.Solve1.Size = new System.Drawing.Size(191, 109);
			this.Solve1.TabIndex = 10;
			this.Solve1.Text = "Jordan Implementation";
			this.Solve1.UseVisualStyleBackColor = false;
			this.Solve1.Click += new System.EventHandler(this.Solve1_Click);
			// 
			// addRowsColumns
			// 
			this.addRowsColumns.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.addRowsColumns.Location = new System.Drawing.Point(59, 44);
			this.addRowsColumns.Name = "addRowsColumns";
			this.addRowsColumns.Size = new System.Drawing.Size(125, 23);
			this.addRowsColumns.TabIndex = 8;
			this.addRowsColumns.Text = "Set the Matrix";
			this.addRowsColumns.UseVisualStyleBackColor = false;
			this.addRowsColumns.Click += new System.EventHandler(this.addRowsColumns_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(184, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(14, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "X";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(204, 18);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(29, 20);
			this.textBox2.TabIndex = 5;
			this.textBox2.Text = "4";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(152, 18);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(26, 20);
			this.textBox1.TabIndex = 6;
			this.textBox1.Text = "3";
			// 
			// resetBtn
			// 
			this.resetBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.resetBtn.Location = new System.Drawing.Point(190, 44);
			this.resetBtn.Name = "resetBtn";
			this.resetBtn.Size = new System.Drawing.Size(152, 22);
			this.resetBtn.TabIndex = 11;
			this.resetBtn.Text = "Clear All";
			this.resetBtn.UseVisualStyleBackColor = false;
			this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
			// 
			// errorLabel
			// 
			this.errorLabel.AutoSize = true;
			this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.errorLabel.ForeColor = System.Drawing.Color.Red;
			this.errorLabel.Location = new System.Drawing.Point(12, 307);
			this.errorLabel.Name = "errorLabel";
			this.errorLabel.Size = new System.Drawing.Size(109, 17);
			this.errorLabel.TabIndex = 12;
			this.errorLabel.Text = "ahsdfjsdfjasdf";
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(600, 92);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.Size = new System.Drawing.Size(444, 201);
			this.dataGridView2.TabIndex = 14;
			// 
			// ZtextBox
			// 
			this.ZtextBox.Location = new System.Drawing.Point(915, 299);
			this.ZtextBox.Name = "ZtextBox";
			this.ZtextBox.Size = new System.Drawing.Size(100, 20);
			this.ZtextBox.TabIndex = 23;
			// 
			// YtextBox
			// 
			this.YtextBox.Location = new System.Drawing.Point(786, 299);
			this.YtextBox.Name = "YtextBox";
			this.YtextBox.Size = new System.Drawing.Size(100, 20);
			this.YtextBox.TabIndex = 24;
			// 
			// XtextBox
			// 
			this.XtextBox.Location = new System.Drawing.Point(652, 299);
			this.XtextBox.Name = "XtextBox";
			this.XtextBox.Size = new System.Drawing.Size(100, 20);
			this.XtextBox.TabIndex = 25;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(900, 302);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(17, 13);
			this.label4.TabIndex = 20;
			this.label4.Text = "Z:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(771, 302);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 13);
			this.label3.TabIndex = 21;
			this.label3.Text = "Y:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(637, 302);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 13);
			this.label2.TabIndex = 22;
			this.label2.Text = "X:";
			// 
			// successLabel
			// 
			this.successLabel.AutoSize = true;
			this.successLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.successLabel.ForeColor = System.Drawing.Color.Green;
			this.successLabel.Location = new System.Drawing.Point(597, 72);
			this.successLabel.Name = "successLabel";
			this.successLabel.Size = new System.Drawing.Size(46, 17);
			this.successLabel.TabIndex = 26;
			this.successLabel.Text = "label5";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(1056, 499);
			this.Controls.Add(this.successLabel);
			this.Controls.Add(this.ZtextBox);
			this.Controls.Add(this.YtextBox);
			this.Controls.Add(this.XtextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.errorLabel);
			this.Controls.Add(this.resetBtn);
			this.Controls.Add(this.Solve2);
			this.Controls.Add(this.Solve1);
			this.Controls.Add(this.addRowsColumns);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.dataGridView1);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Name = "Form1";
			this.Text = "Linear Equations GUI";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Solve2;
        private System.Windows.Forms.Button Solve1;
        private System.Windows.Forms.Button addRowsColumns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button resetBtn;
		private System.Windows.Forms.Label errorLabel;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.TextBox ZtextBox;
		private System.Windows.Forms.TextBox YtextBox;
		private System.Windows.Forms.TextBox XtextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label successLabel;
	}
}

