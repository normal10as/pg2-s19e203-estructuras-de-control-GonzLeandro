Module Operaciones
    Enum Operaciones As Integer
        suma = 1
        resta
        multiplicacion
        division
    End Enum
    Sub Main(args As String())
        Console.WriteLine(Calcular(Operaciones.suma, 5, 8))
        Console.WriteLine(Calcular(Operaciones.suma, 5, 8, 7))
        Console.WriteLine(Calcular(Operaciones.suma, 5, 8, 7, 1))
        Console.WriteLine(Calcular(Operaciones.resta, 8, 5))
        Console.WriteLine(Calcular(Operaciones.resta, 5, 4, 1))
        Console.WriteLine(Calcular(Operaciones.resta, 10, 4, 1, 1))
        Console.WriteLine(Calcular(Operaciones.multiplicacion, 2, 2))
        Console.WriteLine(Calcular(Operaciones.multiplicacion, 2, 2, 2))
        Console.WriteLine(Calcular(Operaciones.multiplicacion, 2, 2, 2, 2))
        Console.WriteLine(Calcular(Operaciones.division, 10, 2))
        Console.WriteLine(Calcular(Operaciones.division, 10, 2, 5))
        Console.WriteLine(Calcular(Operaciones.division, 10, 1, 2, 1))
        Console.WriteLine(Calcular(2, 1))
        Console.WriteLine(Calcular(1, 2, 1))
        Console.WriteLine(Calcular(10, 1, 2, 1))
    End Sub

    Function Calcular(elegir As Operaciones, num1 As Decimal, num2 As Integer) As Operaciones
        Select Case elegir
            Case Operaciones.suma
                Return num1 + num2
            Case Operaciones.resta
                Return num1 - num2
            Case Operaciones.multiplicacion
                Return num1 * num2
            Case Operaciones.division
                Return num1 / num2
        End Select
        Return elegir
    End Function
    Function Calcular(elegir As Operaciones, num1 As Integer, num2 As Integer, num3 As Integer) As Operaciones
        Return (Calcular(elegir, Calcular(elegir, num1, num2), num3))
    End Function
    Function Calcular(elegir As Operaciones, num1 As Integer, num2 As Integer, num3 As Integer, num4 As Integer) As Operaciones
        Return Calcular(elegir, Calcular(elegir, num1, num2, num3), num4)
    End Function

    Function Calcular(num1, num2) As Integer
        Return num1 + num2
    End Function
    Function Calcular(num1, num2, num3) As Integer
        Return Calcular(num1, num2) + num3
    End Function
    Function Calcular(num1, num2, num3, num4) As Integer
        Return Calcular(num1, num2) + Calcular(num3, num4)
    End Function
End Module