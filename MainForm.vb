Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.IO
Imports Microsoft.WindowsAPICodePack.Shell

Public Enum RenameMethod As Integer
    <Description("No pattern")>
    NoPattern = 0
    <Description("Use Date and Time from Exif metadata 'yyyy-mm-dd hh.mm.ss'")>
    UseDateTakenMetadataWithTime = 1
    <Description("Use Date from Exif metadata 'yyyy-mm-dd'")>
    UseDateTakenMetadataWithoutTime = 2
    <Description("Use Date and Time from file attribute 'yyyy-mm-dd hh.mm.ss'")>
    UseDateAndTimeFromFileAttribute = 3
    <Description("Format 'yyyymmddhhmmss' -> 'yyyy-mm-dd hh.mm.ss'")>
    InsertDashesAndDotsAndAddSeparator = 4
    <Description("Format 'yyyymmdd_hhmmss' -> 'yyyy-mm-dd hh.mm.ss'")>
    InsertDashesAndDotsAndChangeSeparator = 5
    <Description("Format 'yyyy-mm-dd_hhmmss' -> 'yyyy-mm-dd hh.mm.ss'")>
    InsertDotsInTimeAndChangeSeparator = 6
    <Description("Format 'yyyy-mm-dd hh mm ss' -> 'yyyy-mm-dd hh.mm.ss'")>
    InsertDotsInTime = 7
    <Description("Format 'dd-mm-yy' -> 'yyyy-mm-dd'")>
    ChangeFormatOfExistingDate = 8
    <Description("Remove first 19 characters 'yyyy-mm-dd hh.mm.ss'")>
    RemoveFirst19Characters = 9
    <Description("For .M2TS e .MODD files - Decrease by 6:45h 'yyyyMMddHHmmss' (Hardcoded)")>
    ChangeVideoFiles = 10
End Enum

Enum ChangeDateTakenMetadataMethod As Integer
    FromFileName = 0
    FromSpecificDate = 1
    IncrementingHours = 2
End Enum

Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RenameMethodList As New List(Of Object)
        For Each EnumValue In [Enum].GetValues(GetType(RenameMethod))
            Dim strDescription As String = GetEnumDescription(EnumValue)
            RenameMethodList.Add(New With {.Value = EnumValue, .Description = strDescription})
        Next
        cmbRenameMethod.DisplayMember = "Description"
        cmbRenameMethod.ValueMember = "Value"
        cmbRenameMethod.DataSource = RenameMethodList

        Dim FolderSettingValue As Object
        FolderSettingValue = My.Settings.Folder 'Retrieve Setting from AppData windows folder
        'FolderSettingValue = ReadSetting("Folder")
        If Not FolderSettingValue Is Nothing Then
            txtFolder.Text = FolderSettingValue.ToString
            btnListFiles_Click(sender, e)
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub

