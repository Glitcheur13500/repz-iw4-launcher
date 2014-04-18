<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepzIW4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepzIW4))
        Me.TextTimer = New System.Windows.Forms.Timer(Me.components)
        Me.OrainsTheme1 = New LauncherV3.OrainsTheme()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Status = New System.Windows.Forms.Label()
        Me.StartGameBTN = New System.Windows.Forms.Button()
        Me.MSGLABEL = New System.Windows.Forms.Label()
        Me.MSG2BOX = New LauncherV3.LogInNormalTextBox()
        Me.LogInCheckBox1 = New LauncherV3.LogInCheckBox()
        Me.OrainsControlBox1 = New LauncherV3.OrainsControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LogInLogButton1 = New LauncherV3.LogInLogButton()
        Me.ProgressBar = New LauncherV3.LogInRadialProgressBar()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.OrainsTheme1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextTimer
        '
        Me.TextTimer.Enabled = True
        Me.TextTimer.Interval = 10
        '
        'OrainsTheme1
        '
        Me.OrainsTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.OrainsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.OrainsTheme1.Controls.Add(Me.PictureBox2)
        Me.OrainsTheme1.Controls.Add(Me.PictureBox1)
        Me.OrainsTheme1.Controls.Add(Me.Status)
        Me.OrainsTheme1.Controls.Add(Me.StartGameBTN)
        Me.OrainsTheme1.Controls.Add(Me.MSGLABEL)
        Me.OrainsTheme1.Controls.Add(Me.MSG2BOX)
        Me.OrainsTheme1.Controls.Add(Me.LogInCheckBox1)
        Me.OrainsTheme1.Controls.Add(Me.OrainsControlBox1)
        Me.OrainsTheme1.Controls.Add(Me.Label1)
        Me.OrainsTheme1.Controls.Add(Me.LogInLogButton1)
        Me.OrainsTheme1.Controls.Add(Me.ProgressBar)
        Me.OrainsTheme1.Controls.Add(Me.WebBrowser1)
        Me.OrainsTheme1.Customization = "AKX//wAAAP8oKCj/FBQU/xYWFv8ODg7/FBQU/w=="
        Me.OrainsTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrainsTheme1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.OrainsTheme1.Image = Nothing
        Me.OrainsTheme1.Location = New System.Drawing.Point(0, 0)
        Me.OrainsTheme1.MaximumSize = New System.Drawing.Size(756, 431)
        Me.OrainsTheme1.MinimumSize = New System.Drawing.Size(756, 431)
        Me.OrainsTheme1.Movable = True
        Me.OrainsTheme1.Name = "OrainsTheme1"
        Me.OrainsTheme1.NoRounding = False
        Me.OrainsTheme1.Sizable = True
        Me.OrainsTheme1.Size = New System.Drawing.Size(756, 431)
        Me.OrainsTheme1.SmartBounds = True
        Me.OrainsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.OrainsTheme1.TabIndex = 0
        Me.OrainsTheme1.Text = "OrainsTheme1"
        Me.OrainsTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.OrainsTheme1.Transparent = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(744, 31)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(13, 29)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(13, 29)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.ForeColor = System.Drawing.Color.White
        Me.Status.Location = New System.Drawing.Point(537, 401)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(64, 15)
        Me.Status.TabIndex = 9
        Me.Status.Text = "Status.Text"
        '
        'StartGameBTN
        '
        Me.StartGameBTN.Location = New System.Drawing.Point(290, 254)
        Me.StartGameBTN.Name = "StartGameBTN"
        Me.StartGameBTN.Size = New System.Drawing.Size(172, 47)
        Me.StartGameBTN.TabIndex = 8
        Me.StartGameBTN.Text = "Launch game!"
        Me.StartGameBTN.UseVisualStyleBackColor = True
        Me.StartGameBTN.Visible = False
        '
        'MSGLABEL
        '
        Me.MSGLABEL.AutoSize = True
        Me.MSGLABEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.MSGLABEL.ForeColor = System.Drawing.Color.White
        Me.MSGLABEL.Location = New System.Drawing.Point(17, 38)
        Me.MSGLABEL.Name = "MSGLABEL"
        Me.MSGLABEL.Size = New System.Drawing.Size(10, 15)
        Me.MSGLABEL.TabIndex = 7
        Me.MSGLABEL.Text = "."
        '
        'MSG2BOX
        '
        Me.MSG2BOX.BackColor = System.Drawing.Color.Transparent
        Me.MSG2BOX.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.MSG2BOX.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.MSG2BOX.Location = New System.Drawing.Point(12, 31)
        Me.MSG2BOX.MaxLength = 32767
        Me.MSG2BOX.Multiline = False
        Me.MSG2BOX.Name = "MSG2BOX"
        Me.MSG2BOX.ReadOnly = True
        Me.MSG2BOX.Size = New System.Drawing.Size(733, 29)
        Me.MSG2BOX.Style = LauncherV3.LogInNormalTextBox.Styles.NotRounded
        Me.MSG2BOX.TabIndex = 6
        Me.MSG2BOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MSG2BOX.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MSG2BOX.UseSystemPasswordChar = False
        '
        'LogInCheckBox1
        '
        Me.LogInCheckBox1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInCheckBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInCheckBox1.Checked = True
        Me.LogInCheckBox1.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.LogInCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInCheckBox1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInCheckBox1.Location = New System.Drawing.Point(36, 391)
        Me.LogInCheckBox1.Name = "LogInCheckBox1"
        Me.LogInCheckBox1.Size = New System.Drawing.Size(110, 22)
        Me.LogInCheckBox1.TabIndex = 5
        Me.LogInCheckBox1.Text = "Updates"
        '
        'OrainsControlBox1
        '
        Me.OrainsControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OrainsControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.OrainsControlBox1.ForeColor = System.Drawing.Color.White
        Me.OrainsControlBox1.Location = New System.Drawing.Point(696, 0)
        Me.OrainsControlBox1.Name = "OrainsControlBox1"
        Me.OrainsControlBox1.Size = New System.Drawing.Size(60, 25)
        Me.OrainsControlBox1.TabIndex = 4
        Me.OrainsControlBox1.Text = "OrainsControlBox1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 374)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Client is ???"
        '
        'LogInLogButton1
        '
        Me.LogInLogButton1.ArcColour = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.LogInLogButton1.ArrowBorderColour = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.LogInLogButton1.ArrowColour = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.LogInLogButton1.BackColor = System.Drawing.Color.Transparent
        Me.LogInLogButton1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInLogButton1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.LogInLogButton1.Location = New System.Drawing.Point(173, 370)
        Me.LogInLogButton1.Name = "LogInLogButton1"
        Me.LogInLogButton1.NormalColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.LogInLogButton1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.LogInLogButton1.Size = New System.Drawing.Size(50, 50)
        Me.LogInLogButton1.TabIndex = 2
        Me.LogInLogButton1.Text = "LogInLogButton1"
        '
        'ProgressBar
        '
        Me.ProgressBar.BackColor = System.Drawing.Color.Transparent
        Me.ProgressBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ProgressBar.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ProgressBar.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ProgressBar.Location = New System.Drawing.Point(667, 342)
        Me.ProgressBar.Maximum = 100
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ProgressBar.RotationAngle = 255
        Me.ProgressBar.Size = New System.Drawing.Size(78, 78)
        Me.ProgressBar.StartingAngle = 110
        Me.ProgressBar.TabIndex = 1
        Me.ProgressBar.Text = "LogInRadialProgressBar1"
        Me.ProgressBar.Value = 0
        '
        'WebBrowser1
        '
        Me.WebBrowser1.AllowWebBrowserDrop = False
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 31)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(733, 389)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        '
        'RepzIW4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 431)
        Me.Controls.Add(Me.OrainsTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(756, 431)
        Me.MinimumSize = New System.Drawing.Size(756, 431)
        Me.Name = "RepzIW4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RepzIW4 Launcher"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.OrainsTheme1.ResumeLayout(False)
        Me.OrainsTheme1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OrainsTheme1 As LauncherV3.OrainsTheme
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents ProgressBar As LauncherV3.LogInRadialProgressBar
    Friend WithEvents LogInLogButton1 As LauncherV3.LogInLogButton
    Friend WithEvents OrainsControlBox1 As LauncherV3.OrainsControlBox
    Friend WithEvents LogInCheckBox1 As LauncherV3.LogInCheckBox
    Friend WithEvents MSG2BOX As LauncherV3.LogInNormalTextBox
    Friend WithEvents TextTimer As System.Windows.Forms.Timer
    Friend WithEvents MSGLABEL As System.Windows.Forms.Label
    Friend WithEvents StartGameBTN As System.Windows.Forms.Button
    Friend WithEvents Status As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
