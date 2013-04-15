Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim valor As Boolean = False
        valor = validarUsuario(UsernameTextBox.Text, PasswordTextBox.Text)
        If valor = True Then
            obtenerListadoCts()
            Me.Hide()
            PasswordTextBox.Text = ""
            UsernameTextBox.Text = ""
            menuPrincipalFrm.Show()
        Else
            MsgBox("Error Datos Invalidos!", vbCritical)
            Exit Sub
            UsernameTextBox.Focus()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("DATO: " & Mid(UsernameTextBox.Text, 1, 2) & ":" & Mid(UsernameTextBox.Text, 3, 2))
    End Sub
End Class
