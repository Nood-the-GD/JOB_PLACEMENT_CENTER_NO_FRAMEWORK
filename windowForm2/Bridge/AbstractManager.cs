using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace windowForm2.Bridge
{
    internal class AbstractManager
    {
        BusinessLayer bsLayer;

        public AbstractManager(BusinessLayer BSlayer)
        {
            this.bsLayer = BSlayer;
        }

        public DataTable GetTable()
        {
            DataTable data = new DataTable();
            data = bsLayer.GetTable().Tables[0];
            return data;
        }

        public void Insert()
        {
            bsLayer.Insert();
        }

        public void Delete()
        {
            DialogResult dialogResult = MessageBox.Show("Are you want to delete ?", "Confirm dialog", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bsLayer.Delete();
            }
        }

        public void DeleteBaseOnUserID()
        {
            try
            {
                bsLayer.DeleteBaseOnUseID();
            }
            catch
            {

            }
        }

        public void Update()
        {
            bsLayer.Update();
            MessageBox.Show("Update complete");
        }

        public void Search(DataGridView dgv, string searchKeyWord)
        {
            bsLayer.Search(dgv, searchKeyWord);
        }
    }
}
