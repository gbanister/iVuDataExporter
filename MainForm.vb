'  Description: A iVu Series VB.NET (2008) sample application developed by 
'               Banner Engineering Corp for customers, developers
'               and integrators using the iVu Data Export feature of the iVu
'               Plus Sensor Series
'
' Requirements: Visual Studio 2008 or newer OR VB Express (2008) or newer
'               iVu Plus Sensor with the Data Export Channel feature.
'               One or more available PC Ethernet connections.
'               Proper commmunication cables and equipment.
'
'  Notes/Usage: The purpose of this program is to demonstrate simple data 
'               export capture from a iVu Plus Sensor to a PC using Ethernet.
'               This program illustrates how to connect to the iVu Plus sensor
'               via ethernet, capture data from the sensor Data Export Channel
'               and log it to a list box for viewing purposes.
'               This program demonstrates simple .NET socket connection and 
'               synchronous socket reading via a timer event.
'               Other .NET socket programming techniques (multi-threaded and 
'               asynchronous) should be considered when developing client 
'               applications for production purposes.

Imports System.IO
Imports System.Net.Sockets
Imports System.Text

Public Class MainForm

    'The Largest Number Of Bytes We Can Recieve And Display At A Time
    Public Shared MAXIMUM_BUFFER_SIZE As Int32 = 100000

    Dim DataBytes() As Byte
    Dim TCPClient As TcpClient
    Dim TCPStream As NetworkStream
    Dim TotalBytesReceived As UInt64
    Dim _dataList As List(Of String) = New List(Of String)()


    Private Sub OnFormLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Default The Maximum Buffer Size Stored In The List Control
        MaxKBytesUpDownBox.Value = 100

        ' Initialize The Stream Recieve Variables
        ReDim DataBytes(MAXIMUM_BUFFER_SIZE)
        TotalBytesReceived = 0

        ' Configure The Stream Update Timer
        StreamUpdateTimer.Enabled = False
        StreamUpdateTimer.Interval = 1

        ' Default To All Controls The Disconnected State
        SetDisconnectedState()

        Dim saveToolTip = New ToolTip()
        'saveToolTip.ToolTipTitle = "Button Tooltip"
        saveToolTip.UseFading = True
        saveToolTip.UseAnimation = True
        saveToolTip.IsBalloon = True
        saveToolTip.ShowAlways = True
        saveToolTip.SetToolTip(btnSave, "Click to save label data to a file.")
    End Sub

    Private Sub OnFormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        'Always Attempt To Disconnect When The Form Is Closing
        DisconnectFromSensor()

    End Sub

    Private Sub OnConnectButtonClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectButton.Click

        'The User Pressed The Connect Button So Attempt Connection To The Sensor
        ConnectToSensor()

    End Sub

    Private Sub OnDisconnectButtonClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisconnectButton.Click

        'The User Pressed The Disconnect Button So Disconnect From The Sensor
        DisconnectFromSensor()

    End Sub

    Private Sub OnClearListLinkClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearListLink.Click

        'The User Wants To Clear The Current Listing Of Exported Data
        DataExportTextBox.Text = ""
        BytesReceivedTextBox.Text = "0"
        TotalBytesReceived = 0
        ClearListLink.Enabled = False

    End Sub

    Private Sub OnStreamUpdateTimerTick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StreamUpdateTimer.Tick

        Dim BytesToRead As Int32 = 0
        Dim BytesRead As Int32 = 0

        ' Before Continuing Verify The Stream Is Still Valid For Use
        If (TCPClient Is Nothing) Then
            Return
        End If

        ' Since The Stream Is Valid, Check To See If The Connection Has Been Lost
        If (TCPClient.Client.Poll(1, SelectMode.SelectRead) And
                 (TCPClient.Client.Available = 0)) Then
            DisconnectFromSensor()
            MsgBox("The sensor closed the connection." + Environment.NewLine +
                   "Please verify the sensor's configuration and connections to PC.")
            Return
        End If

        ' Determine How Many Bytes To Read
        BytesToRead = TCPClient.Available
        If (BytesToRead > MAXIMUM_BUFFER_SIZE) Then
            BytesToRead = MAXIMUM_BUFFER_SIZE
        End If

        ' Read The Bytes Out Of The Socket And Update The Form Controls
        If (BytesToRead > 0) Then
            BytesRead = TCPStream.Read(DataBytes, 0, BytesToRead)
            If (BytesRead > 0) Then
                TotalBytesReceived += Convert.ToUInt64(BytesRead)
                BytesReceivedTextBox.Text = TotalBytesReceived.ToString()
                AppendResponseData(Encoding.UTF8.GetString(DataBytes, 0, BytesRead))
            End If
        End If

    End Sub

    Private Function ConnectToSensor() As Boolean

        Dim Form As ConnectionForm

        'Show The ConnectForm Which Allows Selection Of Serial Port & Options
        StatusLabel.Text = "Connecting..."
        Form = New ConnectionForm
        If (Form.ShowDialog() <> DialogResult.OK) Then
            StatusLabel.Text = "Disconnected"
            Exit Function
        End If

        'Attempt To Open The Port And Display A Error Message If Needed 
        Try
            TCPClient = New TcpClient(ConnectionForm.IPAddress, ConnectionForm.PortNumber)
        Catch ex As Exception
            MsgBox(ex.Message + vbNewLine + "Open Ethernet Connection Failed", )
            Return False
        End Try

        'Reaching Here Means A Connection Has Been Established So Configure The
        'Socket For Use
        TCPClient.SendBufferSize = 100                    'Small Since We Do Not Send
        TCPClient.ReceiveBufferSize = MAXIMUM_BUFFER_SIZE 'Match To Our Largest Buffered Read
        TCPClient.NoDelay = True                          'Disabled Nagle Send Algorithm 
        TCPStream = TCPClient.GetStream()

        'Update The Form And Controls To Connected State
        SetConnectedState()

        'Start Our Update Timer
        StreamUpdateTimer.Enabled = True
        Return True

    End Function

    Private Sub DisconnectFromSensor()

        ' Reset Controls To The Closed State
        StreamUpdateTimer.Enabled = False
        SetDisconnectedState()

        ' Close The Connection Only If Open
        If (TCPClient Is Nothing) Then
            Return
        Else
            TCPStream.Close()
            TCPClient.Close()
        End If

    End Sub

    Private Sub SetDisconnectedState()

        'Set All Controls To The Disconnected State
        ConnectButton.Enabled = True
        DisconnectButton.Enabled = False
        StatusLabel.Text = "Disconnected"

    End Sub

    Private Sub SetConnectedState()

        'Set All Controls To The Connected State
        ConnectButton.Enabled = False
        DisconnectButton.Enabled = True
        StatusLabel.Text = "Connected"

    End Sub

    Private Sub AppendResponseData(ByVal Response As String)

        Dim LastIndex As Int32 = 0
        Dim NewIndex As Int32 = 0
        Dim Length As Int32 = 0
        Dim OverrunAmount As Int32 = 0
        Dim Delimiter As String
        Dim Suffix As String
        Dim data As String

        ' This Loop Replaces All Line Terminators With ASCII Representations
        ' And Forces Wraps In The Displayed Listing
        LastIndex = 0
        Do
            Delimiter = "\r\n"
            Suffix = "<CR><LF>"
            NewIndex = Response.IndexOf(Delimiter, LastIndex)
            If (NewIndex < 0) Then
                Delimiter = "\n\r"
                Suffix = "<LF><CR>"
                NewIndex = Response.IndexOf(Delimiter, LastIndex)
            End If
            If (NewIndex < 0) Then
                Delimiter = "\n"
                Suffix = "<LF>"
                NewIndex = Response.IndexOf(Delimiter, LastIndex)
            End If
            If (NewIndex < 0) Then
                Delimiter = "\r"
                Suffix = "<CR>"
                NewIndex = Response.IndexOf(Delimiter, LastIndex)
            End If
            If (NewIndex > 0) Then
                Length = (NewIndex - LastIndex)

                data = Response.Substring(LastIndex, Length)
                DataExportTextBox.AppendText(data + Suffix + Environment.NewLine)
                _dataList.Add(data)
                '                ToFile(data)
                LastIndex = (NewIndex + Delimiter.Length)
            End If
        Loop While (NewIndex > 0)


        ' Add The Remaining Bytes On The Next Line
        If (LastIndex < Response.Length) Then
            Length = (Response.Length - LastIndex)
            data = Response.Substring(LastIndex, Length)
            DataExportTextBox.AppendText(data)
            '            ToFile(data)
        End If

        ' Remove Old Data From The Listing If We Have Exceeded The Specified Buffer Size, 
        OverrunAmount = (DataExportTextBox.Text.Length - (1000 * Convert.ToInt32(MaxKBytesUpDownBox.Value)))
        If (OverrunAmount > 0) Then
            DataExportTextBox.Text = DataExportTextBox.Text.Substring(OverrunAmount)
            DataExportTextBox.SelectionStart = (DataExportTextBox.Text.Length - 1)
            DataExportTextBox.ScrollToCaret()
        End If

        ' Enable The Clear List Link Label If The Listing Has Went From Empty To
        ' Containing New Data
        If ((ClearListLink.Enabled = False) And (DataExportTextBox.Text.Length > 0)) Then
            ClearListLink.Enabled = True
        End If

    End Sub

    Private Sub ToBuffer(text As String)
        '        text = Replace(text, vbCrLf, "")
        Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Using outputFile As New StreamWriter(mydocpath & Convert.ToString("\WriteLines.txt"), True)
            outputFile.WriteLine(text)
        End Using
    End Sub


    Private Sub ToFile(text As String)
        '        text = Replace(text, vbCrLf, "")
        Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Using outputFile As New StreamWriter(mydocpath & Convert.ToString("\WriteLines.txt"), True)
            outputFile.WriteLine(text)
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Output" & "_" & DateTime.Now.ToString("yyyyMMdd_HH_mm_ss") & ".txt"

        File.WriteAllLines(mydocpath, _dataList, Encoding.UTF8)

        _dataList.Clear()

        Process.Start("explorer.exe", mydocpath)

        saveMessage.Text = $"The data has been saved to {mydocpath}"
    End Sub

End Class
