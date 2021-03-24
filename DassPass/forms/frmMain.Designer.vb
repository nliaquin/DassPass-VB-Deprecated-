<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.grpEncryptionTest = New System.Windows.Forms.GroupBox()
        Me.btnClearEncrypted = New System.Windows.Forms.Button()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.btnCopyEncrypted = New System.Windows.Forms.Button()
        Me.btnClearPlain = New System.Windows.Forms.Button()
        Me.btnEncrpyt = New System.Windows.Forms.Button()
        Me.btnCopyPlain = New System.Windows.Forms.Button()
        Me.txtEncrypted = New System.Windows.Forms.TextBox()
        Me.txtPlain = New System.Windows.Forms.TextBox()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SecondsLeft = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnClearNow = New System.Windows.Forms.Button()
        Me.StatusTimer = New System.Windows.Forms.Timer(Me.components)
        Me.grpControls = New System.Windows.Forms.GroupBox()
        Me.lblServiceMode = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lstServices = New System.Windows.Forms.ListBox()
        Me.grpServiceInfo = New System.Windows.Forms.GroupBox()
        Me.btnCopyUser = New System.Windows.Forms.Button()
        Me.btnCopyPass = New System.Windows.Forms.Button()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtWebsite = New System.Windows.Forms.TextBox()
        Me.lblWebsite = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSortUp = New System.Windows.Forms.Button()
        Me.btnSortDown = New System.Windows.Forms.Button()
        Me.grpSortControls = New System.Windows.Forms.GroupBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.grpEncryptionTest.SuspendLayout()
        Me.StatusBar.SuspendLayout()
        Me.grpControls.SuspendLayout()
        Me.grpServiceInfo.SuspendLayout()
        Me.grpSortControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpEncryptionTest
        '
        Me.grpEncryptionTest.Controls.Add(Me.btnClearEncrypted)
        Me.grpEncryptionTest.Controls.Add(Me.btnDecrypt)
        Me.grpEncryptionTest.Controls.Add(Me.btnCopyEncrypted)
        Me.grpEncryptionTest.Controls.Add(Me.btnClearPlain)
        Me.grpEncryptionTest.Controls.Add(Me.btnEncrpyt)
        Me.grpEncryptionTest.Controls.Add(Me.btnCopyPlain)
        Me.grpEncryptionTest.Controls.Add(Me.txtEncrypted)
        Me.grpEncryptionTest.Controls.Add(Me.txtPlain)
        Me.grpEncryptionTest.Location = New System.Drawing.Point(845, 455)
        Me.grpEncryptionTest.Name = "grpEncryptionTest"
        Me.grpEncryptionTest.Size = New System.Drawing.Size(817, 78)
        Me.grpEncryptionTest.TabIndex = 3
        Me.grpEncryptionTest.TabStop = False
        Me.grpEncryptionTest.Text = "Encryption Testing"
        '
        'btnClearEncrypted
        '
        Me.btnClearEncrypted.Location = New System.Drawing.Point(691, 43)
        Me.btnClearEncrypted.Name = "btnClearEncrypted"
        Me.btnClearEncrypted.Size = New System.Drawing.Size(40, 23)
        Me.btnClearEncrypted.TabIndex = 6
        Me.btnClearEncrypted.Text = "Clear"
        Me.btnClearEncrypted.UseVisualStyleBackColor = True
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(736, 43)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(75, 23)
        Me.btnDecrypt.TabIndex = 7
        Me.btnDecrypt.Text = "Decrypt"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'btnCopyEncrypted
        '
        Me.btnCopyEncrypted.Location = New System.Drawing.Point(647, 43)
        Me.btnCopyEncrypted.Name = "btnCopyEncrypted"
        Me.btnCopyEncrypted.Size = New System.Drawing.Size(40, 23)
        Me.btnCopyEncrypted.TabIndex = 5
        Me.btnCopyEncrypted.Text = "Copy"
        Me.btnCopyEncrypted.UseVisualStyleBackColor = True
        '
        'btnClearPlain
        '
        Me.btnClearPlain.Location = New System.Drawing.Point(691, 17)
        Me.btnClearPlain.Name = "btnClearPlain"
        Me.btnClearPlain.Size = New System.Drawing.Size(40, 23)
        Me.btnClearPlain.TabIndex = 2
        Me.btnClearPlain.Text = "Clear"
        Me.btnClearPlain.UseVisualStyleBackColor = True
        '
        'btnEncrpyt
        '
        Me.btnEncrpyt.Location = New System.Drawing.Point(736, 17)
        Me.btnEncrpyt.Name = "btnEncrpyt"
        Me.btnEncrpyt.Size = New System.Drawing.Size(75, 23)
        Me.btnEncrpyt.TabIndex = 3
        Me.btnEncrpyt.Text = "Encrypt"
        Me.btnEncrpyt.UseVisualStyleBackColor = True
        '
        'btnCopyPlain
        '
        Me.btnCopyPlain.Location = New System.Drawing.Point(647, 17)
        Me.btnCopyPlain.Name = "btnCopyPlain"
        Me.btnCopyPlain.Size = New System.Drawing.Size(40, 23)
        Me.btnCopyPlain.TabIndex = 1
        Me.btnCopyPlain.Text = "Copy"
        Me.btnCopyPlain.UseVisualStyleBackColor = True
        '
        'txtEncrypted
        '
        Me.txtEncrypted.Location = New System.Drawing.Point(6, 45)
        Me.txtEncrypted.Name = "txtEncrypted"
        Me.txtEncrypted.Size = New System.Drawing.Size(635, 20)
        Me.txtEncrypted.TabIndex = 4
        '
        'txtPlain
        '
        Me.txtPlain.Location = New System.Drawing.Point(6, 19)
        Me.txtPlain.Name = "txtPlain"
        Me.txtPlain.Size = New System.Drawing.Size(635, 20)
        Me.txtPlain.TabIndex = 0
        '
        'StatusBar
        '
        Me.StatusBar.BackColor = System.Drawing.Color.White
        Me.StatusBar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status, Me.SecondsLeft})
        Me.StatusBar.Location = New System.Drawing.Point(0, 447)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(838, 22)
        Me.StatusBar.SizingGrip = False
        Me.StatusBar.TabIndex = 4
        '
        'Status
        '
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(0, 17)
        '
        'SecondsLeft
        '
        Me.SecondsLeft.Name = "SecondsLeft"
        Me.SecondsLeft.Size = New System.Drawing.Size(0, 17)
        '
        'btnClearNow
        '
        Me.btnClearNow.Location = New System.Drawing.Point(764, 447)
        Me.btnClearNow.Name = "btnClearNow"
        Me.btnClearNow.Size = New System.Drawing.Size(75, 23)
        Me.btnClearNow.TabIndex = 5
        Me.btnClearNow.Text = "Clear Now"
        Me.btnClearNow.UseVisualStyleBackColor = True
        Me.btnClearNow.Visible = False
        '
        'StatusTimer
        '
        '
        'grpControls
        '
        Me.grpControls.Controls.Add(Me.lblServiceMode)
        Me.grpControls.Controls.Add(Me.btnSave)
        Me.grpControls.Controls.Add(Me.btnCancel)
        Me.grpControls.Controls.Add(Me.btnDelete)
        Me.grpControls.Controls.Add(Me.btnEdit)
        Me.grpControls.Controls.Add(Me.btnAdd)
        Me.grpControls.Location = New System.Drawing.Point(11, 386)
        Me.grpControls.Name = "grpControls"
        Me.grpControls.Size = New System.Drawing.Size(817, 56)
        Me.grpControls.TabIndex = 2
        Me.grpControls.TabStop = False
        Me.grpControls.Text = "Controls"
        '
        'lblServiceMode
        '
        Me.lblServiceMode.AutoSize = True
        Me.lblServiceMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblServiceMode.Location = New System.Drawing.Point(368, 25)
        Me.lblServiceMode.Name = "lblServiceMode"
        Me.lblServiceMode.Size = New System.Drawing.Size(89, 16)
        Me.lblServiceMode.TabIndex = 5
        Me.lblServiceMode.Text = "ServiceMode"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(697, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(113, 27)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.ToolTip.SetToolTip(Me.btnSave, "Save changes")
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(578, 19)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(113, 27)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.ToolTip.SetToolTip(Me.btnCancel, "Cancel changes")
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnDelete.Location = New System.Drawing.Point(244, 19)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(113, 27)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.ToolTip.SetToolTip(Me.btnDelete, "Delete the currently selected service")
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(125, 19)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(113, 27)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        Me.ToolTip.SetToolTip(Me.btnEdit, "Edit the currently selected service")
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(6, 19)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(113, 27)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.ToolTip.SetToolTip(Me.btnAdd, "Add a new service")
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lstServices
        '
        Me.lstServices.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstServices.FormattingEnabled = True
        Me.lstServices.ItemHeight = 16
        Me.lstServices.Location = New System.Drawing.Point(11, 12)
        Me.lstServices.Name = "lstServices"
        Me.lstServices.Size = New System.Drawing.Size(358, 372)
        Me.lstServices.TabIndex = 0
        '
        'grpServiceInfo
        '
        Me.grpServiceInfo.Controls.Add(Me.btnExport)
        Me.grpServiceInfo.Controls.Add(Me.btnCopyUser)
        Me.grpServiceInfo.Controls.Add(Me.btnCopyPass)
        Me.grpServiceInfo.Controls.Add(Me.txtNotes)
        Me.grpServiceInfo.Controls.Add(Me.lblNotes)
        Me.grpServiceInfo.Controls.Add(Me.txtPass)
        Me.grpServiceInfo.Controls.Add(Me.lblPass)
        Me.grpServiceInfo.Controls.Add(Me.txtUser)
        Me.grpServiceInfo.Controls.Add(Me.lblUser)
        Me.grpServiceInfo.Controls.Add(Me.txtWebsite)
        Me.grpServiceInfo.Controls.Add(Me.lblWebsite)
        Me.grpServiceInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grpServiceInfo.Location = New System.Drawing.Point(375, 6)
        Me.grpServiceInfo.Name = "grpServiceInfo"
        Me.grpServiceInfo.Size = New System.Drawing.Size(453, 378)
        Me.grpServiceInfo.TabIndex = 1
        Me.grpServiceInfo.TabStop = False
        Me.grpServiceInfo.Text = "Service Info"
        '
        'btnCopyUser
        '
        Me.btnCopyUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyUser.Location = New System.Drawing.Point(422, 74)
        Me.btnCopyUser.Name = "btnCopyUser"
        Me.btnCopyUser.Size = New System.Drawing.Size(25, 25)
        Me.btnCopyUser.TabIndex = 4
        Me.btnCopyUser.Text = "✂"
        Me.ToolTip.SetToolTip(Me.btnCopyUser, "Copy username")
        Me.btnCopyUser.UseVisualStyleBackColor = True
        '
        'btnCopyPass
        '
        Me.btnCopyPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyPass.Location = New System.Drawing.Point(422, 114)
        Me.btnCopyPass.Name = "btnCopyPass"
        Me.btnCopyPass.Size = New System.Drawing.Size(25, 25)
        Me.btnCopyPass.TabIndex = 7
        Me.btnCopyPass.Text = "✂"
        Me.ToolTip.SetToolTip(Me.btnCopyPass, "Copy password")
        Me.btnCopyPass.UseVisualStyleBackColor = True
        '
        'txtNotes
        '
        Me.txtNotes.BackColor = System.Drawing.Color.White
        Me.txtNotes.Location = New System.Drawing.Point(67, 156)
        Me.txtNotes.MaxLength = 500
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ReadOnly = True
        Me.txtNotes.Size = New System.Drawing.Size(379, 185)
        Me.txtNotes.TabIndex = 9
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Location = New System.Drawing.Point(18, 159)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(47, 16)
        Me.lblNotes.TabIndex = 8
        Me.lblNotes.Text = "Notes:"
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.White
        Me.txtPass.Location = New System.Drawing.Point(67, 116)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.ReadOnly = True
        Me.txtPass.Size = New System.Drawing.Size(354, 22)
        Me.txtPass.TabIndex = 6
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(23, 119)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(42, 16)
        Me.lblPass.TabIndex = 5
        Me.lblPass.Text = "Pass:"
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.White
        Me.txtUser.Location = New System.Drawing.Point(67, 76)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(354, 22)
        Me.txtUser.TabIndex = 3
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(25, 79)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(40, 16)
        Me.lblUser.TabIndex = 2
        Me.lblUser.Text = "User:"
        '
        'txtWebsite
        '
        Me.txtWebsite.BackColor = System.Drawing.Color.White
        Me.txtWebsite.Location = New System.Drawing.Point(67, 36)
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.ReadOnly = True
        Me.txtWebsite.Size = New System.Drawing.Size(379, 22)
        Me.txtWebsite.TabIndex = 1
        '
        'lblWebsite
        '
        Me.lblWebsite.AutoSize = True
        Me.lblWebsite.Location = New System.Drawing.Point(4, 39)
        Me.lblWebsite.Name = "lblWebsite"
        Me.lblWebsite.Size = New System.Drawing.Size(61, 16)
        Me.lblWebsite.TabIndex = 0
        Me.lblWebsite.Text = "Website:"
        '
        'btnSortUp
        '
        Me.btnSortUp.Location = New System.Drawing.Point(6, 19)
        Me.btnSortUp.Name = "btnSortUp"
        Me.btnSortUp.Size = New System.Drawing.Size(30, 30)
        Me.btnSortUp.TabIndex = 0
        Me.btnSortUp.Text = "▲"
        Me.ToolTip.SetToolTip(Me.btnSortUp, "Move the currently selected service up on the list")
        Me.btnSortUp.UseVisualStyleBackColor = True
        '
        'btnSortDown
        '
        Me.btnSortDown.Location = New System.Drawing.Point(6, 61)
        Me.btnSortDown.Name = "btnSortDown"
        Me.btnSortDown.Size = New System.Drawing.Size(30, 30)
        Me.btnSortDown.TabIndex = 1
        Me.btnSortDown.Text = "▼"
        Me.ToolTip.SetToolTip(Me.btnSortDown, "Move the currently selected service down on the list")
        Me.btnSortDown.UseVisualStyleBackColor = True
        '
        'grpSortControls
        '
        Me.grpSortControls.Controls.Add(Me.btnSortDown)
        Me.grpSortControls.Controls.Add(Me.btnSortUp)
        Me.grpSortControls.Location = New System.Drawing.Point(369, 287)
        Me.grpSortControls.Name = "grpSortControls"
        Me.grpSortControls.Size = New System.Drawing.Size(42, 98)
        Me.grpSortControls.TabIndex = 10
        Me.grpSortControls.TabStop = False
        Me.grpSortControls.Text = "Sort"
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(214, 349)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(232, 23)
        Me.btnExport.TabIndex = 10
        Me.btnExport.Text = "Export All To Text"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 469)
        Me.Controls.Add(Me.grpSortControls)
        Me.Controls.Add(Me.btnClearNow)
        Me.Controls.Add(Me.grpServiceInfo)
        Me.Controls.Add(Me.lstServices)
        Me.Controls.Add(Me.grpControls)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.grpEncryptionTest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.Text = "DassPass"
        Me.grpEncryptionTest.ResumeLayout(False)
        Me.grpEncryptionTest.PerformLayout()
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.grpControls.ResumeLayout(False)
        Me.grpControls.PerformLayout()
        Me.grpServiceInfo.ResumeLayout(False)
        Me.grpServiceInfo.PerformLayout()
        Me.grpSortControls.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpEncryptionTest As GroupBox
    Friend WithEvents btnDecrypt As Button
    Friend WithEvents btnCopyEncrypted As Button
    Friend WithEvents btnEncrpyt As Button
    Friend WithEvents btnCopyPlain As Button
    Friend WithEvents txtEncrypted As TextBox
    Friend WithEvents txtPlain As TextBox
    Friend WithEvents StatusBar As StatusStrip
    Friend WithEvents Status As ToolStripStatusLabel
    Friend WithEvents btnClearNow As Button
    Friend WithEvents StatusTimer As Timer
    Friend WithEvents SecondsLeft As ToolStripStatusLabel
    Friend WithEvents btnClearEncrypted As Button
    Friend WithEvents btnClearPlain As Button
    Friend WithEvents grpControls As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lstServices As ListBox
    Friend WithEvents grpServiceInfo As GroupBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents lblNotes As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents txtWebsite As TextBox
    Friend WithEvents lblWebsite As Label
    Friend WithEvents btnCopyPass As Button
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents btnCopyUser As Button
    Friend WithEvents lblServiceMode As Label
    Friend WithEvents grpSortControls As GroupBox
    Friend WithEvents btnSortDown As Button
    Friend WithEvents btnSortUp As Button
    Friend WithEvents btnExport As Button
End Class
