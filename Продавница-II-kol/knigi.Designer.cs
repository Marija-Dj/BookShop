namespace Продавница_II_kol
{
    partial class knigi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(knigi));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.naslov = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.strucniKnigi_I4 = new Продавница_II_kol.StrucniKnigi_I();
            this.strucniKnigi_I6 = new Продавница_II_kol.StrucniKnigi_I();
            this.strucniKnigi_I7 = new Продавница_II_kol.StrucniKnigi_I();
            this.strucniKnigi_I1 = new Продавница_II_kol.StrucniKnigi_I();
            this.strucniKnigi_I2 = new Продавница_II_kol.StrucniKnigi_I();
            this.strucniKnigi_I3 = new Продавница_II_kol.StrucniKnigi_I();
            this.strucniKnigi_I5 = new Продавница_II_kol.StrucniKnigi_I();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.strucniKnigi_I1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.strucniKnigi_I2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.strucniKnigi_I3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.strucniKnigi_I5, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 105);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(790, 395);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // naslov
            // 
            this.naslov.AutoSize = true;
            this.naslov.Font = new System.Drawing.Font("Microsoft YaHei", 25.8F, System.Drawing.FontStyle.Bold);
            this.naslov.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.naslov.Location = new System.Drawing.Point(3, 12);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(493, 57);
            this.naslov.TabIndex = 0;
            this.naslov.Text = "Стручна литература ";
            this.naslov.Click += new System.EventHandler(this.Naslov_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(0, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 427);
            this.panel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.strucniKnigi_I4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.strucniKnigi_I6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.strucniKnigi_I7, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(790, 427);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.radioButton2.Location = new System.Drawing.Point(6, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(124, 28);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Економија";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(6, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(155, 28);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Информатика";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(534, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 73);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // strucniKnigi_I4
            // 
            this.strucniKnigi_I4.ID = 5;
            this.strucniKnigi_I4.Location = new System.Drawing.Point(3, 3);
            this.strucniKnigi_I4.Name = "strucniKnigi_I4";
            this.strucniKnigi_I4.picProduct = ((System.Drawing.Image)(resources.GetObject("strucniKnigi_I4.picProduct")));
            this.strucniKnigi_I4.Product_Cena = "2300 ";
            this.strucniKnigi_I4.Product_Naslov = "Банкарски менаџмент";
            this.strucniKnigi_I4.Product_Zaliha = "Има";
            this.strucniKnigi_I4.Qty = 0;
            this.strucniKnigi_I4.Size = new System.Drawing.Size(762, 232);
            this.strucniKnigi_I4.TabIndex = 0;
            // 
            // strucniKnigi_I6
            // 
            this.strucniKnigi_I6.ID = 6;
            this.strucniKnigi_I6.Location = new System.Drawing.Point(3, 241);
            this.strucniKnigi_I6.Name = "strucniKnigi_I6";
            this.strucniKnigi_I6.picProduct = ((System.Drawing.Image)(resources.GetObject("strucniKnigi_I6.picProduct")));
            this.strucniKnigi_I6.Product_Cena = "1630 ";
            this.strucniKnigi_I6.Product_Naslov = "Претприемаштво";
            this.strucniKnigi_I6.Product_Zaliha = "Има";
            this.strucniKnigi_I6.Qty = 0;
            this.strucniKnigi_I6.Size = new System.Drawing.Size(762, 245);
            this.strucniKnigi_I6.TabIndex = 0;
            // 
            // strucniKnigi_I7
            // 
            this.strucniKnigi_I7.ID = 7;
            this.strucniKnigi_I7.Location = new System.Drawing.Point(3, 492);
            this.strucniKnigi_I7.Name = "strucniKnigi_I7";
            this.strucniKnigi_I7.picProduct = ((System.Drawing.Image)(resources.GetObject("strucniKnigi_I7.picProduct")));
            this.strucniKnigi_I7.Product_Cena = "2000";
            this.strucniKnigi_I7.Product_Naslov = "Вовед во современиот економски раст";
            this.strucniKnigi_I7.Product_Zaliha = "Има ";
            this.strucniKnigi_I7.Qty = 0;
            this.strucniKnigi_I7.Size = new System.Drawing.Size(762, 232);
            this.strucniKnigi_I7.TabIndex = 0;
            // 
            // strucniKnigi_I1
            // 
            this.strucniKnigi_I1.Dock = System.Windows.Forms.DockStyle.Left;
            this.strucniKnigi_I1.ID = 1;
            this.strucniKnigi_I1.Location = new System.Drawing.Point(3, 3);
            this.strucniKnigi_I1.Name = "strucniKnigi_I1";
            this.strucniKnigi_I1.picProduct = ((System.Drawing.Image)(resources.GetObject("strucniKnigi_I1.picProduct")));
            this.strucniKnigi_I1.Product_Cena = "2990  ";
            this.strucniKnigi_I1.Product_Naslov = "Алгоритми за планирање";
            this.strucniKnigi_I1.Product_Zaliha = "Има ";
            this.strucniKnigi_I1.Qty = 0;
            this.strucniKnigi_I1.Size = new System.Drawing.Size(776, 236);
            this.strucniKnigi_I1.TabIndex = 0;
            // 
            // strucniKnigi_I2
            // 
            this.strucniKnigi_I2.Dock = System.Windows.Forms.DockStyle.Left;
            this.strucniKnigi_I2.ID = 2;
            this.strucniKnigi_I2.Location = new System.Drawing.Point(3, 245);
            this.strucniKnigi_I2.Name = "strucniKnigi_I2";
            this.strucniKnigi_I2.picProduct = ((System.Drawing.Image)(resources.GetObject("strucniKnigi_I2.picProduct")));
            this.strucniKnigi_I2.Product_Cena = "3990 ";
            this.strucniKnigi_I2.Product_Naslov = "Концепти на оперативните системи";
            this.strucniKnigi_I2.Product_Zaliha = "Има ";
            this.strucniKnigi_I2.Qty = 0;
            this.strucniKnigi_I2.Size = new System.Drawing.Size(776, 238);
            this.strucniKnigi_I2.TabIndex = 0;
            // 
            // strucniKnigi_I3
            // 
            this.strucniKnigi_I3.Dock = System.Windows.Forms.DockStyle.Left;
            this.strucniKnigi_I3.ID = 3;
            this.strucniKnigi_I3.Location = new System.Drawing.Point(3, 489);
            this.strucniKnigi_I3.Name = "strucniKnigi_I3";
            this.strucniKnigi_I3.picProduct = ((System.Drawing.Image)(resources.GetObject("strucniKnigi_I3.picProduct")));
            this.strucniKnigi_I3.Product_Cena = "4200 ";
            this.strucniKnigi_I3.Product_Naslov = "Програмскиот јазик C++";
            this.strucniKnigi_I3.Product_Zaliha = "Наскоро";
            this.strucniKnigi_I3.Qty = 0;
            this.strucniKnigi_I3.Size = new System.Drawing.Size(762, 238);
            this.strucniKnigi_I3.TabIndex = 0;
            // 
            // strucniKnigi_I5
            // 
            this.strucniKnigi_I5.ID = 4;
            this.strucniKnigi_I5.Location = new System.Drawing.Point(3, 733);
            this.strucniKnigi_I5.Name = "strucniKnigi_I5";
            this.strucniKnigi_I5.picProduct = ((System.Drawing.Image)(resources.GetObject("strucniKnigi_I5.picProduct")));
            this.strucniKnigi_I5.Product_Cena = "2450 ";
            this.strucniKnigi_I5.Product_Naslov = "Концепти во програмските јазици";
            this.strucniKnigi_I5.Product_Zaliha = "Има ";
            this.strucniKnigi_I5.Qty = 0;
            this.strucniKnigi_I5.Size = new System.Drawing.Size(776, 234);
            this.strucniKnigi_I5.TabIndex = 0;
            // 
            // knigi
            // 
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.naslov);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "knigi";
            this.Size = new System.Drawing.Size(790, 500);
            this.Load += new System.EventHandler(this.Knigi_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private StrucniKnigi_I strucniKnigi_I1;
        private StrucniKnigi_I strucniKnigi_I2;
        private StrucniKnigi_I strucniKnigi_I3;
        private StrucniKnigi_I strucniKnigi_I5;
        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private StrucniKnigi_I strucniKnigi_I4;
        private StrucniKnigi_I strucniKnigi_I6;
        private StrucniKnigi_I strucniKnigi_I7;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
