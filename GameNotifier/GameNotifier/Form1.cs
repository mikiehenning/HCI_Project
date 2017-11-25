using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private Boolean repeatAlways, ampm;
        private Timer selectedTimer, selectedUserTimer;
        private Game selectedGame;
        private Game userTimers;
        private List<Game> gameList = new List<Game>();

        //All var from the database

        public frMain()
        {
            InitializeComponent();

            //set up dataconnection and open it
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=HCI_Project;Integrated Security=True");
            conn.Open();


            DataSet GameDs = new DataSet();
            SqlDataAdapter GameAdaptor = new SqlDataAdapter(
                "Select title from Game", conn);
            GameAdaptor.Fill(GameDs);
            //set the listbox datasource to the game table and display titles
            this.lsbGames.DataSource = GameDs.Tables[0];
            this.lsbGames.DisplayMember = "title";

            //getting bosses
            SqlCommand SelectGIDCommand = new SqlCommand("SELECT * FROM Game", conn);
            SqlDataReader myreader;
           
            myreader = SelectGIDCommand.ExecuteReader();

            List<String> lstGamesID = new List<String>();
            List<Game> lstGameObjects = new List<Game>();
            List<Timer> lstTimerObjects = new List<Timer>();
            while (myreader.Read())
            {
                lstGamesID.Add(myreader[0].ToString());
                lstGameObjects.Add(new Game(myreader[1].ToString()));
              


            }

            foreach (String ID in lstGamesID){
                int IDnum = Int32.Parse(ID);

                SqlCommand selectBossWithID = new SqlCommand("Select * from BOss where game = " + ID, conn);


            
            }
            //conn.Close();

            userTimers = new Game("User Games");

            //Test Code, sample timers and games
            Game testGame1 = new Game("game1");
            Game testGame2 = new Game("game2");

            gameList.Add(testGame1);
            gameList.Add(testGame2);

            //lsbGames.Items.Add(testGame1.getName());
           // lsbGames.Items.Add(testGame2.getName());

            Timer timer1 = new Timer("timer1");
            Timer timer2 = new Timer("timer2");
            Timer timer3 = new Timer("timer3");
            Timer timer4 = new Timer("timer4");

            timer1.setTime("02", "20", false);
            timer1.setNotify(0);
            timer1.setRepeat(0, true);
            timer2.setTime("04", "50", true);
            timer3.setTime("12", "30", false);
            timer4.setTime("06", "44", true);
            testGame1.addTimer(timer1);
            testGame2.addTimer(timer2);
            testGame2.addTimer(timer3);
            testGame2.addTimer(timer4);

        }

        private void chbAlwaysRepeat_CheckedChanged(object sender, EventArgs e)
        {
            //disable and greys out the repeat value
            if (chbAlwaysRepeat.Checked)
            {
                nudRepeat.Enabled = false;
                lblRepeat.ForeColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
                chbAlwaysRepeat.ForeColor = Color.FromKnownColor(KnownColor.ControlLightLight);
                repeatAlways = true;
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
            if (rdbtnAM.Checked)
            {
                rdbtnAM.ForeColor = Color.FromKnownColor(KnownColor.ControlLightLight);
                ampm = true;
            }
            else
            {
                rdbtnAM.ForeColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
                ampm = false;
            }
        }

        private void rdbtnPM_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnPM.Checked) rdbtnPM.ForeColor = Color.FromKnownColor(KnownColor.ControlLightLight);
            else rdbtnPM.ForeColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
        }

        private void lsbGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedTxt = lsbGames.GetItemText(lsbGames.SelectedItem); //holds the txt of the currently selected item

            lsbGameItems.Items.Clear();

            foreach(Game game in gameList)
            {
                if(game.getName() == selectedTxt)
                {
                    List<Timer> timers = game.getAllTimers();

                    selectedGame = game;

                    foreach(Timer timer in timers)
                    {
                       lsbGameItems.Items.Add(timer.getName());
                    }
                }
            }
        }

        private void lsbGameItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedTxt = lsbGameItems.GetItemText(lsbGameItems.SelectedItem); //holds the txt of the currently selected item

            foreach(Timer timer in selectedGame.getAllTimers())
            {
                if (timer.getName() == selectedTxt) selectedTimer = timer;
            }                      
        }


        private void lsbTimers_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedTxt = lsbTimers.GetItemText(lsbTimers.SelectedItem); //holds the txt of the currently selected item

            rtxtTimerInfo.Clear();

            btnDelete.Enabled = true;

            foreach(Timer timer in userTimers.getAllTimers())
            {
                if (timer.getName() == selectedTxt) rtxtTimerInfo.Text = timer.getTimerInfo();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Timer newTimer = new Timer(txtName.Text);
            
            newTimer.setTime(dudTimeHr.SelectedItem.ToString(), dudTimeMin.SelectedItem.ToString(), ampm);
            newTimer.setNotify((int) nudNotifyMin.Value);
            newTimer.setRepeat((int) nudRepeat.Value, repeatAlways);

            userTimers.addTimer(newTimer);
            lsbTimers.Items.Add(newTimer.getName());
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (selectedTimer == null) return;

            btnAdd.Enabled = true;

            txtName.Text = selectedTimer.getName();
            dudTimeHr.SelectedIndex = dudTimeHr.Items.IndexOf(selectedTimer.getTimeHr());
            dudTimeMin.SelectedIndex = dudTimeMin.Items.IndexOf(selectedTimer.getTimeMin());

            if (selectedTimer.getAMPM()) rdbtnAM.Checked = true;
            else rdbtnPM.Checked = true;

            nudNotifyMin.Value = selectedTimer.getNotify();

            if (selectedTimer.repeatAlways())
            {
                chbAlwaysRepeat.Checked = true;
            }
            else
            {
                chbAlwaysRepeat.Checked = false;
                nudRepeat.Value = selectedTimer.getRepeat();
            }
        }

        //TODO add a notification asking if it's okay to delete the selected timer
        private void btnDelete_Click(object sender, EventArgs e)
        {
            String selectedTxt = lsbTimers.GetItemText(lsbTimers.SelectedItem);
            Timer timer = userTimers.getTimer(selectedTxt);

            userTimers.removeTimer(timer);
            lsbTimers.Items.Remove(lsbTimers.SelectedItem);
        }

    }
}
