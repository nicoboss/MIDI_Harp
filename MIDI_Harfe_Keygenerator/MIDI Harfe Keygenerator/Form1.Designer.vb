<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Key_TextBox = New System.Windows.Forms.TextBox()
        Me.Generieren_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Key_TextBox
        '
        Me.Key_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Key_TextBox.Location = New System.Drawing.Point(12, 38)
        Me.Key_TextBox.Multiline = True
        Me.Key_TextBox.Name = "Key_TextBox"
        Me.Key_TextBox.Size = New System.Drawing.Size(1004, 520)
        Me.Key_TextBox.TabIndex = 0
        Me.Key_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Generieren_Button
        '
        Me.Generieren_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Generieren_Button.Location = New System.Drawing.Point(1070, 38)
        Me.Generieren_Button.Name = "Generieren_Button"
        Me.Generieren_Button.Size = New System.Drawing.Size(279, 62)
        Me.Generieren_Button.TabIndex = 1
        Me.Generieren_Button.Text = "Generieren"
        Me.Generieren_Button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1371, 639)
        Me.Controls.Add(Me.Generieren_Button)
        Me.Controls.Add(Me.Key_TextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Key_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Generieren_Button As System.Windows.Forms.Button

End Class
