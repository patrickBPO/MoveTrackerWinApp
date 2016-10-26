Imports MoveTrackerWinApp.GlobalVar
Public Class clsClock
    Public WithEvents tmrClocks As New Timer

    Friend Sub StartClock()

        tmrClocks.Interval = 1000
        tmrClocks.Start()

    End Sub

    Public Sub tmrClocks_Tick(sender As Object, e As EventArgs) Handles tmrClocks.Tick
        Dim txtTime As String
        Dim inthr As Integer
        Dim intmm As Integer
        Dim txtss As String

        'labSecs.Text = ""
        inthr = Format(Now, "hh")
        intmm = Format(Now, "mm")
        txtss = Format(Now, "ss")
        txtTime = inthr & ":" & intmm

        glbTime = txtTime
        glbss = txtss

    End Sub
End Class
