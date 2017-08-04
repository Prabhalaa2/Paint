Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = MousePosition.X
        Label2.Text = MousePosition.Y
    End Sub
    Dim Clicked As Boolean = False

    'Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
    'Dim Draw As System.Drawing.Graphics
    '   Draw = Me.CreateGraphics
    '
    'Dim X As Integer = Form1.MousePosition.X - Me.Location.X - 10
    'Dim Y As Integer = Form1.MousePosition.Y - Me.Location.Y - 35

    ' Draw.FillEllipse(Brushes.Aqua, X, Y, 50, 40)
    ' End Sub


    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown


        Clicked = True

    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        Clicked = False

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim Draw As System.Drawing.Graphics
        Draw = Me.CreateGraphics
        Dim X As Integer = Form1.MousePosition.X - Me.Location.X - 10
        Dim Y As Integer = Form1.MousePosition.Y - Me.Location.Y - 35
        If Clicked Then
            Draw.FillEllipse(Brushes.Yellow, X, Y, 40, 50)
        End If
    End Sub
End Class
