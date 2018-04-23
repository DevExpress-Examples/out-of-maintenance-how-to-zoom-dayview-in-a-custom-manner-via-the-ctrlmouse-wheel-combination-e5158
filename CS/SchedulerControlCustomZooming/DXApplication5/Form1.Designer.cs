namespace DXApplication5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerSplitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.schedulerControl = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.dateNavigator = new DevExpress.XtraScheduler.DateNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerSplitContainerControl)).BeginInit();
            this.schedulerSplitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerSplitContainerControl
            // 
            this.schedulerSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerSplitContainerControl.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.schedulerSplitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.schedulerSplitContainerControl.Name = "schedulerSplitContainerControl";
            this.schedulerSplitContainerControl.Panel1.Controls.Add(this.schedulerControl);
            this.schedulerSplitContainerControl.Panel1.Text = "Panel1";
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.dateNavigator);
            this.schedulerSplitContainerControl.Panel2.Text = "Panel2";
            this.schedulerSplitContainerControl.Size = new System.Drawing.Size(1100, 700);
            this.schedulerSplitContainerControl.SplitterPosition = 190;
            this.schedulerSplitContainerControl.TabIndex = 2;
            this.schedulerSplitContainerControl.Text = "splitContainerControl1";
            // 
            // schedulerControl
            // 
            this.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl.Name = "schedulerControl";
            this.schedulerControl.Size = new System.Drawing.Size(905, 700);
            this.schedulerControl.Start = new System.DateTime(2014, 3, 7, 0, 0, 0, 0);
            this.schedulerControl.Storage = this.schedulerStorage;
            this.schedulerControl.TabIndex = 0;
            this.schedulerControl.Text = "schedulerControl1";
            this.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            // 
            // dateNavigator
            // 
            this.dateNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateNavigator.HotDate = null;
            this.dateNavigator.Location = new System.Drawing.Point(0, 0);
            this.dateNavigator.Name = "dateNavigator";
            this.dateNavigator.CellPadding = new System.Windows.Forms.Padding(2);
            this.dateNavigator.SchedulerControl = this.schedulerControl;
            this.dateNavigator.Size = new System.Drawing.Size(190, 700);
            this.dateNavigator.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.schedulerSplitContainerControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerSplitContainerControl)).EndInit();
            this.schedulerSplitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl schedulerSplitContainerControl;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl;
        private DevExpress.XtraScheduler.DateNavigator dateNavigator;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage;

    }
}
