using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_votingSystem
{
    public partial class Voting : Form
    {

        SerialPort sp = new SerialPort();
        string data = "";
        User currentUser;
        public Voting()
        {
            InitializeComponent();
            sp.BaudRate = 9600;

            for (int i = 0; i < 100; i++)
            {
                try
                {
                    sp.PortName = "COM"+i;
                    sp.DataReceived += sp_DataReceived;
                    sp.Open();
                    MessageBox.Show("open in port " + i);
                    break;
                }
                catch(Exception)
                {

                }
            }
            
          
        }

        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data = sp.ReadLine();
            MessageBox.Show("Your id is " + data);
        
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(panel1.Visible == true)
            {
                currentUser = DBHelper.selectUserByVotionId(data);
                if(currentUser == null)
                {
                    MessageBox.Show("this user not saved in database");
                }
                else
                {
                    panel1.Visible = false;
                    panel2.Visible = true;
                }
            }
            else if (panel2.Visible == true)
            {
                if(txtSSNQ.Text.Trim().Equals(currentUser.Ssn.Trim()))
                {
                    panel2.Visible = false;
                    panel3.Visible = true;
                }
                else
                {
                    MessageBox.Show("wrong ssn number please try again");
                }
            }
            else if (panel3.Visible == true)
            {

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Vote v = new Vote ();
            v.User_Id=currentUser.Ssn;
            v.Candidate_Id ="1";
            DBHelper.insertIntoVotes(v);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Vote v = new Vote();
            v.User_Id = currentUser.Ssn;
            v.Candidate_Id = "2";
            DBHelper.insertIntoVotes(v);
        }
      

      
    }
}
