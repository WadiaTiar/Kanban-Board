using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker.TrashCode
{
    internal class Class1
    {

/* clsTask
  
  public static void UpdateTasksOrder(List<TaskModel> tasks)
        {
            clsTask_DataAccess.UpdateTasksOrder(tasks);
        }*/
/*ctrlTask//
                if ( Math.Abs(e.Y - 66) > 120)
                {
                    clsGlobal.ctrlTasksList2.ScrollBar1_Value = 30;
                    clsGlobal.ctrlTasksList2._Scroll();
                }
                
                else if ((e.Y - _mouseDownLocation.Y) < 30)
                {
                    foreach (FlowLayoutPanel panel in clsGlobal.FlowLayoutPanels)
                    {
                        panel.Top += 60;
                    }
                }*/


        /*ctrlTasksList//
         
        public void LoadTasksOrderDataInList_InDataBase()
        {
            ctrlTasksList2.LoadTasksOrderDataInList_InDataBase();
        }*/

        /* ctrlTaskList2//
          
         // configure outer scrollbar (vScrollBar1 placed on the form)
        void UpdateScrollMax2()
        {
            int contentHeight = flowLayoutPanel1.PreferredSize.Height;
            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = contentHeight;
            vScrollBar1.LargeChange = panel1.ClientSize.Height;
            vScrollBar1.SmallChange = 20;
            if (vScrollBar1.Value > vScrollBar1.Maximum) vScrollBar1.Value = vScrollBar1.Maximum;
        }
                 void AttachClickRecursive_CloseAddTaskControl(Control parent)
                {
                    Control lastOne;
                    Control BeforeLastOne = panel_ctrlAddTaskOpened.Controls[panel_ctrlAddTaskOpened.Controls.Count - 2];

                    foreach (Control ctrl in parent.Controls)
                    {
                        if (ctrl is ctrlAddTask || ctrl is Label)
                            continue;


                        ctrl.Click += (s, e) =>
                        {
                            BeforeLastOne.Visible = false;

                            foreach (FlowLayoutPanel panel in clsGlobal.FlowLayoutPanels)
                            {
                                if (panel == flowLayoutPanel4)
                                    continue;


                                lastOne = panel.Controls[panel.Controls.Count - 1];

                                lastOne.Visible = (panel.ClientRectangle.
                                Contains(lastOne.PointToClient(Cursor.Position)))? true: false;

                            }
                        };
                        // If the control has children, recurse


                        if (ctrl.HasChildren)
                            AttachClickRecursive_CloseAddTaskControl(ctrl);
                    }
                }
         */


        /*private void ctrlAddTask_VisibleChanged(object sender, EventArgs e)
        {
            ctrlAddTask addTaskControl = sender as ctrlAddTask;

            if (!addTaskControl.Visible) 
                lblCreateTask.Visible = true;
        }*/

        /*public void LoadTasksOrderDataInList_InDataBase()
        {
            foreach (var panel in clsGlobal.FlowLayoutPanels)
            {
                foreach (var ctrl in panel.Controls)
                {
                    if (ctrl is Label)
                        continue;



                    if (ctrl is ctrlTask task)  
                        clsGlobal.tasksList.Add(new TaskModel { TaskID = task.TaskData.TaskID, TaskIndex_Panel = panel.Controls.IndexOf(task)});

                }
            }
        }*/



    }
}
