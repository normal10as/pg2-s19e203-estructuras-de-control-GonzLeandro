Imports System

Module Program
    Enum operacion As Integer
        suma = 1
        resta
        multiplicacion
        division
    End Enum
    Sub Main(args As String())
        Console.WriteLine("Hello World!")





    End Sub
    Function enumeracion(opcion As operacion, valor1 As Integer, valor2 As Integer) As operacion
        Select Case opcion
            Case operacion.suma
                Return valor1 + valor2
            Case operacion.resta
                Return valor1 - valor2
            Case operacion.multiplicacion
                Return valor1 * valor2
            Case operacion.division
                Return valor1 / valor2
        End Select

    End Function

    Function sobrecargada(valor1, valor2) As Integer
        Return
    End Function
    Function sobrecargada(valor1, valor2, valor3) As Integer
        Return
    End Function
    Function sobrecargada(valor1, valor2, valor3, valor4) As Integer
        Return
    End Function

End Module
