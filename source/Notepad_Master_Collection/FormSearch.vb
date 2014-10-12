Public Class formSearch

    Private Sub textSearch_TextChanged(sender As Object, e As EventArgs) Handles textSearch.TextChanged
        buttonSearch.Enabled = textSearch.Text <> ""
    End Sub

    Private Sub buttonSearch_Click(sender As Object, e As EventArgs) Handles buttonSearch.Click
        MySearch()
        textSearch.Focus()
    End Sub

    Private Sub textSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textSearch.KeyPress
        If AscW(e.KeyChar) = 13 Then
            MySearch()
        End If
        If AscW(e.KeyChar) = 27 Then
            Me.Close()
        End If
    End Sub

    Private Sub buttonCancel_Click(sender As Object, e As EventArgs) Handles buttonCancel.Click
        Me.Close()
    End Sub

    Public Sub MySearch()
        Dim strPos As Integer = formNotepad.richNotepad.Text.IndexOf(textSearch.Text, formNotepad.richNotepad.SelectionStart)
        If strPos = formNotepad.richNotepad.SelectionStart And formNotepad.richNotepad.SelectedText = textSearch.Text Then
            strPos = formNotepad.richNotepad.Text.IndexOf(textSearch.Text, formNotepad.richNotepad.SelectionStart + 1)
        End If
        If strPos <> -1 Then
            formNotepad.richNotepad.Select(strPos, textSearch.Text.Length)
            formNotepad.SearchString = textSearch.Text
        End If
    End Sub
End Class