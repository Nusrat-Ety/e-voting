using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_votingSystem
{
    class Vote
    {
        string user_Id, candidate_Id;

        public string Candidate_Id
        {
            get { return candidate_Id; }
            set { candidate_Id = value; }
        }

        public string User_Id
        {
            get { return user_Id; }
            set { user_Id = value; }
        }

    }
}
