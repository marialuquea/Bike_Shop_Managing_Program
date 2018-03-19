using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM_cw2
{
    public class Worker : Person
    {

        private int _companyID;
        private int _jobID;

        public int CompanyID
        {
            get { return _companyID; }
            set { _companyID = value; }
        }

        public int JobID
        {
            get { return _jobID; }
            set { _jobID = value; }
        }

    }
}
