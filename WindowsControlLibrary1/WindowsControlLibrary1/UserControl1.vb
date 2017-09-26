Public Class UserControl1
    Private lanenumber As Integer
    Public UserControl1(lanenumber)
    Private Sub RacerName_TextChanged(sender As Object, e As EventArgs) Handles RacerName.TextChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Print(ListBox1.SelectedIndex)
    End Sub
End Class
