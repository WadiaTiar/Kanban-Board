using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class TaskModel
    {
        private int _TaskID;
        private int _TaskIndex_Panel;

        public int TaskID { get { return _TaskID; } }
        public int TaskIndex_Panel { get { return _TaskIndex_Panel; } }
        
        public TaskModel(int Task_ID, int TaskIndex_Panel) 
        {
            this._TaskID = Task_ID;
            this._TaskIndex_Panel = TaskIndex_Panel;
        }        
    }

    public class TypeTaskModel
    {
        public int TypeTask_ID { get; set; }
        public string TypeTask_Name { get; set; }
        public string TypeTask_ColorName { get; set; }
    }
}
