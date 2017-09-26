<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.LaneNum = New System.Windows.Forms.Label()
        Me.RacerName = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'LaneNum
        '
        Me.LaneNum.AutoSize = True
        Me.LaneNum.Location = New System.Drawing.Point(17, 22)
        Me.LaneNum.Name = "LaneNum"
        Me.LaneNum.Size = New System.Drawing.Size(31, 13)
        Me.LaneNum.TabIndex = 0
        Me.LaneNum.Text = "Lane"
        '
        'RacerName
        '
        Me.RacerName.Location = New System.Drawing.Point(71, 19)
        Me.RacerName.Name = "RacerName"
        Me.RacerName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RacerName.Size = New System.Drawing.Size(204, 20)
        Me.RacerName.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Argentina", "Canada", "China", "Jamaica", "Russia", "UK"})
        Me.ListBox1.Location = New System.Drawing.Point(281, 22)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(168, 17)
        Me.ListBox1.TabIndex = 2
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.RacerName)
        Me.Controls.Add(Me.LaneNum)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(472, 57)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LaneNum As Label
    Friend WithEvents RacerName As TextBox
    Friend WithEvents ListBox1 As ListBox
End Class
