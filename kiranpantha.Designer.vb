<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kiran_Pantha
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
        Me.components = New System.ComponentModel.Container()
        Me.kiranpantha_time = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fb_lnk = New System.Windows.Forms.LinkLabel()
        Me.mywebsite = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.np_myfinger = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.np_myfinger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'kiranpantha_time
        '
        Me.kiranpantha_time.Enabled = True
        Me.kiranpantha_time.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(1, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(310, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "This software is designed by Kiran Pantha. "
        '
        'fb_lnk
        '
        Me.fb_lnk.AutoSize = True
        Me.fb_lnk.BackColor = System.Drawing.Color.Transparent
        Me.fb_lnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fb_lnk.ForeColor = System.Drawing.Color.Red
        Me.fb_lnk.Location = New System.Drawing.Point(68, 57)
        Me.fb_lnk.Name = "fb_lnk"
        Me.fb_lnk.Size = New System.Drawing.Size(206, 24)
        Me.fb_lnk.TabIndex = 24
        Me.fb_lnk.TabStop = True
        Me.fb_lnk.Text = "www.fb.com/kiranpanth"
        '
        'mywebsite
        '
        Me.mywebsite.AutoSize = True
        Me.mywebsite.BackColor = System.Drawing.Color.Transparent
        Me.mywebsite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mywebsite.ForeColor = System.Drawing.Color.Red
        Me.mywebsite.Location = New System.Drawing.Point(68, 81)
        Me.mywebsite.Name = "mywebsite"
        Me.mywebsite.Size = New System.Drawing.Size(186, 20)
        Me.mywebsite.TabIndex = 23
        Me.mywebsite.TabStop = True
        Me.mywebsite.Text = "www.kiranpantha.com.np"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 26)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Version 1.0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(67, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 26)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Nepali Date and Time"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.MyClockAPP.My.Resources.Resources.Waitting
        Me.PictureBox2.Location = New System.Drawing.Point(122, 175)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(189, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.MyClockAPP.My.Resources.Resources.npflagg
        Me.PictureBox1.Location = New System.Drawing.Point(5, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'np_myfinger
        '
        Me.np_myfinger.BackColor = System.Drawing.Color.Transparent
        Me.np_myfinger.Dock = System.Windows.Forms.DockStyle.Right
        Me.np_myfinger.Image = Global.MyClockAPP.My.Resources.Resources.np
        Me.np_myfinger.Location = New System.Drawing.Point(349, 0)
        Me.np_myfinger.Name = "np_myfinger"
        Me.np_myfinger.Size = New System.Drawing.Size(107, 207)
        Me.np_myfinger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.np_myfinger.TabIndex = 19
        Me.np_myfinger.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(1, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Loading...."
        '
        'Kiran_Pantha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 207)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fb_lnk)
        Me.Controls.Add(Me.mywebsite)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.np_myfinger)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Kiran_Pantha"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.np_myfinger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents np_myfinger As System.Windows.Forms.PictureBox
    Friend WithEvents kiranpantha_time As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fb_lnk As System.Windows.Forms.LinkLabel
    Friend WithEvents mywebsite As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
