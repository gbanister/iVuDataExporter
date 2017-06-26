
'INFO: This Form Is Opened When The User Presses The 'Connect' 
'      Button On The Main Form. This Form Is Used To Select The 
'      Ethernet Communication Parameters For Data Export Reception
Public Class ConnectionForm

    'Shared Copies Of The Settings So The Form Can Re-Open With The
    'Previously Used Parameters 
    Public Shared IPAddress As String = "192.168.0.1"
    Public Shared PortNumber As Int32 = 32100

    Private Sub OnFormLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Assign The Dialog Result Values To The Buttons
        ConnectButton.DialogResult = DialogResult.OK
        CancelButton.DialogResult = DialogResult.Cancel
        Me.AcceptButton = ConnectButton
        Me.CancelButton = CancelButton

        'Open The Form Using The Previously Used Values
        IPAddressTextBox.Text = IPAddress
        PortNumberUpDownBox.Value = PortNumber

    End Sub

    Private Sub OnFormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

        'Reaching Here Means The Form Has Just Closed So Update 
        'The Shared Copies For The Next Time
        IPAddress = IPAddressTextBox.Text
        PortNumber = Convert.ToInt32(PortNumberUpDownBox.Value)

    End Sub
End Class