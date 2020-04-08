Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraScheduler

Namespace DXApplication5
	Public Module DataHelper


		Private Users() As String = { "Peter Dolan", "Ryan Fischer", "Andrew Miller", "Tom Hamlett", "Jerry Campbell", "Carl Lucas", "Mark Hamilton", "Steve Lee" }

		Public Sub FillResources(ByVal storage As SchedulerStorage, ByVal count As Integer)
			Dim resources As ResourceCollection = storage.Resources.Items
			storage.BeginUpdate()
			Try
				Dim cnt As Integer = Math.Min(count, Users.Length)
				For i As Integer = 1 To cnt
					Dim resource As Resource = storage.CreateResource(i)
					resource.Caption = Users(i - 1)
					resources.Add(resource)
				Next i
			Finally
				storage.EndUpdate()
			End Try
		End Sub

		Public Sub GenerateEvents(ByVal eventList As AppointmentCollection, ByVal count As Integer, ByVal collection As ResourceCollection, ByVal storage As SchedulerStorage)

			For i As Integer = 0 To count - 1
				Dim resource As Resource = collection(i)
				Dim subjPrefix As String = resource.Caption & "'s "
				eventList.Add(CreateEvent(subjPrefix & "meeting", resource.Id, 2, 5, storage))
				eventList.Add(CreateEvent(subjPrefix & "travel", resource.Id, 3, 6, storage))
				eventList.Add(CreateEvent(subjPrefix & "phone call", resource.Id, 0, 10, storage))
			Next i
		End Sub

		Public Sub GenerateEventsWithSharedResource(ByVal eventList As AppointmentCollection, ByVal count As Integer, ByVal collection As ResourceCollection, ByVal storage As SchedulerStorage)
			For i As Integer = 0 To count - 1
				Dim subjPrefix As String = "Appt " & i
				eventList.Add(AddSharedResources(subjPrefix, 1, 1, collection, storage))
			Next i
		End Sub

		Private Function AddSharedResources(ByVal subject As String, ByVal status As Integer, ByVal label As Integer, ByVal collection As ResourceCollection, ByVal storage As SchedulerStorage) As Appointment
			Dim apt As Appointment = storage.CreateAppointment(AppointmentType.Normal)
			apt.Subject = subject
			For i As Integer = 0 To collection.Count - 1
				Dim resourceId As Object = CType(collection(i), Resource).Id
				apt.ResourceIds.Add(resourceId)
			Next i


			Dim rnd As New Random()
			Dim rangeInMinutes As Integer = 60 * 24
			apt.Start = DateTime.Today.AddDays(1).Add(TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes)))
			apt.End = apt.Start + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes \ 4))
			apt.StatusKey = status
			apt.LabelKey = label
			Return apt
		End Function

		Private Function CreateEvent(ByVal subject As String, ByVal resourceId As Object, ByVal status As Integer, ByVal label As Integer, ByVal storage As SchedulerStorage) As Appointment
			Dim apt As Appointment = storage.CreateAppointment(AppointmentType.Normal)
			apt.Subject = subject
			apt.ResourceId = resourceId

			Dim rnd As New Random()
			Dim rangeInMinutes As Integer = 60 * 24
			apt.Start = DateTime.Today.Add(TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes)))
			apt.End = apt.Start + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes \ 4))
			apt.StatusKey = status
			apt.LabelKey = label
			Return apt
		End Function

		Public Sub AddRecurrentAppointment(ByVal eventList As AppointmentCollection, ByVal storage As SchedulerStorage)
			Dim aptPattern As Appointment = storage.CreateAppointment(AppointmentType.Pattern)
			aptPattern.Subject = "Pattern"

			aptPattern.RecurrenceInfo.Type = RecurrenceType.Hourly
			aptPattern.RecurrenceInfo.Periodicity = 4
			aptPattern.RecurrenceInfo.Duration = New TimeSpan(0, 30, 0)
			aptPattern.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount
			aptPattern.RecurrenceInfo.OccurrenceCount = 10
			aptPattern.RecurrenceInfo.Start = DateTime.Now.AddDays(2)
			aptPattern.StatusKey = 2
			aptPattern.ResourceId = 1

			eventList.Add(aptPattern)
		End Sub

	End Module
End Namespace
