Imports Microsoft.VisualBasic

Public Class InfoManager
    
    Dim ExitWhenDone As Boolean = False
    
    Private Sub InfoManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxButton1.SelectedIndex = 0
        cbxButton2.SelectedIndex = 0
        SetListNames
        
        For Each s As String In My.Application.CommandLineArgs
            If s.ToLower = "exitwhendone" Then
                ExitWhenDone = True
            ElseIf s.StartsWith("run") Then
                Try
                    lstPrograms.SelectedIndex = (s.Substring(4) -1)
                    Run
                Catch
                    If Not s.Length > 4 Then
                        MsgBox("Parameter too short! Please use the syntax 'run:1'.", MsgBoxStyle.Exclamation)
                    Else
                        Try
                            MsgBox("""" & s.Substring(4) & """ is not a valid integer or doesn't exist in the list!", MsgBoxStyle.Exclamation)
                        Catch ex As Exception
                            MsgBox("""" & s.ToString & """ can't be evaluated! Please use the syntax 'InfoManager.exe run:1'." _
                                   & vbNewLine & vbNewLine & "The error was:" & vbNewLine & ex.Message, MsgBoxStyle.Exclamation)
                        End Try
                    End If
                End Try
            Else
                MsgBox("Unknown parameter '" & s & "'. Available parameters are:" & vbNewLine & vbNewLine & _
                       "ExitWhenDone" & vbNewLine & "run:[script number]", MsgBoxStyle.Exclamation)
            End If
        Next
    End Sub

    Private Sub lstPrograms_SelectedIndexChanged(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles lstPrograms.SelectedIndexChanged
        StatusStripStatusLabel.Text = "Loading item " & lstPrograms.SelectedIndex + 1 & "... (If this doesn't change within a few seconds, item hasn't been loaded correctly)"
        ResetGUI()
        Select Case lstPrograms.SelectedIndex + 1
            Case 1 'Program1
                txtName.Text = My.Settings.Program1.Item(0)
                txtData1.Text = My.Settings.Program1.Item(1)
                cbxButton1.SelectedItem = My.Settings.Program1.Item(2)
                txtButton1.Text = My.Settings.Program1.Item(3)
                cbxButton1_SelectedIndexChanged()
                chkMultiLine.Checked = My.Settings.Program1.Item(4)
                EnableGUI()
            Case 2 'Program2
                txtName.Text = My.Settings.Program2.Item(0)
                txtData1.Text = My.Settings.Program2.Item(1)
                cbxButton1.SelectedItem = My.Settings.Program2.Item(2)
                txtButton1.Text = My.Settings.Program2.Item(3)
                cbxButton1_SelectedIndexChanged()
                chkMultiLine.Checked = My.Settings.Program2.Item(4)
                EnableGUI()
            Case 3 'Program3
                txtName.Text = My.Settings.Program3.Item(0)
                txtData1.Text = My.Settings.Program3.Item(1)
                cbxButton1.SelectedItem = My.Settings.Program3.Item(2)
                txtButton1.Text = My.Settings.Program3.Item(3)
                cbxButton1_SelectedIndexChanged()
                chkMultiLine.Checked = My.Settings.Program3.Item(4)
                EnableGUI()
            Case 4 'Program4
                txtName.Text = My.Settings.Program4.Item(0)
                txtData1.Text = My.Settings.Program4.Item(1)
                cbxButton1.SelectedItem = My.Settings.Program4.Item(2)
                txtButton1.Text = My.Settings.Program4.Item(3)
                cbxButton1_SelectedIndexChanged()
                chkMultiLine.Checked = My.Settings.Program4.Item(4)
                EnableGUI()
            Case 5 'Program5
                txtName.Text = My.Settings.Program5.Item(0)
                txtData1.Text = My.Settings.Program5.Item(1)
                cbxButton1.SelectedItem = My.Settings.Program5.Item(2)
                txtButton1.Text = My.Settings.Program5.Item(3)
                cbxButton1_SelectedIndexChanged()
                chkMultiLine.Checked = My.Settings.Program5.Item(4)
                EnableGUI()
            Case 6 'Program6
                txtName.Text = My.Settings.Program6.Item(0)
                txtData1.Text = My.Settings.Program6.Item(1)
                cbxButton1.SelectedItem = My.Settings.Program6.Item(2)
                txtButton1.Text = My.Settings.Program6.Item(3)
                cbxButton1_SelectedIndexChanged()
                chkMultiLine.Checked = My.Settings.Program6.Item(4)
                EnableGUI()
            Case 7 'Program7
                txtName.Text = My.Settings.Program7.Item(0)
                txtData1.Text = My.Settings.Program7.Item(1)
                cbxButton1.SelectedItem = My.Settings.Program7.Item(2)
                txtButton1.Text = My.Settings.Program7.Item(3)
                cbxButton1_SelectedIndexChanged()
                chkMultiLine.Checked = My.Settings.Program7.Item(4)
                EnableGUI()
            Case 8 'Program8
                txtName.Text = My.Settings.Program8.Item(0)
                txtData1.Text = My.Settings.Program8.Item(1)
                cbxButton1.SelectedItem = My.Settings.Program8.Item(2)
                txtButton1.Text = My.Settings.Program8.Item(3)
                cbxButton1_SelectedIndexChanged()
                chkMultiLine.Checked = My.Settings.Program8.Item(4)
                EnableGUI()
            Case 9 'Program9
                txtName.Text = My.Settings.Program9.Item(0)
                txtData1.Text = My.Settings.Program9.Item(1)
                cbxButton1.SelectedItem = My.Settings.Program9.Item(2)
                txtButton1.Text = My.Settings.Program9.Item(3)
                cbxButton1_SelectedIndexChanged()
                chkMultiLine.Checked = My.Settings.Program9.Item(4)
                EnableGUI()
            Case 10 'Program0 (Extendable)
                txtName.Enabled = False
                lblData1.Enabled = False
                txtData1.Enabled = False
                lblButton1.Enabled = False
                cbxButton1.Enabled = False
                txtButton1.Enabled = False
                lnkHelp.Enabled = False
                chkMultiLine.Enabled = False
                lblData2.Enabled = False
                txtData2.Enabled = False
                lblButton2.Enabled = False
                cbxButton2.Enabled = False
                txtButton2.Enabled = False
                btnSave.Enabled = False
                btnRun.Enabled = False
                txtName.Text = My.Settings.Program0.Item(0)
                'txtData1.Text = My.Settings.Program0.Item(1)
                'cbxButton1.SelectedItem = My.Settings.Program0.Item(2)
                'txtButton1.Text = My.Settings.Program0.Item(3)
                'cbxButton1_SelectedIndexChanged()
                'chkMultiLine.Checked = My.Settings.Program0.Item(4)
            Case -1 'Nothing selected
                txtName.Enabled = False
                lblData1.Enabled = False
                txtData1.Enabled = False
                lblButton1.Enabled = False
                cbxButton1.Enabled = False
                txtButton1.Enabled = False
                lnkHelp.Enabled = False
                chkMultiLine.Enabled = False
                lblData2.Enabled = False
                txtData2.Enabled = False
                lblButton2.Enabled = False
                cbxButton2.Enabled = False
                txtButton2.Enabled = False
                btnSave.Enabled = False
                btnRun.Enabled = False
        End Select
        StatusStripStatusLabel.Text = "Item " & lstPrograms.SelectedIndex + 1 & " successfully loaded!"
    End Sub
    
    Sub ResetGUI()
        txtName.Text = ""
        txtData1.Text = ""
        cbxButton1.SelectedIndex = 0
        txtButton1.Text = "{}"
        chkMultiLine.Checked = False
        txtData2.Text = ""
        cbxButton2.SelectedIndex = 0
        txtButton2.Text = "{}"
    End Sub

    Sub EnableGUI()
        txtName.Enabled = True
        lblData1.Enabled = True
        txtData1.Enabled = True
        lblButton1.Enabled = True
        cbxButton1.Enabled = True
        cbxButton1_SelectedIndexChanged()
        chkMultiLine.Enabled = True
        chkMultiLine_CheckedChanged()
        btnSave.Enabled = True
        btnRun.Enabled = True
    End Sub
    
    Sub SetListNames
        lstPrograms.Items.Item(0) = My.Settings.Program1.Item(0)
        lstPrograms.Items.Item(1) = My.Settings.Program2.Item(0)
        lstPrograms.Items.Item(2) = My.Settings.Program3.Item(0)
        lstPrograms.Items.Item(3) = My.Settings.Program4.Item(0)
        lstPrograms.Items.Item(4) = My.Settings.Program5.Item(0)
        lstPrograms.Items.Item(5) = My.Settings.Program6.Item(0)
        lstPrograms.Items.Item(6) = My.Settings.Program7.Item(0)
        lstPrograms.Items.Item(7) = My.Settings.Program8.Item(0)
        lstPrograms.Items.Item(8) = My.Settings.Program9.Item(0)
    End Sub

    Private Sub Save() Handles btnSave.Click
        StatusStripStatusLabel.Text = "Saving item " & lstPrograms.SelectedIndex + 1 & "... (If this doesn't change within a few seconds, item hasn't been saved correctly)"
        Select Case lstPrograms.SelectedIndex + 1
            Case 1 'Program1
                My.Settings.Program1.Item(0) = txtName.Text
                My.Settings.Program1.Item(1) = txtData1.Text
                My.Settings.Program1.Item(2) = cbxButton1.SelectedItem
                My.Settings.Program1.Item(3) = txtButton1.Text
                My.Settings.Program1.Item(4) = chkMultiLine.Checked
            Case 2 'Program2
                My.Settings.Program2.Item(0) = txtName.Text
                My.Settings.Program2.Item(1) = txtData1.Text
                My.Settings.Program2.Item(2) = cbxButton1.SelectedItem
                My.Settings.Program2.Item(3) = txtButton1.Text
                My.Settings.Program2.Item(4) = chkMultiLine.Checked
            Case 3 'Program3
                My.Settings.Program3.Item(0) = txtName.Text
                My.Settings.Program3.Item(1) = txtData1.Text
                My.Settings.Program3.Item(2) = cbxButton1.SelectedItem
                My.Settings.Program3.Item(3) = txtButton1.Text
                My.Settings.Program3.Item(4) = chkMultiLine.Checked
            Case 4 'Program4
                My.Settings.Program4.Item(0) = txtName.Text
                My.Settings.Program4.Item(1) = txtData1.Text
                My.Settings.Program4.Item(2) = cbxButton1.SelectedItem
                My.Settings.Program4.Item(3) = txtButton1.Text
                My.Settings.Program4.Item(4) = chkMultiLine.Checked
            Case 5 'Program5
                My.Settings.Program5.Item(0) = txtName.Text
                My.Settings.Program5.Item(1) = txtData1.Text
                My.Settings.Program5.Item(2) = cbxButton1.SelectedItem
                My.Settings.Program5.Item(3) = txtButton1.Text
                My.Settings.Program5.Item(4) = chkMultiLine.Checked
            Case 6 'Program6
                My.Settings.Program6.Item(0) = txtName.Text
                My.Settings.Program6.Item(1) = txtData1.Text
                My.Settings.Program6.Item(2) = cbxButton1.SelectedItem
                My.Settings.Program6.Item(3) = txtButton1.Text
                My.Settings.Program6.Item(4) = chkMultiLine.Checked
            Case 7 'Program7
                My.Settings.Program7.Item(0) = txtName.Text
                My.Settings.Program7.Item(1) = txtData1.Text
                My.Settings.Program7.Item(2) = cbxButton1.SelectedItem
                My.Settings.Program7.Item(3) = txtButton1.Text
                My.Settings.Program7.Item(4) = chkMultiLine.Checked
            Case 8 'Program8
                My.Settings.Program8.Item(0) = txtName.Text
                My.Settings.Program8.Item(1) = txtData1.Text
                My.Settings.Program8.Item(2) = cbxButton1.SelectedItem
                My.Settings.Program8.Item(3) = txtButton1.Text
                My.Settings.Program8.Item(4) = chkMultiLine.Checked
            Case 9 'Program9
                My.Settings.Program9.Item(0) = txtName.Text
                My.Settings.Program9.Item(1) = txtData1.Text
                My.Settings.Program9.Item(2) = cbxButton1.SelectedItem
                My.Settings.Program9.Item(3) = txtButton1.Text
                My.Settings.Program9.Item(4) = chkMultiLine.Checked
            Case 10 'Program0 (Extendable)
                My.Settings.Program0.Item(0) = txtName.Text
                My.Settings.Program0.Item(1) = txtData1.Text
                My.Settings.Program0.Item(2) = cbxButton1.SelectedItem
                My.Settings.Program0.Item(3) = txtButton1.Text
                My.Settings.Program0.Item(4) = chkMultiLine.Checked
        End Select
        ' Old Code: (Doesn't work)
        ' CTypeDynamic("My.Settings." & lstPrograms.SelectedItem.ToString, System.Collections.Specialized.StringCollection).Item(0) = txtName.Text
        ' CTypeDynamic("My.Settings." & lstPrograms.SelectedItem.ToString, System.Collections.Specialized.StringCollection).Item(1) = txtData1.Text
        ' CTypeDynamic("My.Settings." & lstPrograms.SelectedItem.ToString, System.Collections.Specialized.StringCollection).Item(2) = cbxButton1.SelectedItem
        ' CTypeDynamic("My.Settings." & lstPrograms.SelectedItem.ToString, System.Collections.Specialized.StringCollection).Item(3) = txtButton1.Text
        ' CTypeDynamic("My.Settings." & lstPrograms.SelectedItem.ToString, My.Settings).Item(4) = chkMultiLine.Checked
        SetListNames
        StatusStripStatusLabel.Text = "Item " & lstPrograms.SelectedIndex + 1 & " successfully saved!"
    End Sub

    Private Sub Run() Handles btnRun.Click, lstPrograms.DoubleClick
        StatusStripStatusLabel.Text = "Running insert script " & lstPrograms.SelectedIndex + 1 & "..."
        Me.WindowState = FormWindowState.Minimized
        SendKeys.Send(txtData1.Text)
        Select Case cbxButton1.SelectedIndex
            Case 0 'Enter
                SendKeys.Send("~")
            Case 1 'Tab
                SendKeys.Send("{TAB}")
            Case 2 'Space
                SendKeys.Send(" ")
            Case 3 'Down Arrow
                SendKeys.Send("{DOWN}")
            Case 4 'Right Arrow
                SendKeys.Send("{RIGHT}")
            Case 5 'Custom...
                SendKeys.Send(txtButton1.Text)
        End Select
        If chkMultiLine.Checked Then
            SendKeys.Send(txtData2.Text)
            Select Case cbxButton2.SelectedIndex
                Case 0 'Enter
                    SendKeys.Send("~")
                Case 1 'Tab
                    SendKeys.Send("{TAB}")
                Case 2 'Space
                    SendKeys.Send(" ")
                Case 3 'Down Arrow
                    SendKeys.Send("{DOWN}")
                Case 4 'Right Arrow
                    SendKeys.Send("{RIGHT}")
                Case 5 'Custom...
                    SendKeys.Send(txtButton1.Text)
            End Select
        End If
        Me.WindowState = FormWindowState.Normal
        StatusStripStatusLabel.Text = "Insert script " & lstPrograms.SelectedIndex + 1 & " completed!"
        If ExitWhenDone Then CloseInfoManager
    End Sub

    Private Sub CloseInfoManager() Handles btnEnd.Click
        Application.Exit()
    End Sub

    Private Sub cbxButton1_SelectedIndexChanged(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles cbxButton1.SelectedIndexChanged
        If cbxButton1.SelectedIndex = 5 Then
            txtButton1.Enabled = True
            lnkHelp.Enabled = True
        Else
            txtButton1.Enabled = False
            lnkHelp.Enabled = False
        End If
    End Sub

    Private Sub lnkHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkHelp.LinkClicked
        Try
            Process.Start("http://msdn.microsoft.com/en-us/library/system.windows.forms.sendkeys.send(v=vs.110).aspx?cs-lang=vb#remarksToggle")
        Catch ex As Exception
            If MsgBox("Unable to launch URL, copy to clipboard instead?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then Clipboard.SetText("http://msdn.microsoft.com/en-us/library/system.windows.forms.sendkeys.send(v=vs.110).aspx?cs-lang=vb#remarksToggle")
        End Try
    End Sub

    Private Sub chkMultiLine_CheckedChanged(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles chkMultiLine.CheckedChanged
        If chkMultiLine.Checked = True Then
            lblData2.Enabled = True
            txtData2.Enabled = True
            lblButton2.Enabled = True
            cbxButton2.Enabled = True
            cbxButton2_SelectedIndexChanged()
        Else
            lblData2.Enabled = False
            txtData2.Enabled = False
            lblButton2.Enabled = False
            cbxButton2.Enabled = False
            txtButton2.Enabled = False
        End If
    End Sub

    Private Sub cbxButton2_SelectedIndexChanged(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles cbxButton2.SelectedIndexChanged
        If cbxButton2.SelectedIndex = 5 Then
            txtButton2.Enabled = True
        Else
            txtButton2.Enabled = False
        End If
    End Sub
End Class
