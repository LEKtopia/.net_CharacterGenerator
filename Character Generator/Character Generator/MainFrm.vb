Option Explicit On
Option Strict On

Public Class MainFrm

    Dim characterName As String
    Dim race As String

    Dim stats As New Dictionary(Of String, Integer)
    Dim numberGen As New Random()

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        characterName = txtName.Text

        Try
            race = cbxSelectRace.SelectedItem.ToString
        Catch ex As Exception
            MessageBox.Show("exception was thrown")
        End Try




        Dim statKeys As New List(Of String)(stats.Keys)

        For Each statKey As String In statKeys

            If race = "Human" Then
                stats(statKey) = RollDice(3, 6)
            ElseIf race = "Elf" Then

                If statKey = "str" Or statKey = "wil" Then
                    stats(statKey) = RollDice(3, 6)
                ElseIf statKey = "agi" Or statKey = "cha" Then
                    stats(statKey) = RollDice(6, 4)
                Else
                    stats(statKey) = RollDice(5, 4)
                End If

            Else
                MessageBox.Show("Under Construction, please select Human or Elf")
            End If

        Next

        DisplayStats()

    End Sub

    Private Function RollDice(numOfDice As Integer, sides As Integer) As Integer
        Return numberGen.Next(numOfDice, numOfDice * sides + 1)
    End Function

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles Me.Load

        InitializeCollections()
        DisplayStats()

    End Sub

    Private Sub InitializeCollections()

        stats.Add("str", 0)
        stats.Add("agi", 0)
        stats.Add("wit", 0)
        stats.Add("wil", 0)
        stats.Add("sns", 0)
        stats.Add("cha", 0)

    End Sub

    Private Sub DisplayStats()

        lblDisplaySTR.Text = stats("str").ToString()
        lblDisplayAGI.Text = stats("agi").ToString()
        lblDisplayWIT.Text = stats("wit").ToString()
        lblDisplayWIL.Text = stats("wil").ToString()
        lblDisplaySNS.Text = stats("sns").ToString()
        lblDisplayCHA.Text = stats("cha").ToString()

    End Sub

End Class
