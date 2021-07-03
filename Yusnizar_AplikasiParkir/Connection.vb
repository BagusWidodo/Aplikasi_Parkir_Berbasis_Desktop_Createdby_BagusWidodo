Imports System.Data.Odbc
Module Connection

    Public conn As OdbcConnection
    Public cmd As New OdbcCommand
    Public dr As OdbcDataReader
    Public da As OdbcDataAdapter
    Public ds As New DataSet
    Public dt As DataTable
    Public data As String

    Public Sub Koneksi()
        Try
            Dim data As String
            data = "Driver={MySQL ODBC 3.51 Driver};Database=program_parkir;server=localhost;user=root"
            conn = New OdbcConnection(data)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub


End Module
