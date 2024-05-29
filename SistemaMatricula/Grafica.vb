Imports System.Data.OleDb
Public Class Grafica
    Private Sub Grafica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=C:\Users\Dell\Downloads\SistemaMatricula-master\Base de datos\Matricula.mdb")
        Try
            conexion.Open()
            MsgBox("Conectado")

            Dim query = "Select * from Alumnos"
            Dim adap As New OleDbDataAdapter(query, conexion)
            Dim dt As New DataTable
            adap.Fill(dt)
            Chart1.Series("Series1").XValueMember = "Nombre"
            Chart1.Series("Series1").YValueMembers = "edadEstudiante"
            Chart1.DataSource = dt


        Catch ex As Exception
            MsgBox("No se conecto por: " & ex.Message)

        End Try
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub
End Class