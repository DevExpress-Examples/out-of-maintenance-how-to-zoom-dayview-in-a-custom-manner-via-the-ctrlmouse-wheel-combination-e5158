using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraScheduler;
using DevExpress.Services;
using System.Windows.Forms;
using DevExpress.Services.Implementation;
using DevExpress.XtraScheduler.Native;
using DevExpress.XtraScheduler.Commands;
using DevExpress.Portable.Input;

namespace DXApplication5
{
    public class MyMouseHandlerService : MouseHandlerServiceWrapper
    {
        IServiceProvider provider;
        public MyMouseHandlerService(IServiceProvider provider, IMouseHandlerService service)
            : base(service)
        {
            this.provider = provider;
        }

        private void ZoomIn(SchedulerControl control)
        {
            MyViewZoomInCommand zoomInCommand = new MyViewZoomInCommand(control);
            zoomInCommand.Execute();
        }
        private void ZoomOut(SchedulerControl control)
        {
            MyViewZoomOutCommand zoomOutCommand = new MyViewZoomOutCommand(control);
            zoomOutCommand.MaxDayCount = 7;
            zoomOutCommand.Execute();
        }
        public override void OnMouseWheel(PortableMouseEventArgs e) {
            SchedulerMouseHandler handler = ((MouseHandlerService)this.Service).Handler as SchedulerMouseHandler;
            if(handler.IsControlPressed) {
                if(provider is SchedulerControl) {
                    SchedulerControl control = (SchedulerControl)provider;
                    if(e.Delta > 0)
                        ZoomIn(control);
                    else
                        ZoomOut(control);
                }
            }
            else
                base.OnMouseWheel(e);
        }
    }
}