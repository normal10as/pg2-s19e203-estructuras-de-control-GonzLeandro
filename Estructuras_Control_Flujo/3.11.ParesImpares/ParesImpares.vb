Imports System

Module ParesImpares
    Sub Main(args As String())
        Dim valor As Integer = 1
        Dim par, impar As Integer

        Do While valor <> 0
            Console.Write("Ingrese un numero: ")
            valor = Console.ReadLine
            If valor Mod 2 Then
                impar += 1
            Else
                par += 1
            End If
        Loop
        par -= 1
        Console.WriteLine("La cantidad de pares es: " & par)
        Console.WriteLine("La cantidad de impares es: " & impar)
    End Sub
End Module
