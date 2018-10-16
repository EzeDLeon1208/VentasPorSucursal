Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "
        Textbox5.Text = " "
        TextBox6.Text = " "
        TextBox7.Text = " "
        TextBox8.Text = " "
        TextBox9.Text = " "
        TextBox10.Text = " "
        TextBox11.Text = " "
        TextBox12.Text = " "
        TextBox13.Text = " "
        TextBox14.Text = " "
        TextBox15.Text = " "
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim NAbril1, NAbril2, NAbril3, NMayo1, NMayo2, NMayo3, TotalSuc1, TotalSuc2, TotalSuc3, TGeneral, PorVen1, PorVen2, PorVen3 As Double

        NAbril1 = TextBox3.Text
        NAbril2 = TextBox8.Text
        NAbril3 = TextBox13.Text
        NMayo1 = TextBox4.Text
        NMayo2 = TextBox9.Text
        NMayo3 = TextBox14.Text


        TextBox16.Text = NAbril1 + NMayo1
        TotalSuc1 = TextBox16.Text
        TextBox17.Text = NAbril2 + NMayo2
        TotalSuc2 = TextBox17.Text
        TextBox18.Text = NAbril3 + NMayo3
        TotalSuc3 = TextBox18.Text

        TextBox19.Text = TotalSuc1 + TotalSuc2 + TotalSuc3
        TGeneral = TextBox19.Text

        Textbox5.Text = (TotalSuc1 * 100) / TGeneral
        PorVen1 = Textbox5.Text

        TextBox10.Text = (TotalSuc2 * 100) / TGeneral
        PorVen2 = TextBox10.Text

        TextBox15.Text = (TotalSuc3 * 100) / TGeneral
        PorVen3 = TextBox15.Text


    End Sub
End Class
