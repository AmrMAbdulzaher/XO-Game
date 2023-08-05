<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GameWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameWindow))
        Me.GameName = New System.Windows.Forms.Panel()
        Me.resetpanel = New System.Windows.Forms.Panel()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.FieldPanel = New System.Windows.Forms.Panel()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.wlcpanel = New System.Windows.Forms.Panel()
        Me.lblwlc = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RestartPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnstart = New System.Windows.Forms.Button()
        Me.panelturn = New System.Windows.Forms.Panel()
        Me.lblwin = New System.Windows.Forms.Label()
        Me.lblturn = New System.Windows.Forms.Label()
        Me.panelscore = New System.Windows.Forms.Panel()
        Me.lblocount = New System.Windows.Forms.Label()
        Me.lblxcount = New System.Windows.Forms.Label()
        Me.lbloscore = New System.Windows.Forms.Label()
        Me.lblxscore = New System.Windows.Forms.Label()
        Me.lblscore = New System.Windows.Forms.Label()
        Me.GameName.SuspendLayout()
        Me.resetpanel.SuspendLayout()
        Me.FieldPanel.SuspendLayout()
        Me.wlcpanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.RestartPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panelturn.SuspendLayout()
        Me.panelscore.SuspendLayout()
        Me.SuspendLayout()
        '
        'GameName
        '
        Me.GameName.BackColor = System.Drawing.Color.Teal
        Me.GameName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GameName.Controls.Add(Me.resetpanel)
        Me.GameName.Controls.Add(Me.Label2)
        Me.GameName.Controls.Add(Me.Label1)
        Me.GameName.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameName.Location = New System.Drawing.Point(-9, 0)
        Me.GameName.Name = "GameName"
        Me.GameName.Size = New System.Drawing.Size(639, 72)
        Me.GameName.TabIndex = 0
        '
        'resetpanel
        '
        Me.resetpanel.BackColor = System.Drawing.Color.DarkTurquoise
        Me.resetpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.resetpanel.Controls.Add(Me.btnreset)
        Me.resetpanel.Location = New System.Drawing.Point(547, 16)
        Me.resetpanel.Name = "resetpanel"
        Me.resetpanel.Size = New System.Drawing.Size(71, 41)
        Me.resetpanel.TabIndex = 5
        Me.resetpanel.Visible = False
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreset.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.ForeColor = System.Drawing.Color.Black
        Me.btnreset.Location = New System.Drawing.Point(1, 1)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(66, 37)
        Me.btnreset.TabIndex = 2
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = False
        Me.btnreset.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Bauhaus 93", 10.2!)
        Me.Label2.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label2.Location = New System.Drawing.Point(252, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(221, 62)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "By Amr Mohamed Abdelzaher 201909957"
        '
        'Label1
        '
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Bauhaus 93", 22.2!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label1.Location = New System.Drawing.Point(20, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 43)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "XO Game v1.0"
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(2, 3)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(155, 59)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "Restart a Game"
        Me.btnNew.UseVisualStyleBackColor = True
        Me.btnNew.Visible = False
        '
        'FieldPanel
        '
        Me.FieldPanel.BackColor = System.Drawing.Color.Black
        Me.FieldPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FieldPanel.Controls.Add(Me.btn9)
        Me.FieldPanel.Controls.Add(Me.btn1)
        Me.FieldPanel.Controls.Add(Me.btn3)
        Me.FieldPanel.Controls.Add(Me.btn8)
        Me.FieldPanel.Controls.Add(Me.btn4)
        Me.FieldPanel.Controls.Add(Me.btn5)
        Me.FieldPanel.Controls.Add(Me.btn7)
        Me.FieldPanel.Controls.Add(Me.btn2)
        Me.FieldPanel.Controls.Add(Me.btn6)
        Me.FieldPanel.Location = New System.Drawing.Point(6, 77)
        Me.FieldPanel.Name = "FieldPanel"
        Me.FieldPanel.Size = New System.Drawing.Size(389, 291)
        Me.FieldPanel.TabIndex = 1
        Me.FieldPanel.Visible = False
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.SystemColors.Control
        Me.btn9.Font = New System.Drawing.Font("Tahoma", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(265, 195)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(133, 99)
        Me.btn9.TabIndex = 11
        Me.btn9.UseVisualStyleBackColor = False
        Me.btn9.Visible = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn1.Font = New System.Drawing.Font("Tahoma", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(-3, -4)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(133, 99)
        Me.btn1.TabIndex = 3
        Me.btn1.UseVisualStyleBackColor = False
        Me.btn1.Visible = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.SystemColors.Control
        Me.btn3.Font = New System.Drawing.Font("Tahoma", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(265, -4)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(133, 99)
        Me.btn3.TabIndex = 5
        Me.btn3.UseVisualStyleBackColor = False
        Me.btn3.Visible = False
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.SystemColors.Control
        Me.btn8.Font = New System.Drawing.Font("Tahoma", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(131, 195)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(133, 99)
        Me.btn8.TabIndex = 10
        Me.btn8.UseVisualStyleBackColor = False
        Me.btn8.Visible = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.SystemColors.Control
        Me.btn4.Font = New System.Drawing.Font("Tahoma", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(-3, 96)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(133, 99)
        Me.btn4.TabIndex = 6
        Me.btn4.UseVisualStyleBackColor = False
        Me.btn4.Visible = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.SystemColors.Control
        Me.btn5.Font = New System.Drawing.Font("Tahoma", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(131, 96)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(133, 99)
        Me.btn5.TabIndex = 7
        Me.btn5.UseVisualStyleBackColor = False
        Me.btn5.Visible = False
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.SystemColors.Control
        Me.btn7.Font = New System.Drawing.Font("Tahoma", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(-3, 195)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(133, 99)
        Me.btn7.TabIndex = 9
        Me.btn7.UseVisualStyleBackColor = False
        Me.btn7.Visible = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.SystemColors.Control
        Me.btn2.Font = New System.Drawing.Font("Tahoma", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(131, -4)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(133, 99)
        Me.btn2.TabIndex = 4
        Me.btn2.UseVisualStyleBackColor = False
        Me.btn2.Visible = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.SystemColors.Control
        Me.btn6.Font = New System.Drawing.Font("Tahoma", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(265, 96)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(133, 99)
        Me.btn6.TabIndex = 8
        Me.btn6.UseVisualStyleBackColor = False
        Me.btn6.Visible = False
        '
        'wlcpanel
        '
        Me.wlcpanel.BackColor = System.Drawing.Color.Teal
        Me.wlcpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wlcpanel.Controls.Add(Me.lblwlc)
        Me.wlcpanel.Location = New System.Drawing.Point(116, 92)
        Me.wlcpanel.Name = "wlcpanel"
        Me.wlcpanel.Size = New System.Drawing.Size(202, 48)
        Me.wlcpanel.TabIndex = 6
        '
        'lblwlc
        '
        Me.lblwlc.Enabled = False
        Me.lblwlc.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwlc.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.lblwlc.Location = New System.Drawing.Point(3, 3)
        Me.lblwlc.Name = "lblwlc"
        Me.lblwlc.Size = New System.Drawing.Size(194, 43)
        Me.lblwlc.TabIndex = 4
        Me.lblwlc.Text = "Welcome"
        Me.lblwlc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(88, 178)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(257, 99)
        Me.Panel1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Bauhaus 93", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(19, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 43)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Press ""Start"" to Play"
        '
        'RestartPanel
        '
        Me.RestartPanel.BackColor = System.Drawing.Color.Teal
        Me.RestartPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RestartPanel.Controls.Add(Me.Panel2)
        Me.RestartPanel.Controls.Add(Me.btnNew)
        Me.RestartPanel.Location = New System.Drawing.Point(432, 297)
        Me.RestartPanel.Name = "RestartPanel"
        Me.RestartPanel.Size = New System.Drawing.Size(161, 67)
        Me.RestartPanel.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnstart)
        Me.Panel2.Location = New System.Drawing.Point(-1, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(161, 67)
        Me.Panel2.TabIndex = 3
        '
        'btnstart
        '
        Me.btnstart.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstart.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstart.ForeColor = System.Drawing.Color.Black
        Me.btnstart.Location = New System.Drawing.Point(2, 3)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(155, 59)
        Me.btnstart.TabIndex = 1
        Me.btnstart.Text = "Start"
        Me.btnstart.UseVisualStyleBackColor = False
        '
        'panelturn
        '
        Me.panelturn.BackColor = System.Drawing.Color.Teal
        Me.panelturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelturn.Controls.Add(Me.lblwin)
        Me.panelturn.Controls.Add(Me.lblturn)
        Me.panelturn.Location = New System.Drawing.Point(407, 78)
        Me.panelturn.Name = "panelturn"
        Me.panelturn.Size = New System.Drawing.Size(202, 48)
        Me.panelturn.TabIndex = 4
        Me.panelturn.Visible = False
        '
        'lblwin
        '
        Me.lblwin.Enabled = False
        Me.lblwin.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwin.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.lblwin.Location = New System.Drawing.Point(0, 2)
        Me.lblwin.Name = "lblwin"
        Me.lblwin.Size = New System.Drawing.Size(206, 43)
        Me.lblwin.TabIndex = 5
        Me.lblwin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblturn
        '
        Me.lblturn.Enabled = False
        Me.lblturn.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblturn.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.lblturn.Location = New System.Drawing.Point(-1, 2)
        Me.lblturn.Name = "lblturn"
        Me.lblturn.Size = New System.Drawing.Size(203, 43)
        Me.lblturn.TabIndex = 4
        Me.lblturn.Text = "Player X Turn"
        Me.lblturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblturn.Visible = False
        '
        'panelscore
        '
        Me.panelscore.BackColor = System.Drawing.Color.Teal
        Me.panelscore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelscore.Controls.Add(Me.lblocount)
        Me.panelscore.Controls.Add(Me.lblxcount)
        Me.panelscore.Controls.Add(Me.lbloscore)
        Me.panelscore.Controls.Add(Me.lblxscore)
        Me.panelscore.Controls.Add(Me.lblscore)
        Me.panelscore.Location = New System.Drawing.Point(407, 132)
        Me.panelscore.Name = "panelscore"
        Me.panelscore.Size = New System.Drawing.Size(202, 146)
        Me.panelscore.TabIndex = 5
        Me.panelscore.Visible = False
        '
        'lblocount
        '
        Me.lblocount.Enabled = False
        Me.lblocount.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblocount.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.lblocount.Location = New System.Drawing.Point(135, 84)
        Me.lblocount.Name = "lblocount"
        Me.lblocount.Size = New System.Drawing.Size(38, 53)
        Me.lblocount.TabIndex = 6
        Me.lblocount.Text = "0"
        Me.lblocount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblocount.Visible = False
        '
        'lblxcount
        '
        Me.lblxcount.Enabled = False
        Me.lblxcount.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblxcount.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.lblxcount.Location = New System.Drawing.Point(135, 41)
        Me.lblxcount.Name = "lblxcount"
        Me.lblxcount.Size = New System.Drawing.Size(38, 53)
        Me.lblxcount.TabIndex = 5
        Me.lblxcount.Text = "0"
        Me.lblxcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblxcount.Visible = False
        '
        'lbloscore
        '
        Me.lbloscore.Enabled = False
        Me.lbloscore.Font = New System.Drawing.Font("Bauhaus 93", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloscore.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.lbloscore.Location = New System.Drawing.Point(0, 91)
        Me.lbloscore.Name = "lbloscore"
        Me.lbloscore.Size = New System.Drawing.Size(113, 43)
        Me.lbloscore.TabIndex = 5
        Me.lbloscore.Text = "Player O:"
        Me.lbloscore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbloscore.Visible = False
        '
        'lblxscore
        '
        Me.lblxscore.Enabled = False
        Me.lblxscore.Font = New System.Drawing.Font("Bauhaus 93", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblxscore.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.lblxscore.Location = New System.Drawing.Point(1, 48)
        Me.lblxscore.Name = "lblxscore"
        Me.lblxscore.Size = New System.Drawing.Size(118, 43)
        Me.lblxscore.TabIndex = 4
        Me.lblxscore.Text = "Player X:"
        Me.lblxscore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblxscore.Visible = False
        '
        'lblscore
        '
        Me.lblscore.Enabled = False
        Me.lblscore.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscore.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.lblscore.Location = New System.Drawing.Point(1, 3)
        Me.lblscore.Name = "lblscore"
        Me.lblscore.Size = New System.Drawing.Size(196, 43)
        Me.lblscore.TabIndex = 3
        Me.lblscore.Text = "Scoreboard"
        Me.lblscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblscore.Visible = False
        '
        'GameWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(621, 376)
        Me.Controls.Add(Me.wlcpanel)
        Me.Controls.Add(Me.panelscore)
        Me.Controls.Add(Me.panelturn)
        Me.Controls.Add(Me.RestartPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FieldPanel)
        Me.Controls.Add(Me.GameName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(639, 423)
        Me.MinimumSize = New System.Drawing.Size(639, 423)
        Me.Name = "GameWindow"
        Me.Text = "XO Game-By Amr 201909957"
        Me.GameName.ResumeLayout(False)
        Me.resetpanel.ResumeLayout(False)
        Me.FieldPanel.ResumeLayout(False)
        Me.wlcpanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.RestartPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.panelturn.ResumeLayout(False)
        Me.panelscore.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GameName As Panel
    Friend WithEvents btnNew As Button
    Friend WithEvents FieldPanel As Panel
    Friend WithEvents btn1 As Button
    Friend WithEvents RestartPanel As Panel
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnstart As Button
    Friend WithEvents panelturn As Panel
    Friend WithEvents lblturn As Label
    Friend WithEvents panelscore As Panel
    Friend WithEvents lbloscore As Label
    Friend WithEvents lblxscore As Label
    Friend WithEvents lblscore As Label
    Friend WithEvents lblocount As Label
    Friend WithEvents lblxcount As Label
    Friend WithEvents lblwin As Label
    Friend WithEvents btnreset As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents resetpanel As Panel
    Friend WithEvents wlcpanel As Panel
    Friend WithEvents lblwlc As Label
End Class
