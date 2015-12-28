<<<<<<< HEAD
﻿/**************************************WCF Project*************************************/



=======
>>>>>>> 11d25840b5c81212e91fe32c0640408d5c9ffe89
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
<<<<<<< HEAD
            return string.Format( "Hi Employee {0} {1}",employee.EmpID,employee.EmpName );

=======
            return string.Format( "Hi Employe.You have done great job{0} {1}",employee.EmpID,employee.EmpName );
            //********Changes  Made
>>>>>>> 11d25840b5c81212e91fe32c0640408d5c9ffe89
        }
    }
}