#Region "Parameters"

    Private Sub btnLocateFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocateFolder.Click
        If System.IO.Directory.Exists(txtFolder.Text) Then
            FolderBrowserDialog.SelectedPath = txtFolder.Text
        End If
        FolderBrowserDialog.ShowDialog()
        txtFolder.Text = FolderBrowserDialog.SelectedPath
    End Sub

    Private Sub btnClearFiles_Click(sender As Object, e As EventArgs) Handles btnClearFiles.Click
        lvwFiles.Items.Clear()
    End Sub

    Private Sub btnListFiles_Click(sender As Object, e As EventArgs) Handles btnListFiles.Click
        Try
            'Save in config file
            My.Settings.Folder = txtFolder.Text
            My.Settings.Save()
            'AddUpdateAppSettings("Folder", txtFolder.Text)

            lvwFiles.Items.Clear()
            lvwFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            lvwFiles.Columns.Clear()
            lvwFiles.Columns.Add("File")
            lvwFiles.Columns.Add("DateTaken")

            If Not System.IO.Directory.Exists(txtFolder.Text) Then
                Throw New Exception("Folder '" + txtFolder.Text + "' does not exist.")
            End If

            Dim strFiles As String() = System.IO.Directory.GetFiles(txtFolder.Text)
            Dim strFile As String
            Dim Lvi As ListViewItem

            For Each strFile In strFiles
                Lvi = New ListViewItem(strFile)
                Lvi.SubItems.Add(strFile)
                Lvi.SubItems.Add("")
                lvwFiles.Items.Add(Lvi)
            Next
            lvwFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            Application.DoEvents()

            Dim strPhrase As String
            For Each Lvi In lvwFiles.Items
                strFile = Lvi.Text
                strPhrase = ""

                If strFile.ToUpper().EndsWith(".JPG") Or strFile.ToUpper().EndsWith(".JPEG") Or strFile.ToUpper().EndsWith(".PNG") Then
                    Dim Img As System.Drawing.Image
                    Try
                        Img = System.Drawing.Image.FromFile(strFile)

                        If strPhrase = "" Then
                            Dim intIndex As Integer
                            For intIndex = 0 To Img.PropertyIdList.Length - 1 'For Debug
                                If Img.PropertyIdList(intIndex) = 36867 Then 'Exif.Photo.DateTimeOriginal
                                    strPhrase = System.Text.Encoding.ASCII.GetString(Img.PropertyItems(intIndex).Value, 0, Img.PropertyItems(intIndex).Value.Length - 1)
                                    strPhrase = strPhrase.Substring(0, 10).Replace(":", "-") + strPhrase.Substring(10).Replace(":", ".")
                                    Exit For
                                End If
                            Next
                            Img.Dispose()
                        End If

                    Catch ex As Exception
                        strPhrase = ex.Message
                    End Try

                ElseIf strFile.ToUpper().EndsWith(".MOV") Or strFile.ToUpper().EndsWith(".MP4") Then
                    Try
                        Dim Shell As ShellObject = ShellObject.FromParsingName(strFile)
                        Dim Data = Shell.Properties.System.Media.DateEncoded
                        strPhrase = CDate(Data.Value).ToString("yyyy-MM-dd hh.mm.ss")
                    Catch ex As Exception
                        strPhrase = ex.Message
                    End Try

                Else
                    strPhrase = "Unexpected file type."
                End If

                Lvi.SubItems(1).Text = strPhrase
                Application.DoEvents()
            Next
            lvwFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

        Catch ex As Exception
            MsgBox(ex.Message.ToString, vbExclamation)
        End Try
    End Sub

#End Region

    'Region yet to be completed...
