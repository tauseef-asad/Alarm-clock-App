<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlarmClockForm
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
        components = New ComponentModel.Container()
        TabControl1 = New TabControl()
        ClockTabPage = New TabPage()
        TimePanel1 = New TimePanel()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        AlarmTabPage1 = New TabPage()
        AlarmPanel1 = New AlarmPanel()
        AlarmTabPage2 = New TabPage()
        AlarmPanel2 = New AlarmPanel()
        AlarmTabPage3 = New TabPage()
        AlarmPanel3 = New AlarmPanel()
        Panel1 = New Panel()
        ButtonOK = New Button()
        Button0 = New Button()
        ButtonCancel = New Button()
        Button9 = New Button()
        Button8 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Timer = New Timer(components)
        TabControl1.SuspendLayout()
        ClockTabPage.SuspendLayout()
        AlarmTabPage1.SuspendLayout()
        AlarmTabPage2.SuspendLayout()
        AlarmTabPage3.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(ClockTabPage)
        TabControl1.Controls.Add(AlarmTabPage1)
        TabControl1.Controls.Add(AlarmTabPage2)
        TabControl1.Controls.Add(AlarmTabPage3)
        TabControl1.Font = New Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TabControl1.Location = New Point(2, 7)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(308, 313)
        TabControl1.TabIndex = 0
        ' 
        ' ClockTabPage
        ' 
        ClockTabPage.Controls.Add(TimePanel1)
        ClockTabPage.Controls.Add(CheckBox3)
        ClockTabPage.Controls.Add(CheckBox2)
        ClockTabPage.Controls.Add(CheckBox1)
        ClockTabPage.Location = New Point(4, 25)
        ClockTabPage.Name = "ClockTabPage"
        ClockTabPage.Padding = New Padding(3)
        ClockTabPage.Size = New Size(300, 284)
        ClockTabPage.TabIndex = 0
        ClockTabPage.Text = "Clock"
        ClockTabPage.UseVisualStyleBackColor = True
        ' 
        ' TimePanel1
        ' 
        TimePanel1.Location = New Point(6, 6)
        TimePanel1.Name = "TimePanel1"
        TimePanel1.Size = New Size(319, 148)
        TimePanel1.TabIndex = 3
        TimePanel1.Time = "00:00 AM"
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(20, 207)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(69, 20)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Alarm 3"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(20, 181)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(69, 20)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Alarm 2"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(20, 157)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(67, 20)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Alarm 1"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' AlarmTabPage1
        ' 
        AlarmTabPage1.Controls.Add(AlarmPanel1)
        AlarmTabPage1.Location = New Point(4, 25)
        AlarmTabPage1.Name = "AlarmTabPage1"
        AlarmTabPage1.Padding = New Padding(3)
        AlarmTabPage1.Size = New Size(192, 71)
        AlarmTabPage1.TabIndex = 1
        AlarmTabPage1.Text = "Alarm 1"
        AlarmTabPage1.UseVisualStyleBackColor = True
        ' 
        ' AlarmPanel1
        ' 
        AlarmPanel1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        AlarmPanel1.Location = New Point(6, 9)
        AlarmPanel1.Name = "AlarmPanel1"
        AlarmPanel1.Size = New Size(284, 279)
        AlarmPanel1.TabIndex = 0
        ' 
        ' AlarmTabPage2
        ' 
        AlarmTabPage2.Controls.Add(AlarmPanel2)
        AlarmTabPage2.Location = New Point(4, 25)
        AlarmTabPage2.Name = "AlarmTabPage2"
        AlarmTabPage2.Padding = New Padding(3)
        AlarmTabPage2.Size = New Size(192, 71)
        AlarmTabPage2.TabIndex = 2
        AlarmTabPage2.Text = "Alarm 2"
        AlarmTabPage2.UseVisualStyleBackColor = True
        ' 
        ' AlarmPanel2
        ' 
        AlarmPanel2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        AlarmPanel2.Location = New Point(0, 0)
        AlarmPanel2.Name = "AlarmPanel2"
        AlarmPanel2.Size = New Size(284, 288)
        AlarmPanel2.TabIndex = 0
        ' 
        ' AlarmTabPage3
        ' 
        AlarmTabPage3.Controls.Add(AlarmPanel3)
        AlarmTabPage3.Location = New Point(4, 25)
        AlarmTabPage3.Name = "AlarmTabPage3"
        AlarmTabPage3.Padding = New Padding(3)
        AlarmTabPage3.Size = New Size(192, 71)
        AlarmTabPage3.TabIndex = 3
        AlarmTabPage3.Text = "Alarm 3"
        AlarmTabPage3.UseVisualStyleBackColor = True
        ' 
        ' AlarmPanel3
        ' 
        AlarmPanel3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        AlarmPanel3.Location = New Point(0, 0)
        AlarmPanel3.Name = "AlarmPanel3"
        AlarmPanel3.Size = New Size(284, 279)
        AlarmPanel3.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(ButtonOK)
        Panel1.Controls.Add(Button0)
        Panel1.Controls.Add(ButtonCancel)
        Panel1.Controls.Add(Button9)
        Panel1.Controls.Add(Button8)
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(6, 326)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(300, 229)
        Panel1.TabIndex = 0
        ' 
        ' ButtonOK
        ' 
        ButtonOK.Location = New Point(148, 155)
        ButtonOK.Name = "ButtonOK"
        ButtonOK.Size = New Size(58, 41)
        ButtonOK.TabIndex = 11
        ButtonOK.Text = "OK"
        ButtonOK.UseVisualStyleBackColor = True
        ' 
        ' Button0
        ' 
        Button0.Location = New Point(102, 155)
        Button0.Name = "Button0"
        Button0.Size = New Size(49, 41)
        Button0.TabIndex = 10
        Button0.Text = "0"
        Button0.UseVisualStyleBackColor = True
        ' 
        ' ButtonCancel
        ' 
        ButtonCancel.Location = New Point(47, 155)
        ButtonCancel.Name = "ButtonCancel"
        ButtonCancel.Size = New Size(59, 41)
        ButtonCancel.TabIndex = 9
        ButtonCancel.Text = "Cancel"
        ButtonCancel.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(157, 108)
        Button9.Name = "Button9"
        Button9.Size = New Size(49, 41)
        Button9.TabIndex = 8
        Button9.Text = "9"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(102, 108)
        Button8.Name = "Button8"
        Button8.Size = New Size(49, 41)
        Button8.TabIndex = 7
        Button8.Text = "8"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(47, 108)
        Button7.Name = "Button7"
        Button7.Size = New Size(49, 41)
        Button7.TabIndex = 6
        Button7.Text = "7"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(157, 61)
        Button6.Name = "Button6"
        Button6.Size = New Size(49, 41)
        Button6.TabIndex = 5
        Button6.Text = "6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(102, 61)
        Button5.Name = "Button5"
        Button5.Size = New Size(49, 41)
        Button5.TabIndex = 4
        Button5.Text = "5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(47, 61)
        Button4.Name = "Button4"
        Button4.Size = New Size(49, 41)
        Button4.TabIndex = 3
        Button4.Text = "4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(157, 14)
        Button3.Name = "Button3"
        Button3.Size = New Size(49, 41)
        Button3.TabIndex = 2
        Button3.Text = "3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(102, 14)
        Button2.Name = "Button2"
        Button2.Size = New Size(49, 41)
        Button2.TabIndex = 1
        Button2.Text = "2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(47, 14)
        Button1.Name = "Button1"
        Button1.Size = New Size(49, 41)
        Button1.TabIndex = 0
        Button1.Text = "1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Timer
        ' 
        Timer.Enabled = True
        Timer.Interval = 60000
        ' 
        ' AlarmClockForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(736, 522)
        Controls.Add(Panel1)
        Controls.Add(TabControl1)
        Name = "AlarmClockForm"
        Text = "Tauseef Asad's Form"
        TabControl1.ResumeLayout(False)
        ClockTabPage.ResumeLayout(False)
        ClockTabPage.PerformLayout()
        AlarmTabPage1.ResumeLayout(False)
        AlarmTabPage2.ResumeLayout(False)
        AlarmTabPage3.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ClockTabPage As TabPage
    Friend WithEvents AlarmTabPage1 As TabPage
    Friend WithEvents AlarmTabPage2 As TabPage
    Friend WithEvents AlarmTabPage3 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonOK As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TimePanel1 As TimePanel
    Friend WithEvents AlarmPanel1 As AlarmPanel
    Friend WithEvents AlarmPanel2 As AlarmPanel
    Friend WithEvents AlarmPanel3 As AlarmPanel
End Class
