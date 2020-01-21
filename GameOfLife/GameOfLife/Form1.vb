Public Class Form1


    Public Sub FormSettings()
        Form1.ActiveForm.BackColor = Color.Black
        Form1.ActiveForm.Text = "Hello World"



    End Sub
    Public Sub DrawBoard()
        Dim myPen As New System.Drawing.Pen(System.Drawing.Color.Red)
        Dim formGraphics As System.Drawing.Graphics
        formGraphics = Me.CreateGraphics()
        formGraphics.DrawLine(myPen, 0, 0, 200, 200)
        myPen.Dispose()
        formGraphics.Dispose()
    End Sub
End Class
