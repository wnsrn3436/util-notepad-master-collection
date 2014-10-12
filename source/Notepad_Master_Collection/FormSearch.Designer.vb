<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSearch
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
        Me.labelText = New System.Windows.Forms.Label()
        Me.textSearch = New System.Windows.Forms.TextBox()
        Me.buttonSearch = New System.Windows.Forms.Button()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labelText
        '
        Me.labelText.AutoSize = True
        Me.labelText.Location = New System.Drawing.Point(12, 15)
        Me.labelText.Name = "labelText"
        Me.labelText.Size = New System.Drawing.Size(80, 12)
        Me.labelText.TabIndex = 0
        Me.labelText.Text = "찾을 내용(&N):"
        '
        'textSearch
        '
        Me.textSearch.Location = New System.Drawing.Point(98, 12)
        Me.textSearch.Name = "textSearch"
        Me.textSearch.Size = New System.Drawing.Size(336, 21)
        Me.textSearch.TabIndex = 1
        '
        'buttonSearch
        '
        Me.buttonSearch.AutoSize = True
        Me.buttonSearch.Enabled = False
        Me.buttonSearch.Location = New System.Drawing.Point(269, 37)
        Me.buttonSearch.Name = "buttonSearch"
        Me.buttonSearch.Size = New System.Drawing.Size(84, 23)
        Me.buttonSearch.TabIndex = 2
        Me.buttonSearch.Text = "다음 찾기(&F)"
        Me.buttonSearch.UseVisualStyleBackColor = True
        '
        'buttonCancel
        '
        Me.buttonCancel.Location = New System.Drawing.Point(359, 37)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(75, 23)
        Me.buttonCancel.TabIndex = 3
        Me.buttonCancel.Text = "취소"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'formSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 72)
        Me.Controls.Add(Me.buttonCancel)
        Me.Controls.Add(Me.buttonSearch)
        Me.Controls.Add(Me.textSearch)
        Me.Controls.Add(Me.labelText)
        Me.Name = "formSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "찾기"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelText As System.Windows.Forms.Label
    Friend WithEvents textSearch As System.Windows.Forms.TextBox
    Friend WithEvents buttonSearch As System.Windows.Forms.Button
    Friend WithEvents buttonCancel As System.Windows.Forms.Button
End Class
