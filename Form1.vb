Public Class Form1
    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click

        Dim puntos As Double = 0

        If chClase.Checked = True Then
            puntos += 2.5
        End If

        If chObjeto.Checked = True Then
            puntos += 2.5
        End If

        If chBucle.Checked = True Then
            puntos -= 2.5
        End If

        If chHerencia.Checked = True Then
            puntos += 2.5
        End If

        If chPolimorfismo.Checked = True Then
            puntos += 2.5
        End If

        MsgBox("El total de puntos obtenidos es " & puntos)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chPolimorfismo.Checked = False
        chBucle.Checked = False
        chClase.Checked = False
        chHerencia.Checked = False
        chObjeto.Checked = False
    End Sub
End Class
