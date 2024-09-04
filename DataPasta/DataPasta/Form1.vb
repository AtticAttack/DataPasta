Public Class DataPastaForm

    Private Sub DataPastaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the Window position to the bottom right, just above the notification area
        Me.Left = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        Me.Top = Screen.PrimaryScreen.WorkingArea.Height - Me.Height

        ' Now hide away until the user clicks the tray icon or presses the hotkey
        Me.Hide()
    End Sub

    Private Sub btnClipboard_Click(sender As Object, e As EventArgs) Handles btnClipboard.Click

        ' Pastes the contents of the clipboard as if you'd typed it at the keyboard

        If (Clipboard.ContainsText()) Then
            SendKeys.Send("%{TAB}")                 ' Types Alt-Tab to change focus back to previous window - i.e. the destination app

            Dim ClipboardText As String = Clipboard.GetText()
            SendKeys.Send(ClipboardText)      ' Types out the contents of the clipboard
        End If

        Me.Hide()
    End Sub


    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick, NotifyIcon1.MouseClick
        Me.Show()
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnMinimise_Click(sender As Object, e As EventArgs) Handles btnMinimise.Click
        NotifyIcon1.Visible = True
        Me.Hide()
    End Sub


    Private Sub PickFileToPaste(ByVal EncodeFileContents As Boolean)

        If (OpenFileDialog1.ShowDialog() <> DialogResult.Cancel) Then
            Try

                SendKeys.Send("%{TAB}")                 ' Types Alt-Tab to change focus back to previous window - i.e. the destination app

                If EncodeFileContents Then
                    Dim FileContentsRawBytes = My.Computer.FileSystem.ReadAllBytes(OpenFileDialog1.FileName)
                    Dim Base64Output = Convert.ToBase64String(FileContentsRawBytes)
                    SendKeys.Send(Base64Output)             ' Type out the contents of the file
                Else
                    Dim FileReader As System.IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialog1.FileName)
                    Dim FileContentsString As String = FileReader.ReadToEnd()
                    SendKeys.Send(FileContentsString)        ' Type out the contents of the file
                End If


            Catch ex As Exception
                ' Oops, something went wrong... oh well, never mind!
            End Try
        End If

    End Sub

    Private Sub btnPasteFile_Click(sender As Object, e As EventArgs) Handles btnPasteFile.Click, TypetextFileToolStripMenuItem.Click

        ' Pick a file and types out it's contents
        PickFileToPaste(False)

    End Sub

    Private Sub btnPasteBase64EncodedFile_Click(sender As Object, e As EventArgs) Handles btnPasteBase64EncodedFile.Click, TypeBase64OfABinaryFileToolStripMenuItem.Click

        ' Pick a file, convert it to Base64, and type out the results
        PickFileToPaste(True)

    End Sub


End Class
