using PPPK_WindowsForms.Model;
using System.Collections.Generic;
using System.Data;

namespace PPPK_WindowsForms.Dal
{
    interface IRepository
    {
        DataSet GetDataSet(string SQL, System.Windows.Forms.TextBox tbMessages);
        IEnumerable<Database> GetDatabases();
        void LogIn(string server, string username, string password);
    }
}