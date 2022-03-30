Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Private Sub panTit_MouseDown(sender As Object, e As MouseEventArgs) Handles panTit.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub panelTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles panTit.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Form1.MousePosition.X - Me.Location.X - ex, Form1.MousePosition.Y - Me.Location.Y - ey))
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        panelDatos.Visible = True
    End Sub

    Private Sub panelTitulo_MouseUp(sender As Object, e As MouseEventArgs) Handles panTit.MouseUp
        Arrastre = False
    End Sub
End Class
