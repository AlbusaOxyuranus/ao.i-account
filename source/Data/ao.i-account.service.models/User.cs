using System.Runtime.Serialization;

namespace ao.i_account.service.models
{
    [DataContract]
    public class User : IEntity
    {
        
        [DataMember(Name = "userId")] public int UserId { get; set; }
        [DataMember(Name = "username")] public string Username { get; set; }
        [DataMember(Name = "password")] public string Password { get; set; }
        public void SetId(int id)
        {
            UserId=id;
        }
    }
}