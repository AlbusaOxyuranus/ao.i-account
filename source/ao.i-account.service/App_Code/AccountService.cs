using System;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AccountService" in code, svc and config file together.
public class AccountService : IAccountService
{
    public void CreateUser(User user)
    {
        throw new NotImplementedException();
    }

    public void GetUser(User user)
    {
        throw new NotImplementedException();
    }

    public void UpdateUser(User user)
    {
        throw new NotImplementedException();
    }

    public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}
}
