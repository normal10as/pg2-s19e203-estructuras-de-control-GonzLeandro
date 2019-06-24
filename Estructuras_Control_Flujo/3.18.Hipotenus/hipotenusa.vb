Imports System

Module hipotenusa
    Dim ValorA, ValorB As Integer
    Dim validar As Boolean
    Sub Main(args As String())
        Do
            IngresoDatos()
        Loop While (ValidarDatos(ValorA, ValorB) = 1)
        Console.WriteLine("El Valor de la hipotenusa es: " & hipotenusa(ValorA, ValorB))

    End Sub
    Sub IngresoDatos()
        Console.WriteLine("Ingrese UNICAMENTE ENTEROS POSITIVOS.")
        Console.Write("Ingrese Lado A: ")
        ValorA = Console.ReadLine()
        Console.Write("Ingrese Lado B: ")
        ValorB = Console.ReadLine()
    End Sub
    Function hipotenusa(ValorA As Integer, ValorB As Integer) As Integer
        Return Math.Sqrt(ValorA * ValorA + ValorB * ValorB)
    End Function
    Function ValidarDatos(ValorA As Integer, ValorB As Integer) As Integer
        If ValorA > 0 And ValorB > 0 Then
            Return 0
        Else
            Return 1
        End If
    End Function
End Module
