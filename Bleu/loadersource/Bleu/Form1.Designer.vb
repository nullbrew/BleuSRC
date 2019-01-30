Namespace Bleu
	Public Partial Class Form1
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x02000003 RID: 3
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.Bleu.Form1))
			Me.button1 = New Global.System.Windows.Forms.Button()
			Me.button2 = New Global.System.Windows.Forms.Button()
			Me.DragForm = New Global.System.Windows.Forms.Timer(Me.components)
			Me.label1 = New Global.System.Windows.Forms.Label()
			Me.label2 = New Global.System.Windows.Forms.Label()
			Me.label3 = New Global.System.Windows.Forms.Label()
			Me.panel1 = New Global.System.Windows.Forms.Panel()
			Me.Changelog = New Global.System.Windows.Forms.WebBrowser()
			Me.RegisterButton = New Global.System.Windows.Forms.Button()
			Me.label8 = New Global.System.Windows.Forms.Label()
			Me.label7 = New Global.System.Windows.Forms.Label()
			Me.label6 = New Global.System.Windows.Forms.Label()
			Me.EmailBox = New Global.System.Windows.Forms.TextBox()
			Me.label5 = New Global.System.Windows.Forms.Label()
			Me.KeyBox = New Global.System.Windows.Forms.TextBox()
			Me.button6 = New Global.System.Windows.Forms.Button()
			Me.panel2 = New Global.System.Windows.Forms.Panel()
			Me.pictureBox5 = New Global.System.Windows.Forms.PictureBox()
			Me.pictureBox4 = New Global.System.Windows.Forms.PictureBox()
			Me.pictureBox3 = New Global.System.Windows.Forms.PictureBox()
			Me.label4 = New Global.System.Windows.Forms.Label()
			Me.button5 = New Global.System.Windows.Forms.Button()
			Me.button4 = New Global.System.Windows.Forms.Button()
			Me.button3 = New Global.System.Windows.Forms.Button()
			Me.pictureBox6 = New Global.System.Windows.Forms.PictureBox()
			Me.AnimationTimer = New Global.System.Windows.Forms.Timer(Me.components)
			Me.pictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.panel1.SuspendLayout()
			Me.panel2.SuspendLayout()
			CType(Me.pictureBox5, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox4, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox3, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox6, Global.System.ComponentModel.ISupportInitialize).BeginInit()
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
			Me.button2.FlatAppearance.BorderSize = 0
			Me.button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 15.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.button2.ForeColor = Global.System.Drawing.Color.White
			Me.button2.Location = New Global.System.Drawing.Point(440, 1)
			Me.button2.Name = "button2"
			Me.button2.Size = New Global.System.Drawing.Size(30, 28)
			Me.button2.TabIndex = 2
			Me.button2.Text = "-"
			Me.button2.UseVisualStyleBackColor = True
			AddHandler Me.button2.Click, AddressOf Me.button2_Click
			Me.DragForm.Interval = 1
			AddHandler Me.DragForm.Tick, AddressOf Me.DragForm_Tick
			Me.label1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.label1.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.label1.Location = New Global.System.Drawing.Point(5, 16)
			Me.label1.Name = "label1"
			Me.label1.Size = New Global.System.Drawing.Size(298, 348)
			Me.label1.TabIndex = 3
			Me.label1.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.label2.AutoSize = True
			Me.label2.Font = New Global.System.Drawing.Font("Segoe UI", 8.25F, Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label2.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.label2.Location = New Global.System.Drawing.Point(3, 3)
			Me.label2.Name = "label2"
			Me.label2.Size = New Global.System.Drawing.Size(66, 13)
			Me.label2.TabIndex = 4
			Me.label2.Text = "What's new?"
			Me.label3.AutoSize = True
			Me.label3.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.label3.Location = New Global.System.Drawing.Point(12, 9)
			Me.label3.Name = "label3"
			Me.label3.Size = New Global.System.Drawing.Size(76, 13)
			Me.label3.TabIndex = 5
			Me.label3.Text = "Bleu Launcher"
			Me.label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.panel1.Controls.Add(Me.Changelog)
			Me.panel1.Controls.Add(Me.RegisterButton)
			Me.panel1.Controls.Add(Me.label8)
			Me.panel1.Controls.Add(Me.label7)
			Me.panel1.Controls.Add(Me.label6)
			Me.panel1.Controls.Add(Me.EmailBox)
			Me.panel1.Controls.Add(Me.label5)
			Me.panel1.Controls.Add(Me.KeyBox)
			Me.panel1.Controls.Add(Me.button6)
			Me.panel1.Controls.Add(Me.panel2)
			Me.panel1.Controls.Add(Me.label1)
			Me.panel1.Controls.Add(Me.label2)
			Me.panel1.Location = New Global.System.Drawing.Point(0, 30)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New Global.System.Drawing.Size(1000, 368)
			Me.panel1.TabIndex = 6
			AddHandler Me.panel1.Paint, AddressOf Me.panel1_Paint
			Me.Changelog.Location = New Global.System.Drawing.Point(6, 17)
			Me.Changelog.MinimumSize = New Global.System.Drawing.Size(20, 20)
			Me.Changelog.Name = "Changelog"
			Me.Changelog.ScriptErrorsSuppressed = True
			Me.Changelog.ScrollBarsEnabled = False
			Me.Changelog.Size = New Global.System.Drawing.Size(296, 346)
			Me.Changelog.TabIndex = 14
			Me.Changelog.Url = New Global.System.Uri("http://bleu.cloris.co/Changelog.html", Global.System.UriKind.Absolute)
			Me.RegisterButton.FlatAppearance.BorderColor = Global.System.Drawing.Color.DimGray
			Me.RegisterButton.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.RegisterButton.Font = New Global.System.Drawing.Font("Verdana", 11.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.RegisterButton.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.RegisterButton.Location = New Global.System.Drawing.Point(515, 183)
			Me.RegisterButton.Name = "RegisterButton"
			Me.RegisterButton.Size = New Global.System.Drawing.Size(471, 28)
			Me.RegisterButton.TabIndex = 13
			Me.RegisterButton.Text = "Register Bleu"
			Me.RegisterButton.UseVisualStyleBackColor = True
			AddHandler Me.RegisterButton.Click, AddressOf Me.RegisterButton_Click
			Me.label8.AutoSize = True
			Me.label8.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label8.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.label8.Location = New Global.System.Drawing.Point(512, 115)
			Me.label8.Name = "label8"
			Me.label8.Size = New Global.System.Drawing.Size(454, 20)
			Me.label8.TabIndex = 12
			Me.label8.Text = "Discord ID: (To find it, go in a server and type \@yourusername)" & vbCrLf
			Me.label8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.label7.AutoSize = True
			Me.label7.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label7.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.label7.Location = New Global.System.Drawing.Point(512, 45)
			Me.label7.Name = "label7"
			Me.label7.Size = New Global.System.Drawing.Size(39, 20)
			Me.label7.TabIndex = 11
			Me.label7.Text = "Key:"
			Me.label7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.label6.AutoSize = True
			Me.label6.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label6.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.label6.Location = New Global.System.Drawing.Point(534, 12)
			Me.label6.Name = "label6"
			Me.label6.Size = New Global.System.Drawing.Size(105, 20)
			Me.label6.TabIndex = 7
			Me.label6.Text = "Register Bleu"
			Me.label6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.EmailBox.BackColor = Global.System.Drawing.Color.FromArgb(33, 33, 33)
			Me.EmailBox.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.EmailBox.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.EmailBox.ForeColor = Global.System.Drawing.Color.White
			Me.EmailBox.Location = New Global.System.Drawing.Point(515, 142)
			Me.EmailBox.Name = "EmailBox"
			Me.EmailBox.Size = New Global.System.Drawing.Size(471, 26)
			Me.EmailBox.TabIndex = 10
			Me.label5.Font = New Global.System.Drawing.Font("Segoe UI", 8.25F, Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label5.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.label5.Location = New Global.System.Drawing.Point(512, 278)
			Me.label5.Name = "label5"
			Me.label5.Size = New Global.System.Drawing.Size(474, 81)
			Me.label5.TabIndex = 7
			Me.label5.Text = componentResourceManager.GetString("label5.Text")
			Me.KeyBox.BackColor = Global.System.Drawing.Color.FromArgb(33, 33, 33)
			Me.KeyBox.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.KeyBox.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.KeyBox.ForeColor = Global.System.Drawing.Color.White
			Me.KeyBox.Location = New Global.System.Drawing.Point(515, 74)
			Me.KeyBox.Name = "KeyBox"
			Me.KeyBox.Size = New Global.System.Drawing.Size(471, 26)
			Me.KeyBox.TabIndex = 9
			Me.button6.FlatAppearance.BorderSize = 0
			Me.button6.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button6.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.button6.ForeColor = Global.System.Drawing.Color.White
			Me.button6.Location = New Global.System.Drawing.Point(505, 6)
			Me.button6.Name = "button6"
			Me.button6.Size = New Global.System.Drawing.Size(30, 28)
			Me.button6.TabIndex = 8
			Me.button6.Text = "<"
			Me.button6.UseVisualStyleBackColor = True
			AddHandler Me.button6.Click, AddressOf Me.button6_Click
			Me.panel2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel2.Controls.Add(Me.pictureBox5)
			Me.panel2.Controls.Add(Me.pictureBox4)
			Me.panel2.Controls.Add(Me.pictureBox3)
			Me.panel2.Controls.Add(Me.label4)
			Me.panel2.Controls.Add(Me.button5)
			Me.panel2.Controls.Add(Me.button4)
			Me.panel2.Controls.Add(Me.button3)
			Me.panel2.Controls.Add(Me.pictureBox6)
			Me.panel2.Location = New Global.System.Drawing.Point(309, 16)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New Global.System.Drawing.Size(185, 348)
			Me.panel2.TabIndex = 5
			Me.pictureBox5.BackColor = Global.System.Drawing.Color.Transparent
			Me.pictureBox5.Image = Global.Bleu.Properties.Resources.HelpIcon
			Me.pictureBox5.Location = New Global.System.Drawing.Point(6, 170)
			Me.pictureBox5.Name = "pictureBox5"
			Me.pictureBox5.Size = New Global.System.Drawing.Size(25, 24)
			Me.pictureBox5.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox5.TabIndex = 12
			Me.pictureBox5.TabStop = False
			Me.pictureBox4.BackColor = Global.System.Drawing.Color.Transparent
			Me.pictureBox4.Image = Global.Bleu.Properties.Resources.RegisterIcon
			Me.pictureBox4.Location = New Global.System.Drawing.Point(6, 98)
			Me.pictureBox4.Name = "pictureBox4"
			Me.pictureBox4.Size = New Global.System.Drawing.Size(25, 24)
			Me.pictureBox4.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox4.TabIndex = 11
			Me.pictureBox4.TabStop = False
			Me.pictureBox3.BackColor = Global.System.Drawing.Color.Transparent
			Me.pictureBox3.Image = Global.Bleu.Properties.Resources.[Continue]
			Me.pictureBox3.Location = New Global.System.Drawing.Point(6, 24)
			Me.pictureBox3.Name = "pictureBox3"
			Me.pictureBox3.Size = New Global.System.Drawing.Size(25, 24)
			Me.pictureBox3.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox3.TabIndex = 8
			Me.pictureBox3.TabStop = False
			Me.label4.AutoSize = True
			Me.label4.Font = New Global.System.Drawing.Font("Segoe UI", 8.25F, Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label4.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.label4.Location = New Global.System.Drawing.Point(3, 329)
			Me.label4.Name = "label4"
			Me.label4.Size = New Global.System.Drawing.Size(59, 13)
			Me.label4.TabIndex = 6
			Me.label4.Text = "Bleu v.1.0.2"
			Me.button5.FlatAppearance.BorderColor = Global.System.Drawing.Color.DimGray
			Me.button5.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button5.Font = New Global.System.Drawing.Font("Verdana", 11.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.button5.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.button5.Location = New Global.System.Drawing.Point(3, 148)
			Me.button5.Name = "button5"
			Me.button5.Size = New Global.System.Drawing.Size(177, 66)
			Me.button5.TabIndex = 10
			Me.button5.Text = "     Help"
			Me.button5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.button5.UseVisualStyleBackColor = True
			AddHandler Me.button5.Click, AddressOf Me.button5_Click
			Me.button4.FlatAppearance.BorderColor = Global.System.Drawing.Color.DimGray
			Me.button4.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button4.Font = New Global.System.Drawing.Font("Verdana", 11.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.button4.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.button4.Location = New Global.System.Drawing.Point(3, 76)
			Me.button4.Name = "button4"
			Me.button4.Size = New Global.System.Drawing.Size(177, 66)
			Me.button4.TabIndex = 9
			Me.button4.Text = "     Register Bleu"
			Me.button4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.button4.UseVisualStyleBackColor = True
			AddHandler Me.button4.Click, AddressOf Me.button4_Click
			Me.button3.FlatAppearance.BorderColor = Global.System.Drawing.Color.DimGray
			Me.button3.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button3.Font = New Global.System.Drawing.Font("Verdana", 11.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.button3.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.button3.Location = New Global.System.Drawing.Point(3, 4)
			Me.button3.Name = "button3"
			Me.button3.Size = New Global.System.Drawing.Size(177, 66)
			Me.button3.TabIndex = 8
			Me.button3.Text = "     Continue to Bleu"
			Me.button3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.button3.UseVisualStyleBackColor = True
			AddHandler Me.button3.Click, AddressOf Me.button3_Click
			Me.pictureBox6.BackgroundImage = Global.Bleu.Properties.Resources.EarthChan
			Me.pictureBox6.Image = Global.Bleu.Properties.Resources.logo3
			Me.pictureBox6.Location = New Global.System.Drawing.Point(3, 220)
			Me.pictureBox6.Name = "pictureBox6"
			Me.pictureBox6.Size = New Global.System.Drawing.Size(177, 127)
			Me.pictureBox6.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.pictureBox6.TabIndex = 13
			Me.pictureBox6.TabStop = False
			Me.AnimationTimer.Interval = 1
			AddHandler Me.AnimationTimer.Tick, AddressOf Me.AnimationTimer_Tick
			Me.pictureBox1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.pictureBox1.Location = New Global.System.Drawing.Point(-1, 0)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New Global.System.Drawing.Size(501, 30)
			Me.pictureBox1.TabIndex = 1
			Me.pictureBox1.TabStop = False
			AddHandler Me.pictureBox1.Click, AddressOf Me.pictureBox1_Click
			AddHandler Me.pictureBox1.MouseDown, AddressOf Me.pictureBox1_MouseDown
			AddHandler Me.pictureBox1.MouseUp, AddressOf Me.pictureBox1_MouseUp
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			MyBase.ClientSize = New Global.System.Drawing.Size(498, 398)
			MyBase.ControlBox = False
			MyBase.Controls.Add(Me.panel1)
			MyBase.Controls.Add(Me.label3)
			MyBase.Controls.Add(Me.button2)
			MyBase.Controls.Add(Me.button1)
			MyBase.Controls.Add(Me.pictureBox1)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "Form1"
			MyBase.Opacity = 0.0
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			AddHandler MyBase.Activated, AddressOf Me.Form1_Activated
			AddHandler MyBase.Load, AddressOf Me.Form1_Load
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.panel2.ResumeLayout(False)
			Me.panel2.PerformLayout()
			CType(Me.pictureBox5, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox4, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox3, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox6, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		Private components As Global.System.ComponentModel.IContainer = Nothing

		Private button1 As Global.System.Windows.Forms.Button

		Private pictureBox1 As Global.System.Windows.Forms.PictureBox

		Private button2 As Global.System.Windows.Forms.Button

		Private DragForm As Global.System.Windows.Forms.Timer

		Private label1 As Global.System.Windows.Forms.Label

		Private label2 As Global.System.Windows.Forms.Label

		Private label3 As Global.System.Windows.Forms.Label

		Private panel1 As Global.System.Windows.Forms.Panel

		Private panel2 As Global.System.Windows.Forms.Panel

		Private button3 As Global.System.Windows.Forms.Button

		Private button5 As Global.System.Windows.Forms.Button

		Private button4 As Global.System.Windows.Forms.Button

		Private label4 As Global.System.Windows.Forms.Label

		Private pictureBox5 As Global.System.Windows.Forms.PictureBox

		Private pictureBox4 As Global.System.Windows.Forms.PictureBox

		Private pictureBox3 As Global.System.Windows.Forms.PictureBox

		Private pictureBox6 As Global.System.Windows.Forms.PictureBox

		Private button6 As Global.System.Windows.Forms.Button

		Private AnimationTimer As Global.System.Windows.Forms.Timer

		Private EmailBox As Global.System.Windows.Forms.TextBox

		Private label5 As Global.System.Windows.Forms.Label

		Private KeyBox As Global.System.Windows.Forms.TextBox

		Private label8 As Global.System.Windows.Forms.Label

		Private label7 As Global.System.Windows.Forms.Label

		Private label6 As Global.System.Windows.Forms.Label

		Private RegisterButton As Global.System.Windows.Forms.Button

		Private Changelog As Global.System.Windows.Forms.WebBrowser
	End Class
End Namespace
