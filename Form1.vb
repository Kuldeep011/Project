Public Class Form1
    Dim QSNs() As String = {"Which company developed .net framwork?", "What is the full form of MSIL?", "In vb.net Dim is used for?", "Who is the founder of Java?"}
    Dim Qsn_1_ans() As String = {"(a) Microsoft", "(b) IBM", "(c) Google", "(d) Meta"}
    Dim Qsn_2_ans() As String = {"(a) Misile", "(b) Microsoft Intermediate Language", "(c) Both", "(d) None"}
    Dim Qsn_3_ans() As String = {"(a) To create Function", "(b) Access Specifire", "(c) To Declare Variable", "(d) None "}
    Dim Qsn_4_ans() As String = {"(a) Dennis Ritchi", "(b) Jems Gosling", "(c) Mick Seridan", "(d) Gudo Van Rossum"}
    Dim ans() As String = {"(a)", "(b)", "(c)", "(b)"}
    Dim Qsn_Num As Integer = 1
    Dim index As Integer = 0
    Dim score As Integer = 0
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim an As String = ComboBox1.Text
        ComboBox1.Text = ""
        If an = ans(index) And index < 4 Then
            score += 10
        End If
        Qsn_Num += 1
        index += 1
        If Qsn_Num < 5 Then
            TextBox2.Text = Qsn_Num
            TextBox3.Text = QSNs(index)
            TextBox4.Clear()
            For i = 0 To 3
                If Qsn_Num = 2 Then
                    TextBox4.AppendText(Qsn_2_ans(i))
                    TextBox4.AppendText(vbNewLine)
                ElseIf Qsn_Num = 3 Then
                    TextBox4.AppendText(Qsn_3_ans(i))
                    TextBox4.AppendText(vbNewLine)
                Else
                    TextBox4.AppendText(Qsn_4_ans(i))
                    TextBox4.AppendText(vbNewLine)
                    Button2.Text = "Finish"
                End If
            Next
        Else
            MsgBox("Your score: " + CStr(score))
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.Text = Qsn_Num
        TextBox3.Text = QSNs(index)
        TextBox1.Text = "Basics test of programming"
        For i = 0 To 3
            TextBox4.AppendText(Qsn_1_ans(i))
            TextBox4.AppendText(vbNewLine)
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
