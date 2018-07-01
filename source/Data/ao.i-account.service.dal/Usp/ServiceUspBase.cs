using System.Collections.Generic;

namespace ao.i_account.service.dal.Usp
{
    public class ServiceUspBase: UspBase
    {
        public ServiceUspBase(Operation operation):base(operation)
        {
            StoreProcedureList = new Dictionary<Operation, string>()
            {
                { Operation.Insert,"usp_Insert_Service"},
                { Operation.Get,"usp_Get_Service"}
            };
        }
    }
}
