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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rdbtnAlwaysRepeat = new System.Windows.Forms.RadioButton();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbNotify = new System.Windows.Forms.Label();
            this.lbRepeat = new System.Windows.Forms.Label();
            this.lbNotifySub = new System.Windows.Forms.Label();
            this.lbRepeatSub = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtNotify = new System.Windows.Forms.TextBox();
            this.txtRepeat = new System.Windows.Forms.TextBox();
            this.rdbtnAM = new System.Windows.Forms.RadioButton();
            this.rdbtnPM = new System.Windows.Forms.RadioButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lsbGames = new System.Windows.Forms.ListBox();
            this.lsbGameItems = new System.Windows.Forms.ListBox();
            this.lsbTimers = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblFind = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblCustomize = new System.Windows.Forms.Label();
            this.numUDTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Joystix", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Image = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.btnAdd.Location = new System.Drawing.Point(517, 526);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 37);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // rdbtnAlwaysRepeat
            // 
            this.rdbtnAlwaysRepeat.AutoSize = true;
            this.rdbtnAlwaysRepeat.Font = new System.Drawing.Font("Joystix", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnAlwaysRepeat.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rdbtnAlwaysRepeat.Location = new System.Drawing.Point(547, 455);
            this.rdbtnAlwaysRepeat.Name = "rdbtnAlwaysRepeat";
            this.rdbtnAlwaysRepeat.Size = new System.Drawing.Size(116, 24);
            this.rdbtnAlwaysRepeat.TabIndex = 1;
            this.rdbtnAlwaysRepeat.TabStop = true;
            this.rdbtnAlwaysRepeat.Text = "Always";
            this.rdbtnAlwaysRepeat.UseVisualStyleBackColor = true;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Joystix", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbTime.Image = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.lbTime.Location = new System.Drawing.Point(367, 161);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(147, 45);
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "Time";
            this.lbTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbNotify
            // 
            this.lbNotify.AutoSize = true;
            this.lbNotify.Font = new System.Drawing.Font("Joystix", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotify.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbNotify.Image = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.lbNotify.Location = new System.Drawing.Point(369, 280);
            this.lbNotify.Name = "lbNotify";
            this.lbNotify.Size = new System.Drawing.Size(163, 34);
            this.lbNotify.TabIndex = 3;
            this.lbNotify.Text = "Notify";
            // 
            // lbRepeat
            // 
            this.lbRepeat.AutoSize = true;
            this.lbRepeat.Font = new System.Drawing.Font("Joystix", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRepeat.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbRepeat.Image = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.lbRepeat.Location = new System.Drawing.Point(369, 401);
            this.lbRepeat.Name = "lbRepeat";
            this.lbRepeat.Size = new System.Drawing.Size(171, 34);
            this.lbRepeat.TabIndex = 4;
            this.lbRepeat.Text = "Repeat";
            // 
            // lbNotifySub
            // 
            this.lbNotifySub.AutoSize = true;
            this.lbNotifySub.Font = new System.Drawing.Font("Joystix", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotifySub.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbNotifySub.Image = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.lbNotifySub.Location = new System.Drawing.Point(649, 297);
            this.lbNotifySub.Name = "lbNotifySub";
            this.lbNotifySub.Size = new System.Drawing.Size(154, 20);
            this.lbNotifySub.TabIndex = 5;
            this.lbNotifySub.Text = "min Before";
            // 
            // lbRepeatSub
            // 
            this.lbRepeatSub.AutoSize = true;
            this.lbRepeatSub.Font = new System.Drawing.Font("Joystix", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRepeatSub.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbRepeatSub.Image = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.lbRepeatSub.Location = new System.Drawing.Point(649, 418);
            this.lbRepeatSub.Name = "lbRepeatSub";
            this.lbRepeatSub.Size = new System.Drawing.Size(79, 20);
            this.lbRepeatSub.TabIndex = 6;
            this.lbRepeatSub.Text = "Times";
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime.Font = new System.Drawing.Font("Joystix", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtTime.Location = new System.Drawing.Point(547, 173);
            this.txtTime.Margin = new System.Windows.Forms.Padding(0);
            this.txtTime.MaxLength = 5;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(120, 33);
            this.txtTime.TabIndex = 7;
            this.txtTime.Text = "00:00";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // txtNotify
            // 
            this.txtNotify.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtNotify.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNotify.Font = new System.Drawing.Font("Joystix", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotify.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtNotify.Location = new System.Drawing.Point(581, 284);
            this.txtNotify.Margin = new System.Windows.Forms.Padding(0);
            this.txtNotify.MaxLength = 2;
            this.txtNotify.Name = "txtNotify";
            this.txtNotify.Size = new System.Drawing.Size(56, 33);
            this.txtNotify.TabIndex = 8;
            this.txtNotify.Text = "00";
            this.txtNotify.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRepeat
            // 
            this.txtRepeat.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtRepeat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRepeat.Font = new System.Drawing.Font("Joystix", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepeat.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtRepeat.Location = new System.Drawing.Point(581, 405);
            this.txtRepeat.Margin = new System.Windows.Forms.Padding(0);
            this.txtRepeat.MaxLength = 2;
            this.txtRepeat.Name = "txtRepeat";
            this.txtRepeat.Size = new System.Drawing.Size(56, 33);
            this.txtRepeat.TabIndex = 9;
            this.txtRepeat.Text = "0";
            this.txtRepeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRepeat.TextChanged += new System.EventHandler(this.txtRepeat_TextChanged);
            // 
            // rdbtnAM
            // 
            this.rdbtnAM.AutoSize = true;
            this.rdbtnAM.Font = new System.Drawing.Font("Joystix", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnAM.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rdbtnAM.Location = new System.Drawing.Point(744, 161);
            this.rdbtnAM.Name = "rdbtnAM";
            this.rdbtnAM.Size = new System.Drawing.Size(59, 24);
            this.rdbtnAM.TabIndex = 11;
            this.rdbtnAM.TabStop = true;
            this.rdbtnAM.Text = "AM";
            this.rdbtnAM.UseVisualStyleBackColor = true;
            // 
            // rdbtnPM
            // 
            this.rdbtnPM.AutoSize = true;
            this.rdbtnPM.Font = new System.Drawing.Font("Joystix", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnPM.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rdbtnPM.Location = new System.Drawing.Point(744, 191);
            this.rdbtnPM.Name = "rdbtnPM";
            this.rdbtnPM.Size = new System.Drawing.Size(57, 24);
            this.rdbtnPM.TabIndex = 12;
            this.rdbtnPM.TabStop = true;
            this.rdbtnPM.Text = "PM";
            this.rdbtnPM.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Joystix", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtSearch.Location = new System.Drawing.Point(22, 80);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.MaxLength = 216;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(271, 25);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.Text = "search";
            // 
            // lsbGames
            // 
            this.lsbGames.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lsbGames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbGames.Font = new System.Drawing.Font("Joystix", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbGames.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lsbGames.FormattingEnabled = true;
            this.lsbGames.HorizontalScrollbar = true;
            this.lsbGames.ItemHeight = 15;
            this.lsbGames.Items.AddRange(new object[] {
            "World of Warcaft",
            "Destiny"});
            this.lsbGames.Location = new System.Drawing.Point(22, 127);
            this.lsbGames.Name = "lsbGames";
            this.lsbGames.Size = new System.Drawing.Size(271, 120);
            this.lsbGames.TabIndex = 14;
            // 
            // lsbGameItems
            // 
            this.lsbGameItems.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lsbGameItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbGameItems.Font = new System.Drawing.Font("Joystix", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbGameItems.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lsbGameItems.FormattingEnabled = true;
            this.lsbGameItems.HorizontalScrollbar = true;
            this.lsbGameItems.ItemHeight = 15;
            this.lsbGameItems.Items.AddRange(new object[] {
            "These",
            "Will",
            "Be",
            "Bosses",
            "Ect"});
            this.lsbGameItems.Location = new System.Drawing.Point(22, 253);
            this.lsbGameItems.Name = "lsbGameItems";
            this.lsbGameItems.Size = new System.Drawing.Size(271, 255);
            this.lsbGameItems.TabIndex = 15;
            // 
            // lsbTimers
            // 
            this.lsbTimers.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lsbTimers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbTimers.Font = new System.Drawing.Font("Joystix", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbTimers.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lsbTimers.FormattingEnabled = true;
            this.lsbTimers.HorizontalScrollbar = true;
            this.lsbTimers.ItemHeight = 15;
            this.lsbTimers.Items.AddRange(new object[] {
            "These",
            "Will",
            "Be",
            "Timers"});
            this.lsbTimers.Location = new System.Drawing.Point(917, 80);
            this.lsbTimers.Name = "lsbTimers";
            this.lsbTimers.Size = new System.Drawing.Size(320, 330);
            this.lsbTimers.TabIndex = 16;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Joystix", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox1.Location = new System.Drawing.Point(917, 416);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(320, 203);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "Here will be timer details";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Joystix", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtName.Location = new System.Drawing.Point(454, 107);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.MaxLength = 216;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(286, 25);
            this.txtName.TabIndex = 18;
            this.txtName.Text = "Timer Name";
            // 
            // btnSelect
            // 
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Joystix", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSelect.Image = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.btnSelect.Location = new System.Drawing.Point(69, 526);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(170, 37);
            this.btnSelect.TabIndex = 19;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Font = new System.Drawing.Font("Joystix", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFind.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFind.Image = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.lblFind.Location = new System.Drawing.Point(62, 23);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(177, 44);
            this.lblFind.TabIndex = 20;
            this.lblFind.Text = "Search For\r\nNotifiers";
            this.lblFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFind.Click += new System.EventHandler(this.lblFind_Click);
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Joystix", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActive.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblActive.Image = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.lblActive.Location = new System.Drawing.Point(935, 33);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(289, 34);
            this.lblActive.TabIndex = 21;
            this.lblActive.Text = "Your Timers";
            // 
            // lblCustomize
            // 
            this.lblCustomize.AutoSize = true;
            this.lblCustomize.Font = new System.Drawing.Font("Joystix", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCustomize.Image = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.lblCustomize.Location = new System.Drawing.Point(465, 33);
            this.lblCustomize.Name = "lblCustomize";
            this.lblCustomize.Size = new System.Drawing.Size(248, 34);
            this.lblCustomize.TabIndex = 22;
            this.lblCustomize.Text = "Customize";
            // 
            // numUDTime
            // 
            this.numUDTime.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numUDTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numUDTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.numUDTime.Font = new System.Drawing.Font("Joystix", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDTime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.numUDTime.Location = new System.Drawing.Point(517, 223);
            this.numUDTime.Name = "numUDTime";
            this.numUDTime.Size = new System.Drawing.Size(73, 36);
            this.numUDTime.TabIndex = 10;
            this.numUDTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUDTime.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::GameNotifier.Properties.Resources.btnBackgroundV1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1249, 631);
            this.Controls.Add(this.lblCustomize);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.lblFind);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lsbTimers);
            this.Controls.Add(this.lsbGameItems);
            this.Controls.Add(this.lsbGames);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.rdbtnPM);
            this.Controls.Add(this.rdbtnAM);
            this.Controls.Add(this.numUDTime);
            this.Controls.Add(this.txtRepeat);
            this.Controls.Add(this.txtNotify);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lbRepeatSub);
            this.Controls.Add(this.lbNotifySub);
            this.Controls.Add(this.lbRepeat);
            this.Controls.Add(this.lbNotify);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.rdbtnAlwaysRepeat);
            this.Controls.Add(this.btnAdd);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frMain";
            this.Text = "Game Notifier";
            ((System.ComponentModel.ISupportInitialize)(this.numUDTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rdbtnAlwaysRepeat;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbNotify;
        private System.Windows.Forms.Label lbRepeat;
        private System.Windows.Forms.Label lbNotifySub;
        private System.Windows.Forms.Label lbRepeatSub;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtNotify;
        private System.Windows.Forms.TextBox txtRepeat;
        private System.Windows.Forms.RadioButton rdbtnAM;
        private System.Windows.Forms.RadioButton rdbtnPM;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lsbGames;
        private System.Windows.Forms.ListBox lsbGameItems;
        private System.Windows.Forms.ListBox lsbTimers;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblCustomize;
        private System.Windows.Forms.NumericUpDown numUDTime;
    }
}

