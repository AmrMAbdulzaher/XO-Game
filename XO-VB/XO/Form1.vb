Imports System.Security.Authentication.ExtendedProtection

Public Class GameWindow
    Private Sub GameWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'All Buttons Click
        For Each c As Control In FieldPanel.Controls

            If c.GetType() = GetType(Button) Then

                AddHandler c.Click, AddressOf btn_Click

            End If
        Next
    End Sub
    'Disable Buttons Function
    Sub disablebtns()
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btn6.Enabled = False
        btn7.Enabled = False
        btn8.Enabled = False
        btn9.Enabled = False
    End Sub
    'Start Button
    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        Panel1.Visible = False
        Label3.Visible = False
        btnstart.Visible = False
        btnNew.Visible = True
        Panel2.Visible = False
        FieldPanel.Visible = True
        btn1.Visible = True
        btn2.Visible = True
        btn3.Visible = True
        btn4.Visible = True
        btn5.Visible = True
        btn6.Visible = True
        btn7.Visible = True
        btn8.Visible = True
        btn9.Visible = True
        lblturn.Visible = True
        lblscore.Visible = True
        panelscore.Visible = True
        lblwin.Visible = False
        lblxscore.Visible = True
        lbloscore.Visible = True
        lblocount.Visible = True
        lblxcount.Visible = True
        lblxcount.Text = 0
        lblocount.Text = 0
        resetpanel.Visible = True
        btnreset.Visible = True
        lblwlc.Visible = False
        wlcpanel.Visible = False
        panelturn.Visible = True

    End Sub


    Dim XorO As Integer = 0
    Private Sub btn_Click(sender As Object, e As EventArgs)

        Dim btn As Button = sender

        'Turns
        If btn.Text.Equals("") Then

            If XorO Mod 2 = 0 Then

                btn.Text = "X"
                btn.ForeColor = Color.Red
                getTheWinner()
                lblturn.Text = "Player O Turn"

            Else

                btn.Text = "O"
                btn.ForeColor = Color.Green
                getTheWinner()
                lblturn.Text = "Player X Turn"

            End If

            XorO += 1

        End If

    End Sub

    Dim winx As Boolean = False
    Dim wino As Boolean = False
    Dim countx As Integer
    Dim counto As Integer

    'Detecting the Winner
    Private Sub getTheWinner()
        'X win
        If btn1.Text = ("X") AndAlso btn1.Text = (btn2.Text) AndAlso btn1.Text = (btn3.Text) Then
            winx = True
            winEffect(btn1, btn2, btn3)
            disablebtns()
            countx += 1
            lblxcount.Text = countx
        End If

        If btn4.Text = ("X") AndAlso btn4.Text = (btn5.Text) AndAlso btn4.Text = (btn6.Text) Then
            winx = True
            winEffect(btn4, btn5, btn6)
            disablebtns()

            countx += 1
            lblxcount.Text = countx


        End If

        If btn7.Text = ("X") AndAlso btn7.Text = (btn8.Text) AndAlso btn7.Text = (btn9.Text) Then
            winx = True
            winEffect(btn7, btn8, btn9)
            disablebtns()

            countx += 1
            lblxcount.Text = countx


        End If

        If btn1.Text = ("X") AndAlso btn1.Text = (btn4.Text) AndAlso btn1.Text = (btn7.Text) Then
            winx = True
            winEffect(btn1, btn4, btn7)
            disablebtns()

            countx += 1
            lblxcount.Text = countx

        End If

        If btn2.Text = ("X") AndAlso btn2.Text = (btn5.Text) AndAlso btn2.Text = (btn8.Text) Then
            winx = True
            winEffect(btn2, btn5, btn8)
            disablebtns()

            countx += 1
            lblxcount.Text = countx

        End If

        If btn3.Text = ("X") AndAlso btn3.Text = (btn6.Text) AndAlso btn3.Text = (btn9.Text) Then
            winx = True
            winEffect(btn3, btn6, btn9)
            disablebtns()

            countx += 1
            lblxcount.Text = countx

        End If

        If btn1.Text = ("X") AndAlso btn1.Text = (btn5.Text) AndAlso btn1.Text = (btn9.Text) Then
            winx = True
            winEffect(btn1, btn5, btn9)
            disablebtns()

            countx += 1
            lblxcount.Text = countx

        End If

        If btn3.Text = ("X") AndAlso btn3.Text = (btn5.Text) AndAlso btn3.Text = (btn7.Text) Then
            winx = True
            winEffect(btn3, btn5, btn7)
            disablebtns()

            countx += 1
            lblxcount.Text = countx

        End If
        'O Win
        If btn1.Text = ("O") AndAlso btn1.Text = (btn2.Text) AndAlso btn1.Text = (btn3.Text) Then
            wino = True
            winEffect(btn1, btn2, btn3)
            disablebtns()

            counto += 1
            lblocount.Text = counto

        End If

        If btn4.Text = ("O") AndAlso btn4.Text = (btn5.Text) AndAlso btn4.Text = (btn6.Text) Then
            wino = True
            winEffect(btn4, btn5, btn6)
            disablebtns()

            counto += 1
            lblocount.Text = counto


        End If

        If btn7.Text = ("O") AndAlso btn7.Text = (btn8.Text) AndAlso btn7.Text = (btn9.Text) Then
            wino = True
            winEffect(btn7, btn8, btn9)
            disablebtns()

            counto += 1
            lblocount.Text = counto

        End If

        If btn1.Text = ("O") AndAlso btn1.Text = (btn4.Text) AndAlso btn1.Text = (btn7.Text) Then
            wino = True
            winEffect(btn1, btn4, btn7)
            disablebtns()

            counto += 1
            lblocount.Text = counto

        End If

        If btn2.Text = ("O") AndAlso btn2.Text = (btn5.Text) AndAlso btn2.Text = (btn8.Text) Then
            wino = True
            winEffect(btn2, btn5, btn8)
            disablebtns()

            counto += 1
            lblocount.Text = counto

        End If

        If btn3.Text = ("O") AndAlso btn3.Text = (btn6.Text) AndAlso btn3.Text = (btn9.Text) Then
            wino = True
            winEffect(btn3, btn6, btn9)

            counto += 1
            lblocount.Text = counto

        End If

        If btn1.Text = ("O") AndAlso btn1.Text = (btn5.Text) AndAlso btn1.Text = (btn9.Text) Then
            wino = True
            winEffect(btn1, btn5, btn9)
            disablebtns()

            counto += 1
            lblocount.Text = counto

        End If

        If btn3.Text = ("O") AndAlso btn3.Text = (btn5.Text) AndAlso btn3.Text = (btn7.Text) Then
            wino = True
            winEffect(btn3, btn5, btn7)
            disablebtns()

            counto += 1
            lblocount.Text = counto

        End If

        'Draw
        If allbuttonsTextLength() = 9 AndAlso winx = False AndAlso wino = False Then
            lblturn.Visible = False
            lblwin.Visible = True
            lblwin.Text = "DRAW!"
            disablebtns()
        End If

    End Sub

    'Buttons Text Length , Function for Draw 
    Function allbuttonsTextLength() As Integer

        Dim btnsTxtLength As Integer = 0

        For Each c As Control In FieldPanel.Controls

            If c.GetType() = GetType(Button) Then

                btnsTxtLength += c.Text.Length

            End If

        Next

        Return btnsTxtLength

    End Function
    'Colorful Win Effect for X and O 
    Private Sub winEffect(ByVal b1 As Button, ByVal b2 As Button, ByVal b3 As Button)
        If winx = True AndAlso wino = False Then
            b1.BackColor = Color.Red
            b2.BackColor = Color.Red
            b3.BackColor = Color.Red
            lblwin.Visible = True
            lblwin.Text = "Player X Won!"

        ElseIf winx = False AndAlso wino = True Then
            b1.BackColor = Color.Green
            b2.BackColor = Color.Green
            b3.BackColor = Color.Green
            lblwin.Visible = True
            lblwin.Text = "Player O Won!"
        End If

        lblturn.Visible = False
    End Sub

    'New Game Button 
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        XorO = 0
        winx = False
        wino = False
        For Each c As Control In FieldPanel.Controls

            If c.GetType() = GetType(Button) Then

                c.BackColor = Color.WhiteSmoke
                c.Text = ""
                btn1.Enabled = True
                btn2.Enabled = True
                btn3.Enabled = True
                btn4.Enabled = True
                btn5.Enabled = True
                btn6.Enabled = True
                btn7.Enabled = True
                btn8.Enabled = True
                btn9.Enabled = True
                lblscore.Visible = True
                panelscore.Visible = True
                lblturn.Visible = True
                lblturn.Text = "Player X Turn"
                lblxcount.Text = countx
                lblocount.Text = counto
                lblwin.Visible = False
            End If

        Next

    End Sub


    'Reset Button
    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        XorO = 0
        winx = False
        wino = False
        For Each c As Control In FieldPanel.Controls

            If c.GetType() = GetType(Button) Then

                c.BackColor = Color.WhiteSmoke
                c.Text = ""
                btn1.Enabled = True
                btn2.Enabled = True
                btn3.Enabled = True
                btn4.Enabled = True
                btn5.Enabled = True
                btn6.Enabled = True
                btn7.Enabled = True
                btn8.Enabled = True
                btn9.Enabled = True
                lblturn.Visible = True
                lblscore.Visible = True
                panelscore.Visible = True
                lblturn.Text = "Player X Turn"
                lblwin.Visible = False
                countx = 0
                counto = 0
                lblxcount.Text = countx
                lblocount.Text = counto

            End If

        Next
    End Sub

End Class


