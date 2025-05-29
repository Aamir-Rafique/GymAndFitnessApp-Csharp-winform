using System;
using System.Windows.Forms;

namespace GymAndFitness.Forms
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            slidePanel1.BringToFront();
        }

        private void slidePanel1_Load(object sender, EventArgs e)
        {

        }
    }
}
