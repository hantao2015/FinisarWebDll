Imports System
Imports System.Collections.Generic
Imports System.Net
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Collections
Imports MiniUiAppCode.Utils
Imports MiniUiAppCode



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
            Return m_errormessage

        End Function

    End Class


