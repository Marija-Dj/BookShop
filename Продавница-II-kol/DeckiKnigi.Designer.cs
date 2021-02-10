namespace Продавница_II_kol
{
    partial class DeckiKnigi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeckiKnigi));
            this.naslov = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.strucniKnigi_I1 = new Продавница_II_kol.StrucniKnigi_I();
            this.strucniKnigi_I2 = new Продавница_II_kol.StrucniKnigi_I();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // naslov
            // 
            this.naslov.AutoSize = true;
            this.naslov.Font = new System.Drawing.Font("Microsoft YaHei", 25.8F, System.Drawing.FontStyle.Bold);
            this.naslov.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.naslov.Location = new System.Drawing.Point(3, 18);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(469, 57);
            this.naslov.TabIndex = 1;
            this.naslov.Text = "Литература за деца";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.strucniKnigi_I1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.strucniKnigi_I2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 121);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(787, 379);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // strucniKnigi_I1
            // 
            this.strucniKnigi_I1.ID = 8;
            this.strucniKnigi_I1.Location = new System.Drawing.Point(3, 3);
            this.strucniKnigi_I1.Name = "strucniKnigi_I1";
            this.strucniKnigi_I1.picProduct = ((System.Drawing.Image)(resources.GetObject("strucniKnigi_I1.picProduct")));
            this.strucniKnigi_I1.Product_Cena = "150";
            this.strucniKnigi_I1.Product_Naslov = "Матеј и Луна поаѓаат на училиште";
            this.strucniKnigi_I1.Product_Zaliha = "Има";
            this.strucniKnigi_I1.Qty = 0;
            this.strucniKnigi_I1.Size = new System.Drawing.Size(760, 234);
            this.strucniKnigi_I1.TabIndex = 0;
            // 
            // strucniKnigi_I2
            // 
            this.strucniKnigi_I2.ID = 9;
            this.strucniKnigi_I2.Location = new System.Drawing.Point(3, 243);
            this.strucniKnigi_I2.Name = "strucniKnigi_I2";
            this.strucniKnigi_I2.picProduct = ((System.Drawing.Image)(resources.GetObject("strucniKnigi_I2.picProduct")));
            this.strucniKnigi_I2.Product_Cena = "390";
            this.strucniKnigi_I2.Product_Naslov = "Кога светот беше млад";
            this.strucniKnigi_I2.Product_Zaliha = "Има";
            this.strucniKnigi_I2.Qty = 0;
            this.strucniKnigi_I2.Size = new System.Drawing.Size(760, 235);
            this.strucniKnigi_I2.TabIndex = 0;
            // 
            // DeckiKnigi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.naslov);
            this.Name = "DeckiKnigi";
            this.Size = new System.Drawing.Size(790, 500);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private StrucniKnigi_I strucniKnigi_I1;
        private StrucniKnigi_I strucniKnigi_I2;
    }
}
