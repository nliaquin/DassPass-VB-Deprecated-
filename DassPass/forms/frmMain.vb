Imports System.ComponentModel

Public Class frmMain
    Private arrServices As ArrayList

    Dim LastIndex As Integer

    Enum Modes
        Read
        Add
        Edit
        Delete
    End Enum
    Dim ServiceMode As Modes

#Region "Status"
    Dim intDisplaySeconds As Integer

    Public Sub SetStatus(ByVal strStatus As String)
        Status.Text = strStatus
        Application.DoEvents()

        btnClearNow.Visible = True

        intDisplaySeconds = 6
        SecondsLeft.Text = "6"

        StatusTimer.Start()
    End Sub

    Private Sub StatusTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles StatusTimer.Tick
        intDisplaySeconds -= 1

        SecondsLeft.Text = 0 + intDisplaySeconds

        If intDisplaySeconds = 0 Then
            btnClearNow.Visible = False
            SecondsLeft.Text = Nothing
            ClearStatus()
            StatusTimer.Stop()
        End If
    End Sub

    Public Sub ClearStatus()
        Status.Text = ""
        Application.DoEvents()

        btnClearNow.Visible = False
        SecondsLeft.Text = Nothing
        StatusTimer.Stop()
    End Sub
#End Region
#Region "Encryption Testing"
    Private Sub btnCopyPlain_Click(sender As Object, e As EventArgs) Handles btnCopyPlain.Click
        If txtPlain.Text = Nothing Then
            SetStatus("Cannot copy blank text...")
        Else
            txtPlain.SelectAll()
            Clipboard.SetText(txtPlain.Text)
            SetStatus("Plain Text Copied...")
        End If
    End Sub

    Private Sub btnClearPlain_Click(sender As Object, e As EventArgs) Handles btnClearPlain.Click
        txtPlain.Text = Nothing
        SetStatus("Plain Text Cleared...")
    End Sub

    Private Sub btnEncrpyt_Click(sender As Object, e As EventArgs) Handles btnEncrpyt.Click
        If txtPlain.Text = Nothing Then
            SetStatus("Textbox cannot be left blank...")
        Else
            Dim PlainString As String
            PlainString = txtPlain.Text

            Dim EncryptedText As String = Encrypt(PlainString)
            txtEncrypted.Text = EncryptedText

            SetStatus("Plain Text Encrypted...")
        End If
    End Sub

    Private Sub btnCopyEncrypted_Click(sender As Object, e As EventArgs) Handles btnCopyEncrypted.Click
        If txtEncrypted.Text = Nothing Then
            SetStatus("Cannot copy blank text...")
        Else
            txtEncrypted.SelectAll()
            Clipboard.SetText(txtEncrypted.Text)
            SetStatus("Encrypted Text Copied...")
        End If
    End Sub

    Private Sub btnClearEncrypted_Click(sender As Object, e As EventArgs) Handles btnClearEncrypted.Click
        txtEncrypted.Text = Nothing
        SetStatus("Encrypted Text Cleared...")
    End Sub

    Private Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
        If txtEncrypted.Text = Nothing Then
            SetStatus("Textbox cannot be left blank...")
        Else
            Dim EncryptedString As String
            EncryptedString = txtEncrypted.Text

            Dim PlainText As String = Decrypt(EncryptedString)
            txtPlain.Text = PlainText

            SetStatus("Encrypted Text Decrypted...")
        End If
    End Sub

    Private Sub btnClearStatus_Click(sender As Object, e As EventArgs) Handles btnClearNow.Click
        ClearStatus()
    End Sub



