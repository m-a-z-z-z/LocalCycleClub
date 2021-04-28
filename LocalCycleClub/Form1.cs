using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace LocalCycleClub
{
    public partial class Form1 : Form
    {
        public List<Achievements> achievements = new List<Achievements>();
        public List<Member> ListOfMembers = new List<Member>();
       // string memberFile = "membersFile.dat";

        public void SetUpData()
        {
            //ReadDataFromFile(ref ListOfMembers, memberFile);
           
            Member m1 = new Member("MazIsDaBest", "Dylan", "Maziarek", "maz@theGOAT.com", "ilikecycling123", new DateTime(31, 08, 1997), "Thurles, Tipperary", "Lance on Steroids Good");
            ListOfMembers.Add(m1);
            Member m2 = new Member("DanIsTrash", "Daniel", "Ruane", "dan@nottheGOAT.com", "password123", new DateTime(20, 04, 2000), "The Shticks, Mayo", "Post Drug Bust Lance");
            ListOfMembers.Add(m2);
            Member m3 = new Member("ZebedeeInDaTree", "Ben", "Houghton", "ben@jewmail.com", "BenAndKiana4Life69", new DateTime(31, 08, 1998), "Killaloe, Tipperary", "Lance on Steroids Good");
            ListOfMembers.Add(m3);
        }
        /*
        public static void ReadDataFromFile(ref List<Member> m, string memberFile)
        {
            List<Member> temp = new List<Member>();
            FileInfo memberInfo = new FileInfo(memberFile);
            FileStream memFSFile;

            if (memberInfo.Exists)
            {
                memFSFile = new FileStream(memberFile, FileMode.Open, FileAccess.Read);
                MessageBox.Show("Found file for read " + memberInfo.FullName);
                BinaryFormatter bformatter = new BinaryFormatter();
                try
                {
                    temp = bformatter.Deserialize(memFSFile) as List<Member>;
                    m = temp;

                }
                catch (Exception e)
                {
                    MessageBox.Show("{0} Exception caught." + e);
                }
                memFSFile.Close();
            }
            if (!memberInfo.Exists)
            {
                MessageBox.Show("ERROR CANT FIND FILE " + memberInfo.FullName);
            }
        }
        public static void writeDataToFile(List<Member> m, string memberFile)
        {
            List<Member> temp = new List<Member>();
            FileInfo memberInfo = new FileInfo(memberFile);
            FileStream memberFileStream;

            if (memberInfo.Exists)
            {
                memberFileStream = new FileStream(memberFile, FileMode.Truncate, FileAccess.Write);
                MessageBox.Show("found file " + memberInfo.FullName);
            }
            else
            {
                memberFileStream = new FileStream(memberFile, FileMode.Create, FileAccess.Write);
                MessageBox.Show("created file " + memberInfo.FullName);
            }
            BinaryFormatter bformatter = new BinaryFormatter();

            try
            {
                bformatter.Serialize(memberFileStream, m);
            }
            catch (Exception e)
            {
                MessageBox.Show("{0} Exception caught." + e);
            }

            memberFileStream.Close();
            MessageBox.Show("Data written to file");
        }
*/
        public Form1()
        {
            InitializeComponent();
            SetUpData();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAddActivities_Click(object sender, EventArgs e)
        {
            ActivitiesForm info = new ActivitiesForm();
            info.Show();
        }

        private Boolean btnSubmit_Click(object sender, EventArgs e)
        {
            string username, fname, lname, email, pass, address, exp;
            DateTime dob;
            username = txtBoxSUUsername.Text;
            fname = txtBoxFirstName.Text;
            lname = txtBoxLastname.Text;
            email = txtBoxEmail.Text;
            pass = txtBoxPassword.Text;
            dob = dobPicker.Value;
            address = txtBoxAddress.Text;
            exp = cyclingXPBox.Text;

            AddMember(username, fname, lname, email, pass, dob, address, exp);
            return true;
        }

        private void AddMember(String UserName, String FirstName, String LastName, String Email, String PassWord, DateTime DoB, String Address, String CyclingXP)
        {
            Member m = new Member(UserName, FirstName, LastName, Email, PassWord, DoB, Address, CyclingXP);
        }

        private void lvLeaderboard_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem L in lvLeaderboard.SelectedItems)
            {
                this.txtBoxSUUsername.Text = L.SubItems[0].Text;
                this.tex
            }
        }

        private void achievementsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddSentence_Click(object sender, EventArgs e)
        {
            if (btnAddSentence.Text == "Add Sentence")
            {
                btnAddSentence.Text = "Save";
                this.txtMotivationalSentence.Enabled = true;
            }
            else
            {
                achievements.Add(new Achievements(this.txtMotivationalSentence.Text));

                btnAddSentence.Text = "Add Sentence";
                this.txtMotivationalSentence.Enabled = false;

            }
        }

        private void btnDeleteSentence_Click(object sender, EventArgs e)
        {
            this.txtMotivationalSentence.Text = "";
            achievements.Remove(new Achievements(this.txtMotivationalSentence.Text));
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            bool B = btnSubmit_Click( sender,  e);
            if (B == true)
            {
                Member m1 = new Member(this.txtBoxSUUsername.Text)
            }
        }

        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    foreach (Member member in ListOfMembers)
        //    {
        //        if (txtBoxUsername.Text = member)
        //        {

        //        }
        //    }
        //}
    }

}
