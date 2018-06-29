using System.Collections.Generic;

namespace ao.i_account.service.dal.Usp
{
    public abstract class UspBase
    {
        protected UspBase()
        {
            Parameters = new Dictionary<string, object>();
        }
        public string NameUsp { get; set; }
        public Dictionary<string, object> Parameters { get; }
    }
}