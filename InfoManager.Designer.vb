<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InfoManager))
        Me.lstPrograms = New System.Windows.Forms.ListBox()
        Me.txtData1 = New System.Windows.Forms.TextBox()
        Me.lblData1 = New System.Windows.Forms.Label()
        Me.lblButton1 = New System.Windows.Forms.Label()
        Me.cbxButton1 = New System.Windows.Forms.ComboBox()
        Me.txtButton1 = New System.Windows.Forms.TextBox()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.chkMultiLine = New System.Windows.Forms.CheckBox()
        Me.txtButton2 = New System.Windows.Forms.TextBox()
        Me.cbxButton2 = New System.Windows.Forms.ComboBox()
        Me.lblButton2 = New System.Windows.Forms.Label()
        Me.lblData2 = New System.Windows.Forms.Label()
        Me.txtData2 = New System.Windows.Forms.TextBox()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.StatusStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lnkHelp = New System.Windows.Forms.LinkLabel()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstPrograms
        '
        Me.lstPrograms.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstPrograms.FormattingEnabled = True
        Me.lstPrograms.IntegralHeight = False
        Me.lstPrograms.Items.AddRange(New Object() {"Program1", "Program2", "Program3", "Program4", "Program5", "Program6", "Program7", "Program8", "Program9", "Add..."})
        Me.lstPrograms.Location = New System.Drawing.Point(12, 12)
        Me.lstPrograms.Name = "lstPrograms"
        Me.lstPrograms.Size = New System.Drawing.Size(120, 253)
        Me.lstPrograms.TabIndex = 0
        '
        'txtData1
        '
        Me.txtData1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtData1.Enabled = False
        Me.txtData1.Location = New System.Drawing.Point(138, 51)
        Me.txtData1.Name = "txtData1"
        Me.txtData1.Size = New System.Drawing.Size(134, 20)
        Me.txtData1.TabIndex = 1
        '
        'lblData1
        '
        Me.lblData1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblData1.AutoSize = True
        Me.lblData1.Enabled = False
        Me.lblData1.Location = New System.Drawing.Point(138, 35)
        Me.lblData1.Name = "lblData1"
        Me.lblData1.Size = New System.Drawing.Size(33, 13)
        Me.lblData1.TabIndex = 2
        Me.lblData1.Text = "Data:"
        '
        'lblButton1
        '
        Me.lblButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblButton1.AutoSize = True
        Me.lblButton1.Enabled = False
        Me.lblButton1.Location = New System.Drawing.Point(138, 74)
        Me.lblButton1.Name = "lblButton1"
        Me.lblButton1.Size = New System.Drawing.Size(81, 13)
        Me.lblButton1.TabIndex = 3
        Me.lblButton1.Text = "Button to press:"
        '
        'cbxButton1
        '
        Me.cbxButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxButton1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxButton1.Enabled = False
        Me.cbxButton1.FormattingEnabled = True
        Me.cbxButton1.Items.AddRange(New Object() {"Enter", "Tab", "Space", "Down Arrow", "Right Arrow", "Custom..."})
        Me.cbxButton1.Location = New System.Drawing.Point(138, 90)
        Me.cbxButton1.Name = "cbxButton1"
        Me.cbxButton1.Size = New System.Drawing.Size(134, 21)
        Me.cbxButton1.TabIndex = 4
        '
        'txtButton1
        '
        Me.txtButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtButton1.Enabled = False
        Me.txtButton1.Location = New System.Drawing.Point(138, 117)
        Me.txtButton1.Name = "txtButton1"
        Me.txtButton1.Size = New System.Drawing.Size(134, 20)
        Me.txtButton1.TabIndex = 5
        '
        'btnRun
        '
        Me.btnRun.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRun.Enabled = False
        Me.btnRun.Location = New System.Drawing.Point(93, 271)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(98, 23)
        Me.btnRun.TabIndex = 6
        Me.btnRun.Text = "Run..."
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnd.Location = New System.Drawing.Point(197, 271)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 7
        Me.btnEnd.Text = "Exit"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(12, 271)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'chkMultiLine
        '
        Me.chkMultiLine.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkMultiLine.AutoSize = True
        Me.chkMultiLine.Enabled = False
        Me.chkMultiLine.Location = New System.Drawing.Point(138, 143)
        Me.chkMultiLine.Name = "chkMultiLine"
        Me.chkMultiLine.Size = New System.Drawing.Size(71, 17)
        Me.chkMultiLine.TabIndex = 9
        Me.chkMultiLine.Text = "Two lines"
        Me.chkMultiLine.UseVisualStyleBackColor = True
        '
        'txtButton2
        '
        Me.txtButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtButton2.Enabled = False
        Me.txtButton2.Location = New System.Drawing.Point(138, 245)
        Me.txtButton2.Name = "txtButton2"
        Me.txtButton2.Size = New System.Drawing.Size(134, 20)
        Me.txtButton2.TabIndex = 14
        '
        'cbxButton2
        '
        Me.cbxButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxButton2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxButton2.Enabled = False
        Me.cbxButton2.FormattingEnabled = True
        Me.cbxButton2.Items.AddRange(New Object() {"Enter", "Tab", "Space", "Down Arrow", "Right Arrow", "Custom..."})
        Me.cbxButton2.Location = New System.Drawing.Point(138, 218)
        Me.cbxButton2.Name = "cbxButton2"
        Me.cbxButton2.Size = New System.Drawing.Size(134, 21)
        Me.cbxButton2.TabIndex = 13
        '
        'lblButton2
        '
        Me.lblButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblButton2.AutoSize = True
        Me.lblButton2.Enabled = False
        Me.lblButton2.Location = New System.Drawing.Point(138, 202)
        Me.lblButton2.Name = "lblButton2"
        Me.lblButton2.Size = New System.Drawing.Size(81, 13)
        Me.lblButton2.TabIndex = 12
        Me.lblButton2.Text = "Button to press:"
        '
        'lblData2
        '
        Me.lblData2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblData2.AutoSize = True
        Me.lblData2.Enabled = False
        Me.lblData2.Location = New System.Drawing.Point(138, 163)
        Me.lblData2.Name = "lblData2"
        Me.lblData2.Size = New System.Drawing.Size(33, 13)
        Me.lblData2.TabIndex = 11
        Me.lblData2.Text = "Data:"
        '
        'txtData2
        '
        Me.txtData2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtData2.Enabled = False
        Me.txtData2.Location = New System.Drawing.Point(138, 179)
        Me.txtData2.Name = "txtData2"
        Me.txtData2.Size = New System.Drawing.Size(134, 20)
        Me.txtData2.TabIndex = 10
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 297)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(284, 22)
        Me.StatusStrip.TabIndex = 15
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'StatusStripStatusLabel
        '
        Me.StatusStripStatusLabel.Name = "StatusStripStatusLabel"
        Me.StatusStripStatusLabel.Size = New System.Drawing.Size(146, 17)
        Me.StatusStripStatusLabel.Text = "Select an item to start..."
        Me.StatusStripStatusLabel.ToolTipText = "Status"
        '
        'txtName
        '
        Me.txtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(138, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(134, 20)
        Me.txtName.TabIndex = 16
        '
        'lnkHelp
        '
        Me.lnkHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkHelp.AutoSize = True
        Me.lnkHelp.Enabled = False
        Me.lnkHelp.Location = New System.Drawing.Point(195, 135)
        Me.lnkHelp.Name = "lnkHelp"
        Me.lnkHelp.Size = New System.Drawing.Size(93, 13)
        Me.lnkHelp.TabIndex = 17
        Me.lnkHelp.TabStop = True
        Me.lnkHelp.Text = "Custom Keys Help"
        '
        'InfoManager
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnEnd
        Me.ClientSize = New System.Drawing.Size(284, 319)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.txtButton2)
        Me.Controls.Add(Me.cbxButton2)
        Me.Controls.Add(Me.lblButton2)
        Me.Controls.Add(Me.lblData2)
        Me.Controls.Add(Me.txtData2)
        Me.Controls.Add(Me.txtButton1)
        Me.Controls.Add(Me.cbxButton1)
        Me.Controls.Add(Me.lblButton1)
        Me.Controls.Add(Me.lblData1)
        Me.Controls.Add(Me.txtData1)
        Me.Controls.Add(Me.lstPrograms)
        Me.Controls.Add(Me.lnkHelp)
        Me.Controls.Add(Me.chkMultiLine)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InfoManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InfoManager"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstPrograms As System.Windows.Forms.ListBox
    Friend WithEvents txtData1 As System.Windows.Forms.TextBox
    Friend WithEvents lblData1 As System.Windows.Forms.Label
    Friend WithEvents lblButton1 As System.Windows.Forms.Label
    Friend WithEvents cbxButton1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtButton1 As System.Windows.Forms.TextBox
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents chkMultiLine As System.Windows.Forms.CheckBox
    Friend WithEvents txtButton2 As System.Windows.Forms.TextBox
    Friend WithEvents cbxButton2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblButton2 As System.Windows.Forms.Label
    Friend WithEvents lblData2 As System.Windows.Forms.Label
    Friend WithEvents txtData2 As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lnkHelp As System.Windows.Forms.LinkLabel

End Class
