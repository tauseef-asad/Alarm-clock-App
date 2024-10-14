Imports System.Windows.Forms

Public Class DigitLED
    Inherits Label

    ' Private fields to hold the maximum digit and current digit value
    Private _maxDigit As Integer
    Private _digit As Integer

    ' Constructor to set default properties
    Public Sub New()
        ' Set default font and other properties
        Me.Font = New Font("Digital", 24, FontStyle.Bold) ' You can change the font type and size as needed
        Me.BackColor = Color.White
        Me.ForeColor = Color.Red
        Me.TextAlign = ContentAlignment.MiddleCenter
    End Sub


    ' User-defined property to get/set the maximum digit allowed
    Public Property MaxDigit() As Integer
        Get
            Return _maxDigit
        End Get
        Set(value As Integer)
            _maxDigit = value
        End Set
    End Property

    ' Property to get/set the digit value with validation
    Public Property Digit() As Integer
        Get
            Return _digit
        End Get
        Set(value As Integer)
            If value >= 0 AndAlso value <= _maxDigit Then
                _digit = value
                Me.Text = _digit.ToString("D" & _maxDigit.ToString.Length) ' Formats the digit
            Else
                Throw New ArgumentOutOfRangeException("Digit must be between 0 and " & _maxDigit)
            End If
        End Set
    End Property

    ' Override the OnPaint method if needed for custom drawing (optional)
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        ' Custom drawing code can go here if you want to draw additional effects
    End Sub
End Class
