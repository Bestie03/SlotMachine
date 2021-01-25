Public Class Form1
    Dim amount, x, a, b, c As Integer


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        amount = Val(TextBox1.Text)
        If amount > 0 Then
            Button1.Visible = False
        End If
    End Sub

    Sub spin()

        If amount < 1 Then
            Label3.Text = "Insufficient betting funds!"
        Else

            x = x + 10
            a = 3 + Int(Rnd() * 3)
            b = 3 + Int(Rnd() * 3)
            c = 3 + Int(Rnd() * 3)

            Label3.Text = "Good Luck!"


            If a = 3 Then
                PictureBox1.Image = Image.FromFile("C:\Users\cian2\Downloads\7.jpg")
            End If
            If a = 4 Then
                PictureBox1.Image = Image.FromFile("C:\Users\cian2\Downloads\bb.jpg")
            End If

            If a = 5 Then
                PictureBox1.Image = Image.FromFile("C:\Users\cian2\Downloads\cherry.jpg")
            End If

            If b = 3 Then
                PictureBox2.Image = Image.FromFile("C:\Users\cian2\Downloads\7.jpg")
            End If

            If b = 4 Then
                PictureBox2.Image = Image.FromFile("C:\Users\cian2\Downloads\bb.jpg")
            End If
            If b = 5 Then
                PictureBox2.Image = Image.FromFile("C:\Users\cian2\Downloads\cherry.jpg")
            End If


            If c = 3 Then
                PictureBox3.Image = Image.FromFile("C:\Users\cian2\Downloads\7.jpg")
            End If

            If c = 4 Then
                PictureBox3.Image = Image.FromFile("C:\Users\cian2\Downloads\bb.jpg")
            End If

            If c = 5 Then
                PictureBox3.Image = Image.FromFile("C:\Users\cian2\Downloads\cherry.jpg")
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If x < 500 Then
            spin()
        Else
            Timer1.Enabled = False

            Label3.ImageAlign = 2

            If (a = 4 And b = 4 And c = 4) Then
                Label3.Text = " You win 20 dollars"
                amount = amount + 20
                TextBox1.Text = amount


            ElseIf (a = 3 And b = 3 And c = 3) Then
                Label3.Text = " You win 30 dollars"
                amount = amount + 30
                TextBox1.Text = amount




            ElseIf (a = 5 And b = 5 And c = 5) Then

                Label3.Text = " Congratulation! Jackpot!!! You win 200 dollars!"
                amount = amount + 200
                TextBox1.Text = amount


            Else
                Label3.Text = " Too bad, you lost 50 dollars"
                amount = amount - 50
                TextBox1.Text = amount
            End If

            If amount < 1 Then
                Label3.Text = " Uh Oh Spaghettios! you're bankrupt!"
                TextBox1.Text = Str$(amount)
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = " Welcome to Blips and Chitz!"

    End Sub

    Private Sub Spin_Button_Click(sender As Object, e As EventArgs) Handles Spin_Button.Click
        Timer1.Enabled = True

        x = 0
        Label2.Text = "Your Credits"

    End Sub
End Class

