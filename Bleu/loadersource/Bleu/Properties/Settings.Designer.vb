Imports System
Imports System.CodeDom.Compiler
Imports System.Configuration
Imports System.Runtime.CompilerServices

Namespace Bleu.Properties
	<GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")>
	<CompilerGenerated()>
	Friend Partial Class Settings
		Inherits ApplicationSettingsBase

		' Token: 0x02000008 RID: 8
		Public Shared ReadOnly Property [Default] As Settings
			Get
				Return Settings.defaultInstance
			End Get
		End Property

		Private Shared defaultInstance As Settings = CType(SettingsBase.Synchronized(New Settings()), Settings)
	End Class
End Namespace
