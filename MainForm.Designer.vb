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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.BytesReceivedTextBox = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.DataExportTextBox = New System.Windows.Forms.TextBox()
        Me.MaxKBytesUpDownBox = New System.Windows.Forms.NumericUpDown()
        Me.label1 = New System.Windows.Forms.Label()
        Me.ClearListLink = New System.Windows.Forms.LinkLabel()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.DisconnectButton = New System.Windows.Forms.Button()
        Me.StreamUpdateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnSave = New System.Windows.Forms.Button()
        Me.saveMessage = New System.Windows.Forms.Label()
        CType(Me.MaxKBytesUpDownBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusLabel
        '
        Me.StatusLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.StatusLabel.Location = New System.Drawing.Point(14, 257)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(82, 18)
        Me.StatusLabel.TabIndex = 82
        Me.StatusLabel.Text = "label4"
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BytesReceivedTextBox
        '
        Me.BytesReceivedTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BytesReceivedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BytesReceivedTextBox.Location = New System.Drawing.Point(301, 258)
        Me.BytesReceivedTextBox.Name = "BytesReceivedTextBox"
        Me.BytesReceivedTextBox.Size = New System.Drawing.Size(74, 17)
        Me.BytesReceivedTextBox.TabIndex = 81
        Me.BytesReceivedTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label3
        '
        Me.label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(213, 259)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(85, 13)
        Me.label3.TabIndex = 80
        Me.label3.Text = "Bytes Received:"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label2
        '
        Me.label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(340, 18)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(40, 13)
        Me.label2.TabIndex = 79
        Me.label2.Text = "KBytes"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataExportTextBox
        '
        Me.DataExportTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataExportTextBox.Location = New System.Drawing.Point(10, 42)
        Me.DataExportTextBox.MaxLength = 32769
        Me.DataExportTextBox.Multiline = True
        Me.DataExportTextBox.Name = "DataExportTextBox"
        Me.DataExportTextBox.ReadOnly = True
        Me.DataExportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataExportTextBox.Size = New System.Drawing.Size(376, 161)
        Me.DataExportTextBox.TabIndex = 78
        '
        'MaxKBytesUpDownBox
        '
        Me.MaxKBytesUpDownBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaxKBytesUpDownBox.Location = New System.Drawing.Point(263, 15)
        Me.MaxKBytesUpDownBox.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.MaxKBytesUpDownBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MaxKBytesUpDownBox.Name = "MaxKBytesUpDownBox"
        Me.MaxKBytesUpDownBox.Size = New System.Drawing.Size(76, 20)
        Me.MaxKBytesUpDownBox.TabIndex = 77
        Me.MaxKBytesUpDownBox.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(199, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(61, 13)
        Me.label1.TabIndex = 76
        Me.label1.Text = "Buffer Size:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ClearListLink
        '
        Me.ClearListLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ClearListLink.AutoSize = True
        Me.ClearListLink.Location = New System.Drawing.Point(101, 260)
        Me.ClearListLink.Name = "ClearListLink"
        Me.ClearListLink.Size = New System.Drawing.Size(50, 13)
        Me.ClearListLink.TabIndex = 75
        Me.ClearListLink.TabStop = True
        Me.ClearListLink.Text = "Clear List"
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(23, 12)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(75, 23)
        Me.ConnectButton.TabIndex = 73
        Me.ConnectButton.Text = "Connect"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'DisconnectButton
        '
        Me.DisconnectButton.Location = New System.Drawing.Point(109, 12)
        Me.DisconnectButton.Name = "DisconnectButton"
        Me.DisconnectButton.Size = New System.Drawing.Size(75, 23)
        Me.DisconnectButton.TabIndex = 74
        Me.DisconnectButton.Text = "Disconnect"
        Me.DisconnectButton.UseVisualStyleBackColor = True
        '
        'StreamUpdateTimer
        '
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(23, 218)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 83
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'saveMessage
        '
        Me.saveMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.saveMessage.AutoSize = True
        Me.saveMessage.Location = New System.Drawing.Point(101, 223)
        Me.saveMessage.Name = "saveMessage"
        Me.saveMessage.Size = New System.Drawing.Size(39, 13)
        Me.saveMessage.TabIndex = 84
        Me.saveMessage.Text = "Label4"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 279)
        Me.Controls.Add(Me.saveMessage)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.BytesReceivedTextBox)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.DataExportTextBox)
        Me.Controls.Add(Me.MaxKBytesUpDownBox)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.ClearListLink)
        Me.Controls.Add(Me.ConnectButton)
        Me.Controls.Add(Me.DisconnectButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "iVu Data Export"
        CType(Me.MaxKBytesUpDownBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents StatusLabel As System.Windows.Forms.Label
    Private WithEvents BytesReceivedTextBox As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents DataExportTextBox As System.Windows.Forms.TextBox
    Private WithEvents MaxKBytesUpDownBox As System.Windows.Forms.NumericUpDown
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents ClearListLink As System.Windows.Forms.LinkLabel
    Private WithEvents ConnectButton As System.Windows.Forms.Button
    Private WithEvents DisconnectButton As System.Windows.Forms.Button
    Friend WithEvents StreamUpdateTimer As System.Windows.Forms.Timer
    Friend WithEvents btnSave As Button
    Friend WithEvents saveMessage As Label
End Class
