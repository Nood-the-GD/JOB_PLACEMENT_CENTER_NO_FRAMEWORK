using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using windowForm2.Global;
using windowForm2.AdministratorInterface;
using windowForm2.Business;
using windowForm2.Bridge;
using windowForm2.Classes;

namespace windowForm2.FactoryMethod
{
    internal class UserAdmin : UserInterface
    {
        AbstractManager manager;
        BLUser blUser;
        public void InsertToDB()
        {
            blUser = new BLUser();
            manager = new AbstractManager(blUser);

            manager.Insert();
        }

        public void OpenForm()
        {
            MainForm_Administrator adminForm = new MainForm_Administrator();
            adminForm.ShowDialog();
        }

        public void SetUtil()
        {
            USER admin = util.GetUserWhenLogin(util.userName);
            util.password = admin.password;
        }
    }
}
