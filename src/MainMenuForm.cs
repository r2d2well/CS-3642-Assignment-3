using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_3642_Assignment__3
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void BlockImageButton_Click(object sender, EventArgs e)
        {
            BlockImageForm blockImageForm = new BlockImageForm();
            blockImageForm.ShowDialog();
            //Opens new BlockImageForm
        }

        private void MoviePerdictionButton_Click(object sender, EventArgs e)
        {
            MoviePerdictionForm moviePerdictionForm = new MoviePerdictionForm();
            moviePerdictionForm.ShowDialog();
            //Opens new MoviePerdictionForm
        }
    }
}
