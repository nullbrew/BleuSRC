Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Bleu
	Public Partial Class HelpPage
		Inherits Form

		' Token: 0x02000002 RID: 2
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		Private Async Sub wait(Interval As Integer)
			Await Task.Delay(Interval)
		End Sub

		Private Sub pictureBox1_MouseDown(sender As Object, e As MouseEventArgs)
			Me.B = New Point(e.X, e.Y)
			Me.DragForm.Start()
		End Sub

		Private Sub pictureBox1_MouseUp(sender As Object, e As MouseEventArgs)
			Me.DragForm.[Stop]()
		End Sub

		Private Async Sub DragForm_Tick(sender As Object, e As EventArgs)
			Dim A As Point = Cursor.Position
			MyBase.Location = New Point(A.X - Me.B.X, A.Y - Me.B.Y)
		End Sub

		Private Async Sub button1_Click(sender As Object, e As EventArgs)
			For i As Integer = 1 To 9
				MyBase.Opacity -= 0.1
				Dim taskAwaiter As TaskAwaiter = Task.Delay(1).GetAwaiter()
				If Not taskAwaiter.IsCompleted Then
					Await taskAwaiter
					Dim taskAwaiter2 As TaskAwaiter
					taskAwaiter = taskAwaiter2
					taskAwaiter2 = Nothing
				End If
				taskAwaiter.GetResult()
			Next
			MyBase.Opacity = 0.95
			Try
				MyBase.Close()
			Catch
			End Try
		End Sub

		Private Sub Form1_Load(sender As Object, e As EventArgs)
			Me.AnimationTimer.Start()
		End Sub

		Private Async Sub button2_Click(sender As Object, e As EventArgs)
			For i As Integer = 1 To 9
				MyBase.Opacity -= 0.1
				Dim taskAwaiter As TaskAwaiter = Task.Delay(1).GetAwaiter()
				If Not taskAwaiter.IsCompleted Then
					Await taskAwaiter
					Dim taskAwaiter2 As TaskAwaiter
					taskAwaiter = taskAwaiter2
					taskAwaiter2 = Nothing
				End If
				taskAwaiter.GetResult()
			Next
			MyBase.WindowState = FormWindowState.Minimized
			MyBase.Opacity = 0.95
		End Sub

		Private Async Sub AnimationTimer_Tick(sender As Object, e As EventArgs)
			Me.AnimationTimer.[Stop]()
			For i As Integer = 1 To 9
				MyBase.Opacity += 0.1
				Dim taskAwaiter As TaskAwaiter = Task.Delay(1).GetAwaiter()
				If Not taskAwaiter.IsCompleted Then
					Await taskAwaiter
					Dim taskAwaiter2 As TaskAwaiter
					taskAwaiter = taskAwaiter2
					taskAwaiter2 = Nothing
				End If
				taskAwaiter.GetResult()
			Next
			MyBase.Opacity = 0.95
		End Sub

		Private B As Point

		Private DeBounce As Boolean = False

		Private Register As Boolean = False
	End Class
End Namespace
