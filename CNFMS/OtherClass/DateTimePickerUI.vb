Imports System.Drawing.Drawing2D

Public Class DateTimePickerUI

    Inherits DateTimePicker
    Private fillColors As Color = Color.LightSeaGreen
    Private textColors As Color = Color.White
    Private borderColors As Color = Color.Gray
    Private borderSizes As Integer = 1
    Private dropDown As Boolean = True
    Private CalenderImg As Image = My.Resources.calendarWhite
    Private iconButton As RectangleF
    Private Const iconWidth As Integer = 35
    Private Const arrowWidth As Integer = 20

    Public Property FillColor As Color
        Get
            Return fillColors
        End Get
        Set(ByVal value As Color)
            fillColors = value

            If fillColors.GetBrightness() >= 0.6F Then
                CalenderImg = My.Resources.calendarDark
            Else
                CalenderImg = My.Resources.calendarWhite
            End If

            Me.Invalidate()
        End Set
    End Property


    Public Property TextColor As Color
        Get
            Return textColors
        End Get
        Set(ByVal value As Color)
            textColors = value
            Me.Invalidate()
        End Set
    End Property


    Public Property BorderColor As Color
        Get
            Return borderColors
        End Get
        Set(ByVal value As Color)
            borderColors = value
            Me.Invalidate()
        End Set
    End Property


    Public Property BorderSize As Integer
        Get
            Return borderSizes
        End Get
        Set(ByVal value As Integer)
            borderSizes = value
            Me.Invalidate()
        End Set
    End Property

    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.MinimumSize = New Size(0, 45)
        Me.Font = New Font(Me.Font.Name, 9.5F)
    End Sub

    Protected Overrides Sub OnDropDown(ByVal eventargs As EventArgs)
        MyBase.OnDropDown(eventargs)
        dropDown = True
    End Sub

    Protected Overrides Sub OnCloseUp(ByVal eventargs As EventArgs)
        MyBase.OnCloseUp(eventargs)
        dropDown = False
    End Sub

    Protected Overrides Sub OnKeyPress(ByVal e As KeyPressEventArgs)
        MyBase.OnKeyPress(e)
        e.Handled = True
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Using graphics As Graphics = Me.CreateGraphics()

            Using pen As Pen = New Pen(BorderColor, BorderSize)
                Using fillBrush As SolidBrush = New SolidBrush(FillColor)
                    Using textBruh As SolidBrush = New SolidBrush(TextColor)
                        Using iconBrush As SolidBrush = New SolidBrush(Color.FromArgb(50, 64, 64, 64))
                            Using format As StringFormat = New StringFormat()
                                Dim dtpArea As RectangleF = New RectangleF(0, 0, Me.Width - 0.5F, Me.Height - 0.5F)
                                Dim iconArea As RectangleF = New RectangleF(dtpArea.Width - iconWidth, 0, iconWidth, dtpArea.Height)
                                pen.Alignment = PenAlignment.Inset
                                format.LineAlignment = StringAlignment.Center
                                graphics.FillRectangle(fillBrush, dtpArea)
                                graphics.DrawString(" " & Me.Text, Me.Font, textBruh, dtpArea, format)
                                If dropDown = True Then graphics.FillRectangle(iconBrush, iconArea)
                                If BorderSize >= 1 Then graphics.DrawRectangle(pen, dtpArea.X, dtpArea.Y, dtpArea.Width, dtpArea.Height)
                                graphics.DrawImage(CalenderImg, Me.Width - CalenderImg.Width - 9, CInt((Me.Height - CalenderImg.Height) / 2))
                            End Using
                        End Using
                    End Using
                End Using
            End Using
        End Using
    End Sub
    Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
        MyBase.OnHandleCreated(e)
        Dim iconWidth As Integer = GetIconWidth()
        iconButton = New RectangleF(Me.Width - iconWidth, 0, iconWidth, Me.Height)
    End Sub
    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
        MyBase.OnMouseMove(e)

        If iconButton.Contains(e.Location) Then
            Me.Cursor = Cursors.Hand
        Else
            Me.Cursor = Cursors.[Default]
        End If
    End Sub
    Private Function GetIconWidth() As Integer
        Dim textwidth As Integer = TextRenderer.MeasureText(Me.Text, Me.Font).Width

        If textwidth <= Me.Width - (iconWidth + 20) Then
            Return iconWidth
        Else
            Return arrowWidth
        End If
    End Function
End Class
