using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameNotifier
{
    public partial class frMain : Form
    {
        //All obj from the interface
        //DomainUpDown dudTimeHour, dudTimeMinutes;

        //All var set from the UI
        private int timeHr , timeMin;
        private Boolean repeatAlways = true;

        //All var from the database

        public frMain()
        {
            InitializeComponent();

            //timeHr = (int)dudTimeHr.SelectedItem;
           // timeMin = (int)dudTimeMin.SelectedItem;
        }

        private void dudTimeHr_SelectedItemChanged(object sender, EventArgs e)
        {
            //int hours;
            //if (dudTimeHr.SelectedIndex == 11) dudTimeHr.SelectedIndex = 0;
           // timeHr = (int) dudTimeHr.SelectedItem;

        }

        private void chbAlwaysRepeat_CheckedChanged(object sender, EventArgs e)
        {
            //disable and greys out the repeat value
            if (chbAlwaysRepeat.Checked)
            {
                nudRepeat.Enabled = false;
                lblRepeat.ForeColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
                chbAlwaysRepeat.ForeColor = Color.FromKnownColor(KnownColor.ControlLightLight);
            }
            else
            {
                nudRepeat.Enabled = true;
                chbAlwaysRepeat.Checked = false;
                chbAlwaysRepeat.ForeColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
                lblRepeat.ForeColor = Color.FromKnownColor(KnownColor.ControlLightLight);
                repeatAlways = false;
            }
        }

        private void rdbtnAM_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbtnAM.Checked) rdbtnAM.ForeColor = Color.FromKnownColor(KnownColor.ControlLightLight);
            else rdbtnAM.ForeColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
        }

        private void rdbtnPM_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnPM.Checked) rdbtnPM.ForeColor = Color.FromKnownColor(KnownColor.ControlLightLight);
            else rdbtnPM.ForeColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
        }

        private void dudTimeMin_SelectedItemChanged(object sender, EventArgs e)
        {
            //timeMin = (int) dudTimeMin.SelectedItem;
        }
    }
}
