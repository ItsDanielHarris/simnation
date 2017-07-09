Public Class Main

    Public current_date As Date = New Date(1900, 1, 1)
    Public money, month_money, new_money, war_money, disaster_money, food_money, money_loss As Double
    Public tax As UInteger = 15
    Public pop, mil, month_pop, month_mil, new_pop, new_mil As Integer
    Public loan_due As Double
    Public loans_due As Double
    Public loan_paid As Double
    Public loans_paid As Double
    Public loan_days As UInteger
    Public disaster_rate As Double
    Public monthly_profit, avg_daily_profit, avg_monthly_profit As Double
    Public days As UInteger
    Public cname As String
    Public dpgrowth, mpgrowth As Integer
    Public wars, sl As UInteger
    Public food, total_food As Double
    Public mil_rate As Double = 0.00001
    Public regions As UInteger
    Public realistic As Boolean


    Public Function RandomNumber(ByVal MaxNumber As Integer, _
    Optional ByVal MinNumber As Integer = 0) As Integer

        'initialize random number generator
        Dim r As New Random(System.DateTime.Now.Millisecond)

        'if passed incorrect arguments, swap them
        'can also throw exception or return 0

        If MinNumber > MaxNumber Then
            Dim t As Integer = MinNumber
            MinNumber = MaxNumber
            MaxNumber = t
        End If

        Return r.Next(MinNumber, MaxNumber)

    End Function

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Difficulty.ShowDialog()
            Calendar.SetDate(New Date(1900, 1, 1))
            Calendar.TodayDate = New Date(1900, 1, 1)
            Timer.Start()
            MAmount.Text = money.ToString
            MSize.Text = money.ToString
            PAmount.Text = pop.ToString
            TAmount.Text = mil.ToString
            FAmount.Text = food.ToString
            RAmount.Text = regions.ToString
            Me.Text = "SimNation - " + cname
            CurrentDate.Text = MonthName(Calendar.TodayDate.Month) + " " + Calendar.TodayDate.Day.ToString + ", " + Calendar.TodayDate.Year.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        Try
            Dim old_date As Date = current_date
            current_date = current_date.AddDays(1)
            Calendar.SetDate(current_date)
            Calendar.TodayDate = current_date

            CurrentDate.Text = MonthName(Calendar.TodayDate.Month) + " " + Calendar.TodayDate.Day.ToString + ", " + Calendar.TodayDate.Year.ToString

            tax = TaxAmount.Value * 5

            new_money = (Math.Round(((tax * 0.000001) * pop) - ((RandomNumber(5) * 0.001) * mil), 1)) - (FImports.Value * 0.01)
            money = Math.Round(money, 1)
            money += new_money
            monthly_profit += new_money
            avg_daily_profit += new_money
            days += current_date.DayOfYear
            avg_daily_profit /= days
            avg_daily_profit = Math.Round(avg_daily_profit, 4)
            avg_monthly_profit += new_money
            avg_monthly_profit = Math.Round(avg_monthly_profit, 4)

            loan_paid = Math.Round(loans_due * (1 / loan_days), 1)

            If loan_due <= 0 Then
                loan_due = 0
                loans_due = 0
                loan_paid = 0
                LinkLabel1.Enabled = True
                LinkLabel2.Enabled = True
                LinkLabel3.Enabled = True
            Else
                loan_due -= loan_paid
                money -= loan_paid
                loans_paid += loan_paid
            End If

            month_money += new_money

            food = food - (0.00235 * pop) + FImports.Value
            food = Math.Round(food)
            total_food += Math.Round(0.00235 * pop)
            food_money += Math.Round(FImports.Value * 0.01)
            If food < 0 Then
                food = 0
            End If
            Dim food_cost As Integer = 0
            If food = 0 Then
                food_cost = RandomNumber(0, -100) * 0.001 * pop
            Else
                food_cost = food * 0.001
            End If

            new_pop = (((RandomNumber(100 - tax, -tax) * 0.001) * pop) + food_cost) * regions
            pop += new_pop
            If pop <= 0 Then
                pop = 0
            End If
            month_pop += new_pop
            dpgrowth += new_pop
            dpgrowth /= days
            dpgrowth = Math.Round(dpgrowth)
            mpgrowth += new_pop

            mil_rate = MRateValue.Value * 0.000001
            new_mil = (RandomNumber(100 - tax, -tax) * mil_rate) * pop
            mil += new_mil
            If mil <= 0 Then
                mil = 0
            End If
            month_mil += new_mil

            Events_Happening()

            MAmount.Text = "$" + money.ToString + " million"
            Cash.Text = "$" + money.ToString + " million"
            If money >= 0 Then
                Cash.ForeColor = Color.Green
                MAmount.ForeColor = Color.Green
            Else
                Cash.ForeColor = Color.Red
                MAmount.ForeColor = Color.Red
            End If
            TFLabel.Text = total_food.ToString + " tons"
            FMoneyLabel.Text = "$" + food_money.ToString + " million"
            PAmount.Text = pop.ToString + " people"
            TAmount.Text = mil.ToString + " troops"
            MSize.Text = mil.ToString + " troops"
            FAmount.Text = food.ToString + " tons"
            RAmount.Text = regions.ToString + " regions"
            YProfitLabel.Text = "$" + new_money.ToString + " million"
            ADProfitLabel.Text = "$" + avg_daily_profit.ToString + " million"
            DPGrowthLabel.Text = dpgrowth.ToString + " people"
            WarsLabel.Text = wars.ToString + " wars"
            SLLabel.Text = sl.ToString + " troops"
            WMoneyLabel.Text = "$" + war_money.ToString + " million"
            DMoneyLabel.Text = "$" + disaster_money.ToString + " million"
            LSpent.Text = "$" + loans_paid.ToString + " million"

            If old_date.Month <> current_date.Month Then

                avg_monthly_profit /= (current_date.Month - 1)
                avg_monthly_profit = Math.Round(avg_monthly_profit, 1)
                AMProfitLabel.Text = "$" + avg_monthly_profit.ToString + " million"

                mpgrowth /= (current_date.Month - 1)
                mpgrowth = Math.Round(mpgrowth)
                MPGrowthLabel.Text = mpgrowth.ToString + " people"

                LMProfitLabel.Text = "$" + monthly_profit.ToString + " million"
                monthly_profit = 0

                'Display Monthly Review
                Timer.Stop()
                Dim month As String = MonthName(old_date.Month)
                Dim report As String = "Money: " & vbTab & vbTab & "$" + month_money.ToString + " million" & vbNewLine & "Population: " & vbTab & month_pop.ToString + " people" & vbNewLine & "Military: " & vbTab & vbTab & month_mil.ToString + " troops"
                month_money = 0
                month_pop = 0
                month_mil = 0
                If DialogResult.OK = MsgBox(report, MsgBoxStyle.OkOnly, (month) + "'s Report") Then
                    Timer.Start()
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Pause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pause.Click
        Timer.Stop()
        status.Text = "Paused"
    End Sub

    Private Sub Play_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles play.Click
        Timer.Interval = 2000
        Timer.Start()
        status.Text = "1x"
    End Sub

    Private Sub FastForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fastforward.Click
        Timer.Interval = 500
        Timer.Start()
        status.Text = "4x"
    End Sub

    Private Sub FastForward2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fastforward2.Click
        Timer.Interval = 250
        Timer.Start()
        status.Text = "8x"
    End Sub

    Private Sub Events_Happening()
        Try
            If disaster_rate <> 0 Then

                If realistic Then

                    Dim capacity As Double = Math.Round(1 / disaster_rate)

                    Dim array As New ArrayList
                    For i As Double = 0.0 To capacity - 1.0
                        array.Add(0)
                    Next
                    array(0) = 1

                    'War
                    If array.Item(RandomNumber(capacity - 1)) = 1 Then
                        Timer.Stop()
                        War.ShowDialog()
                        Timer.Start()
                    End If

                    'Depression
                    If array.Item(RandomNumber(capacity - 1)) = 1 Then
                        Timer.Stop()
                        Dim rn As Double = RandomNumber(75, 50) * 0.01
                        money_loss = money * rn
                        If DialogResult.OK = MsgBox("Depression hits your economy greatly decreasing your money amount." & vbNewLine & "You lose $" & money_loss.ToString & " million.") Then
                            money -= money_loss
                            disaster_money += money_loss
                            disaster_money = Math.Round(disaster_money, 1)
                        End If
                    End If

                    'Recession
                    If array.Item(RandomNumber(capacity - 1)) = 1 Then
                        Timer.Stop()
                        Dim rn As Double = RandomNumber(35, 25) * 0.01
                        money_loss = money * rn
                        If DialogResult.OK = MsgBox("Recession hits your economy decreasing your money amount." & vbNewLine & "You lose $" & money_loss.ToString & " million.") Then
                            money -= money_loss
                            disaster_money += money_loss
                            disaster_money = Math.Round(disaster_money, 1)
                        End If
                    End If

                    Timer.Start()

                Else
                    Dim array As New ArrayList
                    For i As Double = 0 To disaster_rate - 1
                        array.Add(1)
                    Next
                    For i As Double = disaster_rate To 99
                        array.Add(0)
                    Next

                    'War
                    If array.Item(RandomNumber(99)) = 1 Then
                        Timer.Stop()
                        War.ShowDialog()
                        Timer.Start()
                    End If

                    'Depression
                    If array.Item(RandomNumber(99)) = 1 Then
                        Timer.Stop()
                        Dim rn As Double = RandomNumber(75, 50) * 0.01
                        money_loss = money * rn
                        If DialogResult.OK = MsgBox("Depression hits your economy greatly decreasing your money amount." & vbNewLine & "You lose $" & money_loss.ToString & " million.") Then
                            money -= money_loss
                            disaster_money += money_loss
                            disaster_money = Math.Round(disaster_money, 1)
                        End If
                    End If

                    'Recession
                    If array.Item(RandomNumber(99)) = 1 Then
                        Timer.Stop()
                        Dim rn As Double = RandomNumber(35, 25) * 0.01
                        money_loss = money * rn
                        If DialogResult.OK = MsgBox("Recession hits your economy decreasing your money amount." & vbNewLine & "You lose $" & money_loss.ToString & " million.") Then
                            money -= money_loss
                            disaster_money += money_loss
                            disaster_money = Math.Round(disaster_money, 1)
                        End If
                    End If

                    Timer.Start()

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If DialogResult.Yes = MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo) Then
            End
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub hundredmilloan(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If DialogResult.Yes = MsgBox("Are you sure you want to take out this loan for $100 million paying it over a 1 month period?", MsgBoxStyle.YesNo) Then
            money += 100
            loan_due = 105
            loans_due = 105
            loan_days = 30
            LinkLabel1.Enabled = False
            LinkLabel2.Enabled = False
            LinkLabel3.Enabled = False
        End If
    End Sub

    Private Sub thousandloan(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If DialogResult.Yes = MsgBox("Are you sure you want to take out this loan for $1000 million paying it over a 6 month period?", MsgBoxStyle.YesNo) Then
            money += 1000
            loan_due = 1100
            loans_due = 1100
            loan_days = 183
            LinkLabel1.Enabled = False
            LinkLabel2.Enabled = False
            LinkLabel3.Enabled = False
        End If
    End Sub

    Private Sub tenthousandloan(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        If DialogResult.Yes = MsgBox("Are you sure you want to take out this loan for $2000 million paying it over a 12 month period?", MsgBoxStyle.YesNo) Then
            money += 2000
            loan_due = 2400
            loans_due = 2400
            loan_days = 365
            LinkLabel1.Enabled = False
            LinkLabel2.Enabled = False
            LinkLabel3.Enabled = False
        End If
    End Sub

End Class
