<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnLocateFolder = New System.Windows.Forms.Button()
        Me.btnListFiles = New System.Windows.Forms.Button()
        Me.lblFolder = New System.Windows.Forms.Label()
        Me.txtFolder = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lvwFiles = New System.Windows.Forms.ListView()
        Me.btnClearFiles = New System.Windows.Forms.Button()
        Me.chkPreviewOnly = New System.Windows.Forms.CheckBox()
        Me.TabMain = New System.Windows.Forms.TabControl()
        Me.tabAction = New System.Windows.Forms.TabPage()
        Me.boxRename = New System.Windows.Forms.GroupBox()
        Me.chkActionRenameFiles = New System.Windows.Forms.CheckBox()
        Me.chkChangeFileDateAppend2NewFile = New System.Windows.Forms.RadioButton()
        Me.chkChangeFileDateAppend2ExistingFile = New System.Windows.Forms.RadioButton()
        Me.chkChangeFileDateAppend2InRepeated = New System.Windows.Forms.CheckBox()
        Me.numRenameRemoveFinalCharacters = New System.Windows.Forms.NumericUpDown()
        Me.lblRenameRemoveFinalCharacters = New System.Windows.Forms.Label()
        Me.numRenameRemoveInitialCharacters = New System.Windows.Forms.NumericUpDown()
        Me.lblRenameRemoveInitialCharacters = New System.Windows.Forms.Label()
        Me.lblRenameMethod = New System.Windows.Forms.Label()
        Me.chkRenameConcatenateOriginalName = New System.Windows.Forms.CheckBox()
        Me.lblEventName = New System.Windows.Forms.Label()
        Me.cmbRenameMethod = New System.Windows.Forms.ComboBox()
        Me.txtEventName = New System.Windows.Forms.TextBox()
        Me.chkChangeTimeFile = New System.Windows.Forms.CheckBox()
        Me.boxIndex = New System.Windows.Forms.GroupBox()
        Me.btnIndexUpdateMasterIndex = New System.Windows.Forms.Button()
        Me.rdbIndexSaveMetadata = New System.Windows.Forms.RadioButton()
        Me.rdbIndexSalveDotFotFile = New System.Windows.Forms.RadioButton()
        Me.txtIndexDescription = New System.Windows.Forms.TextBox()
        Me.dtpIndexDate = New System.Windows.Forms.DateTimePicker()
        Me.lblIndexDate = New System.Windows.Forms.Label()
        Me.lblIndexDescription = New System.Windows.Forms.Label()
        Me.chkActionIndex = New System.Windows.Forms.CheckBox()
        Me.boxThunbnail = New System.Windows.Forms.GroupBox()
        Me.txtMaxHeight = New System.Windows.Forms.TextBox()
        Me.txtThumbnailMaxWidth = New System.Windows.Forms.TextBox()
        Me.lblThumbnailMaxHeight = New System.Windows.Forms.Label()
        Me.lblThumbnailMaxWidth = New System.Windows.Forms.Label()
        Me.btnThumbnailLocateFolder = New System.Windows.Forms.Button()
        Me.txtThumbnailDestinationFolder = New System.Windows.Forms.TextBox()
        Me.lblThumbnailDestinationFolder = New System.Windows.Forms.Label()
        Me.chkActionGenerateThumbnail = New System.Windows.Forms.CheckBox()
        Me.boxMetadata = New System.Windows.Forms.GroupBox()
        Me.dtpChangeDateTakenTime = New System.Windows.Forms.DateTimePicker()
        Me.lblChangeDateTakenKeepOriginalTime = New System.Windows.Forms.Label()
        Me.dtpChangeDateTakenToSpecificDate = New System.Windows.Forms.DateTimePicker()
        Me.rdbChangeDateTakenToSpecificDateAndOriginalTime = New System.Windows.Forms.RadioButton()
        Me.rdbChangeDateTakenIncreasingHours = New System.Windows.Forms.RadioButton()
        Me.rdbChangeDateTakenToDateTimeInFileName = New System.Windows.Forms.RadioButton()
        Me.chkActionChangeDateTakenMetadata = New System.Windows.Forms.CheckBox()
        Me.lblChangeDateTakenIncreaseHours = New System.Windows.Forms.Label()
        Me.numChangeDateTakenIncreaseHours = New System.Windows.Forms.NumericUpDown()
        Me.chkActionChangeFileDate = New System.Windows.Forms.CheckBox()
        Me.tabIndex = New System.Windows.Forms.TabPage()
        Me.pctPreview = New System.Windows.Forms.PictureBox()
        Me.boxIndexSearch = New System.Windows.Forms.GroupBox()
        Me.rdbIndexSearchOperator2Or = New System.Windows.Forms.RadioButton()
        Me.btnIndexSearch = New System.Windows.Forms.Button()
        Me.lblIndexSearchKeyWords = New System.Windows.Forms.Label()
        Me.rdbIndexSearchOperator2And = New System.Windows.Forms.RadioButton()
        Me.txtIndexSearchWord1 = New System.Windows.Forms.TextBox()
        Me.rdbIndexSearchOperator1Or = New System.Windows.Forms.RadioButton()
        Me.txtIndexSearchWord2 = New System.Windows.Forms.TextBox()
        Me.rdbIndexSearchOperator1And = New System.Windows.Forms.RadioButton()
        Me.txtIndexSearchWord3 = New System.Windows.Forms.TextBox()
        Me.dtpIndexSearchEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpIndexSearchStartDate = New System.Windows.Forms.DateTimePicker()
        Me.lstLog = New System.Windows.Forms.ListBox()
        Me.lblProgress = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabMain.SuspendLayout()
        Me.tabAction.SuspendLayout()
        Me.boxRename.SuspendLayout()
        CType(Me.numRenameRemoveFinalCharacters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRenameRemoveInitialCharacters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.boxIndex.SuspendLayout()
        Me.boxThunbnail.SuspendLayout()
        Me.boxMetadata.SuspendLayout()
        CType(Me.numChangeDateTakenIncreaseHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabIndex.SuspendLayout()
        CType(Me.pctPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.boxIndexSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLocateFolder
        '
        Me.btnLocateFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLocateFolder.Location = New System.Drawing.Point(198, 6)
        Me.btnLocateFolder.Name = "btnLocateFolder"
        Me.btnLocateFolder.Size = New System.Drawing.Size(44, 21)
        Me.btnLocateFolder.TabIndex = 2
        Me.btnLocateFolder.Text = "Folder"
        '
        'btnListFiles
        '
        Me.btnListFiles.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListFiles.Location = New System.Drawing.Point(244, 6)
        Me.btnListFiles.Name = "btnListFiles"
        Me.btnListFiles.Size = New System.Drawing.Size(40, 21)
        Me.btnListFiles.TabIndex = 3
        Me.btnListFiles.Text = "List"
        Me.btnListFiles.UseVisualStyleBackColor = True
        '
        'lblFolder
        '
        Me.lblFolder.AutoSize = True
        Me.lblFolder.Location = New System.Drawing.Point(3, 10)
        Me.lblFolder.Name = "lblFolder"
        Me.lblFolder.Size = New System.Drawing.Size(36, 13)
        Me.lblFolder.TabIndex = 0
        Me.lblFolder.Text = "Folder"
        '
        'txtFolder
        '
        Me.txtFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFolder.Location = New System.Drawing.Point(43, 7)
        Me.txtFolder.Name = "txtFolder"
        Me.txtFolder.Size = New System.Drawing.Size(149, 20)
        Me.txtFolder.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(568, 7)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        '
        'progressBar
        '
        Me.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.progressBar.Location = New System.Drawing.Point(0, 537)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(1024, 16)
        Me.progressBar.TabIndex = 2
        '
        'btnExecute
        '
        Me.btnExecute.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExecute.Location = New System.Drawing.Point(568, 37)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(100, 23)
        Me.btnExecute.TabIndex = 2
        Me.btnExecute.Text = "Execute"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lvwFiles)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnClearFiles)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnListFiles)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnLocateFolder)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFolder)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtFolder)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnExit)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnExecute)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkPreviewOnly)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabMain)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lstLog)
        Me.SplitContainer1.Size = New System.Drawing.Size(1019, 518)
        Me.SplitContainer1.SplitterDistance = 338
        Me.SplitContainer1.TabIndex = 0
        '
        'lvwFiles
        '
        Me.lvwFiles.AllowColumnReorder = True
        Me.lvwFiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwFiles.FullRowSelect = True
        Me.lvwFiles.GridLines = True
        Me.lvwFiles.HideSelection = False
        Me.lvwFiles.Location = New System.Drawing.Point(0, 35)
        Me.lvwFiles.Name = "lvwFiles"
        Me.lvwFiles.Size = New System.Drawing.Size(333, 480)
        Me.lvwFiles.TabIndex = 5
        Me.lvwFiles.UseCompatibleStateImageBehavior = False
        Me.lvwFiles.View = System.Windows.Forms.View.Details
        '
        'btnClearFiles
        '
        Me.btnClearFiles.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearFiles.Location = New System.Drawing.Point(287, 6)
        Me.btnClearFiles.Name = "btnClearFiles"
        Me.btnClearFiles.Size = New System.Drawing.Size(46, 21)
        Me.btnClearFiles.TabIndex = 4
        Me.btnClearFiles.Text = "Clear"
        '
        'chkPreviewOnly
        '
        Me.chkPreviewOnly.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkPreviewOnly.Checked = True
        Me.chkPreviewOnly.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPreviewOnly.Location = New System.Drawing.Point(568, 64)
        Me.chkPreviewOnly.Name = "chkPreviewOnly"
        Me.chkPreviewOnly.Size = New System.Drawing.Size(100, 40)
        Me.chkPreviewOnly.TabIndex = 3
        Me.chkPreviewOnly.Text = "Preview changes only."
        Me.chkPreviewOnly.UseVisualStyleBackColor = True
        '
        'TabMain
        '
        Me.TabMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabMain.Controls.Add(Me.tabAction)
        Me.TabMain.Controls.Add(Me.tabIndex)
        Me.TabMain.Location = New System.Drawing.Point(3, 7)
        Me.TabMain.Name = "TabMain"
        Me.TabMain.SelectedIndex = 0
        Me.TabMain.Size = New System.Drawing.Size(559, 376)
        Me.TabMain.TabIndex = 0
        '
        'tabAction
        '
        Me.tabAction.Controls.Add(Me.boxRename)
        Me.tabAction.Controls.Add(Me.chkChangeTimeFile)
        Me.tabAction.Controls.Add(Me.boxIndex)
        Me.tabAction.Controls.Add(Me.boxThunbnail)
        Me.tabAction.Controls.Add(Me.boxMetadata)
        Me.tabAction.Controls.Add(Me.chkActionChangeFileDate)
        Me.tabAction.Location = New System.Drawing.Point(4, 22)
        Me.tabAction.Name = "tabAction"
        Me.tabAction.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAction.Size = New System.Drawing.Size(551, 350)
        Me.tabAction.TabIndex = 0
        Me.tabAction.Text = "Actions"
        Me.tabAction.UseVisualStyleBackColor = True
        '
        'boxRename
        '
        Me.boxRename.Controls.Add(Me.chkActionRenameFiles)
        Me.boxRename.Controls.Add(Me.chkChangeFileDateAppend2NewFile)
        Me.boxRename.Controls.Add(Me.chkChangeFileDateAppend2ExistingFile)
        Me.boxRename.Controls.Add(Me.chkChangeFileDateAppend2InRepeated)
        Me.boxRename.Controls.Add(Me.numRenameRemoveFinalCharacters)
        Me.boxRename.Controls.Add(Me.lblRenameRemoveFinalCharacters)
        Me.boxRename.Controls.Add(Me.numRenameRemoveInitialCharacters)
        Me.boxRename.Controls.Add(Me.lblRenameRemoveInitialCharacters)
        Me.boxRename.Controls.Add(Me.lblRenameMethod)
        Me.boxRename.Controls.Add(Me.chkRenameConcatenateOriginalName)
        Me.boxRename.Controls.Add(Me.lblEventName)
        Me.boxRename.Controls.Add(Me.cmbRenameMethod)
        Me.boxRename.Controls.Add(Me.txtEventName)
        Me.boxRename.Location = New System.Drawing.Point(6, 104)
        Me.boxRename.Name = "boxRename"
        Me.boxRename.Size = New System.Drawing.Size(539, 117)
        Me.boxRename.TabIndex = 3
        Me.boxRename.TabStop = False
        '
        'chkActionRenameFiles
        '
        Me.chkActionRenameFiles.AutoSize = True
        Me.chkActionRenameFiles.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.chkActionRenameFiles.Location = New System.Drawing.Point(10, -2)
        Me.chkActionRenameFiles.Name = "chkActionRenameFiles"
        Me.chkActionRenameFiles.Size = New System.Drawing.Size(90, 17)
        Me.chkActionRenameFiles.TabIndex = 0
        Me.chkActionRenameFiles.Text = "Rename Files"
        Me.chkActionRenameFiles.UseVisualStyleBackColor = False
        '
        'chkChangeFileDateAppend2NewFile
        '
        Me.chkChangeFileDateAppend2NewFile.AutoSize = True
        Me.chkChangeFileDateAppend2NewFile.BackColor = System.Drawing.Color.Transparent
        Me.chkChangeFileDateAppend2NewFile.Location = New System.Drawing.Point(280, 93)
        Me.chkChangeFileDateAppend2NewFile.Name = "chkChangeFileDateAppend2NewFile"
        Me.chkChangeFileDateAppend2NewFile.Size = New System.Drawing.Size(82, 17)
        Me.chkChangeFileDateAppend2NewFile.TabIndex = 3
        Me.chkChangeFileDateAppend2NewFile.Text = "To New File"
        Me.chkChangeFileDateAppend2NewFile.UseVisualStyleBackColor = False
        '
        'chkChangeFileDateAppend2ExistingFile
        '
        Me.chkChangeFileDateAppend2ExistingFile.AutoSize = True
        Me.chkChangeFileDateAppend2ExistingFile.BackColor = System.Drawing.Color.Transparent
        Me.chkChangeFileDateAppend2ExistingFile.Checked = True
        Me.chkChangeFileDateAppend2ExistingFile.Location = New System.Drawing.Point(187, 93)
        Me.chkChangeFileDateAppend2ExistingFile.Name = "chkChangeFileDateAppend2ExistingFile"
        Me.chkChangeFileDateAppend2ExistingFile.Size = New System.Drawing.Size(96, 17)
        Me.chkChangeFileDateAppend2ExistingFile.TabIndex = 2
        Me.chkChangeFileDateAppend2ExistingFile.TabStop = True
        Me.chkChangeFileDateAppend2ExistingFile.Text = "To Existing File"
        Me.chkChangeFileDateAppend2ExistingFile.UseVisualStyleBackColor = False
        '
        'chkChangeFileDateAppend2InRepeated
        '
        Me.chkChangeFileDateAppend2InRepeated.AutoSize = True
        Me.chkChangeFileDateAppend2InRepeated.BackColor = System.Drawing.Color.Transparent
        Me.chkChangeFileDateAppend2InRepeated.Checked = True
        Me.chkChangeFileDateAppend2InRepeated.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkChangeFileDateAppend2InRepeated.Location = New System.Drawing.Point(10, 93)
        Me.chkChangeFileDateAppend2InRepeated.Name = "chkChangeFileDateAppend2InRepeated"
        Me.chkChangeFileDateAppend2InRepeated.Size = New System.Drawing.Size(184, 17)
        Me.chkChangeFileDateAppend2InRepeated.TabIndex = 1
        Me.chkChangeFileDateAppend2InRepeated.Text = "Append "" 2"" in repeated names..."
        Me.chkChangeFileDateAppend2InRepeated.UseVisualStyleBackColor = False
        '
        'numRenameRemoveFinalCharacters
        '
        Me.numRenameRemoveFinalCharacters.Location = New System.Drawing.Point(488, 67)
        Me.numRenameRemoveFinalCharacters.Name = "numRenameRemoveFinalCharacters"
        Me.numRenameRemoveFinalCharacters.Size = New System.Drawing.Size(40, 20)
        Me.numRenameRemoveFinalCharacters.TabIndex = 12
        '
        'lblRenameRemoveFinalCharacters
        '
        Me.lblRenameRemoveFinalCharacters.AutoSize = True
        Me.lblRenameRemoveFinalCharacters.Location = New System.Drawing.Point(357, 69)
        Me.lblRenameRemoveFinalCharacters.Name = "lblRenameRemoveFinalCharacters"
        Me.lblRenameRemoveFinalCharacters.Size = New System.Drawing.Size(126, 13)
        Me.lblRenameRemoveFinalCharacters.TabIndex = 11
        Me.lblRenameRemoveFinalCharacters.Text = "Remove Final Characters"
        '
        'numRenameRemoveInitialCharacters
        '
        Me.numRenameRemoveInitialCharacters.Location = New System.Drawing.Point(302, 67)
        Me.numRenameRemoveInitialCharacters.Name = "numRenameRemoveInitialCharacters"
        Me.numRenameRemoveInitialCharacters.Size = New System.Drawing.Size(40, 20)
        Me.numRenameRemoveInitialCharacters.TabIndex = 10
        '
        'lblRenameRemoveInitialCharacters
        '
        Me.lblRenameRemoveInitialCharacters.AutoSize = True
        Me.lblRenameRemoveInitialCharacters.Location = New System.Drawing.Point(170, 69)
        Me.lblRenameRemoveInitialCharacters.Name = "lblRenameRemoveInitialCharacters"
        Me.lblRenameRemoveInitialCharacters.Size = New System.Drawing.Size(128, 13)
        Me.lblRenameRemoveInitialCharacters.TabIndex = 9
        Me.lblRenameRemoveInitialCharacters.Text = "Remove Initial Characters"
        '
        'lblRenameMethod
        '
        Me.lblRenameMethod.AutoSize = True
        Me.lblRenameMethod.Location = New System.Drawing.Point(7, 45)
        Me.lblRenameMethod.Name = "lblRenameMethod"
        Me.lblRenameMethod.Size = New System.Drawing.Size(43, 13)
        Me.lblRenameMethod.TabIndex = 6
        Me.lblRenameMethod.Text = "Method"
        '
        'chkRenameConcatenateOriginalName
        '
        Me.chkRenameConcatenateOriginalName.AutoSize = True
        Me.chkRenameConcatenateOriginalName.Location = New System.Drawing.Point(10, 68)
        Me.chkRenameConcatenateOriginalName.Name = "chkRenameConcatenateOriginalName"
        Me.chkRenameConcatenateOriginalName.Size = New System.Drawing.Size(156, 17)
        Me.chkRenameConcatenateOriginalName.TabIndex = 8
        Me.chkRenameConcatenateOriginalName.Text = "Concatenate Original Name"
        Me.chkRenameConcatenateOriginalName.UseVisualStyleBackColor = True
        '
        'lblEventName
        '
        Me.lblEventName.AutoSize = True
        Me.lblEventName.Location = New System.Drawing.Point(7, 20)
        Me.lblEventName.Name = "lblEventName"
        Me.lblEventName.Size = New System.Drawing.Size(66, 13)
        Me.lblEventName.TabIndex = 4
        Me.lblEventName.Text = "Event Name"
        '
        'cmbRenameMethod
        '
        Me.cmbRenameMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRenameMethod.FormattingEnabled = True
        Me.cmbRenameMethod.Location = New System.Drawing.Point(76, 42)
        Me.cmbRenameMethod.Name = "cmbRenameMethod"
        Me.cmbRenameMethod.Size = New System.Drawing.Size(452, 21)
        Me.cmbRenameMethod.TabIndex = 7
        '
        'txtEventName
        '
        Me.txtEventName.Location = New System.Drawing.Point(76, 18)
        Me.txtEventName.Name = "txtEventName"
        Me.txtEventName.Size = New System.Drawing.Size(452, 20)
        Me.txtEventName.TabIndex = 5
        '
        'chkChangeTimeFile
        '
        Me.chkChangeTimeFile.AutoSize = True
        Me.chkChangeTimeFile.Location = New System.Drawing.Point(245, 80)
        Me.chkChangeTimeFile.Name = "chkChangeTimeFile"
        Me.chkChangeTimeFile.Size = New System.Drawing.Size(107, 17)
        Me.chkChangeTimeFile.TabIndex = 2
        Me.chkChangeTimeFile.Text = "Change Time too"
        Me.chkChangeTimeFile.UseVisualStyleBackColor = True
        '
        'boxIndex
        '
        Me.boxIndex.Controls.Add(Me.btnIndexUpdateMasterIndex)
        Me.boxIndex.Controls.Add(Me.rdbIndexSaveMetadata)
        Me.boxIndex.Controls.Add(Me.rdbIndexSalveDotFotFile)
        Me.boxIndex.Controls.Add(Me.txtIndexDescription)
        Me.boxIndex.Controls.Add(Me.dtpIndexDate)
        Me.boxIndex.Controls.Add(Me.lblIndexDate)
        Me.boxIndex.Controls.Add(Me.lblIndexDescription)
        Me.boxIndex.Controls.Add(Me.chkActionIndex)
        Me.boxIndex.Location = New System.Drawing.Point(7, 275)
        Me.boxIndex.Name = "boxIndex"
        Me.boxIndex.Size = New System.Drawing.Size(538, 70)
        Me.boxIndex.TabIndex = 5
        Me.boxIndex.TabStop = False
        '
        'btnIndexUpdateMasterIndex
        '
        Me.btnIndexUpdateMasterIndex.Enabled = False
        Me.btnIndexUpdateMasterIndex.Location = New System.Drawing.Point(447, 19)
        Me.btnIndexUpdateMasterIndex.Name = "btnIndexUpdateMasterIndex"
        Me.btnIndexUpdateMasterIndex.Size = New System.Drawing.Size(85, 39)
        Me.btnIndexUpdateMasterIndex.TabIndex = 7
        Me.btnIndexUpdateMasterIndex.Text = "Update Master Index"
        Me.btnIndexUpdateMasterIndex.UseVisualStyleBackColor = True
        '
        'rdbIndexSaveMetadata
        '
        Me.rdbIndexSaveMetadata.AutoSize = True
        Me.rdbIndexSaveMetadata.Enabled = False
        Me.rdbIndexSaveMetadata.Location = New System.Drawing.Point(104, 47)
        Me.rdbIndexSaveMetadata.Name = "rdbIndexSaveMetadata"
        Me.rdbIndexSaveMetadata.Size = New System.Drawing.Size(70, 17)
        Me.rdbIndexSaveMetadata.TabIndex = 4
        Me.rdbIndexSaveMetadata.Text = "Metadata"
        Me.rdbIndexSaveMetadata.UseVisualStyleBackColor = True
        '
        'rdbIndexSalveDotFotFile
        '
        Me.rdbIndexSalveDotFotFile.AutoSize = True
        Me.rdbIndexSalveDotFotFile.Checked = True
        Me.rdbIndexSalveDotFotFile.Location = New System.Drawing.Point(10, 47)
        Me.rdbIndexSalveDotFotFile.Name = "rdbIndexSalveDotFotFile"
        Me.rdbIndexSalveDotFotFile.Size = New System.Drawing.Size(68, 17)
        Me.rdbIndexSalveDotFotFile.TabIndex = 3
        Me.rdbIndexSalveDotFotFile.TabStop = True
        Me.rdbIndexSalveDotFotFile.Text = ".FOT File"
        Me.rdbIndexSalveDotFotFile.UseVisualStyleBackColor = True
        '
        'txtIndexDescription
        '
        Me.txtIndexDescription.Location = New System.Drawing.Point(207, 19)
        Me.txtIndexDescription.Multiline = True
        Me.txtIndexDescription.Name = "txtIndexDescription"
        Me.txtIndexDescription.Size = New System.Drawing.Size(234, 39)
        Me.txtIndexDescription.TabIndex = 6
        '
        'dtpIndexDate
        '
        Me.dtpIndexDate.CustomFormat = ""
        Me.dtpIndexDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpIndexDate.Location = New System.Drawing.Point(45, 19)
        Me.dtpIndexDate.Name = "dtpIndexDate"
        Me.dtpIndexDate.Size = New System.Drawing.Size(95, 20)
        Me.dtpIndexDate.TabIndex = 2
        '
        'lblIndexDate
        '
        Me.lblIndexDate.AutoSize = True
        Me.lblIndexDate.Location = New System.Drawing.Point(7, 22)
        Me.lblIndexDate.Name = "lblIndexDate"
        Me.lblIndexDate.Size = New System.Drawing.Size(30, 13)
        Me.lblIndexDate.TabIndex = 1
        Me.lblIndexDate.Text = "Date"
        '
        'lblIndexDescription
        '
        Me.lblIndexDescription.AutoSize = True
        Me.lblIndexDescription.Location = New System.Drawing.Point(146, 22)
        Me.lblIndexDescription.Name = "lblIndexDescription"
        Me.lblIndexDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblIndexDescription.TabIndex = 5
        Me.lblIndexDescription.Text = "Description"
        '
        'chkActionIndex
        '
        Me.chkActionIndex.AutoSize = True
        Me.chkActionIndex.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.chkActionIndex.Enabled = False
        Me.chkActionIndex.Location = New System.Drawing.Point(10, -1)
        Me.chkActionIndex.Name = "chkActionIndex"
        Me.chkActionIndex.Size = New System.Drawing.Size(52, 17)
        Me.chkActionIndex.TabIndex = 0
        Me.chkActionIndex.Text = "Index"
        Me.chkActionIndex.UseVisualStyleBackColor = False
        '
        'boxThunbnail
        '
        Me.boxThunbnail.Controls.Add(Me.txtMaxHeight)
        Me.boxThunbnail.Controls.Add(Me.txtThumbnailMaxWidth)
        Me.boxThunbnail.Controls.Add(Me.lblThumbnailMaxHeight)
        Me.boxThunbnail.Controls.Add(Me.lblThumbnailMaxWidth)
        Me.boxThunbnail.Controls.Add(Me.btnThumbnailLocateFolder)
        Me.boxThunbnail.Controls.Add(Me.txtThumbnailDestinationFolder)
        Me.boxThunbnail.Controls.Add(Me.lblThumbnailDestinationFolder)
        Me.boxThunbnail.Controls.Add(Me.chkActionGenerateThumbnail)
        Me.boxThunbnail.Location = New System.Drawing.Point(6, 224)
        Me.boxThunbnail.Name = "boxThunbnail"
        Me.boxThunbnail.Size = New System.Drawing.Size(539, 44)
        Me.boxThunbnail.TabIndex = 4
        Me.boxThunbnail.TabStop = False
        '
        'txtMaxHeight
        '
        Me.txtMaxHeight.Location = New System.Drawing.Point(409, 16)
        Me.txtMaxHeight.Name = "txtMaxHeight"
        Me.txtMaxHeight.Size = New System.Drawing.Size(30, 20)
        Me.txtMaxHeight.TabIndex = 5
        Me.txtMaxHeight.Text = "160"
        '
        'txtThumbnailMaxWidth
        '
        Me.txtThumbnailMaxWidth.Location = New System.Drawing.Point(497, 16)
        Me.txtThumbnailMaxWidth.Name = "txtThumbnailMaxWidth"
        Me.txtThumbnailMaxWidth.Size = New System.Drawing.Size(30, 20)
        Me.txtThumbnailMaxWidth.TabIndex = 7
        Me.txtThumbnailMaxWidth.Text = "120"
        '
        'lblThumbnailMaxHeight
        '
        Me.lblThumbnailMaxHeight.AutoSize = True
        Me.lblThumbnailMaxHeight.Location = New System.Drawing.Point(350, 18)
        Me.lblThumbnailMaxHeight.Name = "lblThumbnailMaxHeight"
        Me.lblThumbnailMaxHeight.Size = New System.Drawing.Size(61, 13)
        Me.lblThumbnailMaxHeight.TabIndex = 4
        Me.lblThumbnailMaxHeight.Text = "Max Height"
        '
        'lblThumbnailMaxWidth
        '
        Me.lblThumbnailMaxWidth.AutoSize = True
        Me.lblThumbnailMaxWidth.Location = New System.Drawing.Point(442, 18)
        Me.lblThumbnailMaxWidth.Name = "lblThumbnailMaxWidth"
        Me.lblThumbnailMaxWidth.Size = New System.Drawing.Size(58, 13)
        Me.lblThumbnailMaxWidth.TabIndex = 6
        Me.lblThumbnailMaxWidth.Text = "Max Width"
        '
        'btnThumbnailLocateFolder
        '
        Me.btnThumbnailLocateFolder.Location = New System.Drawing.Point(301, 15)
        Me.btnThumbnailLocateFolder.Name = "btnThumbnailLocateFolder"
        Me.btnThumbnailLocateFolder.Size = New System.Drawing.Size(42, 21)
        Me.btnThumbnailLocateFolder.TabIndex = 3
        Me.btnThumbnailLocateFolder.Text = "Folder"
        '
        'txtThumbnailDestinationFolder
        '
        Me.txtThumbnailDestinationFolder.Location = New System.Drawing.Point(77, 16)
        Me.txtThumbnailDestinationFolder.Name = "txtThumbnailDestinationFolder"
        Me.txtThumbnailDestinationFolder.Size = New System.Drawing.Size(216, 20)
        Me.txtThumbnailDestinationFolder.TabIndex = 2
        '
        'lblThumbnailDestinationFolder
        '
        Me.lblThumbnailDestinationFolder.Location = New System.Drawing.Point(10, 20)
        Me.lblThumbnailDestinationFolder.Name = "lblThumbnailDestinationFolder"
        Me.lblThumbnailDestinationFolder.Size = New System.Drawing.Size(80, 16)
        Me.lblThumbnailDestinationFolder.TabIndex = 1
        Me.lblThumbnailDestinationFolder.Text = "Destination"
        '
        'chkActionGenerateThumbnail
        '
        Me.chkActionGenerateThumbnail.AutoSize = True
        Me.chkActionGenerateThumbnail.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.chkActionGenerateThumbnail.Location = New System.Drawing.Point(10, -1)
        Me.chkActionGenerateThumbnail.Name = "chkActionGenerateThumbnail"
        Me.chkActionGenerateThumbnail.Size = New System.Drawing.Size(119, 17)
        Me.chkActionGenerateThumbnail.TabIndex = 0
        Me.chkActionGenerateThumbnail.Text = "Gerarate Thumbnail"
        Me.chkActionGenerateThumbnail.UseVisualStyleBackColor = False
        '
        'boxMetadata
        '
        Me.boxMetadata.Controls.Add(Me.dtpChangeDateTakenTime)
        Me.boxMetadata.Controls.Add(Me.lblChangeDateTakenKeepOriginalTime)
        Me.boxMetadata.Controls.Add(Me.dtpChangeDateTakenToSpecificDate)
        Me.boxMetadata.Controls.Add(Me.rdbChangeDateTakenToSpecificDateAndOriginalTime)
        Me.boxMetadata.Controls.Add(Me.rdbChangeDateTakenIncreasingHours)
        Me.boxMetadata.Controls.Add(Me.rdbChangeDateTakenToDateTimeInFileName)
        Me.boxMetadata.Controls.Add(Me.chkActionChangeDateTakenMetadata)
        Me.boxMetadata.Controls.Add(Me.lblChangeDateTakenIncreaseHours)
        Me.boxMetadata.Controls.Add(Me.numChangeDateTakenIncreaseHours)
        Me.boxMetadata.Location = New System.Drawing.Point(6, 6)
        Me.boxMetadata.Name = "boxMetadata"
        Me.boxMetadata.Size = New System.Drawing.Size(539, 69)
        Me.boxMetadata.TabIndex = 0
        Me.boxMetadata.TabStop = False
        '
        'dtpChangeDateTakenTime
        '
        Me.dtpChangeDateTakenTime.Checked = False
        Me.dtpChangeDateTakenTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpChangeDateTakenTime.Location = New System.Drawing.Point(456, 19)
        Me.dtpChangeDateTakenTime.Name = "dtpChangeDateTakenTime"
        Me.dtpChangeDateTakenTime.ShowCheckBox = True
        Me.dtpChangeDateTakenTime.ShowUpDown = True
        Me.dtpChangeDateTakenTime.Size = New System.Drawing.Size(78, 20)
        Me.dtpChangeDateTakenTime.TabIndex = 8
        Me.dtpChangeDateTakenTime.Value = New Date(2017, 10, 22, 0, 0, 0, 0)
        '
        'lblChangeDateTakenKeepOriginalTime
        '
        Me.lblChangeDateTakenKeepOriginalTime.AutoSize = True
        Me.lblChangeDateTakenKeepOriginalTime.Location = New System.Drawing.Point(446, 43)
        Me.lblChangeDateTakenKeepOriginalTime.Name = "lblChangeDateTakenKeepOriginalTime"
        Me.lblChangeDateTakenKeepOriginalTime.Size = New System.Drawing.Size(89, 13)
        Me.lblChangeDateTakenKeepOriginalTime.TabIndex = 0
        Me.lblChangeDateTakenKeepOriginalTime.Text = "keep original time"
        '
        'dtpChangeDateTakenToSpecificDate
        '
        Me.dtpChangeDateTakenToSpecificDate.CustomFormat = ""
        Me.dtpChangeDateTakenToSpecificDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpChangeDateTakenToSpecificDate.Location = New System.Drawing.Point(365, 19)
        Me.dtpChangeDateTakenToSpecificDate.Name = "dtpChangeDateTakenToSpecificDate"
        Me.dtpChangeDateTakenToSpecificDate.Size = New System.Drawing.Size(83, 20)
        Me.dtpChangeDateTakenToSpecificDate.TabIndex = 7
        '
        'rdbChangeDateTakenToSpecificDateAndOriginalTime
        '
        Me.rdbChangeDateTakenToSpecificDateAndOriginalTime.AutoSize = True
        Me.rdbChangeDateTakenToSpecificDateAndOriginalTime.Location = New System.Drawing.Point(208, 19)
        Me.rdbChangeDateTakenToSpecificDateAndOriginalTime.Name = "rdbChangeDateTakenToSpecificDateAndOriginalTime"
        Me.rdbChangeDateTakenToSpecificDateAndOriginalTime.Size = New System.Drawing.Size(158, 17)
        Me.rdbChangeDateTakenToSpecificDateAndOriginalTime.TabIndex = 6
        Me.rdbChangeDateTakenToSpecificDateAndOriginalTime.TabStop = True
        Me.rdbChangeDateTakenToSpecificDateAndOriginalTime.Text = "... to specific Date and Time"
        Me.rdbChangeDateTakenToSpecificDateAndOriginalTime.UseVisualStyleBackColor = True
        '
        'rdbChangeDateTakenIncreasingHours
        '
        Me.rdbChangeDateTakenIncreasingHours.AutoSize = True
        Me.rdbChangeDateTakenIncreasingHours.Location = New System.Drawing.Point(14, 39)
        Me.rdbChangeDateTakenIncreasingHours.Name = "rdbChangeDateTakenIncreasingHours"
        Me.rdbChangeDateTakenIncreasingHours.Size = New System.Drawing.Size(85, 17)
        Me.rdbChangeDateTakenIncreasingHours.TabIndex = 3
        Me.rdbChangeDateTakenIncreasingHours.TabStop = True
        Me.rdbChangeDateTakenIncreasingHours.Text = "... increasing"
        Me.rdbChangeDateTakenIncreasingHours.UseVisualStyleBackColor = True
        '
        'rdbChangeDateTakenToDateTimeInFileName
        '
        Me.rdbChangeDateTakenToDateTimeInFileName.AutoSize = True
        Me.rdbChangeDateTakenToDateTimeInFileName.Location = New System.Drawing.Point(14, 19)
        Me.rdbChangeDateTakenToDateTimeInFileName.Name = "rdbChangeDateTakenToDateTimeInFileName"
        Me.rdbChangeDateTakenToDateTimeInFileName.Size = New System.Drawing.Size(175, 17)
        Me.rdbChangeDateTakenToDateTimeInFileName.TabIndex = 2
        Me.rdbChangeDateTakenToDateTimeInFileName.TabStop = True
        Me.rdbChangeDateTakenToDateTimeInFileName.Text = "... to Date and Time in file name"
        Me.rdbChangeDateTakenToDateTimeInFileName.UseVisualStyleBackColor = True
        '
        'chkActionChangeDateTakenMetadata
        '
        Me.chkActionChangeDateTakenMetadata.AutoSize = True
        Me.chkActionChangeDateTakenMetadata.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.chkActionChangeDateTakenMetadata.Location = New System.Drawing.Point(10, -1)
        Me.chkActionChangeDateTakenMetadata.Name = "chkActionChangeDateTakenMetadata"
        Me.chkActionChangeDateTakenMetadata.Size = New System.Drawing.Size(168, 17)
        Me.chkActionChangeDateTakenMetadata.TabIndex = 0
        Me.chkActionChangeDateTakenMetadata.Text = "Change DateTaken Metadata"
        Me.chkActionChangeDateTakenMetadata.UseVisualStyleBackColor = False
        '
        'lblChangeDateTakenIncreaseHours
        '
        Me.lblChangeDateTakenIncreaseHours.AutoSize = True
        Me.lblChangeDateTakenIncreaseHours.Location = New System.Drawing.Point(149, 41)
        Me.lblChangeDateTakenIncreaseHours.Name = "lblChangeDateTakenIncreaseHours"
        Me.lblChangeDateTakenIncreaseHours.Size = New System.Drawing.Size(33, 13)
        Me.lblChangeDateTakenIncreaseHours.TabIndex = 5
        Me.lblChangeDateTakenIncreaseHours.Text = "hours"
        '
        'numChangeDateTakenIncreaseHours
        '
        Me.numChangeDateTakenIncreaseHours.Location = New System.Drawing.Point(104, 39)
        Me.numChangeDateTakenIncreaseHours.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.numChangeDateTakenIncreaseHours.Minimum = New Decimal(New Integer() {23, 0, 0, -2147483648})
        Me.numChangeDateTakenIncreaseHours.Name = "numChangeDateTakenIncreaseHours"
        Me.numChangeDateTakenIncreaseHours.Size = New System.Drawing.Size(40, 20)
        Me.numChangeDateTakenIncreaseHours.TabIndex = 4
        '
        'chkActionChangeFileDate
        '
        Me.chkActionChangeFileDate.AutoSize = True
        Me.chkActionChangeFileDate.Location = New System.Drawing.Point(16, 80)
        Me.chkActionChangeFileDate.Name = "chkActionChangeFileDate"
        Me.chkActionChangeFileDate.Size = New System.Drawing.Size(225, 17)
        Me.chkActionChangeFileDate.TabIndex = 1
        Me.chkActionChangeFileDate.Text = "Change File Date Using Date in File Name"
        Me.chkActionChangeFileDate.UseVisualStyleBackColor = True
        '
        'tabIndex
        '
        Me.tabIndex.Controls.Add(Me.pctPreview)
        Me.tabIndex.Controls.Add(Me.boxIndexSearch)
        Me.tabIndex.Location = New System.Drawing.Point(4, 22)
        Me.tabIndex.Name = "tabIndex"
        Me.tabIndex.Size = New System.Drawing.Size(551, 350)
        Me.tabIndex.TabIndex = 3
        Me.tabIndex.Text = "Index"
        Me.tabIndex.UseVisualStyleBackColor = True
        '
        'pctPreview
        '
        Me.pctPreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pctPreview.Location = New System.Drawing.Point(3, 4)
        Me.pctPreview.Name = "pctPreview"
        Me.pctPreview.Size = New System.Drawing.Size(428, 325)
        Me.pctPreview.TabIndex = 22
        Me.pctPreview.TabStop = False
        '
        'boxIndexSearch
        '
        Me.boxIndexSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boxIndexSearch.Controls.Add(Me.rdbIndexSearchOperator2Or)
        Me.boxIndexSearch.Controls.Add(Me.btnIndexSearch)
        Me.boxIndexSearch.Controls.Add(Me.lblIndexSearchKeyWords)
        Me.boxIndexSearch.Controls.Add(Me.rdbIndexSearchOperator2And)
        Me.boxIndexSearch.Controls.Add(Me.txtIndexSearchWord1)
        Me.boxIndexSearch.Controls.Add(Me.rdbIndexSearchOperator1Or)
        Me.boxIndexSearch.Controls.Add(Me.txtIndexSearchWord2)
        Me.boxIndexSearch.Controls.Add(Me.rdbIndexSearchOperator1And)
        Me.boxIndexSearch.Controls.Add(Me.txtIndexSearchWord3)
        Me.boxIndexSearch.Controls.Add(Me.dtpIndexSearchEndDate)
        Me.boxIndexSearch.Controls.Add(Me.dtpIndexSearchStartDate)
        Me.boxIndexSearch.Location = New System.Drawing.Point(437, 4)
        Me.boxIndexSearch.Name = "boxIndexSearch"
        Me.boxIndexSearch.Size = New System.Drawing.Size(131, 227)
        Me.boxIndexSearch.TabIndex = 23
        Me.boxIndexSearch.TabStop = False
        Me.boxIndexSearch.Text = "Busca"
        '
        'rdbIndexSearchOperator2Or
        '
        Me.rdbIndexSearchOperator2Or.AutoSize = True
        Me.rdbIndexSearchOperator2Or.Location = New System.Drawing.Point(56, 98)
        Me.rdbIndexSearchOperator2Or.Name = "rdbIndexSearchOperator2Or"
        Me.rdbIndexSearchOperator2Or.Size = New System.Drawing.Size(41, 17)
        Me.rdbIndexSearchOperator2Or.TabIndex = 22
        Me.rdbIndexSearchOperator2Or.TabStop = True
        Me.rdbIndexSearchOperator2Or.Text = "OU"
        Me.rdbIndexSearchOperator2Or.UseVisualStyleBackColor = True
        '
        'btnIndexSearch
        '
        Me.btnIndexSearch.Location = New System.Drawing.Point(22, 196)
        Me.btnIndexSearch.Name = "btnIndexSearch"
        Me.btnIndexSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnIndexSearch.TabIndex = 15
        Me.btnIndexSearch.Text = "Seach"
        Me.btnIndexSearch.UseVisualStyleBackColor = True
        '
        'lblIndexSearchKeyWords
        '
        Me.lblIndexSearchKeyWords.AutoSize = True
        Me.lblIndexSearchKeyWords.Location = New System.Drawing.Point(6, 19)
        Me.lblIndexSearchKeyWords.Name = "lblIndexSearchKeyWords"
        Me.lblIndexSearchKeyWords.Size = New System.Drawing.Size(59, 13)
        Me.lblIndexSearchKeyWords.TabIndex = 6
        Me.lblIndexSearchKeyWords.Text = "Key Words"
        '
        'rdbIndexSearchOperator2And
        '
        Me.rdbIndexSearchOperator2And.AutoSize = True
        Me.rdbIndexSearchOperator2And.Location = New System.Drawing.Point(23, 98)
        Me.rdbIndexSearchOperator2And.Name = "rdbIndexSearchOperator2And"
        Me.rdbIndexSearchOperator2And.Size = New System.Drawing.Size(32, 17)
        Me.rdbIndexSearchOperator2And.TabIndex = 21
        Me.rdbIndexSearchOperator2And.TabStop = True
        Me.rdbIndexSearchOperator2And.Text = "E"
        Me.rdbIndexSearchOperator2And.UseVisualStyleBackColor = True
        '
        'txtIndexSearchWord1
        '
        Me.txtIndexSearchWord1.Location = New System.Drawing.Point(9, 36)
        Me.txtIndexSearchWord1.Name = "txtIndexSearchWord1"
        Me.txtIndexSearchWord1.Size = New System.Drawing.Size(112, 20)
        Me.txtIndexSearchWord1.TabIndex = 7
        '
        'rdbIndexSearchOperator1Or
        '
        Me.rdbIndexSearchOperator1Or.AutoSize = True
        Me.rdbIndexSearchOperator1Or.Location = New System.Drawing.Point(56, 57)
        Me.rdbIndexSearchOperator1Or.Name = "rdbIndexSearchOperator1Or"
        Me.rdbIndexSearchOperator1Or.Size = New System.Drawing.Size(41, 17)
        Me.rdbIndexSearchOperator1Or.TabIndex = 20
        Me.rdbIndexSearchOperator1Or.TabStop = True
        Me.rdbIndexSearchOperator1Or.Text = "OU"
        Me.rdbIndexSearchOperator1Or.UseVisualStyleBackColor = True
        '
        'txtIndexSearchWord2
        '
        Me.txtIndexSearchWord2.Location = New System.Drawing.Point(9, 77)
        Me.txtIndexSearchWord2.Name = "txtIndexSearchWord2"
        Me.txtIndexSearchWord2.Size = New System.Drawing.Size(112, 20)
        Me.txtIndexSearchWord2.TabIndex = 8
        '
        'rdbIndexSearchOperator1And
        '
        Me.rdbIndexSearchOperator1And.AutoSize = True
        Me.rdbIndexSearchOperator1And.Location = New System.Drawing.Point(23, 57)
        Me.rdbIndexSearchOperator1And.Name = "rdbIndexSearchOperator1And"
        Me.rdbIndexSearchOperator1And.Size = New System.Drawing.Size(32, 17)
        Me.rdbIndexSearchOperator1And.TabIndex = 19
        Me.rdbIndexSearchOperator1And.TabStop = True
        Me.rdbIndexSearchOperator1And.Text = "E"
        Me.rdbIndexSearchOperator1And.UseVisualStyleBackColor = True
        '
        'txtIndexSearchWord3
        '
        Me.txtIndexSearchWord3.Location = New System.Drawing.Point(9, 118)
        Me.txtIndexSearchWord3.Name = "txtIndexSearchWord3"
        Me.txtIndexSearchWord3.Size = New System.Drawing.Size(112, 20)
        Me.txtIndexSearchWord3.TabIndex = 9
        '
        'dtpIndexSearchEndDate
        '
        Me.dtpIndexSearchEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpIndexSearchEndDate.Location = New System.Drawing.Point(9, 170)
        Me.dtpIndexSearchEndDate.Name = "dtpIndexSearchEndDate"
        Me.dtpIndexSearchEndDate.ShowCheckBox = True
        Me.dtpIndexSearchEndDate.Size = New System.Drawing.Size(112, 20)
        Me.dtpIndexSearchEndDate.TabIndex = 14
        '
        'dtpIndexSearchStartDate
        '
        Me.dtpIndexSearchStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpIndexSearchStartDate.Location = New System.Drawing.Point(9, 144)
        Me.dtpIndexSearchStartDate.Name = "dtpIndexSearchStartDate"
        Me.dtpIndexSearchStartDate.ShowCheckBox = True
        Me.dtpIndexSearchStartDate.Size = New System.Drawing.Size(112, 20)
        Me.dtpIndexSearchStartDate.TabIndex = 13
        '
        'lstLog
        '
        Me.lstLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstLog.FormattingEnabled = True
        Me.lstLog.Location = New System.Drawing.Point(0, 391)
        Me.lstLog.Name = "lstLog"
        Me.lstLog.Size = New System.Drawing.Size(672, 121)
        Me.lstLog.TabIndex = 4
        '
        'lblProgress
        '
        Me.lblProgress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblProgress.AutoSize = True
        Me.lblProgress.BackColor = System.Drawing.Color.Transparent
        Me.lblProgress.Location = New System.Drawing.Point(5, 522)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(48, 13)
        Me.lblProgress.TabIndex = 1
        Me.lblProgress.Text = "Progress"
        '
        'MainForm
        '
        Me.AcceptButton = Me.btnExecute
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1024, 553)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.progressBar)
        Me.Controls.Add(Me.lblProgress)
        Me.Name = "MainForm"
        Me.Text = "My Photo Tools"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabMain.ResumeLayout(False)
        Me.tabAction.ResumeLayout(False)
        Me.tabAction.PerformLayout()
        Me.boxRename.ResumeLayout(False)
        Me.boxRename.PerformLayout()
        CType(Me.numRenameRemoveFinalCharacters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRenameRemoveInitialCharacters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.boxIndex.ResumeLayout(False)
        Me.boxIndex.PerformLayout()
        Me.boxThunbnail.ResumeLayout(False)
        Me.boxThunbnail.PerformLayout()
        Me.boxMetadata.ResumeLayout(False)
        Me.boxMetadata.PerformLayout()
        CType(Me.numChangeDateTakenIncreaseHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabIndex.ResumeLayout(False)
        CType(Me.pctPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.boxIndexSearch.ResumeLayout(False)
        Me.boxIndexSearch.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLocateFolder As System.Windows.Forms.Button
   Friend WithEvents lblFolder As System.Windows.Forms.Label
   Friend WithEvents txtFolder As System.Windows.Forms.TextBox
   Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
   Friend WithEvents btnExit As System.Windows.Forms.Button
   Friend WithEvents progressBar As System.Windows.Forms.ProgressBar
   Friend WithEvents btnListFiles As Button
   Friend WithEvents btnExecute As Button
   Friend WithEvents SplitContainer1 As SplitContainer
   Friend WithEvents lstLog As ListBox
   Friend WithEvents TabMain As TabControl
   Friend WithEvents tabAction As TabPage
   Friend WithEvents boxRename As GroupBox
   Friend WithEvents numRenameRemoveFinalCharacters As NumericUpDown
   Friend WithEvents lblRenameRemoveFinalCharacters As Label
   Friend WithEvents numRenameRemoveInitialCharacters As NumericUpDown
   Friend WithEvents lblRenameRemoveInitialCharacters As Label
   Friend WithEvents chkPreviewOnly As CheckBox
   Friend WithEvents lblRenameMethod As Label
   Friend WithEvents chkRenameConcatenateOriginalName As CheckBox
   Friend WithEvents lblEventName As Label
   Friend WithEvents cmbRenameMethod As ComboBox
   Friend WithEvents txtEventName As TextBox
   Friend WithEvents btnClearFiles As Button
   Friend WithEvents lblProgress As Label
   Friend WithEvents tabIndex As TabPage
   Friend WithEvents btnIndexSearch As Button
   Friend WithEvents dtpIndexSearchEndDate As DateTimePicker
   Friend WithEvents dtpIndexSearchStartDate As DateTimePicker
   Friend WithEvents txtIndexSearchWord3 As TextBox
   Friend WithEvents txtIndexSearchWord2 As TextBox
   Friend WithEvents txtIndexSearchWord1 As TextBox
   Friend WithEvents lblIndexSearchKeyWords As Label
   Friend WithEvents chkActionRenameFiles As CheckBox
   Friend WithEvents boxMetadata As GroupBox
   Friend WithEvents chkActionChangeDateTakenMetadata As CheckBox
   Friend WithEvents lblChangeDateTakenIncreaseHours As Label
   Friend WithEvents numChangeDateTakenIncreaseHours As NumericUpDown
   Friend WithEvents rdbChangeDateTakenIncreasingHours As RadioButton
   Friend WithEvents rdbChangeDateTakenToDateTimeInFileName As RadioButton
   Friend WithEvents boxThunbnail As GroupBox
   Friend WithEvents txtMaxHeight As TextBox
   Friend WithEvents txtThumbnailMaxWidth As TextBox
   Friend WithEvents lblThumbnailMaxWidth As Label
   Friend WithEvents lblThumbnailMaxHeight As Label
   Friend WithEvents btnThumbnailLocateFolder As Button
   Friend WithEvents txtThumbnailDestinationFolder As TextBox
   Friend WithEvents lblThumbnailDestinationFolder As Label
   Friend WithEvents chkActionGenerateThumbnail As CheckBox
   Friend WithEvents chkActionChangeFileDate As CheckBox
   Friend WithEvents pctPreview As PictureBox
   Friend WithEvents rdbIndexSearchOperator2Or As RadioButton
   Friend WithEvents rdbIndexSearchOperator2And As RadioButton
   Friend WithEvents rdbIndexSearchOperator1Or As RadioButton
   Friend WithEvents rdbIndexSearchOperator1And As RadioButton
   Friend WithEvents boxIndex As GroupBox
   Friend WithEvents txtIndexDescription As TextBox
   Friend WithEvents dtpIndexDate As DateTimePicker
   Friend WithEvents lblIndexDate As Label
   Friend WithEvents lblIndexDescription As Label
   Friend WithEvents chkActionIndex As CheckBox
   Friend WithEvents rdbIndexSaveMetadata As RadioButton
   Friend WithEvents rdbIndexSalveDotFotFile As RadioButton
   Friend WithEvents boxIndexSearch As GroupBox
   Friend WithEvents btnIndexUpdateMasterIndex As Button
   Friend WithEvents lblChangeDateTakenKeepOriginalTime As Label
   Friend WithEvents dtpChangeDateTakenToSpecificDate As DateTimePicker
   Friend WithEvents rdbChangeDateTakenToSpecificDateAndOriginalTime As RadioButton
   Friend WithEvents lvwFiles As ListView
   Friend WithEvents dtpChangeDateTakenTime As DateTimePicker
    Friend WithEvents chkChangeFileDateAppend2InRepeated As CheckBox
    Friend WithEvents chkChangeFileDateAppend2NewFile As RadioButton
   Friend WithEvents chkChangeFileDateAppend2ExistingFile As RadioButton
   Friend WithEvents chkChangeTimeFile As CheckBox
End Class
