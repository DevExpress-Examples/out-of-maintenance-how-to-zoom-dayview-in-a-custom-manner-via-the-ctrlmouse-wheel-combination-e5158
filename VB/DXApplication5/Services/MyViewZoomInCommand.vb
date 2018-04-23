Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Commands
Imports DevExpress.Utils.Commands

Namespace DXApplication5
	Public Class MyViewZoomInCommand
		Inherits ViewZoomInCommand

		Public Sub New(ByVal target As ISchedulerCommandTarget)
			MyBase.New(target)
		End Sub

		Protected Overrides Sub UpdateUIStateCore(ByVal state As ICommandUIState)
			If InnerControl.ActiveViewType <> SchedulerViewType.Day Then
				MyBase.UpdateUIStateCore(state)
			Else
				state.Visible = True
				state.Checked = False
				Dim isCanZoomIn As Boolean = CanZoomIn()
				If (Not isCanZoomIn) Then
					InnerControl.DayView.DayCount -= 1
					state.Enabled = False
				Else
					state.Enabled = True
				End If

			End If

		End Sub


		Private Function CanZoomIn() As Boolean
			Return InnerControl.DayView.DayCount = 1
		End Function

	End Class
End Namespace
