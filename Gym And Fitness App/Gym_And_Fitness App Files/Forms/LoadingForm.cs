using GymAndFitness.Classes;
using System;
using System.Windows.Forms;

namespace GymAndFitness.Forms
{
    public partial class LoadingForm : Form
    {

        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            LoadingFormClass.LoadingFormLoadEvents(timerLoading, lblVersion);
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            LoadingFormClass.StartLoading(lblLoading, lblWelcome, progressBarLoading, timerLoading);
        }




    }
}
