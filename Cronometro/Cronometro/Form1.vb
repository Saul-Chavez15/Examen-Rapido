Public Class Form1

    Dim horas As Integer = 0
    Dim minutos As Integer = 0
    Dim segundos As Integer = 0
    Dim Inicio As Boolean = False


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Inicio = False Then
            Timer1.Start()
            Button1.Text = "Pausar"
            Inicio = True
        Else
            Timer1.Stop()
            Button1.Text = "Iniciar"
            Inicio = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        horas = 0
        minutos = 0
        segundos = 0
        Inicio = False
        Label1.Text = "00:00:00"
        Button1.Text = "Iniciar"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        segundos += 1
        If segundos = 60 Then
            segundos = 0
            minutos += 1

        End If
        If minutos = 60 Then
            minutos = 0
            horas += 1
        End If
        Label1.Text =
        horas.ToString("00") & ":" &
        minutos.ToString("00") & ":" &
            segundos.ToString("00")
    End Sub

    Dim tiempoTotal As Integer = 0
    Dim timerActivo As Boolean = False

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tiempoTotal = 60
        ActualizarTimer()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        tiempoTotal = 300
        ActualizarTimer()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If timerActivo = False And tiempoTotal > 0 Then
            Timer2.Start()
            Button5.Text = "Pausar"
            timerActivo = True
        Else
            Timer2.Stop()
            Button5.Text = "Iniciar"
            timerActivo = False


        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Timer2.Stop()
        tiempoTotal = 0
        Label6.Text = "00:00"
        Button5.Text = "Iniciar"
        timerActivo = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If tiempoTotal > 0 Then
            tiempoTotal -= 1
            ActualizarTimer()
        Else
            Timer2.Stop()
            timerActivo = False
            Button5.Text = "Iniciar"
            MessageBox.Show("Tiempo termiando!")
        End If
    End Sub
    Private Sub ActualizarTimer()
        Dim min As Integer = tiempoTotal / 60
        Dim seg As Integer = tiempoTotal Mod 60
        Label6.Text = min.ToString("00") & ":" & seg.ToString("00")
    End Sub



End Class
