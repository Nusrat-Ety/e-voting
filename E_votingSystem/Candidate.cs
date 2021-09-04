using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_votingSystem
{
    class Candidate
    {

        string ssn, name, address, phone, EMail, photo;

        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }

        public string EMail1
        {
            get { return EMail; }
            set {EMail = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Ssn
        {
            get { return ssn; }
            set { ssn = value; }
        }
    }
}
