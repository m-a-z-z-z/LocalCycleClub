
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.btnForgotPassword = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxAnnouncements = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabActivities = new System.Windows.Forms.TabPage();
            this.tabLeaderboard = new System.Windows.Forms.TabPage();
            this.btnAddCycle = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cyclesTaken = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DistanceCycled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.tabSignup = new System.Windows.Forms.TabPage();
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
            this.tabLeaderboard.SuspendLayout();
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
            this.tabHome.Controls.Add(this.label4);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(603, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 72);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hero of the \r\n    Month";
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.btnForgotPassword);
            this.groupBoxLogin.Controls.Add(this.btnLogin);
            this.groupBoxLogin.Controls.Add(this.txtBoxPassword);
            this.groupBoxLogin.Controls.Add(this.txtBoxUsername);
            this.groupBoxLogin.Controls.Add(this.label3);
            this.groupBoxLogin.Controls.Add(this.label2);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
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
            this.tabActivities.Location = new System.Drawing.Point(4, 25);
            this.tabActivities.Name = "tabActivities";
            this.tabActivities.Padding = new System.Windows.Forms.Padding(3);
            this.tabActivities.Size = new System.Drawing.Size(768, 499);
            this.tabActivities.TabIndex = 1;
            this.tabActivities.Text = "Activities";
            this.tabActivities.UseVisualStyleBackColor = true;
            // 
            // tabLeaderboard
            // 
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
            this.tabProfile.Location = new System.Drawing.Point(4, 25);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Size = new System.Drawing.Size(768, 499);
            this.tabProfile.TabIndex = 3;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // tabSignup
            // 
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
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(212, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 24);
            this.label13.TabIndex = 8;
            this.label13.Text = "Address";
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
            this.ClientSize = new System.Drawing.Size(800, 554);
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
            this.tabLeaderboard.ResumeLayout(false);
            this.tabLeaderboard.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
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
    }
}

