Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; userid=root; password=root; database= crud_demo_db"

        Try
            conn.Open()
            MessageBox.Show("Connected")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    'CREATE BUTTON
    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Dim query As String = "INSERT INTO students_tbl (name, age, email) VALUES (@name, @age, @email)"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database= crud_demo_db")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", TextName.Text)
                    cmd.Parameters.AddWithValue("@age", CInt(TextAge.Text))
                    cmd.Parameters.AddWithValue("@email", TextEmail.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record Insert Succesfully")
                    RefreshGrid()
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub

    'READ BUTTON
    Private Sub ReadButton_Click(sender As Object, e As EventArgs) Handles ReadButton.Click
        Dim query As String = "SELECT id, name, age, email FROM crud_demo_db.students_tbl"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database= crud_demo_db")
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'EDIT BUTTON
    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MessageBox.Show("Select a record")
            Return
        End If

        TextName.Text = DataGridView1.CurrentRow.Cells("name").Value.ToString()
        TextAge.Text = DataGridView1.CurrentRow.Cells("age").Value.ToString()
        TextEmail.Text = DataGridView1.CurrentRow.Cells("email").Value.ToString()
    End Sub

    'UPDATE BUTTON
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MessageBox.Show("Select a record")
            Return
        End If

        Dim id As Integer = CInt(DataGridView1.CurrentRow.Cells("id").Value)
        Dim query As String = "UPDATE students_tbl SET name=@name, age=@age, email=@email WHERE id=@id"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database= crud_demo_db")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@name", TextName.Text)
                    cmd.Parameters.AddWithValue("@age", CInt(TextAge.Text))
                    cmd.Parameters.AddWithValue("@email", TextEmail.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record Updated")
                    RefreshGrid()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'DELETE BUTTON
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MessageBox.Show("Select a record")
            Return
        End If

        Dim id As Integer = CInt(DataGridView1.CurrentRow.Cells("id").Value)
        Dim query As String = "DELETE FROM students_tbl WHERE id=@id"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database= crud_demo_db")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record Deleted")
                    RefreshGrid()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RefreshGrid()
        Dim query As String = "SELECT id, name, age, email FROM crud_demo_db.students_tbl"
        Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database= crud_demo_db")
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub


End Class