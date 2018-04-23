using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Commands;
using DevExpress.Utils.Commands;

namespace DXApplication5
{
    public class MyViewZoomInCommand : ViewZoomInCommand
    {

        public MyViewZoomInCommand(ISchedulerCommandTarget target)
            : base(target)
        {
        }

        protected override void UpdateUIStateCore(ICommandUIState state)
        {
            if (InnerControl.ActiveViewType != SchedulerViewType.Day)
                base.UpdateUIStateCore(state);
            else
            {
                state.Visible = true;
                state.Checked = false;
                bool isCanZoomIn =  CanZoomIn();
                if (!isCanZoomIn)
                {
                    InnerControl.DayView.DayCount--;
                    state.Enabled = false;
                }
                else
                    state.Enabled = true;
               
            }

        }


        private bool CanZoomIn()
        {
            return InnerControl.DayView.DayCount == 1;
        }
     
    }
}
