<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlarmPanel
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
        TimePanel1 = New TimePanel()
        PictureBox1 = New PictureBox()
        ListBox1 = New ListBox()
        CheckBox1 = New CheckBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TimePanel1
        ' 
        TimePanel1.Location = New Point(3, 3)
        TimePanel1.Name = "TimePanel1"
        TimePanel1.Size = New Size(279, 131)
        TimePanel1.TabIndex = 0
        TimePanel1.Time = "00:00 AM"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(3, 140)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(110, 124)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' ListBox1
        ' 
        ListBox1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 25
        ListBox1.Items.AddRange(New Object() {"Cricket", "Bird", "Cow", "Drum Roll", "Boat Horn", "Fanfare", "Train"})
        ListBox1.Location = New Point(136, 160)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(111, 104)
        ListBox1.TabIndex = 2
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(162, 133)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(85, 21)
        CheckBox1.TabIndex = 3
        CheckBox1.Text = "Alarm ON"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' AlarmPanel
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(CheckBox1)
        Controls.Add(ListBox1)
        Controls.Add(PictureBox1)
        Controls.Add(TimePanel1)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "AlarmPanel"
        Size = New Size(284, 279)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TimePanel1 As TimePanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents CheckBox1 As CheckBox

End Class
