using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTracker.Task;
using TaskTracker_BusinessLayer;

namespace TaskTracker.Team_Workspace.Task_Board.Search
{
    public partial class ctrlSearchBoard : UserControl
    {
        ctrlTasksList2 tasksList2;
        static DataTable dtTasks;
        public ctrlSearchBoard(ctrlTasksList2 tasksList2)
        {
            InitializeComponent();
            this.tasksList2 = tasksList2;
            dtTasks = tasksList2.dtTasks;
        }

        public void AddResult(Control ctrl)
        {
            flpSearchResults.Controls.Add(ctrl);
            flpSearchResults.Height += 30;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {            
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                flpSearchResults.Controls.Clear();
                dtTasks.DefaultView.RowFilter =
                    string.Format("[{0}] LIKE '{1}%'", "Title", txtSearch.Text.Trim());

                foreach (DataRowView drv in dtTasks.DefaultView)
                {
                    DataRow row = drv.Row;   // ✅ Get the underlying DataRow

                    ctrlSearchResult result = new ctrlSearchResult(this);
                    result.FillTaskObject(row);
                    ResultTaskCard(result);
                }
            }

            else
                flpSearchResults.Controls.Clear();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {

        }

        /*void LoadTaskCards(DataTable dtTasks)
        {
            
        }*/

        public void ResultTaskCard(ctrlSearchResult result)
        { 
            result.LoadResultTaskCard_ShownData();        
            flpSearchResults.Controls.Add(result);
        }

        private void ctrlSearchBoard_Load(object sender, EventArgs e)
        {
            
        }

        public void btnClose_Click(object sender = null, EventArgs e = null)
        {
            this.Visible = false;
            txtSearch.Text = "";
            flpSearchResults.Controls.Clear();
        }
    }
}
