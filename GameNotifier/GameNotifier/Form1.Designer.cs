namespace GameNotifier
{
    partial class frMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbNotify = new System.Windows.Forms.Label();
            this.lblRepeat = new System.Windows.Forms.Label();
            this.lbNotifySub = new System.Windows.Forms.Label();
            this.lbRepeatSub = new System.Windows.Forms.Label();
            this.rdbtnAM = new System.Windows.Forms.RadioButton();
            this.rdbtnPM = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lsbGames = new System.Windows.Forms.ListBox();
            this.lsbGameItems = new System.Windows.Forms.ListBox();
            this.lsbTimers = new System.Windows.Forms.ListBox();
            this.rtxtTimerInfo = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblFind = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblCustomize = new System.Windows.Forms.Label();
            this.lblColon = new System.Windows.Forms.Label();
            this.nudNotifyMin = new System.Windows.Forms.NumericUpDown();
            this.nudRepeat = new System.Windows.Forms.NumericUpDown();
            this.dudTimeHr = new System.Windows.Forms.DomainUpDown();
            this.dudTimeMin = new System.Windows.Forms.DomainUpDown();
            this.grpbAmPm = new System.Windows.Forms.GroupBox();
            this.chbAlwaysRepeat = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNotifyMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepeat)).BeginInit();
            this.grpbAmPm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Image = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.btnAdd.Location = new System.Drawing.Point(501, 526);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 37);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbTime.Image = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.lbTime.Location = new System.Drawing.Point(367, 161);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(130, 55);
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "Time";
            // 
            // lbNotify
            // 
            this.lbNotify.AutoSize = true;
            this.lbNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotify.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbNotify.Image = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.lbNotify.Location = new System.Drawing.Point(369, 280);
            this.lbNotify.Name = "lbNotify";
            this.lbNotify.Size = new System.Drawing.Size(113, 42);
            this.lbNotify.TabIndex = 3;
            this.lbNotify.Text = "Notify";
            // 
            // lblRepeat
            // 
            this.lblRepeat.AutoSize = true;
            this.lblRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeat.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblRepeat.Image = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.lblRepeat.Location = new System.Drawing.Point(369, 401);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(139, 42);
            this.lblRepeat.TabIndex = 4;
            this.lblRepeat.Text = "Repeat";
            // 
            // lbNotifySub
            // 
            this.lbNotifySub.AutoSize = true;
            this.lbNotifySub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotifySub.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbNotifySub.Image = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.lbNotifySub.Location = new System.Drawing.Point(652, 293);
            this.lbNotifySub.Name = "lbNotifySub";
            this.lbNotifySub.Size = new System.Drawing.Size(115, 25);
            this.lbNotifySub.TabIndex = 5;
            this.lbNotifySub.Text = "min Before";
            // 
            // lbRepeatSub
            // 
            this.lbRepeatSub.AutoSize = true;
            this.lbRepeatSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRepeatSub.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbRepeatSub.Image = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.lbRepeatSub.Location = new System.Drawing.Point(652, 409);
            this.lbRepeatSub.Name = "lbRepeatSub";
            this.lbRepeatSub.Size = new System.Drawing.Size(70, 25);
            this.lbRepeatSub.TabIndex = 6;
            this.lbRepeatSub.Text = "Times";
            // 
            // rdbtnAM
            // 
            this.rdbtnAM.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbtnAM.AutoSize = true;
            this.rdbtnAM.BackgroundImage = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.rdbtnAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rdbtnAM.Checked = true;
            this.rdbtnAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnAM.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rdbtnAM.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdbtnAM.Location = new System.Drawing.Point(6, 13);
            this.rdbtnAM.Name = "rdbtnAM";
            this.rdbtnAM.Size = new System.Drawing.Size(54, 35);
            this.rdbtnAM.TabIndex = 11;
            this.rdbtnAM.TabStop = true;
            this.rdbtnAM.Text = "AM";
            this.rdbtnAM.UseVisualStyleBackColor = true;
            this.rdbtnAM.CheckedChanged += new System.EventHandler(this.rdbtnAM_CheckedChanged);
            // 
            // rdbtnPM
            // 
            this.rdbtnPM.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbtnPM.AutoSize = true;
            this.rdbtnPM.BackgroundImage = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.rdbtnPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnPM.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rdbtnPM.Location = new System.Drawing.Point(6, 49);
            this.rdbtnPM.Name = "rdbtnPM";
            this.rdbtnPM.Size = new System.Drawing.Size(54, 35);
            this.rdbtnPM.TabIndex = 12;
            this.rdbtnPM.Text = "PM";
            this.rdbtnPM.UseVisualStyleBackColor = true;
            this.rdbtnPM.CheckedChanged += new System.EventHandler(this.rdbtnPM_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtSearch.Location = new System.Drawing.Point(22, 80);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.MaxLength = 216;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(271, 28);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.Text = "search";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lsbGames
            // 
            this.lsbGames.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lsbGames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbGames.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lsbGames.FormattingEnabled = true;
            this.lsbGames.HorizontalScrollbar = true;
            this.lsbGames.ItemHeight = 20;
            this.lsbGames.Location = new System.Drawing.Point(22, 127);
            this.lsbGames.Name = "lsbGames";
            this.lsbGames.Size = new System.Drawing.Size(271, 120);
            this.lsbGames.TabIndex = 14;
            this.lsbGames.SelectedIndexChanged += new System.EventHandler(this.lsbGames_SelectedIndexChanged);
            // 
            // lsbGameItems
            // 
            this.lsbGameItems.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lsbGameItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbGameItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbGameItems.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lsbGameItems.FormattingEnabled = true;
            this.lsbGameItems.HorizontalScrollbar = true;
            this.lsbGameItems.ItemHeight = 20;
            this.lsbGameItems.Location = new System.Drawing.Point(22, 253);
            this.lsbGameItems.Name = "lsbGameItems";
            this.lsbGameItems.Size = new System.Drawing.Size(271, 300);
            this.lsbGameItems.TabIndex = 15;
            this.lsbGameItems.SelectedIndexChanged += new System.EventHandler(this.lsbGameItems_SelectedIndexChanged);
            // 
            // lsbTimers
            // 
            this.lsbTimers.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lsbTimers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbTimers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbTimers.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lsbTimers.FormattingEnabled = true;
            this.lsbTimers.HorizontalScrollbar = true;
            this.lsbTimers.ItemHeight = 20;
            this.lsbTimers.Location = new System.Drawing.Point(917, 80);
            this.lsbTimers.Name = "lsbTimers";
            this.lsbTimers.Size = new System.Drawing.Size(320, 280);
            this.lsbTimers.TabIndex = 16;
            this.lsbTimers.SelectedIndexChanged += new System.EventHandler(this.lsbTimers_SelectedIndexChanged);
            // 
            // rtxtTimerInfo
            // 
            this.rtxtTimerInfo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rtxtTimerInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtTimerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtTimerInfo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rtxtTimerInfo.Location = new System.Drawing.Point(917, 371);
            this.rtxtTimerInfo.Name = "rtxtTimerInfo";
            this.rtxtTimerInfo.Size = new System.Drawing.Size(320, 203);
            this.rtxtTimerInfo.TabIndex = 17;
            this.rtxtTimerInfo.Text = "";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtName.Location = new System.Drawing.Point(454, 107);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.MaxLength = 216;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(286, 28);
            this.txtName.TabIndex = 18;
            this.txtName.Text = "Timer Name";
            // 
            // btnSelect
            // 
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSelect.Image = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.btnSelect.Location = new System.Drawing.Point(66, 585);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(170, 37);
            this.btnSelect.TabIndex = 19;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFind.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFind.Image = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.lblFind.Location = new System.Drawing.Point(61, 17);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(132, 58);
            this.lblFind.TabIndex = 20;
            this.lblFind.Text = "Search For\r\n Games";
            this.lblFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActive.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblActive.Image = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.lblActive.Location = new System.Drawing.Point(935, 33);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(220, 42);
            this.lblActive.TabIndex = 21;
            this.lblActive.Text = "Your Timers";
            // 
            // lblCustomize
            // 
            this.lblCustomize.AutoSize = true;
            this.lblCustomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCustomize.Image = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.lblCustomize.Location = new System.Drawing.Point(465, 33);
            this.lblCustomize.Name = "lblCustomize";
            this.lblCustomize.Size = new System.Drawing.Size(194, 42);
            this.lblCustomize.TabIndex = 22;
            this.lblCustomize.Text = "Customize";
            // 
            // lblColon
            // 
            this.lblColon.AutoSize = true;
            this.lblColon.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblColon.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColon.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblColon.Image = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.lblColon.Location = new System.Drawing.Point(602, 168);
            this.lblColon.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.lblColon.MinimumSize = new System.Drawing.Size(0, 1);
            this.lblColon.Name = "lblColon";
            this.lblColon.Size = new System.Drawing.Size(28, 42);
            this.lblColon.TabIndex = 23;
            this.lblColon.Text = ":";
            // 
            // nudNotifyMin
            // 
            this.nudNotifyMin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nudNotifyMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudNotifyMin.Cursor = System.Windows.Forms.Cursors.Default;
            this.nudNotifyMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNotifyMin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nudNotifyMin.Location = new System.Drawing.Point(538, 285);
            this.nudNotifyMin.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudNotifyMin.Name = "nudNotifyMin";
            this.nudNotifyMin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudNotifyMin.Size = new System.Drawing.Size(108, 40);
            this.nudNotifyMin.TabIndex = 25;
            this.nudNotifyMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNotifyMin.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudNotifyMin.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudRepeat
            // 
            this.nudRepeat.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nudRepeat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudRepeat.Cursor = System.Windows.Forms.Cursors.Default;
            this.nudRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRepeat.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nudRepeat.Location = new System.Drawing.Point(538, 401);
            this.nudRepeat.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudRepeat.Name = "nudRepeat";
            this.nudRepeat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudRepeat.Size = new System.Drawing.Size(108, 40);
            this.nudRepeat.TabIndex = 26;
            this.nudRepeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudRepeat.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudRepeat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dudTimeHr
            // 
            this.dudTimeHr.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dudTimeHr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dudTimeHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dudTimeHr.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.dudTimeHr.Items.Add("01");
            this.dudTimeHr.Items.Add("02");
            this.dudTimeHr.Items.Add("03");
            this.dudTimeHr.Items.Add("04");
            this.dudTimeHr.Items.Add("05");
            this.dudTimeHr.Items.Add("06");
            this.dudTimeHr.Items.Add("07");
            this.dudTimeHr.Items.Add("08");
            this.dudTimeHr.Items.Add("09");
            this.dudTimeHr.Items.Add("10");
            this.dudTimeHr.Items.Add("11");
            this.dudTimeHr.Items.Add("12");
            this.dudTimeHr.Location = new System.Drawing.Point(538, 168);
            this.dudTimeHr.Name = "dudTimeHr";
            this.dudTimeHr.ReadOnly = true;
            this.dudTimeHr.SelectedIndex = 0;
            this.dudTimeHr.Size = new System.Drawing.Size(69, 40);
            this.dudTimeHr.TabIndex = 27;
            this.dudTimeHr.Text = "01";
            this.dudTimeHr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dudTimeHr.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.dudTimeHr.SelectedItemChanged += new System.EventHandler(this.dudTimeHr_SelectedItemChanged);
            // 
            // dudTimeMin
            // 
            this.dudTimeMin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dudTimeMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dudTimeMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dudTimeMin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.dudTimeMin.Items.Add("00");
            this.dudTimeMin.Items.Add("01");
            this.dudTimeMin.Items.Add("02");
            this.dudTimeMin.Items.Add("03");
            this.dudTimeMin.Items.Add("04");
            this.dudTimeMin.Items.Add("05");
            this.dudTimeMin.Items.Add("06");
            this.dudTimeMin.Items.Add("07");
            this.dudTimeMin.Items.Add("08");
            this.dudTimeMin.Items.Add("09");
            this.dudTimeMin.Items.Add("10");
            this.dudTimeMin.Items.Add("11");
            this.dudTimeMin.Items.Add("12");
            this.dudTimeMin.Items.Add("13");
            this.dudTimeMin.Items.Add("14");
            this.dudTimeMin.Items.Add("15");
            this.dudTimeMin.Items.Add("16");
            this.dudTimeMin.Items.Add("17");
            this.dudTimeMin.Items.Add("18");
            this.dudTimeMin.Items.Add("19");
            this.dudTimeMin.Items.Add("20");
            this.dudTimeMin.Items.Add("21");
            this.dudTimeMin.Items.Add("22");
            this.dudTimeMin.Items.Add("23");
            this.dudTimeMin.Items.Add("24");
            this.dudTimeMin.Items.Add("25");
            this.dudTimeMin.Items.Add("26");
            this.dudTimeMin.Items.Add("27");
            this.dudTimeMin.Items.Add("28");
            this.dudTimeMin.Items.Add("29");
            this.dudTimeMin.Items.Add("30");
            this.dudTimeMin.Items.Add("31");
            this.dudTimeMin.Items.Add("32");
            this.dudTimeMin.Items.Add("33");
            this.dudTimeMin.Items.Add("34");
            this.dudTimeMin.Items.Add("35");
            this.dudTimeMin.Items.Add("36");
            this.dudTimeMin.Items.Add("37");
            this.dudTimeMin.Items.Add("38");
            this.dudTimeMin.Items.Add("39");
            this.dudTimeMin.Items.Add("40");
            this.dudTimeMin.Items.Add("41");
            this.dudTimeMin.Items.Add("42");
            this.dudTimeMin.Items.Add("43");
            this.dudTimeMin.Items.Add("44");
            this.dudTimeMin.Items.Add("45");
            this.dudTimeMin.Items.Add("46");
            this.dudTimeMin.Items.Add("47");
            this.dudTimeMin.Items.Add("48");
            this.dudTimeMin.Items.Add("49");
            this.dudTimeMin.Items.Add("50");
            this.dudTimeMin.Items.Add("51");
            this.dudTimeMin.Items.Add("52");
            this.dudTimeMin.Items.Add("53");
            this.dudTimeMin.Items.Add("54");
            this.dudTimeMin.Items.Add("55");
            this.dudTimeMin.Items.Add("56");
            this.dudTimeMin.Items.Add("57");
            this.dudTimeMin.Items.Add("58");
            this.dudTimeMin.Items.Add("59");
            this.dudTimeMin.Location = new System.Drawing.Point(618, 168);
            this.dudTimeMin.Name = "dudTimeMin";
            this.dudTimeMin.ReadOnly = true;
            this.dudTimeMin.SelectedIndex = 0;
            this.dudTimeMin.Size = new System.Drawing.Size(69, 40);
            this.dudTimeMin.TabIndex = 28;
            this.dudTimeMin.Text = "00";
            this.dudTimeMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpbAmPm
            // 
            this.grpbAmPm.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.grpbAmPm.BackgroundImage = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.grpbAmPm.Controls.Add(this.rdbtnAM);
            this.grpbAmPm.Controls.Add(this.rdbtnPM);
            this.grpbAmPm.Location = new System.Drawing.Point(725, 145);
            this.grpbAmPm.Name = "grpbAmPm";
            this.grpbAmPm.Size = new System.Drawing.Size(63, 85);
            this.grpbAmPm.TabIndex = 29;
            this.grpbAmPm.TabStop = false;
            // 
            // chbAlwaysRepeat
            // 
            this.chbAlwaysRepeat.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbAlwaysRepeat.AutoSize = true;
            this.chbAlwaysRepeat.BackgroundImage = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.chbAlwaysRepeat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chbAlwaysRepeat.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.chbAlwaysRepeat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chbAlwaysRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAlwaysRepeat.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chbAlwaysRepeat.Location = new System.Drawing.Point(538, 453);
            this.chbAlwaysRepeat.Name = "chbAlwaysRepeat";
            this.chbAlwaysRepeat.Size = new System.Drawing.Size(90, 35);
            this.chbAlwaysRepeat.TabIndex = 30;
            this.chbAlwaysRepeat.Text = "Always";
            this.chbAlwaysRepeat.UseVisualStyleBackColor = true;
            this.chbAlwaysRepeat.CheckedChanged += new System.EventHandler(this.chbAlwaysRepeat_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Image = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.btnDelete.Location = new System.Drawing.Point(995, 585);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 37);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1249, 631);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.chbAlwaysRepeat);
            this.Controls.Add(this.grpbAmPm);
            this.Controls.Add(this.dudTimeMin);
            this.Controls.Add(this.dudTimeHr);
            this.Controls.Add(this.nudRepeat);
            this.Controls.Add(this.nudNotifyMin);
            this.Controls.Add(this.lblCustomize);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.lblFind);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.rtxtTimerInfo);
            this.Controls.Add(this.lsbTimers);
            this.Controls.Add(this.lsbGameItems);
            this.Controls.Add(this.lsbGames);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lbRepeatSub);
            this.Controls.Add(this.lbNotifySub);
            this.Controls.Add(this.lblRepeat);
            this.Controls.Add(this.lbNotify);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblColon);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frMain";
            this.Text = "Game Notifier";
            ((System.ComponentModel.ISupportInitialize)(this.nudNotifyMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepeat)).EndInit();
            this.grpbAmPm.ResumeLayout(false);
            this.grpbAmPm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbNotify;
        private System.Windows.Forms.Label lbNotifySub;
        private System.Windows.Forms.Label lbRepeatSub;
        private System.Windows.Forms.RadioButton rdbtnAM;
        private System.Windows.Forms.RadioButton rdbtnPM;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lsbGames;
        private System.Windows.Forms.ListBox lsbGameItems;
        private System.Windows.Forms.ListBox lsbTimers;
        private System.Windows.Forms.RichTextBox rtxtTimerInfo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblCustomize;
        private System.Windows.Forms.Label lblColon;
        private System.Windows.Forms.NumericUpDown nudNotifyMin;
        private System.Windows.Forms.NumericUpDown nudRepeat;
        private System.Windows.Forms.DomainUpDown dudTimeHr;
        private System.Windows.Forms.DomainUpDown dudTimeMin;
        public System.Windows.Forms.Label lblRepeat;
        private System.Windows.Forms.GroupBox grpbAmPm;
        private System.Windows.Forms.CheckBox chbAlwaysRepeat;
        private System.Windows.Forms.Button btnDelete;
    }
}

