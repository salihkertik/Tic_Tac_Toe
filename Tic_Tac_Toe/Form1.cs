using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{


    public partial class Form1 : Form
    {

        public char secimtipi = 'X';
        public List<int> Xkisi = new List<int>();
        //public List<int> Ykisi = new List<int>();

        public Form1()
        {
            InitializeComponent();
            // pictureBox1.Load("./img/O.png");
            //  pictureBox1.Invalidate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pbsender = (PictureBox)sender;
            if (pbsender.Image != null) return;

            if (secimtipi == 'X')
            {
                pbsender.Load("./img/X.png");
                pbsender.Invalidate();
                pbsender.Tag = secimtipi;
                secimtipi = 'O';


                
                for (int i = 1; i <= 9; i++)
                {


                    if (i==15)
                    {
                        MessageBox.Show("Kazandınız.");
                    }
                }

            }


            else
            {
                pbsender.Load("./img/O.png");
                pbsender.Invalidate();
                pbsender.Tag = secimtipi;
                secimtipi = 'X';

            }

            
            if (pbsender.Name == "pictureBox1")
            {
                if (Convert.ToString(pbsender.Tag) == Convert.ToString(pictureBox2.Tag) && Convert.ToString(pbsender.Tag) == Convert.ToString(pictureBox3.Tag))
                {
                    MessageBox.Show("Kazandınız");
                }
                else if (Convert.ToString(pbsender.Tag) == Convert.ToString(pictureBox4.Tag) && Convert.ToString(pbsender.Tag) == Convert.ToString(pictureBox7.Tag))
                {
                    MessageBox.Show("Kazandınız");
                }
                if (Convert.ToString(pbsender.Tag) == Convert.ToString(pictureBox5.Tag) && Convert.ToString(pbsender.Tag) == Convert.ToString(pictureBox9.Tag))
                {
                    MessageBox.Show("Kazandınız");
                }
            }

            if (pbsender.Name == "pictureBox2")
            {
                if (Convert.ToString(pbsender.Tag) == Convert.ToString(pictureBox1.Tag) && Convert.ToString(pbsender.Tag) == Convert.ToString(pictureBox3.Tag))
                {
                    MessageBox.Show("Kazandınız");
                }
                else if (Convert.ToString(pbsender.Tag) == Convert.ToString(pictureBox5.Tag) && Convert.ToString(pbsender.Tag) == Convert.ToString(pictureBox8.Tag))
                {
                    MessageBox.Show("Kazandınız");
                }

            }
        }
    }
}
