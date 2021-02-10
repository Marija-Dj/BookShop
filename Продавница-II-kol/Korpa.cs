using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Продавница_II_kol
{
    public partial class Korpa : UserControl
    {
        ArrayList listAtems = new ArrayList ();
        public Korpa()
        {
            InitializeComponent();
            //dataGridView1.Rows

        }
        public DataGridViewRowCollection getRows()
        {
            return dataGridView1.Rows;
        }
        private void Korpa_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rowe in dataGridView1.SelectedRows)
            { 
                dataGridView1.Rows.Remove(rowe);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        //private void Сима_Click(object sender, EventArgs e)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
        //    {
        //        sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
        //    }
        //    textBox1.Text = sum.ToString();
        //}

        private void Button4_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            textBox1.Text = sum.ToString();

        }


        //private int[] columnData = (from DataGridViewRow rowe in dataGridView1.Rows
        //                   where rowe.Cells[3].FormattedValue.ToString() != string.Empty
        //                   select Convert.ToInt32(rowe.Cells.FormattedValue)).ToArray();


        //private void TextBox1_TextChanged(object sender, EventArgs e)
        //{
        //    int sum = 0;
        //    for (int i=0; i<dataGridView1.Rows.Count; i++)
        //    {
        //        sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
        //    }
        //    textBox1.Text=sum.ToString();
        //}
    }
}
