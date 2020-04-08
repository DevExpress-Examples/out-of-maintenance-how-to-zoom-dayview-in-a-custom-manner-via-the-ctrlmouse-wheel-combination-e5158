Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler
Imports DevExpress.Services



Namespace DXApplication5
	Partial Public Class Form1
		Inherits XtraForm


		Private Sub InitSchedulerControl()
			schedulerControl.Start = DateTime.Now
			schedulerControl.ActiveViewType = SchedulerViewType.Day
			schedulerControl.GroupType = SchedulerGroupType.Resource
			schedulerControl.DayView.DayCount = 1
			schedulerControl.DayView.ResourcesPerPage = 2
			schedulerControl.OptionsView.EnableAnimation = False

		End Sub
		Public Sub New()
			InitializeComponent()
			InitSchedulerControl()

			schedulerStorage.Appointments.ResourceSharing = True

			DataHelper.FillResources(schedulerStorage, 5)
			InitAppointments()
		End Sub


		Private Sub InitAppointments()
			Dim count As Integer = schedulerStorage.Resources.Count
			DataHelper.GenerateEvents(schedulerStorage.Appointments.Items, count, schedulerStorage.Resources.Items, schedulerStorage)
			DataHelper.GenerateEventsWithSharedResource(schedulerStorage.Appointments.Items, 1, schedulerStorage.Resources.Items, schedulerStorage)
			DataHelper.AddRecurrentAppointment(schedulerStorage.Appointments.Items, schedulerStorage)
		End Sub

		Private Sub ExchangeMouseService()
			Dim oldMouseHandler As IMouseHandlerService = schedulerControl.GetService(Of IMouseHandlerService)()
			If oldMouseHandler IsNot Nothing Then
				Dim newMouseHandler As New MyMouseHandlerService(schedulerControl, oldMouseHandler)
				schedulerControl.RemoveService(GetType(IMouseHandlerService))
				schedulerControl.AddService(GetType(IMouseHandlerService), newMouseHandler)
			End If
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			ExchangeMouseService()
		End Sub

	End Class

End Namespace