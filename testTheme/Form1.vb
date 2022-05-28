Public Class Form1

    Dim con As Object

    Private Sub btclose_Click(sender As Object, e As EventArgs) Handles btclose.Click
        Me.Close()
    End Sub

    Private Sub btdef_Click(sender As Object, e As EventArgs) Handles btdef.Click
        Me.BackColor = Color.White
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If lblogin.ForeColor = Color.Red Then
            lblogin.ForeColor = Color.Green
        Else
            lblogin.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btset_Click(sender As Object, e As EventArgs) Handles btset.Click
        pnltheme.Visible = False
        Me.Width = 380
        Me.Height = 165
        btclose1.Visible = True
        lbtheme.Visible = True
    End Sub

    Private Sub lbtheme_Click(sender As Object, e As EventArgs) Handles lbtheme.Click
        Me.Width = 667
        Me.Height = 300
        btclose1.Visible = False
        pnltheme.Visible = True
        btclose.Visible = True
        lbtheme.Visible = False
        pnlscrol.Visible = True
    End Sub

    Private Sub btclose1_Click(sender As Object, e As EventArgs) Handles btclose1.Click
        Me.Close()
    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Me.BackColor = Button3.BackColor
    End Sub

    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles Button5.MouseEnter
        Me.BackColor = Button5.BackColor
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Me.BackColor = Button1.BackColor
    End Sub

    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Me.BackColor = Button4.BackColor
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Me.BackColor = Button2.BackColor
    End Sub

    Private Sub btclean_Click(sender As Object, e As EventArgs) Handles btclean.Click
        txtusrnam.Text = ""
        txtpass.Text = ""
    End Sub

    Private Sub hsred_Scroll(sender As Object, e As ScrollEventArgs) Handles hsred.Scroll
        Me.BackColor = Color.FromArgb(hsred.Value, hsgreen.Value, hsblue.Value)
    End Sub

    Private Sub hsgreen_Scroll(sender As Object, e As ScrollEventArgs) Handles hsgreen.Scroll
        Me.BackColor = Color.FromArgb(hsred.Value, hsgreen.Value, hsblue.Value)
    End Sub

    Private Sub hsblue_Scroll(sender As Object, e As ScrollEventArgs) Handles hsblue.Scroll
        Me.BackColor = Color.FromArgb(hsred.Value, hsgreen.Value, hsblue.Value)
    End Sub

    Private Sub btlogin_Click(sender As Object, e As EventArgs) Handles btlogin.Click
        MessageBox.Show("Form Submitted")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 165
        Me.Width = 379
    End Sub
End Class
