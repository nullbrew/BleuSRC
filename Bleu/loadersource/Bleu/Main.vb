Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Bleu.Properties
Imports ScintillaNET

Namespace Bleu
	Public Partial Class Main
		Inherits Form

		' Token: 0x02000004 RID: 4
		Private Declare Function mciSendString Lib "winmm.dll" (command As String, buffer As String, bufferSize As Long, hwndCallback As Long) As Integer

		Public Declare Function OpenProcess Lib "kernel32.dll" (dwDesiredAccess As Integer, bInheritHandle As Boolean, dwProcessId As Integer) As IntPtr

		Public Declare Auto Function GetModuleHandle Lib "kernel32.dll" (lpModuleName As String) As IntPtr

		Private Declare Ansi Function GetProcAddress Lib "kernel32" (hModule As IntPtr, procName As String) As IntPtr

		Private Declare Function VirtualAllocEx Lib "kernel32.dll" (hProcess As IntPtr, lpAddress As IntPtr, dwSize As UInteger, flAllocationType As UInteger, flProtect As UInteger) As IntPtr

		Private Declare Function WriteProcessMemory Lib "kernel32.dll" (hProcess As IntPtr, lpBaseAddress As IntPtr, lpBuffer As Byte(), nSize As UInteger, <System.Runtime.InteropServices.OutAttribute()> ByRef lpNumberOfBytesWritten As UIntPtr) As Boolean

		Private Declare Function CreateRemoteThread Lib "kernel32.dll" (hProcess As IntPtr, lpThreadAttributes As IntPtr, dwStackSize As UInteger, lpStartAddress As IntPtr, lpParameter As IntPtr, dwCreationFlags As UInteger, lpThreadId As IntPtr) As IntPtr

		Private Declare Auto Function SendMessage Lib "user32.dll" (hWnd As IntPtr, msg As Integer, wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> lParam As String) As Integer

		Public ReadOnly Property MainWindowHandle As IntPtr

		Public Sub New()
			Me.InitializeComponent()
		End Sub

		Private Function Inject(dllName As String) As Integer
			Dim result As Integer
			Try
				Dim process As Process = Process.GetProcessesByName("RobloxPlayerBeta")(0)
				If process IsNot Nothing Then
					If process.MainWindowHandle.ToInt32() <> 0 Then
						Dim hProcess As IntPtr = Main.OpenProcess(1082, False, process.Id)
						Dim procAddress As IntPtr = Main.GetProcAddress(Main.GetModuleHandle("kernel32.dll"), "LoadLibraryA")
						Dim intPtr As IntPtr = Main.VirtualAllocEx(hProcess, IntPtr.Zero, CUInt(((dllName.Length + 1) * Marshal.SizeOf(GetType(Char)))), 12288UI, 4UI)
						Dim uintPtr As UIntPtr
						Main.WriteProcessMemory(hProcess, intPtr, Encoding.[Default].GetBytes(dllName), CUInt(((dllName.Length + 1) * Marshal.SizeOf(GetType(Char)))), uintPtr)
						Main.CreateRemoteThread(hProcess, IntPtr.Zero, 0UI, procAddress, intPtr, 0UI, IntPtr.Zero)
						Me.Text = "Bleu [Hooked]"
					End If
				Else
					File.Create("00")
				End If
				result = 0
			Catch ex As Exception
				Me.Text = "Bleu"
				result = 0
			End Try
			Return result
		End Function

		Public Sub SendInput(Mode As Integer, Type As Integer, Data As String)
			Try
				File.WriteAllText("C:/Bleu/INPUT", Mode.ToString() + Type.ToString() + Data)
			Catch
			End Try
		End Sub

		Public Sub ReceiveOutput(Mode As Integer, Type As Integer, Data As String)
			If Mode <> Me.OUTPUT_BLEUOUTPUT AndAlso Mode = Me.OUTPUT_MESSAGE Then
				If Type = Me.TYPE_WARNINGICON Then
					MessageBox.Show(Data, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				ElseIf Type = Me.TYPE_ERRORICON Then
					MessageBox.Show(Data, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				ElseIf Type = Me.TYPE_INFORMATIONICON Then
					MessageBox.Show(Data, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				End If
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

		Public Declare Function mciSendString Lib "winmm.dll" (lpstrCommand As String, lpstrReturnString As String, uReturnLength As UInteger, hWndCallback As UInteger) As UInteger

		Private Sub Main_Load(sender As Object, e As EventArgs)
			Main.SendMessage(Me.CmdBox.Handle, 5377, 0, "Command prefix is "";"" ")
			Me.OutputCheck.Start()
			Me.Injector.Start()
			MyBase.Focus()
			Me.AnimationTimer.Start()
			Dim str As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
			Dim str2 As String = "0123456789"
			Dim str3 As String = ChrW(352) & ChrW(353) & ChrW(338) & ChrW(339) & ChrW(376) & "ÿÀàÁáÂâÃãÄäÅåÆæÇçÈèÉéÊêËëÌìÍíÎîÏïÐðÑñÒòÓóÔôÕõÖØøÙùÚúÛûÜüÝýÞþßö"
			Me.scintilla1.StyleResetDefault()
			Me.scintilla1.Styles(32).Font = "Consolas"
			Me.scintilla1.Styles(32).Size = 10
			Me.scintilla1.StyleClearAll()
			Me.scintilla1.Styles(0).ForeColor = Color.Silver
			Me.scintilla1.Styles(1).ForeColor = Color.FromArgb(0, 0, 127, 0)
			Me.scintilla1.Styles(2).ForeColor = Color.FromArgb(0, 0, 127, 0)
			Me.scintilla1.Styles(4).ForeColor = Color.FromArgb(0, 0, 127, 127)
			Me.scintilla1.Styles(5).ForeColor = Color.FromArgb(0, 0, 0, 127)
			Me.scintilla1.Styles(13).ForeColor = Color.FromArgb(0, 255, 128, 0)
			Me.scintilla1.Styles(14).ForeColor = Color.FromArgb(0, 255, 0, 0)
			Me.scintilla1.Styles(15).ForeColor = Color.DarkSlateBlue
			Me.scintilla1.Styles(6).ForeColor = Color.FromArgb(0, 127, 0, 127)
			Me.scintilla1.Styles(7).ForeColor = Color.FromArgb(0, 127, 0, 127)
			Me.scintilla1.Styles(8).ForeColor = Color.FromArgb(0, 127, 0, 127)
			Me.scintilla1.Styles(10).ForeColor = Color.FromArgb(0, 127, 127, 127)
			Me.scintilla1.Styles(9).ForeColor = Color.Maroon
			Me.scintilla1.Lexer = Lexer.Lua
			Me.scintilla1.WordChars = str + str2 + str3
			Me.scintilla1.SetKeywords(0, "info and break do else elseif end for function if in local nil not or repeat return then until while false true goto assert collectgarbage dofile _G getmetatable ipairs loadfile next pairs pcall print rawequal rawget rawset setmetatable tonumber tostring type _VERSION xpcall string table math coroutine io os debug getfenv gcinfo load loadlib loadstring require select setfenv unpack _LOADED LUA_PATH _REQUIREDNAME package rawlen package bit32 utf8 _ENV string.byte string.char string.dump string.find string.format string.gsub string.len string.lower string.rep string.sub string.upper table.concat table.insert table.remove table.sort math.abs math.acos math.asin math.atan math.atan2 math.ceil math.cos math.deg math.exp math.floor math.frexp math.ldexp math.log math.max math.min math.pi math.pow math.rad math.random math.randomseed math.sin math.sqrt math.tan string.gfind string.gmatch string.match string.reverse string.pack string.packsize string.unpack table.foreach table.foreachi table.getn table.setn table.maxn table.pack table.unpack table.move math.cosh math.fmod math.huge math.log10 math.modf math.mod math.sinh math.tanh math.maxinteger math.mininteger math.tointeger math.type math.ult bit32.arshift bit32.band bit32.bnot bit32.bor bit32.btest bit32.bxor bit32.extract bit32.replace bit32.lrotate bit32.lshift bit32.rrotate bit32.rshift utf8.char utf8.charpattern utf8.codes utf8.codepoint utf8.len utf8.offset coroutine.create coroutine.resume coroutine.status coroutine.wrap coroutine.yield io.close io.flush io.input io.lines io.open io.output io.read io.tmpfile io.type io.write io.stdin io.stdout io.stderr os.clock os.date os.difftime os.execute os.exit os.getenv os.remove os.rename os.setlocale os.time os.tmpname coroutine.isyieldable coroutine.running io.popen module package.loaders package.seeall package.config package.searchers package.searchpath require package.cpath package.loaded package.loadlib package.path package.preload")
			Me.scintilla1.SetKeywords(1, "warn")
			Me.scintilla1.SetKeywords(2, "error")
			Me.scintilla1.SetKeywords(3, "")
			Me.scintilla1.SetProperty("fold", "1")
			Me.scintilla1.SetProperty("fold.compact", "1")
			Me.scintilla1.Margins(1).Type = MarginType.Symbol
			Me.scintilla1.Margins(1).Mask = 4261412864UI
			Me.scintilla1.Margins(1).Sensitive = True
			Me.scintilla1.Margins(1).Width = 20
			For i As Integer = 25 To 31
				Me.scintilla1.Markers(i).SetForeColor(SystemColors.ControlLightLight)
				Me.scintilla1.Markers(i).SetBackColor(SystemColors.ControlDark)
			Next
			Me.scintilla1.Markers(30).Symbol = MarkerSymbol.BoxPlus
			Me.scintilla1.Markers(31).Symbol = MarkerSymbol.BoxMinus
			Me.scintilla1.Markers(25).Symbol = MarkerSymbol.BoxPlusConnected
			Me.scintilla1.Markers(27).Symbol = MarkerSymbol.TCorner
			Me.scintilla1.Markers(26).Symbol = MarkerSymbol.BoxMinusConnected
			Me.scintilla1.Markers(29).Symbol = MarkerSymbol.VLine
			Me.scintilla1.Markers(28).Symbol = MarkerSymbol.LCorner
			Me.scintilla1.AutomaticFold = (AutomaticFold.Show Or AutomaticFold.Click Or AutomaticFold.Change)
			Dim length As Integer = Me.scintilla1.Lines.Count.ToString().Length
			If length <> Me.maxLineNumberCharLength Then
				Me.scintilla1.Margins(0).Width = Me.scintilla1.TextWidth(33, New String("9"c, length + 1)) + 2
				Me.maxLineNumberCharLength = length
			End If
		End Sub

		Private Async Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs)
			e.Cancel = True
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
			Process.GetCurrentProcess().Kill()
		End Sub

		Private Async Sub Main_Deactivate(sender As Object, e As EventArgs)
			Me.Active = False
			MyBase.Opacity = 0.95
			For i As Integer = 1 To 20
				If Not Me.Active Then
					MyBase.Opacity -= 0.01
					Dim taskAwaiter As TaskAwaiter = Task.Delay(1).GetAwaiter()
					If Not taskAwaiter.IsCompleted Then
						Await taskAwaiter
						Dim taskAwaiter2 As TaskAwaiter
						taskAwaiter = taskAwaiter2
						taskAwaiter2 = Nothing
					End If
					taskAwaiter.GetResult()
				End If
			Next
		End Sub

		Private Async Sub Main_Activated(sender As Object, e As EventArgs)
			Me.Active = True
			MyBase.Opacity = 0.75
			For i As Integer = 1 To 20
				If Me.Active Then
					MyBase.Opacity += 0.01
					Dim taskAwaiter As TaskAwaiter = Task.Delay(1).GetAwaiter()
					If Not taskAwaiter.IsCompleted Then
						Await taskAwaiter
						Dim taskAwaiter2 As TaskAwaiter
						taskAwaiter = taskAwaiter2
						taskAwaiter2 = Nothing
					End If
					taskAwaiter.GetResult()
				End If
			Next
		End Sub

		Private Sub Main_MouseEnter(sender As Object, e As EventArgs)
			MyBase.Focus()
		End Sub

		Private Sub Main_MouseHover(sender As Object, e As EventArgs)
			MyBase.Focus()
		End Sub

		Private Async Sub button12_Click(sender As Object, e As EventArgs)
		End Sub

		Private Async Sub button13_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub panel1_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		Private Sub scintilla1_TextChanged(sender As Object, e As EventArgs)
			Dim length As Integer = Me.scintilla1.Lines.Count.ToString().Length
			If Me.maxLineNumberCharLength <> length Then
				Me.scintilla1.Margins(0).Width = Me.scintilla1.TextWidth(33, New String("9"c, length + 1)) + 2
				Me.maxLineNumberCharLength = length
			End If
		End Sub

		Private Sub RegisterButton_Click(sender As Object, e As EventArgs)
			Me.SendInput(Me.INPUT_EXECUTE, 0, "spawn(function() " + Me.scintilla1.Text + vbLf & "end)")
		End Sub

		Private Sub button1_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub button2_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub button20_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub button10_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub button11_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub button9_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub button3_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub button4_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub button5_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub button6_Click(sender As Object, e As EventArgs)
			Me.scintilla1.Cut()
		End Sub

		Private Sub button7_Click(sender As Object, e As EventArgs)
			Me.scintilla1.Copy()
		End Sub

		Private Sub button8_Click(sender As Object, e As EventArgs)
			Me.scintilla1.Paste()
		End Sub

		Private Sub button14_Click(sender As Object, e As EventArgs)
			If Me.MatchCase Then
				Me.MatchCase = False
				Me.button21.BackColor = Color.FromArgb(44, 44, 44)
			Else
				Me.MatchCase = True
				Me.button21.BackColor = Color.FromArgb(64, 64, 64)
			End If
		End Sub

		Private Sub textBox1_TextChanged(sender As Object, e As EventArgs)
			Me.Position = 1
			Try
				Dim text As String
				Dim value As String
				If Not Me.MatchCase Then
					text = Me.scintilla1.Text.ToLower()
					value = Me.FindBox.Text.ToLower()
				Else
					text = Me.scintilla1.Text
					value = Me.FindBox.Text
				End If
				If text.LastIndexOf(value) <> -1 Then
					Dim list As List(Of Integer) = text.AllIndexesOf(value)
					Me.scintilla1.SelectionStart = list(Me.Position - 1)
					Me.scintilla1.SelectionEnd = Me.FindBox.Text.Length + list(Me.Position - 1)
					Me.ResultLabel.Text = Me.Position.ToString() + " of " + list.Count.ToString() + " matches"
				Else
					Me.ResultLabel.Text = "0 matches"
				End If
			Catch
				Me.ResultLabel.Text = ""
			End Try
		End Sub

		Private Sub FindBox_KeyDown(sender As Object, e As KeyEventArgs)
			If e.Shift Then
				If e.KeyCode = Keys.[Return] Then
					Try
						Dim str As String
						Dim value As String
						If Not Me.MatchCase Then
							str = Me.scintilla1.Text.ToLower()
							value = Me.FindBox.Text.ToLower()
						Else
							str = Me.scintilla1.Text
							value = Me.FindBox.Text
						End If
						Me.Position -= 1
						Dim list As List(Of Integer) = str.AllIndexesOf(value)
						Me.scintilla1.SelectionStart = list(Me.Position - 1)
						Me.scintilla1.SelectionEnd = Me.FindBox.Text.Length + list(Me.Position - 1)
						Me.scintilla1.[Select]()
						Me.scintilla1.ScrollCaret()
						Me.ResultLabel.Text = Me.Position.ToString() + " of " + list.Count.ToString() + " matches"
						e.SuppressKeyPress = True
					Catch
						Try
							Dim str2 As String
							Dim value2 As String
							If Not Me.MatchCase Then
								str2 = Me.scintilla1.Text.ToLower()
								value2 = Me.FindBox.Text.ToLower()
							Else
								str2 = Me.scintilla1.Text
								value2 = Me.FindBox.Text
							End If
							Dim list2 As List(Of Integer) = str2.AllIndexesOf(value2)
							Me.Position = list2.Count(Of Integer)()
							Me.scintilla1.SelectionStart = list2(Me.Position - 1)
							Me.scintilla1.SelectionEnd = Me.FindBox.Text.Length + list2(Me.Position - 1)
							Me.scintilla1.[Select]()
							Me.scintilla1.ScrollCaret()
							Me.ResultLabel.Text = Me.Position.ToString() + " of " + list2.Count.ToString() + " matches"
						Catch
						End Try
					End Try
					Me.FindBox.Focus()
				End If
			Else
				Try
					Dim str3 As String
					Dim value3 As String
					If Not Me.MatchCase Then
						str3 = Me.scintilla1.Text.ToLower()
						value3 = Me.FindBox.Text.ToLower()
					Else
						str3 = Me.scintilla1.Text
						value3 = Me.FindBox.Text
					End If
					Me.Position += 1
					Dim list3 As List(Of Integer) = str3.AllIndexesOf(value3)
					Me.scintilla1.SelectionStart = list3(Me.Position - 1)
					Me.scintilla1.SelectionEnd = Me.FindBox.Text.Length + list3(Me.Position - 1)
					Me.scintilla1.[Select]()
					Me.scintilla1.ScrollCaret()
					Me.ResultLabel.Text = Me.Position.ToString() + " of " + list3.Count.ToString() + " matches"
					If e.KeyCode = Keys.[Return] Then
						e.SuppressKeyPress = True
					End If
				Catch
					Try
						Dim str4 As String
						Dim value4 As String
						If Not Me.MatchCase Then
							str4 = Me.scintilla1.Text.ToLower()
							value4 = Me.FindBox.Text.ToLower()
						Else
							str4 = Me.scintilla1.Text
							value4 = Me.FindBox.Text
						End If
						Dim list4 As List(Of Integer) = str4.AllIndexesOf(value4)
						Me.Position = 1
						Me.scintilla1.SelectionStart = list4(Me.Position - 1)
						Me.scintilla1.SelectionEnd = Me.FindBox.Text.Length + list4(Me.Position - 1)
						Me.scintilla1.[Select]()
						Me.scintilla1.ScrollCaret()
						Me.ResultLabel.Text = Me.Position.ToString() + " of " + list4.Count.ToString() + " matches"
						If e.KeyCode = Keys.[Return] Then
							e.SuppressKeyPress = True
						End If
					Catch
					End Try
				End Try
				Me.FindBox.Focus()
			End If
		End Sub

		Private Sub FindClose_Click(sender As Object, e As EventArgs)
			Me.FindPanel.Visible = False
		End Sub

		Private Sub scintilla1_KeyDown(sender As Object, e As KeyEventArgs)
			If e.Control AndAlso e.KeyCode = Keys.F Then
				e.SuppressKeyPress = True
				Me.FindPanel.Visible = True
				Me.FindBox.Focus()
			End If
		End Sub

		Private Sub scintilla1_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub FindBack_Click(sender As Object, e As EventArgs)
			Try
				Dim str As String
				Dim value As String
				If Not Me.MatchCase Then
					str = Me.scintilla1.Text.ToLower()
					value = Me.FindBox.Text.ToLower()
				Else
					str = Me.scintilla1.Text
					value = Me.FindBox.Text
				End If
				Me.Position -= 1
				Dim list As List(Of Integer) = str.AllIndexesOf(value)
				Me.scintilla1.SelectionStart = list(Me.Position - 1)
				Me.scintilla1.SelectionEnd = Me.FindBox.Text.Length + list(Me.Position - 1)
				Me.scintilla1.[Select]()
				Me.scintilla1.ScrollCaret()
				Me.ResultLabel.Text = Me.Position.ToString() + " of " + list.Count.ToString() + " matches"
			Catch
				Try
					Dim str2 As String
					Dim value2 As String
					If Not Me.MatchCase Then
						str2 = Me.scintilla1.Text.ToLower()
						value2 = Me.FindBox.Text.ToLower()
					Else
						str2 = Me.scintilla1.Text
						value2 = Me.FindBox.Text
					End If
					Dim list2 As List(Of Integer) = str2.AllIndexesOf(value2)
					Me.Position = list2.Count(Of Integer)()
					Me.scintilla1.SelectionStart = list2(Me.Position - 1)
					Me.scintilla1.SelectionEnd = Me.FindBox.Text.Length + list2(Me.Position - 1)
					Me.scintilla1.[Select]()
					Me.scintilla1.ScrollCaret()
					Me.ResultLabel.Text = Me.Position.ToString() + " of " + list2.Count.ToString() + " matches"
				Catch
				End Try
			End Try
			Me.FindBox.Focus()
		End Sub

		Private Sub FindForward_Click(sender As Object, e As EventArgs)
			Try
				Dim str As String
				Dim value As String
				If Not Me.MatchCase Then
					str = Me.scintilla1.Text.ToLower()
					value = Me.FindBox.Text.ToLower()
				Else
					str = Me.scintilla1.Text
					value = Me.FindBox.Text
				End If
				Me.Position += 1
				Dim list As List(Of Integer) = str.AllIndexesOf(value)
				Me.scintilla1.SelectionStart = list(Me.Position - 1)
				Me.scintilla1.SelectionEnd = Me.FindBox.Text.Length + list(Me.Position - 1)
				Me.scintilla1.[Select]()
				Me.scintilla1.ScrollCaret()
				Me.ResultLabel.Text = Me.Position.ToString() + " of " + list.Count.ToString() + " matches"
			Catch
				Try
					Dim str2 As String
					Dim value2 As String
					If Not Me.MatchCase Then
						str2 = Me.scintilla1.Text.ToLower()
						value2 = Me.FindBox.Text.ToLower()
					Else
						str2 = Me.scintilla1.Text
						value2 = Me.FindBox.Text
					End If
					Dim list2 As List(Of Integer) = str2.AllIndexesOf(value2)
					Me.Position = 1
					Me.scintilla1.SelectionStart = list2(Me.Position - 1)
					Me.scintilla1.SelectionEnd = Me.FindBox.Text.Length + list2(Me.Position - 1)
					Me.scintilla1.[Select]()
					Me.scintilla1.ScrollCaret()
					Me.ResultLabel.Text = Me.Position.ToString() + " of " + list2.Count.ToString() + " matches"
				Catch
				End Try
			End Try
			Me.FindBox.Focus()
		End Sub

		Private Sub FindBox_TextChanged(sender As Object, e As EventArgs)
		End Sub

		Private Async Sub Injector_Tick(sender As Object, e As EventArgs)
			If Me.InjectOk Then
				Try
					Me.Inject("C:/Bleu/libcurl.dll")
					Task.Delay(500)
					Me.Inject("C:/Bleu/LoadHack.dll")
				Catch
				End Try
			End If
		End Sub

		Private Sub button14_Click_1(sender As Object, e As EventArgs)
		End Sub

		Private Sub button13_Click_1(sender As Object, e As EventArgs)
		End Sub

		Private Sub button15_Click(sender As Object, e As EventArgs)
		End Sub

		Public Function Filter1(s As String) As Boolean
			Return Not(s = "") AndAlso Not(s = ".txt") AndAlso Not(s = ".lua") AndAlso s.ToLower().LastIndexOf("(1)") = -1 AndAlso s.ToLower().LastIndexOf("(2)") = -1 AndAlso s.ToLower().LastIndexOf("(3)") = -1 AndAlso s.ToLower().LastIndexOf("(4)") = -1 AndAlso s.ToLower().LastIndexOf("(5)") = -1
		End Function

		Private Function Filter2(s As String) As String
			Return s
		End Function

		Private Sub button16_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub button17_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub button18_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub button19_Click(sender As Object, e As EventArgs)
			If Me.InjectOk Then
				Me.InjectOk = False
				Me.button19.Image = Resources.lock_open
			Else
				Me.InjectOk = True
				Me.button19.Image = Resources._lock
			End If
		End Sub

		Private Sub searchScriptBox_TextChanged(sender As Object, e As EventArgs)
			Me.scriptBox.Items.Clear()
			If Me.searchScriptBox.Text <> "" Then
				Try
					Dim separator As Char() = New Char() { "!"c }
					Dim array As String() = Me.ScriptString.Split(separator)
					For Each text As String In array
						If text.ToLower().Replace("-", "").Replace(" ", "").LastIndexOf(Me.searchScriptBox.Text.ToLower().Replace("-", "").Replace(" ", "")) <> -1 AndAlso Me.Filter1(text) Then
							Me.scriptBox.Items.Add(Me.Filter2(text))
						End If
					Next
					Return
				Catch
					Me.scriptBox.Items.Add("Unable to fetch script list.")
					Return
				End Try
			End If
			Try
				Dim separator2 As Char() = New Char() { "!"c }
				Dim array3 As String() = Me.ScriptString.Split(separator2)
				For Each s As String In array3
					If Me.Filter1(s) Then
						Me.scriptBox.Items.Add(Me.Filter2(s))
					End If
				Next
			Catch
				Me.scriptBox.Items.Add("Unable to fetch script list.")
			End Try
		End Sub

		Private Sub scriptBox_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Me.Library Then
				Try
					Me.scintilla1.Text = New WebClient().DownloadString("http://bleu.cloris.co/Scripts/" + Me.scriptBox.SelectedItem.ToString())
					Return
				Catch
					Return
				End Try
			End If
			Try
				Dim separator As Char() = New Char() { "#"c }
				Dim array As String() = Me.scriptBox.SelectedItem.ToString().Split(separator)
				Dim num As Integer
				Integer.TryParse(array(1), num)
				Me.scintilla1.Text = File.ReadAllText(Me.StringArray(num - 1))
			Catch
			End Try
		End Sub

		Private Sub OutputCheck_Tick(sender As Object, e As EventArgs)
			Try
				If "~" <> File.ReadAllText("C:/Bleu/OUTPUT") Then
					Try
						Dim text As String = File.ReadAllText("C:/Bleu/OUTPUT")
						File.WriteAllText("C:/Bleu/OUTPUT", "~")
						Me.ReceiveOutput(Integer.Parse(text.Substring(0, 1)), Integer.Parse(text.Substring(1, 1)), text.Substring(2))
					Catch
					End Try
				End If
			Catch
			End Try
		End Sub

		Private Sub scriptsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MessageBox.Show("This feature is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub topKek75ToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MessageBox.Show("This feature is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub dexToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.SendInput(Me.INPUT_EXECUTE, 0, "spawn(function() loadstring(game:GetObjects('rbxassetid://418957341')[1].Source)() " & vbLf & "end)")
		End Sub

		Private Sub environmentToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MessageBox.Show("Modifications to ROBLOX:" & vbCrLf & " - TrustCheck bypass" & vbCrLf & " - Added GetObjects" & vbCrLf & " - Added GetObjectsLoadScripts" & vbCrLf & " - Level 6 identity" & vbCrLf & " - LoadLibrary support" & vbCrLf & vbCrLf & " Custom Environment:" & vbCrLf & " - Bleu Table" & vbCrLf & "   - ChangeContext Function" & vbCrLf & "   - ExecuteScript Function" & vbCrLf & " - File Table" & vbCrLf & "   - Write Function" & vbCrLf & "   - Read Function" & vbCrLf & " - Clipboard Table" & vbCrLf & "   - Set Function" & vbCrLf & "   - Get Function" & vbCrLf & " - Output Table" & vbCrLf & "   - SyntaxError Function" & vbCrLf & "   - Error Function" & vbCrLf & "   - Warn Function" & vbCrLf & "   - Info Function" & vbCrLf & "   - Normal Function" & vbCrLf & vbCrLf & " Extended ROBLOX Environment:" & vbCrLf & " - dofile Function" & vbCrLf & "   - Compiles and runs as script from a file" & vbCrLf & " - loadfile Function" & vbCrLf & "   - Compiles and returns a script from a file" & vbCrLf & " - loadstring Function" & vbCrLf & "   - Compiles and returns a script from a string" & vbCrLf & " - getrawmetatable Function (coming soon)" & vbCrLf & "   - Returns the raw metatable of a ROBLOX userdata" & vbCrLf & " - getscriptfunction Function(coming soon)" & vbCrLf & "   - Returns the function of a script" & vbCrLf & " - info Function" & vbCrLf & "   - Outputs an input message into the ROBLOX console", "Bleu Custom Environment")
		End Sub

		Private Sub scriptListToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.StringArray.Clear()
			Me.ScriptString = ""
			Me.scriptBox.Items.Clear()
			Try
				Dim files As String() = Directory.GetFiles("C:/Bleu/AutoExecute", "*.*", SearchOption.AllDirectories)
				Dim num As Integer = 0
				For Each text As String In files
					If Path.GetExtension(text) = ".lua" OrElse Path.GetExtension(text) = ".txt" Then
						num += 1
						Me.StringArray.Add(text)
						Me.ScriptString = String.Concat(New Object() { Me.ScriptString, Path.GetFileName(text), " #", num, "!" })
					End If
				Next
			Catch
			End Try
			Try
				Dim separator As Char() = New Char() { "!"c }
				Dim array2 As String() = Me.ScriptString.Split(separator)
				For Each s As String In array2
					If Me.Filter1(s) Then
						Me.scriptBox.Items.Add(Me.Filter2(s))
					End If
				Next
			Catch
				Me.scriptBox.Items.Add("Unable to fetch script list.")
			End Try
			If Not Me.OpenScript Then
				Me.OpenScript = True
				Me.scintilla1.Size = New Size(Me.scintilla1.Size.Width - Me.scriptBox.Size.Width - 5, Me.scintilla1.Size.Height)
			ElseIf Not Me.Library Then
				Me.OpenScript = False
				Me.scintilla1.Size = New Size(Me.scintilla1.Size.Width + Me.scriptBox.Size.Width + 5, Me.scintilla1.Size.Height)
			End If
			Me.Library = False
		End Sub

		Private Sub scriptLibraryToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.scriptBox.Items.Clear()
			Try
				Me.ScriptString = New WebClient().DownloadString("http://bleu.cloris.co/FetchScripts.php")
				Dim separator As Char() = New Char() { "!"c }
				Dim array As String() = Me.ScriptString.Split(separator)
				For Each s As String In array
					If Me.Filter1(s) Then
						Me.scriptBox.Items.Add(Me.Filter2(s))
					End If
				Next
			Catch
				Me.scriptBox.Items.Add("Unable to fetch script list.")
			End Try
			Main.SendMessage(Me.searchScriptBox.Handle, 5377, 0, "Search")
			If Not Me.OpenScript Then
				Me.OpenScript = True
				Me.scintilla1.Size = New Size(Me.scintilla1.Size.Width - Me.scriptBox.Size.Width - 5, Me.scintilla1.Size.Height)
			ElseIf Me.Library Then
				Me.OpenScript = False
				Me.scintilla1.Size = New Size(Me.scintilla1.Size.Width + Me.scriptBox.Size.Width + 5, Me.scintilla1.Size.Height)
			End If
			Me.Library = True
		End Sub

		Private Sub killRobloxToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each process As Process In Process.GetProcessesByName("RobloxPlayerBeta")
					process.Kill()
				Next
			Catch
			End Try
		End Sub

		Private Sub themesToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.FileLocation = "" Then
				Me.scintilla1.Text = ""
				Me.FileLocation = ""
			Else
				Dim dialogResult As DialogResult = MessageBox.Show("Do you want to save your changes?", "Confirmation", MessageBoxButtons.YesNoCancel)
				If dialogResult = DialogResult.Yes Then
					Try
						File.WriteAllText(Me.FileLocation, Me.scintilla1.Text)
					Catch
					End Try
					Me.scintilla1.Text = ""
					Me.FileLocation = ""
				ElseIf dialogResult = DialogResult.No Then
					Me.scintilla1.Text = ""
					Me.FileLocation = ""
				End If
			End If
		End Sub

		Private Sub saveToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.FileLocation = "" Then
				If Me.saveFileDialog1.ShowDialog() = DialogResult.Cancel Then
					Return
				End If
				Try
					Me.FileLocation = Me.saveFileDialog1.FileName
					File.Create(Me.saveFileDialog1.FileName).Close()
					File.WriteAllText(Me.saveFileDialog1.FileName, Me.scintilla1.Text)
					Return
				Catch
					Return
				End Try
			End If
			Try
				File.WriteAllText(Me.FileLocation, Me.scintilla1.Text)
			Catch
			End Try
		End Sub

		Private Sub saveAsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.saveFileDialog1.ShowDialog() <> DialogResult.Cancel Then
				Try
					Me.FileLocation = Me.saveFileDialog1.FileName
					File.Create(Me.saveFileDialog1.FileName).Close()
					File.WriteAllText(Me.saveFileDialog1.FileName, Me.scintilla1.Text)
				Catch
				End Try
			End If
		End Sub

		Private Sub openToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.FileLocation = "" Then
				If Me.OpenFileDialog1.ShowDialog() = DialogResult.Cancel Then
					Return
				End If
				Try
					Me.FileLocation = Me.OpenFileDialog1.FileName
					Me.scintilla1.Text = File.ReadAllText(Me.OpenFileDialog1.FileName)
					Return
				Catch
					Return
				End Try
			End If
			Dim dialogResult As DialogResult = MessageBox.Show("Do you want to save your changes?", "Confirmation", MessageBoxButtons.YesNoCancel)
			If dialogResult = DialogResult.Yes Then
				Try
					File.WriteAllText(Me.FileLocation, Me.scintilla1.Text)
				Catch
				End Try
				If Me.OpenFileDialog1.ShowDialog() = DialogResult.Cancel Then
					Return
				End If
				Try
					Me.FileLocation = Me.OpenFileDialog1.FileName
					Me.scintilla1.Text = File.ReadAllText(Me.OpenFileDialog1.FileName)
					Return
				Catch
					Return
				End Try
			End If
			If dialogResult = DialogResult.No AndAlso Me.OpenFileDialog1.ShowDialog() <> DialogResult.Cancel Then
				Try
					Me.FileLocation = Me.OpenFileDialog1.FileName
					Me.scintilla1.Text = File.ReadAllText(Me.OpenFileDialog1.FileName)
				Catch
				End Try
			End If
		End Sub

		Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Process.GetCurrentProcess().Kill()
		End Sub

		Private Sub undoToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.scintilla1.Undo()
		End Sub

		Private Sub redoToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.scintilla1.Redo()
		End Sub

		Private Sub selectAllToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.scintilla1.SelectAll()
		End Sub

		Private Sub cutToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.scintilla1.Cut()
		End Sub

		Private Sub copyToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.scintilla1.Copy()
		End Sub

		Private Sub pasteToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.scintilla1.Paste()
		End Sub

		Private Sub vavToolStripMenuItem_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub FillMatches(origstr As String)
			Try
				Dim text As String = origstr
				Me.CmdMatches.Items.Clear()
				text = text.ToLower()
				text = text.Split(New Char() { " "c })(0)
				Dim num As Integer = 0
				For i As Integer = 0 To Me.Cmds.Length - 1
					Try
						If Me.Cmds(i).Substring(0, text.Length) = text Then
							num += 1
							If origstr.Split(New Char() { " "c }).Length < 2 Then
								If num <= 5 Then
									Dim toolStripItem As ToolStripItem = Me.CmdMatches.Items.Add(Me.Cmds(i))
									toolStripItem.ForeColor = Color.FromArgb(224, 224, 224)
								End If
							ElseIf Me.Cmds(i).Split(New Char() { " "c })(0) = text AndAlso num <= 5 Then
								Dim toolStripItem2 As ToolStripItem = Me.CmdMatches.Items.Add(Me.Cmds(i))
								toolStripItem2.ForeColor = Color.FromArgb(224, 224, 224)
							End If
						End If
					Catch
					End Try
				Next
				If Me.CmdMatches.Items.Count <> 0 Then
					Me.CmdMatches.Show(Me.CmdBox, New Point(0, 20))
				Else
					Me.CmdMatches.Close()
				End If
			Catch
			End Try
		End Sub

		Private Sub CmdBox_TextChanged(sender As Object, e As EventArgs)
			Dim size As Size = TextRenderer.MeasureText(Me.CmdBox.Text, Me.CmdBox.Font)
			If size.Width <= 430 Then
				If size.Width > 128 Then
					Me.CmdBox.Size = New Size(size.Width, 20)
					Me.CmdBox.Location = New Point(Me.panel1.Size.Width - (size.Width + 2), 1)
				Else
					Me.CmdBox.Size = New Size(128, 20)
					Me.CmdBox.Location = New Point(Me.panel1.Size.Width - 130, 1)
				End If
				Try
					If Me.CmdBox.Text.Substring(0, 1) = ";" Then
						Me.FillMatches(Me.CmdBox.Text.Substring(1))
					Else
						Me.CmdMatches.Close()
					End If
				Catch
					Me.CmdMatches.Close()
				End Try
			End If
		End Sub

		Private Function FindPlayer(str As String, name As String) As String
			Return String.Concat(New String() { "local ", name.ToLower(), " = (function() local str = [===[", str, "]===] if str == 'me' then return game:GetService('Players').LocalPlayer else for i,v in pairs(game:GetService('Players'):GetPlayers()) do  if v.Name:sub(1, str:len()) == str then return v end end end return game:GetService('Players').LocalPlayer end)();" })
		End Function

		Private Function FindPlayers(str As String, func As String) As String
			Dim text As String = "{"
			Dim array As String() = str.Split(New Char() { ","c })
			For i As Integer = 0 To array.Length - 1
				text = text + "[===[" + array(i).ToLower() + "]===],"
			Next
			text += "}"
			Return String.Concat(New String() { "local function getPlayers(plrs) local newt = {} for i,v in pairs(plrs) do if v == 'me' then table.insert(newt, game:GetService('Players').LocalPlayer) elseif v == 'all' then for o,b in pairs(game:GetService('Players'):GetPlayers()) do table.insert(newt, b) end elseif v == 'others' then for o,b in pairs(game:GetService('Players'):GetPlayers()) do if b ~= game:GetService('Players').LocalPlayer then table.insert(newt, b) end end else for o,b in pairs(game:GetService('Players'):GetPlayers()) do if b.Name:sub(1, v:len()):lower() == v:lower() then table.insert(newt, b) end end  end end return newt end for i,p in pairs(getPlayers(", text, ")) do ", func, " end" })
		End Function

		Private Sub DoCmd(str As String)
			Me.SendInput(Me.INPUT_EXECUTE, 0, "spawn(function()pcall(function() " + str + " end)" & vbLf & "end)")
		End Sub

		Private Sub DoCommand(str As String)
			Try
				If str.Substring(0, 1) = ";" Then
					str = str.Substring(1)
					Dim array As String() = str.Split(New Char() { " "c })
					Dim a As String = array(0).ToLower()
					If a = "cmds" OrElse a = "cmd" OrElse a = "command" OrElse a = "commands" Then
						Me.scintilla1.Text = "Total commands: " + Me.Cmds.Length.ToString()
						For i As Integer = 0 To Me.Cmds.Length - 1
							Dim scintilla As Scintilla = Me.scintilla1
							scintilla.Text = scintilla.Text + vbLf & "-" + Me.Cmds(i)
						Next
					ElseIf a = "kill" Then
						Me.DoCmd(Me.FindPlayers(array(1), "p.Character:BreakJoints()"))
					ElseIf a = "ff" OrElse a = "forcefield" Then
						Me.DoCmd(Me.FindPlayers(array(1), "Instance.new('ForceField', p.Character)"))
					ElseIf a = "explode" OrElse a = "xplode" OrElse a = "explosion" OrElse a = "xplosion" Then
						Me.DoCmd(Me.FindPlayers(array(1), "local x = Instance.new('Explosion', p.Character) x.Position = p.Character.Head.Position"))
					ElseIf a = "fire" OrElse a = "flame" Then
						Me.DoCmd(Me.FindPlayers(array(1), "Instance.new('Fire', p.Character.Head)"))
					ElseIf a = "tp" OrElse a = "teleport" Then
						Me.DoCmd(Me.FindPlayer(array(2), "tp") + Me.FindPlayers(array(1), "p.Character:MoveTo(tp.Character.Head.Position)"))
					ElseIf a = "ws" OrElse a = "speed" OrElse a = "walkspeed" Then
						Me.DoCmd(Me.FindPlayers(array(1), "p.Character.Humanoid.WalkSpeed = " + array(2)))
					ElseIf a = "jp" OrElse a = "jumppower" Then
						Me.DoCmd(Me.FindPlayers(array(1), "p.Character.Humanoid.JumpPower = " + array(2)))
					ElseIf a = "hh" OrElse a = "hipheight" Then
						Me.DoCmd(Me.FindPlayers(array(1), "p.Character.Humanoid.HipHeight = " + array(2)))
					ElseIf a = "kanapapaia" OrElse a = "kana" Then
						Me.DoCmd(Me.FindPlayers(array(1), "game:GetService('Chat'):Chat(p.Character.Head, 'u kanapapaia?')"))
					End If
				ElseIf Uri.IsWellFormedUriString(str, UriKind.Absolute) Then
					Me.SendInput(Me.INPUT_EXECUTE, 0, "spawn(function() loadstring(game:HttpGet([===[" + str + "]===], true))() " & vbLf & "end)")
				Else
					Me.SendInput(Me.INPUT_EXECUTE, 0, "spawn(function() " + str + vbLf & "end)")
				End If
			Catch
			End Try
		End Sub

		Private Sub CmdBox_KeyDown(sender As Object, e As KeyEventArgs)
			If e.KeyCode = Keys.[Return] Then
				e.SuppressKeyPress = True
				Me.DoCommand(Me.CmdBox.Text)
				Dim flag As Boolean = True
				For i As Integer = 0 To Me.Previous.Count - 1
					If Me.Previous(i) = Me.CmdBox.Text Then
						flag = False
					End If
				Next
				If flag Then
					Me.Previous.Add(Me.CmdBox.Text)
				End If
				Me.CmdBox.Text = ""
				Me.loc = Me.Previous.Count
			ElseIf e.KeyCode = Keys.Up Then
				If Me.Previous.Count <> 0 AndAlso Me.loc <> 0 Then
					Me.loc -= 1
					Me.CmdBox.Text = Me.Previous(Me.loc)
				End If
			ElseIf e.KeyCode = Keys.Down AndAlso (Me.Previous.Count <> 0 AndAlso Me.loc <> Me.Previous.Count - 1 AndAlso Me.loc <> Me.Previous.Count) Then
				Me.loc += 1
				Me.CmdBox.Text = Me.Previous(Me.loc)
			End If
		End Sub

		Private Sub CmdBox_KeyPress(sender As Object, e As KeyPressEventArgs)
		End Sub

		Private Sub CmdBox_Leave(sender As Object, e As EventArgs)
			Me.CmdMatches.Close()
		End Sub

		Private Sub Main_MaximizedBoundsChanged(sender As Object, e As EventArgs)
		End Sub

		Private Sub Main_LocationChanged(sender As Object, e As EventArgs)
			Me.CmdMatches.Close()
		End Sub

		Private Sub outputToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MessageBox.Show("This feature is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub toolStripMenuItem9_Click(sender As Object, e As EventArgs)
			MessageBox.Show("This feature is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub toolStripMenuItem10_Click(sender As Object, e As EventArgs)
			MessageBox.Show("This feature is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub toolStripMenuItem11_Click(sender As Object, e As EventArgs)
			MessageBox.Show("This feature is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub toolStripMenuItem12_Click(sender As Object, e As EventArgs)
			MessageBox.Show("This feature is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub toolStripMenuItem13_Click(sender As Object, e As EventArgs)
			MessageBox.Show("This feature is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub toolStripMenuItem14_Click(sender As Object, e As EventArgs)
			MessageBox.Show("This feature is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub toolStripMenuItem15_Click(sender As Object, e As EventArgs)
			MessageBox.Show("This feature is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub toolStripMenuItem16_Click(sender As Object, e As EventArgs)
			MessageBox.Show("This feature is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub inGameTopBarToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MessageBox.Show("This feature is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub otherScriptsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MessageBox.Show("This feature is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub infiniteYieldToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MessageBox.Show("This feature is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub remoteSpyToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MessageBox.Show("This feature is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub roXploit61ToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MessageBox.Show("This feature is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub zinniaKickToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MessageBox.Show("This feature is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub rainingSeagullsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MessageBox.Show("This feature is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub newExecutionToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MessageBox.Show("This feature is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub wrapperToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MessageBox.Show("This feature is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub extendedEnvToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MessageBox.Show("This feature is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub trustCheckToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MessageBox.Show("This feature is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub outputErrorsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MessageBox.Show("This feature is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub toolStripSeparator6_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub toolStripSeparator9_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub doNotClickOnThisToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				File.WriteAllBytes("C:/Bleu/sadaf.mp3", Resources.Miss_Sweeney___Weezer_Mp3Converter_net_)
				Main.mciSendString("close temp_alias", Nothing, 0UI, 0UI)
				Main.mciSendString("open ""C:/Bleu/sadaf.mp3"" alias temp_alias", Nothing, 0UI, 0UI)
				Main.mciSendString("play temp_alias repeat", Nothing, 0UI, 0UI)
			Catch
				Me.Text = "ohsadaa"
			End Try
		End Sub

		Public Shared Function RandomString(length As Integer) As String
			Dim source As IEnumerable(Of String) = Enumerable.Repeat(Of String)("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
			Dim <>9__154_ As Func(Of String, Char) = Main.<>c.<>9__154_0
			Dim selector As Func(Of String, Char) = <>9__154_
			If <>9__154_ Is Nothing Then
				Dim func As Func(Of String, Char) = Function(s As String) s(Main.random.[Next](s.Length))
				selector = func
				Main.<>c.<>9__154_0 = func
			End If
			Return New String(source.[Select](selector).ToArray(Of Char)())
		End Function

		Private Async Sub PissOff_Tick(sender As Object, e As EventArgs)
		End Sub

		Private Sub scriptWareUIToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.SendInput(Me.INPUT_EXECUTE, 0, "SckripptWear()")
		End Sub

		Private Const EM_SETCUEBANNER As Integer = 5377

		Private AutoHook As Boolean = True

		Private Const PROCESS_CREATE_THREAD As Integer = 2

		Private Const PROCESS_QUERY_INFORMATION As Integer = 1024

		Private Const PROCESS_VM_OPERATION As Integer = 8

		Private Const PROCESS_VM_WRITE As Integer = 32

		Private Const PROCESS_VM_READ As Integer = 16

		Private Const MEM_COMMIT As UInteger = 4096UI

		Private Const MEM_RESERVE As UInteger = 8192UI

		Private Const PAGE_READWRITE As UInteger = 4UI

		Private INPUT_EXECUTE As Integer = 1

		Private INPUT_UPDATESETTINGS As Integer = 2

		Private TYPE_TRUSTCHECK As Integer = 1

		Private TYPE_CUSTOMENV As Integer = 2

		Private OUTPUT_BLEUOUTPUT As Integer = 1

		Private TYPE_PRINT As Integer = 0

		Private TYPE_WARN As Integer = 1

		Private TYPE_ERROR As Integer = 2

		Private TYPE_INFO As Integer = 3

		Private OUTPUT_MESSAGE As Integer = 2

		Private TYPE_WARNINGICON As Integer = 1

		Private TYPE_ERRORICON As Integer = 2

		Private TYPE_INFORMATIONICON As Integer = 3

		Private maxLineNumberCharLength As Integer

		Private Active As Boolean = True

		Private Open As Boolean = False

		Private FileLocation As String = ""

		Private Position As Integer = 1

		Private MatchCase As Boolean = False

		Private InjectOk As Boolean = True

		Private OpenScript As Boolean = False

		Private Library As Boolean = False

		Private ScriptString As String

		Private StringArray As List(Of String) = New List(Of String)()

		Private Cmds As String() = New String() { "cmds", "kill plr", "ff plr", "explode plr", "fire plr", "tp plr plr", "ws plr num", "jp plr num", "hh plr num", "kanapapaia plr" }

		Private Previous As List(Of String) = New List(Of String)()

		Private loc As Integer = 0

		Private Shared random As Random = New Random()
	End Class
End Namespace
