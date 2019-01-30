Imports System
Imports System.Collections.Generic

Namespace Bleu
	Public Module Indexes
		' Token: 0x02000005 RID: 5
		<System.Runtime.CompilerServices.ExtensionAttribute()>
		Public Function AllIndexesOf(str As String, value As String) As List(Of Integer)
			If String.IsNullOrEmpty(value) Then
				Throw New ArgumentException("the string to find may not be empty", "value")
			End If
			Dim list As List(Of Integer) = New List(Of Integer)()
			Dim num As Integer = 0
			While True
				num = str.IndexOf(value, num)
				If num = -1 Then
					Exit For
				End If
				list.Add(num)
				num += value.Length
			End While
			Return list
		End Function
	End Module
End Namespace
