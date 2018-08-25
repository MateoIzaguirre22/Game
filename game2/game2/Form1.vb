Public Class Form1
    Dim contador As Integer
    Dim caminar1 As Integer = 0
    Dim caminar2 As Integer = 0
    Dim animacion_quieto As Integer
    Dim animacion_caminar As Integer
    Dim salto As Integer
    Dim pared As Integer
    Dim desplazamiento As Double = 1
    Dim vida As Integer = 200
    Dim power As Integer = 100
    Dim ataque As Integer
    Dim contador_salto As Integer






    Private Sub Form1_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        '//////Movimiento/////

        '<caminar a la derecha>'
        If e.KeyCode = Keys.Right Then
            caminar1 = 1
            movimiento.Enabled = True
            animacion_quieto = 0
            animacion_caminar = 1
        End If

        '<saltar>'
        If e.KeyCode = Keys.Up Then
            salto = 1
            animacion_quieto = 0
            animacion_caminar = 0
            gravedad.Enabled = True

        End If

        '<caminar a la izquierda>'
        If e.KeyCode = Keys.Left Then
            caminar2 = 1
            animacion_quieto = 0
            animacion_caminar = 2
            movimiento.Enabled = True
        End If


        If e.KeyCode = Keys.A Then
            ataque = 1
        End If
        If e.KeyCode = Keys.S Then
            power = power + 1
        End If
    End Sub

    Private Sub Form1_KeyUp1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Right Then
            caminar1 = 0
            animacion_quieto = 1
            animacion_caminar = 0
        End If

        If e.KeyCode = Keys.Left Then
            caminar2 = 0
            animacion_quieto = 1
            animacion_caminar = 0
        End If
        If e.KeyCode = Keys.A Then
            ataque = 0
            PictureBox2.Dispose()
        End If

        
    End Sub









    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles movimiento.Tick
        If caminar1 = 1 Then
            PictureBox1.Location = New Point(PictureBox1.Location.X + 2, PictureBox1.Location.Y)
        End If
        If caminar2 = 1 Then
            PictureBox1.Location = New Point(PictureBox1.Location.X - 2, PictureBox1.Location.Y)
        End If

        If PictureBox1.Location.X = Panel2.Location.X - 50 Then
            PictureBox1.Location = New Point(PictureBox1.Location.X - 2, PictureBox1.Location.Y)
        End If


    End Sub


    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gravedad.Tick


        If salto = 1 Then
            desplazamiento = desplazamiento + 0.1
            PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y - desplazamiento)
            contador_salto = contador_salto + 1
        End If
        If PictureBox1.Location.Y < 30 And PictureBox1.Location.Y > 7 Then
            salto = 0
            gravedad.Enabled = False
            caida.Enabled = True
            desplazamiento = 0.5

        End If



    End Sub


    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caida.Tick
        desplazamiento = desplazamiento + 0.1
        PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y + desplazamiento)


        If PictureBox1.Location.Y + PictureBox1.Height > Panel1.Location.Y - 20 And PictureBox1.Location.Y + PictureBox1.Height <= Panel1.Location.Y Then
            PictureBox1.Location = New Point(PictureBox1.Location.X, Panel1.Location.Y - PictureBox1.Height)
            caida.Enabled = False
            gravedad.Enabled = False
            animacion_quieto = 1
            desplazamiento = 0
        End If

    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Animacion.Tick
        animacion_quieto = 1

        If PictureBox2.Location.X < PictureBox1.Location.X Then
            PictureBox2.Image = My.Resources.snap1
        Else
            PictureBox2.Image = My.Resources.snap1
            PictureBox2.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
        End If


        If PictureBox2.Location.X > PictureBox1.Location.X Then
            PictureBox1.Image = My.Resources.snap1
        Else
            animacion_quieto = 2
        End If






        Label2.Text = contador
        If animacion_quieto = 1 Then
            contador = contador + 1
            If contador >= 3 Then
                contador = contador * 0
            End If
            If contador = 1 Then
                PictureBox1.Image = My.Resources.snap1
            End If
            If contador = 2 Then
                PictureBox1.Image = My.Resources.snap2
            End If

        End If

        If animacion_quieto = 2 Then
            contador = contador + 1
            If contador >= 3 Then
                contador = contador * 0
            End If
            If contador = 1 Then
                PictureBox1.Image = My.Resources.snap1
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
            End If
            If contador = 2 Then
                PictureBox1.Image = My.Resources.snap2
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
            End If

        End If





        If animacion_caminar = 1 Then
            contador = contador + 1
            If contador >= 5 Then
                contador = contador * 0
            End If
            If contador = 0 Then
                PictureBox1.Image = My.Resources.snap3
            End If
            If contador = 1 Then
                PictureBox1.Image = My.Resources.snap4
            End If
            If contador = 2 Then
                PictureBox1.Image = My.Resources.snap5
            End If
            If contador = 3 Then
                PictureBox1.Image = My.Resources.snap6
            End If
        End If

        If animacion_caminar = 2 Then
            contador = contador + 1

            If contador >= 5 Then
                contador = contador * 0
            End If
            If contador = 0 Then
                PictureBox1.Image = My.Resources.snap3
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
            End If
            If contador = 1 Then
                PictureBox1.Image = My.Resources.snap4
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
            End If
            If contador = 2 Then
                PictureBox1.Image = My.Resources.snap5
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
            End If
            If contador = 3 Then
                PictureBox1.Image = My.Resources.snap6
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
            End If
        End If


    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




    End Sub

   
    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        vida1.Width = vida
        poder.Width = power
        If PictureBox1.Location.X = PictureBox2.Location.X Then
            vida = vida - 26
        End If
        If ataque = 1 Then
            power = power - 10
        End If
    End Sub


   
End Class