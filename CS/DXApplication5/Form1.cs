using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using DevExpress.Services;



namespace DXApplication5
{
    public partial class Form1 : XtraForm
    {


        private void InitSchedulerControl()
        {
            schedulerControl.Start = System.DateTime.Now;
            schedulerControl.ActiveViewType = SchedulerViewType.Day;
            schedulerControl.GroupType = SchedulerGroupType.Resource;
            schedulerControl.DayView.DayCount = 1;
            schedulerControl.DayView.ResourcesPerPage = 2;
            schedulerControl.OptionsView.EnableAnimation = false;
       
        }
        public Form1()
        {
            InitializeComponent();
            InitSchedulerControl();

            schedulerStorage.Appointments.ResourceSharing = true;

            DataHelper.FillResources(schedulerStorage, 5);
            InitAppointments();
        }


        void InitAppointments()
        {
            int count = schedulerStorage.Resources.Count;
            DataHelper.GenerateEvents(schedulerStorage.Appointments.Items, count, schedulerStorage.Resources.Items);
            DataHelper.GenerateEventsWithSharedResource(schedulerStorage.Appointments.Items, 1, schedulerStorage.Resources.Items);
            DataHelper.AddRecurrentAppointment(schedulerStorage.Appointments.Items);
        }

        private void ExchangeMouseService()
        {
            IMouseHandlerService oldMouseHandler = schedulerControl.GetService<IMouseHandlerService>();
            if (oldMouseHandler != null)
            {
                MyMouseHandlerService newMouseHandler = new MyMouseHandlerService(schedulerControl, oldMouseHandler);
                schedulerControl.RemoveService(typeof(IMouseHandlerService));
                schedulerControl.AddService(typeof(IMouseHandlerService), newMouseHandler);
            }
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            ExchangeMouseService();
        }

    }

}