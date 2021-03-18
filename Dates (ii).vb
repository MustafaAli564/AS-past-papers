Module Module1

    Sub Main()
        Dim finddate, filedate As String
        Dim found As Boolean
        found = False
        FileOpen(1, "D:/DISCOUNT_DATES.txt", OpenMode.Input)
        Console.WriteLine("Enter Date as DD/MM/YYYY to find")
        finddate = Console.ReadLine
        Do Until EOF(1) Or found = True
            Input(1, filedate)
            If Left(filedate, 10) = finddate Then
                found = True
            End If
        Loop
        If found = True Then
            If Mid(filedate, 12, (Len(filedate) - 11)) = "TRUE" Then
                Console.WriteLine("This is a Discount Date")
            Else
                Console.WriteLine("No discount on this date")
            End If
        Else
            Console.WriteLine("Date not found")
        End If
        FileClose(1)
        Console.ReadKey()
    End Sub

End Module