#Region "Indexar"

    Private Sub Rdb_Operador1_CheckedChanged(sender As Object, e As EventArgs) Handles rdbIndexSearchOperator1And.CheckedChanged, rdbIndexSearchOperator1Or.CheckedChanged
        rdbIndexSearchOperator1Or.Checked = (sender Is rdbIndexSearchOperator1Or)
        rdbIndexSearchOperator1And.Checked = (sender Is rdbIndexSearchOperator1And)
    End Sub

    Private Sub Rdb_Operador2_CheckedChanged(sender As Object, e As EventArgs) Handles rdbIndexSearchOperator2And.CheckedChanged, rdbIndexSearchOperator2Or.CheckedChanged
        rdbIndexSearchOperator2Or.Checked = (sender Is rdbIndexSearchOperator2Or)
        rdbIndexSearchOperator2And.Checked = (sender Is rdbIndexSearchOperator2And)
    End Sub

    Private Sub Btn_Buscar_Click(sender As Object, e As EventArgs) Handles btnIndexSearch.Click
        Dim Str_Palavra1 As String = txtIndexSearchWord1.Text
        Dim Str_Palavra2 As String = txtIndexSearchWord2.Text
        Dim Str_Palavra3 As String = txtIndexSearchWord3.Text

        If Str_Palavra1 = "" And Str_Palavra2 = "" And Str_Palavra3 = "" And Not dtpIndexSearchStartDate.Checked And Not dtpIndexSearchEndDate.Checked Then
            MsgBox("Informe pelo menos um parâmetro de pesquisa.")
            Exit Sub
        End If

        '//read file content in StreamReader
        'StreamReadertxt Reader = New StreamReader(fName);
        'szReadAll = txtReader.ReadToEnd();//Reads the whole text file To the End
        'txtReader.Close(); //Closes the text file after it Is fully read.
        'txtReader = null;
        '//search word in file content
        'If (Regex.IsMatch(szReadAll, "SearchME", RegexOptions.IgnoreCase)) // If the match Is found in allRead
        '  MessageBox.Show("found");
        'Else
        '  MessageBox.Show("not found");

        Dim Str_NovoNome As String = txtFolder.Text + "\Arqmast.mas"
        If System.IO.File.Exists(Str_NovoNome) Then
            'Dim Str_TodoConteudo as String = IO.File.ReadAllText(Str_NovoNome)
            Dim oStream As New System.IO.StreamReader(Str_NovoNome)
            Dim Str_Linha As String
            Do While oStream.Peek() >= 0
                Str_Linha = oStream.ReadLine()
                If Str_Linha.Contains("") Then

                    Stop
                    'Incluir Imagem na lista de resultados

                End If
            Loop
            oStream.Close()
        End If

        'Exibir List2.ListCount & " fotos selecionadas de " & File1.ListCount + 1
    End Sub

    Private Sub Btn_AtualizaIndiceMaster_Click() Handles btnIndexUpdateMasterIndex.Click
        Dim Str_NovoNome As String = txtFolder.Text + "\Arqmast.mas"
        'If Not System.IO.File.Exists(Str_NovoNome) Then
        'End If

        Dim oStream As New System.IO.StreamWriter(Str_NovoNome)

        lstLog.Items.Clear()
        progressBar.Value = 0
        progressBar.Maximum = lvwFiles.SelectedItems.Count - 1

        Dim Str_Arquivo As String
        Dim Lvi As ListViewItem
        For Each Lvi In lvwFiles.SelectedItems
            Str_Arquivo = Lvi.Text

            Dim Str_Caminho As String = Str_Arquivo.Substring(0, Str_Arquivo.LastIndexOf("\"))
            Dim Str_Nome As String = Str_Arquivo.Substring(Str_Arquivo.LastIndexOf("\") + 1)
            Dim Str_Extensao As String = Str_Nome.Substring(Str_Nome.LastIndexOf(".") + 1, Str_Nome.Length - Str_Nome.LastIndexOf(".") - 1)
            Str_Nome = Str_Nome.Substring(0, Str_Nome.Length - Str_Extensao.Length - 1)
            Str_NovoNome = Str_Caminho + "\" + Str_Nome + ".fot"

            Dim Str_Descricao As String = ""
            Dim Dtr_Data As String = ""

            'Lê o arquivo .FOT
            If System.IO.File.Exists(Str_NovoNome) Then
                Dim oStreamFot As New System.IO.StreamReader(Str_NovoNome)
                Dim Str_Linha As String
                Do While oStreamFot.Peek() >= 0
                    Str_Linha = oStreamFot.ReadLine()
                    Stop
                    txtIndexDescription.Text = ""
                    dtpIndexDate.Value = Now
                Loop
                oStreamFot.Close()

                oStream.WriteLine("""" + Str_NovoNome + """,""" + txtIndexDescription.Text + """,""" + dtpIndexDate.ToString("dd/MM/yyyy") + """")
            End If

            lblProgress.Text = progressBar.Value.ToString + "/" + progressBar.Maximum.ToString
            progressBar.Increment(1)
            Application.DoEvents()
        Next

        oStream.Close()

    End Sub

    Private Sub Lst_Arquivos_SelectedIndexChanged(sender As Object, e As EventArgs)
        'Dim Str_Arquivo As String = Lvw_Arquivos.SelectedItem.text
        ''Pct_Preview.Image = Image.FromFile(Str_Arquivo)

        'Dim Str_NovoNome As String = ""
        'Dim Str_Caminho As String = Str_Arquivo.Substring(0, Str_Arquivo.LastIndexOf("\"))
        'Dim Str_Nome As String = Str_Arquivo.Substring(Str_Arquivo.LastIndexOf("\") + 1)
        'Dim Str_Extensao As String = Str_Nome.Substring(Str_Nome.LastIndexOf(".") + 1, Str_Nome.Length - Str_Nome.LastIndexOf(".") - 1)
        'Str_Nome = Str_Nome.Substring(0, Str_Nome.Length - Str_Extensao.Length - 1)
        'Str_NovoNome = Str_Caminho + "\" + Str_Nome + ".fot"

        'If System.IO.File.Exists(Str_NovoNome) Then
        '   Dim oStream As New System.IO.StreamReader(Str_NovoNome)
        '   Dim Str_Linha As String
        '   Do While oStream.Peek() >= 0
        '      Str_Linha = oStream.ReadLine()
        '      Stop
        '      Txt_Descricao.Text = ""
        '      Dtp_Data.Value = Now
        '   Loop
        '   oStream.Close()
        'End If
    End Sub

#End Region

    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        If lvwFiles.SelectedItems.Count = 0 Then
            MsgBox("Please, select at least on file from the list.", vbExclamation)
            Exit Sub
        End If

        If Not chkPreviewOnly.Checked Then
            If chkActionChangeDateTakenMetadata.Checked Then
                If rdbChangeDateTakenToDateTimeInFileName.Checked Then
                    If MsgBox("Selected files will be overwritten with 'DateTaken' metadata changed to the date present in file name. Confirm?", vbYesNo + vbQuestion) <> vbYes Then
                        Exit Sub
                    End If
                ElseIf rdbChangeDateTakenToSpecificDateAndOriginalTime.Checked Then
                    If MsgBox("Selected files will be overwritten with 'DateTaken' metadata changed to " + dtpChangeDateTakenToSpecificDate.Value.ToString("dd/MM/yyyy") + " keeping original Time. Confirm?", vbYesNo + vbQuestion) <> vbYes Then
                        Exit Sub
                    End If
                ElseIf rdbChangeDateTakenIncreasingHours.Checked Then
                    If MsgBox("Selected files will be overwritten with 'DateTaken' metadata increased by " + numChangeDateTakenIncreaseHours.Value.ToString + " hours. Confirm?", vbYesNo + vbQuestion) <> vbYes Then
                        Exit Sub
                    End If
                End If
            End If
            If chkActionChangeFileDate.Checked Then
                If MsgBox("Selected files will have their 'Modified Date' attribute changed to the date present in the file name. Confirm?", vbYesNo + vbQuestion) <> vbYes Then
                    Exit Sub
                End If
            End If
        End If

        If chkActionGenerateThumbnail.Checked Then
            If Val(txtMaxHeight.Text) = 0 Then
                MsgBox("Maximun Height must be greater than zero.", vbExclamation)
                Exit Sub
            End If
            If Val(txtThumbnailMaxWidth.Text) = 0 Then
                MsgBox("Maximun Width must be greater than zero.", vbExclamation)
                Exit Sub
            End If
        End If

        lstLog.Items.Clear()
        progressBar.Value = 0
        progressBar.Maximum = lvwFiles.SelectedItems.Count - 1

        Dim strFileName As String
        Dim Lvi As ListViewItem

        Try
            For Each Lvi In lvwFiles.SelectedItems
                strFileName = Lvi.Text

                If chkActionChangeDateTakenMetadata.Checked Then
                    If rdbChangeDateTakenToDateTimeInFileName.Checked Then
                        Sl_ChangeDateTakenMetadata(strFileName, ChangeDateTakenMetadataMethod.FromFileName)
                    ElseIf rdbChangeDateTakenToSpecificDateAndOriginalTime.Checked Then
                        Sl_ChangeDateTakenMetadata(strFileName, ChangeDateTakenMetadataMethod.FromSpecificDate)
                    ElseIf rdbChangeDateTakenIncreasingHours.Checked Then
                        Sl_ChangeDateTakenMetadata(strFileName, ChangeDateTakenMetadataMethod.IncrementingHours)
                    End If
                End If
                If chkActionChangeFileDate.Checked Then
                    Sl_ChangeFileDate(strFileName)
                End If
                If chkActionRenameFiles.Checked Then
                    Sl_RenameFile(strFileName)
                End If
                If chkActionGenerateThumbnail.Checked Then
                    Sl_GenerateThumbnail(strFileName)
                End If
                If chkActionIndex.Checked Then
                    Sl_SaveIndex(strFileName)
                End If

                lblProgress.Text = progressBar.Value.ToString + "/" + progressBar.Maximum.ToString
                progressBar.Increment(1)
                Application.DoEvents()
            Next

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub

    Private Sub Sl_SaveIndex(strFile As String)
        Dim strNewName As String = ""
        Dim strPath As String = strFile.Substring(0, strFile.LastIndexOf("\"))
        Dim strName As String = strFile.Substring(strFile.LastIndexOf("\") + 1)
        Dim strExtension As String = strName.Substring(strName.LastIndexOf(".") + 1, strName.Length - strName.LastIndexOf(".") - 1)
        strName = strName.Substring(0, strName.Length - strExtension.Length - 1)
        strNewName = strPath + "\" + strName + ".fot"

        'If Not System.IO.File.Exists(strFileIni) Then

        'End If

        Dim oStream As New System.IO.StreamWriter(strNewName)
        oStream.WriteLine("""" + txtIndexDescription.Text + """,""" + dtpIndexDate.ToString("dd/MM/yyyy") + """")
        oStream.Close()
    End Sub

    Private Sub Sl_ChangeFileDate(strFile As String)

        Dim strPath As String = strFile.Substring(0, strFile.LastIndexOf("\"))
        Dim strName As String = strFile.Substring(strFile.LastIndexOf("\") + 1)

        Dim dthExistingCreateDate As Date = System.IO.File.GetLastWriteTime(strFile)
        Dim dthNewCreateDate As Date = DateSerial(strName.Substring(0, 4), strName.Substring(5, 2), strName.Substring(8, 2))

        If Not chkChangeTimeFile.Checked Then
            dthNewCreateDate = dthNewCreateDate.AddHours(12)
        Else
            dthNewCreateDate = dthNewCreateDate.AddHours(strName.Substring(11, 2)).AddMinutes(strName.Substring(14, 2)).AddSeconds(strName.Substring(17, 2))
        End If

        'File date and time ("yyyy-mm-dd hh.mm.ss")
        'System.IO.File.GetLastWriteTime(strFile).ToString("yyyy-MM-dd HH.mm.ss")

        lstLog.Items.Add(strFile + " - Existing CreateDate: " + dthExistingCreateDate.ToString + " New CreateDate: " + dthNewCreateDate.ToString)

        If Not chkPreviewOnly.Checked Then
            System.IO.File.SetCreationTime(strFile, dthNewCreateDate)
            System.IO.File.SetLastWriteTime(strFile, dthNewCreateDate)
            System.IO.File.SetLastAccessTime(strFile, dthNewCreateDate)
        End If

    End Sub

    Private Sub Sl_RenameFile(ByVal strFile As String)

        Dim strNewName As String = ""
        Dim strPath As String = strFile.Substring(0, strFile.LastIndexOf("\"))
        Dim strName As String = strFile.Substring(strFile.LastIndexOf("\") + 1)
        Dim strExtension As String = strName.Substring(strName.LastIndexOf(".") + 1, strName.Length - strName.LastIndexOf(".") - 1)
        strName = strName.Substring(0, strName.Length - strExtension.Length - 1)

        If numRenameRemoveInitialCharacters.Value > 0 Then
            strName = strName.Substring(numRenameRemoveInitialCharacters.Value)
        End If
        If numRenameRemoveFinalCharacters.Value > 0 Then
            strName = strName.Substring(0, strName.Length - numRenameRemoveFinalCharacters.Value)
        End If

        Select Case DirectCast(cmbRenameMethod.SelectedItem.value, RenameMethod)
            Case RenameMethod.NoPattern
                strNewName = strPath + "\" + strName

            Case RenameMethod.UseDateTakenMetadataWithTime,    'yyyy-mm-dd hh.mm.ss'
                 RenameMethod.UseDateTakenMetadataWithoutTime  'yyyy-mm-dd'
                Dim strPhrase As String
                Dim dthDateTaken As Date
                Try
                    If strFile.ToUpper().EndsWith(".JPG") Or strFile.ToUpper().EndsWith(".JPEG") Or strFile.ToUpper().EndsWith(".PNG") Then
                        Dim oImage As Image = Image.FromFile(strFile)
                        Dim intIndex As Integer
                        For intIndex = 0 To oImage.PropertyIdList.Length - 1 'For Debug
                            If oImage.PropertyIdList(intIndex) = 36867 Then 'Exif.Photo.DateTimeOriginal
                                strPhrase = System.Text.Encoding.ASCII.GetString(oImage.PropertyItems(intIndex).Value, 0, oImage.PropertyItems(intIndex).Value.Length - 1)
                                strPhrase = strPhrase.Substring(0, 10).Replace(":", "-") + strPhrase.Substring(10).Replace(":", ".")
                                dthDateTaken = DateSerial(strPhrase.Substring(0, 4), strPhrase.Substring(5, 2), strPhrase.Substring(8, 2)).AddHours(strPhrase.Substring(11, 2)).AddMinutes(strPhrase.Substring(14, 2)).AddSeconds(strPhrase.Substring(17, 2))
                                Exit For
                            End If
                        Next
                        oImage.Dispose()

                    ElseIf strFile.ToUpper().EndsWith(".MOV") Or strFile.ToUpper().EndsWith(".MP4") Then
                        Dim Shell As ShellObject = ShellObject.FromParsingName(strFile)
                        Dim Data = Shell.Properties.System.Media.DateEncoded
                        dthDateTaken = CDate(Data.Value)

                    End If

                    If dthDateTaken <> DateTime.MinValue Then
                        If cmbRenameMethod.SelectedItem.value = RenameMethod.UseDateTakenMetadataWithTime Then
                            strNewName = strPath + "\" + dthDateTaken.ToString("yyyy-MM-dd HH.mm.ss") 'strPhrase
                        ElseIf cmbRenameMethod.SelectedItem.value = RenameMethod.UseDateTakenMetadataWithTime Then
                            strNewName = strPath + "\" + dthDateTaken.ToString("yyyy-MM-dd") 'strPhrase
                        End If
                    End If
                Catch ex As Exception
                    lstLog.Items.Add(ex.Message)
                End Try

            Case RenameMethod.UseDateAndTimeFromFileAttribute

                strNewName = strPath + "\" + System.IO.File.GetLastWriteTime(strFile).ToString("yyyy-MM-dd HH.mm.ss")

            Case RenameMethod.InsertDashesAndDotsAndAddSeparator 'yyyymmddhhmmss -> yyyy-mm-dd hh.mm.ss
                Dim strTempName As String = strName
                strTempName = strTempName.Insert(12, ".")
                strTempName = strTempName.Insert(10, ".")
                strTempName = strTempName.Insert(8, " ")
                strTempName = strTempName.Insert(6, "-")
                strTempName = strTempName.Insert(4, "-")
                strNewName = strPath + "\" + strTempName

            Case RenameMethod.InsertDashesAndDotsAndChangeSeparator 'yyyymmdd_hhmmss -> yyyy-mm-dd hh.mm.ss
                Dim strTempName As String = strName
                strTempName = strTempName.Remove(8, 1)
                strTempName = strTempName.Insert(12, ".")
                strTempName = strTempName.Insert(10, ".")
                strTempName = strTempName.Insert(8, " ")
                strTempName = strTempName.Insert(6, "-")
                strTempName = strTempName.Insert(4, "-")
                strNewName = strPath + "\" + strTempName

            Case RenameMethod.InsertDotsInTimeAndChangeSeparator 'yyyy-mm-dd_hhmmss -> yyyy-mm-dd hh.mm.ss
                Dim strTempName As String = strName
                strTempName = strTempName.Remove(10, 1)
                strTempName = strTempName.Insert(14, ".")
                strTempName = strTempName.Insert(12, ".")
                strTempName = strTempName.Insert(10, " ")
                strNewName = strPath + "\" + strTempName
'            
            Case RenameMethod.InsertDotsInTime 'yyyy-mm-dd hh mm ss -> yyyy-mm-dd hh.mm.ss
                Dim strTempName As String = strName
                strTempName = strTempName.Remove(13, 1)
                strTempName = strTempName.Insert(13, ".")
                strTempName = strTempName.Remove(16, 1)
                strTempName = strTempName.Insert(16, ".")
                strNewName = strPath + "\" + strTempName
'
            Case RenameMethod.ChangeFormatOfExistingDate 'dd-mm-yy -> yyyy-mm-dd
                Dim strTempName As String = ""
                strTempName = "20" + strName.Substring(6, 2) + "-" + strName.Substring(3, 2) + "-" + strName.Substring(0, 2) + strName.Substring(8)
                strNewName = strPath + "\" + strTempName

            Case RenameMethod.RemoveFirst19Characters 'yyyy-mm-dd hh.mm.ss
                strNewName = strName.Substring(0, 19)

            Case RenameMethod.ChangeVideoFiles

                If strFile.ToUpper.EndsWith(".M2TS") Or strFile.ToUpper.EndsWith(".MODD") Then

                    Dim Dth As Date = DateSerial(strName.Substring(0, 4), strName.Substring(4, 2), strName.Substring(6, 2))
                    Dth = Dth.AddHours(strName.Substring(8, 2))
                    Dth = Dth.AddMinutes(strName.Substring(10, 2))
                    Dth = Dth.AddSeconds(strName.Substring(12, 2))

                    Dth = Dth.AddHours(-6)
                    Dth = Dth.AddMinutes(-45)

                    strNewName = Dth.ToString("yyyyMMddHHmmss") + strName.Substring(14)
                End If

        End Select
        If strNewName = "" Then
            lstLog.Items.Add(strFile + " - New name: " + strNewName)
        Else
            If txtEventName.Text <> "" Then
                strNewName += " - " + txtEventName.Text
            End If
            If chkRenameConcatenateOriginalName.Checked Then
                strNewName += " - " + strName
            End If
            strNewName += "." + strExtension

            lstLog.Items.Add(strFile + " - New name: " + strNewName)
            If System.IO.File.Exists(strNewName) Then
                lstLog.Items.Add(strNewName + " already exists!")
            End If

            If Not chkPreviewOnly.Checked Then
                If System.IO.File.Exists(strNewName) Then
                    If chkChangeFileDateAppend2InRepeated.Checked Then

                        Dim numTries As Integer = 2
                        Do While numTries < 10
                            Dim Str_Nome2 As String
                            Str_Nome2 = strNewName.Substring(0, strNewName.Length - (strExtension.Length + 1)) + " " + numTries.ToString() + "." + strExtension

                            If Not System.IO.File.Exists(Str_Nome2) Then
                                strNewName = Str_Nome2
                                Exit Do
                            End If
                            numTries += 1
                        Loop

                    End If
                End If
                If Not System.IO.File.Exists(strNewName) Then
                    System.IO.File.Move(strFile, strNewName)
                End If
            End If
        End If

    End Sub

    Private Sub Sl_ChangeDateTakenMetadata(strFile As String, intChangeDateTakenMethod As ChangeDateTakenMetadataMethod)
        'https://social.msdn.microsoft.com/Forums/vstudio/en-US/71d8de37-f52d-4faa-887a-793f8041110a/managing-general-exif-info-with-imagesetpropertyitem?forum=netfxbcl
        'http://dejanstojanovic.net/aspnet/2014/november/adding-extra-info-to-an-image-file/

        Dim strPath As String = strFile.Substring(0, strFile.LastIndexOf("\"))
        Dim strName As String = strFile.Substring(strFile.LastIndexOf("\") + 1)
        Dim strExtension As String = strName.Substring(strName.LastIndexOf(".") + 1, strName.Length - strName.LastIndexOf(".") - 1)
        strName = strName.Substring(0, strName.Length - strExtension.Length - 1)
        Dim strNewName As String = strPath + "\" + strName + "_2." + strExtension
        Dim strNewDate As String = ""

        If intChangeDateTakenMethod = ChangeDateTakenMetadataMethod.FromFileName Then
            'Format yyyy-mm-dd hh.mm.ss
            strNewDate = strName.Substring(0, 4) + ":" + strName.Substring(5, 2) + ":" + strName.Substring(8, 2) + " " + strName.Substring(11, 2) + ":" + strName.Substring(14, 2) + ":" + strName.Substring(17, 2)

            'Format yyyymmddhhmmss
            'strNewDate = strName.Substring(0, 4) + ":" + strName.Substring(4, 2) + ":" + strName.Substring(6, 2) + " " + strName.Substring(8, 2) + ":" + strName.Substring(10, 2) + ":" + strName.Substring(12, 2)
        End If

        Try
            Dim Img As System.Drawing.Image = System.Drawing.Image.FromFile(strFile)
            'http://www.exiv2.org/tags.html

            Dim blnFound As Boolean = False
            Dim intIndex As Integer
            For intIndex = 0 To Img.PropertyIdList.Length - 1 'For Debug
                If Img.PropertyIdList(intIndex) = 36867 Then 'Exif.Photo.DateTimeOriginal
                    blnFound = True
                    Exit For
                End If
            Next
            Dim PropItm As System.Drawing.Imaging.PropertyItem
            Dim strPhrase As String = ""
            If blnFound Then
                PropItm = Img.PropertyItems(intIndex)

                'Dim bytL As Byte
                'Dim intC As Integer
                'For intC = 0 To Img.PropertyItems(intIndex).Value.Length - 2 'ignores last item
                '   bytL = Img.PropertyItems(intIndex).Value(intC)
                '   Str_Frase += Chr(bytL)
                'Next
                strPhrase = System.Text.Encoding.ASCII.GetString(Img.PropertyItems(intIndex).Value, 0, Img.PropertyItems(intIndex).Value.Length - 1)
                strPhrase = strPhrase.Substring(0, 10).Replace(":", "-") + strPhrase.Substring(10).Replace(":", ".")

                Dim dthDateTaken As Date
                If intChangeDateTakenMethod = ChangeDateTakenMetadataMethod.FromSpecificDate Then
                    dthDateTaken = DateSerial(dtpChangeDateTakenToSpecificDate.Value.Year, dtpChangeDateTakenToSpecificDate.Value.Month, dtpChangeDateTakenToSpecificDate.Value.Day)
                    If Not dtpChangeDateTakenTime.Checked Then
                        'Use original hour
                        dthDateTaken = dthDateTaken.AddHours(strPhrase.Substring(11, 2)).AddMinutes(strPhrase.Substring(14, 2)).AddSeconds(strPhrase.Substring(17, 2))
                    Else
                        'Use informed hour
                        dthDateTaken = dthDateTaken.AddHours(dtpChangeDateTakenTime.Value.Hour).AddMinutes(dtpChangeDateTakenTime.Value.Minute).AddSeconds(dtpChangeDateTakenTime.Value.Second)
                    End If
                ElseIf intChangeDateTakenMethod = ChangeDateTakenMetadataMethod.IncrementingHours Then
                    dthDateTaken = DateSerial(strPhrase.Substring(0, 4), strPhrase.Substring(5, 2), strPhrase.Substring(8, 2)).AddHours(strPhrase.Substring(11, 2)).AddMinutes(strPhrase.Substring(14, 2)).AddSeconds(strPhrase.Substring(17, 2))
                    dthDateTaken = dthDateTaken.AddHours(numChangeDateTakenIncreaseHours.Value)
                End If
                If Not intChangeDateTakenMethod = ChangeDateTakenMetadataMethod.FromFileName Then
                    strNewDate = dthDateTaken.Year.ToString("0000") + ":" + dthDateTaken.Month.ToString("00") + ":" + dthDateTaken.Day.ToString("00") + " " + dthDateTaken.Hour.ToString("00") + ":" + dthDateTaken.Minute.ToString("00") + ":" + dthDateTaken.Second.ToString("00")
                End If
            Else
                If intChangeDateTakenMethod = ChangeDateTakenMetadataMethod.FromFileName Then
                    'Not found, then create property
                    PropItm = CType(System.Runtime.Serialization.FormatterServices.GetUninitializedObject(GetType(Imaging.PropertyItem)), Imaging.PropertyItem)
                    PropItm.Id = 36867
                    PropItm.Type = 2
                End If
            End If

            PropItm.Value = System.Text.ASCIIEncoding.ASCII.GetBytes(strNewDate + Chr(0))
            Img.SetPropertyItem(PropItm)
            lstLog.Items.Add(strFile + IIf(strPhrase <> "", " DateTaken " + strPhrase, "") + " - New DateTaken: " + strNewDate)
            If Not chkPreviewOnly.Checked Then
                Img.Save(strNewName, System.Drawing.Imaging.ImageFormat.Jpeg)
                Img.Dispose()
                'Replace original file by the new one
                FileIO.FileSystem.DeleteFile(strFile, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
                FileIO.FileSystem.RenameFile(strNewName, strFile.Substring(strFile.LastIndexOf("\") + 1))
            Else
                Img.Dispose()
            End If

        Catch ex As Exception
            lstLog.Items.Add(ex.Message)
        End Try

    End Sub

    Private Sub btnThumbnailLocateFolder_Click(sender As Object, e As EventArgs) Handles btnThumbnailLocateFolder.Click
        If System.IO.Directory.Exists(txtThumbnailDestinationFolder.Text) Then
            FolderBrowserDialog.SelectedPath = txtThumbnailDestinationFolder.Text
        End If
        FolderBrowserDialog.ShowDialog()
        txtThumbnailDestinationFolder.Text = FolderBrowserDialog.SelectedPath
    End Sub

    Private Sub Sl_GenerateThumbnail(ByVal strFile As String)

        Dim strDestinationFile As String = txtThumbnailDestinationFolder.Text + "\" + strFile.Substring(strFile.LastIndexOf("\") + 1)

        Dim imgOriginal As System.Drawing.Image
        Dim imgReduced As System.Drawing.Image

        Dim myCallback As System.Drawing.Image.GetThumbnailImageAbort
        Dim myPtr As IntPtr

        imgOriginal = System.Drawing.Image.FromFile(strFile)

        Dim intGreaterSide As Integer
        Dim strGreaterSide As String
        With imgOriginal
            If .Width > .Height Then
                intGreaterSide = .Width
                strGreaterSide = "W" 'Width
            Else
                intGreaterSide = .Height
                strGreaterSide = "H" 'Height
            End If

            Dim intMaximunWidth As Integer = Val(txtThumbnailMaxWidth.Text)
            Dim intMaximunHeight As Integer = Val(txtMaxHeight.Text)

            Dim intPercent As Integer
            intPercent = intMaximunHeight * 100 / intGreaterSide

            Dim intNewHeight As Integer
            Dim intNewWidth As Integer
            If strGreaterSide = "H" Then
                intNewHeight = intMaximunHeight
                intNewWidth = .Width * intPercent / 100
            Else
                intNewWidth = intMaximunHeight
                intNewHeight = .Height * intPercent / 100
            End If
            imgReduced = .GetThumbnailImage(intNewWidth, intNewHeight, myCallback, myPtr)
        End With

        'Replicate metadata to thumbnail
        Try
            Dim PropItm As System.Drawing.Imaging.PropertyItem
            For Each PropItm In imgOriginal.PropertyItems
                imgReduced.SetPropertyItem(PropItm)
            Next
        Catch ex As Exception

        End Try

        Try
            If Not chkPreviewOnly.Checked Then
                imgReduced.Save(strDestinationFile, System.Drawing.Imaging.ImageFormat.Jpeg)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub dtpChangeDateTakenTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpChangeDateTakenTime.ValueChanged
        lblChangeDateTakenKeepOriginalTime.Enabled = Not dtpChangeDateTakenTime.Checked
    End Sub

    Private Sub chkActionChangeFileDate_CheckedChanged(sender As Object, e As EventArgs) Handles chkActionChangeFileDate.CheckedChanged
        chkChangeTimeFile.Enabled = chkActionChangeFileDate.Checked
    End Sub
End Class
