<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConnectionForm
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
        Me.ConnectionGroupBox = New System.Windows.Forms.GroupBox
        Me.IPAddressTextBox = New System.Windows.Forms.TextBox
        Me.ConnectButton = New System.Windows.Forms.Button
        Me.CancelButton = New System.Windows.Forms.Button
        Me.PortNumberUpDownBox = New System.Windows.Forms.NumericUpDown
        Me.IPAddressLabel = New System.Windows.Forms.Label
        Me.PortLabel = New System.Windows.Forms.Label
        Me.ConnectionGroupBox.SuspendLayout()
        CType(Me.PortNumberUpDownBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConnectionGroupBox
        '
        Me.ConnectionGroupBox.Controls.Add(Me.IPAddressTextBox)
        Me.ConnectionGroupBox.Controls.Add(Me.ConnectButton)
        Me.ConnectionGroupBox.Controls.Add(Me.CancelButton)
        Me.ConnectionGroupBox.Controls.Add(Me.PortNumberUpDownBox)
        Me.ConnectionGroupBox.Controls.Add(Me.IPAddressLabel)
        Me.ConnectionGroupBox.Controls.Add(Me.PortLabel)
        Me.ConnectionGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.ConnectionGroupBox.Name = "ConnectionGroupBox"
        Me.ConnectionGroupBox.Size = New System.Drawing.Size(205, 119)
        Me.ConnectionGroupBox.TabIndex = 62
        Me.ConnectionGroupBox.TabStop = False
        Me.ConnectionGroupBox.Text = "Data Export Channel"
        '
        'IPAddressTextBox
        '
        Me.IPAddressTextBox.Location = New System.Drawing.Point(80, 24)
        Me.IPAddressTextBox.Name = "IPAddressTextBox"
        Me.IPAddressTextBox.Size = New System.Drawing.Size(111, 20)
        Me.IPAddressTextBox.TabIndex = 61
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(23, 84)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(75, 23)
        Me.ConnectButton.TabIndex = 57
        Me.ConnectButton.Text = "Connect"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(104, 84)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 58
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'PortNumberUpDownBox
        '
        Me.PortNumberUpDownBox.Location = New System.Drawing.Point(80, 52)
        Me.PortNumberUpDownBox.Maximum = New Decimal(New Integer() {65000, 0, 0, 0})
        Me.PortNumberUpDownBox.Name = "PortNumberUpDownBox"
        Me.PortNumberUpDownBox.Size = New System.Drawing.Size(74, 20)
        Me.PortNumberUpDownBox.TabIndex = 54
        '
        'IPAddressLabel
        '
        Me.IPAddressLabel.Location = New System.Drawing.Point(12, 24)
        Me.IPAddressLabel.Name = "IPAddressLabel"
        Me.IPAddressLabel.Size = New System.Drawing.Size(67, 21)
        Me.IPAddressLabel.TabIndex = 59
        Me.IPAddressLabel.Text = "IP Address:"
        Me.IPAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PortLabel
        '
        Me.PortLabel.Location = New System.Drawing.Point(20, 51)
        Me.PortLabel.Name = "PortLabel"
        Me.PortLabel.Size = New System.Drawing.Size(58, 21)
        Me.PortLabel.TabIndex = 53
        Me.PortLabel.Text = "Port:"
        Me.PortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ConnectionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 146)
        Me.Controls.Add(Me.ConnectionGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConnectionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Connect To Sensor..."
        Me.ConnectionGroupBox.ResumeLayout(False)
        Me.ConnectionGroupBox.PerformLayout()
        CType(Me.PortNumberUpDownBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ConnectionGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents IPAddressTextBox As System.Windows.Forms.TextBox
    Private WithEvents ConnectButton As System.Windows.Forms.Button
    Private WithEvents CancelButton As System.Windows.Forms.Button
    Private WithEvents PortNumberUpDownBox As System.Windows.Forms.NumericUpDown
    Private WithEvents IPAddressLabel As System.Windows.Forms.Label
    Private WithEvents PortLabel As System.Windows.Forms.Label
End Class
