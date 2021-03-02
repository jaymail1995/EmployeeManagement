using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeManagement.Models;

namespace EmployeeManagment.Data
{
    public class UserData : DataManager
    {
        private string _query;
        DataManager dataManager = new DataManager();
        List<EmployeeModel> employeeObjList = new List<EmployeeModel>();

        public int AddEmployeeDetails(EmployeeModel employeeModel)
        {
            try
            {
                _query = $"INSERT INTO Employee (FirstName, City, Phone, Email) values ('{employeeModel.EmployeeFirstName}','{employeeModel.EmployeeCity}','{employeeModel.EmployeePhone}','{employeeModel.EmployeeEmail}');";
                int result = dataManager.InsertData(_query);
                if (result > 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public List<EmployeeModel> GetEmployeeList()
        {
            try
            {
                _query = "SELECT * FROM Employee";
                employeeObjList = dataManager.GetEmployeeDetails(_query);
                return employeeObjList;
            }
            catch
            {
                throw;
            }
        }
        
    }
}