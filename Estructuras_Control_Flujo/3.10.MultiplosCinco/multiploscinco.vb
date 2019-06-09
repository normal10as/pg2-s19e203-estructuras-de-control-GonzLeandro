Imports System

Module multiploscinco
    Dim texto As Int16
    Sub Main(args As String())
        Dim menor As Int16
        Dim mayor As Int16
        Dim multiplos As Int16 = 0
        Dim cont As Int16 = 0
        Console.WriteLine("ingrese un valor ")
        menor = Console.ReadLine()
        Console.WriteLine("ingrese un valor mayor al anterior ")
        mayor = Console.ReadLine()
        Do While cont < mayor
            cont += 1
            If cont Mod 5 = 0 Then
                multiplos += 1
            End If
        Loop
        multiplosexistentesss(multiplos)

        Do Until cont = mayor
            cont += 1
            If cont Mod 5 = 0 Then
                multiplos += 1
            End If

        Loop
        multiplosexistentesss(multiplos)

        Do
            cont += 1
            If cont Mod 5 = 0 Then
                multiplos += 1
            End If
        Loop While cont < mayor
        multiplosexistentesss(multiplos)

        Do
            cont += 1
            If cont Mod 5 = 0 Then
                multiplos += 1
            End If
        Loop Until cont > mayor
        multiplosexistentesss(multiplos)

    End Sub

    Sub multiplosexistentesss(multiplos As Int16)
        Console.WriteLine("existen " & multiplos & " multiplos de 5 entre ambos numeros")
    End Sub

End Module
