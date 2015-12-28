using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace MyService
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        string empID;

        [DataMember]
        string empName;

        [DataMember]
        public string EmpID { get; set; }

        [DataMember]
        public string EmpName { get; set; }
    }
    
    [ServiceContract]
    public interface IEmployee
    {
        [OperationContract]
        string HiEmployee(Employee employee);
        
    }
    class MyService1
    {
        public string HiEmployee(Employee employee)
        {
            return string.Format( "Hi Employe.You have done great job{0} {1}",employee.EmpID,employee.EmpName );
            //********Changes  Made
        }
    }
}
