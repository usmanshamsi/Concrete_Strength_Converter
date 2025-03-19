Public Class Form1

    Private Sub radUnitToCube_PSI_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radUnitToCube_PSI.CheckedChanged
        If radUnitToCube_PSI.Checked Then
            lblUnitToCube.Text = "Psi"
        ElseIf radUnitToCube_MPA.Checked Then
            lblUnitToCube.Text = "MPa"
        End If
    End Sub

    Private Sub radUnitToCylinder_PSI_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radUnitToCylinder_PSI.CheckedChanged
        If radUnitToCylinder_PSI.Checked Then
            lblUnitToCylinder.Text = "Psi"
        ElseIf radUnitToCylinder_MPA.Checked Then
            lblUnitToCylinder.Text = "MPa"
        End If
    End Sub
End Class
