using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SewingApp
{
    public partial class MainForm : Form
    {
        public static MainForm Instance { get; } = new MainForm();
        public Control PrimaryControl
        {
            get => panel1.GetPrimaryControl();
            set => panel1.SetPrimaryControl(value);
        }

        private MainForm()
        {
            InitializeComponent();
            MinimumSize = Size;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PrimaryControl = new Pages.Auth();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