#End Region
#Region "Form Event Handlers"
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StatusTimer.Interval = 1000
        InitCrypto()
        InitCrypto2()
        InitIO()

        ServiceMode = Modes.Read
        lblServiceMode.Text = Nothing

        arrServices = ReadFromFile()
        RefreshLstServices()
    End Sub

    'Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    '    If MessageBox.Show("Are you sure you wish to exit the program? Any unsaved changes will be lost.", "Exit DassPass?", MessageBoxButtons.YesNo) = DialogResult.No Then
    '        e.Cancel = True
    '    End If
    'End Sub

    Private Sub LeftControlsCheck(sender As Object, e As EventArgs) Handles lstServices.SelectedIndexChanged
        If lstServices.SelectedItem <> Nothing Then
            btnEdit.Enabled = True
            btnDelete.Enabled = True
        Else
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub SetSelectedService() Handles lstServices.SelectedIndexChanged
        If lstServices.SelectedIndex <> -1 Then
            Dim tempService As clsService = arrServices.Item(lstServices.SelectedIndex)

            txtWebsite.Text = tempService.GetWebsite
            txtUser.Text = tempService.GetUser
            txtPass.Text = tempService.GetPass
            txtNotes.Text = tempService.GetNotes

            'With LastService
            '    .Website = tempSevice.GetWebsite
            '    .User = tempSevice.GetUser
            '    .Pass = tempSevice.GetPass
            '    .Notes = tempSevice.GetNotes
            'End With

            LastIndex = lstServices.SelectedIndex

            tempService = Nothing
        Else
            txtWebsite.Clear()
            txtUser.Clear()
            txtPass.Clear()
            txtNotes.Clear()
        End If
    End Sub
#End Region
#Region "Formatting"
    Private Sub AddMode()
        lblServiceMode.Text = "Adding new service"
        SetStatus("Add selected...")

        lstServices.Enabled = False

        btnAdd.Visible = False
        btnEdit.Visible = False
        btnDelete.Visible = False

        btnCancel.Visible = True
        btnSave.Visible = True

        txtWebsite.Text = Nothing
        txtWebsite.ReadOnly = False

        txtUser.Text = Nothing
        txtUser.ReadOnly = False
        btnCopyUser.Enabled = False

        txtPass.Text = Nothing
        txtPass.ReadOnly = False
        btnCopyPass.Enabled = False

        txtNotes.Text = Nothing
        txtNotes.ReadOnly = False

        ServiceMode = Modes.Add
    End Sub

    Private Sub EditMode()
        lblServiceMode.Text = "Editing selected service"
        SetStatus("Edit selected...")

        lstServices.Enabled = False

        btnAdd.Visible = False
        btnEdit.Visible = False
        btnDelete.Visible = False

        btnCancel.Visible = True
        btnSave.Visible = True

        txtWebsite.ReadOnly = False

        txtUser.ReadOnly = False
        btnCopyUser.Enabled = False

        txtPass.ReadOnly = False
        btnCopyPass.Enabled = False

        txtNotes.ReadOnly = False

        ServiceMode = Modes.Edit
    End Sub

    Private Sub DeleteMode()
        btnCancel.Text = "No"
        btnSave.Text = "Yes"

        lblServiceMode.Text = "Are you sure you wish to delete?"
        SetStatus("Delete selected...")

        lstServices.Enabled = False

        btnAdd.Visible = False
        btnEdit.Visible = False
        btnDelete.Visible = False

        btnCancel.Visible = True
        btnSave.Visible = True

        ServiceMode = Modes.Delete
    End Sub

    Private Sub ReadMode()
        btnCancel.Text = "Cancel"
        btnSave.Text = "Save"

        lblServiceMode.Text = Nothing

        lstServices.Enabled = True

        btnAdd.Visible = True
        btnEdit.Visible = True
        btnDelete.Visible = True

        btnCancel.Visible = False
        btnSave.Visible = False

        txtWebsite.ReadOnly = True

        txtUser.ReadOnly = True
        btnCopyUser.Enabled = True

        txtPass.ReadOnly = True
        btnCopyPass.Enabled = True

        txtNotes.ReadOnly = True

        ServiceMode = Modes.Read
    End Sub
