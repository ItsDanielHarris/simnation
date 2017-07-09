Public Class War

    Private Sub Fight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Main.RandomNumber(100) Mod 2 = 1 Then
            'Win
            Dim rn As Double = Main.RandomNumber(10) * 0.01
            Dim tl As Integer = Main.mil * rn

            If tl > Main.mil Then
                rn = 0.25
                MsgBox("You do not have enough troops to support the war. You lose $" + rn.ToString + " million.")
                Me.Close()
            End If

            Main.money_loss = Main.money * rn

            Main.wars += 1
            If Main.mil > 0 Then
                Main.sl += tl
                Main.mil -= tl
            Else
                Main.mil = 0
            End If
            Main.money -= Main.money_loss
            Main.war_money += Main.money_loss
            Main.war_money = Math.Round(Main.war_money, 1)

            MsgBox("Your country won the war. You've managed to keep your regions but you lost " + tl.ToString + " troops and $" + Main.money_loss.ToString + " million.")
        Else
            'Lose
            Dim rn As Double = Main.RandomNumber(25, 15) * 0.01
            Dim tl As Integer = Main.mil * rn

            If tl > Main.mil Then
                rn = 0.25
                MsgBox("You do not have enough troops to support the war. You lose $" + rn.ToString + " million.")
                Me.Close()
            End If

            Main.money_loss = Main.money * rn

            Main.wars += 1
            If Main.mil > 0 Then
                Main.sl += tl
                Main.mil -= tl
            Else
                Main.mil = 0
            End If
            Main.money -= Main.money_loss
            Main.war_money += Main.money_loss
            Main.war_money = Math.Round(Main.war_money, 1)

            Main.regions -= 1

            MsgBox("Your country lost the war. You lose " + tl.ToString + " troops, $" + Main.money_loss.ToString + " million and a region.")
        End If
        Me.Close()
    End Sub

    Private Sub Surrender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim rn As Double = Main.RandomNumber(25, 15) * 0.01
            Dim tl As Integer = Main.mil * rn

            If DialogResult.Yes = MsgBox("Are you sure you want to surrender? You will lose $" + (Main.money * rn).ToString + " million, and a region.", MsgBoxStyle.YesNo) Then

                Main.money_loss = Main.money * rn

                Main.wars += 1

                Main.money -= Main.money_loss
                Main.war_money += Main.money_loss
                Main.war_money = Math.Round(Main.war_money, 1)

                Main.regions -= 1

                MsgBox("You lost $" + Main.money_loss.ToString + " million and a region.")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub War_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Main.cname + " Declares War"
    End Sub
End Class