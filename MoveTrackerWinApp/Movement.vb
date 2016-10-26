Public Class Movement
    Private Sub Movement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbkolbeDataSet.officer' table. You can move, or remove it, as needed.
        Me.OfficerTableAdapter.Fill(Me.DbkolbeDataSet.officer)
        'txtToday.Text = FormatDateTime(Today, DateFormat.LongDate)
        labDate.Text = FormatDateTime(Today, DateFormat.LongDate) & " - "
        labTime.Text = FormatDateTime(TimeOfDay, DateFormat.LongTime)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        MsgBox("Cell content clicked")

    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        MsgBox("Row Header clicked")
    End Sub
End Class
