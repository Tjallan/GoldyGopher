using System;
using System.Windows.Forms;

namespace GoldyGopher
{
    public partial class GoldyGopher : Form
    {

        private enum ApplicationState { Startup, Idle, Processing }

        public GoldyGopher()
        {
            InitializeComponent();
            setControlState(ApplicationState.Idle);
        }

        private Boolean cancelProcessing = false;
        /// <summary>
        /// Manage UI elements
        /// </summary>
        /// <param name="transitionState"></param>
        private void setControlState(ApplicationState transitionState)
        {
            if (transitionState == ApplicationState.Startup)
            {
                tbx_LowerBounds.Enabled = false;
                tbx_UpperBounds.Enabled = false;
                btnScan.Enabled = false;
                btnScan.Visible = true;
                btn_Cancel.Enabled = false;
                btn_Cancel.Visible = false;
                btn_Exit.Enabled = false;
             }
            else
            if (transitionState == ApplicationState.Idle)
            {
                tbx_LowerBounds.Enabled = true;
                tbx_UpperBounds.Enabled = true;
                btnScan.Enabled = true;
                btnScan.Visible = true;
                btn_Cancel.Enabled = true;
                btn_Cancel.Visible = false;
                btn_Exit.Enabled = true;
            }
            else if (transitionState == ApplicationState.Processing)
            {
                tbx_LowerBounds.Enabled = false;
                tbx_UpperBounds.Enabled = false;
                btnScan.Enabled = false;
                btnScan.Visible = false;
                btn_Cancel.Enabled = true;
                btn_Cancel.Visible = true;
                btn_Exit.Enabled = false;
            }
            Application.DoEvents();//process other messages on UI thread
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            int lowerBounds = 0;
            int upperBounds = 0;
            setControlState(ApplicationState.Processing);
            cancelProcessing = false;
            try
            {
                lstbx_Items.Items.Clear();

                lowerBounds = int.Parse(tbx_LowerBounds.Text);
                upperBounds = int.Parse(tbx_UpperBounds.Text);

                if (lowerBounds > upperBounds)
                {
                    MessageBox.Show("Lower bounds must be less than upper bounds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (upperBounds - lowerBounds > 32768)
                {
                    MessageBox.Show("Range between lower and upper bounds must be less than 32768.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                for (int idx = lowerBounds; idx <=upperBounds; idx++)
                {
                    Boolean mod3 = (idx % 3 == 0) && idx != 0;
                    Boolean mod7 = (idx % 7 == 0) && idx != 0;
                    if (mod3 && mod7)
                    {
                        lstbx_Items.Items.Add("Goldy Gopher");
                    }
                    else if (mod3)
                    {
                        lstbx_Items.Items.Add("Goldy");
                    }
                    else if (mod7)
                    {
                        lstbx_Items.Items.Add("Gopher");
                    }
                    else
                    {
                        lstbx_Items.Items.Add(idx.ToString());
                    }

                    Application.DoEvents();//process other messages on UI thread
 
                    if (cancelProcessing)
                    {
                        break;
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("A Processing Error Occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                finally
            {
                setControlState(ApplicationState.Idle);
            }
        }

        private void txtNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            cancelProcessing = true;
        }
        private void formClosing(object sender, FormClosingEventArgs e)
        {
            cancelProcessing = true;
        }
    }
}
