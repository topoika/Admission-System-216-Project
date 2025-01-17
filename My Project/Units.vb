﻿Imports System.Data.OleDb

Public Class Units
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Adm\source\repos\Admission\MainDb.mdb")
    'Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\source\repos\DB\MainDb.mdb")
    Dim maxCredits As Integer = 0
    Private Sub Load_data()
        conn.Open()
        Dim cmd As New OleDbCommand("select Name, Description, Lecturer, CreditHours from Units WHERE NAME NOT IN (SELECT NAME FROM Selected WHERE AdmNo = @AdmNo)", conn)
        cmd.Parameters.AddWithValue("@AdmNo", Me.Tag.ToString().Substring(0, 7))
        Dim dt As New OleDbDataAdapter
        dt.SelectCommand = cmd
        Dim Selected As New DataTable
        Selected.Clear()
        dt.Fill(Selected)
        DataGridView1.DataSource = Selected
        conn.Close()
        Dim checkboxcol As New DataGridViewCheckBoxColumn
        checkboxcol.Width = 40
        checkboxcol.Name = "checkboxcol"
        checkboxcol.HeaderText = "Selected"
        DataGridView1.Columns.Insert(0, checkboxcol)
    End Sub

    Private Sub PLoad_data()
        conn.Open()
        Dim cmd As New OleDbCommand("select Name, Description, Lecturer, CreditHours from Selected WHERE AdmNo = @admissionNumber", conn)
        cmd.Parameters.AddWithValue("@admissionNumber", Me.Tag.ToString().Substring(0, 7))
        Dim dtb As New OleDbDataAdapter
        dtb.SelectCommand = cmd
        Dim Selected As New DataTable
        Selected.Clear()
        dtb.Fill(Selected)
        DataGridView2.DataSource = Selected
        conn.Close()
        Dim checkboxcol As New DataGridViewCheckBoxColumn
        checkboxcol.Width = 40
        checkboxcol.Name = "checkboxfordrop"
        checkboxcol.HeaderText = "Drop"
        DataGridView2.Columns.Insert(0, checkboxcol)
        For Each item As DataGridViewRow In DataGridView2.Rows
            maxCredits = maxCredits + 3
        Next
        MaxCreditsText.Text = maxCredits.ToString() + "/" + Me.Tag.ToString().Substring(8) + " Hours"
    End Sub
    Private Sub Units_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PLoad_data()
        Load_data()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If maxCredits > Integer.Parse(Me.Tag.ToString().Substring(8)) Then
            MessageBox.Show("You've exceeded you maximum creadit hours")
        Else
            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim select1 As Boolean = Convert.ToBoolean(row.Cells("checkboxcol").Value)
                If select1 Then
                    conn.Open()
                    Dim sql As String = "insert into Selected (AdmNo,Name,Description,Lecturer,CreditHours) values(@AdmNumber,@Name,@Description,@Lecturer,@CreditHours)"
                    Dim cmd1 As New OleDbCommand(sql, conn)
                    cmd1.Parameters.AddWithValue("@AdmNumber", Me.Tag.ToString().Substring(0, 7))
                    cmd1.Parameters.AddWithValue("@Name", row.Cells("Name").Value)
                    cmd1.Parameters.AddWithValue("@Description", row.Cells("Description").Value)
                    cmd1.Parameters.AddWithValue("@Lecturer", row.Cells("Lecturer").Value)
                    cmd1.Parameters.AddWithValue("@CreditHours", row.Cells("CreditHours").Value)
                    cmd1.ExecuteNonQuery()
                    conn.Close()
                End If
            Next
            maxCredits = 0
            DataGridView2.Columns.RemoveAt(0)
            Me.Refresh()
            PLoad_data()
            MessageBox.Show("You have regirster for units")
        End If
    End Sub
    Private Sub ExitAddUnits_Click(sender As Object, e As EventArgs) Handles ExitAddUnits.Click
        Portal.Tag = Me.Tag.ToString().Substring(0, 7)
        Portal.Show()
        Me.Close()
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If maxCredits > Integer.Parse(Me.Tag.ToString().Substring(8)) Or maxCredits + Integer.Parse(DataGridView1.Rows(e.RowIndex).Cells(4).Value) > Integer.Parse(Me.Tag.ToString().Substring(8)) Then
            MessageBox.Show("You've exceeded you maximum creadit hours  ")
        Else
            maxCredits = maxCredits + Integer.Parse(DataGridView1.Rows(e.RowIndex).Cells(4).Value)
            MaxCreditsText.Text = maxCredits.ToString() + "/" + Me.Tag.ToString().Substring(8) + " Hours"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each row As DataGridViewRow In DataGridView2.Rows
            Dim select1 As Boolean = Convert.ToBoolean(row.Cells("checkboxfordrop").Value)
            If select1 Then
                conn.Open()
                Dim sql As String = "delete * from Selected where ID= @id"
                Dim cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", row.Cells("ID").Value)
                cmd.ExecuteNonQuery()
                conn.Close()
            End If
        Next
        DataGridView2.Columns.RemoveAt(0)
        maxCredits = 0
        PLoad_data()
        Me.Refresh()
        MessageBox.Show("You've dropped the units")

    End Sub
End Class