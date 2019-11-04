using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovning2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // List
        List<Media> mediaList = new List<Media>();

        private void BtnRegisterBook_Click(object sender, EventArgs e)
        {
            try
            {
                string title = tbxTitleBook.Text;
                int pageAmount = int.Parse(tbxSides.Text);
                Book b = new Book(pageAmount, title);
                mediaList.Add(b);

                lbxLibrary.Items.Add(b.ToString());

                //clear textboxes
                tbxTitleBook.Clear();
                tbxSides.Clear();
            }
            catch
            {
                MessageBox.Show("Du har skrivit fel");

                //clear textboxes
                tbxTitleBook.Clear();
                tbxSides.Clear();
            }
        }

        private void BtnRegisterSound_Click(object sender, EventArgs e)
        {
            try
            {
                string title = tbxTitleSound.Text;
                double playTime = double.Parse(tbxPlayTime.Text);
                Sound s = new Sound(playTime, title);
                mediaList.Add(s);

                lbxLibrary.Items.Add(s.ToString());

                //clear textboxes
                tbxTitleSound.Clear();
                tbxPlayTime.Clear();
            }
            catch
            {
                MessageBox.Show("Du har skrivit fel");

                //clear textboxes
                tbxTitleSound.Clear();
                tbxPlayTime.Clear();
            }
        }

        private void BtnRegisterMovie_Click(object sender, EventArgs e)
        {
            try
            {
                string title = tbxTitle.Text;
                int playTime = int.Parse(tbxTimeMovie.Text);
                string resolution = TbxResolution.Text;
                Movie m = new Movie(resolution, playTime, title);
                mediaList.Add(m);

                lbxLibrary.Items.Add(m.ToString());

                //clear textboxes
                tbxTitle.Clear();
                tbxTimeMovie.Clear();
                TbxResolution.Clear();
            }
            catch
            {
                MessageBox.Show("Du har skrivit fel");

                //clear textboxes
                tbxTitle.Clear();
                tbxTimeMovie.Clear();
                TbxResolution.Clear();
            }
        }
    }
}
