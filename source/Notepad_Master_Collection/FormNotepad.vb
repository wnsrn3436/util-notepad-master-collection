Imports HelpPane

Public Class formNotepad
    Public Enum MyEdited
        NotEdited
        Edited
        OpenFile
    End Enum

    Public NotepadSize As Size
    Public SearchString As String = ""
    Public CurrentFile As String = "*.txt"
    Public IsEdited As MyEdited = MyEdited.NotEdited

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If NotepadSize = Nothing Then NotepadSize = New Size(Me.Width - richNotepad.Width, Me.Height - richNotepad.Height)
        richNotepad.Size = New Size(Me.Width - NotepadSize.Width, Me.Height - NotepadSize.Height)
    End Sub

    Private Sub 파일FToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles 파일FToolStripMenuItem.DropDownOpening
        MyEnabled()
    End Sub

    Private Sub 새로만들기NToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 새로만들기NToolStripMenuItem.Click
        If IsEdited = MyEdited.Edited Then
            If MessageBox.Show("변경 내용을 저장하시겠습니까?", "노트패드", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                MyOtherSave()
            End If
        End If
        IsEdited = MyEdited.OpenFile
        Me.Text = "Notepad Master Collection"
        CurrentFile = "*.txt"
        richNotepad.Text = ""
    End Sub

    Private Sub 열기OToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 열기OToolStripMenuItem.Click
        If IsEdited = MyEdited.Edited Then
            If MessageBox.Show("변경 내용을 저장하시겠습니까?", "노트패드", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                MyOtherSave()
            End If
        End If
        IsEdited = MyEdited.OpenFile
        Dim dialog As OpenFileDialog = New OpenFileDialog
        dialog.Filter = "텍스트 문서(*.txt)|*.txt|모든 파일 (*.*)|*.*"
        dialog.FileName = CurrentFile
        If dialog.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            CurrentFile = dialog.FileName
            Me.Text = CurrentFile
            Dim openFile As IO.TextReader = New IO.StreamReader(CurrentFile, System.Text.Encoding.Default)
            richNotepad.Text = openFile.ReadToEnd
            openFile.Close()
        End If
    End Sub

    Private Sub 저장SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 저장SToolStripMenuItem.Click
        If CurrentFile <> "*.txt" Then
            Dim writeFile As IO.TextWriter = New IO.StreamWriter(CurrentFile, False, System.Text.Encoding.Default)
            writeFile.Write(richNotepad.Text)
            writeFile.Close()
            IsEdited = MyEdited.NotEdited
            Me.Text = CurrentFile
        Else
            MyOtherSave()
        End If
    End Sub

    Private Sub 다른이름으로저장AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 다른이름으로저장AToolStripMenuItem.Click
        MyOtherSave()
    End Sub

    Private Sub 페이지설정SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 페이지설정SToolStripMenuItem.Click
        'Not Used
    End Sub

    Private Sub 인쇄PToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 인쇄PToolStripMenuItem.Click
        Dim dialog As PrintDialog = New PrintDialog
        dialog.ShowDialog()
    End Sub

    Private Sub 끝내기XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 끝내기XToolStripMenuItem.Click
        If IsEdited = MyEdited.Edited Then
            If MessageBox.Show("변경 내용을 저장하시겠습니까?", "노트패드", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                MyOtherSave()
            End If
        End If
        End
    End Sub

    Private Sub 편집EToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles 편집EToolStripMenuItem.DropDownOpening
        MyEnabled()
    End Sub

    Private Sub 실행취소UToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 실행취소UToolStripMenuItem.Click
        richNotepad.Undo()
    End Sub

    Private Sub 잘라내기TToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 잘라내기TToolStripMenuItem.Click
        richNotepad.Cut()
    End Sub

    Private Sub 복사CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 복사CToolStripMenuItem.Click
        richNotepad.Copy()
    End Sub

    Private Sub 붙여넣기PToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 붙여넣기PToolStripMenuItem.Click
        richNotepad.Paste()
    End Sub

    Private Sub 삭제LToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 삭제LToolStripMenuItem.Click
        Dim selectedPos As Integer = richNotepad.SelectionStart
        richNotepad.Text = richNotepad.Text.Remove(selectedPos, richNotepad.SelectedText.Length)
        richNotepad.SelectionStart = selectedPos
    End Sub

    Private Sub 찾기FToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 찾기FToolStripMenuItem.Click
        formSearch.Show()
        formSearch.Location = New Point(Me.Location.X + 70, (Me.Location.Y + Me.Height) \ 2)
    End Sub

    Private Sub 다음찾기NToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 다음찾기NToolStripMenuItem.Click
        If SearchString <> "" Then
            formSearch.textSearch.Text = SearchString
            formSearch.MySearch()
        Else
            formSearch.Show()
            formSearch.Location = New Point(Me.Location.X + 70, (Me.Location.Y + Me.Height) \ 2)
            formSearch.textSearch.Text = SearchString
        End If
    End Sub

    Private Sub 바꾸기RToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 바꾸기RToolStripMenuItem.Click
        'Not Used
    End Sub

    Private Sub 이동GToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 이동GToolStripMenuItem.Click
        'Not Used
    End Sub

    Private Sub 모두선택AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 모두선택AToolStripMenuItem.Click
        richNotepad.SelectAll()
    End Sub

    Private Sub 시간날짜DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 시간날짜DToolStripMenuItem.Click
        richNotepad.AppendText(TimeOfDay() & " " & Today())
    End Sub

    Private Sub 서식OToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles 서식OToolStripMenuItem.DropDownOpening
        MyEnabled()
    End Sub

    Private Sub 자동줄바꿈WToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles 자동줄바꿈WToolStripMenuItem.CheckedChanged
        richNotepad.WordWrap = 자동줄바꿈WToolStripMenuItem.Checked
    End Sub

    Private Sub 글꼴FToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 글꼴FToolStripMenuItem.Click
        Dim dialog As FontDialog = New FontDialog
        dialog.Font = richNotepad.Font
        dialog.Color = richNotepad.ForeColor
        dialog.ShowDialog()
        richNotepad.Font = dialog.Font
        richNotepad.ForeColor = dialog.Color
    End Sub

    Private Sub 보기VToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles 보기VToolStripMenuItem.DropDownOpening
        MyEnabled()
    End Sub

    Private Sub 상태표시줄SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 상태표시줄SToolStripMenuItem.Click
        'Not Used
    End Sub

    Private Sub 도움말HToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles 도움말HToolStripMenuItem.DropDownOpening
        MyEnabled()
    End Sub

    Private Sub 도움말보기HToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 도움말보기HToolStripMenuItem.Click
        Dim helpPane As HxHelpPane = New HxHelpPane()
        helpPane.DisplayTask("mshelp://windows/?id=5d18d5fb-e737-4a73-b6cc-dccc63720231")
    End Sub

    Private Sub 메모장정보ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 메모장정보ToolStripMenuItem.Click
        MessageBox.Show("JunguSoft Tosunyi" & vbCrLf & "버전 1.0 (빌드 0000: Service Pack 0)" & vbCrLf & "Copyright ⓒ 2014 JunguSoft Corporation. All rights reserved." & vbCrLf & vbCrLf & "Tosunyi Zero Ultmate K 운영 체제 및 해당 사용자 인터페이스는 미국, 대한민국 및 기타 여러 나라에서 상표 및 출원 중인 다른 지적 재산권이나 기존 지적 재산권에 의해 보호됩니다." & vbCrLf & vbCrLf & vbCrLf & vbCrLf & "이 제품은 JunguSoft 소프트웨어 사용 조건에 따라 다음 사용자가 사용할 수 있습니다." & vbCrLf & vbTab & My.User.Name, "메모장 정보", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub richNotepad_TextChanged(sender As Object, e As EventArgs) Handles richNotepad.TextChanged
        If IsEdited = MyEdited.OpenFile Then
            IsEdited = MyEdited.NotEdited
        ElseIf IsEdited <> MyEdited.Edited Then
            IsEdited = MyEdited.Edited
            Me.Text &= "*"
        End If
    End Sub

    Private Sub richNotepad_KeyDown(sender As Object, e As KeyEventArgs) Handles richNotepad.KeyDown
        If e.KeyCode = Keys.Control Then
            MyEnabled()
        End If
    End Sub

    Private Sub formNotepad_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If IsEdited = MyEdited.Edited Then
            If MessageBox.Show("변경 내용을 저장하시겠습니까?", "노트패드", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                MyOtherSave()
            End If
        End If
        End
    End Sub

    Public Sub MyOtherSave()
        Dim dialog As SaveFileDialog = New SaveFileDialog
        dialog.Filter = "텍스트 문서(*.txt)|*.txt|모든 파일 (*.*)|*.*"
        dialog.FileName = CurrentFile
        If dialog.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            CurrentFile = dialog.FileName
            Me.Text = CurrentFile
            Dim writeFile As IO.TextWriter = New IO.StreamWriter(CurrentFile, False, System.Text.Encoding.Default)
            writeFile.Write(richNotepad.Text)
            writeFile.Close()
            IsEdited = MyEdited.NotEdited
        End If
    End Sub

    Public Sub MyEnabled()
        새로만들기NToolStripMenuItem.Enabled = True
        열기OToolStripMenuItem.Enabled = True
        저장SToolStripMenuItem.Enabled = True
        다른이름으로저장AToolStripMenuItem.Enabled = True
        페이지설정SToolStripMenuItem.Enabled = False
        인쇄PToolStripMenuItem.Enabled = True
        끝내기XToolStripMenuItem.Enabled = True
        '
        실행취소UToolStripMenuItem.Enabled = richNotepad.CanUndo
        잘라내기TToolStripMenuItem.Enabled = richNotepad.SelectedText <> ""
        복사CToolStripMenuItem.Enabled = richNotepad.SelectedText <> ""
        붙여넣기PToolStripMenuItem.Enabled = richNotepad.CanPaste(DataFormats.GetFormat(DataFormats.Text))
        삭제LToolStripMenuItem.Enabled = richNotepad.SelectedText <> ""
        찾기FToolStripMenuItem.Enabled = richNotepad.Text <> ""
        다음찾기NToolStripMenuItem.Enabled = richNotepad.Text <> ""
        바꾸기RToolStripMenuItem.Enabled = False
        이동GToolStripMenuItem.Enabled = False
        모두선택AToolStripMenuItem.Enabled = True
        시간날짜DToolStripMenuItem.Enabled = True
        '
        자동줄바꿈WToolStripMenuItem.Enabled = True
        글꼴FToolStripMenuItem.Enabled = True
        '
        상태표시줄SToolStripMenuItem.Enabled = False
        '
        도움말보기HToolStripMenuItem.Enabled = True
        메모장정보ToolStripMenuItem.Enabled = True
    End Sub
End Class