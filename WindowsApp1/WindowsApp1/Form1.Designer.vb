<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.AthletesTab = New System.Windows.Forms.TabPage()
        Me.RaceTab = New System.Windows.Forms.TabPage()
        Me.ResultsTab = New System.Windows.Forms.TabPage()
        Me.Lane10RB = New System.Windows.Forms.RadioButton()
        Me.Lane9RB = New System.Windows.Forms.RadioButton()
        Me.Lane8RB = New System.Windows.Forms.RadioButton()
        Me.Lane7RB = New System.Windows.Forms.RadioButton()
        Me.Lane6RB = New System.Windows.Forms.RadioButton()
        Me.Lane5RB = New System.Windows.Forms.RadioButton()
        Me.Lane4RB = New System.Windows.Forms.RadioButton()
        Me.Lane3RB = New System.Windows.Forms.RadioButton()
        Me.Lane2RB = New System.Windows.Forms.RadioButton()
        Me.Lane1RB = New System.Windows.Forms.RadioButton()
        Me.LaneControlBox = New System.Windows.Forms.GroupBox()
        Me.TabControl1.SuspendLayout()
        Me.AthletesTab.SuspendLayout()
        Me.LaneControlBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.AllowDrop = True
        Me.TabControl1.Controls.Add(Me.AthletesTab)
        Me.TabControl1.Controls.Add(Me.RaceTab)
        Me.TabControl1.Controls.Add(Me.ResultsTab)
        Me.TabControl1.Location = New System.Drawing.Point(0, 12)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(573, 468)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'AthletesTab
        '
        Me.AthletesTab.BackColor = System.Drawing.SystemColors.Window
        Me.AthletesTab.Controls.Add(Me.LaneControlBox)
        Me.AthletesTab.Location = New System.Drawing.Point(4, 22)
        Me.AthletesTab.Name = "AthletesTab"
        Me.AthletesTab.Padding = New System.Windows.Forms.Padding(3)
        Me.AthletesTab.Size = New System.Drawing.Size(565, 442)
        Me.AthletesTab.TabIndex = 0
        Me.AthletesTab.Text = "Athletes"
        '
        'RaceTab
        '
        Me.RaceTab.Location = New System.Drawing.Point(4, 22)
        Me.RaceTab.Name = "RaceTab"
        Me.RaceTab.Padding = New System.Windows.Forms.Padding(3)
        Me.RaceTab.Size = New System.Drawing.Size(565, 442)
        Me.RaceTab.TabIndex = 1
        Me.RaceTab.Text = "Race"
        Me.RaceTab.UseVisualStyleBackColor = True
        '
        'ResultsTab
        '
        Me.ResultsTab.Location = New System.Drawing.Point(4, 22)
        Me.ResultsTab.Name = "ResultsTab"
        Me.ResultsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ResultsTab.Size = New System.Drawing.Size(565, 442)
        Me.ResultsTab.TabIndex = 2
        Me.ResultsTab.Text = "Results"
        Me.ResultsTab.UseVisualStyleBackColor = True
        '
        'Lane10RB
        '
        Me.Lane10RB.AutoSize = True
        Me.Lane10RB.Location = New System.Drawing.Point(431, 57)
        Me.Lane10RB.Name = "Lane10RB"
        Me.Lane10RB.Size = New System.Drawing.Size(37, 17)
        Me.Lane10RB.TabIndex = 19
        Me.Lane10RB.TabStop = True
        Me.Lane10RB.Text = "10"
        Me.Lane10RB.UseVisualStyleBackColor = True
        '
        'Lane9RB
        '
        Me.Lane9RB.AutoSize = True
        Me.Lane9RB.Location = New System.Drawing.Point(346, 57)
        Me.Lane9RB.Name = "Lane9RB"
        Me.Lane9RB.Size = New System.Drawing.Size(31, 17)
        Me.Lane9RB.TabIndex = 18
        Me.Lane9RB.TabStop = True
        Me.Lane9RB.Text = "9"
        Me.Lane9RB.UseVisualStyleBackColor = True
        '
        'Lane8RB
        '
        Me.Lane8RB.AutoSize = True
        Me.Lane8RB.Location = New System.Drawing.Point(261, 57)
        Me.Lane8RB.Name = "Lane8RB"
        Me.Lane8RB.Size = New System.Drawing.Size(31, 17)
        Me.Lane8RB.TabIndex = 17
        Me.Lane8RB.TabStop = True
        Me.Lane8RB.Text = "8"
        Me.Lane8RB.UseVisualStyleBackColor = True
        '
        'Lane7RB
        '
        Me.Lane7RB.AutoSize = True
        Me.Lane7RB.Location = New System.Drawing.Point(176, 57)
        Me.Lane7RB.Name = "Lane7RB"
        Me.Lane7RB.Size = New System.Drawing.Size(31, 17)
        Me.Lane7RB.TabIndex = 16
        Me.Lane7RB.TabStop = True
        Me.Lane7RB.Text = "7"
        Me.Lane7RB.UseVisualStyleBackColor = True
        '
        'Lane6RB
        '
        Me.Lane6RB.AutoSize = True
        Me.Lane6RB.Location = New System.Drawing.Point(91, 57)
        Me.Lane6RB.Name = "Lane6RB"
        Me.Lane6RB.Size = New System.Drawing.Size(31, 17)
        Me.Lane6RB.TabIndex = 15
        Me.Lane6RB.TabStop = True
        Me.Lane6RB.Text = "6"
        Me.Lane6RB.UseVisualStyleBackColor = True
        '
        'Lane5RB
        '
        Me.Lane5RB.AutoSize = True
        Me.Lane5RB.Location = New System.Drawing.Point(431, 20)
        Me.Lane5RB.Name = "Lane5RB"
        Me.Lane5RB.Size = New System.Drawing.Size(31, 17)
        Me.Lane5RB.TabIndex = 14
        Me.Lane5RB.TabStop = True
        Me.Lane5RB.Text = "5"
        Me.Lane5RB.UseVisualStyleBackColor = True
        '
        'Lane4RB
        '
        Me.Lane4RB.AutoSize = True
        Me.Lane4RB.Location = New System.Drawing.Point(346, 20)
        Me.Lane4RB.Name = "Lane4RB"
        Me.Lane4RB.Size = New System.Drawing.Size(31, 17)
        Me.Lane4RB.TabIndex = 13
        Me.Lane4RB.TabStop = True
        Me.Lane4RB.Text = "4"
        Me.Lane4RB.UseVisualStyleBackColor = True
        '
        'Lane3RB
        '
        Me.Lane3RB.AutoSize = True
        Me.Lane3RB.Location = New System.Drawing.Point(261, 20)
        Me.Lane3RB.Name = "Lane3RB"
        Me.Lane3RB.Size = New System.Drawing.Size(31, 17)
        Me.Lane3RB.TabIndex = 12
        Me.Lane3RB.TabStop = True
        Me.Lane3RB.Text = "3"
        Me.Lane3RB.UseVisualStyleBackColor = True
        '
        'Lane2RB
        '
        Me.Lane2RB.AutoSize = True
        Me.Lane2RB.Location = New System.Drawing.Point(176, 20)
        Me.Lane2RB.Name = "Lane2RB"
        Me.Lane2RB.Size = New System.Drawing.Size(31, 17)
        Me.Lane2RB.TabIndex = 11
        Me.Lane2RB.TabStop = True
        Me.Lane2RB.Text = "2"
        Me.Lane2RB.UseVisualStyleBackColor = True
        '
        'Lane1RB
        '
        Me.Lane1RB.AutoSize = True
        Me.Lane1RB.Location = New System.Drawing.Point(91, 20)
        Me.Lane1RB.Name = "Lane1RB"
        Me.Lane1RB.Size = New System.Drawing.Size(31, 17)
        Me.Lane1RB.TabIndex = 10
        Me.Lane1RB.TabStop = True
        Me.Lane1RB.Text = "1"
        Me.Lane1RB.UseVisualStyleBackColor = True
        '
        'LaneControlBox
        '
        Me.LaneControlBox.Controls.Add(Me.Lane1RB)
        Me.LaneControlBox.Controls.Add(Me.Lane10RB)
        Me.LaneControlBox.Controls.Add(Me.Lane2RB)
        Me.LaneControlBox.Controls.Add(Me.Lane9RB)
        Me.LaneControlBox.Controls.Add(Me.Lane3RB)
        Me.LaneControlBox.Controls.Add(Me.Lane8RB)
        Me.LaneControlBox.Controls.Add(Me.Lane4RB)
        Me.LaneControlBox.Controls.Add(Me.Lane7RB)
        Me.LaneControlBox.Controls.Add(Me.Lane5RB)
        Me.LaneControlBox.Controls.Add(Me.Lane6RB)
        Me.LaneControlBox.Location = New System.Drawing.Point(6, 6)
        Me.LaneControlBox.Name = "LaneControlBox"
        Me.LaneControlBox.Size = New System.Drawing.Size(552, 95)
        Me.LaneControlBox.TabIndex = 20
        Me.LaneControlBox.TabStop = False
        Me.LaneControlBox.Text = "Number of Lanes"
        Me.LaneControlBox.UseCompatibleTextRendering = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(574, 480)
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.AthletesTab.ResumeLayout(False)
        Me.LaneControlBox.ResumeLayout(False)
        Me.LaneControlBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private Sub LaneRB_Click(sender As Object, e As EventArgs) Handles Lane1RB.Click, Lane2RB.Click, Lane3RB.Click, Lane4RB.Click, Lane5RB.Click, Lane6RB.Click, Lane7RB.Click, Lane8RB.Click, Lane9RB.Click, Lane10RB.Click


    End Sub

    Friend WithEvents AthletesTab As TabPage
    Friend WithEvents RaceTab As TabPage
    Friend WithEvents ResultsTab As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents LaneControlBox As GroupBox
    Friend WithEvents Lane1RB As RadioButton
    Friend WithEvents Lane10RB As RadioButton
    Friend WithEvents Lane2RB As RadioButton
    Friend WithEvents Lane9RB As RadioButton
    Friend WithEvents Lane3RB As RadioButton
    Friend WithEvents Lane8RB As RadioButton
    Friend WithEvents Lane4RB As RadioButton
    Friend WithEvents Lane7RB As RadioButton
    Friend WithEvents Lane5RB As RadioButton
    Friend WithEvents Lane6RB As RadioButton
End Class
