<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_form))
        Me.kiran_X = New System.Windows.Forms.Label()
        Me.kiran_Y = New System.Windows.Forms.Label()
        Me.dateinnp = New System.Windows.Forms.Label()
        Me.me_goto = New System.Windows.Forms.Timer(Me.components)
        Me.me_height = New System.Windows.Forms.Timer(Me.components)
        Me.time_go = New System.Windows.Forms.Timer(Me.components)
        Me.date_go = New System.Windows.Forms.Timer(Me.components)
        Me.DateAndTimeNotify = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.date_and_time_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.converter_menu_item = New System.Windows.Forms.ToolStripMenuItem()
        Me.trans = New System.Windows.Forms.ToolStripMenuItem()
        Me.Skin = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ncell = New System.Windows.Forms.ToolStripMenuItem()
        Me.SkyBlue = New System.Windows.Forms.ToolStripMenuItem()
        Me.Green = New System.Windows.Forms.ToolStripMenuItem()
        Me.Blue = New System.Windows.Forms.ToolStripMenuItem()
        Me.Red = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.moveme = New System.Windows.Forms.PictureBox()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NcellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SkyBlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.timeinnp = New System.Windows.Forms.Label()
        Me.date_and_time_menu.SuspendLayout()
        CType(Me.moveme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'kiran_X
        '
        Me.kiran_X.AutoSize = True
        Me.kiran_X.Location = New System.Drawing.Point(355, 32)
        Me.kiran_X.Name = "kiran_X"
        Me.kiran_X.Size = New System.Drawing.Size(0, 13)
        Me.kiran_X.TabIndex = 0
        Me.kiran_X.Visible = False
        '
        'kiran_Y
        '
        Me.kiran_Y.AutoSize = True
        Me.kiran_Y.Location = New System.Drawing.Point(355, 45)
        Me.kiran_Y.Name = "kiran_Y"
        Me.kiran_Y.Size = New System.Drawing.Size(0, 13)
        Me.kiran_Y.TabIndex = 1
        Me.kiran_Y.Visible = False
        '
        'dateinnp
        '
        Me.dateinnp.BackColor = System.Drawing.Color.Transparent
        Me.dateinnp.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dateinnp.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateinnp.ForeColor = System.Drawing.Color.White
        Me.dateinnp.Location = New System.Drawing.Point(0, 22)
        Me.dateinnp.Name = "dateinnp"
        Me.dateinnp.Size = New System.Drawing.Size(283, 29)
        Me.dateinnp.TabIndex = 3
        Me.dateinnp.Text = "------------Date------"
        '
        'me_goto
        '
        '
        'me_height
        '
        '
        'time_go
        '
        Me.time_go.Enabled = True
        '
        'date_go
        '
        Me.date_go.Enabled = True
        Me.date_go.Interval = 1000
        '
        'DateAndTimeNotify
        '
        Me.DateAndTimeNotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.DateAndTimeNotify.BalloonTipText = "Date and Time [नेपाली] is running via system Tray "
        Me.DateAndTimeNotify.BalloonTipTitle = "Running"
        Me.DateAndTimeNotify.ContextMenuStrip = Me.date_and_time_menu
        Me.DateAndTimeNotify.Icon = CType(resources.GetObject("DateAndTimeNotify.Icon"), System.Drawing.Icon)
        Me.DateAndTimeNotify.Text = "नेपाली Date Bar"
        Me.DateAndTimeNotify.Visible = True
        '
        'date_and_time_menu
        '
        Me.date_and_time_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.converter_menu_item, Me.trans, Me.Skin, Me.AboutToolStripMenuItem1, Me.ExitToolStripMenuItem1})
        Me.date_and_time_menu.Name = "date_and_time_menu"
        Me.date_and_time_menu.Size = New System.Drawing.Size(154, 114)
        '
        'converter_menu_item
        '
        Me.converter_menu_item.Name = "converter_menu_item"
        Me.converter_menu_item.Size = New System.Drawing.Size(153, 22)
        Me.converter_menu_item.Text = "Date Converter"
        '
        'trans
        '
        Me.trans.Name = "trans"
        Me.trans.Size = New System.Drawing.Size(153, 22)
        Me.trans.Text = "Opacity"
        '
        'Skin
        '
        Me.Skin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ncell, Me.SkyBlue, Me.Green, Me.Blue, Me.Red})
        Me.Skin.Name = "Skin"
        Me.Skin.Size = New System.Drawing.Size(153, 22)
        Me.Skin.Text = "Skin"
        '
        'Ncell
        '
        Me.Ncell.Image = Global.MyClockAPP.My.Resources.Resources.logoncell
        Me.Ncell.Name = "Ncell"
        Me.Ncell.Size = New System.Drawing.Size(118, 22)
        Me.Ncell.Text = "Ncell"
        '
        'SkyBlue
        '
        Me.SkyBlue.Image = Global.MyClockAPP.My.Resources.Resources.sky
        Me.SkyBlue.Name = "SkyBlue"
        Me.SkyBlue.Size = New System.Drawing.Size(118, 22)
        Me.SkyBlue.Text = "Sky Blue"
        '
        'Green
        '
        Me.Green.Image = Global.MyClockAPP.My.Resources.Resources.green
        Me.Green.Name = "Green"
        Me.Green.Size = New System.Drawing.Size(118, 22)
        Me.Green.Text = "Green"
        '
        'Blue
        '
        Me.Blue.Image = Global.MyClockAPP.My.Resources.Resources.blue
        Me.Blue.Name = "Blue"
        Me.Blue.Size = New System.Drawing.Size(118, 22)
        Me.Blue.Text = "Blue"
        '
        'Red
        '
        Me.Red.Image = Global.MyClockAPP.My.Resources.Resources.red
        Me.Red.Name = "Red"
        Me.Red.Size = New System.Drawing.Size(118, 22)
        Me.Red.Text = "Red"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Image = Global.MyClockAPP.My.Resources.Resources.about
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Image = Global.MyClockAPP.My.Resources.Resources.no
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.AboutToolStripMenuItem.Image = Global.MyClockAPP.My.Resources.Resources.about
        Me.AboutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ExitToolStripMenuItem.Image = Global.MyClockAPP.My.Resources.Resources.no
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'moveme
        '
        Me.moveme.BackColor = System.Drawing.Color.Transparent
        Me.moveme.BackgroundImage = Global.MyClockAPP.My.Resources.Resources.about
        Me.moveme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.moveme.ContextMenuStrip = Me.date_and_time_menu
        Me.moveme.Location = New System.Drawing.Point(256, 27)
        Me.moveme.Name = "moveme"
        Me.moveme.Size = New System.Drawing.Size(24, 24)
        Me.moveme.TabIndex = 4
        Me.moveme.TabStop = False
        Me.moveme.Tag = "MOVE"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem1.Text = "Skin"
        '
        'NcellToolStripMenuItem
        '
        Me.NcellToolStripMenuItem.Image = Global.MyClockAPP.My.Resources.Resources.logoncell
        Me.NcellToolStripMenuItem.Name = "NcellToolStripMenuItem"
        Me.NcellToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NcellToolStripMenuItem.Text = "Ncell"
        '
        'GreenToolStripMenuItem
        '
        Me.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        Me.GreenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GreenToolStripMenuItem.Text = "Green"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BlueToolStripMenuItem.Text = "Blue"
        '
        'SkyBlueToolStripMenuItem
        '
        Me.SkyBlueToolStripMenuItem.Name = "SkyBlueToolStripMenuItem"
        Me.SkyBlueToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SkyBlueToolStripMenuItem.Text = "Sky Blue"
        '
        'RedToolStripMenuItem
        '
        Me.RedToolStripMenuItem.Name = "RedToolStripMenuItem"
        Me.RedToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RedToolStripMenuItem.Text = "Red"
        '
        'timeinnp
        '
        Me.timeinnp.BackColor = System.Drawing.Color.Transparent
        Me.timeinnp.Dock = System.Windows.Forms.DockStyle.Top
        Me.timeinnp.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeinnp.ForeColor = System.Drawing.Color.White
        Me.timeinnp.Location = New System.Drawing.Point(0, 0)
        Me.timeinnp.Name = "timeinnp"
        Me.timeinnp.Size = New System.Drawing.Size(283, 30)
        Me.timeinnp.TabIndex = 5
        Me.timeinnp.Text = "----Time----"
        '
        'main_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.MyClockAPP.My.Resources.Resources.green
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(283, 51)
        Me.Controls.Add(Me.kiran_Y)
        Me.Controls.Add(Me.kiran_X)
        Me.Controls.Add(Me.timeinnp)
        Me.Controls.Add(Me.moveme)
        Me.Controls.Add(Me.dateinnp)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main_form"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Date"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.HotPink
        Me.date_and_time_menu.ResumeLayout(False)
        CType(Me.moveme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents kiran_X As System.Windows.Forms.Label
    Friend WithEvents kiran_Y As System.Windows.Forms.Label
    Friend WithEvents dateinnp As System.Windows.Forms.Label
    Friend WithEvents me_goto As System.Windows.Forms.Timer
    Friend WithEvents me_height As System.Windows.Forms.Timer
    Friend WithEvents time_go As System.Windows.Forms.Timer
    Friend WithEvents date_go As System.Windows.Forms.Timer
    Friend WithEvents moveme As System.Windows.Forms.PictureBox
    Friend WithEvents DateAndTimeNotify As System.Windows.Forms.NotifyIcon
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NcellToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SkyBlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents date_and_time_menu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Skin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ncell As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SkyBlue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Green As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Blue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Red As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents trans As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents converter_menu_item As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents timeinnp As System.Windows.Forms.Label

End Class
