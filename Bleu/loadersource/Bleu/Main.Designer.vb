Namespace Bleu
	Public Partial Class Main
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x02000004 RID: 4
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.Bleu.Main))
			Me.AnimationTimer = New Global.System.Windows.Forms.Timer(Me.components)
			Me.panel1 = New Global.System.Windows.Forms.Panel()
			Me.CmdBox = New Global.System.Windows.Forms.TextBox()
			Me.RegisterButton = New Global.System.Windows.Forms.Button()
			Me.splitter1 = New Global.System.Windows.Forms.PictureBox()
			Me.FindPanel = New Global.System.Windows.Forms.Panel()
			Me.ResultLabel = New Global.System.Windows.Forms.Label()
			Me.button21 = New Global.System.Windows.Forms.Button()
			Me.FindForward = New Global.System.Windows.Forms.Button()
			Me.FindBack = New Global.System.Windows.Forms.Button()
			Me.FindClose = New Global.System.Windows.Forms.Button()
			Me.panel3 = New Global.System.Windows.Forms.Panel()
			Me.FindBox = New Global.System.Windows.Forms.TextBox()
			Me.scintilla1 = New Global.ScintillaNET.Scintilla()
			Me.searchScriptBox = New Global.System.Windows.Forms.TextBox()
			Me.scriptBox = New Global.System.Windows.Forms.ListBox()
			Me.saveFileDialog1 = New Global.System.Windows.Forms.SaveFileDialog()
			Me.OpenFileDialog1 = New Global.System.Windows.Forms.OpenFileDialog()
			Me.Injector = New Global.System.Windows.Forms.Timer(Me.components)
			Me.contextMenuStrip1 = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.ohToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.moonyToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.sADMARGToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.aFewLeavestoGoInASaladToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator1 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.redToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.bleuToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.bleuToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.windows98ToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.OutputCheck = New Global.System.Windows.Forms.Timer(Me.components)
			Me.menuStrip1 = New Global.System.Windows.Forms.MenuStrip()
			Me.bleuToolStripMenuItem2 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.themesToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.saveToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.saveAsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.openToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.exitToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.editToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.undoToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.redoToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.selectAllToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.cutToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.copyToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.pasteToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.viewToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.environmentToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.scriptListToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.scriptLibraryToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.scriptWareUIToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.themesToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem9 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem10 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem11 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem12 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem13 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem14 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem15 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem16 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.outputToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.rOBLOXToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.scriptsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.inGameTopBarToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.dexToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.otherScriptsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.infiniteYieldToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.remoteSpyToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.topKek75ToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.roXploit61ToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.zinniaKickToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.rainingSeagullsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.nonFEGamesToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.killRobloxToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.doNotClickOnThisToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.loadHackToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.newExecutionToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.wrapperToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.trustCheckToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.extendedEnvToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.outputErrorsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CmdMatches = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.PissOff = New Global.System.Windows.Forms.Timer(Me.components)
			Me.button19 = New Global.System.Windows.Forms.Button()
			Me.panel1.SuspendLayout()
			CType(Me.splitter1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.FindPanel.SuspendLayout()
			Me.contextMenuStrip1.SuspendLayout()
			Me.menuStrip1.SuspendLayout()
			MyBase.SuspendLayout()
			Me.AnimationTimer.Interval = 1
			AddHandler Me.AnimationTimer.Tick, AddressOf Me.AnimationTimer_Tick
			Me.panel1.Controls.Add(Me.CmdBox)
			Me.panel1.Controls.Add(Me.RegisterButton)
			Me.panel1.Controls.Add(Me.splitter1)
			Me.panel1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.panel1.Location = New Global.System.Drawing.Point(0, 313)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New Global.System.Drawing.Size(507, 22)
			Me.panel1.TabIndex = 18
			AddHandler Me.panel1.Paint, AddressOf Me.panel1_Paint
			Me.CmdBox.Anchor = Global.System.Windows.Forms.AnchorStyles.Right
			Me.CmdBox.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.CmdBox.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.CmdBox.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.CmdBox.ForeColor = Global.System.Drawing.Color.FromArgb(224, 244, 244)
			Me.CmdBox.Location = New Global.System.Drawing.Point(377, 1)
			Me.CmdBox.MaxLength = 500
			Me.CmdBox.Name = "CmdBox"
			Me.CmdBox.Size = New Global.System.Drawing.Size(128, 20)
			Me.CmdBox.TabIndex = 40
			Me.CmdBox.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			AddHandler Me.CmdBox.TextChanged, AddressOf Me.CmdBox_TextChanged
			AddHandler Me.CmdBox.KeyDown, AddressOf Me.CmdBox_KeyDown
			AddHandler Me.CmdBox.KeyPress, AddressOf Me.CmdBox_KeyPress
			AddHandler Me.CmdBox.Leave, AddressOf Me.CmdBox_Leave
			Me.RegisterButton.FlatAppearance.BorderColor = Global.System.Drawing.Color.DimGray
			Me.RegisterButton.FlatAppearance.BorderSize = 0
			Me.RegisterButton.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.RegisterButton.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.RegisterButton.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.RegisterButton.Image = Global.Bleu.Properties.Resources.play
			Me.RegisterButton.ImageAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.RegisterButton.Location = New Global.System.Drawing.Point(1, 0)
			Me.RegisterButton.Name = "RegisterButton"
			Me.RegisterButton.Size = New Global.System.Drawing.Size(73, 20)
			Me.RegisterButton.TabIndex = 14
			Me.RegisterButton.Text = "Execute"
			Me.RegisterButton.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.RegisterButton.UseVisualStyleBackColor = True
			AddHandler Me.RegisterButton.Click, AddressOf Me.RegisterButton_Click
			Me.splitter1.BackColor = Global.System.Drawing.Color.Gray
			Me.splitter1.Location = New Global.System.Drawing.Point(75, 7)
			Me.splitter1.Name = "splitter1"
			Me.splitter1.Size = New Global.System.Drawing.Size(1, 8)
			Me.splitter1.TabIndex = 15
			Me.splitter1.TabStop = False
			Me.FindPanel.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.FindPanel.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.FindPanel.Controls.Add(Me.ResultLabel)
			Me.FindPanel.Controls.Add(Me.button21)
			Me.FindPanel.Controls.Add(Me.FindForward)
			Me.FindPanel.Controls.Add(Me.FindBack)
			Me.FindPanel.Controls.Add(Me.FindClose)
			Me.FindPanel.Controls.Add(Me.panel3)
			Me.FindPanel.Controls.Add(Me.FindBox)
			Me.FindPanel.Location = New Global.System.Drawing.Point(227, 26)
			Me.FindPanel.Name = "FindPanel"
			Me.FindPanel.Size = New Global.System.Drawing.Size(280, 51)
			Me.FindPanel.TabIndex = 36
			Me.FindPanel.Visible = False
			Me.ResultLabel.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ResultLabel.AutoSize = True
			Me.ResultLabel.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.ResultLabel.ForeColor = Global.System.Drawing.Color.Black
			Me.ResultLabel.Location = New Global.System.Drawing.Point(47, 28)
			Me.ResultLabel.Name = "ResultLabel"
			Me.ResultLabel.Size = New Global.System.Drawing.Size(0, 13)
			Me.ResultLabel.TabIndex = 19
			Me.button21.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.button21.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.button21.BackgroundImage = Global.Bleu.Properties.Resources.match_case
			Me.button21.FlatAppearance.BorderColor = Global.System.Drawing.SystemColors.Control
			Me.button21.FlatAppearance.BorderSize = 0
			Me.button21.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button21.Location = New Global.System.Drawing.Point(24, 28)
			Me.button21.Name = "button21"
			Me.button21.Size = New Global.System.Drawing.Size(17, 17)
			Me.button21.TabIndex = 36
			Me.button21.UseVisualStyleBackColor = False
			AddHandler Me.button21.Click, AddressOf Me.button14_Click
			Me.FindForward.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.FindForward.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.FindForward.BackgroundImage = Global.Bleu.Properties.Resources.arrowright_black_16
			Me.FindForward.FlatAppearance.BorderColor = Global.System.Drawing.SystemColors.Control
			Me.FindForward.FlatAppearance.BorderSize = 0
			Me.FindForward.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.FindForward.Location = New Global.System.Drawing.Point(237, 8)
			Me.FindForward.Name = "FindForward"
			Me.FindForward.Size = New Global.System.Drawing.Size(17, 17)
			Me.FindForward.TabIndex = 35
			Me.FindForward.UseVisualStyleBackColor = False
			AddHandler Me.FindForward.Click, AddressOf Me.FindForward_Click
			Me.FindBack.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.FindBack.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.FindBack.BackgroundImage = Global.Bleu.Properties.Resources.arrowleft_black_16
			Me.FindBack.FlatAppearance.BorderColor = Global.System.Drawing.SystemColors.Control
			Me.FindBack.FlatAppearance.BorderSize = 0
			Me.FindBack.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.FindBack.Location = New Global.System.Drawing.Point(216, 8)
			Me.FindBack.Name = "FindBack"
			Me.FindBack.Size = New Global.System.Drawing.Size(17, 17)
			Me.FindBack.TabIndex = 34
			Me.FindBack.UseVisualStyleBackColor = False
			AddHandler Me.FindBack.Click, AddressOf Me.FindBack_Click
			Me.FindClose.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.FindClose.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.FindClose.BackgroundImage = Global.Bleu.Properties.Resources.delete_x_16_b
			Me.FindClose.FlatAppearance.BorderColor = Global.System.Drawing.SystemColors.Control
			Me.FindClose.FlatAppearance.BorderSize = 0
			Me.FindClose.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.FindClose.Location = New Global.System.Drawing.Point(260, 8)
			Me.FindClose.Name = "FindClose"
			Me.FindClose.Size = New Global.System.Drawing.Size(17, 17)
			Me.FindClose.TabIndex = 18
			Me.FindClose.UseVisualStyleBackColor = False
			AddHandler Me.FindClose.Click, AddressOf Me.FindClose_Click
			Me.panel3.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.panel3.BackColor = Global.System.Drawing.Color.FromArgb(64, 64, 64)
			Me.panel3.Location = New Global.System.Drawing.Point(1, 47)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New Global.System.Drawing.Size(280, 4)
			Me.panel3.TabIndex = 33
			Me.FindBox.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.FindBox.BackColor = Global.System.Drawing.Color.White
			Me.FindBox.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.FindBox.Location = New Global.System.Drawing.Point(24, 5)
			Me.FindBox.Name = "FindBox"
			Me.FindBox.Size = New Global.System.Drawing.Size(192, 20)
			Me.FindBox.TabIndex = 17
			Me.FindBox.Tag = ""
			AddHandler Me.FindBox.TextChanged, AddressOf Me.FindBox_TextChanged
			AddHandler Me.FindBox.KeyDown, AddressOf Me.FindBox_KeyDown
			Me.scintilla1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.scintilla1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.scintilla1.Lexer = Global.ScintillaNET.Lexer.Lua
			Me.scintilla1.Location = New Global.System.Drawing.Point(0, 19)
			Me.scintilla1.Name = "scintilla1"
			Me.scintilla1.Size = New Global.System.Drawing.Size(507, 295)
			Me.scintilla1.TabIndex = 2
			AddHandler Me.scintilla1.TextChanged, AddressOf Me.scintilla1_TextChanged
			AddHandler Me.scintilla1.Click, AddressOf Me.scintilla1_Click
			AddHandler Me.scintilla1.KeyDown, AddressOf Me.scintilla1_KeyDown
			Me.searchScriptBox.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.searchScriptBox.Location = New Global.System.Drawing.Point(343, 23)
			Me.searchScriptBox.Name = "searchScriptBox"
			Me.searchScriptBox.Size = New Global.System.Drawing.Size(162, 20)
			Me.searchScriptBox.TabIndex = 38
			AddHandler Me.searchScriptBox.TextChanged, AddressOf Me.searchScriptBox_TextChanged
			Me.scriptBox.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.scriptBox.FormattingEnabled = True
			Me.scriptBox.Location = New Global.System.Drawing.Point(343, 49)
			Me.scriptBox.Name = "scriptBox"
			Me.scriptBox.Size = New Global.System.Drawing.Size(162, 264)
			Me.scriptBox.TabIndex = 37
			AddHandler Me.scriptBox.SelectedIndexChanged, AddressOf Me.scriptBox_SelectedIndexChanged
			Me.saveFileDialog1.Filter = "Lua files|*.lua;*.txt|All files|*.*"
			Me.saveFileDialog1.Title = "Save Script"
			Me.OpenFileDialog1.AddExtension = False
			Me.OpenFileDialog1.Filter = "Lua files|*.lua;*.txt|All files|*.*"
			Me.OpenFileDialog1.SupportMultiDottedExtensions = True
			Me.OpenFileDialog1.Title = "Open Script"
			AddHandler Me.Injector.Tick, AddressOf Me.Injector_Tick
			Me.contextMenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.ohToolStripMenuItem, Me.moonyToolStripMenuItem, Me.sADMARGToolStripMenuItem, Me.aFewLeavestoGoInASaladToolStripMenuItem, Me.toolStripSeparator1, Me.redToolStripMenuItem, Me.bleuToolStripMenuItem, Me.bleuToolStripMenuItem1, Me.windows98ToolStripMenuItem })
			Me.contextMenuStrip1.Name = "contextMenuStrip1"
			Me.contextMenuStrip1.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.System
			Me.contextMenuStrip1.Size = New Global.System.Drawing.Size(229, 186)
			Me.ohToolStripMenuItem.Image = Global.Bleu.Properties.Resources.Zinnia
			Me.ohToolStripMenuItem.Name = "ohToolStripMenuItem"
			Me.ohToolStripMenuItem.Size = New Global.System.Drawing.Size(228, 22)
			Me.ohToolStripMenuItem.Text = "Zinnia"
			Me.moonyToolStripMenuItem.Image = Global.Bleu.Properties.Resources.moon
			Me.moonyToolStripMenuItem.Name = "moonyToolStripMenuItem"
			Me.moonyToolStripMenuItem.Size = New Global.System.Drawing.Size(228, 22)
			Me.moonyToolStripMenuItem.Text = "Moony (my baby)"
			Me.sADMARGToolStripMenuItem.Image = Global.Bleu.Properties.Resources._4dc13fd52f691020a1308c5b6cbc6f49
			Me.sADMARGToolStripMenuItem.Name = "sADMARGToolStripMenuItem"
			Me.sADMARGToolStripMenuItem.Size = New Global.System.Drawing.Size(228, 22)
			Me.sADMARGToolStripMenuItem.Text = "SAD MARG"
			Me.aFewLeavestoGoInASaladToolStripMenuItem.Image = Global.Bleu.Properties.Resources.default_20
			Me.aFewLeavestoGoInASaladToolStripMenuItem.Name = "aFewLeavestoGoInASaladToolStripMenuItem"
			Me.aFewLeavestoGoInASaladToolStripMenuItem.Size = New Global.System.Drawing.Size(228, 22)
			Me.aFewLeavestoGoInASaladToolStripMenuItem.Text = "a few leaves (to go in a salad)"
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New Global.System.Drawing.Size(225, 6)
			Me.redToolStripMenuItem.Image = Global.Bleu.Properties.Resources.record
			Me.redToolStripMenuItem.Name = "redToolStripMenuItem"
			Me.redToolStripMenuItem.Size = New Global.System.Drawing.Size(228, 22)
			Me.redToolStripMenuItem.Text = "Red"
			Me.bleuToolStripMenuItem.Image = Global.Bleu.Properties.Resources.recycle
			Me.bleuToolStripMenuItem.Name = "bleuToolStripMenuItem"
			Me.bleuToolStripMenuItem.Size = New Global.System.Drawing.Size(228, 22)
			Me.bleuToolStripMenuItem.Text = "Green"
			Me.bleuToolStripMenuItem1.Image = Global.Bleu.Properties.Resources.Blue_Material
			Me.bleuToolStripMenuItem1.Name = "bleuToolStripMenuItem1"
			Me.bleuToolStripMenuItem1.Size = New Global.System.Drawing.Size(228, 22)
			Me.bleuToolStripMenuItem1.Text = "Bleu"
			Me.windows98ToolStripMenuItem.Image = Global.Bleu.Properties.Resources.icon
			Me.windows98ToolStripMenuItem.Name = "windows98ToolStripMenuItem"
			Me.windows98ToolStripMenuItem.Size = New Global.System.Drawing.Size(228, 22)
			Me.windows98ToolStripMenuItem.Text = "Windows 95"
			Me.OutputCheck.Interval = 50
			AddHandler Me.OutputCheck.Tick, AddressOf Me.OutputCheck_Tick
			Me.menuStrip1.AutoSize = False
			Me.menuStrip1.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.menuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.bleuToolStripMenuItem2, Me.editToolStripMenuItem, Me.viewToolStripMenuItem, Me.rOBLOXToolStripMenuItem, Me.loadHackToolStripMenuItem })
			Me.menuStrip1.Location = New Global.System.Drawing.Point(0, 0)
			Me.menuStrip1.Name = "menuStrip1"
			Me.menuStrip1.Size = New Global.System.Drawing.Size(507, 19)
			Me.menuStrip1.TabIndex = 20
			Me.menuStrip1.Text = "menuStrip1"
			Me.bleuToolStripMenuItem2.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.themesToolStripMenuItem, Me.saveToolStripMenuItem, Me.saveAsToolStripMenuItem, Me.openToolStripMenuItem, Me.exitToolStripMenuItem })
			Me.bleuToolStripMenuItem2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.bleuToolStripMenuItem2.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.bleuToolStripMenuItem2.Name = "bleuToolStripMenuItem2"
			Me.bleuToolStripMenuItem2.Size = New Global.System.Drawing.Size(40, 15)
			Me.bleuToolStripMenuItem2.Text = "Bleu"
			Me.themesToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.themesToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.themesToolStripMenuItem.Image = Global.Bleu.Properties.Resources.new_document_16
			Me.themesToolStripMenuItem.Name = "themesToolStripMenuItem"
			Me.themesToolStripMenuItem.Size = New Global.System.Drawing.Size(114, 22)
			Me.themesToolStripMenuItem.Text = "New"
			AddHandler Me.themesToolStripMenuItem.Click, AddressOf Me.themesToolStripMenuItem_Click
			Me.saveToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.saveToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.saveToolStripMenuItem.Image = Global.Bleu.Properties.Resources.save_16
			Me.saveToolStripMenuItem.Name = "saveToolStripMenuItem"
			Me.saveToolStripMenuItem.Size = New Global.System.Drawing.Size(114, 22)
			Me.saveToolStripMenuItem.Text = "Save"
			AddHandler Me.saveToolStripMenuItem.Click, AddressOf Me.saveToolStripMenuItem_Click
			Me.saveAsToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.saveAsToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.saveAsToolStripMenuItem.Image = Global.Bleu.Properties.Resources.save_green_16
			Me.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem"
			Me.saveAsToolStripMenuItem.Size = New Global.System.Drawing.Size(114, 22)
			Me.saveAsToolStripMenuItem.Text = "Save As"
			AddHandler Me.saveAsToolStripMenuItem.Click, AddressOf Me.saveAsToolStripMenuItem_Click
			Me.openToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.openToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.openToolStripMenuItem.Image = Global.Bleu.Properties.Resources.open_document_16_h
			Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
			Me.openToolStripMenuItem.Size = New Global.System.Drawing.Size(114, 22)
			Me.openToolStripMenuItem.Text = "Open"
			AddHandler Me.openToolStripMenuItem.Click, AddressOf Me.openToolStripMenuItem_Click
			Me.exitToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.exitToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.exitToolStripMenuItem.Image = Global.Bleu.Properties.Resources.delete_x_16
			Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
			Me.exitToolStripMenuItem.Size = New Global.System.Drawing.Size(114, 22)
			Me.exitToolStripMenuItem.Text = "Close"
			AddHandler Me.exitToolStripMenuItem.Click, AddressOf Me.exitToolStripMenuItem_Click
			Me.editToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.undoToolStripMenuItem, Me.redoToolStripMenuItem, Me.selectAllToolStripMenuItem, Me.cutToolStripMenuItem, Me.copyToolStripMenuItem, Me.pasteToolStripMenuItem })
			Me.editToolStripMenuItem.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.editToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.editToolStripMenuItem.Name = "editToolStripMenuItem"
			Me.editToolStripMenuItem.Size = New Global.System.Drawing.Size(37, 15)
			Me.editToolStripMenuItem.Text = "Edit"
			Me.undoToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.undoToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.undoToolStripMenuItem.Image = Global.Bleu.Properties.Resources.undo_16
			Me.undoToolStripMenuItem.Name = "undoToolStripMenuItem"
			Me.undoToolStripMenuItem.Size = New Global.System.Drawing.Size(118, 22)
			Me.undoToolStripMenuItem.Text = "Undo"
			AddHandler Me.undoToolStripMenuItem.Click, AddressOf Me.undoToolStripMenuItem_Click
			Me.redoToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.redoToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.redoToolStripMenuItem.Image = Global.Bleu.Properties.Resources.redo_16
			Me.redoToolStripMenuItem.Name = "redoToolStripMenuItem"
			Me.redoToolStripMenuItem.Size = New Global.System.Drawing.Size(118, 22)
			Me.redoToolStripMenuItem.Text = "Redo"
			AddHandler Me.redoToolStripMenuItem.Click, AddressOf Me.redoToolStripMenuItem_Click
			Me.selectAllToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.selectAllToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.selectAllToolStripMenuItem.Image = Global.Bleu.Properties.Resources.select_16x16
			Me.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem"
			Me.selectAllToolStripMenuItem.Size = New Global.System.Drawing.Size(118, 22)
			Me.selectAllToolStripMenuItem.Text = "Select All"
			AddHandler Me.selectAllToolStripMenuItem.Click, AddressOf Me.selectAllToolStripMenuItem_Click
			Me.cutToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.cutToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.cutToolStripMenuItem.Image = Global.Bleu.Properties.Resources.Cut_16x16
			Me.cutToolStripMenuItem.Name = "cutToolStripMenuItem"
			Me.cutToolStripMenuItem.Size = New Global.System.Drawing.Size(118, 22)
			Me.cutToolStripMenuItem.Text = "Cut"
			AddHandler Me.cutToolStripMenuItem.Click, AddressOf Me.cutToolStripMenuItem_Click
			Me.copyToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.copyToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.copyToolStripMenuItem.Image = Global.Bleu.Properties.Resources.Copy_16x16
			Me.copyToolStripMenuItem.Name = "copyToolStripMenuItem"
			Me.copyToolStripMenuItem.Size = New Global.System.Drawing.Size(118, 22)
			Me.copyToolStripMenuItem.Text = "Copy"
			AddHandler Me.copyToolStripMenuItem.Click, AddressOf Me.copyToolStripMenuItem_Click
			Me.pasteToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.pasteToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.pasteToolStripMenuItem.Image = Global.Bleu.Properties.Resources.paste_16x16
			Me.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem"
			Me.pasteToolStripMenuItem.Size = New Global.System.Drawing.Size(118, 22)
			Me.pasteToolStripMenuItem.Text = "Paste"
			AddHandler Me.pasteToolStripMenuItem.Click, AddressOf Me.pasteToolStripMenuItem_Click
			Me.viewToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.environmentToolStripMenuItem, Me.scriptListToolStripMenuItem, Me.scriptLibraryToolStripMenuItem, Me.scriptWareUIToolStripMenuItem, Me.themesToolStripMenuItem1, Me.outputToolStripMenuItem })
			Me.viewToolStripMenuItem.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.viewToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.viewToolStripMenuItem.Name = "viewToolStripMenuItem"
			Me.viewToolStripMenuItem.Size = New Global.System.Drawing.Size(42, 15)
			Me.viewToolStripMenuItem.Text = "View"
			Me.environmentToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.environmentToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.environmentToolStripMenuItem.Image = Global.Bleu.Properties.Resources.publish_open
			Me.environmentToolStripMenuItem.Name = "environmentToolStripMenuItem"
			Me.environmentToolStripMenuItem.Size = New Global.System.Drawing.Size(254, 22)
			Me.environmentToolStripMenuItem.Text = "Environment"
			AddHandler Me.environmentToolStripMenuItem.Click, AddressOf Me.environmentToolStripMenuItem_Click
			Me.scriptListToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.scriptListToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.scriptListToolStripMenuItem.Image = Global.Bleu.Properties.Resources.text_toggle_comment
			Me.scriptListToolStripMenuItem.Name = "scriptListToolStripMenuItem"
			Me.scriptListToolStripMenuItem.Size = New Global.System.Drawing.Size(254, 22)
			Me.scriptListToolStripMenuItem.Text = "Script List"
			AddHandler Me.scriptListToolStripMenuItem.Click, AddressOf Me.scriptListToolStripMenuItem_Click
			Me.scriptLibraryToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.scriptLibraryToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.scriptLibraryToolStripMenuItem.Image = Global.Bleu.Properties.Resources.ScriptPreview_16x
			Me.scriptLibraryToolStripMenuItem.Name = "scriptLibraryToolStripMenuItem"
			Me.scriptLibraryToolStripMenuItem.Size = New Global.System.Drawing.Size(254, 22)
			Me.scriptLibraryToolStripMenuItem.Text = "Script Library"
			AddHandler Me.scriptLibraryToolStripMenuItem.Click, AddressOf Me.scriptLibraryToolStripMenuItem_Click
			Me.scriptWareUIToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.scriptWareUIToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.scriptWareUIToolStripMenuItem.Image = Global.Bleu.Properties.Resources.f71a48ebe4ebb6c0fb771721248d7523
			Me.scriptWareUIToolStripMenuItem.Name = "scriptWareUIToolStripMenuItem"
			Me.scriptWareUIToolStripMenuItem.Size = New Global.System.Drawing.Size(254, 22)
			Me.scriptWareUIToolStripMenuItem.Text = "Script-Ware UI (AZULX GAVE PERM)"
			AddHandler Me.scriptWareUIToolStripMenuItem.Click, AddressOf Me.scriptWareUIToolStripMenuItem_Click
			Me.themesToolStripMenuItem1.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.themesToolStripMenuItem1.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.toolStripMenuItem9, Me.toolStripMenuItem10, Me.toolStripMenuItem11, Me.toolStripMenuItem12, Me.toolStripMenuItem13, Me.toolStripMenuItem14, Me.toolStripMenuItem15, Me.toolStripMenuItem16 })
			Me.themesToolStripMenuItem1.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.themesToolStripMenuItem1.Image = Global.Bleu.Properties.Resources.Zinnia
			Me.themesToolStripMenuItem1.Name = "themesToolStripMenuItem1"
			Me.themesToolStripMenuItem1.Size = New Global.System.Drawing.Size(254, 22)
			Me.themesToolStripMenuItem1.Text = "Themes"
			Me.toolStripMenuItem9.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.toolStripMenuItem9.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.toolStripMenuItem9.Image = Global.Bleu.Properties.Resources.Zinnia
			Me.toolStripMenuItem9.Name = "toolStripMenuItem9"
			Me.toolStripMenuItem9.Size = New Global.System.Drawing.Size(133, 22)
			Me.toolStripMenuItem9.Text = "Zinnia"
			AddHandler Me.toolStripMenuItem9.Click, AddressOf Me.toolStripMenuItem9_Click
			Me.toolStripMenuItem10.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.toolStripMenuItem10.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.toolStripMenuItem10.Image = Global.Bleu.Properties.Resources.moon
			Me.toolStripMenuItem10.Name = "toolStripMenuItem10"
			Me.toolStripMenuItem10.Size = New Global.System.Drawing.Size(133, 22)
			Me.toolStripMenuItem10.Text = "Moon"
			AddHandler Me.toolStripMenuItem10.Click, AddressOf Me.toolStripMenuItem10_Click
			Me.toolStripMenuItem11.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.toolStripMenuItem11.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.toolStripMenuItem11.Image = Global.Bleu.Properties.Resources._4dc13fd52f691020a1308c5b6cbc6f49
			Me.toolStripMenuItem11.Name = "toolStripMenuItem11"
			Me.toolStripMenuItem11.Size = New Global.System.Drawing.Size(133, 22)
			Me.toolStripMenuItem11.Text = "Margaret"
			AddHandler Me.toolStripMenuItem11.Click, AddressOf Me.toolStripMenuItem11_Click
			Me.toolStripMenuItem12.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.toolStripMenuItem12.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.toolStripMenuItem12.Image = Global.Bleu.Properties.Resources.default_20
			Me.toolStripMenuItem12.Name = "toolStripMenuItem12"
			Me.toolStripMenuItem12.Size = New Global.System.Drawing.Size(133, 22)
			Me.toolStripMenuItem12.Text = "Autumn"
			AddHandler Me.toolStripMenuItem12.Click, AddressOf Me.toolStripMenuItem12_Click
			Me.toolStripMenuItem13.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.toolStripMenuItem13.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.toolStripMenuItem13.Image = Global.Bleu.Properties.Resources.record
			Me.toolStripMenuItem13.Name = "toolStripMenuItem13"
			Me.toolStripMenuItem13.Size = New Global.System.Drawing.Size(133, 22)
			Me.toolStripMenuItem13.Text = "Red"
			AddHandler Me.toolStripMenuItem13.Click, AddressOf Me.toolStripMenuItem13_Click
			Me.toolStripMenuItem14.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.toolStripMenuItem14.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.toolStripMenuItem14.Image = Global.Bleu.Properties.Resources.recycle
			Me.toolStripMenuItem14.Name = "toolStripMenuItem14"
			Me.toolStripMenuItem14.Size = New Global.System.Drawing.Size(133, 22)
			Me.toolStripMenuItem14.Text = "Green"
			AddHandler Me.toolStripMenuItem14.Click, AddressOf Me.toolStripMenuItem14_Click
			Me.toolStripMenuItem15.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.toolStripMenuItem15.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.toolStripMenuItem15.Image = Global.Bleu.Properties.Resources.Blue_Material
			Me.toolStripMenuItem15.Name = "toolStripMenuItem15"
			Me.toolStripMenuItem15.Size = New Global.System.Drawing.Size(133, 22)
			Me.toolStripMenuItem15.Text = "Bleu"
			AddHandler Me.toolStripMenuItem15.Click, AddressOf Me.toolStripMenuItem15_Click
			Me.toolStripMenuItem16.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.toolStripMenuItem16.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.toolStripMenuItem16.Image = Global.Bleu.Properties.Resources.icon
			Me.toolStripMenuItem16.Name = "toolStripMenuItem16"
			Me.toolStripMenuItem16.Size = New Global.System.Drawing.Size(133, 22)
			Me.toolStripMenuItem16.Text = "Windows 95"
			AddHandler Me.toolStripMenuItem16.Click, AddressOf Me.toolStripMenuItem16_Click
			Me.outputToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.outputToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.outputToolStripMenuItem.Image = Global.Bleu.Properties.Resources.Output
			Me.outputToolStripMenuItem.Name = "outputToolStripMenuItem"
			Me.outputToolStripMenuItem.Size = New Global.System.Drawing.Size(254, 22)
			Me.outputToolStripMenuItem.Text = "Output"
			AddHandler Me.outputToolStripMenuItem.Click, AddressOf Me.outputToolStripMenuItem_Click
			Me.rOBLOXToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.scriptsToolStripMenuItem, Me.inGameTopBarToolStripMenuItem, Me.dexToolStripMenuItem, Me.otherScriptsToolStripMenuItem, Me.nonFEGamesToolStripMenuItem, Me.killRobloxToolStripMenuItem, Me.doNotClickOnThisToolStripMenuItem })
			Me.rOBLOXToolStripMenuItem.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.rOBLOXToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 244)
			Me.rOBLOXToolStripMenuItem.Name = "rOBLOXToolStripMenuItem"
			Me.rOBLOXToolStripMenuItem.Size = New Global.System.Drawing.Size(47, 15)
			Me.rOBLOXToolStripMenuItem.Text = "Game"
			Me.scriptsToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.scriptsToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.scriptsToolStripMenuItem.Image = Global.Bleu.Properties.Resources.screengui
			Me.scriptsToolStripMenuItem.Name = "scriptsToolStripMenuItem"
			Me.scriptsToolStripMenuItem.Size = New Global.System.Drawing.Size(156, 22)
			Me.scriptsToolStripMenuItem.Text = "In-Game Window"
			AddHandler Me.scriptsToolStripMenuItem.Click, AddressOf Me.scriptsToolStripMenuItem_Click
			Me.inGameTopBarToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.inGameTopBarToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.inGameTopBarToolStripMenuItem.Image = Global.Bleu.Properties.Resources.SelectAll_16x
			Me.inGameTopBarToolStripMenuItem.Name = "inGameTopBarToolStripMenuItem"
			Me.inGameTopBarToolStripMenuItem.Size = New Global.System.Drawing.Size(156, 22)
			Me.inGameTopBarToolStripMenuItem.Text = "In-Game TopBar"
			AddHandler Me.inGameTopBarToolStripMenuItem.Click, AddressOf Me.inGameTopBarToolStripMenuItem_Click
			Me.dexToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.dexToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.dexToolStripMenuItem.Image = Global.Bleu.Properties.Resources.Explorer_16x16
			Me.dexToolStripMenuItem.Name = "dexToolStripMenuItem"
			Me.dexToolStripMenuItem.Size = New Global.System.Drawing.Size(156, 22)
			Me.dexToolStripMenuItem.Text = "Dex"
			AddHandler Me.dexToolStripMenuItem.Click, AddressOf Me.dexToolStripMenuItem_Click
			Me.otherScriptsToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.otherScriptsToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.infiniteYieldToolStripMenuItem, Me.remoteSpyToolStripMenuItem, Me.topKek75ToolStripMenuItem, Me.roXploit61ToolStripMenuItem, Me.zinniaKickToolStripMenuItem, Me.rainingSeagullsToolStripMenuItem })
			Me.otherScriptsToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.otherScriptsToolStripMenuItem.Image = Global.Bleu.Properties.Resources.script_source_setting
			Me.otherScriptsToolStripMenuItem.Name = "otherScriptsToolStripMenuItem"
			Me.otherScriptsToolStripMenuItem.Size = New Global.System.Drawing.Size(156, 22)
			Me.otherScriptsToolStripMenuItem.Text = "More Scripts"
			AddHandler Me.otherScriptsToolStripMenuItem.Click, AddressOf Me.otherScriptsToolStripMenuItem_Click
			Me.infiniteYieldToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.infiniteYieldToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.infiniteYieldToolStripMenuItem.Image = Global.Bleu.Properties.Resources.IY
			Me.infiniteYieldToolStripMenuItem.Name = "infiniteYieldToolStripMenuItem"
			Me.infiniteYieldToolStripMenuItem.Size = New Global.System.Drawing.Size(153, 22)
			Me.infiniteYieldToolStripMenuItem.Text = "Infinite Yield"
			AddHandler Me.infiniteYieldToolStripMenuItem.Click, AddressOf Me.infiniteYieldToolStripMenuItem_Click
			Me.remoteSpyToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.remoteSpyToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.remoteSpyToolStripMenuItem.Image = Global.Bleu.Properties.Resources.R2S
			Me.remoteSpyToolStripMenuItem.Name = "remoteSpyToolStripMenuItem"
			Me.remoteSpyToolStripMenuItem.Size = New Global.System.Drawing.Size(153, 22)
			Me.remoteSpyToolStripMenuItem.Text = "Remote 2 Script"
			AddHandler Me.remoteSpyToolStripMenuItem.Click, AddressOf Me.remoteSpyToolStripMenuItem_Click
			Me.topKek75ToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.topKek75ToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.topKek75ToolStripMenuItem.Image = Global.Bleu.Properties.Resources.K3K
			Me.topKek75ToolStripMenuItem.Name = "topKek75ToolStripMenuItem"
			Me.topKek75ToolStripMenuItem.Size = New Global.System.Drawing.Size(153, 22)
			Me.topKek75ToolStripMenuItem.Text = "TopK3K v4"
			AddHandler Me.topKek75ToolStripMenuItem.Click, AddressOf Me.topKek75ToolStripMenuItem_Click
			Me.roXploit61ToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.roXploit61ToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.roXploit61ToolStripMenuItem.Image = Global.Bleu.Properties.Resources.krystal
			Me.roXploit61ToolStripMenuItem.Name = "roXploit61ToolStripMenuItem"
			Me.roXploit61ToolStripMenuItem.Size = New Global.System.Drawing.Size(153, 22)
			Me.roXploit61ToolStripMenuItem.Text = "Ro-Xploit 6.0"
			AddHandler Me.roXploit61ToolStripMenuItem.Click, AddressOf Me.roXploit61ToolStripMenuItem_Click
			Me.zinniaKickToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.zinniaKickToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.zinniaKickToolStripMenuItem.Image = Global.Bleu.Properties.Resources.Zinnia
			Me.zinniaKickToolStripMenuItem.Name = "zinniaKickToolStripMenuItem"
			Me.zinniaKickToolStripMenuItem.Size = New Global.System.Drawing.Size(153, 22)
			Me.zinniaKickToolStripMenuItem.Text = "Zinnia Kick"
			AddHandler Me.zinniaKickToolStripMenuItem.Click, AddressOf Me.zinniaKickToolStripMenuItem_Click
			Me.rainingSeagullsToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.rainingSeagullsToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.rainingSeagullsToolStripMenuItem.Image = Global.Bleu.Properties.Resources.seagull
			Me.rainingSeagullsToolStripMenuItem.Name = "rainingSeagullsToolStripMenuItem"
			Me.rainingSeagullsToolStripMenuItem.Size = New Global.System.Drawing.Size(153, 22)
			Me.rainingSeagullsToolStripMenuItem.Text = "Raining Seagulls"
			AddHandler Me.rainingSeagullsToolStripMenuItem.Click, AddressOf Me.rainingSeagullsToolStripMenuItem_Click
			Me.nonFEGamesToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.nonFEGamesToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.nonFEGamesToolStripMenuItem.Image = Global.Bleu.Properties.Resources.NotExecuted_16x
			Me.nonFEGamesToolStripMenuItem.Name = "nonFEGamesToolStripMenuItem"
			Me.nonFEGamesToolStripMenuItem.Size = New Global.System.Drawing.Size(156, 22)
			Me.nonFEGamesToolStripMenuItem.Text = "Non-FE Games"
			Me.killRobloxToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.killRobloxToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.killRobloxToolStripMenuItem.Image = Global.Bleu.Properties.Resources.delete_x_161
			Me.killRobloxToolStripMenuItem.Name = "killRobloxToolStripMenuItem"
			Me.killRobloxToolStripMenuItem.Size = New Global.System.Drawing.Size(156, 22)
			Me.killRobloxToolStripMenuItem.Text = "Kill Game"
			AddHandler Me.killRobloxToolStripMenuItem.Click, AddressOf Me.killRobloxToolStripMenuItem_Click
			Me.doNotClickOnThisToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.doNotClickOnThisToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.doNotClickOnThisToolStripMenuItem.Image = Global.Bleu.Properties.Resources.DontOpen
			Me.doNotClickOnThisToolStripMenuItem.Name = "doNotClickOnThisToolStripMenuItem"
			Me.doNotClickOnThisToolStripMenuItem.Size = New Global.System.Drawing.Size(156, 22)
			Me.doNotClickOnThisToolStripMenuItem.Text = "I am depressed."
			AddHandler Me.doNotClickOnThisToolStripMenuItem.Click, AddressOf Me.doNotClickOnThisToolStripMenuItem_Click
			Me.loadHackToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.newExecutionToolStripMenuItem, Me.wrapperToolStripMenuItem, Me.trustCheckToolStripMenuItem, Me.extendedEnvToolStripMenuItem, Me.outputErrorsToolStripMenuItem })
			Me.loadHackToolStripMenuItem.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.loadHackToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.loadHackToolStripMenuItem.Name = "loadHackToolStripMenuItem"
			Me.loadHackToolStripMenuItem.Size = New Global.System.Drawing.Size(66, 15)
			Me.loadHackToolStripMenuItem.Text = "Execution"
			Me.newExecutionToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.newExecutionToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.newExecutionToolStripMenuItem.Image = Global.Bleu.Properties.Resources.S3
			Me.newExecutionToolStripMenuItem.Name = "newExecutionToolStripMenuItem"
			Me.newExecutionToolStripMenuItem.Size = New Global.System.Drawing.Size(155, 22)
			Me.newExecutionToolStripMenuItem.Text = "New"
			AddHandler Me.newExecutionToolStripMenuItem.Click, AddressOf Me.newExecutionToolStripMenuItem_Click
			Me.wrapperToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.wrapperToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.wrapperToolStripMenuItem.Image = Global.Bleu.Properties.Resources.S2
			Me.wrapperToolStripMenuItem.Name = "wrapperToolStripMenuItem"
			Me.wrapperToolStripMenuItem.Size = New Global.System.Drawing.Size(155, 22)
			Me.wrapperToolStripMenuItem.Text = "Wrapper"
			AddHandler Me.wrapperToolStripMenuItem.Click, AddressOf Me.wrapperToolStripMenuItem_Click
			Me.trustCheckToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.trustCheckToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.trustCheckToolStripMenuItem.Image = Global.Bleu.Properties.Resources.tc
			Me.trustCheckToolStripMenuItem.Name = "trustCheckToolStripMenuItem"
			Me.trustCheckToolStripMenuItem.Size = New Global.System.Drawing.Size(155, 22)
			Me.trustCheckToolStripMenuItem.Text = "Trust Check"
			AddHandler Me.trustCheckToolStripMenuItem.Click, AddressOf Me.trustCheckToolStripMenuItem_Click
			Me.extendedEnvToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.extendedEnvToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.extendedEnvToolStripMenuItem.Image = Global.Bleu.Properties.Resources.views_16
			Me.extendedEnvToolStripMenuItem.Name = "extendedEnvToolStripMenuItem"
			Me.extendedEnvToolStripMenuItem.Size = New Global.System.Drawing.Size(155, 22)
			Me.extendedEnvToolStripMenuItem.Text = "Use Environment"
			AddHandler Me.extendedEnvToolStripMenuItem.Click, AddressOf Me.extendedEnvToolStripMenuItem_Click
			Me.outputErrorsToolStripMenuItem.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.outputErrorsToolStripMenuItem.Checked = True
			Me.outputErrorsToolStripMenuItem.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.outputErrorsToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.outputErrorsToolStripMenuItem.Name = "outputErrorsToolStripMenuItem"
			Me.outputErrorsToolStripMenuItem.Size = New Global.System.Drawing.Size(155, 22)
			Me.outputErrorsToolStripMenuItem.Text = "Output Errors"
			AddHandler Me.outputErrorsToolStripMenuItem.Click, AddressOf Me.outputErrorsToolStripMenuItem_Click
			Me.CmdMatches.AutoClose = False
			Me.CmdMatches.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			Me.CmdMatches.Name = "CmdMatches"
			Me.CmdMatches.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.Professional
			Me.CmdMatches.ShowImageMargin = False
			Me.CmdMatches.Size = New Global.System.Drawing.Size(36, 4)
			Me.PissOff.Interval = 4000
			AddHandler Me.PissOff.Tick, AddressOf Me.PissOff_Tick
			Me.button19.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.button19.FlatAppearance.BorderColor = Global.System.Drawing.Color.DimGray
			Me.button19.FlatAppearance.BorderSize = 0
			Me.button19.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button19.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.button19.ForeColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.button19.Image = Global.Bleu.Properties.Resources._lock
			Me.button19.ImageAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.button19.Location = New Global.System.Drawing.Point(482, 0)
			Me.button19.Name = "button19"
			Me.button19.Size = New Global.System.Drawing.Size(25, 20)
			Me.button19.TabIndex = 34
			Me.button19.UseVisualStyleBackColor = True
			AddHandler Me.button19.Click, AddressOf Me.button19_Click
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.FromArgb(44, 44, 44)
			MyBase.ClientSize = New Global.System.Drawing.Size(507, 335)
			MyBase.Controls.Add(Me.panel1)
			MyBase.Controls.Add(Me.FindPanel)
			MyBase.Controls.Add(Me.button19)
			MyBase.Controls.Add(Me.scintilla1)
			MyBase.Controls.Add(Me.menuStrip1)
			MyBase.Controls.Add(Me.scriptBox)
			MyBase.Controls.Add(Me.searchScriptBox)
			Me.ForeColor = Global.System.Drawing.SystemColors.ControlText
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.MainMenuStrip = Me.menuStrip1
			Me.MinimumSize = New Global.System.Drawing.Size(523, 374)
			MyBase.Name = "Main"
			MyBase.Opacity = 0.0
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Bleu"
			MyBase.TopMost = True
			AddHandler MyBase.MaximizedBoundsChanged, AddressOf Me.Main_MaximizedBoundsChanged
			AddHandler MyBase.Activated, AddressOf Me.Main_Activated
			AddHandler MyBase.Deactivate, AddressOf Me.Main_Deactivate
			AddHandler MyBase.FormClosing, AddressOf Me.Main_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Main_Load
			AddHandler MyBase.LocationChanged, AddressOf Me.Main_LocationChanged
			AddHandler MyBase.MouseEnter, AddressOf Me.Main_MouseEnter
			AddHandler MyBase.MouseHover, AddressOf Me.Main_MouseHover
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			CType(Me.splitter1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.FindPanel.ResumeLayout(False)
			Me.FindPanel.PerformLayout()
			Me.contextMenuStrip1.ResumeLayout(False)
			Me.menuStrip1.ResumeLayout(False)
			Me.menuStrip1.PerformLayout()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		Private components As Global.System.ComponentModel.IContainer = Nothing

		Private AnimationTimer As Global.System.Windows.Forms.Timer

		Private RegisterButton As Global.System.Windows.Forms.Button

		Private splitter1 As Global.System.Windows.Forms.PictureBox

		Private panel1 As Global.System.Windows.Forms.Panel

		Private scintilla1 As Global.ScintillaNET.Scintilla

		Private button19 As Global.System.Windows.Forms.Button

		Private saveFileDialog1 As Global.System.Windows.Forms.SaveFileDialog

		Public OpenFileDialog1 As Global.System.Windows.Forms.OpenFileDialog

		Private FindPanel As Global.System.Windows.Forms.Panel

		Private ResultLabel As Global.System.Windows.Forms.Label

		Private button21 As Global.System.Windows.Forms.Button

		Private FindForward As Global.System.Windows.Forms.Button

		Private FindBack As Global.System.Windows.Forms.Button

		Private FindClose As Global.System.Windows.Forms.Button

		Private panel3 As Global.System.Windows.Forms.Panel

		Private FindBox As Global.System.Windows.Forms.TextBox

		Private Injector As Global.System.Windows.Forms.Timer

		Private scriptBox As Global.System.Windows.Forms.ListBox

		Private searchScriptBox As Global.System.Windows.Forms.TextBox

		Private contextMenuStrip1 As Global.System.Windows.Forms.ContextMenuStrip

		Private ohToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private OutputCheck As Global.System.Windows.Forms.Timer

		Private moonyToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private sADMARGToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private aFewLeavestoGoInASaladToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private toolStripSeparator1 As Global.System.Windows.Forms.ToolStripSeparator

		Private redToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private bleuToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private bleuToolStripMenuItem1 As Global.System.Windows.Forms.ToolStripMenuItem

		Private windows98ToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private menuStrip1 As Global.System.Windows.Forms.MenuStrip

		Private bleuToolStripMenuItem2 As Global.System.Windows.Forms.ToolStripMenuItem

		Private themesToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private saveToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private saveAsToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private openToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private exitToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private editToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private undoToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private redoToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private selectAllToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private cutToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private copyToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private pasteToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private viewToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private environmentToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private scriptListToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private scriptLibraryToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private themesToolStripMenuItem1 As Global.System.Windows.Forms.ToolStripMenuItem

		Private rOBLOXToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private loadHackToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private scriptsToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private newExecutionToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private wrapperToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private trustCheckToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private extendedEnvToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private inGameTopBarToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private dexToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private otherScriptsToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private killRobloxToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private infiniteYieldToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private remoteSpyToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private topKek75ToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private roXploit61ToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private zinniaKickToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private rainingSeagullsToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private toolStripMenuItem9 As Global.System.Windows.Forms.ToolStripMenuItem

		Private toolStripMenuItem10 As Global.System.Windows.Forms.ToolStripMenuItem

		Private toolStripMenuItem11 As Global.System.Windows.Forms.ToolStripMenuItem

		Private toolStripMenuItem12 As Global.System.Windows.Forms.ToolStripMenuItem

		Private toolStripMenuItem13 As Global.System.Windows.Forms.ToolStripMenuItem

		Private toolStripMenuItem14 As Global.System.Windows.Forms.ToolStripMenuItem

		Private toolStripMenuItem15 As Global.System.Windows.Forms.ToolStripMenuItem

		Private toolStripMenuItem16 As Global.System.Windows.Forms.ToolStripMenuItem

		Private outputToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private outputErrorsToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private CmdBox As Global.System.Windows.Forms.TextBox

		Private CmdMatches As Global.System.Windows.Forms.ContextMenuStrip

		Private doNotClickOnThisToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private PissOff As Global.System.Windows.Forms.Timer

		Private nonFEGamesToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		Private scriptWareUIToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem
	End Class
End Namespace
