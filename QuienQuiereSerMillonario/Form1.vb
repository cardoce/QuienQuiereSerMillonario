﻿Public Class QuienQuiereSerMillonarioMain
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
    Dim numeroDePreguntas As Integer = 9
    Dim numeroDeTurno As Integer = 0
    Dim puntosDeJugador As Integer = 0
    Dim indicePregunta As Integer = numeroDePregunta()

    Private Sub bttnResponder_Click(sender As Object, e As EventArgs) Handles bttnResponder.Click
        indicePregunta = numeroDePregunta()
        If numeroDeTurno < numeroDePreguntas Then
            asignarPreguntasyRepuestas(indicePregunta)
            preguntaUsada(indicePregunta)
            numeroDeTurno = numeroDeTurno + 1
            If respuestaCorrecta(respuestaSeleccionada, indicePregunta) Then
                puntosDeJugador = puntosDeJugador + 1
                txtPuntos.Text = puntosDeJugador
            Else
                MsgBox("Respuesta Incorrecta")
                numeroDeTurno = 10
            End If
        Else
            MsgBox("Fin del Juego")
        End If
    End Sub

    Function respuestaCorrecta(ByVal respuestaUsuario As String, ByVal indicePregunta As Integer) As Boolean
        If respuestaUsuario.Equals(RespuestasCorrectas.GetValue(indicePregunta)) Then
            Return True
        Else
            Return False
        End If

    End Function
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

    Function numeroDePregunta() As Integer
        Dim numero As Integer
        numero = CInt(Math.Ceiling(Rnd() * (numeroDePreguntas - 1)))
        Do While (PreguntasUsadas(numero))
            numero = CInt(Math.Ceiling(Rnd() * (numeroDePreguntas - 1)))
        Loop
        Return numero
    End Function

    Sub preguntaUsada(ByVal index As Integer)
        PreguntasUsadas(index) = True
    End Sub

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
End Class
