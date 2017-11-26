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

            
            //set up dataconnection and open it, can get this string when connecting database
            //THIS STRING WILL PROBABLY BE DIFFERENT FOR YOU, GET IT FROM THE DATA SOURCE CREATED --ASK THOMAS IF QUESTION
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=HCI_Project;Integrated Security=True");
            conn.Open();

            //create data transfer objects
            DataSet GameDs = new DataSet();  //place to put data
            SqlDataAdapter GameAdaptor = new SqlDataAdapter(//sends query and fills dataset
                "Select title from Game", conn);
            GameAdaptor.Fill(GameDs);
            //set the listbox datasource to the game table and display titles
            this.lsbGames.DataSource = GameDs.Tables[0];
            this.lsbGames.DisplayMember = "title"; //gets column by string name

            //getting bosses
            SqlCommand SelectGamesCommand = new SqlCommand("SELECT * FROM Game", conn);
            SqlDataReader GameReader;
           
            GameReader = SelectGamesCommand.ExecuteReader();

            List<Timer> lstTimerObjects = new List<Timer>();  //holds timer objects
            List<Game> tmpGameObjects = new List<Game>();//tempory GameObjects

            //creates game objects, puts them in list
            while (GameReader.Read())
            {
                String objectName = GameReader[1].ToString();
                Game gameObject = new Game(objectName);

                gameObject.ID = Int32.Parse(GameReader[0].ToString());
                tmpGameObjects.Add(gameObject);
            }

            GameReader.Close(); //close reader


            // add timers to games 
            foreach (Game game in tmpGameObjects)
            {
                SqlCommand SelectBosses = new SqlCommand("SELECT * FROM Boss where game = " + game.ID.ToString() + ";", conn);
                SqlDataReader BossReader;

                BossReader = SelectBosses.ExecuteReader();

                String gameName = game.getName();
                Game realGame = new Game(gameName);
                realGame.ID = game.ID;

                while (BossReader.Read())
                {
                    String timerName = BossReader[2].ToString();
                    Timer timer = new Timer(timerName);

                    String goTime = BossReader[3].ToString();

                    String[] timeSplit = goTime.Split(':');

                    bool ampm;

                    String hour = timeSplit[0];
                    int hourNum = Int32.Parse(hour);
                    if(hourNum > 12)
                    {
                        ampm = false;
                        hourNum = hourNum - 12;
                        hour = hourNum.ToString();
                    } else
                    {
                        ampm = true;
                    }


                    timer.setTime(hour, timeSplit[1], ampm);
                    timer.GID = game.ID;

                    realGame.addTimer(timer);

                    Console.WriteLine(realGame.getTimer(timerName).getName());
                    Console.WriteLine(timer.getTimeHr() + " this is hour");
                    Console.WriteLine(timer.GID.ToString());


                }

                BossReader.Close();

                List<Timer> gameTimers = realGame.getAllTimers();

                foreach(Timer timer in gameTimers)
                {
                    Console.WriteLine(timer.getName() + ":BossName, " + timer.GID.ToString() + ":GID");
                }

                gameList.Add(realGame);

            }

            //The user is a "game" that has its own timers, the user timers
            userTimers = new Game("User Games");

            /*
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
            */
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

                    int i = 0;
                    foreach(Timer timer in timers)
                    {
                       Console.WriteLine(i.ToString());
                       lsbGameItems.Items.Add(timer.getName());
                       i++;
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

        private void dudTimeHr_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Timer newTimer = new Timer(txtName.Text);

            

            newTimer.setTime(dudTimeHr.SelectedItem.ToString(), dudTimeMin.SelectedItem.ToString(), ampm);
            newTimer.setNotify((int) nudNotifyMin.Value);
            newTimer.setRepeat((int)nudRepeat.Value, repeatAlways);
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

            int hour = Int32.Parse(selectedTimer.getTimeHr()); //deal with indexes in domainUpDownBox
            


             dudTimeHr.SelectedIndex = Int32.Parse(selectedTimer.getTimeHr()) - 1;
             dudTimeMin.SelectedIndex = Int32.Parse(selectedTimer.getTimeMin());
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
