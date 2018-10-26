using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_to_the_team
{
    class TeamMember : Person
    {

        protected double _salary;
        protected string _address;

        public TeamMember(double salary, string address, string firstName, string lastName, int age, string emailAddress) : base (firstName, lastName, age, emailAddress)
        {
            _salary = salary;
            _address = address;
        }


        public TeamMember()
        { }

        public double Salary
        {
            get { return this._salary; }
            set { this._salary = value; }

        }

        public string Address
        {
            get {return this._address;}
            set {this._address = value; }
            
        }

        public override string getList()
        {

            return $"Name: {_firstName} {_lastName}\nEmail Address: {_emailAddress}\nAge: {_age}\nAddress: {_address}\nSalary: ${_salary}";
        }
       
        

    }
}
