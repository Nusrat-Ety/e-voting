using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_votingSystem
{
    public partial class addUser : Form
    {
        string data;
        public addUser()
        {
            InitializeComponent();
            
            try
            {
                serialPort1.Open();
                MessageBox.Show("open in com5");
            }
            catch(Exception)
            {
                MessageBox.Show("error in open ard");

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            User person = new User();
            person.Address = txtAddress.Text;
            person.Bdate = dtpBirthDate.Value.ToString();
            person.Email = txtEmail.Text;
            person.FirstName = txtFirstName.Text;
            person.LastName = txtSecondName.Text;
            person.Phone = txtPhone.Text;
            person.PhotoPath1 = "dasf";
            person.Ssn = txtSSN.Text;
            person.VottingId = txtvotionId.Text;


            DBHelper.insertIntoUser(person);


        
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            data = serialPort1.ReadLine();
            MessageBox.Show(data);
        }

        private void btnGetId_Click(object sender, EventArgs e)
        {
            txtvotionId.Text = data;
        }
    }
}
