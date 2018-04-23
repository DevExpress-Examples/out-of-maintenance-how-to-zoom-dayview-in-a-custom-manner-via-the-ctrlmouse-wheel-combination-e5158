Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Commands
Imports DevExpress.Utils.Commands

Namespace DXApplication5
    Public Class MyViewZoomOutCommand
        Inherits ViewZoomOutCommand

        Public Sub New(ByVal target As ISchedulerCommandTarget)
            MyBase.New(target)

        End Sub


        Private _MaxDayCount As Integer
        Public Property MaxDayCount() As Integer
            Get
                Return _MaxDayCount
            End Get
            Set(ByVal value As Integer)
                _MaxDayCount = value
            End Set
        End Property

        Protected Overrides Sub UpdateUIStateCore(ByVal state As ICommandUIState)

            If InnerControl.ActiveViewType <> SchedulerViewType.Day Then
                MyBase.UpdateUIStateCore(state)
            Else
                state.Visible = True
                state.Checked = False
                Dim isCanZoom As Boolean = CanZoomOut()

                If Not isCanZoom Then
                    If InnerControl.DayView.DayCount >= MaxDayCount Then
                        state.Enabled = False
                    Else
                        InnerControl.DayView.DayCount += 1
                        state.Enabled = True
                    End If
                End If

            End If
        End Sub


        Private Function CanZoomOut() As Boolean
            Return InnerControl.DayView.TimeScale < TimeSpan.FromHours(1)
        End Function


    End Class
End Namespace
