Imports System.Data
Imports MoveTrackerWinApp.GlobalVar
Imports MoveTrackerWinApp.clsClock
Public Class MovementSystem
    Dim ThisClock As clsClock

    Private Sub DataGridView1_MouseDown(sender As Object, e As MouseEventArgs)
        If DataGridView1.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        DataGridView1.DoDragDrop(DataGridView1.CurrentCell.Value.ToString, DragDropEffects.Copy)

    End Sub



    Private Sub MovementSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbkolbeDataSet.officer' table. You can move, or remove it, as needed.
        'Me.OfficerTableAdapter.Fill(Me.DbkolbeDataSet.officer)

        'Dim i As Integer = 0
        'For i = 0 To 3
        '    Me.DataGridView2.Columns.Add(Me.DataGridView1.Columns(i).Name, Me.DataGridView1.Columns(i).HeaderText)
        'Next
        'frmAssignLocale.Close()

        'tmrEvents.Interval = 1000
        'tmrEvents.Start()
        Call RunTheClock()

    End Sub

    Private Sub RunTheClock()
        'Dim thisclock As New clsClock
        'thisclock.StartClock()

        'lblClock.Text = glbTime
        'labSecs.Text = glbss

        tmrEvents.Interval = 1000
        tmrMS.Interval = 100
        tmrMS.Start()
        tmrEvents.Start()
        Call AssignCurrLoc()

    End Sub
    Private Sub AssignCurrLoc()
        txtCurrLoc.Text = glbLocNme
    End Sub

    Private Sub AssignCurrUser()
        lblUser.Text = glbUserNme
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs)
        Dim selectedRowCount As Integer =
        DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)

        If selectedRowCount > 0 Then

            Dim sb As New System.Text.StringBuilder()

            Dim i As Integer
            For i = 0 To selectedRowCount - 1

                sb.Append("Row: ")
                sb.Append(DataGridView1.SelectedRows(i).Index.ToString())
                sb.Append(Environment.NewLine)

            Next i

            sb.Append("Total: " + selectedRowCount.ToString())
            MessageBox.Show(sb.ToString(), "Selected Rows")

        End If
        'ListBox1.Items.Add(DataGridView1.SelectedRows(DataGridView1(1, 1))
        'Dim dt As New DataTable()

        'dt.Columns.Add("inmate_sys_id", GetType(Integer))
        'dt.Columns.Add("f_name", GetType(String))
        'dt.Columns.Add("m_name", GetType(Integer))
        'dt.Columns.Add("l_name", GetType(Decimal))

        'For Each gvRow As DataGridViewRow In DataGridView1.Rows
        '    Dim checkbox As CheckBox = DirectCast(gvRow.Cells(0).FindControl("CheckBox1"), CheckBox)
        '    If checkbox.Checked Then
        '        Dim row As DataRow = dt.NewRow()
        '        row("inmate_sys_id") = gvRow.Cells(1).Text
        '        row("f_name") = gvRow.Cells(2).Text
        '        row("m_name") = gvRow.Cells(3).Text
        '        row("l_name") = gvRow.Cells(4).Text
        '        dt.Rows.Add(row)
        '    End If
        'Next
        'ListBox1.DataSource = dt
        ''ListBox1.DataBindings.
    End Sub

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Dim selectedRowCount As Integer =
        DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)

        If selectedRowCount > 0 Then

            Dim sb As New System.Text.StringBuilder()

            Dim i As Integer
            For i = 0 To selectedRowCount - 1

                sb.Append("Row: ")
                sb.Append(DataGridView1.SelectedRows(i).Index.ToString())
                sb.Append(Environment.NewLine)

            Next i

            sb.Append("Total: " + selectedRowCount.ToString())
            MessageBox.Show(sb.ToString(), "Selected Rows")

        End If
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = DataGridView1.Rows(e.RowIndex)
            MsgBox("Selected" & selectedRow.ToString)
        End If
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Dim exists As Boolean
        Dim Dsto As New DataSet '' '' Dataset for to DatagridView

        'For i = 0 To Me.DataGridView1.Columns.Count - 1

        'Dim i As Integer = 0
        'For i = 0 To 3
        '    Me.DataGridView2.Columns.Add(Me.DataGridView1.Columns(i).Name, Me.DataGridView1.Columns(i).HeaderText)
        'Next
        '-- Use Right mouse button to activate Row grab and send to second list
        If e.Button = MouseButtons.Right Then
            'For index As Integer = 0 To DataGridView1.Rows.Count
            If DataGridView1.Rows(e.RowIndex).Selected = True Then

                Dim drows As New System.Windows.Forms.DataGridViewRow

                'If drows.Cells(0).Value = drows.Cells(0).Value Then

                For Each drows In DataGridView1.SelectedRows
                    For Each drows1 In DataGridView2.Rows
                        If drows1.Cells(0).Value = drows.Cells(0).Value Then
                            exists = True
                        End If
                    Next
                    If Not exists Then
                        DataGridView2.Rows.Add(drows.Cells(0).Value, drows.Cells(1).Value, drows.Cells(2).Value, drows.Cells(3).Value)
                    End If
                Next

            Else
                MsgBox("It is Not Selected")
            End If
            'Next   
        End If

    End Sub

    Private Sub tmrEvents_Tick(sender As Object, e As EventArgs) Handles tmrEvents.Tick
        Dim txtTime As String
        Dim inthr As Integer
        Dim intmm As Integer
        Dim txtss As String

        labSecs.Text = ""
        inthr = Format(Now, "hh")
        intmm = Format(Now, "mm")
        txtss = Format(Now, "ss")
        txtTime = inthr & ":" & intmm

        lblClock.Text = txtTime
        labSecs.Text = txtss
    End Sub

    Private Sub MovementSystem_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmMain.Show()
    End Sub

    Private Sub tmrMS_Tick(sender As Object, e As EventArgs) Handles tmrMS.Tick
        Dim startTime As DateTime
        Dim diff As TimeSpan = DateTime.Now - startTime

        LabMs.Text = diff.ToString("\:ff")

    End Sub
End Class

