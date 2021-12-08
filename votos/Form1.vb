Public Class form1


    Public a(999999), i As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a(i) = TextBox1.Text
        ListBox1.Items.Add(a(i))
        i = i + 1

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim K As Integer
        Dim boric, kast, total, porcentaje, emitidos, nulo, blanco, b2, k2, n1, bl1, em1, to1 As Integer
        K = i - 1
        For i = 0 To K
            If a(i) = 1 Then
                boric = boric + 1

            End If

            If a(i) = 2 Then
                kast = kast + 1
            End If
            If a(i) = 3 Then
                nulo = nulo + 1
            End If
            If a(i) = 4 Then
                blanco = blanco + 1
            End If

            total = boric + kast + nulo + blanco
            emitidos = boric + kast

            b2 = (boric * 100.0 / emitidos)
            k2 = (kast * 100.0 / emitidos)
            n1 = (nulo * 100.0 / total)
            bl1 = (blanco * 100.0 / total)
            em1 = (emitidos * 100.0 / total)
            to1 = (total * 100.0 / total)

        Next
        TextBox8.Text = b2.ToString("0.## '%'")
        TextBox9.Text = k2.ToString("0.## '%'")
        TextBox10.Text = em1.ToString("0.## '%'")
        TextBox11.Text = n1.ToString("0.## '%'")
        TextBox12.Text = bl1.ToString("0.## '%'")
        TextBox13.Text = to1.ToString("0.## '%'")


    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim K As Integer
        Dim boric, kast, nulo, blanco, total, emitidos As Integer
        K = i - 1
        For i = 0 To K
            If a(i) = 1 Then
                boric = boric + 1

            End If

            If a(i) = 2 Then
                kast = kast + 1
            End If
            If a(i) = 3 Then
                nulo = nulo + 1
            End If
            If a(i) = 4 Then
                blanco = blanco + 1
            End If

            total = boric + kast + nulo + blanco
            emitidos = boric + kast

        Next
        TextBox2.Text = boric
        TextBox3.Text = kast
        TextBox4.Text = nulo
        TextBox5.Text = blanco
        TextBox6.Text = total
        TextBox7.Text = emitidos
    End Sub
End Class
