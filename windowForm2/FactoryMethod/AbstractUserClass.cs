using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowForm2.FactoryMethod
{
    internal abstract class AbstractUserClass
    {
        public abstract UserInterface CreateUser();

        public void SetUtil()
        {
            UserInterface user = CreateUser();

            user.SetUtil();
            user.OpenForm();
        }

        public void InsertUser()
        {
            UserInterface user = CreateUser();

            user.InsertToDB();
            user.SetUtil();
        }
    }
}
