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

    Private Sub bttnConvertToCube_Click(sender As System.Object, e As System.EventArgs) Handles bttnConvertToCube.Click

        ' INPUTS

        Dim cylinder_strength_psi As Double = Convert.ToDouble(inputCylinderStrength.Text)
        If radUnitToCube_PSI.Checked Then
            ' do nothing
        ElseIf radUnitToCube_MPA.Checked Then
            cylinder_strength_psi *= 145.0
        End If


        Dim converted_cube_strength As Double = cylinder_strength_psi

        ' CODE TO CONVERT (PSI UNITS)
        Dim conversion_factor As Double = toCube(cylinder_strength_psi)

        ' MsgBox(conversion_factor.ToString, , "conversion factor")


        converted_cube_strength /= conversion_factor


        ' OUTPUT

        If radUnitToCube_PSI.Checked Then
            ' do nothing
        ElseIf radUnitToCube_MPA.Checked Then
            converted_cube_strength /= 145.0
        End If

        outputCubeStrength.Text = converted_cube_strength.ToString("0.00")


    End Sub

    Private Sub bttnConvertToCylinder_Click(sender As System.Object, e As System.EventArgs) Handles bttnConvertToCylinder.Click
        Dim cube_strength_psi As Double = Convert.ToDouble(inputCubeStrength.Text)

        If radUnitToCylinder_PSI.Checked Then
            ' do nothing
        ElseIf radUnitToCylinder_MPA.Checked Then
            cube_strength_psi *= 145.0
        End If


        Dim converted_cylinder_strength As Double = cube_strength_psi


        ' CODE TO CONVERT (PSI UNITS)
        Dim conversion_factor As Double = toCylinder(cube_strength_psi)

        ' MsgBox(conversion_factor.ToString, , "conversion factor")


        converted_cylinder_strength *= conversion_factor



        ' OUTPUT

        If radUnitToCylinder_PSI.Checked Then
            ' do nothing
        ElseIf radUnitToCylinder_MPA.Checked Then
            converted_cylinder_strength /= 145.0
        End If

        outputCylinderStrength.Text = converted_cylinder_strength.ToString("0.00")

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles bttnAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub bttnClose_Click(sender As System.Object, e As System.EventArgs) Handles bttnClose.Click
        Me.Close()
    End Sub
End Class
