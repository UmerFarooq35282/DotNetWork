using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebAPISaopBase.Models;


namespace WebAPISaopBase
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPracticeAPI" in both code and config file together.
    [ServiceContract]
    public interface IPracticeAPI
    {
        [OperationContract]
        void DoWork();

        [OperationContract]

        List<Department> GetDeparments();

        [OperationContract]
        List<Department> GetDeparmentById(int id);
        [OperationContract]
        List<Department> GetTopDepartments(int id , int rating);

    }
}
