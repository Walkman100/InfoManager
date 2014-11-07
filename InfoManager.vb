Imports Microsoft.VisualBasic

Public Class InfoManager

    Private Sub InfoManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lstPrograms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPrograms.SelectedIndexChanged
        Select Case lstPrograms.SelectedIndex + 1
            Case 1 'Program1
                EnableGUI()
                txtName.Text = My.Settings.Program1.Item(0)
            Case 2 'Program2
                EnableGUI()
                txtName.Text = My.Settings.Program2.Item(0)
            Case 3 'Program3
                EnableGUI()
                txtName.Text = My.Settings.Program3.Item(0)
            Case 4 'Program4
                EnableGUI()
                txtName.Text = My.Settings.Program4.Item(0)
            Case 5 'Program5
                EnableGUI()
                txtName.Text = My.Settings.Program5.Item(0)
            Case 6 'Program6
                EnableGUI()
                txtName.Text = My.Settings.Program6.Item(0)
            Case 7 'Program7
                EnableGUI()
                txtName.Text = My.Settings.Program7.Item(0)
            Case 8 'Program8
                EnableGUI()
                txtName.Text = My.Settings.Program8.Item(0)
            Case 9 'Program9
                EnableGUI()
                txtName.Text = My.Settings.Program9.Item(0)
            Case 10 'Program0 (Extendable)
                txtName.Enabled = False
                lblData1.Enabled = False
                txtData1.Enabled = False
                lblButton1.Enabled = False
                cbxButton1.Enabled = False
                txtButton1.Enabled = False
                chkMultiLine.Enabled = False
                lblData2.Enabled = False
                txtData2.Enabled = False
                lblButton2.Enabled = False
                cbxButton2.Enabled = False
                txtButton2.Enabled = False
                txtName.Text = My.Settings.Program0.Item(0)
            Case -1 'Nothing selected
                txtName.Enabled = False
                lblData1.Enabled = False
                txtData1.Enabled = False
                lblButton1.Enabled = False
                cbxButton1.Enabled = False
                txtButton1.Enabled = False
                chkMultiLine.Enabled = False
                lblData2.Enabled = False
                txtData2.Enabled = False
                lblButton2.Enabled = False
                cbxButton2.Enabled = False
                txtButton2.Enabled = False
        End Select
    End Sub

    Sub EnableGUI()
        txtName.Enabled = True
        lblData1.Enabled = True
        txtData1.Enabled = True
        lblButton1.Enabled = True
        cbxButton1.Enabled = True
        txtButton1.Enabled = True
        chkMultiLine.Enabled = True
        chkMultiLine_CheckedChanged()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click

    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Application.Exit()
    End Sub

    Private Sub cbxButton1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxButton1.SelectedIndexChanged

    End Sub

    Private Sub chkMultiLine_CheckedChanged(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles chkMultiLine.CheckedChanged
        If chkMultiLine.Checked = True Then
            lblData2.Enabled = True
            txtData2.Enabled = True
            lblButton2.Enabled = True
            cbxButton2.Enabled = True
            txtButton2.Enabled = True
        Else
            lblData2.Enabled = False
            txtData2.Enabled = False
            lblButton2.Enabled = False
            cbxButton2.Enabled = False
            txtButton2.Enabled = False
        End If
    End Sub

    Private Sub cbxButton2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxButton2.SelectedIndexChanged

    End Sub
End Class
