Imports System

Module Program
    Sub Main(args As String())
        Dim num As Integer = 2
        Dim num_primo As Integer
        Dim index As Integer = 0
        Console.WriteLine("Numeros primos del 2 al 1000: ")
        While num < 1000
            For index = 1 To 1000
                If num Mod index = 0 Then
                    num_primo += 1
                End If
            Next
            If num_primo = 2 Then
                Console.WriteLine(num)
            End If
            num_primo = 0
            num += 1
        End While
    End Sub
End Module
