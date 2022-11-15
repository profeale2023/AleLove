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
End Class
