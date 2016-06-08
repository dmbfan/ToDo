Public Class ToDo
    Friend Item

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstBxList.Items.AddRange(txtText.Text.Split(vbNewLine))
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBxList.SelectedIndexChanged

    End Sub

    Private Sub txtText_TextChanged(sender As Object, e As EventArgs) Handles txtText.TextChanged

    End Sub
End Class
