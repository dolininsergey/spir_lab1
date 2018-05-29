using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_spiridonova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
			errorLabel.Hide();
			successLabel.Hide();
        }


        

        private void addRowsColumns_Click(object sender,EventArgs e) {
			dataGridView1.Rows.Clear();
			dataGridView1.Columns.Clear();
			dataGridView1.Refresh();
			int rows = int.Parse(textBox1.Text);
            int columns = int.Parse(textBox2.Text);

            int i;
            for(int j = 0;j<columns;j++)
                dataGridView1.Columns.Add((j+1).ToString(),(j+1).ToString());

            for(i=0;i<rows;i++) {
                dataGridView1.Rows.Add();
            }
        }

        

        private void Solve1_Click(object sender,EventArgs e) {
			dataGridView2.Rows.Clear();
			dataGridView2.Columns.Clear();
			dataGridView2.Refresh();
			XtextBox.Clear();
			YtextBox.Clear();
			ZtextBox.Clear();

			errorLabel.Hide();
			successLabel.Hide();
			// Jordan Elimination
			int rows = dataGridView1.Rows.Count;
            int columns = dataGridView1.Columns.Count;
			bool error = false;

			for(int r = 0; r < rows; r++) {
				for(int c = 0; c < columns; c++) {
					if(dataGridView1.Rows[r].Cells[c].Value == null) {
						errorLabel.Show();
						errorLabel.Text = "Error. Fill the cells";
						error = true;
						break;
					}
				}
			}
			if(!error) {
				double[,] matr = new double[rows, columns];
				for(int r = 0; r < rows; r++) {
					for(int c = 0; c < columns; c++) {
						matr[r, c] = double.Parse(dataGridView1.Rows[r].Cells[c].Value.ToString());
					}
				}

				int i, k, q;
				double v;
				for(q = 0; q < rows; q++) {
					v = matr[q, q];
					for(k = 0; k < columns; k++)
						matr[q, k] /= v;
					for(i = q + 1; i < rows; i++) {
						v = matr[i, q];
						for(k = q; k < columns; k++)
							matr[i, k] = matr[i, k] - matr[q, k] * v;
					}
				}
				for(q = 0; q < rows; q++)
					for(i = 0; i < (rows - 1) - q; i++) {
						v = matr[i, (columns - 1) - q - 1];
						for(k = columns - 1 - q - 1; k < columns; k++)
							matr[i, k] = matr[i, k] - matr[(rows - 1) - q, k] * v;
					}
				for(int j = 0; j < columns; j++)
					dataGridView2.Columns.Add((j + 1).ToString(), (j + 1).ToString());

				for(int i1 = 0; i1 < rows; i1++) {
					dataGridView2.Rows.Add();
				}
				for(int r = 0; r < rows; r++) {
					for(int c = 0; c < columns; c++) {
						dataGridView2.Rows[r].Cells[c].Value = matr[r, c];
					}
				}

				XtextBox.Text = matr[0, columns - 1].ToString();
				YtextBox.Text = matr[1, columns - 1].ToString();
				ZtextBox.Text = matr[2, columns - 1].ToString();

				successLabel.Show();
				successLabel.Text = "Success: Jordan Elimination";
			}


		}

        private void Solve2_Click(object sender,EventArgs e) {
			dataGridView2.Rows.Clear();
			dataGridView2.Columns.Clear();
			dataGridView2.Refresh();
			XtextBox.Clear();
			YtextBox.Clear();
			ZtextBox.Clear();

			errorLabel.Hide();
			successLabel.Hide();
			// Gauss Elimination
			int rows = dataGridView1.Rows.Count;
            int columns = dataGridView1.Columns.Count;
			bool error = false;

			for(int r = 0; r < rows; r++) {
				for(int c = 0; c < columns; c++) {
					if(dataGridView1.Rows[r].Cells[c].Value == null) {
						errorLabel.Show();						
						errorLabel.Text = "Error. Fill the cells";
						error = true;
						break;
					}
				}
			}
			if(!error) {
				double[,] matr = new double[rows, columns];

				for(int r = 0; r < rows; r++) {
					for(int c = 0; c < columns; c++) {
						matr[r, c] = double.Parse(dataGridView1.Rows[r].Cells[c].Value.ToString());
					}
				}

				int i, k, q;
				double v;
				for(q = 0; q < rows; q++) {
					v = matr[q, q];
					for(k = 0; k < columns; k++)
						matr[q, k] /= v;
					for(i = q + 1; i < rows; i++) {
						v = matr[i, q];
						for(k = q; k < columns; k++)
							matr[i, k] = matr[i, k] - matr[q, k] * v;
					}
				}

				for(int j = 0; j < columns; j++)
					dataGridView2.Columns.Add((j + 1).ToString(), (j + 1).ToString());

				for(int zzz = 0; zzz < rows; zzz++) {
					dataGridView2.Rows.Add();
				}
				for(int r = 0; r < rows; r++) {
					for(int c = 0; c < columns; c++) {
						dataGridView2.Rows[r].Cells[c].Value = matr[r, c];
					}
				}

				double z = matr[2, columns - 1];
				double y = matr[1, columns - 1] - matr[1, columns - 2] * z;
				double x = matr[0, columns - 1] - matr[0, columns - 2] * z - matr[0, columns - 3] * y;
				XtextBox.Text = x.ToString();
				YtextBox.Text = y.ToString();
				ZtextBox.Text = z.ToString();

				successLabel.Show();
				successLabel.Text = "Success: Gauss Elimination";
			}
		}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void resetBtn_Click(object sender, EventArgs e) {
			textBox1.Text = "0";
			textBox2.Text = "0";
			dataGridView1.Rows.Clear();
			dataGridView1.Columns.Clear();
			dataGridView1.Refresh();

			successLabel.Hide();
			errorLabel.Hide();
			dataGridView2.Rows.Clear();
			dataGridView2.Columns.Clear();
			dataGridView2.Refresh();

			XtextBox.Clear();
			YtextBox.Clear();
			ZtextBox.Clear();
		}
	}
}
