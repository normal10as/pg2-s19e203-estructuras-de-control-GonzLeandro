Imports System

Module cilindro
    Sub Main(args As String())
        Dim base, altura As Integer
        Do
            Console.WriteLine("Ingrese UNICAMENTE VALORES POSITIVOS")
            Console.Write("Ingrese la base del cilindro: ")
            base = Console.ReadLine()
            Console.Write("Ingrese la altura del cilindro: ")
            altura = Console.ReadLine()
        Loop While (ValidarDatos(base, altura) = 1)
        Console.WriteLine("El volumen del cilindro es: " & devolvervolumen(base, altura))
    End Sub

    Function devolvervolumen(base As Integer, altura As Integer) As Double
        Return Math.PI * base * base * altura
    End Function
    Function ValidarDatos(base As Integer, altura As Integer) As Integer
        If base > 0 And altura > 0 Then
            Return 0
        Else
            Return 1
        End If
    End Function
End Module
