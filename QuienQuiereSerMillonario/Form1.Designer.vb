﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.bttnResponder = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPuntos = New System.Windows.Forms.TextBox()
        Me.bttn5050 = New System.Windows.Forms.Button()
        Me.bttnPublico = New System.Windows.Forms.Button()
        Me.rbttnD = New System.Windows.Forms.RadioButton()
        Me.rbttnC = New System.Windows.Forms.RadioButton()
        Me.rbttnB = New System.Windows.Forms.RadioButton()
        Me.rbttnA = New System.Windows.Forms.RadioButton()
        Me.bttnJugar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer = New System.Windows.Forms.Label()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtPorA = New System.Windows.Forms.TextBox()
        Me.txtPorC = New System.Windows.Forms.TextBox()
        Me.txtPorB = New System.Windows.Forms.TextBox()
        Me.txtPorD = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Controls.Add(Me.txtPorD)
        Me.GroupBox1.Controls.Add(Me.txtPorB)
        Me.GroupBox1.Controls.Add(Me.txtPorC)
        Me.GroupBox1.Controls.Add(Me.txtPorA)
        Me.GroupBox1.Controls.Add(Me.txtPuntos)
        Me.GroupBox1.Controls.Add(Me.bttn5050)
        Me.GroupBox1.Controls.Add(Me.bttnPublico)
        Me.GroupBox1.Controls.Add(Me.rbttnD)
        Me.GroupBox1.Controls.Add(Me.bttnResponder)
        Me.GroupBox1.Controls.Add(Me.rbttnC)
        Me.GroupBox1.Controls.Add(Me.lblPregunta)
        Me.GroupBox1.Controls.Add(Me.rbttnB)
        Me.GroupBox1.Controls.Add(Me.rbttnA)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 260)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 176)
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
        'bttn5050
        '
        Me.bttn5050.AutoEllipsis = True
        Me.bttn5050.Location = New System.Drawing.Point(28, 147)
        Me.bttn5050.Name = "bttn5050"
        Me.bttn5050.Size = New System.Drawing.Size(75, 23)
        Me.bttn5050.TabIndex = 5
        Me.bttn5050.Text = "50/50"
        Me.bttn5050.UseVisualStyleBackColor = True
        '
        'bttnPublico
        '
        Me.bttnPublico.Location = New System.Drawing.Point(165, 147)
        Me.bttnPublico.Name = "bttnPublico"
        Me.bttnPublico.Size = New System.Drawing.Size(75, 23)
        Me.bttnPublico.TabIndex = 4
        Me.bttnPublico.Text = "Publico"
        Me.bttnPublico.UseVisualStyleBackColor = True
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
        Me.bttnJugar.Location = New System.Drawing.Point(165, 213)
        Me.bttnJugar.Name = "bttnJugar"
        Me.bttnJugar.Size = New System.Drawing.Size(75, 23)
        Me.bttnJugar.TabIndex = 3
        Me.bttnJugar.Text = "Jugar"
        Me.bttnJugar.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer
        '
        Me.Timer.AutoSize = True
        Me.Timer.Location = New System.Drawing.Point(379, 26)
        Me.Timer.Name = "Timer"
        Me.Timer.Size = New System.Drawing.Size(0, 13)
        Me.Timer.TabIndex = 4
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(246, 213)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalir.TabIndex = 5
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(76, 213)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Instrucciones"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.ButtonSalir)
        Me.GroupBox2.Controls.Add(Me.bttnJugar)
        Me.GroupBox2.Location = New System.Drawing.Point(41, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(406, 242)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.QuienQuiereSerMillonario.My.Resources.Resources.images1
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(104, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 179)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'txtPorA
        '
        Me.txtPorA.Location = New System.Drawing.Point(110, 63)
        Me.txtPorA.Name = "txtPorA"
        Me.txtPorA.ReadOnly = True
        Me.txtPorA.Size = New System.Drawing.Size(34, 20)
        Me.txtPorA.TabIndex = 6
        Me.txtPorA.Visible = False
        '
        'txtPorC
        '
        Me.txtPorC.Location = New System.Drawing.Point(110, 102)
        Me.txtPorC.Name = "txtPorC"
        Me.txtPorC.ReadOnly = True
        Me.txtPorC.Size = New System.Drawing.Size(34, 20)
        Me.txtPorC.TabIndex = 7
        Me.txtPorC.Visible = False
        '
        'txtPorB
        '
        Me.txtPorB.Location = New System.Drawing.Point(282, 62)
        Me.txtPorB.Name = "txtPorB"
        Me.txtPorB.ReadOnly = True
        Me.txtPorB.Size = New System.Drawing.Size(34, 20)
        Me.txtPorB.TabIndex = 8
        Me.txtPorB.Visible = False
        '
        'txtPorD
        '
        Me.txtPorD.Location = New System.Drawing.Point(282, 105)
        Me.txtPorD.Name = "txtPorD"
        Me.txtPorD.ReadOnly = True
        Me.txtPorD.Size = New System.Drawing.Size(34, 20)
        Me.txtPorD.TabIndex = 9
        Me.txtPorD.Visible = False
        '
        'QuienQuiereSerMillonarioMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 457)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Timer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "QuienQuiereSerMillonarioMain"
        Me.Text = "Quien Quiere Ser Millonario?"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents bttn5050 As Button
    Friend WithEvents bttnPublico As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer As Label
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtPorD As TextBox
    Friend WithEvents txtPorB As TextBox
    Friend WithEvents txtPorC As TextBox
    Friend WithEvents txtPorA As TextBox
End Class
