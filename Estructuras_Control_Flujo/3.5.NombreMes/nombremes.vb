Imports System

Module nombremes
    Enum MesDelAño
        Enero = 1
        Febrero
        Marzo
        Abril
        Mayo
        Junio
        Julio
        Septiembre
        Agosto
        Octubre
        Noviembre
        Diciembre
    End Enum

    Sub Main(args As String())
        Dim numeromes As MesDelAño
        Console.Write("Ingrese un mes del año (Entre 1 y 12): ")
        numeromes = Console.ReadLine

        Select Case numeromes
            Case 1 To 12
                Console.WriteLine("El mes ingresado es: " & numeromes.ToString)
            Case Else
                Console.WriteLine("El numero ingresado es invalido.")
        End Select

    End Sub
End Module
