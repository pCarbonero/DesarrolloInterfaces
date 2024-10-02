Imports ClasesSharp

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim pers As New ClsPersona()
        If Not (textoNombre.Text.Equals("")) Then
            pers.Nombre = textoNombre.Text
            MessageBox.Show("Hola " + pers.Nombre)
            lbError.Visible = False
        Else
            lbError.Visible = True
        End If


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbError.Click

    End Sub
End Class
