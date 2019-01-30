Imports System
Imports System.Windows.Forms

Namespace Bleu
	Friend Module Program
		' Token: 0x02000006 RID: 6
		<STAThread()>
		Private Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub
	End Module
End Namespace
