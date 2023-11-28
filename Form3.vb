Public Class Form3
    Private Sub PATIENTBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PATIENTBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PATIENTBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Pharmaplus_Hospital_Database_System1DataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pharmaplus_Hospital_Database_System1DataSet.PATIENT' table. You can move, or remove it, as needed.
        Me.PATIENTTableAdapter.Fill(Me.Pharmaplus_Hospital_Database_System1DataSet.PATIENT)

    End Sub

    Private Sub radMale_CheckedChanged(sender As Object, e As EventArgs) Handles radMale.CheckedChanged
        If radMale.Checked Then
            SexTextBox.Text = radMale.Text
        End If
    End Sub

    Private Sub radFemale_CheckedChanged(sender As Object, e As EventArgs) Handles radFemale.CheckedChanged
        If radFemale.Checked Then
            SexTextBox.Text = radFemale.Text
        End If
    End Sub

    Private Sub PATIENTBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles PATIENTBindingNavigator.RefreshItems
        If SexTextBox.Text = radMale.Text Then
            radMale.Checked = True
            radFemale.Checked = False
        ElseIf SexTextBox.Text = radFemale.Text Then
            radFemale.Checked = True
            radMale.Checked = False
        End If
    End Sub

    Private Sub BtnSaveData_Click(sender As Object, e As EventArgs) Handles BtnSaveData.Click
        Try
            Me.PATIENTBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Pharmaplus_Hospital_Database_System1DataSet)
            MsgBox("Success")
        Catch ex As Exception
            MsgBox("Error occur,Please reacheck the fields and try again")
        End Try
    End Sub

    Private Sub BtnAddNew_Click(sender As Object, e As EventArgs) Handles BtnAddNew.Click
        Me.PATIENTBindingSource.AddNew()
        radMale.Checked = True
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Me.PATIENTBindingSource.MoveNext()
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        Me.PATIENTBindingSource.MovePrevious()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Me.PATIENTBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Pharmaplus_Hospital_Database_System1DataSet)
        MsgBox("Current Record Deleted")
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class