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
    Public Function convert2ListOfAttendance(ByVal array_Attendance As ArrayList) As List(Of FinisarAttendance)
        Dim list As New List(Of FinisarAttendance)
        For i = 0 To array_Attendance.Count - 1
            Dim att As New FinisarAttendance
            Dim hs As Hashtable = DirectCast(array_Attendance.Item(i), Hashtable)
            att.AttendanceHour = hs("AttendanceHour")
            att.Department = hs("Department")
            att.ProductionStage = hs("ProductionStage")
            att.ProjectCode = hs("ProjectCode")
            att.Remark = hs("Remark")
            att.StepNO = hs("StepNO")
            list.Add(att)
        Next
        Return list
    End Function
    Public Function convert2ListOfHeadCount(ByVal array_headcount As ArrayList) As List(Of FinisarHeadCount)
        Dim list As New List(Of FinisarHeadCount)
        For i = 0 To array_headcount.Count - 1
            Dim head As New FinisarHeadCount
            Dim hs As Hashtable = DirectCast(array_headcount.Item(i), Hashtable)
            head.Department = hs("Department")
            head.Headcount = hs("Headcount")
            head.ProjectCode = hs("ProjectCode")
            head.Remark = hs("Remark")
            list.Add(head)

        Next
        Return list
    End Function


    '1.	获取部门出勤工时和人头数
    Public Function getAttendanceByDepartment(ByVal Department As String, ByVal FromDate As String, ByVal ToDate As String, ByRef Attendance As List(Of FinisarAttendance), ByRef Headcount As List(Of FinisarHeadCount), ByRef requestid As Int64) As Boolean
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
            inputdata.Add("returnparms", "Attendance,Headcount")
            Dim taskreturndata As Task(Of Hashtable) = RealsunClientNet.Execute("getAttendanceByDepartment", inputdata, requestid)
            Dim returndata As Hashtable = taskreturndata.Result
            If Convert.ToInt16(returndata("error")) <> 0 Then
                m_errormessage = "函数调用成功，但是远程服务器响应错误：" + Convert.ToString(returndata("message"))
                Return False
            End If
            requestid = Convert.ToInt64(returndata("requestid"))
            Dim array_Attendance As New ArrayList
            Dim array_Headcount As New ArrayList

            array_Attendance = DirectCast(returndata("data")("Attendance"), ArrayList)
            array_Headcount = DirectCast(returndata("data")("Headcount"), ArrayList)

            Attendance = convert2ListOfAttendance(array_Attendance)
            Headcount = convert2ListOfHeadCount(array_Headcount)

            If Attendance Is Nothing Then
                m_errormessage = " List(Of Attendance) 无数据返回"
                Return False
            End If
            If Headcount Is Nothing Then
                m_errormessage = " List(Of Headcount) 无数据返回 "
                Return False
            End If
            Return True
        Catch ex As Exception
            m_errormessage = ex.Message.ToString()
            Return False
        End Try

        Return False
    End Function
    '2.	获取项目代码出勤工时和人头数
    Public Function getAttendanceByProjCode(ByVal Department As String, ByVal FromDate As String, ByVal ToDate As String, ByRef Attendance As List(Of FinisarAttendance), ByRef Headcount As List(Of FinisarHeadCount), ByRef requestid As Int64) As Boolean
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
            inputdata.Add("returnparms", "Attendance,Headcount")
            Dim taskreturndata As Task(Of Hashtable) = RealsunClientNet.Execute("getAttendanceByProjCode", inputdata, requestid)
            Dim returndata As Hashtable = taskreturndata.Result
            If Convert.ToInt16(returndata("error")) <> 0 Then
                m_errormessage = "函数调用成功，但是远程服务器响应错误：" + Convert.ToString(returndata("message"))
                Return False
            End If
            requestid = Convert.ToInt64(returndata("requestid"))
            Dim array_Attendance As New ArrayList
            Dim array_Headcount As New ArrayList

            array_Attendance = DirectCast(returndata("data")("Attendance"), ArrayList)
            array_Headcount = DirectCast(returndata("data")("Headcount"), ArrayList)

            Attendance = convert2ListOfAttendance(array_Attendance)
            Headcount = convert2ListOfHeadCount(array_Headcount)

            If Attendance Is Nothing Then
                m_errormessage = " List(Of Attendance) 无数据返回"
                Return False
            End If
            If Headcount Is Nothing Then
                m_errormessage = " List(Of Headcount) 无数据返回 "
                Return False
            End If
            Return True
        Catch ex As Exception
            m_errormessage = ex.Message.ToString()
            Return False
        End Try


        Return False
    End Function
    '3.	获取工序出勤工时
    Public Function getAttendanceByStepNo(ByVal Department As String, ByVal ProjectCode As String, ByVal ProductionStage As String, ByVal StepNo As String, ByVal FromDate As String, ByVal ToDate As String, ByRef Attendance As List(Of FinisarAttendance), ByRef requestid As Int64) As Boolean

        Try
            Dim inputdata As New Hashtable
            If (FromDate = "" Or FromDate Is Nothing) Then
                m_errormessage = "FromDate 不能为空"
                Return False
            End If
            If (ToDate = "" Or ToDate Is Nothing) Then
                m_errormessage = "ToDate 不能为空"
                Return False
            End If
            If (Department = "" Or Department Is Nothing) Then
                m_errormessage = "Department 不能为空"
                Return False
            End If
            If (ProjectCode = "" Or ProjectCode Is Nothing) Then
                m_errormessage = "ProjectCode 不能为空"
                Return False
            End If
            If ProductionStage Is Nothing Then
                ProductionStage = ""
            End If
            If StepNo Is Nothing Then
                StepNo = ""
            End If
            inputdata.Add("Department", Department)
            inputdata.Add("ProjectCode", ProjectCode)
            inputdata.Add("ProductionStage", ProductionStage)

            inputdata.Add("StepNo", StepNo)
            inputdata.Add("FromDate", FromDate)
            inputdata.Add("ToDate", ToDate)
            inputdata.Add("returnparms", "Attendance")
            Dim taskreturndata As Task(Of Hashtable) = RealsunClientNet.Execute("getAttendanceByStepNo", inputdata, requestid)
            Dim returndata As Hashtable = taskreturndata.Result
            If Convert.ToInt16(returndata("error")) <> 0 Then
                m_errormessage = "函数调用成功，但是远程服务器响应错误：" + Convert.ToString(returndata("message"))
                Return False
            End If
            requestid = Convert.ToInt64(returndata("requestid"))
            Dim array_Attendance As New ArrayList


            array_Attendance = DirectCast(returndata("data")("Attendance"), ArrayList)


            Attendance = convert2ListOfAttendance(array_Attendance)


            If Attendance Is Nothing Then
                m_errormessage = " List(Of Attendance) 无数据返回"
                Return False
            End If

            Return True
        Catch ex As Exception
            m_errormessage = ex.Message.ToString()
            Return False
        End Try
        Return False
    End Function

End Class


