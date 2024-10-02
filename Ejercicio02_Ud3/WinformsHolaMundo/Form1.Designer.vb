<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btn = New Button()
        textoNombre = New TextBox()
        Label1 = New Label()
        HScrollBar1 = New HScrollBar()
        lbError = New Label()
        SuspendLayout()
        ' 
        ' btn
        ' 
        btn.Location = New Point(160, 168)
        btn.Name = "btn"
        btn.Size = New Size(75, 23)
        btn.TabIndex = 0
        btn.Text = "Saludar"
        btn.UseVisualStyleBackColor = True
        ' 
        ' textoNombre
        ' 
        textoNombre.Location = New Point(150, 111)
        textoNombre.Name = "textoNombre"
        textoNombre.Size = New Size(100, 23)
        textoNombre.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(55, 114)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 15)
        Label1.TabIndex = 2
        Label1.Text = "Nombre: "
        ' 
        ' HScrollBar1
        ' 
        HScrollBar1.Location = New Point(74, 352)
        HScrollBar1.Name = "HScrollBar1"
        HScrollBar1.Size = New Size(8, 8)
        HScrollBar1.TabIndex = 3
        ' 
        ' lbError
        ' 
        lbError.AutoSize = True
        lbError.ForeColor = Color.Red
        lbError.Location = New Point(325, 118)
        lbError.Name = "lbError"
        lbError.Size = New Size(123, 15)
        lbError.TabIndex = 4
        lbError.Text = "Texto mal introducido"
        lbError.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lbError)
        Controls.Add(HScrollBar1)
        Controls.Add(Label1)
        Controls.Add(textoNombre)
        Controls.Add(btn)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn As Button
    Friend WithEvents textoNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents lbError As Label

End Class
