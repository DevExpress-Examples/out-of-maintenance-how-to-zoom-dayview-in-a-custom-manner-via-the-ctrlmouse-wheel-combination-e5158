Imports Microsoft.VisualBasic
Imports System
Namespace DXApplication5
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
			Me.schedulerSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
			Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
			Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			Me.dateNavigator = New DevExpress.XtraScheduler.DateNavigator()
			CType(Me.schedulerSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.schedulerSplitContainerControl.SuspendLayout()
			CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' schedulerSplitContainerControl
			' 
			Me.schedulerSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.schedulerSplitContainerControl.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
			Me.schedulerSplitContainerControl.Location = New System.Drawing.Point(0, 0)
			Me.schedulerSplitContainerControl.Name = "schedulerSplitContainerControl"
			Me.schedulerSplitContainerControl.Panel1.Controls.Add(Me.schedulerControl)
			Me.schedulerSplitContainerControl.Panel1.Text = "Panel1"
			Me.schedulerSplitContainerControl.Panel2.Controls.Add(Me.dateNavigator)
			Me.schedulerSplitContainerControl.Panel2.Text = "Panel2"
			Me.schedulerSplitContainerControl.Size = New System.Drawing.Size(1100, 700)
			Me.schedulerSplitContainerControl.SplitterPosition = 190
			Me.schedulerSplitContainerControl.TabIndex = 2
			Me.schedulerSplitContainerControl.Text = "splitContainerControl1"
			' 
			' schedulerControl
			' 
			Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.schedulerControl.Location = New System.Drawing.Point(0, 0)
			Me.schedulerControl.Name = "schedulerControl"
			Me.schedulerControl.Size = New System.Drawing.Size(905, 700)
			Me.schedulerControl.Start = New System.DateTime(2014, 3, 7, 0, 0, 0, 0)
			Me.schedulerControl.Storage = Me.schedulerStorage
			Me.schedulerControl.TabIndex = 0
			Me.schedulerControl.Text = "schedulerControl1"
			Me.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1)
			Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
			' 
			' dateNavigator
			' 
			Me.dateNavigator.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dateNavigator.HotDate = Nothing
			Me.dateNavigator.Location = New System.Drawing.Point(0, 0)
			Me.dateNavigator.Name = "dateNavigator"
			Me.dateNavigator.SchedulerControl = Me.schedulerControl
			Me.dateNavigator.Size = New System.Drawing.Size(190, 700)
			Me.dateNavigator.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1100, 700)
			Me.Controls.Add(Me.schedulerSplitContainerControl)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.schedulerSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.schedulerSplitContainerControl.ResumeLayout(False)
			CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateNavigator, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private schedulerSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
		Private schedulerControl As DevExpress.XtraScheduler.SchedulerControl
		Private dateNavigator As DevExpress.XtraScheduler.DateNavigator
		Private schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage

	End Class
End Namespace
