Public Class CopyMetadataForm
   Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

   Public Sub New()
      MyBase.New()

      'This call is required by the Windows Form Designer.
      InitializeComponent()

      'Add any initialization after the InitializeComponent() call

   End Sub

   'Form overrides dispose to clean up the component list.
   Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing Then
         If Not (components Is Nothing) Then
            components.Dispose()
         End If
      End If
      MyBase.Dispose(disposing)
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   Friend WithEvents Btn_Processa As System.Windows.Forms.Button
   Friend WithEvents Lbl_PastaOrigem As System.Windows.Forms.Label
   Friend WithEvents Lbl_PastaDestino As System.Windows.Forms.Label
   Friend WithEvents Txt_PastaOrigem As System.Windows.Forms.TextBox
   Friend WithEvents Txt_PastaDestino As System.Windows.Forms.TextBox
   Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
   Friend WithEvents Btn_Sair As System.Windows.Forms.Button
   Friend WithEvents Btn_LocalizaOrigem As System.Windows.Forms.Button
   Friend WithEvents Btn_LocalizaDestino As System.Windows.Forms.Button
   Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Btn_LocalizaFinal As System.Windows.Forms.Button
   Friend WithEvents Txt_PastaFinal As System.Windows.Forms.TextBox
   Friend WithEvents Lbl_PastaFinal As System.Windows.Forms.Label
   Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
   Friend WithEvents Lbl_1 As Label
   Friend WithEvents Bar_1 As System.Windows.Forms.ProgressBar
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CopyMetadataForm))
      Me.Btn_Processa = New System.Windows.Forms.Button()
      Me.Lbl_PastaOrigem = New System.Windows.Forms.Label()
      Me.Lbl_PastaDestino = New System.Windows.Forms.Label()
      Me.Txt_PastaOrigem = New System.Windows.Forms.TextBox()
      Me.Txt_PastaDestino = New System.Windows.Forms.TextBox()
      Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
      Me.Btn_Sair = New System.Windows.Forms.Button()
      Me.Btn_LocalizaOrigem = New System.Windows.Forms.Button()
      Me.Btn_LocalizaDestino = New System.Windows.Forms.Button()
      Me.Bar_1 = New System.Windows.Forms.ProgressBar()
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Btn_LocalizaFinal = New System.Windows.Forms.Button()
      Me.Txt_PastaFinal = New System.Windows.Forms.TextBox()
      Me.Lbl_PastaFinal = New System.Windows.Forms.Label()
      Me.GroupBox2 = New System.Windows.Forms.GroupBox()
      Me.Lbl_1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Processa
        '
        Me.Btn_Processa.Location = New System.Drawing.Point(14, 224)
        Me.Btn_Processa.Name = "Btn_Processa"
        Me.Btn_Processa.Size = New System.Drawing.Size(147, 28)
        Me.Btn_Processa.TabIndex = 0
        Me.Btn_Processa.Text = "Copiar Metadados"
        '
        'Lbl_PastaOrigem
        '
        Me.Lbl_PastaOrigem.AutoSize = True
        Me.Lbl_PastaOrigem.Location = New System.Drawing.Point(7, 25)
        Me.Lbl_PastaOrigem.Name = "Lbl_PastaOrigem"
        Me.Lbl_PastaOrigem.Size = New System.Drawing.Size(317, 17)
        Me.Lbl_PastaOrigem.TabIndex = 1
        Me.Lbl_PastaOrigem.Text = "Pasta Origem (Arquivo com metadados originais)"
        '
        'Lbl_PastaDestino
        '
        Me.Lbl_PastaDestino.AutoSize = True
        Me.Lbl_PastaDestino.Location = New System.Drawing.Point(7, 87)
        Me.Lbl_PastaDestino.Name = "Lbl_PastaDestino"
        Me.Lbl_PastaDestino.Size = New System.Drawing.Size(317, 17)
        Me.Lbl_PastaDestino.TabIndex = 2
        Me.Lbl_PastaDestino.Text = "Pasta Destino (Arquivo com metadados faltando)"
        '
        'Txt_PastaOrigem
        '
        Me.Txt_PastaOrigem.Location = New System.Drawing.Point(7, 44)
        Me.Txt_PastaOrigem.Name = "Txt_PastaOrigem"
        Me.Txt_PastaOrigem.Size = New System.Drawing.Size(259, 22)
        Me.Txt_PastaOrigem.TabIndex = 3
        Me.Txt_PastaOrigem.Text = "d:\fotos"
        '
        'Txt_PastaDestino
        '
        Me.Txt_PastaDestino.Location = New System.Drawing.Point(7, 108)
        Me.Txt_PastaDestino.Name = "Txt_PastaDestino"
        Me.Txt_PastaDestino.Size = New System.Drawing.Size(259, 22)
        Me.Txt_PastaDestino.TabIndex = 4
        Me.Txt_PastaDestino.Text = "d:\fotos"
        '
        'Btn_Sair
        '
        Me.Btn_Sair.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Sair.Location = New System.Drawing.Point(290, 224)
        Me.Btn_Sair.Name = "Btn_Sair"
        Me.Btn_Sair.Size = New System.Drawing.Size(77, 28)
        Me.Btn_Sair.TabIndex = 5
        Me.Btn_Sair.Text = "Sair"
        '
        'Btn_LocalizaOrigem
        '
        Me.Btn_LocalizaOrigem.Location = New System.Drawing.Point(276, 44)
        Me.Btn_LocalizaOrigem.Name = "Btn_LocalizaOrigem"
        Me.Btn_LocalizaOrigem.Size = New System.Drawing.Size(77, 28)
        Me.Btn_LocalizaOrigem.TabIndex = 6
        Me.Btn_LocalizaOrigem.Text = "Localizar"
        '
        'Btn_LocalizaDestino
        '
        Me.Btn_LocalizaDestino.Location = New System.Drawing.Point(276, 108)
        Me.Btn_LocalizaDestino.Name = "Btn_LocalizaDestino"
        Me.Btn_LocalizaDestino.Size = New System.Drawing.Size(77, 28)
        Me.Btn_LocalizaDestino.TabIndex = 7
        Me.Btn_LocalizaDestino.Text = "Localizar"
        '
        'Bar_1
        '
        Me.Bar_1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Bar_1.Location = New System.Drawing.Point(0, 274)
        Me.Bar_1.Name = "Bar_1"
        Me.Bar_1.Size = New System.Drawing.Size(603, 19)
        Me.Bar_1.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(385, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(203, 246)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 219)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Btn_LocalizaFinal
        '
        Me.Btn_LocalizaFinal.Location = New System.Drawing.Point(276, 172)
        Me.Btn_LocalizaFinal.Name = "Btn_LocalizaFinal"
        Me.Btn_LocalizaFinal.Size = New System.Drawing.Size(77, 28)
        Me.Btn_LocalizaFinal.TabIndex = 12
        Me.Btn_LocalizaFinal.Text = "Localizar"
        '
        'Txt_PastaFinal
        '
        Me.Txt_PastaFinal.Location = New System.Drawing.Point(7, 172)
        Me.Txt_PastaFinal.Name = "Txt_PastaFinal"
        Me.Txt_PastaFinal.Size = New System.Drawing.Size(259, 22)
        Me.Txt_PastaFinal.TabIndex = 11
        Me.Txt_PastaFinal.Text = "d:\fotos"
        '
        'Lbl_PastaFinal
        '
        Me.Lbl_PastaFinal.AutoSize = True
        Me.Lbl_PastaFinal.Location = New System.Drawing.Point(7, 150)
        Me.Lbl_PastaFinal.Name = "Lbl_PastaFinal"
        Me.Lbl_PastaFinal.Size = New System.Drawing.Size(284, 17)
        Me.Lbl_PastaFinal.TabIndex = 10
        Me.Lbl_PastaFinal.Text = "Pasta Final (Metadados + Imagem Alterada)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btn_LocalizaOrigem)
        Me.GroupBox2.Controls.Add(Me.Btn_LocalizaFinal)
        Me.GroupBox2.Controls.Add(Me.Lbl_PastaOrigem)
        Me.GroupBox2.Controls.Add(Me.Txt_PastaFinal)
        Me.GroupBox2.Controls.Add(Me.Lbl_PastaDestino)
        Me.GroupBox2.Controls.Add(Me.Lbl_PastaFinal)
        Me.GroupBox2.Controls.Add(Me.Txt_PastaOrigem)
        Me.GroupBox2.Controls.Add(Me.Txt_PastaDestino)
        Me.GroupBox2.Controls.Add(Me.Btn_LocalizaDestino)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(364, 203)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'Lbl_1
        '
        Me.Lbl_1.AutoSize = True
        Me.Lbl_1.Location = New System.Drawing.Point(168, 231)
        Me.Lbl_1.Name = "Lbl_1"
        Me.Lbl_1.Size = New System.Drawing.Size(73, 17)
        Me.Lbl_1.TabIndex = 14
        Me.Lbl_1.Text = "Progresso"
        '
        'Frm_CopiaMetadados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.CancelButton = Me.Btn_Sair
        Me.ClientSize = New System.Drawing.Size(603, 293)
        Me.Controls.Add(Me.Lbl_1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Bar_1)
        Me.Controls.Add(Me.Btn_Sair)
        Me.Controls.Add(Me.Btn_Processa)
        Me.Name = "Frm_CopiaMetadados"
        Me.Text = "Copia Metadados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Btn_Sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Sair.Click
      End
   End Sub

   Private Sub Btn_LocalizaOrigem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_LocalizaOrigem.Click
      If System.IO.Directory.Exists(Txt_PastaOrigem.Text) Then
         FolderBrowserDialog.SelectedPath = Txt_PastaOrigem.Text
      End If
      FolderBrowserDialog.ShowDialog()
      Txt_PastaOrigem.Text = FolderBrowserDialog.SelectedPath
   End Sub

   Private Sub Btn_LocalizaDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_LocalizaDestino.Click
      If System.IO.Directory.Exists(Txt_PastaDestino.Text) Then
         FolderBrowserDialog.SelectedPath = Txt_PastaDestino.Text
      End If
      FolderBrowserDialog.ShowDialog()
      Txt_PastaDestino.Text = FolderBrowserDialog.SelectedPath
   End Sub

   Private Sub Btn_LocalizaFinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_LocalizaFinal.Click
      If System.IO.Directory.Exists(Txt_PastaFinal.Text) Then
         FolderBrowserDialog.SelectedPath = Txt_PastaFinal.Text
      End If
      FolderBrowserDialog.ShowDialog()
      Txt_PastaFinal.Text = FolderBrowserDialog.SelectedPath
   End Sub

   Private Sub Btn_Processa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Processa.Click

      Dim Str_ArqOrigem As String() = System.IO.Directory.GetFiles(Txt_PastaOrigem.Text, "*.jpg")

      Bar_1.Value = 0
      Bar_1.Maximum = Str_ArqOrigem.Length - 1
      Dim Str_Arquivo As String
      For Each Str_Arquivo In Str_ArqOrigem
         Sl_CopiaMetadados(Str_Arquivo, Str_Arquivo.Substring(Str_Arquivo.LastIndexOf("\") + 1), Txt_PastaFinal.Text)
         Lbl_1.Text = Bar_1.Value.ToString + "/" + Bar_1.Maximum.ToString
         Bar_1.Increment(1)
         Application.DoEvents()
      Next
      MsgBox("Concluído.", MsgBoxStyle.Information)

   End Sub

   Private Sub Sl_CopiaMetadados(ByVal Str_ArqOrigem As String, ByVal Str_ArqDestino As String, ByVal Str_CaminhoFinal As String)
      Dim Img_Origem As System.Drawing.Image
      Dim Img_Destino As System.Drawing.Image

      '*** Gerar Log de erros ***
      If Not System.IO.File.Exists(Txt_PastaDestino.Text + "\" + Str_ArqDestino) Then
         Exit Sub
      End If

      If Not System.IO.Directory.Exists(Str_CaminhoFinal) Then
         Exit Sub
      End If

      Img_Origem = System.Drawing.Image.FromFile(Str_ArqOrigem)
      Img_Destino = System.Drawing.Image.FromFile(Txt_PastaDestino.Text + "\" + Str_ArqDestino)

      'Replica os metadados de uma imagem para a outra
      Try
         Dim PropItm As System.Drawing.Imaging.PropertyItem
         For Each PropItm In Img_Origem.PropertyItems
            Img_Destino.SetPropertyItem(PropItm)
         Next
      Catch ex As Exception
         '*** Gerar Log de erros ***
      End Try

      Img_Destino.Save(Str_CaminhoFinal + "\" + Str_ArqDestino, System.Drawing.Imaging.ImageFormat.Jpeg)
   End Sub
End Class
