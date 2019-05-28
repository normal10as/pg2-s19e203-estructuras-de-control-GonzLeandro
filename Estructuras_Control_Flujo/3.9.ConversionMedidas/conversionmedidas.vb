Imports System

Module conversionmedidas
    Enum medidas As Integer
        PIE = 1
        PULGADAS = 2
        YARDA = 3
        CENTIMETROS = 4
        METROS = 5
    End Enum
    Dim numero As Decimal
    Sub Main(args As String())
        Dim valor As Byte
        Console.WriteLine(medidas.PIE & medidas.PIE.ToString)
        Console.WriteLine(medidas.PULGADAS & medidas.PULGADAS.ToString)
        Console.WriteLine(medidas.YARDA & medidas.YARDA.ToString)
        Console.WriteLine(medidas.CENTIMETROS & medidas.CENTIMETROS.ToString)
        Console.WriteLine(medidas.METROS & medidas.METROS.ToString)
        Console.Write("Ingrese una unidad de medida: ")
        valor = Console.ReadLine()

        Select Case valor
            Case 1
                ingresodatos(medidas.PIE)
                Console.WriteLine("Pulgadas: " & numero * 12)
                Console.WriteLine("YARDAS: " & numero / 3)
                Console.WriteLine("CENTIMETROS: " & numero * 30.48)
                Console.WriteLine("METROS: " & numero / 3.281)
            Case 2
                ingresodatos(medidas.PULGADAS)
                Console.WriteLine("PIE: " & numero / 12)
                Console.WriteLine("YARDAS: " & numero / 36)
                Console.WriteLine("CENTIMETROS: " & numero * 2.54)
                Console.WriteLine("METROS: " & numero / 39.37)
            Case 3
                ingresodatos(medidas.YARDA)
                Console.WriteLine("PIE: " & numero * 3)
                Console.WriteLine("Pulgadas: " & numero * 36)
                Console.WriteLine("CENTIMETROS: " & numero * 91.44)
                Console.WriteLine("METROS: " & numero / 1.094)
            Case 4
                ingresodatos(medidas.CENTIMETROS)
                Console.WriteLine("PIE: " & numero / 30.48)
                Console.WriteLine("YARDAS: " & numero / 91.44)
                Console.WriteLine("PULGADAS: " & numero / 2.54)
                Console.WriteLine("METROS: " & numero / 100)
            Case 5
                ingresodatos(medidas.METROS)
                Console.WriteLine("PIE: " & numero * 3.281)
                Console.WriteLine("YARDAS: " & numero * 1.094)
                Console.WriteLine("CENTIMETROS: " & numero * 100)
                Console.WriteLine("PULGADAS: " & numero * 39.37)
            Case Else
                Console.WriteLine("El numero ingresado es INCORRECTO.")

        End Select
    End Sub
    Private Function ingresodatos(valor) As String
        Console.Write("Ingrese el numero de {0} a convertir: ", valor)
        numero = Console.ReadLine
        Return numero
    End Function
End Module
