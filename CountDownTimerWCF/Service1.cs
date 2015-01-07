using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CountDownTimerWCF
{

   // [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

       

        public string[] GetUser(string Id)
        { return new User().GetUser(Convert.ToInt32(Id)); }

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

    public class User
    {

        Dictionary<int, string> users = null;
        public User()
        {
            users = new Dictionary<int, string>();
            users.Add(1, "pranay");
            users.Add(2, "Krunal");
            users.Add(3, "Aditya");
            users.Add(4, "Samir");
        }

        public string[] GetUser(int Id)
        {
            var user = from u in users
                       where u.Key == Id
                       select u.Value;

            return user.ToArray<string>();
        }

    }
}
