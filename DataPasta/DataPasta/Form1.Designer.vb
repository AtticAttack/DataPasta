<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataPastaForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(DataPastaForm))
        btnClipboard = New Button()
        btnPasteFile = New Button()
        btnPasteBase64EncodedFile = New Button()
        btnMinimise = New Button()
        NotifyIcon1 = New NotifyIcon(components)
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ToolStripMenuItem1 = New ToolStripMenuItem()
        TypetextFileToolStripMenuItem = New ToolStripMenuItem()
        TypeBase64OfABinaryFileToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        OpenFileDialog1 = New OpenFileDialog()
        ToolTip1 = New ToolTip(components)
        ContextMenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnClipboard
        ' 
        btnClipboard.Image = My.Resources.Resources.iconClipboard1
        btnClipboard.Location = New Point(0, 2)
        btnClipboard.Margin = New Padding(4, 5, 4, 5)
        btnClipboard.Name = "btnClipboard"
        btnClipboard.Size = New Size(57, 67)
        btnClipboard.TabIndex = 0
        ToolTip1.SetToolTip(btnClipboard, "Type clipboard contents")
        btnClipboard.UseVisualStyleBackColor = True
        ' 
        ' btnPasteFile
        ' 
        btnPasteFile.Image = My.Resources.Resources.iconFile
        btnPasteFile.Location = New Point(54, 2)
        btnPasteFile.Margin = New Padding(4, 5, 4, 5)
        btnPasteFile.Name = "btnPasteFile"
        btnPasteFile.Size = New Size(57, 67)
        btnPasteFile.TabIndex = 1
        ToolTip1.SetToolTip(btnPasteFile, "Select text file and type contents")
        btnPasteFile.UseVisualStyleBackColor = True
        ' 
        ' btnPasteBase64EncodedFile
        ' 
        btnPasteBase64EncodedFile.Image = My.Resources.Resources.iconFileBase64
        btnPasteBase64EncodedFile.Location = New Point(107, 2)
        btnPasteBase64EncodedFile.Margin = New Padding(4, 5, 4, 5)
        btnPasteBase64EncodedFile.Name = "btnPasteBase64EncodedFile"
        btnPasteBase64EncodedFile.Size = New Size(57, 67)
        btnPasteBase64EncodedFile.TabIndex = 2
        ToolTip1.SetToolTip(btnPasteBase64EncodedFile, "Select file and type BASE64 encoded contents")
        btnPasteBase64EncodedFile.UseVisualStyleBackColor = True
        ' 
        ' btnMinimise
        ' 
        btnMinimise.Image = My.Resources.Resources.iconMinimise
        btnMinimise.Location = New Point(164, 2)
        btnMinimise.Margin = New Padding(4, 5, 4, 5)
        btnMinimise.Name = "btnMinimise"
        btnMinimise.Size = New Size(57, 67)
        btnMinimise.TabIndex = 3
        ToolTip1.SetToolTip(btnMinimise, "Minimise to system tray")
        btnMinimise.UseVisualStyleBackColor = True
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.ContextMenuStrip = ContextMenuStrip1
        NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), Icon)
        NotifyIcon1.Text = "DataPasta"
        NotifyIcon1.Visible = True
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, TypetextFileToolStripMenuItem, TypeBase64OfABinaryFileToolStripMenuItem, ToolStripMenuItem2, ExitToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(301, 138)
        ContextMenuStrip1.Text = "Paste &clipboard contents"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(300, 32)
        ToolStripMenuItem1.Text = "Type &clipboard contents"
        ' 
        ' TypetextFileToolStripMenuItem
        ' 
        TypetextFileToolStripMenuItem.Name = "TypetextFileToolStripMenuItem"
        TypetextFileToolStripMenuItem.Size = New Size(300, 32)
        TypetextFileToolStripMenuItem.Text = "Type &text file"
        ' 
        ' TypeBase64OfABinaryFileToolStripMenuItem
        ' 
        TypeBase64OfABinaryFileToolStripMenuItem.Name = "TypeBase64OfABinaryFileToolStripMenuItem"
        TypeBase64OfABinaryFileToolStripMenuItem.Size = New Size(300, 32)
        TypeBase64OfABinaryFileToolStripMenuItem.Text = "Type &Base64 of a binary file"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(297, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(300, 32)
        ExitToolStripMenuItem.Text = "E&xit"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' DataPastaForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(226, 70)
        Controls.Add(btnMinimise)
        Controls.Add(btnPasteBase64EncodedFile)
        Controls.Add(btnPasteFile)
        Controls.Add(btnClipboard)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        Name = "DataPastaForm"
        Text = "DataPasta"
        TopMost = True
        ContextMenuStrip1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnClipboard As Button
    Friend WithEvents btnPasteFile As Button
    Friend WithEvents btnPasteBase64EncodedFile As Button
    Friend WithEvents btnMinimise As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TypetextFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TypeBase64OfABinaryFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolTip1 As ToolTip
End Class
