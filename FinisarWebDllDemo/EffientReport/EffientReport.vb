Imports System
Imports System.Collections.Generic
Imports System.Net
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Collections
Imports MiniUiAppCode.Utils
Imports MiniUiAppCode


Imports System.Reflection

Public Class EffientReport
        Private m_strBaseUrl As String = "http://121.199.9.136:8082/rispweb/"
        Private m_user As String = ""
        Private m_upass As String = ""
        Private m_islogin As Boolean = False
        Private m_errormessage As String = ""
        Sub New(ByVal strBaseUrl As String, ByVal User As String, ByVal Upass As String)
            m_strBaseUrl = strBaseUrl
            m_user = User
            m_upass = Upass
            m_islogin = False
        m_errormessage = ""
        RealsunClientNet.strBaseUrl = m_strBaseUrl
    End Sub
        Public Function Login() As Boolean
            If m_user = "" Then
                m_islogin = False
                m_errormessage = "用户名不能为空"
                Return m_islogin
            End If
        If m_upass = "" Then
            m_islogin = False
            m_errormessage = "密码不能为空"
            Return m_islogin
        End If

        Try

            Dim loginReturnData As Task(Of Hashtable) = RealsunClientNet.Login(m_user, m_upass)
            Dim result As New Hashtable
            result = loginReturnData.Result
            If Convert.ToInt16(result("error")) = 0 Then
                m_islogin = True
            Else
                m_islogin = False
                m_errormessage = Convert.ToString(result("message"))
            End If
        Catch ex As Exception
            m_islogin = False
                m_errormessage = ex.Message.ToString()
            End Try

            Return m_islogin
        End Function
    Public Function getLastErroMessage() As String
        Dim strerror As String = m_errormessage
        m_errormessage = ""
        Return strerror
    End Function
    Public Function isLogin() As Boolean
        Return m_islogin
    End Function

    '1.	获取部门出勤工时和人头数
    Public Function getAttendanceByDepartment(ByVal Department As String, ByVal FromDate As String, ByVal ToDate As String, ByRef Attendance As List(Of FinisarAttendance), ByRef Headcount As List(Of FinisarHeadCount)) As Boolean
        Dim inputdata As New Hashtable
        Try

            If (FromDate = "" Or FromDate Is Nothing) Then
                m_errormessage = "FromDate 不能为空"
                Return False
            End If
            If (ToDate = "" Or ToDate Is Nothing) Then
                m_errormessage = "ToDate 不能为空"
                Return False
            End If
            inputdata.Add("Department", Department)
            inputdata.Add("FromDate", FromDate)
            inputdata.Add("ToDate", ToDate)
            Dim taskreturndata As Task(Of Hashtable) = RealsunClientNet.Execute("getAttendanceByDepartment", inputdata)
            Dim returndata As Hashtable = taskreturndata.Result
            If Convert.ToInt16(returndata("error")) <> 0 Then
                m_errormessage = "函数调用成功，但是远程服务器响应错误：" + Convert.ToString(returndata("message"))
                Return False
            End If
            Return True
        Catch ex As Exception
            m_errormessage = ex.Message.ToString()
        End Try

        Return False
    End Function
    '2.	获取项目代码出勤工时和人头数
    Public Function getAttendanceByProjCode(ByVal Department As String, ByVal FromDate As String, ByVal ToData As String, ByRef Attendance As List(Of FinisarAttendance), ByRef Headcount As List(Of FinisarHeadCount)) As Boolean
        Return False
    End Function
    '3.	获取工序出勤工时
    Public Function getAttendanceByStepNo(ByVal Department As String, ByVal ProjectCode As String, ByVal ProductionStage As String, ByVal StepNo As String, ByVal FromDate As String, ByVal ToData As String, ByRef Attendance As List(Of FinisarAttendance)) As Boolean
        Return False
    End Function

End Class


