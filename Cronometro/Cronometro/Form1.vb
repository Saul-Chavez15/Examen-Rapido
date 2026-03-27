Public Class Form1

    Dim boton_Start As Boolean = True
    Dim tiempo_crono As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim numero1 As Integer = 1000
        Dim resultado As Integer = numero1 / 1000
        Dim residuo As Integer = numero1 Mod 60
        Label1.Text = resultado.ToString()
        Label3.Text = residuo.ToString()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tiempo_crono = tiempo_crono + 1
        Label1.Text = tiempo_crono.ToString()
    End Sub
End Class
