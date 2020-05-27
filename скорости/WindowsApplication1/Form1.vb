Imports System.Data.OleDb
Public Class Form1
    Public Property TextBox2 As Object

    Private Sub RefreshGrid()
        Dim c As New OleDbCommand
        c.Connection = conn
        c.CommandText = "select * from Планеты"
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter(c)
        da.Fill(ds, "Планеты")
        Grid1.DataSource = ds
        Grid1.DataMember = "Планеты"
        Grid1.Columns("ID").Visible = False
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn = New OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Professional\Documents\Планеты1.accdb;Persist Security Info=False;"
        conn.Open()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RefreshGrid()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim _s1 As String
        Dim _s2 As Double
        Dim _s3 As Double
        Dim _r As DialogResult
        Form2.ShowDialog()

        _s1 = Form2.TextBox1.Text
        _s2 = Form2.TextBox2.Text
        _s3 = Form2.TextBox3.Text

        _r = Form2.DialogResult

        If _r <> DialogResult.OK Then
            Exit Sub
        End If

        Form2.Close()
        Dim c As New OleDbCommand
        c.Connection = conn
        c.CommandText = "insert into [Планеты]([Планета], [Масса планеты], [Радиус]) values('" & _s1 & "' , '" & _s2 & "' , '" & _s3 & "') "
        c.ExecuteNonQuery()
        RefreshGrid()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim _k As Integer
        _k = Grid1.CurrentRow.Cells("ID").Value
        Dim c As New OleDbCommand
        c.Connection = conn
        c.CommandText = "delete from Планеты where id = " & _k
        c.ExecuteNonQuery()
        RefreshGrid()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form3.Show()
        RefreshGrid()
    End Sub
End Class
