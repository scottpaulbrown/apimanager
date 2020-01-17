using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIManager.WIN {
    public partial class WizardButtons : UserControl {
        public delegate void NextClickedEvent(WizardNavigationArgs args);
        public delegate void PreviousClickedEvent(WizardNavigationArgs args);
        public event NextClickedEvent NextClicked;
        public event PreviousClickedEvent PreviousClicked;

        public bool FinishShown { get; set; }
        public bool PreviousShown { get; set; }

        public WizardButtons() {
            InitializeComponent();
        }

        public void Setup(WizardNavigationArgs args) {
            SetupButtons(args);
        }

        void OnNextClicked(WizardNavigationArgs args) {
            NextClicked?.Invoke(args);
        }

        void OnPreviousClicked(WizardNavigationArgs args) {
            PreviousClicked?.Invoke(args);
        }

        private void btnNext_Click(object sender, EventArgs e) {
            WizardNavigationArgs args = new WizardNavigationArgs();
            OnNextClicked(args);
            SetupButtons(args);
        }

        private void SetupButtons(WizardNavigationArgs args) {
            FinishShown = args.ShowFinish;
            PreviousShown = args.ShowPrevious;
            btnNext.Text = FinishShown ? "Finish" : "Next >";
            btnPrev.Visible = PreviousShown;
        }
    }
}
