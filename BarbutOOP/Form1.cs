using BarbutOOP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbutOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bZarAt_Click(object sender, EventArgs e)
        {
            ZarlariAt();
        }

        private void ZarlariAt()
        {
            string path = @"C:\Users\ozan.yesil\source\repos\BarbutOOP\BarbutOOP\FilesZar";
            string extension = ".png";
            Zar zar = new Zar();
            byte zar1deger = zar.ZarAt();
            byte zar2deger = zar.ZarAt();
            string zar1yazi = zar.ZarYazısınıGetir(zar1deger);
            string zar2yazi = zar.ZarYazısınıGetir(zar2deger);
            //lZar1.Text = zar1yazi;
            //lZar2.Text = zar2yazi;
            lZar1.Image = Image.FromFile(path + "\\" + (zar1deger + 1) + extension);
            lZar2.Image = Image.FromFile(path + "\\" + (zar2deger + 1) + extension);
            //lZar1.Text = zar1deger.ToString();
            //lZar2.Text = "" + zar2deger;   //stringe çevirme yöntemleri //to string kullanman daha iyi
            if (zar1deger > zar2deger)
            {
                lbSonuc.Items.Add("1. Zar Kazandı.");
            }
            else if (zar2deger > zar1deger)
            {
                lbSonuc.Items.Add("2. Zar Kazandı.");
            }
            else
            {
                //lbSonuc.Items.Add("Berabere.");
                ZarlariAt();  //recursive method
            }
        }
    }
}
