<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Difficulty
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Difficulty))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MAmount = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PAmount = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TAmount = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ok = New System.Windows.Forms.Button()
        Me.quit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Regions = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Food = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DRate = New System.Windows.Forms.NumericUpDown()
        Me.real = New System.Windows.Forms.RadioButton()
        Me.game = New System.Windows.Forms.RadioButton()
        CType(Me.MAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Regions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Food, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Money:"
        '
        'MAmount
        '
        Me.MAmount.Location = New System.Drawing.Point(108, 24)
        Me.MAmount.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.MAmount.Name = "MAmount"
        Me.MAmount.Size = New System.Drawing.Size(96, 22)
        Me.MAmount.TabIndex = 2
        Me.MAmount.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(210, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "$ million"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Population:"
        '
        'PAmount
        '
        Me.PAmount.Location = New System.Drawing.Point(108, 53)
        Me.PAmount.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.PAmount.Name = "PAmount"
        Me.PAmount.Size = New System.Drawing.Size(96, 22)
        Me.PAmount.TabIndex = 3
        Me.PAmount.Value = New Decimal(New Integer() {100000, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(210, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "people"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Military Size:"
        '
        'TAmount
        '
        Me.TAmount.Location = New System.Drawing.Point(108, 83)
        Me.TAmount.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.TAmount.Name = "TAmount"
        Me.TAmount.Size = New System.Drawing.Size(96, 22)
        Me.TAmount.TabIndex = 4
        Me.TAmount.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(210, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "troops"
        '
        'ok
        '
        Me.ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ok.Location = New System.Drawing.Point(150, 303)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(75, 23)
        Me.ok.TabIndex = 7
        Me.ok.Text = "&OK"
        Me.ok.UseVisualStyleBackColor = True
        '
        'quit
        '
        Me.quit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.quit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.quit.Location = New System.Drawing.Point(233, 303)
        Me.quit.Name = "quit"
        Me.quit.Size = New System.Drawing.Size(75, 23)
        Me.quit.TabIndex = 8
        Me.quit.Text = "&Quit"
        Me.quit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Disaster Rate:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Nation Name:"
        '
        'CName
        '
        Me.CName.Location = New System.Drawing.Point(97, 15)
        Me.CName.Name = "CName"
        Me.CName.Size = New System.Drawing.Size(205, 22)
        Me.CName.TabIndex = 1
        Me.CName.Text = "United States"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Food:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.game)
        Me.GroupBox1.Controls.Add(Me.real)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Regions)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Food)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.MAmount)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.PAmount)
        Me.GroupBox1.Controls.Add(Me.DRate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TAmount)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(287, 248)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Set Starting Amounts:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(210, 207)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "regions"
        '
        'Regions
        '
        Me.Regions.Location = New System.Drawing.Point(108, 205)
        Me.Regions.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Regions.Name = "Regions"
        Me.Regions.Size = New System.Drawing.Size(96, 22)
        Me.Regions.TabIndex = 20
        Me.Regions.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 207)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Regions:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(210, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "tons"
        '
        'Food
        '
        Me.Food.Location = New System.Drawing.Point(108, 116)
        Me.Food.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.Food.Name = "Food"
        Me.Food.Size = New System.Drawing.Size(96, 22)
        Me.Food.TabIndex = 5
        Me.Food.Value = New Decimal(New Integer() {50000, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(210, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "%"
        '
        'DRate
        '
        Me.DRate.DecimalPlaces = 7
        Me.DRate.Location = New System.Drawing.Point(108, 146)
        Me.DRate.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DRate.Name = "DRate"
        Me.DRate.Size = New System.Drawing.Size(96, 22)
        Me.DRate.TabIndex = 6
        Me.DRate.Value = New Decimal(New Integer() {5479, 0, 0, 458752})
        '
        'real
        '
        Me.real.AutoSize = True
        Me.real.Checked = True
        Me.real.Location = New System.Drawing.Point(108, 174)
        Me.real.Name = "real"
        Me.real.Size = New System.Drawing.Size(67, 17)
        Me.real.TabIndex = 22
        Me.real.TabStop = True
        Me.real.Text = "Realistic"
        Me.real.UseVisualStyleBackColor = True
        '
        'game
        '
        Me.game.AutoSize = True
        Me.game.Location = New System.Drawing.Point(181, 174)
        Me.game.Name = "game"
        Me.game.Size = New System.Drawing.Size(72, 17)
        Me.game.TabIndex = 23
        Me.game.Text = "Gamelike"
        Me.game.UseVisualStyleBackColor = True
        '
        'Difficulty
        '
        Me.AcceptButton = Me.ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.quit
        Me.ClientSize = New System.Drawing.Size(320, 341)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.quit)
        Me.Controls.Add(Me.ok)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Difficulty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.MAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Regions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Food, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MAmount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PAmount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TAmount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ok As System.Windows.Forms.Button
    Friend WithEvents quit As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Food As System.Windows.Forms.NumericUpDown
    Friend WithEvents Regions As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DRate As System.Windows.Forms.NumericUpDown
    Friend WithEvents game As System.Windows.Forms.RadioButton
    Friend WithEvents real As System.Windows.Forms.RadioButton
End Class
