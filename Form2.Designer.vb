<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.BtnPatientDetails = New System.Windows.Forms.Button()
        Me.BtnMedicine = New System.Windows.Forms.Button()
        Me.BtnAppointment = New System.Windows.Forms.Button()
        Me.BtnBilling = New System.Windows.Forms.Button()
        Me.BtnDoctorDetails = New System.Windows.Forms.Button()
        Me.BtnDischarge = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnPatientDetails
        '
        Me.BtnPatientDetails.Location = New System.Drawing.Point(175, 138)
        Me.BtnPatientDetails.Name = "BtnPatientDetails"
        Me.BtnPatientDetails.Size = New System.Drawing.Size(174, 43)
        Me.BtnPatientDetails.TabIndex = 0
        Me.BtnPatientDetails.Text = "Patient Details"
        Me.BtnPatientDetails.UseVisualStyleBackColor = True
        '
        'BtnMedicine
        '
        Me.BtnMedicine.Location = New System.Drawing.Point(506, 138)
        Me.BtnMedicine.Name = "BtnMedicine"
        Me.BtnMedicine.Size = New System.Drawing.Size(174, 43)
        Me.BtnMedicine.TabIndex = 0
        Me.BtnMedicine.Text = "Medicine"
        Me.BtnMedicine.UseVisualStyleBackColor = True
        '
        'BtnAppointment
        '
        Me.BtnAppointment.Location = New System.Drawing.Point(175, 248)
        Me.BtnAppointment.Name = "BtnAppointment"
        Me.BtnAppointment.Size = New System.Drawing.Size(174, 42)
        Me.BtnAppointment.TabIndex = 0
        Me.BtnAppointment.Text = "Appointment"
        Me.BtnAppointment.UseVisualStyleBackColor = True
        '
        'BtnBilling
        '
        Me.BtnBilling.Location = New System.Drawing.Point(506, 248)
        Me.BtnBilling.Name = "BtnBilling"
        Me.BtnBilling.Size = New System.Drawing.Size(174, 42)
        Me.BtnBilling.TabIndex = 0
        Me.BtnBilling.Text = "Billing"
        Me.BtnBilling.UseVisualStyleBackColor = True
        '
        'BtnDoctorDetails
        '
        Me.BtnDoctorDetails.Location = New System.Drawing.Point(175, 344)
        Me.BtnDoctorDetails.Name = "BtnDoctorDetails"
        Me.BtnDoctorDetails.Size = New System.Drawing.Size(174, 40)
        Me.BtnDoctorDetails.TabIndex = 0
        Me.BtnDoctorDetails.Text = "Doctor Details"
        Me.BtnDoctorDetails.UseVisualStyleBackColor = True
        '
        'BtnDischarge
        '
        Me.BtnDischarge.Location = New System.Drawing.Point(506, 344)
        Me.BtnDischarge.Name = "BtnDischarge"
        Me.BtnDischarge.Size = New System.Drawing.Size(174, 40)
        Me.BtnDischarge.TabIndex = 0
        Me.BtnDischarge.Text = "Discharge"
        Me.BtnDischarge.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(359, 448)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(143, 58)
        Me.BtnBack.TabIndex = 0
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Pharmaplus_Hospital_Management_1.My.Resources.Resources.Hospital_Image
        Me.ClientSize = New System.Drawing.Size(848, 533)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnDischarge)
        Me.Controls.Add(Me.BtnDoctorDetails)
        Me.Controls.Add(Me.BtnBilling)
        Me.Controls.Add(Me.BtnAppointment)
        Me.Controls.Add(Me.BtnMedicine)
        Me.Controls.Add(Me.BtnPatientDetails)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pharmaplus Hospital HomePage"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnPatientDetails As Button
    Friend WithEvents BtnMedicine As Button
    Friend WithEvents BtnAppointment As Button
    Friend WithEvents BtnBilling As Button
    Friend WithEvents BtnDoctorDetails As Button
    Friend WithEvents BtnDischarge As Button
    Friend WithEvents BtnBack As Button
End Class
