Imports System.Data.SqlClient

Public Class LoginForm

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If ValidateLogin(username, password) Then
            Dim role As String = GetUserRole(username)
            MessageBox.Show("Login berhasil. Selamat datang, " & username & "!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Beralih ke form yang sesuai berdasarkan peran pengguna
            Select Case role
                Case "administrator"
                    Dim adminForm As New AdminForm()
                    adminForm.Show()
                Case "personalia"
                    Dim personaliaForm As New PersonaliaForm()
                    personaliaForm.Show()
                Case "gudang"
                    Dim gudangForm As New GudangForm()
                    gudangForm.Show()
                Case "kasir"
                    Dim kasirForm As New KasirForm()
                    kasirForm.Show()
                Case "manager"
                    Dim managerForm As New ManagerForm()
                    managerForm.Show()
            End Select

            ' Sembunyikan form login setelah login berhasil
            Me.Hide()
        Else
            MessageBox.Show("Login gagal. Username atau password salah.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Public Function ValidateLogin(ByVal username As String, ByVal password As String) As Boolean
        Try
            koneksi() ' Panggil fungsi koneksi untuk menginisialisasi objek con
            Dim query As String = "SELECT COUNT(*) FROM akun WHERE Username=@Username AND Password=@Password"
            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@Password", password)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function GetUserRole(ByVal username As String) As String
        Dim role As String = ""
        Try
            koneksi() ' Panggil fungsi koneksi untuk menginisialisasi objek con
            Dim query As String = "SELECT Role FROM akun WHERE Username=@Username"
            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Username", username)

            rd = cmd.ExecuteReader()
            If rd.HasRows Then
                While rd.Read()
                    role = rd("Role").ToString()
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            rd.Close()
            con.Close()
        End Try
        Return role
    End Function



End Class
