<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssignLocale
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboLoc = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.DataSet1 = New MoveTrackerWinApp.DataSet1()
        Me.LocationparentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Location_parentTableAdapter = New MoveTrackerWinApp.DataSet1TableAdapters.location_parentTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationparentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnOk)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboLoc)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 102)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cboLoc
        '
        Me.cboLoc.DataSource = Me.LocationparentBindingSource
        Me.cboLoc.DisplayMember = "tango"
        Me.cboLoc.FormattingEnabled = True
        Me.cboLoc.Location = New System.Drawing.Point(30, 32)
        Me.cboLoc.Name = "cboLoc"
        Me.cboLoc.Size = New System.Drawing.Size(202, 21)
        Me.cboLoc.TabIndex = 0
        Me.cboLoc.ValueMember = "location_parent_id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Location To Assign This Computer"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(33, 60)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LocationparentBindingSource
        '
        Me.LocationparentBindingSource.DataMember = "location_parent"
        Me.LocationparentBindingSource.DataSource = Me.DataSet1
        '
        'Location_parentTableAdapter
        '
        Me.Location_parentTableAdapter.ClearBeforeFill = True
        '
        'frmAssignLocale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 135)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAssignLocale"
        Me.Text = "Assign Location"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationparentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnOk As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboLoc As ComboBox
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents LocationparentBindingSource As BindingSource
    Friend WithEvents Location_parentTableAdapter As DataSet1TableAdapters.location_parentTableAdapter
End Class
