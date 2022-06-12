using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowForm2.FactoryMethod
{
    internal class AdminClass : AbstractUserClass
    {
        public override UserInterface CreateUser()
        {
            return new UserAdmin();
        }
    }
}
