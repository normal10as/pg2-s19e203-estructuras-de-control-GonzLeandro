Imports System
Imports System.Console
Module angulo
    Sub Main(args As String())
        Dim angulo As Short
        Write("Ingrese un angulo: ")
        angulo = ReadLine()

        Select Case angulo
            Case 1 To 89
                WriteLine("AGUDO")
            Case 90
                WriteLine("RECTO")
            Case 91 To 179
                WriteLine("OBTUSO")
            Case 180
                WriteLine("LLANO")
            Case 181 To 359
                WriteLine("CONCAVO")
            Case Else
                WriteLine("ERROR")
        End Select
    End Sub
End Module
