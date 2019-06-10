Imports System

Module Program
    Const interes As UShort = 36
    Sub main()
        Dim capital, saldo, acuminteres As Single
        Dim meses, acum, interesmensual As UShort
        acum = 1

        Console.WriteLine("Ingrese dinero a depositar: ")
        capital = Console.ReadLine()
        Console.WriteLine("Ingrese plazo en meses: ")
        meses = Console.ReadLine()

        Do While acum <= meses
            interesmensual = interes / 12
            saldo = capital + (capital * interesmensual / 100)
            acuminteres = acuminteres + (capital * interesmensual / 100)
            Console.WriteLine("Mes {0}     |El capital es: {1}|     |Intereses ganados {2}|      |Saldo {3}|", acum, capital, interesmensual, saldo)
            capital = saldo
            acum += 1
        Loop
        Console.WriteLine("El total de interes acumulado es de: " & acuminteres)
    End Sub
End Module
