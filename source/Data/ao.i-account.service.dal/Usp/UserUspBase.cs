using System.Collections.Generic;

namespace ao.i_account.service.dal.Usp
{
    public class UserUspBase : UspBase
    {
        public UserUspBase(Operation operation):base(operation)
        {
            StoreProcedureList = new Dictionary<Operation, string>
            {
                {Operation.Insert, "usp_Insert_User"},
                {Operation.Get, "usp_Get_User"}
            };
        }
    }
}