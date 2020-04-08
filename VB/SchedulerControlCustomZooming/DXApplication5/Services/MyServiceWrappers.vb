Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraScheduler
Imports DevExpress.Services
Imports System.Windows.Forms
Imports DevExpress.Services.Implementation
Imports DevExpress.XtraScheduler.Native
Imports DevExpress.XtraScheduler.Commands
Imports DevExpress.Portable.Input

Namespace DXApplication5
	Public Class MyMouseHandlerService
		Inherits MouseHandlerServiceWrapper

		Private provider As IServiceProvider
		Public Sub New(ByVal provider As IServiceProvider, ByVal service As IMouseHandlerService)
			MyBase.New(service)
			Me.provider = provider
		End Sub

		Private Sub ZoomIn(ByVal control As SchedulerControl)
			Dim zoomInCommand As New MyViewZoomInCommand(control)
			zoomInCommand.Execute()
		End Sub
		Private Sub ZoomOut(ByVal control As SchedulerControl)
			Dim zoomOutCommand As New MyViewZoomOutCommand(control)
			zoomOutCommand.MaxDayCount = 7
			zoomOutCommand.Execute()
		End Sub
		Public Overrides Sub OnMouseWheel(ByVal e As PortableMouseEventArgs)
			Dim handler As SchedulerMouseHandler = TryCast(CType(Me.Service, MouseHandlerService).Handler, SchedulerMouseHandler)
			If handler.IsControlPressed Then
				If TypeOf provider Is SchedulerControl Then
					Dim control As SchedulerControl = DirectCast(provider, SchedulerControl)
					If e.Delta > 0 Then
						ZoomIn(control)
					Else
						ZoomOut(control)
					End If
				End If
			Else
				MyBase.OnMouseWheel(e)
			End If
		End Sub
	End Class
End Namespace