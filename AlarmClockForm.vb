Public Class AlarmClockForm
    Private Sub AlarmClockForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = False
        Me.Size = New Size(458, 335)
    End Sub
    Public digitButtons(9) As Button ' Array to hold references to digit buttons

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        AlarmPanel1.CheckBox1.Checked = CheckBox1.Checked


    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        digitButtons(0) = Button0
        digitButtons(1) = Button1
        digitButtons(2) = Button2
        digitButtons(3) = Button3
        digitButtons(4) = Button4
        digitButtons(5) = Button5
        digitButtons(6) = Button6
        digitButtons(7) = Button7
        digitButtons(8) = Button8
        digitButtons(9) = Button9
    End Sub


    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        AlarmPanel2.CheckBox1.Checked = CheckBox1.Checked

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        AlarmPanel3.CheckBox1.Checked = CheckBox1.Checked
    End Sub

    Private Sub TimePanel1_Load(sender As Object, e As EventArgs) Handles TimePanel1.Load
        TimePanel1.SetCurrentTime()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        TimePanel1.SetCurrentTime()
    End Sub
End Class