Module Module1

    Sub Main()
        Dim hometeamname, awayteamname, winningteamname As String
        Dim homeruns, awayruns, rundifference As Integer

        hometeamname = ""
        awayteamname = ""
        winningteamname = ""
        homeruns = 0
        awayruns = 0
        rundifference = 0

        Console.Write("Home team: ")
        hometeamname = Console.ReadLine
        Console.Write("Home runs: ")
        homeruns = Console.ReadLine
        Console.Write("Away team: ")
        awayteamname = Console.ReadLine
        Console.Write("Away runs: ")
        awayruns = Console.ReadLine

        rundifference = awayruns - homeruns
        If rundifference < 0 Then
            rundifference = -1 * rundifference
            winningteamname = hometeamname
        Else
            winningteamname = awayteamname
        End If

        Console.Write("Winning team was " & winningteamname & " " & "Who scored " & rundifference & " " & "more runs")
        Console.ReadKey()
    End Sub

End Module
