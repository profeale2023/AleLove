Public Class Transporte
    Private _marca As String
    Private _ruedas As Integer
    Private _asientos As Integer



    Public Property MarcaTransporte As String
        Get
            Return _marca
        End Get
        Set(value As String)
            _marca = value
        End Set
    End Property

    Public Property RuedasTransporte As String
        Get
            Return _ruedas
        End Get
        Set(value As String)
            _ruedas = value
        End Set
    End Property

    Public Property AsientosTransporte As String
        Get
            Return _asientos
        End Get
        Set(value As String)
            _asientos = value
        End Set
    End Property



    Public Overridable Function Movimiento(ByVal sTipo As String)
        Dim sRetorno As String
        If sTipo = "Avion" Then
            sRetorno = "Despega"
        Else
            sRetorno = "Acelera"
        End If
        Return sRetorno
    End Function




End Class
