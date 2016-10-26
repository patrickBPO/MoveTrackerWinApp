<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MovementSystem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.labTime = New System.Windows.Forms.Label()
        Me.labDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMoveID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.grpCurrLoc = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCurrLoc = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.tmrEvents = New System.Windows.Forms.Timer(Me.components)
        Me.grpClock = New System.Windows.Forms.GroupBox()
        Me.LabMs = New System.Windows.Forms.Label()
        Me.labSecs = New System.Windows.Forms.Label()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.tmrMS = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCurrLoc.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpClock.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.AllowDrop = True
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox3.Location = New System.Drawing.Point(53, 46)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(57, 20)
        Me.TextBox3.TabIndex = 5
        Me.TextBox3.Text = "5"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(223, 200)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 29)
        Me.Button4.TabIndex = 30
        Me.Button4.Tag = ""
        Me.Button4.Text = "Receive"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.CheckedListBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(614, 279)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(279, 228)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pending Departures"
        '
        'Button3
        '
        Me.Button3.Image = Global.MoveTrackerWinApp.My.Resources.Resources.report_icon
        Me.Button3.Location = New System.Drawing.Point(238, 134)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 37)
        Me.Button3.TabIndex = 32
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(223, 186)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(56, 29)
        Me.Button5.TabIndex = 31
        Me.Button5.Text = "Cancel"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Location = New System.Drawing.Point(6, 13)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(215, 199)
        Me.CheckedListBox2.TabIndex = 28
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.CheckedListBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(614, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(279, 238)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pending Arrivals"
        '
        'Button2
        '
        Me.Button2.Image = Global.MoveTrackerWinApp.My.Resources.Resources.report_icon
        Me.Button2.Location = New System.Drawing.Point(238, 146)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 37)
        Me.Button2.TabIndex = 29
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.AllowDrop = True
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(6, 14)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(215, 214)
        Me.CheckedListBox1.TabIndex = 27
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.TextBox4)
        Me.GroupBox4.Controls.Add(Me.TextBox3)
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.Location = New System.Drawing.Point(918, 35)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(132, 112)
        Me.GroupBox4.TabIndex = 43
        Me.GroupBox4.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Out"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Current"
        '
        'TextBox4
        '
        Me.TextBox4.AllowDrop = True
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.Green
        Me.TextBox4.Location = New System.Drawing.Point(53, 18)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(57, 20)
        Me.TextBox4.TabIndex = 6
        Me.TextBox4.Text = "48"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.AllowDrop = True
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Blue
        Me.TextBox2.Location = New System.Drawing.Point(53, 69)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(57, 20)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = "53"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'labTime
        '
        Me.labTime.AutoSize = True
        Me.labTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTime.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.labTime.Location = New System.Drawing.Point(905, 17)
        Me.labTime.Name = "labTime"
        Me.labTime.Size = New System.Drawing.Size(34, 13)
        Me.labTime.TabIndex = 37
        Me.labTime.Text = "Time"
        '
        'labDate
        '
        Me.labDate.AutoSize = True
        Me.labDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDate.ForeColor = System.Drawing.Color.DodgerBlue
        Me.labDate.Location = New System.Drawing.Point(617, 4)
        Me.labDate.Name = "labDate"
        Me.labDate.Size = New System.Drawing.Size(34, 13)
        Me.labDate.TabIndex = 36
        Me.labDate.Text = "Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Inmate Search"
        '
        'txtMoveID
        '
        Me.txtMoveID.Location = New System.Drawing.Point(95, 4)
        Me.txtMoveID.Name = "txtMoveID"
        Me.txtMoveID.Size = New System.Drawing.Size(59, 20)
        Me.txtMoveID.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Destination"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(367, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Time"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 200)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Move Type"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(4, 298)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(279, 20)
        Me.TextBox13.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 282)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Comments"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(330, 295)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Check Out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TextBox13)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(605, 333)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Movement Status"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(11, 25)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(588, 138)
        Me.DataGridView2.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Move Class"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(4, 258)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(140, 21)
        Me.ComboBox3.TabIndex = 35
        Me.ComboBox3.Text = "DEPORTATION"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(210, 216)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(140, 21)
        Me.ComboBox2.TabIndex = 34
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(4, 215)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(122, 21)
        Me.ComboBox1.TabIndex = 32
        Me.ComboBox1.Text = "DISCHARGE"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(370, 216)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(59, 20)
        Me.TextBox9.TabIndex = 30
        '
        'grpCurrLoc
        '
        Me.grpCurrLoc.Controls.Add(Me.Label12)
        Me.grpCurrLoc.Controls.Add(Me.txtCurrLoc)
        Me.grpCurrLoc.Location = New System.Drawing.Point(182, -1)
        Me.grpCurrLoc.Name = "grpCurrLoc"
        Me.grpCurrLoc.Size = New System.Drawing.Size(429, 32)
        Me.grpCurrLoc.TabIndex = 44
        Me.grpCurrLoc.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 15)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Location"
        '
        'txtCurrLoc
        '
        Me.txtCurrLoc.BackColor = System.Drawing.SystemColors.Control
        Me.txtCurrLoc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCurrLoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCurrLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrLoc.Location = New System.Drawing.Point(207, 12)
        Me.txtCurrLoc.Name = "txtCurrLoc"
        Me.txtCurrLoc.Size = New System.Drawing.Size(206, 15)
        Me.txtCurrLoc.TabIndex = 35
        Me.txtCurrLoc.Text = "TANGO 1"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(588, 138)
        Me.DataGridView1.TabIndex = 45
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 13)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "Nominal Role"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(386, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "User"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Maroon
        Me.lblUser.Location = New System.Drawing.Point(421, 33)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(39, 13)
        Me.lblUser.TabIndex = 51
        Me.lblUser.Text = "Name"
        '
        'tmrEvents
        '
        Me.tmrEvents.Enabled = True
        Me.tmrEvents.Interval = 1000
        '
        'grpClock
        '
        Me.grpClock.Controls.Add(Me.LabMs)
        Me.grpClock.Controls.Add(Me.labSecs)
        Me.grpClock.Controls.Add(Me.lblClock)
        Me.grpClock.Location = New System.Drawing.Point(937, 2)
        Me.grpClock.Name = "grpClock"
        Me.grpClock.Size = New System.Drawing.Size(113, 38)
        Me.grpClock.TabIndex = 54
        Me.grpClock.TabStop = False
        '
        'LabMs
        '
        Me.LabMs.AutoSize = True
        Me.LabMs.Font = New System.Drawing.Font("Engravers MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMs.ForeColor = System.Drawing.Color.Black
        Me.LabMs.Location = New System.Drawing.Point(81, 14)
        Me.LabMs.Name = "LabMs"
        Me.LabMs.Size = New System.Drawing.Size(25, 14)
        Me.LabMs.TabIndex = 56
        Me.LabMs.Text = "33"
        '
        'labSecs
        '
        Me.labSecs.AutoSize = True
        Me.labSecs.Font = New System.Drawing.Font("Engravers MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labSecs.ForeColor = System.Drawing.Color.DarkRed
        Me.labSecs.Location = New System.Drawing.Point(55, 11)
        Me.labSecs.Name = "labSecs"
        Me.labSecs.Size = New System.Drawing.Size(30, 17)
        Me.labSecs.TabIndex = 55
        Me.labSecs.Text = "33"
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblClock.Location = New System.Drawing.Point(11, 10)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(49, 19)
        Me.lblClock.TabIndex = 54
        Me.lblClock.Text = "3:33"
        '
        'tmrMS
        '
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(944, 167)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 55
        '
        'MovementSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 571)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.grpClock)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.grpCurrLoc)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.labTime)
        Me.Controls.Add(Me.labDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMoveID)
        Me.Name = "MovementSystem"
        Me.Text = "MovementSystem"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCurrLoc.ResumeLayout(False)
        Me.grpCurrLoc.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpClock.ResumeLayout(False)
        Me.grpClock.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents CheckedListBox2 As CheckedListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents labTime As Label
    Friend WithEvents labDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMoveID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents grpCurrLoc As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCurrLoc As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents tmrEvents As Timer
    Friend WithEvents grpClock As GroupBox
    Friend WithEvents labSecs As Label
    Friend WithEvents lblClock As Label
    Friend WithEvents tmrMS As Timer
    Friend WithEvents LabMs As Label
    Friend WithEvents TextBox1 As TextBox
End Class
