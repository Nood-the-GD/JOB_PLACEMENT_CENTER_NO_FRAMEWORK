using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace windowForm2.Bridge
{
    public interface BusinessLayer
    {
        DataSet GetTable();

        bool Insert();

        bool Delete();

        bool DeleteBaseOnUseID();

        bool Update();

        void Search(DataGridView dgv, string searchKeyWord);

    }
}
