
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Form6
    Dim conn As New MySqlConnection
    Dim sda As New MySqlDataAdapter
    Dim reader As MySqlDataReader
    Dim cmd As New MySqlCommand
    Dim query As String
    Dim n As Boolean
    Public server As String
    Public appPath As String

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        appPath = Path.GetDirectoryName(Application.ExecutablePath)

        server = My.Computer.FileSystem.ReadAllText("" & appPath & "\db_connection.txt")
        Try
            conn.ConnectionString = server
            conn.Open()





            conn.Close()

            Timer1.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            n = True
            Timer1.Enabled = False
        Finally
            conn.Dispose()
        End Try
        If n = True Then
            MessageBox.Show("Please edit " & appPath & "\db_connection.txt or make sure you are connected to the network")

            Application.Exit()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        frm_login.Show()
        Me.Hide()
    End Sub
End Class