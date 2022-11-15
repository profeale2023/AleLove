Public Class Avion
    Inherits Transporte

    Private _turbina As String

    Public Property TurbinaAvion As String
        Get
            Return _turbina
        End Get
        Set(value As String)
            _turbina = value
        End Set
    End Property

    Public Overrides Function Movimiento(sTipo As String) As Object
        sTipo = "Despega"
        Return sTipo
    End Function
End Class
