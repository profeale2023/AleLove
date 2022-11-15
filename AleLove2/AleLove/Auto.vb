Public Class Auto
    Inherits Transporte

    Private _modelo As String

    Public Property ModeloAuto As String
        Get
            Return _modelo
        End Get
        Set(value As String)
            _modelo = value
        End Set
    End Property


    Public Overrides Function Movimiento(sTipo As String) As Object
        sTipo = "Acelera"
        Return sTipo
    End Function
End Class
