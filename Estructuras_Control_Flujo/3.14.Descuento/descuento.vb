Imports System

Module descuento
    Dim Cantidad As Integer
    Dim Precio, PrecioSinDescuento, PrecioConDescuento, DescuentoTotal, SubTotal, Total As Single
    Sub Main(args As String())
        Do
            Console.Write("Ingrese la cantidad del producto: ")
            Cantidad = Console.ReadLine()
            If Cantidad <> 0 Then
                Console.Write("Ingrese el precio unitario del producto: ")
                Precio = Console.ReadLine()
                PrecioSinDescuento = Cantidad * Precio
                SubTotal = SubTotal + PrecioSinDescuento
                If Cantidad >= 10 And Cantidad <= 50 Then
                    ResolverDescuentosTotales(PrecioSinDescuento, 0.05)
                ElseIf Cantidad >= 51 And Cantidad <= 250 Then
                    ResolverDescuentosTotales(PrecioSinDescuento, 0.1)
                ElseIf Cantidad >= 251 Then
                    ResolverDescuentosTotales(PrecioSinDescuento, 0.2)
                Else
                    Console.WriteLine("Precio sin descuento del producto: " & PrecioSinDescuento)
                End If
            End If
        Loop While (Cantidad <> 0)
        Console.WriteLine("El subtotal es: " & SubTotal)
        Console.WriteLine("El total es: " & Total)
        Console.WriteLine("La cantidad de pesos descontados es: " & DescuentoTotal)
    End Sub
    Sub ResolverDescuentosTotales(PrecioSinDescuento, descuento)
        PrecioConDescuento = PrecioSinDescuento - (PrecioSinDescuento * descuento)
        DescuentoTotal = DescuentoTotal + (PrecioSinDescuento - PrecioConDescuento)
        Total = Total + PrecioConDescuento
        Console.WriteLine("Precio sin descuento del producto: " & PrecioSinDescuento)
    End Sub
End Module