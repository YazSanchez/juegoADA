Public Class Game

    Dim contador As Integer = 0
    Dim carta_1 As PictureBox = PictureBox1
    Dim carta_2 As PictureBox = PictureBox2
    Dim carta_3 As PictureBox = PictureBox3
    Dim carta_4 As PictureBox = PictureBox4

    Dim color As Color = Color.Black
    Dim color2 As Color = Color.Blue


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.BackColor = color Or color2
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox2.BackColor = Color.Pink
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox3.BackColor = Color.PaleVioletRed
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PictureBox4.BackColor = Color.Gray

    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click

        If PictureBox1.BackColor = PictureBox2.BackColor Then

            lblContador.Text = contador + 1

        Else lblMal.Text = "No son iguales"

        End If

        If PictureBox1.BackColor = PictureBox3.BackColor Then

            lblContador.Text = contador + 1

        Else lblMal.Text = "No son iguales"

        End If

        If PictureBox1.BackColor = PictureBox4.BackColor Then

            lblContador.Text = contador + 1

        Else lblMal.Text = "No son iguales"

        End If


        If PictureBox2.BackColor = PictureBox1.BackColor Then

            lblContador.Text = contador + 1

        Else lblMal.Text = "No son iguales"

        End If

        If PictureBox2.BackColor = PictureBox3.BackColor Then

            lblContador.Text = contador + 1

        Else lblMal.Text = "No son iguales"

        End If

        If PictureBox2.BackColor = PictureBox4.BackColor Then

            lblContador.Text = contador + 1

        Else lblMal.Text = "No son iguales"

        End If

        If PictureBox3.BackColor = PictureBox1.BackColor Then

            lblContador.Text = contador + 1

        Else lblMal.Text = "No son iguales"

        End If

        If PictureBox3.BackColor = PictureBox2.BackColor Then

            lblContador.Text = contador + 1

        Else lblMal.Text = "No son iguales"

        End If

        If PictureBox3.BackColor = PictureBox4.BackColor Then

            lblContador.Text = contador + 1

        Else lblMal.Text = "No son iguales"

        End If

        If PictureBox4.BackColor = PictureBox1.BackColor Then

            lblContador.Text = contador + 1

        Else lblMal.Text = "No son iguales"

        End If

        If PictureBox4.BackColor = PictureBox2.BackColor Then

            lblContador.Text = contador + 1

        Else lblMal.Text = "No son iguales"

        End If

        If PictureBox4.BackColor = PictureBox3.BackColor Then

            lblContador.Text = contador + 1

        Else lblMal.Text = "No son iguales"

        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.BackColor = Color.Blue

    End Sub
End Class
