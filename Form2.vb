Public Class Form2
    Private Sub BtnPatientDetails_Click(sender As Object, e As EventArgs) Handles BtnPatientDetails.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub BtnAppointment_Click(sender As Object, e As EventArgs) Handles BtnAppointment.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub BtnDoctorDetails_Click(sender As Object, e As EventArgs) Handles BtnDoctorDetails.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub BtnMedicine_Click(sender As Object, e As EventArgs) Handles BtnMedicine.Click
        Form6.Show()
        Me.Close()
    End Sub

    Private Sub BtnBilling_Click(sender As Object, e As EventArgs) Handles BtnBilling.Click
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub BtnDischarge_Click(sender As Object, e As EventArgs) Handles BtnDischarge.Click
        Form8.Show()
        Me.Close()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class