Imports System

Module fibonacci
    Sub Main(args As String())
        Dim a, b, c, cont As Integer
        a = 0
        b = 1
        c = 0
        cont = 0
        Do Until cont = 20
            Console.WriteLine(c)
            c = a + b
            a = b
            b = c
            cont += 1
        Loop
    End Sub
End Module
