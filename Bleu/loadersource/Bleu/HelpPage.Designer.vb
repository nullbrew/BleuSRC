Namespace Bleu
	Public Partial Class HelpPage
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x02000002 RID: 2
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.Bleu.HelpPage))
			Me.button1 = New Global.System.Windows.Forms.Button()
			Me.DragForm = New Global.System.Windows.Forms.Timer(Me.components)
			Me.label3 = New Global.System.Windows.Forms.Label()
			Me.AnimationTimer = New Global.System.Windows.Forms.Timer(Me.components)
			Me.pictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.webBrowser1 = New Global.System.Windows.Forms.WebBrowser()
			CType(Me.pictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.button1.FlatAppearance.BorderSize = 0
			Me.button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.button1.ForeColor = Global.System.Drawing.Color.White
			Me.button1.Location = New Global.System.Drawing.Point(470, 1)
			Me.button1.Name = "button1"
			Me.button1.Size = New Global.System.Drawing.Size(30, 28)
			Me.button1.TabIndex = 0
			Me.button1.Text = "X"
			Me.button1.UseVisualStyleBackColor = True
			AddHandler Me.button1.Click, AddressOf Me.button1_Click
			Me.DragForm.Interval = 1
			AddHandler Me.DragForm.Tick, AddressOf Me.DragForm_Tick
			Me.label3.AutoSize = True
			Me.label3.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.label3.Location = New Global.System.Drawing.Point(12, 9)
			Me.label3.Name = "label3"
			Me.label3.Size = New Global.System.Drawing.Size(53, 13)
			Me.label3.TabIndex = 5
			Me.label3.Text = "Bleu Help"
			Me.label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.AnimationTimer.Interval = 1
			AddHandler Me.AnimationTimer.Tick, AddressOf Me.AnimationTimer_Tick
			Me.pictureBox1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.pictureBox1.Location = New Global.System.Drawing.Point(-1, 0)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New Global.System.Drawing.Size(501, 30)
			Me.pictureBox1.TabIndex = 1
			Me.pictureBox1.TabStop = False
			AddHandler Me.pictureBox1.MouseDown, AddressOf Me.pictureBox1_MouseDown
			AddHandler Me.pictureBox1.MouseUp, AddressOf Me.pictureBox1_MouseUp
			Me.webBrowser1.Location = New Global.System.Drawing.Point(5, 36)
			Me.webBrowser1.MinimumSize = New Global.System.Drawing.Size(20, 20)
			Me.webBrowser1.Name = "webBrowser1"
			Me.webBrowser1.Size = New Global.System.Drawing.Size(488, 357)
			Me.webBrowser1.TabIndex = 6
			Me.webBrowser1.Url = New Global.System.Uri("https://bleu.cloris.co/Help", Global.System.UriKind.Absolute)
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			MyBase.ClientSize = New Global.System.Drawing.Size(498, 398)
			MyBase.ControlBox = False
			MyBase.Controls.Add(Me.webBrowser1)
			MyBase.Controls.Add(Me.label3)
			MyBase.Controls.Add(Me.button1)
			MyBase.Controls.Add(Me.pictureBox1)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "HelpPage"
			MyBase.Opacity = 0.0
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			AddHandler MyBase.Load, AddressOf Me.Form1_Load
			CType(Me.pictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		Private components As Global.System.ComponentModel.IContainer = Nothing

		Private button1 As Global.System.Windows.Forms.Button

		Private pictureBox1 As Global.System.Windows.Forms.PictureBox

		Private DragForm As Global.System.Windows.Forms.Timer

		Private label3 As Global.System.Windows.Forms.Label

		Private AnimationTimer As Global.System.Windows.Forms.Timer

		Private webBrowser1 As Global.System.Windows.Forms.WebBrowser
	End Class
End Namespace
