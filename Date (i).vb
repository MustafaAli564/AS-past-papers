Module Module1

    Sub Main()
        Dim nextdate, Discount, DISCOUNT_DATES As String

        FileOpen(1, "D:/DISCOUNT_DATES.txt", OpenMode.Output)
        Console.Write("Date: ")
        nextdate = Console.ReadLine
        While nextdate <> "XXX"
            Console.WriteLine("Discount TRUE/FALSE")
            Discount = Console.ReadLine
            DISCOUNT_DATES = nextdate & " " & Discount
            WriteLine(1, DISCOUNT_DATES)
            Console.Write("date: ")
            nextdate = Console.ReadLine

        End While
        Console.WriteLine("File Made")
        Console.ReadKey()

        FileClose(1)

    End Sub

End Module
