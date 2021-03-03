using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using EmployeeManagement.Models;

namespace EmployeeManagment.Data
{
    public class DataManager
    {
        SqlConnection _conn;
        SqlCommand cmd;
        SqlDataReader reader;

        public string ConnectionString { get; set; } = @"Data Source=.;Initial Catalog=Inventory;Integrated Security=True";

        public int InsertData(string query)
        {
            try
            {
                _conn = new SqlConnection(ConnectionString);
                _conn.Open();
                cmd = new SqlCommand(query, _conn);
                int result = cmd.ExecuteNonQuery();
                 if(result > 0)
                {
                    return result;
                }
                else
                {
                    return 0;
                }
            }
            catch(Exception exception)
            {
                return -1;
            }
            finally
            {
                _conn.Close();
                _conn.Dispose();
            }
        }

        public int UpdateData(string query)
        {
            try
            {
                _conn = new SqlConnection(ConnectionString);
                _conn.Open();
                cmd = new SqlCommand(query, _conn);
                int result = cmd.ExecuteNonQuery();
                if(result > 0)
                {
                    return result;
                }
                else
                {
                    return 0;
                }
            }
            catch (FormatException)
            {
                return -1;
            }
            catch (Exception)
            {
                return -2;
            }
            finally
            {
                _conn.Close();
                _conn.Dispose();
            }
        }

        public int DeleteData(string query)
        {
            try
            {
                _conn = new SqlConnection(ConnectionString);
                _conn.Open();
                cmd = new SqlCommand(query, _conn);
                int result = cmd.ExecuteNonQuery();
                if(result > 0)
                {
                    return result;
                }
                else
                {
                    return 0;
                }
            }
            catch (FormatException)
            {
                return -1;
            }
            catch(Exception)
            {
                return -2;
            }
            finally
            {
                _conn.Close();
                _conn.Dispose();
            }
        }

        public List<EmployeeModel> GetEmployeeDetails(string query)
        {
            try
            {
                List<EmployeeModel> employeeList = new List<EmployeeModel>();
                _conn = new SqlConnection(ConnectionString);
                _conn.Open();
                cmd = new SqlCommand(query, _conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    EmployeeModel empObject = new EmployeeModel();
                    empObject.EmployeeID =          reader["Id"].Equals(DBNull.Value)? 0 : int.Parse(reader["Id"].ToString());
                    empObject.EmployeeFirstName =   reader["FirstName"].Equals(DBNull.Value) ? "NULL" : (string) reader["FirstName"];
                    empObject.EmployeeCity =        reader["City"].Equals(DBNull.Value) ? "NULL" : (string) reader["City"];
                    empObject.EmployeePhone =       reader["Phone"].Equals(DBNull.Value) ? "NULL" : (string) reader["Phone"];
                    empObject.EmployeeEmail =       reader["Email"].Equals(DBNull.Value) ? "NULL" : (string) reader["Email"];
                    employeeList.Add(empObject);
                }
                return employeeList;
            }
            catch (FormatException)
            {
                throw;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                _conn.Close();
                _conn.Dispose();
            }
        }
    }
}