using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class TaskModel
    {
        public int TaskID { get; set; }
        //public string Title { get; set; }
        //public int Status { get; set; }
        public int TaskIndex_Panel { get; set; }
    }

    public class TypeTaskModel
    {
        public int TypeTask_ID { get; set; }
        public string TypeTask_Name { get; set; }
        public string TypeTask_ColorName { get; set; }
    }
}
