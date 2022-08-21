using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerhabaWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TextBox tb_ad = new TextBox();
            tb_ad.Size = new Size(100, 50);
            tb_ad.Location = new Point(300, 20);
            this.Controls.Add(tb_ad);

            TextBox tb_soyad = new TextBox();
            tb_soyad.Size = new Size(100, 50);
            tb_soyad.Location = new Point(300, 50);
            this.Controls.Add(tb_soyad);

            Label lbl_name = new Label();
            lbl_name.Text = "isim";
            lbl_name.Size = new Size(100, 50);
            lbl_name.Location = new Point(200, 20);
            this.Controls.Add(lbl_name);

            Label lbl_soyad = new Label();
            lbl_soyad.Text = "soyad";
            lbl_soyad.Size=new Size(100, 50);
            lbl_soyad.Location = new Point(200, 70);
            this.Controls.Add(lbl_soyad);

            Button button= new Button();
            button.Text = "sakın dokanma";
            button.UseVisualStyleBackColor = true;
            button.Size = new Size(150, 50);
            button.Location = new Point(250, 100);
            this.Controls.Add(button);
        }

    }
}
