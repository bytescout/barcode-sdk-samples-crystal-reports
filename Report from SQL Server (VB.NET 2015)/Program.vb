'********************************************************************
'
' Download evaluation version: https://bytescout.com/download/web-installer
'
' Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up
'
' Copyright © 2017 ByteScout Inc. All rights reserved.
' http://www.bytescout.com
'                                                                   
'********************************************************************


Imports System.Collections.Generic
Imports System.Windows.Forms

NotInheritable Class Program
	Private Sub New()
	End Sub
	<STAThread> _
	Friend Shared Sub Main()
		Application.EnableVisualStyles()
		Application.Run(New Form1())
	End Sub
End Class
