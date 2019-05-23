Imports System

Module tercero
    Sub Main(args As String())
        Dim a, b, c, d, e As Integer
        Console.WriteLine("Ingrese el primer numero: ")
        a = Console.ReadLine()
        Console.WriteLine("Ingrese el segundo numero: ")
        b = Console.ReadLine()
        Console.WriteLine("Ingrese el tercer numero: ")
        c = Console.ReadLine()
        Console.WriteLine("Ingrese el cuarto numero: ")
        d = Console.ReadLine()
        Console.WriteLine("Ingrese el quinto numero: ")
        e = Console.ReadLine()
        If a > b And a > c And a > d And a > e Then
            Console.WriteLine("El mayor numero es '{0}' y su posicion de ingreso fue la Primera.", a)
        ElseIf b > c And b > d And b > e Then
            Console.WriteLine("El mayor numero es '{0}' y su posicion de ingreso fue la Segunda.", b)
        ElseIf c > d And c > e Then
            Console.WriteLine("El mayor numero es '{0}' y su posicion de ingreso fue la Tercera.", c)
        ElseIf d > e Then
            Console.WriteLine("El mayor numero es '{0}' y su posicion de ingreso fue la Cuarta.", d)
        Else
            Console.WriteLine("El mayor numero es '{0}' y su posicion de ingreso fue la Quinta.", e)
        End If
    End Sub
End Module
