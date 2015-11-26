using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tron
{
    public partial class GameForm : Form
    {
        public PictureBox Surface => pictureBox;

        public GameForm()
        {
            InitializeComponent();
        }
    }
}
