<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimePanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Digitled1 = New DigitLED()
        Digitled2 = New DigitLED()
        Digitled3 = New DigitLED()
        Digitled4 = New DigitLED()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        SetButton = New Button()
        ResetButton = New Button()
        GroupBox1 = New GroupBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Digitled1
        ' 
        Digitled1.AutoSize = True
        Digitled1.BackColor = Color.White
        Digitled1.Digit = 0
        Digitled1.Font = New Font("Microsoft Sans Serif", 24.0F, FontStyle.Bold, GraphicsUnit.Point)
        Digitled1.ForeColor = Color.Red
        Digitled1.Location = New Point(9, 30)
        Digitled1.MaxDigit = 0
        Digitled1.Name = "Digitled1"
        Digitled1.Size = New Size(41, 37)
        Digitled1.TabIndex = 0
        Digitled1.Text = "H"
        Digitled1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Digitled2
        ' 
        Digitled2.AutoSize = True
        Digitled2.BackColor = Color.White
        Digitled2.Digit = 0
        Digitled2.Font = New Font("Microsoft Sans Serif", 24.0F, FontStyle.Bold, GraphicsUnit.Point)
        Digitled2.ForeColor = Color.Red
        Digitled2.Location = New Point(56, 30)
        Digitled2.MaxDigit = 0
        Digitled2.Name = "Digitled2"
        Digitled2.Size = New Size(41, 37)
        Digitled2.TabIndex = 1
        Digitled2.Text = "H"
        Digitled2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Digitled3
        ' 
        Digitled3.AutoSize = True
        Digitled3.BackColor = Color.White
        Digitled3.Digit = 0
        Digitled3.Font = New Font("Microsoft Sans Serif", 24.0F, FontStyle.Bold, GraphicsUnit.Point)
        Digitled3.ForeColor = Color.Red
        Digitled3.Location = New Point(103, 30)
        Digitled3.MaxDigit = 0
        Digitled3.Name = "Digitled3"
        Digitled3.Size = New Size(44, 37)
        Digitled3.TabIndex = 2
        Digitled3.Text = "M"
        Digitled3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Digitled4
        ' 
        Digitled4.AutoSize = True
        Digitled4.BackColor = Color.White
        Digitled4.Digit = 0
        Digitled4.Font = New Font("Microsoft Sans Serif", 24.0F, FontStyle.Bold, GraphicsUnit.Point)
        Digitled4.ForeColor = Color.Red
        Digitled4.Location = New Point(153, 30)
        Digitled4.MaxDigit = 0
        Digitled4.Name = "Digitled4"
        Digitled4.Size = New Size(44, 37)
        Digitled4.TabIndex = 3
        Digitled4.Text = "M"
        Digitled4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Checked = True
        RadioButton1.Location = New Point(19, 30)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(44, 19)
        RadioButton1.TabIndex = 4
        RadioButton1.TabStop = True
        RadioButton1.Text = "AM"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(19, 55)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(43, 19)
        RadioButton2.TabIndex = 5
        RadioButton2.Text = "PM"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' SetButton
        ' 
        SetButton.Location = New Point(9, 81)
        SetButton.Name = "SetButton"
        SetButton.Size = New Size(95, 23)
        SetButton.TabIndex = 6
        SetButton.Text = "SET"
        SetButton.UseVisualStyleBackColor = True
        ' 
        ' ResetButton
        ' 
        ResetButton.Location = New Point(103, 81)
        ResetButton.Name = "ResetButton"
        ResetButton.Size = New Size(94, 23)
        ResetButton.TabIndex = 7
        ResetButton.Text = "RESET"
        ResetButton.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Location = New Point(203, 9)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(63, 82)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        ' 
        ' TimePanel
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(GroupBox1)
        Controls.Add(ResetButton)
        Controls.Add(SetButton)
        Controls.Add(Digitled4)
        Controls.Add(Digitled3)
        Controls.Add(Digitled2)
        Controls.Add(Digitled1)
        Name = "TimePanel"
        Size = New Size(275, 111)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Digitled1 As DigitLED
    Friend WithEvents Digitled2 As DigitLED
    Friend WithEvents Digitled3 As DigitLED
    Friend WithEvents Digitled4 As DigitLED
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents SetButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents GroupBox1 As GroupBox

End Class
