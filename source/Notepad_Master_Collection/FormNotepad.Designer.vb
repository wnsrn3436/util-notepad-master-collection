<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formNotepad
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.menuMain = New System.Windows.Forms.MenuStrip()
        Me.파일FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.새로만들기NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.열기OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.저장SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.다른이름으로저장AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.페이지설정SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.인쇄PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.끝내기XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.편집EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.실행취소UToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.잘라내기TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.복사CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.붙여넣기PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.삭제LToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.찾기FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.다음찾기NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.바꾸기RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.이동GToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.모두선택AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.시간날짜DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.서식OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.자동줄바꿈WToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.글꼴FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.보기VToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.상태표시줄SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.도움말HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.도움말보기HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.메모장정보ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.richNotepad = New System.Windows.Forms.RichTextBox()
        Me.menuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuMain
        '
        Me.menuMain.BackgroundImage = Global.Notepad_Master_Collection.My.Resources.Resources.menu
        Me.menuMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.menuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.파일FToolStripMenuItem, Me.편집EToolStripMenuItem, Me.서식OToolStripMenuItem, Me.보기VToolStripMenuItem, Me.도움말HToolStripMenuItem})
        Me.menuMain.Location = New System.Drawing.Point(0, 0)
        Me.menuMain.Name = "menuMain"
        Me.menuMain.Padding = New System.Windows.Forms.Padding(0)
        Me.menuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.menuMain.Size = New System.Drawing.Size(784, 24)
        Me.menuMain.TabIndex = 0
        Me.menuMain.Text = "MenuStrip1"
        '
        '파일FToolStripMenuItem
        '
        Me.파일FToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.새로만들기NToolStripMenuItem, Me.열기OToolStripMenuItem, Me.저장SToolStripMenuItem, Me.다른이름으로저장AToolStripMenuItem, Me.ToolStripMenuItem1, Me.페이지설정SToolStripMenuItem, Me.인쇄PToolStripMenuItem, Me.ToolStripMenuItem2, Me.끝내기XToolStripMenuItem})
        Me.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem"
        Me.파일FToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.파일FToolStripMenuItem.Text = "파일(&F)"
        '
        '새로만들기NToolStripMenuItem
        '
        Me.새로만들기NToolStripMenuItem.Name = "새로만들기NToolStripMenuItem"
        Me.새로만들기NToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.새로만들기NToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.새로만들기NToolStripMenuItem.Text = "새로 만들기(&N)"
        '
        '열기OToolStripMenuItem
        '
        Me.열기OToolStripMenuItem.Name = "열기OToolStripMenuItem"
        Me.열기OToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.열기OToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.열기OToolStripMenuItem.Text = "열기(&O)..."
        '
        '저장SToolStripMenuItem
        '
        Me.저장SToolStripMenuItem.Name = "저장SToolStripMenuItem"
        Me.저장SToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.저장SToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.저장SToolStripMenuItem.Text = "저장(&S)"
        '
        '다른이름으로저장AToolStripMenuItem
        '
        Me.다른이름으로저장AToolStripMenuItem.Name = "다른이름으로저장AToolStripMenuItem"
        Me.다른이름으로저장AToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.다른이름으로저장AToolStripMenuItem.Text = "다른 이름으로 저장(&A)...　　　　"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(248, 6)
        '
        '페이지설정SToolStripMenuItem
        '
        Me.페이지설정SToolStripMenuItem.Name = "페이지설정SToolStripMenuItem"
        Me.페이지설정SToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.페이지설정SToolStripMenuItem.Text = "페이지 설정(&U)..."
        '
        '인쇄PToolStripMenuItem
        '
        Me.인쇄PToolStripMenuItem.Name = "인쇄PToolStripMenuItem"
        Me.인쇄PToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.인쇄PToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.인쇄PToolStripMenuItem.Text = "인쇄(&P)..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(248, 6)
        '
        '끝내기XToolStripMenuItem
        '
        Me.끝내기XToolStripMenuItem.Name = "끝내기XToolStripMenuItem"
        Me.끝내기XToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.끝내기XToolStripMenuItem.Text = "끝내기(&X)"
        '
        '편집EToolStripMenuItem
        '
        Me.편집EToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.실행취소UToolStripMenuItem, Me.ToolStripMenuItem3, Me.잘라내기TToolStripMenuItem, Me.복사CToolStripMenuItem, Me.붙여넣기PToolStripMenuItem, Me.삭제LToolStripMenuItem, Me.ToolStripMenuItem4, Me.찾기FToolStripMenuItem, Me.다음찾기NToolStripMenuItem, Me.바꾸기RToolStripMenuItem, Me.이동GToolStripMenuItem, Me.ToolStripMenuItem5, Me.모두선택AToolStripMenuItem, Me.시간날짜DToolStripMenuItem})
        Me.편집EToolStripMenuItem.Name = "편집EToolStripMenuItem"
        Me.편집EToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.편집EToolStripMenuItem.Text = "편집(&E)"
        '
        '실행취소UToolStripMenuItem
        '
        Me.실행취소UToolStripMenuItem.Name = "실행취소UToolStripMenuItem"
        Me.실행취소UToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.실행취소UToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.실행취소UToolStripMenuItem.Text = "실행 취소(&U)　　　　"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(228, 6)
        '
        '잘라내기TToolStripMenuItem
        '
        Me.잘라내기TToolStripMenuItem.Name = "잘라내기TToolStripMenuItem"
        Me.잘라내기TToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.잘라내기TToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.잘라내기TToolStripMenuItem.Text = "잘라내기(&T)"
        '
        '복사CToolStripMenuItem
        '
        Me.복사CToolStripMenuItem.Name = "복사CToolStripMenuItem"
        Me.복사CToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.복사CToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.복사CToolStripMenuItem.Text = "복사(&C)"
        '
        '붙여넣기PToolStripMenuItem
        '
        Me.붙여넣기PToolStripMenuItem.Name = "붙여넣기PToolStripMenuItem"
        Me.붙여넣기PToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.붙여넣기PToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.붙여넣기PToolStripMenuItem.Text = "붙여넣기(&P)"
        '
        '삭제LToolStripMenuItem
        '
        Me.삭제LToolStripMenuItem.Name = "삭제LToolStripMenuItem"
        Me.삭제LToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.삭제LToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.삭제LToolStripMenuItem.Text = "삭제(&L)"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(228, 6)
        '
        '찾기FToolStripMenuItem
        '
        Me.찾기FToolStripMenuItem.Name = "찾기FToolStripMenuItem"
        Me.찾기FToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.찾기FToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.찾기FToolStripMenuItem.Text = "찾기(&F)..."
        '
        '다음찾기NToolStripMenuItem
        '
        Me.다음찾기NToolStripMenuItem.Name = "다음찾기NToolStripMenuItem"
        Me.다음찾기NToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.다음찾기NToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.다음찾기NToolStripMenuItem.Text = "다음 찾기(&N)"
        '
        '바꾸기RToolStripMenuItem
        '
        Me.바꾸기RToolStripMenuItem.Name = "바꾸기RToolStripMenuItem"
        Me.바꾸기RToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.바꾸기RToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.바꾸기RToolStripMenuItem.Text = "바꾸기(&R)..."
        '
        '이동GToolStripMenuItem
        '
        Me.이동GToolStripMenuItem.Name = "이동GToolStripMenuItem"
        Me.이동GToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.이동GToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.이동GToolStripMenuItem.Text = "이동(&G)..."
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(228, 6)
        '
        '모두선택AToolStripMenuItem
        '
        Me.모두선택AToolStripMenuItem.Name = "모두선택AToolStripMenuItem"
        Me.모두선택AToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.모두선택AToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.모두선택AToolStripMenuItem.Text = "모두 선택(&A)"
        '
        '시간날짜DToolStripMenuItem
        '
        Me.시간날짜DToolStripMenuItem.Name = "시간날짜DToolStripMenuItem"
        Me.시간날짜DToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.시간날짜DToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.시간날짜DToolStripMenuItem.Text = "시간/날짜(&D)"
        '
        '서식OToolStripMenuItem
        '
        Me.서식OToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.자동줄바꿈WToolStripMenuItem, Me.글꼴FToolStripMenuItem})
        Me.서식OToolStripMenuItem.Name = "서식OToolStripMenuItem"
        Me.서식OToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.서식OToolStripMenuItem.Text = "서식(&O)"
        '
        '자동줄바꿈WToolStripMenuItem
        '
        Me.자동줄바꿈WToolStripMenuItem.Checked = True
        Me.자동줄바꿈WToolStripMenuItem.CheckOnClick = True
        Me.자동줄바꿈WToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.자동줄바꿈WToolStripMenuItem.Name = "자동줄바꿈WToolStripMenuItem"
        Me.자동줄바꿈WToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.자동줄바꿈WToolStripMenuItem.Text = "자동 줄 바꿈(&W)　"
        '
        '글꼴FToolStripMenuItem
        '
        Me.글꼴FToolStripMenuItem.Name = "글꼴FToolStripMenuItem"
        Me.글꼴FToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.글꼴FToolStripMenuItem.Text = "글꼴(&F)..."
        '
        '보기VToolStripMenuItem
        '
        Me.보기VToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.상태표시줄SToolStripMenuItem})
        Me.보기VToolStripMenuItem.Name = "보기VToolStripMenuItem"
        Me.보기VToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.보기VToolStripMenuItem.Text = "보기(&V)"
        '
        '상태표시줄SToolStripMenuItem
        '
        Me.상태표시줄SToolStripMenuItem.Name = "상태표시줄SToolStripMenuItem"
        Me.상태표시줄SToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.상태표시줄SToolStripMenuItem.Text = "상태 표시줄(&S)　"
        '
        '도움말HToolStripMenuItem
        '
        Me.도움말HToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.도움말보기HToolStripMenuItem, Me.ToolStripMenuItem6, Me.메모장정보ToolStripMenuItem})
        Me.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem"
        Me.도움말HToolStripMenuItem.Size = New System.Drawing.Size(72, 24)
        Me.도움말HToolStripMenuItem.Text = "도움말(&H)"
        '
        '도움말보기HToolStripMenuItem
        '
        Me.도움말보기HToolStripMenuItem.Name = "도움말보기HToolStripMenuItem"
        Me.도움말보기HToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.도움말보기HToolStripMenuItem.Text = "도움말 보기(&H)　"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(164, 6)
        '
        '메모장정보ToolStripMenuItem
        '
        Me.메모장정보ToolStripMenuItem.Name = "메모장정보ToolStripMenuItem"
        Me.메모장정보ToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.메모장정보ToolStripMenuItem.Text = "메모장 정보(&A)"
        '
        'richNotepad
        '
        Me.richNotepad.Font = New System.Drawing.Font("굴림체", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.richNotepad.HideSelection = False
        Me.richNotepad.Location = New System.Drawing.Point(0, 22)
        Me.richNotepad.Margin = New System.Windows.Forms.Padding(0)
        Me.richNotepad.Name = "richNotepad"
        Me.richNotepad.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.richNotepad.Size = New System.Drawing.Size(785, 540)
        Me.richNotepad.TabIndex = 1
        Me.richNotepad.Text = ""
        '
        'formNotepad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.richNotepad)
        Me.Controls.Add(Me.menuMain)
        Me.MainMenuStrip = Me.menuMain
        Me.Name = "formNotepad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notepad Master Collection"
        Me.menuMain.ResumeLayout(False)
        Me.menuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents 파일FToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents richNotepad As System.Windows.Forms.RichTextBox
    Friend WithEvents 새로만들기NToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 열기OToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 저장SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 다른이름으로저장AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 페이지설정SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 인쇄PToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 끝내기XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 편집EToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 실행취소UToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 잘라내기TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 복사CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 붙여넣기PToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 삭제LToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 찾기FToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 다음찾기NToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 바꾸기RToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 이동GToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 모두선택AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 시간날짜DToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 서식OToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 자동줄바꿈WToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 글꼴FToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 보기VToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 상태표시줄SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 도움말HToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 도움말보기HToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 메모장정보ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
