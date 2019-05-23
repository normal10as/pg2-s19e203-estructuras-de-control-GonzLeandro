Imports System

Module menor
    Sub Main(args As String())
        Dim menor, valor As Integer

        Console.WriteLine("Ingrese un numero: ")
        menor = Console.ReadLine
        For index = 1 To 2
            Console.WriteLine("Ingrese un numero: ")
            valor = Console.ReadLine
            If valor < menor Then
                menor = valor
            End If

        Next
        Console.WriteLine("El numero menor ingresado es: " & menor)
    End Sub
End Module
