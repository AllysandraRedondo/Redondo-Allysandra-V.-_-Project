using MODELS;
using System.Collections.Generic;

namespace DATALAYER
{
    public class OwnerData
    {
        List<OwnerContent> user = new List<OwnerContent>();

        public OwnerData()
        {
            Userlist();
        }
        public void Userlist()
        {
            OwnerContent num1 = new OwnerContent { name = "Redondo", pass = "123" };
           

            user.Add(num1);
           
        }
        public OwnerContent GetUser(string name, string pass)
        {
            OwnerContent User = new OwnerContent();

            foreach (var ver in user)
            {
                if (name == ver.name && pass == ver.pass)
                {
                    User = ver;

                }
            }
            return User;
        }
    }
}
