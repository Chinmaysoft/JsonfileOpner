Imports System.IO


Public Class Json_Opner

    Dim strtxt As String
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            WebBrowser1.Hide()
            OpenFileDialog1.Title = "Open Text Files"
            OpenFileDialog1.ShowDialog()
            strtxt = OpenFileDialog1.FileName
            RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(strtxt)
        Catch ex As Exception
            MessageBox.Show("Please select file")

        End Try
    End Sub

    Private Sub CloseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem1.Click
        End
    End Sub

    Private Sub BrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrowserToolStripMenuItem.Click
        WebBrowser1.Navigate(strtxt)
    End Sub

    Private Sub WriteNewFileToolStripMenuItem_Click(sender As Object, e As EventArgs) 

    End Sub
End Class
