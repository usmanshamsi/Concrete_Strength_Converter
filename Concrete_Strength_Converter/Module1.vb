Module Module1

    Dim cube_strengths() As Double = {1000, 2200, 2900, 3500, 3800, 4900, 5300, 5900, 6400, 7300}
    Dim conversion_factors() As Double = {0.77, 0.76, 0.81, 0.87, 0.91, 0.93, 0.94, 0.95, 0.96, 0.96}
    Dim cylinder_strengths() As Double = {0.77 * 1000, 0.76 * 2200, 0.81 * 2900, 0.87 * 3500, 0.91 * 3800, 0.93 * 4900, 0.94 * 5300, 0.95 * 5900, _
                                          0.96 * 6400, 0.96 * 7300}

    Function toCylinder(cubeStrength As Double) As Double


        If cubeStrength < cube_strengths(0) Then
            Return conversion_factors(0)
        ElseIf cubeStrength >= cube_strengths(9) Then
            Return conversion_factors(9)
        Else
            For i As Integer = 0 To 8
                If cubeStrength >= cube_strengths(i) And cubeStrength < cube_strengths(i + 1) Then

                    Return interpolate_y(cube_strengths(i), conversion_factors(i), _
                                         cube_strengths(i + 1), conversion_factors(i + 1), _
                                         cubeStrength)

                End If
            Next
        End If

        Return -1.0

    End Function


    Function interpolate_y(x1 As Double, y1 As Double, x2 As Double, y2 As Double, x As Double) As Double
        Return y1 + (y2 - y1) / (x2 - x1) * (x - x1)
    End Function




End Module
