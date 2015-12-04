Imports System

Public Class FinisarHeadCount
    Public _Department As String = "OSA"

    Public _ProjectCode As String = ""
    Public _Headcount As Double = 0

    Public _Remark As String = ""
    Public Sub New()

    End Sub
    Property Headcount() As Double
        Get
            Headcount = _Headcount
        End Get
        Set(value As Double)
            _Headcount = value
        End Set
    End Property
    Property Department() As String
        Get
            Return _department
        End Get
        Set(value As String)
            _department = value
        End Set
    End Property
    Property ProjectCode() As String
        Get
            ProjectCode = _ProjectCode
        End Get
        Set(value As String)
            _ProjectCode = value
        End Set
    End Property
    Property Remark As String
        Get
            Remark = _Remark
        End Get
        Set(value As String)
            _Remark = value
        End Set
    End Property
End Class


