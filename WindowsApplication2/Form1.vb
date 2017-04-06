Public Class Form1
    Dim GameWin As Boolean
    Dim ResetGame As Boolean
    Dim GameOverTick As Integer = 1

    Private Sub Form1_keydown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.S
                If Man.Height + Man.Location.Y + 60 < Me.ClientRectangle.Height And ResetGame = False Then
                    Man.Top += 60
                End If
            Case Keys.W
                If Man.Height + Man.Location.Y + 60 > Me.Man.Height And ResetGame = False Then
                    Man.Top -= 60
                End If
            Case Keys.A
                If (Man.Location.X + Man.Width) - (60 + Man.Width) > 0 And ResetGame = False Then
                    Man.Left -= 60
                End If
            Case Keys.D
                If Man.Width + Man.Location.X + 60 < Me.ClientRectangle.Width And ResetGame = False Then
                    Man.Left += 60
                End If
            Case Keys.Enter
                If ResetGame = True Then
                    ResetGame = False
                    GameWin = False
                    Man.Location = New Point(351, 456)
                    TrafficTimer.Enabled = True
                    Label1.Visible = False
                    Label2.Visible = False
                    GameOverTimer.Enabled = False
                    GameOverTick = 1
                    Car1.Location = New Point(-48, 51)
                    Car2.Location = New Point(-89, 151)
                    Car3.Location = New Point(729, 276)
                    Van.Location = New Point(729, 400)
                End If
        End Select

    End Sub

    Private Sub TrafficTimer_Tick(sender As Object, e As EventArgs) Handles TrafficTimer.Tick
        If Car1.Location.X >= 729 Then
            Car1.Location = New Point(-48, 51)
        Else
            Car1.Left += 20
        End If
        If Car2.Location.X >= 729 Then
            Car2.Location = New Point(-89, 151)
        Else
            Car2.Left += 15
        End If
        If Car3.Location.X <= -108 Then
            Car3.Location = New Point(729, 276)
        Else
            Car3.Left -= 15
        End If
        If Van.Location.X <= -108 Then
            Van.Location = New Point(729, 400)
        Else
            Van.Left -= 10
        End If
        BtGo.Enabled = False
        btStop.Enabled = True
        collison()
    End Sub
    Public Sub collison()
        If Man.Bounds.IntersectsWith(Car1.Bounds) Or Man.Bounds.IntersectsWith(Car2.Bounds) Or Man.Bounds.IntersectsWith(Car3.Bounds) Or Man.Bounds.IntersectsWith(Van.Bounds) Then
            gameover()
        End If
        If Man.Bounds.IntersectsWith(PictureBox3.Bounds) Then
            GameWin = False
            GameOver()
            BtGo.Enabled = False
            btStop.Enabled = False
        End If
    End Sub

    Private Sub GameOverTimer_Tick(sender As Object, e As EventArgs) Handles GameOverTimer.Tick
        Select Case GameOverTick
            Case 1
                Label1.ForeColor = Color.Crimson
                Label2.ForeColor = Color.Crimson
                GameOverTick += 1
            Case 2
                Label1.ForeColor = Color.Blue
                Label1.ForeColor = Color.Blue
                GameOverTick = 1
        End Select
        BtGo.Enabled = False
        btStop.Enabled = False

    End Sub
    Public Sub GameOver()
        If GameWin = False Then
            Label1.Text = "Game Over"
            Label2.Text = "Hit Enter To Play Again"
            Label1.Visible = True
            Label2.Visible = True
            ResetGame = True
            TrafficTimer.Enabled = False
            GameOverTimer.Enabled = True
            BtGo.Enabled = False
            btStop.Enabled = False
        ElseIf GameWin = True Then
            Label1.Text = "Your Alive"
            Label2.Text = "Hit Enter To Play Again"
            Label1.Visible = True
            Label2.Visible = True
            ResetGame = True
            TrafficTimer.Enabled = False
            GameOverTimer.Enabled = True
            BtGo.Enabled = False
            btStop.Enabled = False


        End If
    End Sub

    Private Sub btStop_Click(sender As Object, e As EventArgs) Handles btStop.Click
        TrafficTimer.Enabled = False
        GameOverTimer.Enabled = False
        BtGo.Enabled = True
        btStop.Enabled = False


    End Sub

    Private Sub BtGo_Click(sender As Object, e As EventArgs) Handles BtGo.Click
        TrafficTimer.Enabled = True
        GameOverTimer.Enabled = False
        BtGo.Enabled = False
        btStop.Enabled = True





    End Sub

    
End Class
