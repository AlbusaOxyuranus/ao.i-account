using ao.i_account.service.dal.Usp;
using ao.i_account.service.models;

namespace ao.i_account.service.dal
{
    public static class Mapper
    {
        //private static readonly Dictionary<Type, Type> _mapDictionary = new Dictionary<Type, Type>()
        //{
        //    {typeof(User), typeof(UserSp<User>)},
        //};

        public static UspBase InsertOperation(IEntity entity)
        {
            return new UserUspBase
            {
                NameUsp = "usp_Insert_User",
                Parameters =
                {
                    {"@username", (entity as User)?.Username},
                    {"@password", (entity as User)?.Password}
                }
            };
        }

        public static UspBase GetOperation<TGetType>(TGetType id)
        {
            return new UserUspBase
            {
                NameUsp = "usp_Get_User",
                Parameters =
                {
                    {"@userId", id}
                }
            };
        }
    }
}