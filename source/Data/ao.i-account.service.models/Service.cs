using System.Runtime.Serialization;

namespace ao.i_account.service.models
{
    [DataContract]
    public class Service : IEntity
    {
        [DataMember] public int Id { get; set; }
        [DataMember] public string NameService { get; set; }
    }
}