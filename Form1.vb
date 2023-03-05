Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Display.Click
        namaout.Text = TBName.Text
        phoneout.Text = TBPhone.Text
        mailout.Text = TBEmail.Text
        fbout.Text = TBFb.Text
        igout.Text = TBIg.Text



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint


    End Sub

    Private Sub TBName_TextChanged(sender As Object, e As EventArgs) Handles TBName.TextChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles labelname.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles labelphone.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        Controls.Clear()
        InitializeComponent()

    End Sub
End Class
