<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dc_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dc_form))
        Me.kiran_yy = New System.Windows.Forms.Label()
        Me.Kiran_xx = New System.Windows.Forms.Label()
        Me.xit = New System.Windows.Forms.PictureBox()
        Me.my_convert = New System.Windows.Forms.GroupBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.mm = New System.Windows.Forms.ComboBox()
        Me.dd = New System.Windows.Forms.ComboBox()
        Me.yyyy = New System.Windows.Forms.ComboBox()
        Me.GO = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ad_bs = New System.Windows.Forms.PictureBox()
        Me.result = New System.Windows.Forms.TextBox()
        Me.lbl_hero = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.conv = New System.Windows.Forms.Label()
        Me.tip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.xit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.my_convert.SuspendLayout()
        CType(Me.ad_bs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'kiran_yy
        '
        Me.kiran_yy.AutoSize = True
        Me.kiran_yy.Location = New System.Drawing.Point(370, 248)
        Me.kiran_yy.Name = "kiran_yy"
        Me.kiran_yy.Size = New System.Drawing.Size(0, 13)
        Me.kiran_yy.TabIndex = 0
        Me.kiran_yy.Visible = False
        '
        'Kiran_xx
        '
        Me.Kiran_xx.AutoSize = True
        Me.Kiran_xx.Location = New System.Drawing.Point(370, 261)
        Me.Kiran_xx.Name = "Kiran_xx"
        Me.Kiran_xx.Size = New System.Drawing.Size(0, 13)
        Me.Kiran_xx.TabIndex = 1
        Me.Kiran_xx.Visible = False
        '
        'xit
        '
        Me.xit.BackColor = System.Drawing.Color.Transparent
        Me.xit.Image = Global.MyClockAPP.My.Resources.Resources.close
        Me.xit.Location = New System.Drawing.Point(297, -5)
        Me.xit.Name = "xit"
        Me.xit.Size = New System.Drawing.Size(48, 30)
        Me.xit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.xit.TabIndex = 3
        Me.xit.TabStop = False
        Me.tip.SetToolTip(Me.xit, "Close")
        '
        'my_convert
        '
        Me.my_convert.BackColor = System.Drawing.Color.Transparent
        Me.my_convert.Controls.Add(Me.lbl)
        Me.my_convert.Controls.Add(Me.mm)
        Me.my_convert.Controls.Add(Me.dd)
        Me.my_convert.Controls.Add(Me.yyyy)
        Me.my_convert.Controls.Add(Me.GO)
        Me.my_convert.Controls.Add(Me.Label2)
        Me.my_convert.Location = New System.Drawing.Point(12, 83)
        Me.my_convert.Name = "my_convert"
        Me.my_convert.Size = New System.Drawing.Size(325, 101)
        Me.my_convert.TabIndex = 10
        Me.my_convert.TabStop = False
        Me.my_convert.Text = "Convert AD TO BS"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.BackColor = System.Drawing.Color.Transparent
        Me.lbl.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.Transparent
        Me.lbl.Location = New System.Drawing.Point(262, 13)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(57, 33)
        Me.lbl.TabIndex = 18
        Me.lbl.Text = "text"
        Me.lbl.Visible = False
        '
        'mm
        '
        Me.mm.DropDownHeight = 100
        Me.mm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mm.DropDownWidth = 106
        Me.mm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mm.FormattingEnabled = True
        Me.mm.IntegralHeight = False
        Me.mm.Location = New System.Drawing.Point(110, 49)
        Me.mm.Name = "mm"
        Me.mm.Size = New System.Drawing.Size(47, 32)
        Me.mm.TabIndex = 18
        '
        'dd
        '
        Me.dd.DropDownHeight = 100
        Me.dd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dd.DropDownWidth = 106
        Me.dd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dd.FormattingEnabled = True
        Me.dd.IntegralHeight = False
        Me.dd.Location = New System.Drawing.Point(176, 49)
        Me.dd.Name = "dd"
        Me.dd.Size = New System.Drawing.Size(47, 32)
        Me.dd.TabIndex = 17
        '
        'yyyy
        '
        Me.yyyy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.yyyy.DropDownHeight = 100
        Me.yyyy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.yyyy.DropDownWidth = 106
        Me.yyyy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yyyy.FormattingEnabled = True
        Me.yyyy.IntegralHeight = False
        Me.yyyy.Location = New System.Drawing.Point(17, 49)
        Me.yyyy.Name = "yyyy"
        Me.yyyy.Size = New System.Drawing.Size(73, 32)
        Me.yyyy.TabIndex = 16
        '
        'GO
        '
        Me.GO.BackgroundImage = Global.MyClockAPP.My.Resources.Resources.tospng
        Me.GO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GO.ForeColor = System.Drawing.Color.White
        Me.GO.Location = New System.Drawing.Point(257, 49)
        Me.GO.Name = "GO"
        Me.GO.Size = New System.Drawing.Size(46, 32)
        Me.GO.TabIndex = 15
        Me.GO.Text = "→"
        Me.GO.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(11, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 31)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "YYYY   MM   DD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(8, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "The Converted Date is :"
        '
        'ad_bs
        '
        Me.ad_bs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ad_bs.BackColor = System.Drawing.Color.Transparent
        Me.ad_bs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ad_bs.Image = Global.MyClockAPP.My.Resources.Resources.BS
        Me.ad_bs.Location = New System.Drawing.Point(7, 34)
        Me.ad_bs.Name = "ad_bs"
        Me.ad_bs.Size = New System.Drawing.Size(121, 36)
        Me.ad_bs.TabIndex = 14
        Me.ad_bs.TabStop = False
        '
        'result
        '
        Me.result.AcceptsTab = True
        Me.result.BackColor = System.Drawing.Color.White
        Me.result.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.result.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result.Location = New System.Drawing.Point(7, 226)
        Me.result.MaxLength = 4
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(326, 26)
        Me.result.TabIndex = 15
        Me.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_hero
        '
        Me.lbl_hero.AutoSize = True
        Me.lbl_hero.BackColor = System.Drawing.Color.Transparent
        Me.lbl_hero.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hero.ForeColor = System.Drawing.Color.Transparent
        Me.lbl_hero.Location = New System.Drawing.Point(176, 39)
        Me.lbl_hero.Name = "lbl_hero"
        Me.lbl_hero.Size = New System.Drawing.Size(125, 33)
        Me.lbl_hero.TabIndex = 16
        Me.lbl_hero.Text = "BS → AD"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(-3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Date Converter "
        '
        'conv
        '
        Me.conv.BackColor = System.Drawing.Color.Transparent
        Me.conv.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.conv.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.conv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.conv.Location = New System.Drawing.Point(12, 255)
        Me.conv.Name = "conv"
        Me.conv.Size = New System.Drawing.Size(304, 22)
        Me.conv.TabIndex = 17
        '
        'tip
        '
        Me.tip.IsBalloon = True
        Me.tip.ToolTipTitle = "[X]"
        '
        'dc_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MyClockAPP.My.Resources.Resources.green
        Me.ClientSize = New System.Drawing.Size(343, 271)
        Me.Controls.Add(Me.conv)
        Me.Controls.Add(Me.lbl_hero)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.ad_bs)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.my_convert)
        Me.Controls.Add(Me.xit)
        Me.Controls.Add(Me.Kiran_xx)
        Me.Controls.Add(Me.kiran_yy)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "dc_form"
        Me.Opacity = 0.9R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Date_Converter"
        CType(Me.xit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.my_convert.ResumeLayout(False)
        Me.my_convert.PerformLayout()
        CType(Me.ad_bs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents kiran_yy As System.Windows.Forms.Label
    Friend WithEvents Kiran_xx As System.Windows.Forms.Label
    Friend WithEvents xit As System.Windows.Forms.PictureBox
    Friend WithEvents my_convert As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GO As System.Windows.Forms.Button
    Friend WithEvents ad_bs As System.Windows.Forms.PictureBox
    Friend WithEvents result As System.Windows.Forms.TextBox
    Friend WithEvents lbl_hero As System.Windows.Forms.Label
    Friend WithEvents mm As System.Windows.Forms.ComboBox
    Friend WithEvents dd As System.Windows.Forms.ComboBox
    Friend WithEvents yyyy As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents conv As System.Windows.Forms.Label
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents tip As System.Windows.Forms.ToolTip
End Class
