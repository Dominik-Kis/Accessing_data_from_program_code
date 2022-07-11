using PPPK_WindowsForms.Dal;
using PPPK_WindowsForms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPPK_WindowsForms
{
    public partial class sqlManager : Form
    {
        public sqlManager()
        {
            InitializeComponent();
            Init();
        }

        private void Init() => LoadDatabases();

        private void LoadDatabases()
 => CbDatabases.DataSource = new List<Database>(RepositoryFactory.GetRepository().GetDatabases());

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
            => Application.Exit();

        private void MainForm_FormClosed(object sender, FormClosingEventArgs e)
            => Application.Exit();

        private void button1_Click(object sender, EventArgs e)
        {
            TbMessages.Text = "";
            flpResults.Controls.Clear();
            string useDatabase = "use " + CbDatabases.SelectedItem + " ";
            DataSet ds = RepositoryFactory.GetRepository().GetDataSet(useDatabase + TbQuery.Text, TbMessages);
            if (ds.Tables.Count != 0)
            {
                //DgResults.DataSource = ds.Tables[0];

                foreach (DataTable data in ds.Tables)
                {
                    DataGrid dataGrid = new DataGrid();
                    dataGrid.DataSource = data;
                    dataGrid.Width = flpResults.Width - 25;
                    if (ds.Tables.Count == 1)
                    {
                        dataGrid.Height = flpResults.Height - 10;
                    }
                    else
                    {
                        dataGrid.Height = flpResults.Height / 2;
                    }

                    flpResults.Controls.Add(dataGrid);
                }

                tabControl1.SelectedTab = tabResults;
            }
            else
            {
                //DgResults.DataSource = null;
                //DgResults.Rows.Clear();
                tabControl1.SelectedTab = tabMessages;
            }
            //tabResults.Controls.Clear();
            //new SelectResultsForm(ds.Tables[0]).ShowDialog();
        }

    }
}
