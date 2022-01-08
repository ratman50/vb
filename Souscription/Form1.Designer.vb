<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblMat = New System.Windows.Forms.Label()
        Me.lblPren = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblAdres = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.TxtVal = New System.Windows.Forms.TextBox()
        Me.TxtPren = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtAdres = New System.Windows.Forms.TextBox()
        Me.TxtTel = New System.Windows.Forms.TextBox()
        Me.CboGenre = New System.Windows.Forms.ComboBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChBAutre = New System.Windows.Forms.CheckBox()
        Me.ChBMaladie = New System.Windows.Forms.CheckBox()
        Me.ChBVoy = New System.Windows.Forms.CheckBox()
        Me.chBTrav = New System.Windows.Forms.CheckBox()
        Me.LblSous = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RdbJourna = New System.Windows.Forms.RadioButton()
        Me.RdbContract = New System.Windows.Forms.RadioButton()
        Me.RdbEmbauch = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDateSous = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CboDureSous = New System.Windows.Forms.ComboBox()
        Me.LblFinSous = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblMontGob = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Lblm = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMat
        '
        Me.lblMat.AutoSize = True
        Me.lblMat.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMat.Location = New System.Drawing.Point(3, 22)
        Me.lblMat.Name = "lblMat"
        Me.lblMat.Size = New System.Drawing.Size(113, 20)
        Me.lblMat.TabIndex = 0
        Me.lblMat.Text = "Matricule"
        '
        'lblPren
        '
        Me.lblPren.AutoSize = True
        Me.lblPren.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPren.Location = New System.Drawing.Point(3, 57)
        Me.lblPren.Name = "lblPren"
        Me.lblPren.Size = New System.Drawing.Size(84, 20)
        Me.lblPren.TabIndex = 1
        Me.lblPren.Text = "Prénom"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(3, 88)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(52, 20)
        Me.lblNom.TabIndex = 2
        Me.lblNom.Text = "Nom"
        '
        'lblAdres
        '
        Me.lblAdres.AutoSize = True
        Me.lblAdres.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdres.Location = New System.Drawing.Point(3, 125)
        Me.lblAdres.Name = "lblAdres"
        Me.lblAdres.Size = New System.Drawing.Size(83, 20)
        Me.lblAdres.TabIndex = 3
        Me.lblAdres.Text = "Adresse"
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel.Location = New System.Drawing.Point(3, 161)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(108, 20)
        Me.lblTel.TabIndex = 4
        Me.lblTel.Text = "Téléphone"
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenre.Location = New System.Drawing.Point(3, 197)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(67, 20)
        Me.lblGenre.TabIndex = 5
        Me.lblGenre.Text = "Genre"
        '
        'TxtVal
        '
        Me.TxtVal.Font = New System.Drawing.Font("Nirmala UI Semilight", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVal.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtVal.Location = New System.Drawing.Point(122, 22)
        Me.TxtVal.Name = "TxtVal"
        Me.TxtVal.Size = New System.Drawing.Size(106, 27)
        Me.TxtVal.TabIndex = 6
        '
        'TxtPren
        '
        Me.TxtPren.Font = New System.Drawing.Font("Nirmala UI Semilight", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPren.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtPren.Location = New System.Drawing.Point(122, 57)
        Me.TxtPren.Name = "TxtPren"
        Me.TxtPren.Size = New System.Drawing.Size(106, 27)
        Me.TxtPren.TabIndex = 7
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Nirmala UI Semilight", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtName.Location = New System.Drawing.Point(122, 88)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(106, 27)
        Me.TxtName.TabIndex = 8
        '
        'TxtAdres
        '
        Me.TxtAdres.Font = New System.Drawing.Font("Nirmala UI Semilight", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdres.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtAdres.Location = New System.Drawing.Point(122, 121)
        Me.TxtAdres.Name = "TxtAdres"
        Me.TxtAdres.Size = New System.Drawing.Size(106, 27)
        Me.TxtAdres.TabIndex = 9
        '
        'TxtTel
        '
        Me.TxtTel.Font = New System.Drawing.Font("Nirmala UI Semilight", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtTel.Location = New System.Drawing.Point(122, 154)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(106, 27)
        Me.TxtTel.TabIndex = 10
        '
        'CboGenre
        '
        Me.CboGenre.Font = New System.Drawing.Font("Nirmala UI Semilight", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboGenre.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CboGenre.FormattingEnabled = True
        Me.CboGenre.Items.AddRange(New Object() {"Masculin", "Féminin"})
        Me.CboGenre.Location = New System.Drawing.Point(122, 189)
        Me.CboGenre.Name = "CboGenre"
        Me.CboGenre.Size = New System.Drawing.Size(106, 28)
        Me.CboGenre.TabIndex = 11
        Me.CboGenre.Text = "Masculin"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 12)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblMat)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CboGenre)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPren)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtTel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblNom)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtAdres)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblAdres)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblTel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtPren)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblGenre)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtVal)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChBAutre)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChBMaladie)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChBVoy)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chBTrav)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LblSous)
        Me.SplitContainer1.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.SplitContainer1.Size = New System.Drawing.Size(684, 256)
        Me.SplitContainer1.SplitterDistance = 349
        Me.SplitContainer1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(32, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Information personnelle"
        '
        'ChBAutre
        '
        Me.ChBAutre.AutoSize = True
        Me.ChBAutre.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChBAutre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ChBAutre.Location = New System.Drawing.Point(101, 128)
        Me.ChBAutre.Name = "ChBAutre"
        Me.ChBAutre.Size = New System.Drawing.Size(131, 23)
        Me.ChBAutre.TabIndex = 4
        Me.ChBAutre.Text = "Autre (250 000)"
        Me.ChBAutre.UseVisualStyleBackColor = True
        '
        'ChBMaladie
        '
        Me.ChBMaladie.AutoSize = True
        Me.ChBMaladie.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChBMaladie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ChBMaladie.Location = New System.Drawing.Point(101, 70)
        Me.ChBMaladie.Name = "ChBMaladie"
        Me.ChBMaladie.Size = New System.Drawing.Size(148, 23)
        Me.ChBMaladie.TabIndex = 3
        Me.ChBMaladie.Text = "Maladie (100 000)"
        Me.ChBMaladie.UseVisualStyleBackColor = True
        '
        'ChBVoy
        '
        Me.ChBVoy.AutoSize = True
        Me.ChBVoy.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChBVoy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ChBVoy.Location = New System.Drawing.Point(101, 99)
        Me.ChBVoy.Name = "ChBVoy"
        Me.ChBVoy.Size = New System.Drawing.Size(144, 23)
        Me.ChBVoy.TabIndex = 2
        Me.ChBVoy.Text = "Voyage (750 000)"
        Me.ChBVoy.UseVisualStyleBackColor = True
        '
        'chBTrav
        '
        Me.chBTrav.AutoSize = True
        Me.chBTrav.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chBTrav.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chBTrav.Location = New System.Drawing.Point(101, 47)
        Me.chBTrav.Name = "chBTrav"
        Me.chBTrav.Size = New System.Drawing.Size(132, 23)
        Me.chBTrav.TabIndex = 1
        Me.chBTrav.Text = "Travail (25 000)"
        Me.chBTrav.UseVisualStyleBackColor = True
        '
        'LblSous
        '
        Me.LblSous.AutoSize = True
        Me.LblSous.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSous.Location = New System.Drawing.Point(75, 0)
        Me.LblSous.Name = "LblSous"
        Me.LblSous.Size = New System.Drawing.Size(149, 20)
        Me.LblSous.TabIndex = 0
        Me.LblSous.Text = "Nature Souscription"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Location = New System.Drawing.Point(12, 274)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.RdbEmbauch)
        Me.SplitContainer2.Panel1.Controls.Add(Me.RdbContract)
        Me.SplitContainer2.Panel1.Controls.Add(Me.RdbJourna)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Lblm)
        Me.SplitContainer2.Panel2.Controls.Add(Me.LblFinSous)
        Me.SplitContainer2.Panel2.Controls.Add(Me.CboDureSous)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblDateSous)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer2.Size = New System.Drawing.Size(684, 172)
        Me.SplitContainer2.SplitterDistance = 349
        Me.SplitContainer2.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(118, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "statut"
        '
        'RdbJourna
        '
        Me.RdbJourna.AutoSize = True
        Me.RdbJourna.Checked = True
        Me.RdbJourna.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbJourna.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RdbJourna.Location = New System.Drawing.Point(36, 40)
        Me.RdbJourna.Name = "RdbJourna"
        Me.RdbJourna.Size = New System.Drawing.Size(100, 22)
        Me.RdbJourna.TabIndex = 1
        Me.RdbJourna.TabStop = True
        Me.RdbJourna.Text = "journalier"
        Me.RdbJourna.UseVisualStyleBackColor = True
        '
        'RdbContract
        '
        Me.RdbContract.AutoSize = True
        Me.RdbContract.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbContract.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RdbContract.Location = New System.Drawing.Point(36, 63)
        Me.RdbContract.Name = "RdbContract"
        Me.RdbContract.Size = New System.Drawing.Size(107, 22)
        Me.RdbContract.TabIndex = 2
        Me.RdbContract.Text = "contractuel"
        Me.RdbContract.UseVisualStyleBackColor = True
        '
        'RdbEmbauch
        '
        Me.RdbEmbauch.AutoSize = True
        Me.RdbEmbauch.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbEmbauch.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RdbEmbauch.Location = New System.Drawing.Point(36, 86)
        Me.RdbEmbauch.Name = "RdbEmbauch"
        Me.RdbEmbauch.Size = New System.Drawing.Size(96, 22)
        Me.RdbEmbauch.TabIndex = 3
        Me.RdbEmbauch.Text = "embauche"
        Me.RdbEmbauch.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(97, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "date souscription"
        '
        'lblDateSous
        '
        Me.lblDateSous.AutoSize = True
        Me.lblDateSous.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateSous.Location = New System.Drawing.Point(185, 35)
        Me.lblDateSous.Name = "lblDateSous"
        Me.lblDateSous.Size = New System.Drawing.Size(94, 20)
        Me.lblDateSous.TabIndex = 3
        Me.lblDateSous.Text = "/////////////////"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "durée souscription"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "date fin souscription"
        '
        'CboDureSous
        '
        Me.CboDureSous.Font = New System.Drawing.Font("Nirmala UI Semilight", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDureSous.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CboDureSous.FormattingEnabled = True
        Me.CboDureSous.Location = New System.Drawing.Point(189, 58)
        Me.CboDureSous.Name = "CboDureSous"
        Me.CboDureSous.Size = New System.Drawing.Size(44, 28)
        Me.CboDureSous.TabIndex = 12
        '
        'LblFinSous
        '
        Me.LblFinSous.AutoSize = True
        Me.LblFinSous.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFinSous.Location = New System.Drawing.Point(185, 103)
        Me.LblFinSous.Name = "LblFinSous"
        Me.LblFinSous.Size = New System.Drawing.Size(99, 20)
        Me.LblFinSous.TabIndex = 13
        Me.LblFinSous.Text = "//////////////////"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(210, 449)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(177, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Montant Global"
        '
        'LblMontGob
        '
        Me.LblMontGob.AutoSize = True
        Me.LblMontGob.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMontGob.Location = New System.Drawing.Point(393, 449)
        Me.LblMontGob.Name = "LblMontGob"
        Me.LblMontGob.Size = New System.Drawing.Size(20, 20)
        Me.LblMontGob.TabIndex = 15
        Me.LblMontGob.Text = "0"
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.Lime
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Font = New System.Drawing.Font("Perpetua Titling MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(54, 482)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Padding = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Size = New System.Drawing.Size(131, 33)
        Me.BtnSave.TabIndex = 16
        Me.BtnSave.Text = "Enregistrer"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Perpetua Titling MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(294, 482)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(2)
        Me.Button2.Size = New System.Drawing.Size(115, 33)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Effacer"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Perpetua Titling MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(515, 482)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(2)
        Me.Button3.Size = New System.Drawing.Size(115, 33)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Fermer"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Lblm
        '
        Me.Lblm.AutoSize = True
        Me.Lblm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblm.Location = New System.Drawing.Point(239, 63)
        Me.Lblm.Name = "Lblm"
        Me.Lblm.Size = New System.Drawing.Size(37, 16)
        Me.Lblm.TabIndex = 14
        Me.Lblm.Text = "mois"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 527)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.LblMontGob)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMat As System.Windows.Forms.Label
    Friend WithEvents lblPren As System.Windows.Forms.Label
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblAdres As System.Windows.Forms.Label
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents lblGenre As System.Windows.Forms.Label
    Friend WithEvents TxtVal As System.Windows.Forms.TextBox
    Friend WithEvents TxtPren As System.Windows.Forms.TextBox
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents TxtAdres As System.Windows.Forms.TextBox
    Friend WithEvents TxtTel As System.Windows.Forms.TextBox
    Friend WithEvents CboGenre As System.Windows.Forms.ComboBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChBAutre As System.Windows.Forms.CheckBox
    Friend WithEvents ChBMaladie As System.Windows.Forms.CheckBox
    Friend WithEvents ChBVoy As System.Windows.Forms.CheckBox
    Friend WithEvents chBTrav As System.Windows.Forms.CheckBox
    Friend WithEvents LblSous As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RdbEmbauch As System.Windows.Forms.RadioButton
    Friend WithEvents RdbContract As System.Windows.Forms.RadioButton
    Friend WithEvents RdbJourna As System.Windows.Forms.RadioButton
    Friend WithEvents LblFinSous As System.Windows.Forms.Label
    Friend WithEvents CboDureSous As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblDateSous As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LblMontGob As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Lblm As System.Windows.Forms.Label

End Class
