Imports System.Data.OleDb
Public Class Form1
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Dim con As New OleDbConnection("Provider=Microsoft.jet.Oledb.4.0; Data source=C:\Users\Dell\Downloads\SistemaMatricula-master\Base de datos\Matricula.mdb")
        Try
            con.Open()
            MsgBox("Conectado")

            Dim query = "Select * from Alumnos"
            Dim adap As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adap.Fill(dt)
            DataGridView1.DataSource = dt


        Catch ex As Exception

            MsgBox("No se econectó por:" & ex.Message)

        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Form2.Show()
    End Sub
End Class
