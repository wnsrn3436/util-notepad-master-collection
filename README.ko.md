# Notepad Master Collection

Windows 메모장을 본떠 만든 텍스트 편집기다. 파일, 편집, 서식, 보기, 도움말 메뉴와 각 항목의 이름, 단축키를 메모장과 같게 두었고, 메뉴를 열 때마다 지금 상황에 맞춰 항목을 켜고 끈다. 편집 영역은 RichTextBox 이고 파일은 시스템 기본 인코딩의 텍스트로 읽고 쓴다. 학교 과제로 만들었다.

<p>
  <img src="docs/screenshots/screenshot-1.png" width="480" alt="편집 화면">
</p>


## 사용 방법

Releases에서 받아 실행하면 된다. .NET Framework 4.5 가 있어야 한다.

| 메뉴 | 단축키 | 동작 |
|---|---|---|
| 파일 > 새로 만들기 | Ctrl+N | 빈 문서로 시작한다 |
| 파일 > 열기 | Ctrl+O | 텍스트 파일을 연다 |
| 파일 > 저장 | Ctrl+S | 연 파일에 덮어쓴다. 새 문서면 다른 이름으로 저장과 같다 |
| 파일 > 다른 이름으로 저장 | | 저장할 위치를 골라 저장한다 |
| 편집 > 실행 취소, 잘라내기, 복사, 붙여넣기 | Ctrl+Z, Ctrl+X, Ctrl+C, Ctrl+V | 메모장과 같다 |
| 편집 > 삭제 | Del | 선택한 글을 지운다 |
| 편집 > 찾기, 다음 찾기 | Ctrl+F, F3 | 찾기 창을 띄우거나 마지막으로 찾은 말을 다시 찾는다 |
| 편집 > 모두 선택 | Ctrl+A | 본문 전체를 선택한다 |
| 편집 > 시간/날짜 | F5 | 문서 끝에 지금 시각과 날짜를 붙인다 |
| 서식 > 자동 줄 바꿈, 글꼴 | | 줄 바꿈을 켜고 끄거나 글꼴을 바꾼다 |
| 도움말 > 도움말 보기, 메모장 정보 | | Windows 도움말과 프로그램 정보를 띄운다 |

내용을 고치면 창 제목표시줄 끝에 `*` 가 붙는다. 고친 채로 새로 만들기, 열기, 끝내기를 하거나 창을 닫으면 "변경 내용을 저장하시겠습니까?" 를 묻고, "예" 를 누르면 저장할 위치를 고르는 창이 뜬다.

찾기 창에 찾을 내용을 쓰고 Enter 나 "다음 찾기" 를 누르면 커서 뒤에서 처음 나오는 곳을 선택한다. Esc 를 누르면 닫힌다.


## 구현 원리

**메뉴 상태는 열 때마다 계산한다.** 메뉴마다 `DropDownOpening` 에서 `MyEnabled` 를 불러 항목을 켜고 끈다. 실행 취소는 `CanUndo`, 잘라내기와 복사와 삭제는 선택 영역, 붙여넣기는 클립보드의 텍스트, 찾기는 본문이 있는지에 따른다. 메모장이 상황에 따라 메뉴를 회색으로 바꾸는 동작을 따라 한 것이다.

```vb
실행취소UToolStripMenuItem.Enabled = richNotepad.CanUndo
잘라내기TToolStripMenuItem.Enabled = richNotepad.SelectedText <> ""
복사CToolStripMenuItem.Enabled = richNotepad.SelectedText <> ""
붙여넣기PToolStripMenuItem.Enabled = richNotepad.CanPaste(DataFormats.GetFormat(DataFormats.Text))
삭제LToolStripMenuItem.Enabled = richNotepad.SelectedText <> ""
찾기FToolStripMenuItem.Enabled = richNotepad.Text <> ""
```

**변경 여부는 세 가지 상태로 따진다.** `TextChanged` 는 파일을 불러와 본문을 채울 때도 일어나므로, 열기 직전에 상태를 `OpenFile` 로 두어 그 한 번은 넘긴다. 그 뒤 처음 바뀔 때 `Edited` 로 바꾸며 제목에 `*` 를 붙이고, 저장하면 `NotEdited` 로 돌아간다.

```vb
Private Sub richNotepad_TextChanged(sender As Object, e As EventArgs) Handles richNotepad.TextChanged
    If IsEdited = MyEdited.OpenFile Then
        IsEdited = MyEdited.NotEdited
    ElseIf IsEdited <> MyEdited.Edited Then
        IsEdited = MyEdited.Edited
        Me.Text &= "*"
    End If
End Sub
```


## 파일

| 경로 | 내용 |
|---|---|
| `source/Notepad_Master_Collection.sln` | Visual Studio 2013 솔루션 |
| `source/Notepad_Master_Collection/FormNotepad.vb` | 메뉴 동작, 파일 읽고 쓰기, 메뉴 상태 |
| `source/Notepad_Master_Collection/FormNotepad.Designer.vb` | 메뉴와 편집 영역 디자인 |
| `source/Notepad_Master_Collection/FormSearch.vb` | 찾기 창 |
| `source/Notepad_Master_Collection/Resources/menu.png` | 메뉴 막대 배경 |
| `docs/screenshots/` | 스크린샷 |
| Releases | 실행 파일 |


## 라이선스

zlib 라이선스다. 자세한 내용은 [LICENSE](LICENSE) 에 있다.
