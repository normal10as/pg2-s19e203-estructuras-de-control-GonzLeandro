Imports System

Module comparar
    Sub Main(args As String())
        Dim primer, segundo As Integer
        Console.WriteLine("Ingrese el primer numero: ")
        primer = Console.ReadLine
        Console.WriteLine("Ingrese el segundo numero: ")
        segundo = Console.ReadLine

        If primer > segundo Then
            Console.WriteLine("El primer numero es 'mayor' que el segundo {0} < {1}", primer, segundo)
        ElseIf primer < segundo Then
            Console.WriteLine("El primer numero es 'menor' que el segundo {0} > {1}", primer, segundo)
        Else
            Console.WriteLine("Ambos numeros son 'iguales' {0} = {1}", primer, segundo)
        End If

    End Sub
End Module
