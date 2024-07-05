Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tipler As String() = {"Gün", "Hafta", "Ay", "Yıl"}
        CBoxFarkTipi.Items.AddRange(tipler)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ilktarih, sontarih As Date
        Dim farktipi As String
        Dim fark As Long

        ilktarih = DTPİlk.Value
        sontarih = DTPSon.Value
        farktipi = CBoxFarkTipi.SelectedItem.ToString()


        Select Case farktipi
            Case "Gün"
                fark = DateDiff(DateInterval.Day, ilktarih, sontarih)
            Case "Hafta"
                fark = DateDiff(DateInterval.WeekOfYear, ilktarih, sontarih)
            Case "Ay"
                fark = DateDiff(DateInterval.Month, ilktarih, sontarih)
            Case "Yıl"
                fark = DateDiff(DateInterval.Year, ilktarih, sontarih)
            Case Else
                MessageBox.Show("Bir fark tipi seçmelisiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
        TBoxFark.Text = fark.ToString()
    End Sub
End Class
