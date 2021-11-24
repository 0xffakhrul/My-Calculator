Public Class Calculator

    Dim firstNum As Decimal
    Dim secondNum As Decimal
    Dim ops As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "7"
        Else
            txtDisplay.Text = "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "8"
        Else
            txtDisplay.Text = "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "9"
        Else
            txtDisplay.Text = "9"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "4"
        Else
            txtDisplay.Text = "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "5"
        Else
            txtDisplay.Text = "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "6"
        Else
            txtDisplay.Text = "6"
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "1"
        Else
            txtDisplay.Text = "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "2"
        Else
            txtDisplay.Text = "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "3"
        Else
            txtDisplay.Text = "3"
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "0"
        End If
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtDisplay.Text = "0"
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        firstNum = txtDisplay.Text
        txtDisplay.Text = "0"
        ops = "/"
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        firstNum = txtDisplay.Text
        txtDisplay.Text = "0"
        ops = "+"
    End Sub

    Private Sub btnSubstract_Click(sender As Object, e As EventArgs) Handles btnSubstract.Click
        firstNum = txtDisplay.Text
        txtDisplay.Text = "0"
        ops = "-"
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        firstNum = txtDisplay.Text
        txtDisplay.Text = "0"
        ops = "*"
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        secondNum = txtDisplay.Text
        If ops = "+" Then
            txtDisplay.Text = firstNum + secondNum
        ElseIf ops = "-" Then
            txtDisplay.Text = firstNum - secondNum
        ElseIf ops = "*" Then
            txtDisplay.Text = firstNum * secondNum
        Else
            If secondNum = "0" Then
                txtDisplay.Text = "Cannot divide by zero"
            Else
                txtDisplay.Text = firstNum / secondNum
            End If
        End If
    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "."
        Else
            txtDisplay.Text = "."
        End If
    End Sub
End Class
