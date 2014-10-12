# Notepad Master Collection

A text editor modeled on Windows Notepad. The File, Edit, Format, View, and Help menus, along with the names and shortcut keys of their items, match Notepad, and each time a menu opens its items are enabled or disabled to fit the current situation. The editing area is a RichTextBox, and files are read and written as text in the system default encoding. It was made as a school assignment.

<p>
  <img src="docs/screenshots/screenshot-1.png" width="480" alt="Editing screen">
</p>


## How to use

Download from Releases and run it. .NET Framework 4.5 is required.

| Menu | Shortcut | Action |
|---|---|---|
| File > New | Ctrl+N | Starts a blank document |
| File > Open | Ctrl+O | Opens a text file |
| File > Save | Ctrl+S | Overwrites the opened file. For a new document it works like Save As |
| File > Save As | | Saves to a chosen location |
| Edit > Undo, Cut, Copy, Paste | Ctrl+Z, Ctrl+X, Ctrl+C, Ctrl+V | Same as Notepad |
| Edit > Delete | Del | Deletes the selected text |
| Edit > Find, Find Next | Ctrl+F, F3 | Opens the Find window or searches again for the last found text |
| Edit > Select All | Ctrl+A | Selects the whole text |
| Edit > Time/Date | F5 | Appends the current time and date at the end of the document |
| Format > Word Wrap, Font | | Toggles word wrap or changes the font |
| Help > View Help, About Notepad | | Shows Windows Help and the program information |

Once the text is edited, `*` is added to the end of the window title bar. Starting a new document, opening a file, exiting, or closing the window with unsaved edits asks "변경 내용을 저장하시겠습니까?" (save changes?), and answering "예" (yes) opens a dialog to choose where to save.

In the Find window, typing the text and pressing Enter or "다음 찾기" (find next) selects its first occurrence after the cursor. Pressing Esc closes the window.


## How it works

**Menu states are computed every time a menu opens.** Each menu's `DropDownOpening` calls `MyEnabled`, which enables or disables the items. Undo follows `CanUndo`, Cut, Copy, and Delete follow the selection, Paste follows whether the clipboard holds text, and Find follows whether there is any text. This mirrors how Notepad grays out menu items depending on the situation.

```vb
실행취소UToolStripMenuItem.Enabled = richNotepad.CanUndo
잘라내기TToolStripMenuItem.Enabled = richNotepad.SelectedText <> ""
복사CToolStripMenuItem.Enabled = richNotepad.SelectedText <> ""
붙여넣기PToolStripMenuItem.Enabled = richNotepad.CanPaste(DataFormats.GetFormat(DataFormats.Text))
삭제LToolStripMenuItem.Enabled = richNotepad.SelectedText <> ""
찾기FToolStripMenuItem.Enabled = richNotepad.Text <> ""
```

**The edited state is tracked with three values.** `TextChanged` also fires when a loaded file fills the text, so the state is set to `OpenFile` just before opening to let that one change pass. The first change after that switches it to `Edited` and adds `*` to the title, and saving returns it to `NotEdited`.

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


## Files

| Path | Content |
|---|---|
| `source/Notepad_Master_Collection.sln` | Visual Studio 2013 solution |
| `source/Notepad_Master_Collection/FormNotepad.vb` | Menu actions, file reading and writing, menu states |
| `source/Notepad_Master_Collection/FormNotepad.Designer.vb` | Menu and editing area design |
| `source/Notepad_Master_Collection/FormSearch.vb` | Find window |
| `source/Notepad_Master_Collection/Resources/menu.png` | Menu bar background |
| `docs/screenshots/` | Screenshots |
| Releases | Executable |


## License

zlib. See [LICENSE](LICENSE).
