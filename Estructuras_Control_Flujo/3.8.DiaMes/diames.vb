Imports System

Module diames
    Enum MesDelA�o
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
        Dim numeromes As MesDelA�o
        Dim a�o As Short
        Console.Write("Ingrese un mes del a�o (Entre 1 y 12): ")
        numeromes = Console.ReadLine

        Select Case numeromes
            Case 1, 3, 5, 7, 8, 10, 12
                Console.Write("El mes ingresado es: " & numeromes.ToString & " y tiene 31 dias")
            Case 2
                Console.Write("Ingresar a�o: ")
                a�o = Console.ReadLine()
                If (a�o Mod 4 = 0 And a�o Mod 100 <> 0 Or a�o Mod 400 = 0) Then
                    Console.WriteLine("El mes es febrero y tiene 29 dias")
                Else
                    Console.WriteLine("El mes es febrero y tiene 28 dias")

                End If

            Case 4, 6, 9, 11
                Console.Write("El mes ingresado es: " & numeromes.ToString & " y tiene 30 dias")
            Case Else

        End Select


    End Sub
End Module
