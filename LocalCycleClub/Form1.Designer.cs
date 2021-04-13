
namespace LocalCycleClub
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Caught Cheating",
            "Got caught cheating"}, 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.heroOfTheMonthLbl = new System.Windows.Forms.Label();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.btnForgotPassword = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.passwordLoginLbl = new System.Windows.Forms.Label();
            this.userNameLoginLbl = new System.Windows.Forms.Label();
            this.txtBoxAnnouncements = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabActivities = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAddActivities = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.AActivity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ALocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ADate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabLeaderboard = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnAddCycle = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cyclesTaken = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DistanceCycled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.lblClubRanking = new System.Windows.Forms.Label();
            this.lblKMCycled = new System.Windows.Forms.Label();
            this.clubRankinglbl = new System.Windows.Forms.Label();
            this.kmCycledlbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpBoxAchievementsUnlckd = new System.Windows.Forms.GroupBox();
            this.achievementsListView = new System.Windows.Forms.ListView();
            this.achievementsIcons = new System.Windows.Forms.ImageList(this.components);
            this.lblUsername = new System.Windows.Forms.Label();
            this.tabSignup = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.txtBoxSUPassword = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxLastname = new System.Windows.Forms.TextBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxSUUsername = new System.Windows.Forms.TextBox();
            this.txtBoxAddress = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cyclingXPBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxLogin.SuspendLayout();
            this.tabActivities.SuspendLayout();
            this.tabLeaderboard.SuspendLayout();
            this.tabProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpBoxAchievementsUnlckd.SuspendLayout();
            this.tabSignup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Controls.Add(this.tabActivities);
            this.tabControl1.Controls.Add(this.tabLeaderboard);
            this.tabControl1.Controls.Add(this.tabProfile);
            this.tabControl1.Controls.Add(this.tabSignup);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 528);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.pictureBox1);
            this.tabHome.Controls.Add(this.heroOfTheMonthLbl);
            this.tabHome.Controls.Add(this.groupBoxLogin);
            this.tabHome.Controls.Add(this.txtBoxAnnouncements);
            this.tabHome.Controls.Add(this.label1);
            this.tabHome.Location = new System.Drawing.Point(4, 25);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(768, 499);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LocalCycleClub.Properties.Resources.lanceondrugs__1_;
            this.pictureBox1.Location = new System.Drawing.Point(378, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 274);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // heroOfTheMonthLbl
            // 
            this.heroOfTheMonthLbl.AutoSize = true;
            this.heroOfTheMonthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroOfTheMonthLbl.Location = new System.Drawing.Point(603, 293);
            this.heroOfTheMonthLbl.Name = "heroOfTheMonthLbl";
            this.heroOfTheMonthLbl.Size = new System.Drawing.Size(169, 72);
            this.heroOfTheMonthLbl.TabIndex = 4;
            this.heroOfTheMonthLbl.Text = "Hero of the \r\n    Month";
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.btnForgotPassword);
            this.groupBoxLogin.Controls.Add(this.btnLogin);
            this.groupBoxLogin.Controls.Add(this.txtBoxPassword);
            this.groupBoxLogin.Controls.Add(this.txtBoxUsername);
            this.groupBoxLogin.Controls.Add(this.passwordLoginLbl);
            this.groupBoxLogin.Controls.Add(this.userNameLoginLbl);
            this.groupBoxLogin.Location = new System.Drawing.Point(378, 43);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(350, 170);
            this.groupBoxLogin.TabIndex = 3;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Login";
            // 
            // btnForgotPassword
            // 
            this.btnForgotPassword.Location = new System.Drawing.Point(174, 118);
            this.btnForgotPassword.Name = "btnForgotPassword";
            this.btnForgotPassword.Size = new System.Drawing.Size(141, 29);
            this.btnForgotPassword.TabIndex = 5;
            this.btnForgotPassword.Text = "Forgot Password";
            this.btnForgotPassword.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(93, 118);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 29);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(128, 81);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(187, 22);
            this.txtBoxPassword.TabIndex = 3;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Location = new System.Drawing.Point(128, 42);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(187, 22);
            this.txtBoxUsername.TabIndex = 2;
            // 
            // passwordLoginLbl
            // 
            this.passwordLoginLbl.AutoSize = true;
            this.passwordLoginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLoginLbl.Location = new System.Drawing.Point(20, 78);
            this.passwordLoginLbl.Name = "passwordLoginLbl";
            this.passwordLoginLbl.Size = new System.Drawing.Size(98, 25);
            this.passwordLoginLbl.TabIndex = 1;
            this.passwordLoginLbl.Text = "Password";
            // 
            // userNameLoginLbl
            // 
            this.userNameLoginLbl.AccessibleDescription = "";
            this.userNameLoginLbl.AutoSize = true;
            this.userNameLoginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLoginLbl.Location = new System.Drawing.Point(20, 38);
            this.userNameLoginLbl.Name = "userNameLoginLbl";
            this.userNameLoginLbl.Size = new System.Drawing.Size(102, 25);
            this.userNameLoginLbl.TabIndex = 0;
            this.userNameLoginLbl.Text = "Username";
            // 
            // txtBoxAnnouncements
            // 
            this.txtBoxAnnouncements.Location = new System.Drawing.Point(6, 56);
            this.txtBoxAnnouncements.Name = "txtBoxAnnouncements";
            this.txtBoxAnnouncements.Size = new System.Drawing.Size(330, 437);
            this.txtBoxAnnouncements.TabIndex = 2;
            this.txtBoxAnnouncements.Text = "DANIEL HAS A MASSIVE COCK  AND THATS FAXXX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Announcements";
            // 
            // tabActivities
            // 
            this.tabActivities.Controls.Add(this.label15);
            this.tabActivities.Controls.Add(this.btnAddActivities);
            this.tabActivities.Controls.Add(this.listView2);
            this.tabActivities.Location = new System.Drawing.Point(4, 25);
            this.tabActivities.Name = "tabActivities";
            this.tabActivities.Padding = new System.Windows.Forms.Padding(3);
            this.tabActivities.Size = new System.Drawing.Size(768, 499);
            this.tabActivities.TabIndex = 1;
            this.tabActivities.Text = "Activities";
            this.tabActivities.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 25);
            this.label15.TabIndex = 3;
            this.label15.Text = "Activities";
            // 
            // btnAddActivities
            // 
            this.btnAddActivities.Location = new System.Drawing.Point(647, 176);
            this.btnAddActivities.Name = "btnAddActivities";
            this.btnAddActivities.Size = new System.Drawing.Size(106, 37);
            this.btnAddActivities.TabIndex = 1;
            this.btnAddActivities.Text = "Add Activity";
            this.btnAddActivities.UseVisualStyleBackColor = true;
            this.btnAddActivities.Click += new System.EventHandler(this.btnAddActivities_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AActivity,
            this.AName,
            this.ALocation,
            this.ADate});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(25, 93);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(606, 181);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // AActivity
            // 
            this.AActivity.Text = "Activity";
            this.AActivity.Width = 120;
            // 
            // AName
            // 
            this.AName.Text = "Name";
            this.AName.Width = 120;
            // 
            // ALocation
            // 
            this.ALocation.Text = "Location";
            this.ALocation.Width = 120;
            // 
            // ADate
            // 
            this.ADate.Text = "Date";
            this.ADate.Width = 120;
            // 
            // tabLeaderboard
            // 
            this.tabLeaderboard.Controls.Add(this.comboBox2);
            this.tabLeaderboard.Controls.Add(this.btnAddCycle);
            this.tabLeaderboard.Controls.Add(this.listView1);
            this.tabLeaderboard.Controls.Add(this.label5);
            this.tabLeaderboard.Location = new System.Drawing.Point(4, 25);
            this.tabLeaderboard.Name = "tabLeaderboard";
            this.tabLeaderboard.Size = new System.Drawing.Size(768, 499);
            this.tabLeaderboard.TabIndex = 2;
            this.tabLeaderboard.Text = "Leaderboard";
            this.tabLeaderboard.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Day",
            "Month",
            "Year"});
            this.comboBox2.Location = new System.Drawing.Point(54, 133);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(137, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // btnAddCycle
            // 
            this.btnAddCycle.Location = new System.Drawing.Point(74, 274);
            this.btnAddCycle.Name = "btnAddCycle";
            this.btnAddCycle.Size = new System.Drawing.Size(97, 49);
            this.btnAddCycle.TabIndex = 2;
            this.btnAddCycle.Text = "Add Cycle";
            this.btnAddCycle.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.cyclesTaken,
            this.DistanceCycled});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(233, 74);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(439, 390);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 145;
            // 
            // cyclesTaken
            // 
            this.cyclesTaken.Text = "Cycles Taken";
            this.cyclesTaken.Width = 145;
            // 
            // DistanceCycled
            // 
            this.DistanceCycled.Text = "Distance Cycled";
            this.DistanceCycled.Width = 145;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Leaderboard";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.lblClubRanking);
            this.tabProfile.Controls.Add(this.lblKMCycled);
            this.tabProfile.Controls.Add(this.clubRankinglbl);
            this.tabProfile.Controls.Add(this.kmCycledlbl);
            this.tabProfile.Controls.Add(this.pictureBox2);
            this.tabProfile.Controls.Add(this.grpBoxAchievementsUnlckd);
            this.tabProfile.Controls.Add(this.lblUsername);
            this.tabProfile.Location = new System.Drawing.Point(4, 25);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Size = new System.Drawing.Size(768, 499);
            this.tabProfile.TabIndex = 3;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // lblClubRanking
            // 
            this.lblClubRanking.AutoSize = true;
            this.lblClubRanking.Location = new System.Drawing.Point(177, 401);
            this.lblClubRanking.Name = "lblClubRanking";
            this.lblClubRanking.Size = new System.Drawing.Size(16, 17);
            this.lblClubRanking.TabIndex = 6;
            this.lblClubRanking.Text = "0";
            // 
            // lblKMCycled
            // 
            this.lblKMCycled.AutoSize = true;
            this.lblKMCycled.Location = new System.Drawing.Point(177, 353);
            this.lblKMCycled.Name = "lblKMCycled";
            this.lblKMCycled.Size = new System.Drawing.Size(40, 17);
            this.lblKMCycled.TabIndex = 5;
            this.lblKMCycled.Text = "0 Km";
            // 
            // clubRankinglbl
            // 
            this.clubRankinglbl.AutoSize = true;
            this.clubRankinglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clubRankinglbl.Location = new System.Drawing.Point(54, 399);
            this.clubRankinglbl.Name = "clubRankinglbl";
            this.clubRankinglbl.Size = new System.Drawing.Size(113, 18);
            this.clubRankinglbl.TabIndex = 4;
            this.clubRankinglbl.Text = "Club Ranking:";
            // 
            // kmCycledlbl
            // 
            this.kmCycledlbl.AutoSize = true;
            this.kmCycledlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kmCycledlbl.Location = new System.Drawing.Point(58, 353);
            this.kmCycledlbl.Name = "kmCycledlbl";
            this.kmCycledlbl.Size = new System.Drawing.Size(112, 18);
            this.kmCycledlbl.TabIndex = 3;
            this.kmCycledlbl.Text = "Km\'s Cycled: ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LocalCycleClub.Properties.Resources.profilepic;
            this.pictureBox2.Location = new System.Drawing.Point(57, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(257, 258);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // grpBoxAchievementsUnlckd
            // 
            this.grpBoxAchievementsUnlckd.Controls.Add(this.achievementsListView);
            this.grpBoxAchievementsUnlckd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxAchievementsUnlckd.Location = new System.Drawing.Point(383, 31);
            this.grpBoxAchievementsUnlckd.Name = "grpBoxAchievementsUnlckd";
            this.grpBoxAchievementsUnlckd.Size = new System.Drawing.Size(355, 433);
            this.grpBoxAchievementsUnlckd.TabIndex = 1;
            this.grpBoxAchievementsUnlckd.TabStop = false;
            this.grpBoxAchievementsUnlckd.Text = "Achievements Unlocked";
            // 
            // achievementsListView
            // 
            this.achievementsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.achievementsListView.HideSelection = false;
            listViewItem1.Tag = "Oops";
            this.achievementsListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.achievementsListView.LargeImageList = this.achievementsIcons;
            this.achievementsListView.Location = new System.Drawing.Point(3, 20);
            this.achievementsListView.Name = "achievementsListView";
            this.achievementsListView.Size = new System.Drawing.Size(349, 410);
            this.achievementsListView.SmallImageList = this.achievementsIcons;
            this.achievementsListView.TabIndex = 0;
            this.achievementsListView.UseCompatibleStateImageBehavior = false;
            this.achievementsListView.View = System.Windows.Forms.View.Details;
            // 
            // achievementsIcons
            // 
            this.achievementsIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("achievementsIcons.ImageStream")));
            this.achievementsIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.achievementsIcons.Images.SetKeyName(0, "oops.jpg");
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(93, 22);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(168, 38);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // tabSignup
            // 
            this.tabSignup.Controls.Add(this.label14);
            this.tabSignup.Controls.Add(this.btnSubmit);
            this.tabSignup.Controls.Add(this.btnClear);
            this.tabSignup.Controls.Add(this.dobPicker);
            this.tabSignup.Controls.Add(this.txtBoxSUPassword);
            this.tabSignup.Controls.Add(this.txtBoxEmail);
            this.tabSignup.Controls.Add(this.txtBoxLastname);
            this.tabSignup.Controls.Add(this.txtBoxFirstName);
            this.tabSignup.Controls.Add(this.txtBoxSUUsername);
            this.tabSignup.Controls.Add(this.txtBoxAddress);
            this.tabSignup.Controls.Add(this.label13);
            this.tabSignup.Controls.Add(this.cyclingXPBox);
            this.tabSignup.Controls.Add(this.label12);
            this.tabSignup.Controls.Add(this.label11);
            this.tabSignup.Controls.Add(this.label10);
            this.tabSignup.Controls.Add(this.label9);
            this.tabSignup.Controls.Add(this.label8);
            this.tabSignup.Controls.Add(this.label7);
            this.tabSignup.Controls.Add(this.label6);
            this.tabSignup.Location = new System.Drawing.Point(4, 25);
            this.tabSignup.Name = "tabSignup";
            this.tabSignup.Size = new System.Drawing.Size(768, 499);
            this.tabSignup.TabIndex = 4;
            this.tabSignup.Text = "Sign Up";
            this.tabSignup.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(209, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 25);
            this.label14.TabIndex = 20;
            this.label14.Text = "Address";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(500, 442);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(333, 442);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // dobPicker
            // 
            this.dobPicker.Location = new System.Drawing.Point(333, 317);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(242, 22);
            this.dobPicker.TabIndex = 16;
            this.dobPicker.Value = new System.DateTime(2021, 4, 7, 9, 41, 59, 0);
            // 
            // txtBoxSUPassword
            // 
            this.txtBoxSUPassword.Location = new System.Drawing.Point(333, 393);
            this.txtBoxSUPassword.Name = "txtBoxSUPassword";
            this.txtBoxSUPassword.Size = new System.Drawing.Size(242, 22);
            this.txtBoxSUPassword.TabIndex = 15;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(333, 355);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(242, 22);
            this.txtBoxEmail.TabIndex = 14;
            // 
            // txtBoxLastname
            // 
            this.txtBoxLastname.Location = new System.Drawing.Point(333, 103);
            this.txtBoxLastname.Name = "txtBoxLastname";
            this.txtBoxLastname.Size = new System.Drawing.Size(242, 22);
            this.txtBoxLastname.TabIndex = 12;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(333, 64);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(242, 22);
            this.txtBoxFirstName.TabIndex = 11;
            // 
            // txtBoxSUUsername
            // 
            this.txtBoxSUUsername.Location = new System.Drawing.Point(333, 29);
            this.txtBoxSUUsername.Name = "txtBoxSUUsername";
            this.txtBoxSUUsername.Size = new System.Drawing.Size(242, 22);
            this.txtBoxSUUsername.TabIndex = 10;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(333, 145);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(242, 97);
            this.txtBoxAddress.TabIndex = 9;
            this.txtBoxAddress.Text = "";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 24);
            this.label13.TabIndex = 19;
            // 
            // cyclingXPBox
            // 
            this.cyclingXPBox.FormattingEnabled = true;
            this.cyclingXPBox.Location = new System.Drawing.Point(333, 272);
            this.cyclingXPBox.Name = "cyclingXPBox";
            this.cyclingXPBox.Size = new System.Drawing.Size(242, 24);
            this.cyclingXPBox.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(120, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 24);
            this.label12.TabIndex = 6;
            this.label12.Text = "Cycling Experience";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(245, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 24);
            this.label11.TabIndex = 5;
            this.label11.Text = "DOB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(205, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 24);
            this.label10.TabIndex = 4;
            this.label10.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(238, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(198, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Last name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(198, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "First name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(198, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Username";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 554);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.tabActivities.ResumeLayout(false);
            this.tabActivities.PerformLayout();
            this.tabLeaderboard.ResumeLayout(false);
            this.tabLeaderboard.PerformLayout();
            this.tabProfile.ResumeLayout(false);
            this.tabProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpBoxAchievementsUnlckd.ResumeLayout(false);
            this.tabSignup.ResumeLayout(false);
            this.tabSignup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabActivities;
        private System.Windows.Forms.TabPage tabLeaderboard;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.TabPage tabSignup;
        private System.Windows.Forms.RichTextBox txtBoxAnnouncements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Button btnForgotPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Label passwordLoginLbl;
        private System.Windows.Forms.Label userNameLoginLbl;
        private System.Windows.Forms.Label heroOfTheMonthLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddCycle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader cyclesTaken;
        private System.Windows.Forms.ColumnHeader DistanceCycled;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.TextBox txtBoxSUPassword;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxLastname;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxSUUsername;
        private System.Windows.Forms.RichTextBox txtBoxAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cyclingXPBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAddActivities;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader AActivity;
        private System.Windows.Forms.ColumnHeader AName;
        private System.Windows.Forms.ColumnHeader ALocation;
        private System.Windows.Forms.ColumnHeader ADate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox grpBoxAchievementsUnlckd;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblClubRanking;
        private System.Windows.Forms.Label lblKMCycled;
        private System.Windows.Forms.Label clubRankinglbl;
        private System.Windows.Forms.Label kmCycledlbl;
        private System.Windows.Forms.ListView achievementsListView;
        private System.Windows.Forms.ImageList achievementsIcons;
    }
}

