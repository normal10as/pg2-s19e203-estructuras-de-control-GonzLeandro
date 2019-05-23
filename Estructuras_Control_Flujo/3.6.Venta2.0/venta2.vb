Imports System

Module venta2
    Enum Descuento As Byte
        Uno = 0.05
        Dos = 0.1
        Tres = 0.2
    End Enum

    Sub Main(args As String())
        Dim cantidad As Int16
        Dim precio, total As Single

        Console.WriteLine("Ingrese la Cantidad del producto: ")
        cantidad = Console.ReadLine()
        Console.WriteLine("Ingrese el Precio unitario del producto: ")
        precio = Console.ReadLine()

        total = (cantidad * precio)
        Console.WriteLine("total sin descuento: " & total)

        Select Case cantidad
            Case 10 To 50
                total -= total * Descuento.Uno
                Console.WriteLine("El precio total es: " & total)
            Case 51 To 250
                total -= total * Descuento.Dos
                Console.WriteLine("El precio total es: " & total)
            Case >= 251
                total -= total * Descuento.Tres
                Console.WriteLine("El precio total es: " & total)
            Case Else
                Console.WriteLine("El precio total es: " & total)
        End Select

    End Sub

End Module
