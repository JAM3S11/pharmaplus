Public Class Form6
    Private Sub MEDICINEBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MEDICINEBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MEDICINEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Pharmaplus_Hospital_Database_System1DataSet)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pharmaplus_Hospital_Database_System1DataSet.MEDICINE' table. You can move, or remove it, as needed.
        Me.MEDICINETableAdapter.Fill(Me.Pharmaplus_Hospital_Database_System1DataSet.MEDICINE)

    End Sub

    Private Sub BtnSaveData_Click(sender As Object, e As EventArgs) Handles BtnSaveData.Click
        Try
            Me.MEDICINEBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Pharmaplus_Hospital_Database_System1DataSet)
            MsgBox("Success")
        Catch ex As Exception
            MsgBox("Error Occur,Please check the fields and try again")
        End Try
    End Sub

    Private Sub BtnAddNew_Click(sender As Object, e As EventArgs) Handles BtnAddNew.Click
        Me.MEDICINEBindingSource.AddNew()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Me.MEDICINEBindingSource.MoveNext()
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        Me.MEDICINEBindingSource.MovePrevious()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Me.MEDICINEBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(Pharmaplus_Hospital_Database_System1DataSet)
        MsgBox("Current Medicine Record Deleted")
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class