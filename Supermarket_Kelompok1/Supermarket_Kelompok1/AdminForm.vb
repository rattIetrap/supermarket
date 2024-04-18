Imports System.Data.SqlClient

Public Class AdminForm
    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbUserRole.Items.Add("admin")
        cmbUserRole.Items.Add("personalia")
        cmbUserRole.Items.Add("gudang")
        cmbUserRole.Items.Add("kasir")
        cmbUserRole.Items.Add("manager")

    End Sub
    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click
        ' Implementasi untuk membuat pengguna baru
        ' Ambil data dari TextBox
        Dim username As String = txtNewUsername.Text
        Dim password As String = txtNewPassword.Text
        Dim role As String = cmbUserRole.SelectedItem.ToString()
        Dim fullName As String = txtFullName.Text ' Ambil nama lengkap dari TextBox

        ' Masukkan data ke dalam tabel akun
        Dim query As String = "INSERT INTO akun (Username, Password, Role, Nama_Pengguna) VALUES (@Username, @Password, @Role, @Nama_Pengguna)"
        cmd = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@Username", username)
        cmd.Parameters.AddWithValue("@Password", password)
        cmd.Parameters.AddWithValue("@Role", role)
        cmd.Parameters.AddWithValue("@Nama_Pengguna", fullName)

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Pengguna berhasil dibuat.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click
        ' Implementasi untuk melihat laporan data pengguna
        Dim query As String = "SELECT Username, Role FROM akun"
        Dim adapter As New SqlDataAdapter(query, con)
        Dim table As New DataTable()

        Try
            con.Open()
            adapter.Fill(table)
            dgvUserReport.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Tutup form AdminForm
        Me.Close()

        ' Tampilkan kembali form login
        Dim loginForm As New LoginForm()
        loginForm.Show()
    End Sub


End Class
