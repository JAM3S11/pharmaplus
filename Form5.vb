Public Class Form5
    Private Sub DOCTORBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DOCTORBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DOCTORBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Pharmaplus_Hospital_Database_System1DataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pharmaplus_Hospital_Database_System1DataSet.DOCTOR' table. You can move, or remove it, as needed.
        Me.DOCTORTableAdapter.Fill(Me.Pharmaplus_Hospital_Database_System1DataSet.DOCTOR)

    End Sub

    Private Sub BtnSaveData_Click(sender As Object, e As EventArgs) Handles BtnSaveData.Click
        Try
            Me.DOCTORBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Pharmaplus_Hospital_Database_System1DataSet)
            MsgBox("Success")
        Catch ex As Exception
            MsgBox("Error Occur,Please check the fields and try again")
        End Try
    End Sub

    Private Sub BtnAddNew_Click(sender As Object, e As EventArgs) Handles BtnAddNew.Click
        Me.DOCTORBindingSource.AddNew()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Me.DOCTORBindingSource.MoveNext()
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        Me.DOCTORBindingSource.MovePrevious()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Me.DOCTORBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(Pharmaplus_Hospital_Database_System1DataSet)
        MsgBox("Current Doctor Details Deleted")
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class