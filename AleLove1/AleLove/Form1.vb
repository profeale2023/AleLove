Public Class Form1
    Private Sub BtnCarga_Click(sender As Object, e As EventArgs) Handles BtnCarga.Click
        Dim Avion1 As Avion = New Avion
        Dim Auto1 As Auto = New Auto

        If Me.CboTransp.SelectedItem = "Avion" Then
            Avion1.MarcaTransporte = TxtMarca.Text
            Avion1.RuedasTransporte = TxtRuedas.Text


            TxtResultado1.Text = Avion1.MarcaTransporte & " " & Avion1.RuedasTransporte & " " & Avion1.TurbinaAvion & " " & Avion1.Movimiento(Me.CboTransp.SelectedItem)
        Else
            Auto1.MarcaTransporte = TxtMarca.Text
            Auto1.RuedasTransporte = TxtRuedas.Text
            TxtResultado2.Text = Auto1.MarcaTransporte & " " & Auto1.RuedasTransporte & " " & Auto1.ModeloAuto & " " & Auto1.Movimiento(Me.CboTransp.SelectedItem)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class
