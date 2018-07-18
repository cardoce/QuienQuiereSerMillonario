Public Class QuienQuiereSerMillonarioMain
    Dim Preguntas() As String = {"Pregunta1", "Pregunta2", "Pregunta3", "Pregunta4",
        "Pregunta5", "Pregunta6", "Pregunta7", "Pregunta8", "Pregunta9"}
    Dim Respuestas() As String = {"Opcion A1", "Opcion B1", "Opcion C1", "Opcion D1",
        "Opcion A2", "Opcion B2", "Opcion C2", "Opcion D2",
        "Opcion A3", "Opcion B3", "Opcion C3", "Opcion D3",
        "Opcion A4", "Opcion B4", "Opcion C4", "Opcion D4",
        "Opcion A5", "Opcion B5", "Opcion C5", "Opcion D5",
        "Opcion A6", "Opcion B6", "Opcion C6", "Opcion D6",
        "Opcion A7", "Opcion B7", "Opcion C7", "Opcion D7",
        "Opcion A8", "Opcion B8", "Opcion C8", "Opcion D8",
        "Opcion A9", "Opcion B9", "Opcion C9", "Opcion D9"}
    Dim RespuestasCorrectas() As String = {"Opcion A1", "Opcion C2", "Opcion B3",
        "Opcion D4", "Opcion A5", "Opcion B6", "Opcion B7", "Opcion D8", "Opcion C9"}
    Dim PreguntasUsadas() As Boolean = {False, False, False, False,
        False, False, False, False, False, False, False}
    Dim Premios() As Integer = {100000, 250000, 500000, 750000, 1000000,
        2000000, 2500000, 3000000, 5000000, 7500000, 10000000, 12000000,
        15000000, 20000000, 25000000}
    Dim numeroDePreguntas As Integer = 9
    Dim numeroDeTurno As Integer = 0
    Dim puntosDeJugador As Integer = 0
    Dim indicePregunta As Integer = 0
    Dim banderaJuegoContinua As Boolean = True


    Private Sub bttnResponder_Click(sender As Object, e As EventArgs) Handles bttnResponder.Click
        Dim respuesta As String = respuestaSeleccionada()
        If MessageBox.Show(respuesta + " Respuesta definitiva?", "Respuesta Definitiva",
                           MessageBoxButtons.OKCancel) =
                           Windows.Forms.DialogResult.OK Then
            procesarRespuesta(respuesta)
        End If
    End Sub

    Function esRespuestaCorrecta(ByVal respuestaUsuario As String, ByVal indicePregunta As Integer) As Boolean
        If respuestaUsuario.Equals(RespuestasCorrectas(indicePregunta)) Then
            Return True
        Else
            Return False
        End If
    End Function
    Sub procesarRespuesta(ByVal respuesta As String)
        If numeroDeTurno < numeroDePreguntas And banderaJuegoContinua Then
            If esRespuestaCorrecta(respuesta, indicePregunta) Then
                puntosDeJugador = Premios(indicePregunta)
                indicePregunta = indicePregunta + 1
                txtPuntos.Text = puntosDeJugador
                asignarPreguntasyRepuestas(indicePregunta)
                preguntaUsada(indicePregunta)
                numeroDeTurno = numeroDeTurno + 1
            Else
                MsgBox("Respuesta Incorrecta")
                banderaJuegoContinua = False
                bttnResponder.Enabled = False
                txtPuntos.Text = ultimaZona(numeroDeTurno)
            End If
        Else
            MsgBox("Fin del Juego")
            bttnResponder.Enabled = False
        End If
        habilitarOpciones()
    End Sub
    Function respuestaSeleccionada() As String
        Dim respuesta As String = ""
        If rbttnA.Checked Then
            rbttnA.Checked = False
            respuesta = rbttnA.Text
        ElseIf rbttnB.Checked Then
            rbttnB.Checked = False
            respuesta = rbttnB.Text
        ElseIf rbttnC.Checked Then
            rbttnC.Checked = False
            respuesta = rbttnC.Text
        ElseIf rbttnD.Checked Then
            rbttnD.Checked = False
            respuesta = rbttnD.Text
        End If
        Return respuesta
    End Function

    'Function numeroDePregunta() As Integer
    'Dim numero As Integer
    'numero = CInt(Math.Ceiling(Rnd() * (numeroDePreguntas - 1)))
    'Do While (PreguntasUsadas(numero))
    '       numero = CInt(Math.Ceiling(Rnd() * (numeroDePreguntas - 1)))
    'Loop
    'Return numero
    'End Function

    Sub preguntaUsada(ByVal index As Integer)
        PreguntasUsadas(index) = True
    End Sub

    Function ultimaZona(ByVal turno As Integer) As Integer
        Dim zona As Integer = 0
        If turno >= 15 Then
            zona = Premios(24)
        ElseIf turno >= 13 Then
            zona = Premios(12)
        ElseIf turno >= 10 Then
            zona = Premios(9)
        ElseIf turno >= 8 Then
            zona = Premios(7)
        ElseIf turno >= 5 Then
            zona = Premios(4)
        End If
        Return zona
    End Function

    Sub asignarPreguntasyRepuestas(ByVal index As Integer)
        Dim indexPreguntas As Integer = index * 4
        lblPregunta.Text = Preguntas(index)
        rbttnA.Text = Respuestas(indexPreguntas)
        rbttnB.Text = Respuestas(indexPreguntas + 1)
        rbttnC.Text = Respuestas(indexPreguntas + 2)
        rbttnD.Text = Respuestas(indexPreguntas + 3)
    End Sub

    Private Sub bttnJugar_Click(sender As Object, e As EventArgs) Handles bttnJugar.Click
        GroupBox1.Show()
        asignarPreguntasyRepuestas(indicePregunta)
        preguntaUsada(indicePregunta)
        numeroDeTurno = numeroDeTurno + 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bttn5050.Click
        obtener5050(indicePregunta)
        bttn5050.Enabled = False
    End Sub

    Sub obtener5050(ByVal index As Integer)
        Dim respuesta As String = obtenerRespuestaCorrecta(index)
        Dim banderaBreak As Integer = 0
        If Not rbttnA.Text = respuesta And banderaBreak < 2 Then
            rbttnA.Enabled = False
            banderaBreak = banderaBreak + 1
        End If
        If Not rbttnB.Text = respuesta And banderaBreak < 2 Then
            rbttnB.Enabled = False
            banderaBreak = banderaBreak + 1
        End If
        If Not rbttnC.Text = respuesta And banderaBreak < 2 Then
            rbttnC.Enabled = False
            banderaBreak = banderaBreak + 1
        End If
        If Not rbttnD.Text = respuesta And banderaBreak < 2 Then
            rbttnD.Enabled = False
            banderaBreak = banderaBreak + 1
        End If

    End Sub

    Function obtenerRespuestaCorrecta(ByVal index As Integer)
        index = index * 4
        Dim respuesta As String = ""
        For value As Integer = 0 To 4
            If esRespuestaCorrecta(Respuestas(index), index) Then
                respuesta = Respuestas(index)
            End If
        Next
        Return respuesta
    End Function

    Sub habilitarOpciones()
        rbttnA.Enabled = True
        rbttnB.Enabled = True
        rbttnC.Enabled = True
        rbttnD.Enabled = True
    End Sub
End Class