#End Region
#Region "Controls"
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddMode()
        lstServices.SelectedIndex = -1
    End Sub

    Private Sub AddService()
        If txtWebsite.Text <> "" And txtUser.Text <> "" And txtPass.Text <> "" Then
            Dim strWebsite As String = txtWebsite.Text
            Dim strUser As String = txtUser.Text
            Dim strPass As String = txtPass.Text
            Dim strNotes As String = txtNotes.Text

            Dim newService As New clsService(strWebsite, strUser, strPass, strNotes)
            arrServices.Add(newService)
            WriteToFile(arrServices)
            RefreshLstServices()

            SetStatus("Service successfully added...")
            ReadMode()
        Else
            SetStatus("Cannot Save without a Website, User, and Pass...")
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EditMode()
    End Sub
    Private Sub EditService()
        If txtWebsite.Text <> "" And txtUser.Text <> "" And txtPass.Text <> "" Then
            Dim strWebsite As String = txtWebsite.Text
            Dim strUser As String = txtUser.Text
            Dim strPass As String = txtPass.Text
            Dim strNotes As String = txtNotes.Text

            Dim serviceIndex As Integer = lstServices.SelectedIndex
            Dim thisService As clsService = arrServices.Item(serviceIndex)

            With thisService
                .SetWebsite(strWebsite)
                .SetUser(strUser)
                .SetPass(strPass)
                .SetNotes(strNotes)
            End With

            arrServices.Item(serviceIndex) = thisService
            WriteToFile(arrServices)
            RefreshLstServices()
            lstServices.SelectedIndex = LastIndex

            SetStatus("Service successfully edited...")
            ReadMode()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteMode()
    End Sub
    Private Sub DeleteService()
        arrServices.RemoveAt(LastIndex)
        WriteToFile(arrServices)
        RefreshLstServices()

        btnEdit.Enabled = False
        btnDelete.Enabled = False

        lstServices.SelectedIndex = -1
        LastIndex = -1
        txtWebsite.Clear()
        txtUser.Clear()
        txtPass.Clear()
        txtNotes.Clear()

        SetStatus("Service successfully deleted...")
        ReadMode()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ReadMode()
        lstServices.SelectedIndex = -1
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Select Case ServiceMode
            Case Modes.Add
                AddService()

            Case Modes.Edit
                EditService()

            Case Modes.Delete
                DeleteService()
        End Select
    End Sub

    Private Sub btnCopyUser_Click(sender As Object, e As EventArgs) Handles btnCopyUser.Click
        If txtUser.Text <> Nothing Then
            Clipboard.SetText(txtUser.Text)
            SetStatus("Username copied to clipboard...")
        End If
    End Sub

    Private Sub btnCopyPass_Click(sender As Object, e As EventArgs) Handles btnCopyPass.Click
        If txtPass.Text <> Nothing Then
            Clipboard.SetText(txtPass.Text)
            SetStatus("Password copied to clipboard...")
        End If
    End Sub
#End Region
#Region "Sorting"
    Private Sub btnSortUp_Click(sender As Object, e As EventArgs) Handles btnSortUp.Click
        If lstServices.SelectedIndex > 0 Then
            Dim index As Integer = lstServices.SelectedIndex
            Dim selectedService As clsService = arrServices.Item(index)
            Dim aboveService As clsService = arrServices.Item(index - 1)

            arrServices.RemoveAt(index)
            arrServices.Insert(index - 1, selectedService)

            RefreshLstServices()
            WriteToFile(arrServices)
            lstServices.SelectedIndex = LastIndex - 1
        End If
    End Sub

    Private Sub btnSortDown_Click(sender As Object, e As EventArgs) Handles btnSortDown.Click
        If lstServices.SelectedIndex < arrServices.Count - 1 Then
            Dim index As Integer = lstServices.SelectedIndex
            Dim selectedService As clsService = arrServices.Item(index)
            Dim belowService As clsService = arrServices.Item(index + 1)

            arrServices.RemoveAt(index)
            arrServices.Insert(index + 1, selectedService)

            RefreshLstServices()
            WriteToFile(arrServices)
            lstServices.SelectedIndex = LastIndex + 1
        End If
    End Sub
#End Region

    Private Sub RefreshLstServices()
        lstServices.Items.Clear()

        For Each aService As clsService In arrServices
            lstServices.Items.Add(aService.GetWebsite)
        Next
    End Sub

    Private Sub AssistUserDuringReadMode() Handles txtWebsite.Enter, txtUser.Enter, txtPass.Enter, txtNotes.Enter
        If ServiceMode = Modes.Read Then
            SetStatus("To modify or add services, enter either add or edit mode...")
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If MessageBox.Show("This will export all of your data to plain text. Are you sure you want to do this? If so, please wait and do nothing else until you are prompted.", "Export Everything?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ExportToText()
            MessageBox.Show("The export is complete. You may now continue using DassPass.", "Export Complete")
        End If
    End Sub
End Class