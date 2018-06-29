using System.Runtime.Serialization;

[DataContract]
public class User
{
    [DataMember]
    public int UserId { get; set; }
    [DataMember]
    public string FirstName { get; set; }
    [DataMember]
    public string Lastname { get; set; }
    [DataMember]
    public string Surname { get; set; }
}