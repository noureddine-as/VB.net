Public Class Form1

    '  MP mp)

    Dim IsClicked As Boolean = False

    Enum HandType
        Hours
        Minutes
        Secondes
    End Enum

    Sub DrawHands()
        Dim G As Graphics = Graphics.FromHwnd(Me.main_panel.Handle)

        G.TranslateTransform(Me.main_panel.Width / 2, Me.main_panel.Height / 2)
        Dim O_Point As New Point(0, 0)

        G.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

        G.DrawImage(My.Resources.horloge, -110, -110, 220, 220)

        DrawHand(G, HandType.Hours)
        DrawHand(G, HandType.Minutes)
        DrawHand(G, HandType.Secondes)

        Dim O_rect As New Rectangle(-3, -3, 6, 6)
        G.FillEllipse(Brushes.Black, O_rect)

        G.Dispose()
    End Sub

    Sub DrawHand(ByVal G As Graphics, ByVal HType As HandType)

        Dim x As Integer = Convert.ToInt16(GetRay(HType) * Math.Cos(GetAlpha(HType)))

        Dim y As Integer = Convert.ToInt16(GetRay(HType) * Math.Sin(GetAlpha(HType)))

        Dim M_Point As New Point(x, y)
        Dim O_Point As New Point(0, 0)

        'Dim X_ As Double = 0
        'Dim Y_ As Double = 0

        'If x >= 0 And y >= 0 Then
        '    X_ = -10 * Math.Sin(GetAlpha(HType))
        '    Y_ = -10 * Math.Cos(GetAlpha(HType))

        'ElseIf x >= 0 And y <= 0 Then
        '    X_ = -10 * Math.Cos(Math.PI - GetAlpha(HType))
        '    Y_ = 10 * Math.Sin(Math.PI - GetAlpha(HType))

        'ElseIf x < 0 And y > 0 Then
        '    X_ = 10 * Math.Cos(Math.PI + GetAlpha(HType))
        '    Y_ = -10 * Math.Sin(Math.PI + GetAlpha(HType))

        'ElseIf x < 0 And y < 0 Then
        '    X_ = 10 * Math.Cos(Math.PI + GetAlpha(HType))
        '    Y_ = 10 * Math.Sin(Math.PI + GetAlpha(HType))

        'End If

        'Dim Start_point As New Point(X_, Y_)

        G.DrawLine(GetPen(HType), O_Point, M_Point)

    End Sub

    Function GetPen(ByVal HTyPe As HandType) As Pen

        Dim Hpen As New Pen(Color.AliceBlue, 0)

        If HTyPe = HandType.Hours Then

            Hpen.Color = Color.Black
            Hpen.EndCap = Drawing2D.LineCap.Round
            Hpen.StartCap = Drawing2D.LineCap.Round
            Hpen.Width = 6

        ElseIf HTyPe = HandType.Minutes Then

            Hpen.Color = Color.SlateGray
            Hpen.EndCap = Drawing2D.LineCap.Triangle
            Hpen.StartCap = Drawing2D.LineCap.Round
            Hpen.Width = 3.5

        ElseIf HTyPe = HandType.Secondes Then

            Hpen.Color = Color.DeepSkyBlue
            Hpen.EndCap = Drawing2D.LineCap.Square
            Hpen.StartCap = Drawing2D.LineCap.Round
            Hpen.Width = 2.5

        End If

        Return Hpen
    End Function

    Function GetAlpha(ByVal Htype As HandType) As Double
        Dim Alpha As Double = Nothing
        Dim Alpha0 As Double = Nothing
        Dim NowDate As Date = Now
        'Dim NowDate As Date = CDate(MaskedTextBox1.Text)

        If Htype = HandType.Hours Then
            Dim h As Short = NowDate.Hour
            Select Case h
                Case h = 0
                    h = 12
                Case h > 12
                    h -= 12
            End Select
            Alpha0 = h * 30

        ElseIf Htype = HandType.Minutes Then
            Dim m As Short = NowDate.Minute

            Alpha0 = m * 6

        ElseIf Htype = HandType.Secondes Then
            Dim s As Short = NowDate.Second

            Alpha0 = s * 6

        End If

        Alpha = (((Alpha0 - 90)) * Math.PI) / 180

        Return Alpha
    End Function

    Function GetRay(ByVal HType As HandType) As Integer

        Dim r As Short = Nothing

        Select Case HType

            Case HandType.Hours

                r = 55

            Case HandType.Minutes

                r = 70

            Case HandType.Secondes

                r = 85

        End Select

        Return r
    End Function

    Private Sub Date_Tm_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Date_Tm.Tick
        DrawHands()
    End Sub

    Private Sub TM_position_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TM_position.Tick
        If IsClicked = True Then
            Me.Left = MousePosition.X - Me.Width / 2
            Me.Top = MousePosition.Y - Me.Height / 2
        End If
    End Sub

  
    Private Sub QuitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub


    Private Sub main_panel_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles main_panel.DoubleClick
        If IsClicked = False Then
            IsClicked = True
        Else
            IsClicked = False
        End If
    End Sub

   
End Class
