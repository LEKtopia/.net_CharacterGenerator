<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFrm
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblRace = New System.Windows.Forms.Label()
        Me.cbxSelectRace = New System.Windows.Forms.ComboBox()
        Me.gbxStats = New System.Windows.Forms.GroupBox()
        Me.lblDisplayCHA = New System.Windows.Forms.Label()
        Me.lblDisplaySNS = New System.Windows.Forms.Label()
        Me.lblDisplayWIL = New System.Windows.Forms.Label()
        Me.lblDisplayWIT = New System.Windows.Forms.Label()
        Me.lblDisplayAGI = New System.Windows.Forms.Label()
        Me.lblDisplaySTR = New System.Windows.Forms.Label()
        Me.lblCHA = New System.Windows.Forms.Label()
        Me.lblSNS = New System.Windows.Forms.Label()
        Me.lblWIL = New System.Windows.Forms.Label()
        Me.lblWIT = New System.Windows.Forms.Label()
        Me.lblAGI = New System.Windows.Forms.Label()
        Me.lblSTR = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.gbxStats.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(55, 20)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(73, 6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(163, 26)
        Me.txtName.TabIndex = 1
        '
        'lblRace
        '
        Me.lblRace.AutoSize = True
        Me.lblRace.Location = New System.Drawing.Point(12, 44)
        Me.lblRace.Name = "lblRace"
        Me.lblRace.Size = New System.Drawing.Size(100, 20)
        Me.lblRace.TabIndex = 2
        Me.lblRace.Text = "Select Race:"
        '
        'cbxSelectRace
        '
        Me.cbxSelectRace.FormattingEnabled = True
        Me.cbxSelectRace.Items.AddRange(New Object() {"Human", "Elf", "Dwarf", "Gnome"})
        Me.cbxSelectRace.Location = New System.Drawing.Point(119, 39)
        Me.cbxSelectRace.Name = "cbxSelectRace"
        Me.cbxSelectRace.Size = New System.Drawing.Size(117, 28)
        Me.cbxSelectRace.TabIndex = 3
        Me.cbxSelectRace.Text = "Human"
        '
        'gbxStats
        '
        Me.gbxStats.Controls.Add(Me.lblDisplayCHA)
        Me.gbxStats.Controls.Add(Me.lblDisplaySNS)
        Me.gbxStats.Controls.Add(Me.lblDisplayWIL)
        Me.gbxStats.Controls.Add(Me.lblDisplayWIT)
        Me.gbxStats.Controls.Add(Me.lblDisplayAGI)
        Me.gbxStats.Controls.Add(Me.lblDisplaySTR)
        Me.gbxStats.Controls.Add(Me.lblCHA)
        Me.gbxStats.Controls.Add(Me.lblSNS)
        Me.gbxStats.Controls.Add(Me.lblWIL)
        Me.gbxStats.Controls.Add(Me.lblWIT)
        Me.gbxStats.Controls.Add(Me.lblAGI)
        Me.gbxStats.Controls.Add(Me.lblSTR)
        Me.gbxStats.Location = New System.Drawing.Point(12, 73)
        Me.gbxStats.Name = "gbxStats"
        Me.gbxStats.Size = New System.Drawing.Size(223, 220)
        Me.gbxStats.TabIndex = 4
        Me.gbxStats.TabStop = False
        Me.gbxStats.Text = "Character Stats"
        '
        'lblDisplayCHA
        '
        Me.lblDisplayCHA.AutoSize = True
        Me.lblDisplayCHA.Location = New System.Drawing.Point(57, 181)
        Me.lblDisplayCHA.Name = "lblDisplayCHA"
        Me.lblDisplayCHA.Size = New System.Drawing.Size(15, 20)
        Me.lblDisplayCHA.TabIndex = 16
        Me.lblDisplayCHA.Text = "*"
        '
        'lblDisplaySNS
        '
        Me.lblDisplaySNS.AutoSize = True
        Me.lblDisplaySNS.Location = New System.Drawing.Point(57, 152)
        Me.lblDisplaySNS.Name = "lblDisplaySNS"
        Me.lblDisplaySNS.Size = New System.Drawing.Size(15, 20)
        Me.lblDisplaySNS.TabIndex = 15
        Me.lblDisplaySNS.Text = "*"
        '
        'lblDisplayWIL
        '
        Me.lblDisplayWIL.AutoSize = True
        Me.lblDisplayWIL.Location = New System.Drawing.Point(57, 123)
        Me.lblDisplayWIL.Name = "lblDisplayWIL"
        Me.lblDisplayWIL.Size = New System.Drawing.Size(15, 20)
        Me.lblDisplayWIL.TabIndex = 14
        Me.lblDisplayWIL.Text = "*"
        '
        'lblDisplayWIT
        '
        Me.lblDisplayWIT.AutoSize = True
        Me.lblDisplayWIT.Location = New System.Drawing.Point(57, 93)
        Me.lblDisplayWIT.Name = "lblDisplayWIT"
        Me.lblDisplayWIT.Size = New System.Drawing.Size(15, 20)
        Me.lblDisplayWIT.TabIndex = 13
        Me.lblDisplayWIT.Text = "*"
        '
        'lblDisplayAGI
        '
        Me.lblDisplayAGI.AutoSize = True
        Me.lblDisplayAGI.Location = New System.Drawing.Point(57, 63)
        Me.lblDisplayAGI.Name = "lblDisplayAGI"
        Me.lblDisplayAGI.Size = New System.Drawing.Size(15, 20)
        Me.lblDisplayAGI.TabIndex = 12
        Me.lblDisplayAGI.Text = "*"
        '
        'lblDisplaySTR
        '
        Me.lblDisplaySTR.AutoSize = True
        Me.lblDisplaySTR.Location = New System.Drawing.Point(57, 34)
        Me.lblDisplaySTR.Name = "lblDisplaySTR"
        Me.lblDisplaySTR.Size = New System.Drawing.Size(15, 20)
        Me.lblDisplaySTR.TabIndex = 11
        Me.lblDisplaySTR.Text = "*"
        '
        'lblCHA
        '
        Me.lblCHA.AutoSize = True
        Me.lblCHA.Location = New System.Drawing.Point(4, 181)
        Me.lblCHA.Name = "lblCHA"
        Me.lblCHA.Size = New System.Drawing.Size(47, 20)
        Me.lblCHA.TabIndex = 10
        Me.lblCHA.Text = "CHA:"
        '
        'lblSNS
        '
        Me.lblSNS.AutoSize = True
        Me.lblSNS.Location = New System.Drawing.Point(5, 152)
        Me.lblSNS.Name = "lblSNS"
        Me.lblSNS.Size = New System.Drawing.Size(46, 20)
        Me.lblSNS.TabIndex = 9
        Me.lblSNS.Text = "SNS:"
        '
        'lblWIL
        '
        Me.lblWIL.AutoSize = True
        Me.lblWIL.Location = New System.Drawing.Point(9, 123)
        Me.lblWIL.Name = "lblWIL"
        Me.lblWIL.Size = New System.Drawing.Size(42, 20)
        Me.lblWIL.TabIndex = 8
        Me.lblWIL.Text = "WIL:"
        '
        'lblWIT
        '
        Me.lblWIT.AutoSize = True
        Me.lblWIT.Location = New System.Drawing.Point(9, 93)
        Me.lblWIT.Name = "lblWIT"
        Me.lblWIT.Size = New System.Drawing.Size(42, 20)
        Me.lblWIT.TabIndex = 7
        Me.lblWIT.Text = "WIT:"
        '
        'lblAGI
        '
        Me.lblAGI.AutoSize = True
        Me.lblAGI.Location = New System.Drawing.Point(9, 63)
        Me.lblAGI.Name = "lblAGI"
        Me.lblAGI.Size = New System.Drawing.Size(42, 20)
        Me.lblAGI.TabIndex = 6
        Me.lblAGI.Text = "AGI:"
        '
        'lblSTR
        '
        Me.lblSTR.AutoSize = True
        Me.lblSTR.Location = New System.Drawing.Point(6, 34)
        Me.lblSTR.Name = "lblSTR"
        Me.lblSTR.Size = New System.Drawing.Size(45, 20)
        Me.lblSTR.TabIndex = 5
        Me.lblSTR.Text = "STR:"
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(12, 300)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(223, 53)
        Me.btnGenerate.TabIndex = 5
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 369)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.gbxStats)
        Me.Controls.Add(Me.cbxSelectRace)
        Me.Controls.Add(Me.lblRace)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "MainFrm"
        Me.Text = "Character Generator"
        Me.gbxStats.ResumeLayout(False)
        Me.gbxStats.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblRace As Label
    Friend WithEvents cbxSelectRace As ComboBox
    Friend WithEvents gbxStats As GroupBox
    Friend WithEvents lblDisplayCHA As Label
    Friend WithEvents lblDisplaySNS As Label
    Friend WithEvents lblDisplayWIL As Label
    Friend WithEvents lblDisplayWIT As Label
    Friend WithEvents lblDisplayAGI As Label
    Friend WithEvents lblDisplaySTR As Label
    Friend WithEvents lblCHA As Label
    Friend WithEvents lblSNS As Label
    Friend WithEvents lblWIL As Label
    Friend WithEvents lblWIT As Label
    Friend WithEvents lblAGI As Label
    Friend WithEvents lblSTR As Label
    Friend WithEvents btnGenerate As Button
End Class
