Imports System

Module venta
    Sub Main(args As String())
        Dim cantidad As Int16
        Dim precio, total As Single

        Console.WriteLine("Ingrese la Cantidad del producto: ")
        cantidad = Console.ReadLine()
        Console.WriteLine("Ingrese el Precio unitario del producto: ")
        precio = Console.ReadLine()

        total = (cantidad * precio)
        Console.WriteLine("total sin descuento: " & total)

        If cantidad >= 10 And cantidad <= 50 Then
            total -= total * 0.05
           
        ElseIf cantidad >= 51 And cantidad <= 250 Then
            total -= total * 0.1
        ElseIf cantidad >= 251 Then
            total -= total * 0.2
        Else
            total = (cantidad * precio)
        End If
        Console.WriteLine("El precio total es: " & total)
    End Sub
End Module
