using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Required]
        [Display(Name = "First Name")]
        public string EmployeeFirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        [Required]
        [Display(Name = "City")]
        public string EmployeeCity
        {
            get { return _city; }
            set { _city = value; }
        }
        [Required]
        [Display(Name = "Phone")]
        public string EmployeePhone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        [Required]
        [Display(Name = "Email")]
        public string EmployeeEmail
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}