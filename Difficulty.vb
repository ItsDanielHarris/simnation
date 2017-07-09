Public Class Difficulty

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quit.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click
        Main.money = MAmount.Value
        Main.pop = PAmount.Value
        Main.mil = TAmount.Value
        Main.disaster_rate = DRate.Value
        Main.cname = CName.Text
        Main.food = Food.Value
        Main.regions = Regions.Value
        Main.realistic = real.Checked
        Me.Close()
    End Sub

    Private Sub game_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles game.CheckedChanged
        DRate.DecimalPlaces = 0
        DRate.Maximum = 100
        DRate.Value = 3
    End Sub

    Private Sub real_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles real.CheckedChanged
        DRate.DecimalPlaces = 7
        DRate.Maximum = 1
        DRate.Value = 0.0005479
    End Sub
End Class