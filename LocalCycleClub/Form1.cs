using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalCycleClub
{
    public partial class Form1 : Form
    {
        public List<Member> ListOfMembers = new List<Member>();
        public void SetUpData()
        {
            Member m1 = new Member("MazIsDaBest", "Dylan", "Maziarek", "maz@theGOAT.com", "ilikecycling123", new DateTime(31, 08, 1997), "Thurles, Tipperary", "Lance on Steroids Good");
        }
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

        private void btnSubmit_Click(object sender, EventArgs e)
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
        }
        private void AddMember(String UserName, String FirstName, String LastName, String Email, String PassWord, DateTime DoB, String Address, String CyclingXP)
        {
            Member m = new Member(UserName, FirstName, LastName, Email, PassWord, DoB, Address, CyclingXP);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
