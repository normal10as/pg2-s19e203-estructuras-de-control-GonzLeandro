Imports System

Module descuento
    Sub Main(args As String())
        Dim cantidad As Int16 = 1
        Dim precio, total, subtotal, descuento, ProductoSinDescuento, descuentoTotal As Single
        Do
            Console.WriteLine("Ingrese la Cantidad del producto: ")
            cantidad = Console.ReadLine()
            If cantidad <> 0 Then
                Console.WriteLine("Ingrese el Precio unitario del producto: ")
                precio = Console.ReadLine()

                ProductoSinDescuento = (precio * cantidad)
                subtotal = subtotal + ProductoSinDescuento

                If cantidad >= 10 And cantidad <= 50 Then
                    descuento -= ProductoSinDescuento * 0.05
                    descuentoTotal = descuento + (subtotal - descuento)
                    total += total + descuento
                    Console.WriteLine("Precio sin descuento del producto: " & ProductoSinDescuento)
                ElseIf cantidad >= 51 And cantidad <= 250 Then
                    descuento -= ProductoSinDescuento * 0.1
                    descuentoTotal = descuento + (subtotal - descuento)
                    total += total + descuento
                    Console.WriteLine("Precio sin descuento del producto: " & ProductoSinDescuento)
                ElseIf cantidad >= 251 Then
                    descuento -= ProductoSinDescuento * 0.2
                    descuentoTotal = descuento + (subtotal - descuento)
                    total += total + descuento
                    Console.WriteLine("Precio sin descuento del producto: " & ProductoSinDescuento)
                Else
                    Console.WriteLine("El precio total es: " & ProductoSinDescuento)
                End If
            End If
        Loop While (cantidad <> 0)
        Console.WriteLine("El subtotal es: " & subtotal)
        Console.WriteLine("El total es: " & total)
        Console.WriteLine("La cantidad de pesos descontados es: " & descuentoTotal)
    End Sub
End Module
