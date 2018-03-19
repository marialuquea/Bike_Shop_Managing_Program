
namespace SEM_cw2
{
    public class Worker : Person
    {

        private int _staffNo;
        private int _jobID;
        private double _salary;
        private int _phoneNo;

        public int StaffNumber
        {
            get { return _staffNo; }
            set { _staffNo = value; }
        }
        public int JobID
        {
            get { return _jobID; }
            set { _jobID = value; }
        }
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public int PhoneNumber
        {
            get { return _phoneNo; }
            set { _phoneNo = value; }
        }
        
    }
}
