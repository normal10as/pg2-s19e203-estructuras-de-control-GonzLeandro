Imports System

Module operaciones2
    Enum operacion As Integer
        suma = 1
        resta
        multiplicacion
        division
    End Enum
    Sub Main(args As String())
        Console.WriteLine(sobrecargada(operacion.suma, 5, 8))
        Console.WriteLine(sobrecargada(operacion.suma, 5, 8, 7))
        Console.WriteLine(sobrecargada(operacion.suma, 5, 8, 7, 1))
        Console.WriteLine(sobrecargada(operacion.resta, 8, 5))
        Console.WriteLine(sobrecargada(operacion.resta, 5, 4, 1))
        Console.WriteLine(sobrecargada(operacion.resta, 10, 4, 1, 1))
        Console.WriteLine(sobrecargada(operacion.multiplicacion, 2, 2))
        Console.WriteLine(sobrecargada(operacion.multiplicacion, 2, 2, 2))
        Console.WriteLine(sobrecargada(operacion.multiplicacion, 2, 2, 2, 2))
        Console.WriteLine(sobrecargada(operacion.division, 10, 2))
        Console.WriteLine(sobrecargada(operacion.division, 10, 2, 5))
        Console.WriteLine(sobrecargada(operacion.division, 10, 1, 2, 1))
        Console.WriteLine(sobrecargada(2, 1))
        Console.WriteLine(sobrecargada(1, 2, 1))
        Console.WriteLine(sobrecargada(10, 1, 2, 1))


    End Sub
    Function enumeracion(opcion As operacion, numero1 As Integer, numero2 As Integer) As operacion
        Select Case opcion
            Case operacion.suma
                Return numero1 + numero2
            Case operacion.resta
                Return numero1 - numero2
            Case operacion.multiplicacion
                Return numero1 * numero2
            Case operacion.division
                Return numero1 / numero2
        End Select
    End Function

    Function sobrecargada(opcion As operacion, numero1 As Integer, numero2 As Integer, numero3 As Integer) As operacion
        Return enumeracion(opcion, enumeracion(opcion, numero1, numero2), numero3)
    End Function
    Function sobrecargada(opcion As operacion, numero1 As Integer, numero2 As Integer, numero3 As Integer, numero4 As Integer) As Integer
        Return enumeracion(opcion, enumeracion(opcion, numero1, numero2), enumeracion(opcion, numero3, numero4))
    End Function

    Function sobrecargada(numero1, numero2) As Integer
        Return numero1 + numero2
    End Function
    Function sobrecargada(numero1, numero2, numero3) As Integer
        Return sobrecargada(numero1, numero2) + numero3
    End Function
    Function sobrecargada(numero1, numero2, numero3, numero4) As Integer
        Return sobrecargada(numero1, numero2) + sobrecargada(numero3, numero4)
    End Function




End Module
