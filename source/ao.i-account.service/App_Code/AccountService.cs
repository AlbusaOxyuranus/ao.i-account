using System;
using System.Configuration;
using ao.i_account.service.bal;
using ao.i_account.service.dal;
using ao.i_account.service.models;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AccountService" in code, svc and config file together.
public class AccountService : IAccountService
{
    public User CreateUser(User user)
    {
        using (var bc = new BusinessContext(new DbMode()))
        {
           return bc.Add(user);
        }
    }

    public void GetUser(int id)
    {
        using (var bc = new BusinessContext(new DbMode()))
        {
            bc.Get<User, int>(id);
        }
    }

    public Service CreateService(Service service)
    {
        using (var bc = new BusinessContext(new DbMode()))
        {
            return bc.Add(service);
        }
    }

    public void GetService(int id)
    {
        using (var bc = new BusinessContext(new DbMode()))
        {
            bc.Get<Service, int>(id);
        }
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

public class DbMode: IMode
{
    public string ConnectionString
    {
        get
        {
            return ConfigurationManager.ConnectionStrings["Prod-db"].ConnectionString;
        }
    }
}
