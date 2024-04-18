Imports System.Data.SqlClient
Module Module1
    Public con As SqlConnection ' Variabel untuk koneksi SQL Server
    Public cmd As SqlCommand ' Variabel untuk perintah SQL
    Public ds As DataSet ' Variabel untuk menyimpan data dalam bentuk dataset
    Public da As SqlDataAdapter ' Variabel untuk mengisi dataset danmemperbarui database
    Public rd As SqlDataReader ' Variabel untuk membaca data dari database
    Public db As String ' Variabel untuk nama database
    Public data_nomor As String ' Variabel untuk data nomor tertentu

    Public Sub koneksi()
        'fungsi initial catalog adalah database yang kita buat apa untuk koneksi , data source kenapa local agar kalau mau jaringan atau berdiri sendiri
        ' di sistem langsung terhubng ke sql server, integreted security itu standart bawaan sql server
        db = "Integrated Security=SSPI; Persist Security Info=True;Initial Catalog=tif_mart; Data Source=DESKTOP-F087824"

        con = New SqlConnection(db)
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                MsgBox("Koneksi ke database berhasil", MsgBoxStyle.Information, "Informasi")

            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Public Function SQLTable(ByVal Source As String) As DataTable
        ' --- Fungsi untuk membuat nomor otomatis dengan menghubungkan padafield yang ada di table ---
        Try
            Dim adp As New SqlClient.SqlDataAdapter(Source, con) ' Membuatobjek SqlDataAdapter untuk mengambil data dari database dengan perintah SQLyang diberikan
            Dim DT As New DataTable ' Membuatobjek DataTable untuk menyimpan data dari database

            adp.Fill(DT) ' MengisiDataTable dengan data yang diambil dari database

            SQLTable = DT 'Mengembalikan DataTable yang berisi data dari database
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message) 'Menampilkan pesan kesalahan jika terjadi SqlException

            SQLTable = Nothing 'Mengembalikan nilai Nothing jika terjadi kesalahan
        End Try
    End Function

End Module