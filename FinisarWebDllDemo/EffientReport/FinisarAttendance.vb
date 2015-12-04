Imports System

<Serializable>
Public Class FinisarAttendance
    Private _department As String = ""
    Public _ProductionStage As String = "MP"
    Public _ProjectCode As String = ""
    Public _AttendanceHour As Double = 8.0
    Public _StepNO As String = ""
    Public _Remark As String = ""
    Public Sub New()

    End Sub
    Property Department() As String
        Get
            Return _department
        End Get
        Set(value As String)
            _department = value
        End Set
    End Property
    Property ProductionStage() As String
        Get
            ProductionStage = _ProductionStage
        End Get
        Set(value As String)
            _ProductionStage = value
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
    Property AttendanceHour As Double
        Get
            AttendanceHour = _AttendanceHour
        End Get
        Set(value As Double)
            _AttendanceHour = value
        End Set
    End Property
    Property StepNO() As String
        Get
            StepNO = _StepNO
        End Get
        Set(value As String)
            _StepNO = value
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


