using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Продавница_II_kol
{
    public partial class knigi : UserControl
    {
        public knigi()
        {

            InitializeComponent();
            //StrucniKnigi_I.Rows = Korpa.getRows();
            if (radioButton1.Checked)
            {
                panel1.Hide();
                tableLayoutPanel1.Show();
            }
            else if (radioButton2.Checked)
            {
                panel1.Show();
                tableLayoutPanel1.Hide();
            }
        }

        private void Knigi_Load(object sender, EventArgs e)
        {
            
            
               // MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ikolvpp;");
                //connection.Open();
               /* if(connection.State==ConnectionState.Open)
                {
                    label1.Text = "Connected";
                    label1.ForeColor = Color.Green;
                }
                else
                {
                    label1.Text = "Not Conected";
                    label1.ForeColor = Color.Red;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }


        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Show();
            tableLayoutPanel1.Hide();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Hide();
            tableLayoutPanel1.Show();
        }

        private void Naslov_Click(object sender, EventArgs e)
        {

        }










        //public void populateItems()
        //{
        //    StrucniKnigi_I[] listItems = new StrucniKnigi_I[2];
        //    for (int i = 0; i < listItems.Length; i++)
        //    {
        //        listItems[i] = new StrucniKnigi_I();
        //        listItems[i].Title = "Knigi";
        //        listItems[i].Cena = "2990 mkd";
        //        listItems[i].Zaliha = "Naskoro";
        ///* listItems[2].Title = "Knigi";
        // listItems[2].Cena = "2990 mkd";
        // listItems[2].Zaliha = "Naskoro";*/
        //if (flowLayoutPanel1.Controls.Count > 0)
        //{
        //    flowLayoutPanel1.Controls.Clear();
        //}
        //else
        //            flowLayoutPanel1.Controls.Add(listItems[i]);
        //    }
        //}


    }
}
