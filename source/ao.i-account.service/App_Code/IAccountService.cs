﻿using System.Runtime.Serialization;
using System.ServiceModel;
using ao.i_account.service.models;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAccountService" in both code and config file together.
[ServiceContract]
public interface IAccountService
{
    [OperationContract]
    void CreateUser(User user);

    [OperationContract]
    void GetUser(User user);

    [OperationContract]
    void UpdateUser(User user);


    [OperationContract]
    string GetData(int value);

    [OperationContract]
    CompositeType GetDataUsingDataContract(CompositeType composite);

    // TODO: Add your service operations here
}

// Use a data contract as illustrated in the sample below to add composite types to service operations.
[DataContract]
public class CompositeType
{
    bool _boolValue = true;
    string _stringValue = "Hello ";

    [DataMember]
    public bool BoolValue
    {
        get { return _boolValue; }
        set { _boolValue = value; }
    }

    [DataMember]
    public string StringValue
    {
        get { return _stringValue; }
        set { _stringValue = value; }
    }
}