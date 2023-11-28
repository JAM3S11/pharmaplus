Public Class Form4
    Private Sub APPOINTMENTBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles APPOINTMENTBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.APPOINTMENTBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Pharmaplus_Hospital_Database_System1DataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pharmaplus_Hospital_Database_System1DataSet.APPOINTMENT' table. You can move, or remove it, as needed.
        Me.APPOINTMENTTableAdapter.Fill(Me.Pharmaplus_Hospital_Database_System1DataSet.APPOINTMENT)

    End Sub

    Private Sub BtnSaveData_Click(sender As Object, e As EventArgs) Handles BtnSaveData.Click
        Try
            Me.APPOINTMENTBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Pharmaplus_Hospital_Database_System1DataSet)
            MsgBox("Success")
        Catch ex As Exception
            MsgBox("Error occur,Please check the fields and try again")
        End Try
    End Sub

    Private Sub BtnAddNew_Click(sender As Object, e As EventArgs) Handles BtnAddNew.Click
        Me.APPOINTMENTBindingSource.AddNew()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Me.APPOINTMENTBindingSource.MoveNext()
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        Me.APPOINTMENTBindingSource.MovePrevious()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Me.APPOINTMENTBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Pharmaplus_Hospital_Database_System1DataSet)
        MsgBox("Current Appointment Deleted")
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class