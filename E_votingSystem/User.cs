using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_votingSystem
{
    class User
    {
        string firstName, lastName, phone, email, ssn, address, education, vottingId, PhotoPath, bdate;

        public string Bdate
        {
            get { return bdate; }
            set { bdate = value; }
        }

        public string PhotoPath1
        {
            get { return PhotoPath; }
            set { PhotoPath = value; }
        }

        public string VottingId
        {
            get { return vottingId; }
            set { vottingId = value; }
        }

        public string Education
        {
            get { return education; }
            set { education = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Ssn
        {
            get { return ssn; }
            set { ssn = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

      

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        } 
    }
}
