Imports StaxRip.UI

Class AudioForm
    Inherits DialogBase

#Region " Designer "

    Protected Overloads Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Friend WithEvents CommandLink1 As StaxRip.UI.CommandLink
    Friend WithEvents gbBasic As System.Windows.Forms.GroupBox
    Friend WithEvents nudQuality As NumEdit
    Friend WithEvents numBitrate As NumEdit
    Friend WithEvents lQualiy As System.Windows.Forms.Label
    Friend WithEvents lCodec As System.Windows.Forms.Label
    Friend WithEvents mbCodec As StaxRip.UI.MenuButton
    Friend WithEvents mbLanguage As StaxRip.UI.MenuButton
    Friend WithEvents lLanguage As System.Windows.Forms.Label
    Friend WithEvents numDelay As NumEdit
    Friend WithEvents lDelay As System.Windows.Forms.Label
    Friend WithEvents rtbCmdlPreview As CommandLineRichTextBox
    Friend WithEvents mbChannels As StaxRip.UI.MenuButton
    Friend WithEvents lChannels As System.Windows.Forms.Label
    Friend WithEvents gbAdvanced As System.Windows.Forms.GroupBox
    Friend WithEvents lName As System.Windows.Forms.Label
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents TipProvider As StaxRip.UI.TipProvider
    Friend WithEvents mbSamplingRate As StaxRip.UI.MenuButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bnOK As StaxRip.UI.ButtonEx
    Friend WithEvents bnCancel As StaxRip.UI.ButtonEx
    Friend WithEvents mbEncoder As StaxRip.UI.MenuButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cbNormalize As StaxRip.UI.CheckBoxEx
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents CommandLineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miCopyComandLine As StaxRip.UI.MenuItemEx
    Friend WithEvents miShowPaths As StaxRip.UI.MenuItemEx
    Friend WithEvents miExecute As StaxRip.UI.MenuItemEx
    Friend WithEvents miProfiles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miDialogHelp As StaxRip.UI.MenuItemEx
    Friend WithEvents SimpleUI As StaxRip.SimpleUI
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents numGain As StaxRip.UI.NumEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AudioForm))
        Me.gbBasic = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lCodec = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.lName = New System.Windows.Forms.Label()
        Me.numDelay = New StaxRip.UI.NumEdit()
        Me.numGain = New StaxRip.UI.NumEdit()
        Me.mbCodec = New StaxRip.UI.MenuButton()
        Me.mbLanguage = New StaxRip.UI.MenuButton()
        Me.mbSamplingRate = New StaxRip.UI.MenuButton()
        Me.lLanguage = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lDelay = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numBitrate = New StaxRip.UI.NumEdit()
        Me.nudQuality = New StaxRip.UI.NumEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mbEncoder = New StaxRip.UI.MenuButton()
        Me.lQualiy = New System.Windows.Forms.Label()
        Me.lChannels = New System.Windows.Forms.Label()
        Me.mbChannels = New StaxRip.UI.MenuButton()
        Me.cbNormalize = New StaxRip.UI.CheckBoxEx()
        Me.rtbCmdlPreview = New StaxRip.UI.CommandLineRichTextBox()
        Me.gbAdvanced = New System.Windows.Forms.GroupBox()
        Me.SimpleUI = New StaxRip.SimpleUI()
        Me.TipProvider = New StaxRip.UI.TipProvider(Me.components)
        Me.bnOK = New StaxRip.UI.ButtonEx()
        Me.bnCancel = New StaxRip.UI.ButtonEx()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.CommandLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miCopyComandLine = New StaxRip.UI.MenuItemEx()
        Me.miExecute = New StaxRip.UI.MenuItemEx()
        Me.miShowPaths = New StaxRip.UI.MenuItemEx()
        Me.miProfiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.miHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.miDialogHelp = New StaxRip.UI.MenuItemEx()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.gbBasic.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.gbAdvanced.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbBasic
        '
        Me.gbBasic.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbBasic.Controls.Add(Me.TableLayoutPanel2)
        Me.gbBasic.Location = New System.Drawing.Point(8, 8)
        Me.gbBasic.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)
        Me.gbBasic.Name = "gbBasic"
        Me.gbBasic.Size = New System.Drawing.Size(475, 515)
        Me.gbBasic.TabIndex = 1
        Me.gbBasic.TabStop = False
        Me.gbBasic.Text = "Basic"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lCodec, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tbName, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.lName, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.numDelay, 3, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.numGain, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.mbCodec, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.mbLanguage, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.mbSamplingRate, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lLanguage, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lDelay, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.numBitrate, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.nudQuality, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.mbEncoder, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lQualiy, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lChannels, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.mbChannels, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.cbNormalize, 2, 4)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 30)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(463, 312)
        Me.TableLayoutPanel2.TabIndex = 44
        '
        'lCodec
        '
        Me.lCodec.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lCodec.AutoSize = True
        Me.lCodec.Location = New System.Drawing.Point(3, 8)
        Me.lCodec.Name = "lCodec"
        Me.lCodec.Size = New System.Drawing.Size(66, 25)
        Me.lCodec.TabIndex = 0
        Me.lCodec.Text = "Codec:"
        '
        'tbName
        '
        Me.tbName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.tbName, 3)
        Me.tbName.Location = New System.Drawing.Point(127, 208)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(333, 31)
        Me.tbName.TabIndex = 16
        '
        'lName
        '
        Me.lName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lName.AutoSize = True
        Me.lName.Location = New System.Drawing.Point(3, 211)
        Me.lName.Name = "lName"
        Me.lName.Size = New System.Drawing.Size(118, 25)
        Me.lName.TabIndex = 15
        Me.lName.Text = "Profile Name:"
        '
        'numDelay
        '
        Me.numDelay.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numDelay.Location = New System.Drawing.Point(361, 126)
        Me.numDelay.Name = "numDelay"
        Me.numDelay.Size = New System.Drawing.Size(99, 35)
        Me.numDelay.TabIndex = 19
        '
        'numGain
        '
        Me.numGain.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numGain.Location = New System.Drawing.Point(361, 85)
        Me.numGain.Name = "numGain"
        Me.numGain.Size = New System.Drawing.Size(99, 35)
        Me.numGain.TabIndex = 37
        '
        'mbCodec
        '
        Me.mbCodec.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mbCodec.Location = New System.Drawing.Point(127, 3)
        Me.mbCodec.ShowMenuSymbol = True
        Me.mbCodec.Size = New System.Drawing.Size(150, 35)
        Me.mbCodec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mbLanguage
        '
        Me.mbLanguage.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mbLanguage.Location = New System.Drawing.Point(127, 167)
        Me.mbLanguage.ShowMenuSymbol = True
        Me.mbLanguage.Size = New System.Drawing.Size(150, 35)
        Me.mbLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mbSamplingRate
        '
        Me.mbSamplingRate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mbSamplingRate.Location = New System.Drawing.Point(127, 126)
        Me.mbSamplingRate.ShowMenuSymbol = True
        Me.mbSamplingRate.Size = New System.Drawing.Size(150, 35)
        Me.mbSamplingRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lLanguage
        '
        Me.lLanguage.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lLanguage.AutoSize = True
        Me.lLanguage.Location = New System.Drawing.Point(3, 172)
        Me.lLanguage.Name = "lLanguage"
        Me.lLanguage.Size = New System.Drawing.Size(93, 25)
        Me.lLanguage.TabIndex = 10
        Me.lLanguage.Text = "Language:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(283, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 25)
        Me.Label4.TabIndex = 36
        Me.Label4.TabStop = True
        Me.Label4.Text = "Gain:"
        '
        'lDelay
        '
        Me.lDelay.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lDelay.AutoSize = True
        Me.lDelay.Location = New System.Drawing.Point(283, 131)
        Me.lDelay.Name = "lDelay"
        Me.lDelay.Size = New System.Drawing.Size(60, 25)
        Me.lDelay.TabIndex = 14
        Me.lDelay.TabStop = True
        Me.lDelay.Text = "Delay:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Sample Rate:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(283, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 25)
        Me.Label3.TabIndex = 29
        Me.Label3.TabStop = True
        Me.Label3.Text = "Bitrate:"
        '
        'numBitrate
        '
        Me.numBitrate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numBitrate.Location = New System.Drawing.Point(361, 3)
        Me.numBitrate.Name = "numBitrate"
        Me.numBitrate.Size = New System.Drawing.Size(99, 35)
        Me.numBitrate.TabIndex = 17
        '
        'nudQuality
        '
        Me.nudQuality.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudQuality.Location = New System.Drawing.Point(361, 44)
        Me.nudQuality.Name = "nudQuality"
        Me.nudQuality.Size = New System.Drawing.Size(99, 35)
        Me.nudQuality.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 25)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Encoder:"
        '
        'mbEncoder
        '
        Me.mbEncoder.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mbEncoder.Location = New System.Drawing.Point(127, 44)
        Me.mbEncoder.ShowMenuSymbol = True
        Me.mbEncoder.Size = New System.Drawing.Size(150, 35)
        Me.mbEncoder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lQualiy
        '
        Me.lQualiy.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lQualiy.AutoSize = True
        Me.lQualiy.Location = New System.Drawing.Point(283, 49)
        Me.lQualiy.Name = "lQualiy"
        Me.lQualiy.Size = New System.Drawing.Size(72, 25)
        Me.lQualiy.TabIndex = 12
        Me.lQualiy.TabStop = True
        Me.lQualiy.Text = "Quality:"
        '
        'lChannels
        '
        Me.lChannels.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lChannels.AutoSize = True
        Me.lChannels.Location = New System.Drawing.Point(3, 90)
        Me.lChannels.Name = "lChannels"
        Me.lChannels.Size = New System.Drawing.Size(87, 25)
        Me.lChannels.TabIndex = 5
        Me.lChannels.Text = "Channels:"
        '
        'mbChannels
        '
        Me.mbChannels.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mbChannels.Location = New System.Drawing.Point(127, 85)
        Me.mbChannels.ShowMenuSymbol = True
        Me.mbChannels.Size = New System.Drawing.Size(150, 35)
        Me.mbChannels.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbNormalize
        '
        Me.cbNormalize.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbNormalize.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.cbNormalize, 2)
        Me.cbNormalize.Location = New System.Drawing.Point(288, 170)
        Me.cbNormalize.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.cbNormalize.Size = New System.Drawing.Size(118, 29)
        Me.cbNormalize.Text = "Normalize"
        Me.cbNormalize.UseVisualStyleBackColor = True
        '
        'rtbCmdlPreview
        '
        Me.rtbCmdlPreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbCmdlPreview.BlockPaint = False
        Me.rtbCmdlPreview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TableLayoutPanel1.SetColumnSpan(Me.rtbCmdlPreview, 2)
        Me.rtbCmdlPreview.LastCommandLine = Nothing
        Me.rtbCmdlPreview.Location = New System.Drawing.Point(8, 531)
        Me.rtbCmdlPreview.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.rtbCmdlPreview.Name = "rtbCmdlPreview"
        Me.rtbCmdlPreview.ReadOnly = True
        Me.rtbCmdlPreview.Size = New System.Drawing.Size(958, 36)
        Me.rtbCmdlPreview.TabIndex = 2
        Me.rtbCmdlPreview.Text = ""
        '
        'gbAdvanced
        '
        Me.gbAdvanced.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbAdvanced.Controls.Add(Me.SimpleUI)
        Me.gbAdvanced.Location = New System.Drawing.Point(491, 8)
        Me.gbAdvanced.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)
        Me.gbAdvanced.Name = "gbAdvanced"
        Me.gbAdvanced.Size = New System.Drawing.Size(475, 515)
        Me.gbAdvanced.TabIndex = 3
        Me.gbAdvanced.TabStop = False
        Me.gbAdvanced.Text = "Advanced"
        '
        'SimpleUI
        '
        Me.SimpleUI.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleUI.Location = New System.Drawing.Point(4, 24)
        Me.SimpleUI.Margin = New System.Windows.Forms.Padding(2)
        Me.SimpleUI.Name = "SimpleUI"
        Me.SimpleUI.Size = New System.Drawing.Size(466, 486)
        Me.SimpleUI.TabIndex = 0
        Me.SimpleUI.Text = "SimpleUI1"
        '
        'bnOK
        '
        Me.bnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bnOK.Location = New System.Drawing.Point(8, 8)
        Me.bnOK.Margin = New System.Windows.Forms.Padding(8)
        Me.bnOK.Size = New System.Drawing.Size(100, 35)
        Me.bnOK.Text = "OK"
        '
        'bnCancel
        '
        Me.bnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bnCancel.Location = New System.Drawing.Point(116, 8)
        Me.bnCancel.Margin = New System.Windows.Forms.Padding(0, 8, 8, 8)
        Me.bnCancel.Size = New System.Drawing.Size(100, 35)
        Me.bnCancel.Text = "Cancel"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 696)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(0, 0)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'MenuStrip
        '
        Me.MenuStrip.AutoSize = False
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CommandLineToolStripMenuItem, Me.miProfiles, Me.miHelp})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(972, 42)
        Me.MenuStrip.TabIndex = 8
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'CommandLineToolStripMenuItem
        '
        Me.CommandLineToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miCopyComandLine, Me.miExecute, Me.miShowPaths})
        Me.CommandLineToolStripMenuItem.Name = "CommandLineToolStripMenuItem"
        Me.CommandLineToolStripMenuItem.Size = New System.Drawing.Size(144, 38)
        Me.CommandLineToolStripMenuItem.Text = "Command Line"
        '
        'miCopyComandLine
        '
        Me.miCopyComandLine.Help = Nothing
        Me.miCopyComandLine.Name = "miCopyComandLine"
        Me.miCopyComandLine.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.miCopyComandLine.Size = New System.Drawing.Size(241, 38)
        Me.miCopyComandLine.Text = "Copy to clipboard"
        '
        'miExecute
        '
        Me.miExecute.Help = Nothing
        Me.miExecute.Name = "miExecute"
        Me.miExecute.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.miExecute.Size = New System.Drawing.Size(241, 38)
        Me.miExecute.Text = "Execute"
        '
        'miShowPaths
        '
        Me.miShowPaths.Help = Nothing
        Me.miShowPaths.Name = "miShowPaths"
        Me.miShowPaths.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.miShowPaths.Size = New System.Drawing.Size(241, 38)
        Me.miShowPaths.Text = "Show paths"
        '
        'miProfiles
        '
        Me.miProfiles.Name = "miProfiles"
        Me.miProfiles.Size = New System.Drawing.Size(82, 38)
        Me.miProfiles.Text = "Profiles"
        '
        'miHelp
        '
        Me.miHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miDialogHelp})
        Me.miHelp.Name = "miHelp"
        Me.miHelp.Size = New System.Drawing.Size(61, 38)
        Me.miHelp.Text = "Help"
        '
        'miDialogHelp
        '
        Me.miDialogHelp.Help = Nothing
        Me.miDialogHelp.Name = "miDialogHelp"
        Me.miDialogHelp.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.miDialogHelp.Size = New System.Drawing.Size(134, 38)
        Me.miDialogHelp.Text = "Help"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.rtbCmdlPreview, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.gbBasic, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.gbAdvanced, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 42)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(972, 618)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.Controls.Add(Me.bnOK)
        Me.FlowLayoutPanel2.Controls.Add(Me.bnCancel)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(750, 567)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(224, 51)
        Me.FlowLayoutPanel2.TabIndex = 11
        '
        'AudioForm
        '
        Me.AcceptButton = Me.bnOK
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.bnCancel
        Me.ClientSize = New System.Drawing.Size(972, 660)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AudioForm"
        Me.Text = "Audio Settings"
        Me.gbBasic.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.gbAdvanced.ResumeLayout(False)
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Profile, TempProfile As GUIAudioProfile

    Sub New()
        MyBase.New()

        InitializeComponent()
        rtbCmdlPreview.ReadOnly = True

        mbChannels.Add("1 (Mono)", 1)
        mbChannels.Add("2 (Stereo)", 2)
        mbChannels.Add("6 (5.1)", 6)
        mbChannels.Add("7 (6.1)", 7)
        mbChannels.Add("8 (7.1)", 8)

        mbSamplingRate.Add("Original", 0)
        mbSamplingRate.Add("11025 Hz", 11025)
        mbSamplingRate.Add("22050 Hz", 22050)
        mbSamplingRate.Add("44100 Hz", 44100)
        mbSamplingRate.Add("48000 Hz", 48000)
        mbSamplingRate.Add("88200 Hz", 88200)
        mbSamplingRate.Add("96000 Hz", 96000)

        numBitrate.Minimum = 16
        numBitrate.Maximum = 16000

        numGain.DecimalPlaces = 1

        If components Is Nothing Then
            components = New System.ComponentModel.Container
        End If

        rtbCmdlPreview.ScrollBars = RichTextBoxScrollBars.None
        miShowPaths.Checked = s.ShowPathsInCommandLine

        UpdateProfilesMenu()

        If g.IsCulture("de") Then
            ActionMenuItem.Add(miHelp.DropDownItems, "BeSweet | Kommandozeilenreferenz", Sub() g.ShellExecute("http://brother-john.net/besweet-referenz.html"))
        Else
            ActionMenuItem.Add(miHelp.DropDownItems, "BeSweet | Commandline Reference", Sub() g.ShellExecute("http://brother-john.net/besweet-reference.html"))
        End If

        ActionMenuItem.Add(miHelp.DropDownItems, "eac3to wiki", Sub() g.ShellExecute("http://en.wikibooks.org/wiki/Eac3to"))
        ActionMenuItem.Add(miHelp.DropDownItems, "ffmpeg help file", Sub() g.ShellExecute(Package.ffmpeg.GetHelpPath))
        ActionMenuItem.Add(miHelp.DropDownItems, "KpeX Audio FAQ", Sub() g.ShellExecute("http://forum.doom9.org/showthread.php?t=68300"))

        g.SetRenderer(MenuStrip)
        MenuStrip.Font = New Font("Segoe UI", 9 * s.UIScaleFactor)

        TipProvider.SetTip("Profile name that is auto generated when undefined.", lName)
        TipProvider.SetTip("Language used by the muxer. Saved in projects/templates but not in profiles.", mbLanguage, lLanguage)
        TipProvider.SetTip("Delay in milliseconds. eac3to and BeSweet handle delay, ffmpeg don't but it is handled by the muxer. Saved in projects/templates but not in profiles.", numDelay, lDelay)
    End Sub

    Private Sub AudioForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If DialogResult = DialogResult.OK Then SetValues(Profile)
    End Sub

    Sub SetValues(gap As GUIAudioProfile)
        gap.Bitrate = TempProfile.Bitrate
        gap.Language = TempProfile.Language
        gap.Channels = TempProfile.Channels
        gap.Delay = TempProfile.Delay
        gap.Name = TempProfile.Name
        gap.StreamName = TempProfile.StreamName
        gap.Gain = TempProfile.Gain
        gap.Default = TempProfile.Default
        gap.Params = TempProfile.Params
    End Sub

    Sub UpdateBitrate()
        nudQuality_ValueChanged(nudQuality)
    End Sub

    Private Sub nudQuality_ValueChanged(numEdit As NumEdit) Handles nudQuality.ValueChanged
        If Not TempProfile Is Nothing Then
            TempProfile.Params.Quality = CSng(nudQuality.Value)
            numBitrate.Value = TempProfile.GetBitrate
            UpdateControls()
        End If
    End Sub

    Private Sub nudBitrate_ValueChanged(numEdit As NumEdit) Handles numBitrate.ValueChanged
        If Not TempProfile Is Nothing Then
            TempProfile.Bitrate = CSng(numBitrate.Value)
            UpdateControls()
        End If
    End Sub

    Private Sub nudDelay_ValueChanged(numEdit As NumEdit) Handles numDelay.ValueChanged
        TempProfile.Delay = CInt(numDelay.Value)
        UpdateControls()
    End Sub

    Private Sub numGain_ValueChanged(numEdit As NumEdit) Handles numGain.ValueChanged
        TempProfile.Gain = numGain.Value
        UpdateControls()
    End Sub

    Sub SimpleUIValueChanged()
        SimpleUI.Save()
        UpdateControls()
    End Sub

    Sub UpdateControls()
        Select Case TempProfile.Params.Codec
            Case AudioCodec.Opus, AudioCodec.Flac
                nudQuality.Enabled = False
            Case Else
                nudQuality.Enabled = TempProfile.Params.RateMode = AudioRateMode.VBR
        End Select

        If TempProfile.Params.Codec = AudioCodec.Flac OrElse TempProfile.Params.Codec = AudioCodec.WAV Then
            numBitrate.Enabled = False
        Else
            numBitrate.Enabled = Not nudQuality.Enabled
        End If

        numBitrate.Increment = If(TempProfile.Params.Codec = AudioCodec.AC3, 32D, 1D)
        tbName.SendMessageCue(TempProfile.Name, False)
        rtbCmdlPreview.SetText(TempProfile.GetCommandLine(s.ShowPathsInCommandLine))
        UpdateHeight(rtbCmdlPreview)
    End Sub

    Sub UpdateHeight(rtb As RichTextBox)
        Using g = rtb.CreateGraphics
            Dim s = g.MeasureString(rtb.Text, rtb.Font, rtb.ClientSize.Width)
            rtb.ClientSize = New Size(rtb.ClientSize.Width, CInt(s.Height + rtb.Font.Height / 7))
        End Using
    End Sub

    Private Sub mbCodec_ValueChangedUser() Handles mbCodec.ValueChangedUser
        TempProfile.Params.Codec = mbCodec.GetValue(Of AudioCodec)()

        Select Case TempProfile.Params.Codec
            Case AudioCodec.AAC
                SetQuality(If(TempProfile.Params.Encoder = GuiAudioEncoder.qaac, 50.0F, 0.35F))
                TempProfile.Params.AacProfile = AudioAacProfile.Automatic
                TempProfile.Params.RateMode = AudioRateMode.VBR
            Case AudioCodec.AC3
                If TempProfile.Channels = 6 Then
                    numBitrate.Value = 448
                Else
                    numBitrate.Value = 224
                End If

                TempProfile.Params.RateMode = AudioRateMode.CBR
            Case AudioCodec.Flac, AudioCodec.WAV
                numBitrate.Value = TempProfile.GetBitrate
                TempProfile.Params.RateMode = AudioRateMode.CBR
            Case AudioCodec.DTS
                If TempProfile.Channels = 6 Then
                    numBitrate.Value = 1536
                Else
                    numBitrate.Value = 768
                End If

                TempProfile.Params.RateMode = AudioRateMode.CBR
            Case AudioCodec.MP3
                SetQuality(4)
                TempProfile.Params.RateMode = AudioRateMode.VBR
            Case AudioCodec.Vorbis
                SetQuality(1)
                TempProfile.Params.RateMode = AudioRateMode.VBR
            Case AudioCodec.Opus
                numBitrate.Value = 80
                TempProfile.Params.RateMode = AudioRateMode.VBR
        End Select

        UpdateBitrate()
        TempProfile.GetCommandLine(False) 'set encoder
        LoadAdvanced()
        UpdateControls()
    End Sub

    Sub SetQuality(value As Single)
        If TempProfile.Params.Codec = AudioCodec.AAC AndAlso
            TempProfile.Params.Encoder = GuiAudioEncoder.qaac Then

            nudQuality.Minimum = 0D
            nudQuality.Maximum = 127D
            nudQuality.Increment = 1D
            nudQuality.DecimalPlaces = 0
        ElseIf TempProfile.Params.Codec = AudioCodec.MP3 Then
            nudQuality.Minimum = 0D
            nudQuality.Maximum = 9D
            nudQuality.Increment = 1D
            nudQuality.DecimalPlaces = 0
        ElseIf TempProfile.Params.Codec = AudioCodec.Vorbis Then
            nudQuality.Minimum = 0D
            nudQuality.Maximum = 10D
            nudQuality.Increment = 1D
            nudQuality.DecimalPlaces = 0
        Else
            nudQuality.Minimum = 0.01D
            nudQuality.Maximum = 1D
            nudQuality.Increment = 0.01D
            nudQuality.DecimalPlaces = 2
        End If

        nudQuality.Value = CDec(value)
    End Sub

    Private Sub mbChannels_ValueChanged() Handles mbChannels.ValueChangedUser
        TempProfile.Channels = mbChannels.GetValue(Of Integer)()
        UpdateBitrate()
        UpdateControls()
    End Sub

    Private Sub mbSamplingRate_ValueChanged() Handles mbSamplingRate.ValueChangedUser
        TempProfile.Params.SamplingRate = mbSamplingRate.GetValue(Of Integer)()
        UpdateBitrate()
        UpdateControls()
    End Sub

    Private Sub mbLanguage_ValueChanged() Handles mbLanguage.ValueChangedUser
        TempProfile.Language = mbLanguage.GetValue(Of Language)()
        UpdateControls()
    End Sub

    Sub ToogleShowPaths()
        s.ShowPathsInCommandLine = Not s.ShowPathsInCommandLine
        miShowPaths.Checked = s.ShowPathsInCommandLine
        Application.DoEvents()
        UpdateControls()
    End Sub

    Private Sub AudioForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        UpdateControls()
        Refresh()

        For Each i In Language.Languages
            If i.IsCommon Then
                mbLanguage.Add(i.ToString, i)
            Else
                mbLanguage.Add("More | " + i.ToString.Substring(0, 1) + " | " + i.ToString, i)
            End If
        Next

        ActiveControl = mbCodec
    End Sub

    Private Sub tbName_TextChanged(sender As Object, e As EventArgs) Handles tbName.TextChanged
        TempProfile.Name = tbName.Text
        UpdateControls()
    End Sub

    Sub UpdateProfilesMenu()
        miProfiles.DropDownItems.Clear()

        For Each i In s.AudioProfiles.OfType(Of GUIAudioProfile)()
            ActionMenuItem.Add(miProfiles.DropDownItems, i.Name, AddressOf LoadProfile2, i, Nothing)
        Next

        miProfiles.DropDownItems.Add("-")

        miProfiles.DropDownItems.Add(New ActionMenuItem("Save", Sub() SaveProfile(), "Saves the current settings as profile"))
        miProfiles.DropDownItems.Add(New ActionMenuItem("Edit...", Sub() EditProfiles(), "Shows the profiles dialog to edit the audio profiles"))
    End Sub

    Sub SaveProfile()
        Dim gap = ObjectHelp.GetCopy(Of GUIAudioProfile)(TempProfile)
        s.AudioProfiles.Insert(0, gap)
        MsgInfo("The profile was saved.")
        UpdateProfilesMenu()
    End Sub

    Sub EditProfiles()
        Using f As New ProfilesForm("Audio Profiles", s.AudioProfiles, Nothing,
                                    Function() g.MainForm.GetNewAudioProfile(Nothing),
                                    AddressOf AudioProfile.GetDefaults)
            f.ShowDialog()
        End Using

        UpdateProfilesMenu()
    End Sub

    Sub LoadProfile2(gap As GUIAudioProfile)
        Dim language = TempProfile.Language
        Dim delay = TempProfile.Delay
        Dim file = TempProfile.File
        Dim gain = TempProfile.Gain

        TempProfile = ObjectHelp.GetCopy(Of GUIAudioProfile)(gap)

        TempProfile.Gain = gain
        TempProfile.Language = language
        TempProfile.Delay = delay
        TempProfile.File = file

        LoadProfile()
    End Sub

    Sub LoadProfile(gap As GUIAudioProfile)
        Profile = gap
        TempProfile = ObjectHelp.GetCopy(Of GUIAudioProfile)(gap)
        LoadProfile()
    End Sub

    Sub LoadProfile()
        If TempProfile.Name <> TempProfile.DefaultName Then
            tbName.Text = TempProfile.Name
        End If

        tbName.SendMessageCue(TempProfile.Name, False)

        mbCodec.Value = TempProfile.Params.Codec
        mbChannels.Value = TempProfile.Channels
        mbLanguage.Value = TempProfile.Language
        mbSamplingRate.Value = TempProfile.Params.SamplingRate
        mbEncoder.Value = TempProfile.Params.Encoder

        SetQuality(TempProfile.Params.Quality)

        numBitrate.Value = CDec(TempProfile.Bitrate)
        numDelay.Value = TempProfile.Delay
        numGain.Value = CDec(TempProfile.Gain)

        cbNormalize.Checked = TempProfile.Params.Normalize

        LoadAdvanced()
        UpdateControls()
    End Sub

    Sub SetBitrate(v As Integer)
        numBitrate.Value = v
    End Sub

    Sub LoadAdvanced()
        RemoveHandler SimpleUI.ValueChanged, AddressOf SimpleUIValueChanged

        Dim ui = SimpleUI
        ui.Host.Controls.Clear()

        If Not ui.ActivePage Is Nothing Then DirectCast(ui.ActivePage, Control).Dispose()

        Dim page = ui.CreateFlowPage("main page")
        page.SuspendLayout()

        Dim tb = ui.AddTextBlock(page)
        tb.Label.Text = "Stream Name:"
        tb.Label.Tooltip = "Stream name used by the muxer."
        tb.Edit.Expandet = True
        tb.Edit.Text = TempProfile.StreamName
        tb.Edit.SaveAction = Sub(value) TempProfile.StreamName = value

        tb = ui.AddTextBlock(page)
        tb.Label.Text = "Custom Switches:"
        tb.Label.Tooltip = "Custom command line arguments"
        tb.Edit.Expandet = True
        tb.Edit.Text = TempProfile.Params.CustomSwitches
        tb.Edit.SaveAction = Sub(value) TempProfile.Params.CustomSwitches = value

        Dim cb As SimpleUI.SimpleUICheckBox

        Select Case TempProfile.GetEncoder
            Case GuiAudioEncoder.BeSweet
                Dim mb = ui.AddMenuButtonBlock(Of String)(page)
                mb.Label.Text = "Dynamic Compr.:"
                mb.Label.Tooltip = "Sets the overall dynamic compression in the decoder (applied to every output speaker)."
                mb.MenuButton.Expandet = True
                mb.MenuButton.Value = TempProfile.Params.BeSweetDynamicCompression
                mb.MenuButton.SaveAction = Sub(value) TempProfile.Params.BeSweetDynamicCompression = value
                mb.MenuButton.Add({"None", "Normal", "Light", "Heavy", "Inverse"})

                If TempProfile.Params.Codec = AudioCodec.AAC Then
                    Dim mbaac = ui.AddMenuButtonBlock(Of AudioAacProfile)(page)
                    mbaac.Label.Text = "AAC Profile:"
                    mbaac.MenuButton.Expandet = True
                    mbaac.MenuButton.Value = TempProfile.Params.AacProfile
                    mbaac.MenuButton.SaveAction = Sub(value) TempProfile.Params.AacProfile = value
                End If

                Dim mbRateMode = ui.AddMenuButtonBlock(Of AudioRateMode)(page)
                mbRateMode.Label.Text = "Rate Mode:"
                mbRateMode.MenuButton.Expandet = True
                mbRateMode.MenuButton.Value = TempProfile.Params.RateMode
                mbRateMode.MenuButton.SaveAction = Sub(value) TempProfile.Params.RateMode = value

                Dim mbFramerate = ui.AddMenuButtonBlock(Of AudioFrameRateMode)(page)
                mbFramerate.Label.Text = "Frame rate:"
                mbFramerate.MenuButton.Expandet = True
                mbFramerate.MenuButton.Value = TempProfile.Params.FrameRateMode
                mbFramerate.MenuButton.SaveAction = Sub(value) TempProfile.Params.FrameRateMode = value

                tb = ui.AddTextBlock(page)
                tb.Label.Text = "Gain/Normalize:"
                tb.Label.Tooltip = "Parameters added to ota section when the Normalize checkbox is enabled."
                tb.Edit.Expandet = True
                tb.Edit.Text = TempProfile.Params.BeSweetGainAndNormalization
                tb.Edit.SaveAction = Sub(value) TempProfile.Params.BeSweetGainAndNormalization = value

                tb = ui.AddTextBlock(page)
                tb.Label.Text = "Azid parameters:"
                tb.Label.Tooltip = "Custom parameters used in the Azid section."
                tb.Edit.Expandet = True
                tb.Edit.Text = TempProfile.Params.BeSweetAzid
                tb.Edit.SaveAction = Sub(value) TempProfile.Params.BeSweetAzid = value
            Case GuiAudioEncoder.Eac3to
                Dim mbFrameRateMode = ui.AddMenuButtonBlock(Of AudioFrameRateMode)(page)
                mbFrameRateMode.Label.Text = "Frame rate:"
                mbFrameRateMode.MenuButton.Expandet = True
                mbFrameRateMode.MenuButton.Value = TempProfile.Params.FrameRateMode
                mbFrameRateMode.MenuButton.SaveAction = Sub(value) TempProfile.Params.FrameRateMode = value

                Dim mbStereoDownmix = ui.AddMenuButtonBlock(Of Integer)(page)
                mbStereoDownmix.Label.Text = "Stereo Downmix:"
                mbStereoDownmix.MenuButton.Expandet = True
                mbStereoDownmix.MenuButton.Add("Simple", 0)
                mbStereoDownmix.MenuButton.Add("DPL II", 1)
                mbStereoDownmix.MenuButton.Value = TempProfile.Params.eac3toStereoDownmixMode
                mbStereoDownmix.MenuButton.SaveAction = Sub(value) TempProfile.Params.eac3toStereoDownmixMode = value

                cb = ui.AddCheckBox(page)
                cb.Text = "Downconvert to 16 bit"
                cb.Checked = TempProfile.Params.Down16
                cb.SaveAction = Sub(value)
                                    TempProfile.Params.Down16 = value
                                    UpdateBitrate()
                                    UpdateControls()
                                End Sub

                If (TempProfile.File = "" OrElse TempProfile.File.ToLower.Contains("dts") OrElse
                    (Not TempProfile.Stream Is Nothing AndAlso
                     TempProfile.Stream.Name.Contains("DTS"))) AndAlso
                    TempProfile.Params.Codec = AudioCodec.DTS Then

                    cb = ui.AddCheckBox(page)
                    cb.Text = "Extract DTS core"
                    cb.Checked = TempProfile.Params.eac3toExtractDtsCore
                    cb.SaveAction = Sub(value) TempProfile.Params.eac3toExtractDtsCore = value
                End If
            Case GuiAudioEncoder.ffmpeg
                Dim mbRateMode = ui.AddMenuButtonBlock(Of AudioRateMode)(page)
                mbRateMode.Label.Text = "Rate Mode:"
                mbRateMode.MenuButton.Expandet = True
                mbRateMode.MenuButton.Value = TempProfile.Params.RateMode
                mbRateMode.MenuButton.SaveAction = Sub(value) TempProfile.Params.RateMode = value
            Case GuiAudioEncoder.qaac
                Dim mbMode = ui.AddMenuButtonBlock(Of Integer)(page)
                mbMode.Label.Text = "Mode:"
                mbMode.MenuButton.Expandet = True
                mbMode.MenuButton.Add("True VBR", 0)
                mbMode.MenuButton.Add("Constrained VBR", 1)
                mbMode.MenuButton.Add("ABR", 2)
                mbMode.MenuButton.Add("CBR", 3)
                mbMode.MenuButton.Value = TempProfile.Params.qaacRateMode
                mbMode.MenuButton.SaveAction = Sub(value)
                                                   TempProfile.Params.qaacRateMode = value
                                                   TempProfile.Params.RateMode = If(TempProfile.Params.qaacRateMode = 0,
                                                                                    AudioRateMode.VBR,
                                                                                    AudioRateMode.CBR)
                                               End Sub

                Dim mbQuality = ui.AddMenuButtonBlock(Of Integer)(page)
                mbQuality.Label.Text = "Quality:"
                mbQuality.MenuButton.Expandet = True
                mbQuality.MenuButton.Add("Low", 0)
                mbQuality.MenuButton.Add("Medium", 1)
                mbQuality.MenuButton.Add("High", 2)
                mbQuality.MenuButton.Value = TempProfile.Params.qaacQuality
                mbQuality.MenuButton.SaveAction = Sub(value) TempProfile.Params.qaacQuality = value

                Dim num = ui.AddNumericBlock(page)
                num.Label.Text = "Lowpass:"
                num.NumEdit.Init(0, Integer.MaxValue, 1, 0)
                num.NumEdit.Value = TempProfile.Params.qaacLowpass
                num.NumEdit.SaveAction = Sub(value) TempProfile.Params.qaacLowpass = CInt(value)

                cb = ui.AddCheckBox(page)
                cb.Text = "High Efficiency"
                cb.Checked = TempProfile.Params.qaacHE
                cb.SaveAction = Sub(value) TempProfile.Params.qaacHE = value
                AddHandler cb.CheckedChanged, Sub() If cb.Checked Then mbMode.MenuButton.Value = 1
                AddHandler mbMode.MenuButton.ValueChangedUser, Sub() If mbMode.MenuButton.Value = 0 Then cb.Checked = False

                cb = ui.AddCheckBox(page)
                cb.Text = "No dither when quantizing to lower bit depth"
                cb.Checked = TempProfile.Params.qaacNoDither
                cb.SaveAction = Sub(value) TempProfile.Params.qaacNoDither = value
        End Select

        cb = ui.AddCheckBox(page)
        cb.Text = "Default Stream"
        cb.Checked = TempProfile.Default
        cb.SaveAction = Sub(value) TempProfile.Default = value

        page.ResumeLayout(True)

        AddHandler SimpleUI.ValueChanged, AddressOf SimpleUIValueChanged
    End Sub

    Private Sub nudBitrate_KeyUp(sender As Object, e As KeyEventArgs) Handles numBitrate.KeyUp
        Try
            Dim v = CInt(numBitrate.Text)
            If v Mod 16 = 0 Then numBitrate.Value = v
        Catch
        End Try
    End Sub

    Private Sub nudQuality_KeyUp(sender As Object, e As KeyEventArgs) Handles nudQuality.KeyUp
        Try
            Dim v = CInt(nudQuality.Text)
            nudQuality.Value = v
        Catch
        End Try
    End Sub

    Private Sub mbEncoder_ValueChangedUser() Handles mbEncoder.ValueChangedUser
        TempProfile.Params.Encoder = mbEncoder.GetValue(Of GuiAudioEncoder)()
        mbCodec_ValueChangedUser()
    End Sub

    Private Sub cbNormalize_CheckedChanged(sender As Object, e As EventArgs) Handles cbNormalize.CheckedChanged
        TempProfile.Params.Normalize = cbNormalize.Checked
        UpdateControls()
    End Sub

    Private Sub miCopyComandLine_Click(sender As Object, e As EventArgs) Handles miCopyComandLine.Click
        Clipboard.SetText(TempProfile.GetCommandLine(True))
    End Sub

    Private Sub miShowPaths_Click(sender As Object, e As EventArgs) Handles miShowPaths.Click
        ToogleShowPaths()
    End Sub

    Private Sub miExecute_Click(sender As Object, e As EventArgs) Handles miExecute.Click
        If TempProfile.File <> "" Then
            If Not TempProfile.SupportedInput.Contains(Filepath.GetExt(TempProfile.File)) Then
                MsgWarn("The input format isn't supported," + BR + "please decode first using:" + BR2 + "Codec: WAV" + BR + "Encoder: ffmpeg")
            Else
                Proc.StartComandLine(TempProfile.GetCommandLine(True))
            End If
        Else
            MsgWarn("Source file is missing!")
        End If
    End Sub

    Private Sub CommandLineAudioSettingsForm_HelpRequested() Handles Me.HelpRequested
        miDialogHelp.PerformClick()
    End Sub

    Private Sub miDialogHelp_Click(sender As Object, e As EventArgs) Handles miDialogHelp.Click
        Dim f As New HelpForm()
        f.Doc.WriteStart(Text)
        f.Doc.WriteTips(TipProvider.GetTips, SimpleUI.ActivePage.TipProvider.GetTips)
        f.Show()
    End Sub
End Class