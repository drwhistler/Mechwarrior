Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rdr = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Mechwarrior\MissionTypeList.txt")

        While Not rdr.EndOfStream
            Dim line As String = rdr.ReadLine()
            MissionType.Items.Add(line)
        End While
        rdr.Close()

        rdr = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Mechwarrior\TonnageLimitList.txt")

        While Not rdr.EndOfStream
            Dim line As String = rdr.ReadLine()
            Limit.Items.Add(line)
        End While
        rdr.Close()

        rdr = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Mechwarrior\FactionList.txt")

        While Not rdr.EndOfStream
            Dim line As String = rdr.ReadLine()
            Employer.Items.Add(line)
            Target.Items.Add(line)
        End While
        rdr.Close()

        Result.Items.Add("SUCCESS")
        Result.Items.Add("FAIL")

    End Sub


    Private Sub SaveMission_Click(sender As Object, e As EventArgs) Handles SaveMission.Click

        Dim mission As String = "  CURRENT MISSION" + Environment.NewLine +
                                "   System -  " + SystemName.Text.ToString + Environment.NewLine +
                                "   Mission Type - " + MissionType.SelectedItem.ToString + Environment.NewLine +
                                "   Employer - " + Employer.SelectedItem.ToString + Environment.NewLine +
                                "   Target - " + Target.SelectedItem.ToString + Environment.NewLine +
                                "   Limit - " + Limit.SelectedItem.ToString + Environment.NewLine +
                                "   Difficulty - " + Difficulty.Text.ToString

        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Mechwarrior\Mission.txt", mission)

    End Sub

    Private Sub SaveLog_Click(sender As Object, e As EventArgs) Handles SaveLog.Click

        'write newest log entry to perma-log
        Dim logRecordNew As String = " " + DateTimePicker1.Value.ToShortDateString + " | " +
                            SystemName.Text.ToString + " - " +
                            MissionType.SelectedItem.ToString + " - " +
                            Employer.SelectedItem.ToString + " - " +
                            Target.SelectedItem.ToString + " - " +
                            Limit.SelectedItem.ToString + " - " +
                            Difficulty.Text.ToString + " - " +
                            Result.SelectedItem.ToString + Environment.NewLine
        File.AppendAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Mechwarrior\MissionLog.txt", logRecordNew)

        'read current short mission log
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Mechwarrior\MissionLog2.txt")
        Dim logRecord1 As String = rdr.ReadLine() + Environment.NewLine
        Dim logRecord2 As String = rdr.ReadLine() + Environment.NewLine
        Dim logRecord3 As String = rdr.ReadLine() + Environment.NewLine
        Dim logRecord4 As String = rdr.ReadLine() + Environment.NewLine
        Dim logRecord5 As String = rdr.ReadLine() + Environment.NewLine
        rdr.Close()

        'write new short mission log
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Mechwarrior\MissionLog2.txt", " ")
        File.AppendAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Mechwarrior\MissionLog2.txt", logRecord1)
        File.AppendAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Mechwarrior\MissionLog2.txt", logRecordNew)
        File.AppendAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Mechwarrior\MissionLog2.txt", logRecord2)
        File.AppendAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Mechwarrior\MissionLog2.txt", logRecord3)
        File.AppendAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Mechwarrior\MissionLog2.txt", logRecord4)
        File.AppendAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Mechwarrior\MissionLog2.txt", logRecord5)

    End Sub

    Private Sub Reload_Click(sender As Object, e As EventArgs) Handles Reload.Click

        Dim rdr = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Mechwarrior\MissionTypeList.txt")

        MissionType.Items.Clear()
        While Not rdr.EndOfStream
            Dim line As String = rdr.ReadLine()
            MissionType.Items.Add(line)
        End While
        rdr.Close()

        rdr = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Mechwarrior\TonnageLimitList.txt")

        Limit.Items.Clear()
        While Not rdr.EndOfStream
            Dim line As String = rdr.ReadLine()
            Limit.Items.Add(line)
        End While
        rdr.Close()

        rdr = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Mechwarrior\FactionList.txt")

        Employer.Items.Clear()
        Target.Items.Clear()
        While Not rdr.EndOfStream
            Dim line As String = rdr.ReadLine()
            Employer.Items.Add(line)
            Target.Items.Add(line)
        End While
        rdr.Close()

    End Sub

    Private Sub SaveNewFaction_Click(sender As Object, e As EventArgs) Handles SaveNewFaction.Click

        File.AppendAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Mechwarrior\FactionList.txt", NewFactionName.Text.ToString + Environment.NewLine)

        Employer.Items.Clear()
        Target.Items.Clear()

        Dim rdr = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Mechwarrior\FactionList.txt")

        While Not rdr.EndOfStream
            Dim line As String = rdr.ReadLine()
            Employer.Items.Add(line)
            Target.Items.Add(line)
        End While
        rdr.Close()

        NewFactionName.Clear()

    End Sub

    Private Sub SaveMissonType_Click(sender As Object, e As EventArgs) Handles SaveMissonType.Click

        File.AppendAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Mechwarrior\MissionTypeList.txt", NewMissionType.Text.ToString + Environment.NewLine)

        MissionType.Items.Clear()

        Dim rdr = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Mechwarrior\MissionTypeList.txt")

        While Not rdr.EndOfStream
            Dim line As String = rdr.ReadLine()
            MissionType.Items.Add(line)
        End While
        rdr.Close()

        NewMissionType.Clear()

    End Sub
End Class
