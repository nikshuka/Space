Imports System.Data.OleDb
Imports System.Math
Public Class Form3
    Const G As Double = 0.00000000006672
    Dim _id As Int16
    Dim _h As Double
    Dim _m As Double
    Dim _r As Double
    Dim _v1 As Double
    Dim _v2 As Double
    Dim c As New OleDbCommand
    Dim ds As New DataSet
    Dim da As New OleDbDataAdapter(c)
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Планеты1DataSet1.Планеты' table. You can move, or remove it, as needed.
        ПланетыTableAdapter.Fill(Солнечная_системаDataSet1.Планеты)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            _id = Int16.Parse(ComboBox1.SelectedValue)
            _h = Double.Parse(TextBox3.Text)

        Catch ex As Exception
            MsgBox("Ошибка")
        End Try
        Dim planets = ПланетыTableAdapter.GetData()
        Dim rows = From Планеты In planets
                   Where Планеты.ID = _id
                   Select Планеты.Масса_планеты, Планеты.Радиус
        For Each row As Object In rows
            _m = row.Масса_планеты
            _r = row.Радиус
        Next
        _v1 = Sqrt((G * _m) / (_r + _h))
        _v2 = _v1 * Sqrt(2)
        TextBox1.Text = _v1
        TextBox2.Text = _v2
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        c.Connection = conn
        c.CommandText = "select * from Планеты"
        da.Fill(ds, "Планеты")
        Grid1.DataSource = ds
        Grid1.DataMember = "Планеты"
    End Sub

End Class