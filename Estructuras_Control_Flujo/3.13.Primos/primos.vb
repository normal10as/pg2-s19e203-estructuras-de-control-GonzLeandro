Imports System

Module primos
    Dim x As Integer
    Sub Main(args As String())
        numerosprimos2()
    End Sub

    Sub numerosprimos2()
        Do While (x < 1000)
            x += 1
            If (x / 1 = x) And (x Mod x = 0) And (x Mod 2 <> 0) Then
                Console.WriteLine(x)
            End If
        Loop
    End Sub
    Sub numerosprimos()
        For x = 1 To 20
            If x Mod 1 = 0 And x / x = 1 Then
                Console.WriteLine(x)
            Else
                Console.Write("NO QUIERO")
            End If
        Next
    End Sub
End Module
