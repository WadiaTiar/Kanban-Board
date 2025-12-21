using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class PanelTasksModel
    {
        private int _StatusID;
        private int _OrderNum;

        public int PanelTasksID { get { return _StatusID; } }
        public int PanelTasksOrder { get { return _OrderNum; } }

        public PanelTasksModel(int Status_ID, int OrderNum)
        {
            this._StatusID = Status_ID;
            this._OrderNum = OrderNum;
        }
    }
}
