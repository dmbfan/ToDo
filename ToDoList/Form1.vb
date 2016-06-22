Public Class ToDo

    Dim W As IO.StreamWriter



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        lstBxList.Items.Remove(lstBxList.Text)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstBxList.Items.Add(txtText.Text)
        txtText.Clear()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBxList.SelectedIndexChanged

    End Sub

    Private Sub txtText_TextChanged(sender As Object, e As EventArgs) Handles txtText.TextChanged

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim i As Integer
        W = New IO.StreamWriter("C:\" & txtBxSave.Text & ".txt")
        For i = 0 To lstBxList.Items.Count - 1
            W.WriteLine(lstBxList.Items.Item(i))
        Next

    End Sub
End Class
