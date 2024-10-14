Public Class TimePanel
    Inherits UserControl

    Private _hour1 As Integer = 0 ' First digit of hour
    Private _hour2 As Integer = 0 ' Second digit of hour
    Private _minute1 As Integer = 0 ' First digit of minute
    Private _minute2 As Integer = 0 ' Second digit of minute
    Public Sub InitiateMaxDigit()
        Digitled1.MaxDigit = 1
        Digitled2.MaxDigit = 9
        Digitled3.MaxDigit = 5
        Digitled4.MaxDigit = 9
    End Sub
    Public Sub SetCurrentTime()
        Dim currentTime As DateTime = DateTime.Now
        Me.Time = currentTime.ToString("hh:mm tt") ' AM/PM format
    End Sub

    Public Property Time As String
        Get
            Return $"{_hour1}{_hour2}:{_minute1}{_minute2} {(If(RadioButton1.Checked, "AM", "PM"))}"
        End Get
        Set(value As String)
            Dim timeParts() As String = value.Split(":"c)
            If timeParts.Length = 2 Then
                Dim hourPart As String = timeParts(0)
                Dim minutePart As String = timeParts(1).Replace(" AM", "").Replace(" PM", "")
                Dim isPM As Boolean = value.Contains("PM")

                ' Set the digits accordingly
                _hour1 = CInt(hourPart(0).ToString())
                _hour2 = CInt(hourPart(1).ToString())
                _minute1 = CInt(minutePart(0).ToString())
                _minute2 = CInt(minutePart(1).ToString())

                ' Update the DigitLED controls
                UpdateDisplay()
                RadioButton2.Checked = isPM
                RadioButton1.Checked = Not isPM
            End If
        End Set
    End Property
    Private Sub UpdateDisplay()
        ' Update the DigitLED displays with the current values
        Digitled1.Digit = _hour1
        Digitled2.Digit = _hour2
        Digitled3.Digit = _minute1
        Digitled4.Digit = _minute2
    End Sub
    Private Sub buttonSet_Click(sender As Object, e As EventArgs) Handles SetButton.Click
        ' Reset the time to 00:00AM and start interaction with keypad (to be implemented later)
        Time = "00:00 AM"
        AlarmClockForm.Size = New Size(458, 598)
        AlarmClockForm.Panel1.Visible = True
        ' Code to show keypad for user interaction goes here
    End Sub

    Private Sub buttonReset_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ' Reset the time to 00:00AM
        AlarmClockForm.Size = New Size(458, 335)
        AlarmClockForm.Panel1.Visible = False
        If AlarmClockForm.TabControl1.SelectedTab Is AlarmClockForm.TabControl1.TabPages("ClockTabPage") Then
            AlarmClockForm.TimePanel1.SetCurrentTime()
        Else
            Time = "00:00 AM"
        End If

    End Sub


    Private Sub TimePanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitiateMaxDigit()
    End Sub
End Class
