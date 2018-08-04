Public Class QuienQuiereSerMillonarioMain
    Dim Preguntas() As String = {
        "Quien dirigió la película El Padrino en 1972?", "Tecnica que describe y representa detalladamente la superficie de un terreno",
        "Uno de los libros de J. K. Rowling es Harry Potter y", "Con que material esculpió Miguel Angel La Piedad ubicada en el Vaticano?",
        "Cual es el idioma oficial de Israel?", "Cual de los siguientes países limita con Francia?",
         "En la mitología griega, Eros es considerado el dios del:",
         "Las Vegas es una ciudad estadounidense que queda en:", "Cual de estos animales es un rumiante?",
         "Que parte del cuerpo se examina en una encefalografia?",
         "Que elemento químico es representado por el símbolo P?",
        "Tim Burton dirigió la película",
        "Es el nombre de uno de los Tres Reyes Magos:",
        "Cual de estos bailes es tradicional de España?",
        "El Tour de Francia es una famosa competencia de:"}
    Dim Respuestas() As String = {
        "Roman Polanski", "Franco Zeffirelli", "Francis Ford Copolla", "Federico Fellini",
         "Topografía", "Serigrafía", "Epigrafía", "Holografía",
        "El arca perdida", "El prisionero de Azkaban", "La magia negra", "Su varita",
         "Bronce", "Marmol", "Madera", "Yeso",
         "Japones", "Griego", "Hebreo", "Chino",
         "Holanda", "Suecia", "Dinamarca", "Belgica",
         "Odio", "Miedo", "Amor", "Trabajo",
         "Oklahoma", "Nevada", "Arizona", "Colorado",
         "La ardilla", "El caracol", "El loro", "La vaca",
         "Ovarios", "Cráneo", "Pulmones", "Hígado",
         "Bromo", "Boro", "Rubidio", "Fosforo",
         "Inteligencia Artificial", "El gran pez", "Hombres de Negro", "Juegos Macabros",
         "Barrabas", "Jonas", "Melchor", "Judas",
        "Samba", "Fandango", "Joropo", "Cumbia",
        "Golf", "Ciclismo", "Fútbol", "Automovilismo"
    }
    Dim RespuestasCorrectas() As String = {
        "Francis Ford Copolla", "Topografía", "El prisionero de Azkaban", "Marmol",
        "Hebreo", "Belgica", "Amor", "Nevada", "La vaca", "Cráneo", "Fosforo", "El gran pez",
        "Melchor", "Fandango", "Ciclismo"
    }


    Dim PreguntasUsadas() As Boolean = {False, False, False, False,
        False, False, False, False, False, False, False, False, False, False, False}
    Dim Premios() As Integer = {100000, 250000, 500000, 750000, 1000000,
        2000000, 2500000, 3000000, 5000000, 7500000, 10000000, 12000000,
        15000000, 20000000, 25000000}
    Dim numeroDePreguntas As Integer = 14
    Dim numeroDeTurno As Integer = 0
    Dim puntosDeJugador As Integer = 0
    Dim indicePregunta As Integer = obtenerIndiceDePregunta()
    Dim banderaJuegoContinua As Boolean = True
    Dim timeLeft As Integer = 30

    Private Sub bttnResponder_Click(sender As Object, e As EventArgs) Handles bttnResponder.Click
        Dim respuesta As String = respuestaSeleccionada()

        If MessageBox.Show(respuesta + " Respuesta definitiva?", "Respuesta Definitiva",
                           MessageBoxButtons.OKCancel) =
                           Windows.Forms.DialogResult.OK Then
            procesarRespuesta(respuesta)
        End If
        timeLeft = 31
        correrTimer()
    End Sub

    Function esRespuestaCorrecta(ByVal respuestaUsuario As String, ByVal indicePregunta As Integer) As Boolean
        Dim test As String = RespuestasCorrectas(indicePregunta)
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
                indicePregunta = obtenerIndiceDePregunta()
                txtPuntos.Text = puntosDeJugador
                asignarPreguntasyRepuestas(indicePregunta)
                preguntaUsada(indicePregunta)
                numeroDeTurno = numeroDeTurno + 1
            Else
                MsgBox("Respuesta Incorrecta")
                Timer1.Stop()
                banderaJuegoContinua = False
                bttnResponder.Enabled = False
                txtPuntos.Text = ultimaZona(numeroDeTurno)
            End If
        Else
            MsgBox("Fin del Juego")
            bttnResponder.Enabled = False
        End If
        habilitarOpciones()
        deshabilitarPorcentajes()
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

    Function obtenerIndiceDePregunta() As Integer
        Dim numero As Integer
        Dim random As New Random
        numero = random.Next(0, numeroDePreguntas)
        Do While (PreguntasUsadas(numero))
            numero = random.Next(0, numeroDePreguntas)
        Loop
        Return numero
    End Function

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
        correrTimer()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bttn5050.Click
        obtener5050(indicePregunta)
        bttn5050.Enabled = False
        timeLeft = 30
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
        Dim respuesta As String = ""
        Dim indexTemporal As Integer = index * 4
        For value As Integer = indexTemporal To (indexTemporal + 4)
            Dim test As String = Respuestas(value)
            If esRespuestaCorrecta(Respuestas(value), index) Then
                respuesta = Respuestas(value)
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If timeLeft > 0 Then

            timeLeft -= 1
            LabelTimer.Text = timeLeft & " seconds"
        Else

            Timer1.Stop()
            MessageBox.Show("No has contestado a tiempo.", "Lo Sentimos!")
            bttnResponder.Enabled = False

        End If
    End Sub

    Sub correrTimer()
        Timer1.Enabled = True
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Terminarjuego()
    End Sub

    Sub Terminarjuego()
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bttnPublico.Click
        calcularPorcentajes()
        bttnPublico.Enabled = False
        timeLeft = 30
    End Sub

    Sub deshabilitarPorcentajes()
        txtPorA.Hide()
        txtPorB.Hide()
        txtPorC.Hide()
        txtPorD.Hide()
    End Sub

    Sub calcularPorcentajes()
        Dim range As New Random
        Dim porA, porB, porC, porD As Integer
        Dim values(4) As Integer
        Dim max As Integer = 100
        porA = range.Next(0, max)
        max -= porA
        porB = range.Next(0, max)
        max -= porB
        porC = range.Next(0, max)
        max -= porC
        porD = max
        values(0) = porA
        values(1) = porB
        values(2) = porC
        values(3) = porD

        Dim mayorPor As Integer = values.Max

        If porA = mayorPor Then
            txtPorA.BackColor = Color.LightGreen
        ElseIf porB = mayorPor Then
            txtPorB.BackColor = Color.LightGreen
        ElseIf porC = mayorPor Then
            txtPorC.BackColor = Color.LightGreen
        ElseIf porD = mayorPor Then
            txtPorD.BackColor = Color.LightGreen
        End If
        txtPorA.Text = porA
        txtPorB.Text = porB
        txtPorC.Text = porC
        txtPorD.Text = porD


        txtPorA.Show()
        txtPorB.Show()
        txtPorC.Show()
        txtPorD.Show()

    End Sub

    Private Sub QuienQuiereSerMillonarioMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarFechaHora()
    End Sub

    Sub mostrarFechaHora()
        LabelDate.Text = DateTime.Now.ToString("dd/MM/yyyy")
        LabelTime.Text = DateTime.Now.ToShortTimeString()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.ShowDialog()
    End Sub
End Class
