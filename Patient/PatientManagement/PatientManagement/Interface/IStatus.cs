using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement.Class
{
    public interface IStatus
    {
        void Insert(string id, bool status);
        void Update(string id, bool status);
        void Delete(string id);
        string AutoId();
        TreeNode ShowCategory();
        GroupBox ShowCategoryBox();
    }
}
