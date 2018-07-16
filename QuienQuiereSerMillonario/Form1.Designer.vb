<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuienQuiereSerMillonarioMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.bttnResponder = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPuntos = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rbttnD = New System.Windows.Forms.RadioButton()
        Me.rbttnC = New System.Windows.Forms.RadioButton()
        Me.rbttnB = New System.Windows.Forms.RadioButton()
        Me.rbttnA = New System.Windows.Forms.RadioButton()
        Me.bttnJugar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPregunta
        '
        Me.lblPregunta.AutoSize = True
        Me.lblPregunta.Location = New System.Drawing.Point(10, 26)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(50, 13)
        Me.lblPregunta.TabIndex = 0
        Me.lblPregunta.Text = "Pregunta"
        '
        'bttnResponder
        '
        Me.bttnResponder.Location = New System.Drawing.Point(303, 147)
        Me.bttnResponder.Name = "bttnResponder"
        Me.bttnResponder.Size = New System.Drawing.Size(75, 23)
        Me.bttnResponder.TabIndex = 1
        Me.bttnResponder.Text = "Responder"
        Me.bttnResponder.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPuntos)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.rbttnD)
        Me.GroupBox1.Controls.Add(Me.bttnResponder)
        Me.GroupBox1.Controls.Add(Me.rbttnC)
        Me.GroupBox1.Controls.Add(Me.lblPregunta)
        Me.GroupBox1.Controls.Add(Me.rbttnB)
        Me.GroupBox1.Controls.Add(Me.rbttnA)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 228)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Quien Quiere Ser Millonario"
        Me.GroupBox1.Visible = False
        '
        'txtPuntos
        '
        Me.txtPuntos.Location = New System.Drawing.Point(152, 190)
        Me.txtPuntos.Name = "txtPuntos"
        Me.txtPuntos.ReadOnly = True
        Me.txtPuntos.Size = New System.Drawing.Size(100, 20)
        Me.txtPuntos.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.AutoEllipsis = True
        Me.Button2.Location = New System.Drawing.Point(28, 147)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "50/50"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(165, 147)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Publico"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rbttnD
        '
        Me.rbttnD.AutoSize = True
        Me.rbttnD.Location = New System.Drawing.Point(186, 105)
        Me.rbttnD.Name = "rbttnD"
        Me.rbttnD.Size = New System.Drawing.Size(90, 17)
        Me.rbttnD.TabIndex = 3
        Me.rbttnD.TabStop = True
        Me.rbttnD.Text = "RadioButton4"
        Me.rbttnD.UseVisualStyleBackColor = True
        '
        'rbttnC
        '
        Me.rbttnC.AutoSize = True
        Me.rbttnC.Location = New System.Drawing.Point(13, 105)
        Me.rbttnC.Name = "rbttnC"
        Me.rbttnC.Size = New System.Drawing.Size(90, 17)
        Me.rbttnC.TabIndex = 2
        Me.rbttnC.TabStop = True
        Me.rbttnC.Text = "RadioButton3"
        Me.rbttnC.UseVisualStyleBackColor = True
        '
        'rbttnB
        '
        Me.rbttnB.AutoSize = True
        Me.rbttnB.Location = New System.Drawing.Point(186, 63)
        Me.rbttnB.Name = "rbttnB"
        Me.rbttnB.Size = New System.Drawing.Size(90, 17)
        Me.rbttnB.TabIndex = 1
        Me.rbttnB.TabStop = True
        Me.rbttnB.Text = "RadioButton2"
        Me.rbttnB.UseVisualStyleBackColor = True
        '
        'rbttnA
        '
        Me.rbttnA.AutoSize = True
        Me.rbttnA.Location = New System.Drawing.Point(13, 63)
        Me.rbttnA.Name = "rbttnA"
        Me.rbttnA.Size = New System.Drawing.Size(90, 17)
        Me.rbttnA.TabIndex = 0
        Me.rbttnA.TabStop = True
        Me.rbttnA.Text = "RadioButton1"
        Me.rbttnA.UseVisualStyleBackColor = True
        '
        'bttnJugar
        '
        Me.bttnJugar.Location = New System.Drawing.Point(172, 21)
        Me.bttnJugar.Name = "bttnJugar"
        Me.bttnJugar.Size = New System.Drawing.Size(155, 23)
        Me.bttnJugar.TabIndex = 3
        Me.bttnJugar.Text = "Empezar a Jugar"
        Me.bttnJugar.UseVisualStyleBackColor = True
        '
        'QuienQuiereSerMillonarioMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 342)
        Me.Controls.Add(Me.bttnJugar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "QuienQuiereSerMillonarioMain"
        Me.Text = "Quien Quiere Ser Millonario?"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblPregunta As Label
    Friend WithEvents bttnResponder As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbttnD As RadioButton
    Friend WithEvents rbttnC As RadioButton
    Friend WithEvents rbttnB As RadioButton
    Friend WithEvents rbttnA As RadioButton
    Friend WithEvents bttnJugar As Button
    Friend WithEvents txtPuntos As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
