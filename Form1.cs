using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_week9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.Team' table. You can move, or remove it, as needed.
            this.teamTableAdapter.Fill(this.dataSet11.Team);
            // TODO: This line of code loads data into the 'dataSet1.Team' table. You can move, or remove it, as needed.
            this.teamTableAdapter.Fill(this.dataSet1.Team);
            // TODO: This line of code loads data into the 'dataSet1.Player' table. You can move, or remove it, as needed.
            this.playerTableAdapter.Fill(this.dataSet1.Player);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Age, team;
            team = (int)comboBox1.SelectedValue;
            if(int.TryParse(textBox3.Text, out Age))
            {
                this.playerTableAdapter.Insert(textBox1.Text, textBox2.Text, Age, team);
            }
            this.playerTableAdapter.Fill(this.dataSet1.Player);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IDX;
            int Sel_ID = 0;
            IDX = dataGridView1.CurrentRow.Index;
            int.TryParse(dataGridView1.Rows[IDX].Cells[0].Value.ToString(), out Sel_ID);
            this.playerTableAdapter.MyDelete(Sel_ID);
            this.playerTableAdapter.Fill(this.dataSet1.Player);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IDX;
            int Sel_ID;
            IDX = dataGridView1.CurrentRow.Index;
            int Age, team;
            team = (int)comboBox1.SelectedValue;
            if(int.TryParse(textBox3.Text, out Age))
            {
                int.TryParse(dataGridView1.Rows[IDX].Cells[0].Value.ToString(), out Sel_ID);
                this.playerTableAdapter.MyUpdate(textBox1.Text, textBox2.Text, Age, team, Sel_ID, 5);

            }
            this.playerTableAdapter.Fill(this.dataSet1.Player);

        }
    }
}
