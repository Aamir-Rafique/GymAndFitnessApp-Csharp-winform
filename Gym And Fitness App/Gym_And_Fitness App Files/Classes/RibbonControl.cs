using System;
using System.Drawing;
using System.Windows.Forms;

namespace GymAndFitness.Classes
{
    public partial class RibbonControl : UserControl
    {
        private Point _mouseOffset;
        private bool _mouseDown;

        public RibbonControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top; // Fix ribbon at the top
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.FindForm().WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Closes the entire application
            }
        }

        // Make the ribbon draggable (so users can move the window)
        private void RibbonControl_MouseDown_1(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _mouseOffset = e.Location;
        }

        private void RibbonControl_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                Form parentForm = this.FindForm();
                if (parentForm != null)
                {
                    parentForm.Location = new Point(
                        parentForm.Location.X + e.X - _mouseOffset.X,
                        parentForm.Location.Y + e.Y - _mouseOffset.Y);
                }
            }
        }

        private void RibbonControl_MouseUp_1(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void RibbonControl_Load(object sender, EventArgs e)
        {

        }
    }
}
