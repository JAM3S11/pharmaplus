Public Class Form8
    Private Sub DISCHARGEBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DISCHARGEBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DISCHARGEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Pharmaplus_Hospital_Database_System1DataSet)

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pharmaplus_Hospital_Database_System1DataSet.DISCHARGE' table. You can move, or remove it, as needed.
        Me.DISCHARGETableAdapter.Fill(Me.Pharmaplus_Hospital_Database_System1DataSet.DISCHARGE)

    End Sub

    Private Sub BtnSaveData_Click(sender As Object, e As EventArgs) Handles BtnSaveData.Click
        Try
            Me.DISCHARGEBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Pharmaplus_Hospital_Database_System1DataSet)
            MsgBox("Success")
        Catch ex As Exception
            MsgBox("Error Occur,Please check the fields and try again")
        End Try
    End Sub

    Private Sub BtnAddNew_Click(sender As Object, e As EventArgs) Handles BtnAddNew.Click
        Me.DISCHARGEBindingSource.AddNew()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Me.DISCHARGEBindingSource.MoveNext()
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        Me.DISCHARGEBindingSource.MovePrevious()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Me.DISCHARGEBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(Pharmaplus_Hospital_Database_System1DataSet)
        MsgBox("Current Discharge record deleted")
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class