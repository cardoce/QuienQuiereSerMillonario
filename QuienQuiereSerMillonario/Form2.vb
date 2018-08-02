Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelInstructions.Text = (
  "El jugador debe contestar preguntas de conocimiento general. 
Las preguntas son de opción múltiple: cuatro posibles respuestas se dan (A, B, C o D), y el concursante debe elegir la correcta. 
Hay un límite de tiempo establecido de 30 segundos para responder a una pregunta.

Se le preguntará al concursante si esa es su respuesta final. 
La respuesta de la pregunta final, no se puede cambiar. 

Si el jugador contesta a una pregunta de manera incorrecta, entonces todo el dinero ganado hasta el momento se ha perdido, 
salvo que haya alcanzado una zona segura, si un jugador contesta una pregunta de manera incorrecta por encima de estos niveles, 
entonces el premio se reduce a la premio garantizado anterior. 

El juego termina cuando el jugador contesta a una pregunta de manera incorrecta, o responde a todas las preguntas correctamente.

La secuencia completa de premios para esta versión del juego es:

    ₡ 100000 
    ₡ 250000 
    ₡ 500000 
    ₡ 750000 
    ₡ 1000000  (***zona segura 1***)
    ₡ 2000000 
    ₡ 2500000 
    ₡ 3000000  (***zona segura 2***)
    ₡ 5000000 
    ₡ 7500000  (***zona segura 3***)
    ₡ 10000000 
    ₡ 12000000 
    ₡ 15000000 (***zona segura 4***)
    ₡ 20000000 
    ₡ 25000000 (*** Gran premio ***)

Si en algún momento el jugador no está seguro de la respuesta a una pregunta, 
él o ella puede usar un comodin a elegir, entre:

Cincuenta por ciento (50:50): El juego elimina dos de las opciones de respuestas incorrectas.

Comodín del público: Los miembros del publico (simulado por el juego) indican sus opciones con un voto. 
Los resultados se muestran inmediatamente en la pantalla.")

    End Sub
End Class