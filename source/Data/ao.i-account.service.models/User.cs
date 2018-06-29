using System.Runtime.Serialization;

namespace ao.i_account.service.models
{
    [DataContract]
    public class User
    {
        [DataMember] public int UserId { get; set; }
        [DataMember] public string Username { get; set; }
        [DataMember] public string Password { get; set; }
    }
}