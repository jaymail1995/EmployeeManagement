using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Models
{
    public class EmployeeModel
    {
        private int _id;
        private string _firstName;
        private string _city;
        private string _phone;
        private string _email;
       
        public EmployeeModel()
        {
            _id = 0;
            _firstName = "default";
            _city = "default";
            _phone = "default";
            _email = "default";
        }

        public int EmployeeID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string EmployeeFirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string EmployeeCity
        {
            get { return _city; }
            set { _city = value; }
        }
        public string EmployeePhone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string EmployeeEmail
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}