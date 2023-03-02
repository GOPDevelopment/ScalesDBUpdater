Imports System.Data.SqlTypes
Imports System.IO
Imports System.Runtime.InteropServices


Public Class ProductInfo
    Public Property UUID As Guid
    Public Property ScaleType As String
    Public Property ProductCode As String
    Public Property ProductDescription As String
    Public Property ProductDescription2 As String

    Public Property SetWeight As String
    Public Property NormalWeight As String

    Public Property ProductGrade As String
    Public Property Type As String


    Public Property Tare As String
    Public Property Tare2 As String

    Public Property MinWeight As String
    Public Property MaxWeight As String

    Public Property Lot As String
    Public Property ItemTareEach As String

    Public Property KickoutCount As String
    Public Property ItemCountPerBox As String

    Public Property SellByDays As String
    Public Property KillDate As String


    Public Property LabelTemplate As String
    Public Property AlphaDescription As String
    Public Property TestingDescription As String
    Public Property DateEntered As String


End Class
Module CommonStuff
    Function FixNull(ByVal szValue)
        If IsDBNull(szValue) Then
            Return ""
        Else
            Return szValue
        End If
    End Function
    Function FixNullString(ByVal szValue)
        If IsDBNull(szValue) Then
            Return ""
        Else
            Return szValue.ToString
        End If
    End Function
    Function FixNullInteger(ByVal szValue)
        If IsDBNull(szValue) Then
            Return 0
        ElseIf IsNumeric(szValue) Then
            Return CInt(szValue)
        Else
            Return 0
        End If
    End Function
    Function FixNullDecimal(ByVal szValue)
        If IsDBNull(szValue) Then
            Return 0
        ElseIf IsNumeric(szValue) Then
            Return CDec(szValue)
        Else
            Return 0
        End If
    End Function
    Function FixNullDate(ByVal szValue)
        If IsDBNull(szValue) Then
            Return ""
        Else
            Return Convert.ToDateTime(szValue.ToString).ToString("MM/dd/yyyy")
        End If
    End Function
    Function CheckBit(ByVal b As Boolean, ByVal endchar As String)
        If b Then
            Return "1" & endchar
        Else
            Return "0" & endchar
        End If
    End Function
    Function CheckString(ByVal s As String)
        Return CheckString(s, "")
    End Function
    Function CheckString(ByVal s As String, ByVal endchar As String)
        Dim pos = InStr(s, "'")
        While pos > 0
            s = Mid(s, 1, pos) & "'" & Mid(s, pos + 1)
            pos = InStr(pos + 2, s, "'")
        End While
        CheckString = "'" & s & "'" & endchar
    End Function
    Function CheckDate(ByVal szValue) As Nullable(Of Date)
        If szValue Is Nothing Or IsDBNull(szValue) Then
            Return Nothing
        ElseIf szValue.ToString = String.Empty Then
            Return Nothing
        Else
            Return Convert.ToDateTime(szValue.ToString).ToString("MM/dd/yyyy")
        End If
    End Function
    Function CheckValueForNull(ByVal s As String, ByVal endchar As String, ByVal IsString As Boolean)
        If String.IsNullOrEmpty(s) Then
            Return "NULL" & endchar
        Else
            If IsString Then
                Return CheckString(s, endchar)
            Else
                Return s & endchar
            End If
        End If
    End Function



    Sub CleanWorkFolder(tempWorkFolder As String)
        Dim OldFiles() As String = Directory.GetFiles(Environment.CurrentDirectory & tempWorkFolder, "*.palco.lbl*")
        For Each ThisFile As String In OldFiles
            Try
                If DateDiff(DateInterval.DayOfYear, File.GetLastWriteTime(ThisFile), Now) > 30 Then
                    File.Delete(ThisFile)
                End If
            Catch ex As Exception
                WriteToErrorLog(ex.Message, ex.StackTrace, "Error")

            End Try
        Next
    End Sub

    Private Sub CleanErrLogFolder()

        'clean out old err files
        Dim OldFiles() As String = Directory.GetFiles(Application.StartupPath & "\Errors\", "*.txt")
        For Each ThisFile As String In OldFiles
            Try
                If DateDiff(DateInterval.DayOfYear, File.GetLastWriteTime(ThisFile), Now) > 30 Then
                    File.Delete(ThisFile)
                End If

            Catch ex As Exception
                WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
            End Try
        Next

    End Sub

    Public Sub WriteToErrorLog(ByVal msg As String, ByVal stkTrace As String, ByVal title As String)
        Try

            If Not System.IO.Directory.Exists(Application.StartupPath & "\Errors\") Then
                System.IO.Directory.CreateDirectory(Application.StartupPath & "\Errors\")
            End If

            Dim fn As String = "errlog" & DateTime.Now.ToString("yyyyMMdd") & ".txt"

            'check the file
            Dim fs As FileStream = New FileStream(Application.StartupPath & "\Errors\" & fn, FileMode.OpenOrCreate, FileAccess.ReadWrite)
            Dim s As StreamWriter = New StreamWriter(fs)
            s.Close()
            fs.Close()

            'log it
            Dim fs1 As FileStream = New FileStream(Application.StartupPath & "\Errors\" & fn, FileMode.Append, FileAccess.Write)
            Dim s1 As StreamWriter = New StreamWriter(fs1)
            s1.Write("===== " & DateTime.Now.ToString() & "============================================================" & vbCrLf)
            s1.Write(title & ": " & msg & vbCrLf)
            s1.Write(stkTrace & vbCrLf)
            s1.Close()
            fs1.Close()

        Catch ex As Exception
            'do nothing, carry on
        End Try
    End Sub

    Public Sub WriteToLog(ByVal msg As String, ByVal stkTrace As String, ByVal title As String)
        Try

            If Not System.IO.Directory.Exists(Application.StartupPath & "\Errors\") Then
                System.IO.Directory.CreateDirectory(Application.StartupPath & "\Errors\")
            End If

            Dim fn As String = "errlog" & DateTime.Now.ToString("yyyyMMdd") & ".txt"

            'check the file
            Dim fs As FileStream = New FileStream(Application.StartupPath & "\Errors\" & fn, FileMode.OpenOrCreate, FileAccess.ReadWrite)
            Dim s As StreamWriter = New StreamWriter(fs)
            s.Close()
            fs.Close()

            'log it
            Dim fs1 As FileStream = New FileStream(Application.StartupPath & "\Errors\" & fn, FileMode.Append, FileAccess.Write)
            Dim s1 As StreamWriter = New StreamWriter(fs1)
            s1.Write("===== " & DateTime.Now.ToString() & "============= Informational Only ===========================" & vbCrLf)
            s1.Write(title & ": " & msg & vbCrLf)
            s1.Write(stkTrace & vbCrLf)
            s1.Close()
            fs1.Close()

        Catch ex As Exception
            'do nothing, carry on
        End Try
    End Sub


    '' Access the GetUserNameA function in advapi32.dll and
    '' call the function GetUserName.
    'Declare Function GetUserName Lib "advapi32.dll" Alias "GetUserNameA" (ByVal lpBuffer As String, nSize As Long) As Long

    '' Main routine to Dimension variables, retrieve user name and display answer.
    'Sub Get_User_Name()
    '    Dim lpBuff As String
    '    Dim ret As Long
    '    Dim UserName As String

    '    ' Get the user name minus any trailing spaces found in the name.
    '    ret = GetUserName(lpBuff, 25)
    '    UserName = Left(lpBuff, InStr(lpBuff, Chr(0)) - 1)

    '    ' Display the User Name
    '    MsgBox UserName
    ' End Sub

End Module

Public Class WinApi
    <DllImport("user32.dll", EntryPoint:="GetSystemMetrics")>
    Public Shared Function GetSystemMetrics(ByVal which As Integer) As Integer
    End Function

    <DllImport("user32.dll")>
    Public Shared Sub SetWindowPos(ByVal hwnd As IntPtr, ByVal hwndInsertAfter As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal width As Integer, ByVal height As Integer,
  ByVal flags As UInteger)
    End Sub

    Private Const SM_CXSCREEN As Integer = 0
    Private Const SM_CYSCREEN As Integer = 1
    Private Shared HWND_TOP As IntPtr = IntPtr.Zero
    Private Const SWP_SHOWWINDOW As Integer = 64
    ' 0×0040
    Public Shared ReadOnly Property ScreenX() As Integer
        Get
            Return GetSystemMetrics(SM_CXSCREEN)
        End Get
    End Property

    Public Shared ReadOnly Property ScreenY() As Integer
        Get
            Return GetSystemMetrics(SM_CYSCREEN)
        End Get
    End Property

    Public Shared Sub SetWinFullScreen(ByVal hwnd As IntPtr)
        SetWindowPos(hwnd, HWND_TOP, 0, 0, ScreenX, ScreenY,
         SWP_SHOWWINDOW)
    End Sub
End Class


Public Class FormState
    Private winState As FormWindowState
    Private brdStyle As FormBorderStyle
    Private topMost As Boolean
    Private bounds As Rectangle

    Private IsMaximized As Boolean = False

    Public Sub Maximize(ByVal targetForm As Form)
        If Not IsMaximized Then
            IsMaximized = True
            Save(targetForm)
            targetForm.WindowState = FormWindowState.Maximized
            targetForm.FormBorderStyle = FormBorderStyle.None
            targetForm.TopMost = True
            WinApi.SetWinFullScreen(targetForm.Handle)
        End If
    End Sub

    Public Sub Save(ByVal targetForm As Form)
        winState = targetForm.WindowState
        brdStyle = targetForm.FormBorderStyle
        topMost = targetForm.TopMost
        bounds = targetForm.Bounds
    End Sub

    Public Sub Restore(ByVal targetForm As Form)
        targetForm.WindowState = winState
        targetForm.FormBorderStyle = brdStyle
        targetForm.TopMost = topMost
        targetForm.Bounds = bounds
        IsMaximized = False
    End Sub
End Class
