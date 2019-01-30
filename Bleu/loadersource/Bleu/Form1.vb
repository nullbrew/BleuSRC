Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Bleu.Properties

Namespace Bleu
	Public Partial Class Form1
		Inherits Form

		' Token: 0x02000003 RID: 3
		Public Sub New()
			Me.InitializeComponent()
			Me.button3.Controls.Add(Me.pictureBox3)
			Me.pictureBox3.Location = New Point(5, 22)
			Me.button4.Controls.Add(Me.pictureBox4)
			Me.pictureBox4.Location = New Point(5, 22)
			Me.button5.Controls.Add(Me.pictureBox5)
			Me.pictureBox5.Location = New Point(5, 22)
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
			If Path.GetFileNameWithoutExtension(Application.ExecutablePath) = "BleuTMP" Then
				Try
					New WebClient().DownloadFile(New Uri("https://bleu.cloris.co/Release/Bleu.exe"), Directory.GetCurrentDirectory() + "/Bleu.exe")
				Catch
				End Try
				Process.Start(Directory.GetCurrentDirectory() + "/Bleu.exe")
				MyBase.Close()
			End If
			Try
				Me.label1.Text = vbLf + New WebClient().DownloadString("http://bleu.cloris.co/Message.txt")
			Catch
			End Try
			Try
				If Me.Update <> New WebClient().DownloadString("http://bleu.cloris.co/UpdateLog.txt") Then
					Me.button3.Text = "     Update Bleu"
					Me.DoUpdate = True
				End If
			Catch
			End Try
			Try
				If Not Directory.Exists("C:/Bleu/") Then
					Directory.CreateDirectory("C:/Bleu")
					Directory.CreateDirectory("C:/Bleu/AutoExecute")
					File.Create("C:/Bleu/Auth.txt").Close()
					File.Create("C:/Bleu/INPUT").Close()
					File.Create("C:/Bleu/OUTPUT").Close()
				End If
			Catch
			End Try
			Try
				Me.KeyBox.Text = File.ReadAllText("C:/Bleu/Auth.txt")
			Catch
			End Try
			Me.panel1.Location = New Point(0, Me.panel1.Location.Y)
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

		Private Async Sub button4_Click(sender As Object, e As EventArgs)
			If Not Me.DeBounce Then
				Me.DeBounce = True
				For i As Integer = 1 To 10
					If Not Me.Register Then
						Me.panel1.Location = New Point(Me.panel1.Location.X - 50, Me.panel1.Location.Y)
					Else
						Me.panel1.Location = New Point(Me.panel1.Location.X + 50, Me.panel1.Location.Y)
					End If
					Dim taskAwaiter As TaskAwaiter = Task.Delay(1).GetAwaiter()
					If Not taskAwaiter.IsCompleted Then
						Await taskAwaiter
						Dim taskAwaiter2 As TaskAwaiter
						taskAwaiter = taskAwaiter2
						taskAwaiter2 = Nothing
					End If
					taskAwaiter.GetResult()
				Next
				Me.Register = Not Me.Register
				Me.DeBounce = False
			End If
		End Sub

		Private Async Sub button6_Click(sender As Object, e As EventArgs)
			If Not Me.DeBounce Then
				Me.DeBounce = True
				For i As Integer = 1 To 10
					If Not Me.Register Then
						Me.panel1.Location = New Point(Me.panel1.Location.X - 50, Me.panel1.Location.Y)
					Else
						Me.panel1.Location = New Point(Me.panel1.Location.X + 50, Me.panel1.Location.Y)
					End If
					Dim taskAwaiter As TaskAwaiter = Task.Delay(1).GetAwaiter()
					If Not taskAwaiter.IsCompleted Then
						Await taskAwaiter
						Dim taskAwaiter2 As TaskAwaiter
						taskAwaiter = taskAwaiter2
						taskAwaiter2 = Nothing
					End If
					taskAwaiter.GetResult()
				Next
				Me.Register = Not Me.Register
				Me.DeBounce = False
			End If
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

		Private Async Sub Form1_Activated(sender As Object, e As EventArgs)
		End Sub

		Private Sub textBox3_TextChanged(sender As Object, e As EventArgs)
		End Sub

		Private Sub button5_Click(sender As Object, e As EventArgs)
			New HelpPage().Show()
		End Sub

		Private Async Sub DownloadUpdates()
			Dim client As WebClient = New WebClient()
			client.DownloadFile(New Uri("https://bleu.cloris.co/Release/Bleu.exe"), Directory.GetCurrentDirectory() + "/BleuTMP.exe")
			Await Task.Delay(2000)
			Me.UpdateDone = True
		End Sub

		Private Sub DownloadDlls()
			Try
				New WebClient().DownloadFile(New Uri("https://bleu.cloris.co/Release/LoadHack.dll"), "C:/Bleu/LoadHack.dll")
				New WebClient().DownloadFile(New Uri("https://bleu.cloris.co/Release/libcurl.dll"), "C:/Bleu/libcurl.dll")
				New WebClient().DownloadFile(New Uri("https://bleu.cloris.co/Release/ScintillaNET.dll"), Directory.GetCurrentDirectory() + "/ScintillaNET.dll")
			Catch
			End Try
			Me.DllsDone = True
		End Sub

		Private Async Sub button3_Click(sender As Object, e As EventArgs)
			Dim taskAwaiter2 As TaskAwaiter
			Try
				If Me.DoUpdate Then
					If Not Me.button3DeBounce Then
						Me.button3DeBounce = True
						Dim DownloadBleu As Thread = AddressOf Me.DownloadUpdates
						DownloadBleu.Start()
						Me.button3.Text = "     Downloading..."
						While Not Me.UpdateDone
							Dim taskAwaiter As TaskAwaiter = Task.Delay(1).GetAwaiter()
							If Not taskAwaiter.IsCompleted Then
								Await taskAwaiter
								taskAwaiter = taskAwaiter2
								taskAwaiter2 = Nothing
							End If
							taskAwaiter.GetResult()
						End While
						Process.Start(Directory.GetCurrentDirectory() + "/BleuTMP.exe")
						MyBase.Close()
						Me.UpdateDone = False
						Me.button3DeBounce = False
						DownloadBleu = Nothing
					End If
					Return
				End If
				Dim DownloadBleu2 As Thread = AddressOf Me.DownloadDlls
				DownloadBleu2.Start()
				Me.button3.Text = "     Downloading..."
				While Not Me.DllsDone
					Dim taskAwaiter3 As TaskAwaiter = Task.Delay(1).GetAwaiter()
					If Not taskAwaiter3.IsCompleted Then
						Await taskAwaiter3
						taskAwaiter3 = taskAwaiter2
						taskAwaiter2 = Nothing
					End If
					taskAwaiter3.GetResult()
				End While
				If File.ReadAllText("C:/Bleu/Auth.txt") = "" AndAlso MessageBox.Show("Hmm.. It doesn't look like you have an authentication code set up. Would you like to register Bleu?", "You aren't using a key", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
					If Not Me.DeBounce Then
						Me.DeBounce = True
						For i As Integer = 1 To 10
							If Not Me.Register Then
								Me.panel1.Location = New Point(Me.panel1.Location.X - 50, Me.panel1.Location.Y)
							Else
								Me.panel1.Location = New Point(Me.panel1.Location.X + 50, Me.panel1.Location.Y)
							End If
							Dim taskAwaiter4 As TaskAwaiter = Task.Delay(1).GetAwaiter()
							If Not taskAwaiter4.IsCompleted Then
								Await taskAwaiter4
								taskAwaiter4 = taskAwaiter2
								taskAwaiter2 = Nothing
							End If
							taskAwaiter4.GetResult()
						Next
						Me.Register = Not Me.Register
						Me.DeBounce = False
					End If
					Return
				End If
				DownloadBleu2 = Nothing
			Catch
			End Try
			New Main().Show()
			For j As Integer = 1 To 9
				MyBase.Opacity -= 0.1
				Dim taskAwaiter5 As TaskAwaiter = Task.Delay(1).GetAwaiter()
				If Not taskAwaiter5.IsCompleted Then
					Await taskAwaiter5
					taskAwaiter5 = taskAwaiter2
					taskAwaiter2 = Nothing
				End If
				taskAwaiter5.GetResult()
			Next
			MyBase.Hide()
		End Sub

		Private Async Sub RegisterButton_Click(sender As Object, e As EventArgs)
			If Me.KeyBox.Text = "" Then
				Dim taskAwaiter2 As TaskAwaiter
				For i As Integer = 1 To 3
					Me.KeyBox.Location = New Point(Me.KeyBox.Location.X - 1, Me.KeyBox.Location.Y)
					Dim taskAwaiter As TaskAwaiter = Task.Delay(1).GetAwaiter()
					If Not taskAwaiter.IsCompleted Then
						Await taskAwaiter
						taskAwaiter = taskAwaiter2
						taskAwaiter2 = Nothing
					End If
					taskAwaiter.GetResult()
				Next
				For j As Integer = 1 To 6
					Me.KeyBox.Location = New Point(Me.KeyBox.Location.X + 1, Me.KeyBox.Location.Y)
					Dim taskAwaiter3 As TaskAwaiter = Task.Delay(1).GetAwaiter()
					If Not taskAwaiter3.IsCompleted Then
						Await taskAwaiter3
						taskAwaiter3 = taskAwaiter2
						taskAwaiter2 = Nothing
					End If
					taskAwaiter3.GetResult()
				Next
				For k As Integer = 1 To 3
					Me.KeyBox.Location = New Point(Me.KeyBox.Location.X - 1, Me.KeyBox.Location.Y)
					Dim taskAwaiter4 As TaskAwaiter = Task.Delay(1).GetAwaiter()
					If Not taskAwaiter4.IsCompleted Then
						Await taskAwaiter4
						taskAwaiter4 = taskAwaiter2
						taskAwaiter2 = Nothing
					End If
					taskAwaiter4.GetResult()
				Next
			ElseIf Me.EmailBox.Text = "" Then
				Dim taskAwaiter2 As TaskAwaiter
				For l As Integer = 1 To 3
					Me.EmailBox.Location = New Point(Me.EmailBox.Location.X - 1, Me.EmailBox.Location.Y)
					Dim taskAwaiter5 As TaskAwaiter = Task.Delay(1).GetAwaiter()
					If Not taskAwaiter5.IsCompleted Then
						Await taskAwaiter5
						taskAwaiter5 = taskAwaiter2
						taskAwaiter2 = Nothing
					End If
					taskAwaiter5.GetResult()
				Next
				For m As Integer = 1 To 6
					Me.EmailBox.Location = New Point(Me.EmailBox.Location.X + 1, Me.EmailBox.Location.Y)
					Dim taskAwaiter6 As TaskAwaiter = Task.Delay(1).GetAwaiter()
					If Not taskAwaiter6.IsCompleted Then
						Await taskAwaiter6
						taskAwaiter6 = taskAwaiter2
						taskAwaiter2 = Nothing
					End If
					taskAwaiter6.GetResult()
				Next
				For n As Integer = 1 To 3
					Me.EmailBox.Location = New Point(Me.EmailBox.Location.X - 1, Me.EmailBox.Location.Y)
					Dim taskAwaiter7 As TaskAwaiter = Task.Delay(1).GetAwaiter()
					If Not taskAwaiter7.IsCompleted Then
						Await taskAwaiter7
						taskAwaiter7 = taskAwaiter2
						taskAwaiter2 = Nothing
					End If
					taskAwaiter7.GetResult()
				Next
			ElseIf MessageBox.Show("Would you like to check if this key is valid?", "Key validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
				If Not Me.DeBounce Then
					Me.DeBounce = True
					For i2 As Integer = 1 To 10
						If Not Me.Register Then
							Me.panel1.Location = New Point(Me.panel1.Location.X - 50, Me.panel1.Location.Y)
						Else
							Me.panel1.Location = New Point(Me.panel1.Location.X + 50, Me.panel1.Location.Y)
						End If
						Dim taskAwaiter8 As TaskAwaiter = Task.Delay(1).GetAwaiter()
						If Not taskAwaiter8.IsCompleted Then
							Await taskAwaiter8
							Dim taskAwaiter2 As TaskAwaiter
							taskAwaiter8 = taskAwaiter2
							taskAwaiter2 = Nothing
						End If
						taskAwaiter8.GetResult()
					Next
					File.WriteAllText("C:/Bleu/Auth.txt", Me.KeyBox.Text)
					Me.Register = Not Me.Register
					Me.DeBounce = False
				End If
			Else
				Try
					Dim Response As String = New WebClient().DownloadString("https://bleu.cloris.co/Whitelist.php?step=1&key=" + Me.KeyBox.Text)
					If Response <> "0" Then
						MessageBox.Show(Response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Else
						If Not(New WebClient().DownloadString("https://bleu.cloris.co/Whitelist.php?step=2&key=" + Me.KeyBox.Text + "&email=" + Me.EmailBox.Text) <> "0") Then
						End If
						Me.DeBounce = True
						For i3 As Integer = 1 To 10
							If Not Me.Register Then
								Me.panel1.Location = New Point(Me.panel1.Location.X - 50, Me.panel1.Location.Y)
							Else
								Me.panel1.Location = New Point(Me.panel1.Location.X + 50, Me.panel1.Location.Y)
							End If
							Dim taskAwaiter9 As TaskAwaiter = Task.Delay(1).GetAwaiter()
							If Not taskAwaiter9.IsCompleted Then
								Await taskAwaiter9
								Dim taskAwaiter2 As TaskAwaiter
								taskAwaiter9 = taskAwaiter2
								taskAwaiter2 = Nothing
							End If
							taskAwaiter9.GetResult()
						Next
						Try
							File.WriteAllText("C:/Bleu/Auth.txt", Me.KeyBox.Text)
						Catch
						End Try
						Me.Register = Not Me.Register
						Me.DeBounce = False
						Response = Nothing
					End If
				Catch
				End Try
			End If
		End Sub

		Private Sub panel1_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		Private Sub pictureBox1_Click(sender As Object, e As EventArgs)
		End Sub

		Private Update As String = "IMWAITINGUNTILYOULOVEMEiwillmakeyoumywife"

		Private B As Point

		Private DoUpdate As Boolean = False

		Private DeBounce As Boolean = False

		Private Register As Boolean = False

		Private UpdateDone As Boolean = False

		Private DllsDone As Boolean = False

		Private button3DeBounce As Boolean = False
	End Class
End Namespace
