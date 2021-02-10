using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Продавница_II_kol
{
    public partial class StrucniKnigi_I : UserControl
    {
        public StrucniKnigi_I()
        {
            InitializeComponent();

        }



        private void LabZaliha_Click(object sender, EventArgs e)
        {

        }

        private void LabTitle_Click(object sender, EventArgs e)
        {

        }

        private void StrucniKnigi_I_Load(object sender, EventArgs e)
        {

        }

        //Ne sakase da rabotat ubo


       // #region Propertis
        //    private string _title;
        //private Image _image;
        //private string _cena;
       // private string _zaliha;

        //[Category("Custom Props")]
        //public string Title
        //{
        //    get { return labTitle.Text; }
        //    set { labTitle.Text = value; }
        //}



        //public Image Image
        //{
        //    get { return pictureBox1.Image; }
        //    set { pictureBox1.Image = value; }
        //}


        //public string Cena
        //{
        //    get { return labCena.Text; }
        //    set  {labCena.Text = value; }
        //}


        //public string Zaliha
        //{
        //    get { return labZaliha.Text; }
        //    set {  labZaliha.Text = value; }
        //}

        private void Label1_Click(object sender, EventArgs e)
        {

        }



        private void Button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this, Product_Naslov+" : "+ Product_Cena);
            Qty++;
            button1.Text = $"Купи({Qty})";
            button2.Visible = true;
            Rows.Add(ID, Product_Naslov, Product_Cena, "1", Product_Cena);
        }

        private int findIndexRow(int id)
        {
            for (int i = 0; i < Rows.Count; i++)
            {
                int idNaracaj = int.Parse(Rows[i].Cells[0].Value+ "");
                if (id == idNaracaj)
                    return i;
            }
            return -1;
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Qty--;
            int row = findIndexRow(ID);
            Rows.RemoveAt(row);
            if (Qty == 0)
            {
                button1.Text = "Купи";
                button2.Visible = false;

            }
            else button1.Text = $"Купи({Qty})";
        }

        public int Qty { get; set; }  
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }


    }
}