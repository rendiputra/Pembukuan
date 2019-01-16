Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtuser.Text = "admin" And txtpw.Text = "admin" Then
            Form1.Show()
            Me.Hide()
        Else MsgBox("Username Dan Password Tidak Valid")
        End If
    End Sub

    Private Sub txtuser_MouseEnter(sender As Object, e As EventArgs) Handles txtuser.MouseEnter
        If txtuser.Text = "Username" Then
            txtuser.Text = ""
        End If
    End Sub

    Private Sub txtuser_MouseLeave(sender As Object, e As EventArgs) Handles txtuser.MouseLeave
        If txtuser.Text = "" Then
            txtuser.Text = "Username"
        End If
    End Sub

    Private Sub txtpw_MouseLeave(sender As Object, e As EventArgs) Handles txtpw.MouseLeave
        If txtpw.Text = "" Then
            txtpw.Text = "Password"
            txtpw.PasswordChar = ""
        End If
    End Sub

    Private Sub txtpw_MouseEnter(sender As Object, e As EventArgs) Handles txtpw.MouseEnter
        If txtpw.Text = "Password" Then
            txtpw.Text = ""
            txtpw.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtuser.Text = "Username"
        txtpw.Text = "Password"
    End Sub

    Private Sub txtpw_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpw.KeyPress
        txtpw.PasswordChar = "*"
    End Sub
End Class