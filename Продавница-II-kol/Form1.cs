using System;
using System.Windows.Forms;

namespace Продавница_II_kol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesingMenu();
            //panelslide.Height = button1.Height;
            doma1.BringToFront();
            StrucniKnigi_I.Rows = korpa1.getRows();
          
            

            
        }
        private void movepanel(Control btn)
        {
            panelButtos.Height = btn.Height;
            panelButtos.Top = btn.Top;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            movepanel(button1);
            doma1.BringToFront();
            
            
            //doma.BringToFront();
            /* panelButton1.Height = button1.Height;
             panelButton1.Top = button1.Top;
             button1.Visible = true;
             butt2.Visible = false;
             button3.Visible = false;*/

            //firstCustomControl.BringToFront();
            //panelButt2.Visible = true;
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            /* panelButt2.Height = butt2.Height;
             panelButt2.Top = butt2.Top;
             button1.Visible = false;
             butt2.Visible = true;
             button3.Visible = false;*/
            movepanel(butt2);

            //
            showSubMenu(panelButt2);

        }
        //private object korpa1;
        private void Button4_Click(object sender, EventArgs e)
        {
            /* panelButt3.Height = button3.Height;
             panelButt3.Top = button3.Top;
             button1.Visible = false;
             butt2.Visible = false;
             button3.Visible = true;*/

            movepanel(button3);
            korpa1.BringToFront();
        }
        private void customizeDesingMenu()
        {
            panelButt2.Visible = false;
        }
        private void hidSubMenu()
        {
            if (panelButt2.Visible == true) panelButt2.Visible = false;

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hidSubMenu();
                subMenu.Visible = true;

            }
            else
                subMenu.Visible = false;
        }

        private void Butt2p1_Click(object sender, EventArgs e)
        {
            hidSubMenu();
        }

        private void Butt2p2_Click(object sender, EventArgs e)
        {
            hidSubMenu();
        }

        private void Butt2p3_Click(object sender, EventArgs e)
        {
            hidSubMenu();
           knigi1.BringToFront();
        }

        private void Butt2p4_Click(object sender, EventArgs e)
        {
            hidSubMenu();
            deckiKnigi1.BringToFront();
        }

        private void Doma1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void Korpa1_Load(object sender, EventArgs e)
        {

        }
    }
    }




























//
//  ZA menito od strana so ne sakase!
//

/*   private void Butt2_MouseHover(object sender, EventArgs e)
   {
       panel1.Visible = true;
   }

   private void Butt2_MouseLeave(object sender, EventArgs e)
   {
       panel1.Visible = false;
   }

   private void PanelButt2_MouseEnter(object sender, EventArgs e)
   {
       panel1.Visible = true;
   }

   private void PanelButt2_MouseLeave(object sender, EventArgs e)
   {
       panel1.Visible = false;
   }*/
/*  private void Button7_Click(object sender, EventArgs e)
  {
      panelButt2.Visible = false;
  }
  private void Button3_Click(object sender, EventArgs e)
  {
      panelButt2.Visible = false;
  }
  */



/* private void Label1_Click(object sender, EventArgs e)
 {

 }

 private void Panel3_Paint(object sender, PaintEventArgs e)
 {

 }







 private void Form1_Load(object sender, EventArgs e)
 {

 }

 private void PanelButt3_Paint(object sender, PaintEventArgs e)
 {

 }

 private void PanelButt2_MouseHover(object sender, EventArgs e)
 {

 }

 private void PictureBox1_Click(object sender, EventArgs e)
 {

 }



 private void Butt2_Leave(object sender, EventArgs e)
 {
     panelButt2.Visible = true;
 }

 private void Butt2_DragEnter(object sender, DragEventArgs e)
 {
     panelButt2.Visible = true;
 }

 private void PanelButt2_MouseEnter(object sender, EventArgs e)
 {
     panelButt2.Visible = true;
 }

 private void PanelButt2_MouseLeave(object sender, EventArgs e)
 {
     panelButt2.Visible = false;
 }

 private void Butt2_MouseEnter(object sender, EventArgs e)
 {
     panel1.Visible = true;
 }*/

/* private void Butt2_MouseEnter(object sender, EventArgs e)
 {
     panelButt2.Visible = true;
 }*/
