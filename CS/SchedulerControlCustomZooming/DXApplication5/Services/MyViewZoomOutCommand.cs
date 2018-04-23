using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Commands;
using DevExpress.Utils.Commands;

namespace DXApplication5
{
    public class MyViewZoomOutCommand : ViewZoomOutCommand
    {

        public MyViewZoomOutCommand(ISchedulerCommandTarget target)
            : base(target)
        {

        }


        private int _MaxDayCount;
        public int MaxDayCount
        {
            get { return _MaxDayCount; }
            set
            {
                _MaxDayCount = value;
            }
        }

        protected override void UpdateUIStateCore(ICommandUIState state)
        {

            if (InnerControl.ActiveViewType != SchedulerViewType.Day)
                base.UpdateUIStateCore(state);
            else
            {
                state.Visible = true;
                state.Checked = false;
                bool isCanZoom = CanZoomOut();

                if (!isCanZoom)
                {
                    if (InnerControl.DayView.DayCount >= MaxDayCount)
                        state.Enabled = false;
                    else
                    {
                        InnerControl.DayView.DayCount++;
                        state.Enabled = true;
                    }
                }
              
            }
        }


        private bool CanZoomOut()
        {
            return InnerControl.DayView.TimeScale < TimeSpan.FromHours(1);
        }
     

    }
}
