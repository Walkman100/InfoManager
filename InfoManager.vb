Imports Microsoft.VisualBasic

Public Class InfoManager

    Private Sub InfoManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxButton1.SelectedIndex = 0
        cbxButton2.SelectedIndex = 0
    End Sub

    Private Sub lstPrograms_SelectedIndexChanged(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles lstPrograms.SelectedIndexChanged
        StatusStripStatusLabel.Text = "Loading item... (If this doesn't change whithin a few seconds, item hasn't been loaded correctly)"
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
        StatusStripStatusLabel.Text = "Item succesfully loaded!"
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        CType(lstPrograms.SelectedItem, System.Collections.Specialized.StringCollection).Item(0) = txtName.Text
        CType(lstPrograms.SelectedItem, System.Collections.Specialized.StringCollection).Item(1) = txtData1.Text
        CType(lstPrograms.SelectedItem, System.Collections.Specialized.StringCollection).Item(2) = cbxButton1.SelectedItem
        CType(lstPrograms.SelectedItem, System.Collections.Specialized.StringCollection).Item(3) = txtButton1.Text
        CType(lstPrograms.SelectedItem, System.Collections.Specialized.StringCollection).Item(4) = chkMultiLine.Checked
        StatusStripStatusLabel.Text = "Saved!"
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click, lstPrograms.DoubleClick
        lstPrograms_SelectedIndexChanged()
        StatusStripStatusLabel.Text = "Running insert script..."
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
        StatusStripStatusLabel.Text = "Insert script completed!"
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
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
            Process.Start("http://msdn.microsoft.com/en-us/library/system.windows.forms.sendkeys.send(v=vs.110).aspx#remarksToggle")
        Catch ex As Exception
            If MsgBox("Unable to launch URL, copy to clipboard instead?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then Clipboard.SetText("http://msdn.microsoft.com/en-us/library/system.windows.forms.sendkeys.send(v=vs.110).aspx#remarksToggle")
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
