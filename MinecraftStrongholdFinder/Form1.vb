Option Explicit On
Option Strict On

Imports System.Net


Public Class Form1

    'Position 1 X, Z, angle, and radian angle variables
    Dim sngPos1X As Single
    Dim sngPos1Z As Single
    Dim sngPos1A As Single
    Dim sngPos1AR As Single

    'Position 2 X, Z, angle, and radian angle variables
    Dim sngPos2X As Single
    Dim sngPos2Z As Single
    Dim sngPos2A As Single
    Dim sngPos2AR As Single

    'Stronghold X, Z, angle, and radian angle variables
    Dim sngSHX As Single
    Dim sngSHZ As Single
    Dim sngSHA As Single
    Dim sngSHAR As Single

    'Stores the length of the legs of the triangle
    Dim sngPos1toPos2 As Single
    Dim sngPos2toSH As Single

    'Super Secret Variables
    Dim shrtTop As Short
    Dim shrtBot As Short

    'Declination angle formed by Pos1 and Pos2
    Dim sngDeclination As Single

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim shrtError As Short = 0

        If txbPos1X.Text <> "" And txbPos1Z.Text <> "" And txbPos1A.Text <> "" And txbPos2X.Text <> "" And txbPos2Z.Text <> "" And txbPos2A.Text <> "" Then

            'Gathering input from textboxes, flipping Z-axis to be able
            'to do the necessary trig
            Try
                sngPos1X = CSng(txbPos1X.Text)
                sngPos1Z = CSng(txbPos1Z.Text) * -1
                sngPos1A = CSng(txbPos1A.Text)
                Try
                    sngPos2X = CSng(txbPos2X.Text)
                    sngPos2Z = CSng(txbPos2Z.Text) * -1
                    sngPos2A = CSng(txbPos2A.Text)
                Catch ex As Exception
                    shrtError = 1
                    MessageBox.Show("Position 2 coordinates invalid. Please check your input.")
                End Try
            Catch ex As Exception
                shrtError = 1
                MessageBox.Show("Position 1 coordinates invalid. Please check your input.")
            End Try

            If shrtError = 0 Then

                'Minecraft degrees are not determined in the continuous
                '0-360 degree way in trig - also converting to radians
                sngPos1A = MinecraftDegreesToRadians(sngPos1A)
                sngPos2A = MinecraftDegreesToRadians(sngPos2A)

                'Using Pythagorean Theorem to find distance between Pos1 and Pos2
                sngPos1toPos2 = CSng(Math.Sqrt(((sngPos2X - sngPos1X) ^ 2) + ((sngPos2Z - sngPos1Z) ^ 2)))
                lblLegADistance.Text = CStr(sngPos1toPos2)

                'Declination angle formed by Pos1 and Pos2
                sngDeclination = CSng(Math.Atan2((sngPos2Z - sngPos1Z), (sngPos2X - sngPos1X)))

                'determines whether to use interior or
                'exterior angles for Position 1
                sngPos1AR = FindAngle(sngDeclination, sngPos1A)

                'Declination angle formed by Pos1 and Pos2
                sngDeclination = CSng(Math.Atan2((sngPos1Z - sngPos2Z), (sngPos1X - sngPos2X)))

                'determines whether to use interior or
                'exterior angles for Position 2
                sngPos2AR = FindAngle(sngDeclination, sngPos2A)

                'Finding the Stronghold's angle
                sngSHA = CSng(Math.PI - sngPos1AR - sngPos2AR)
                sngSHAR = sngSHA

                'Using Law of Sines to find distance from Position 2 to Stronghold
                sngPos2toSH = CSng((sngPos1toPos2 * Math.Sin(sngPos1AR)) / Math.Sin(sngSHAR))
                lblLegBDistance.Text = CStr(sngPos2toSH)

                'Determining Stronghold coordinates using trig and Position 2 coords
                sngSHX = CSng(sngPos2X + sngPos2toSH * Math.Cos(sngPos2A))
                sngSHZ = CSng(sngPos2Z + sngPos2toSH * Math.Sin(sngPos2A))

                'PROCESSING COMPLETE!
                'OUTPUTTING DATA!
                lblSHX.Text = CStr(CInt(sngSHX))
                lblSHZ.Text = CStr(CInt(sngSHZ) * -1)

                'If the Stronghold's angle is smaller than .3 radians (17 degrees), 
                'then the margin of error may be high
                'Alerting user to this fact
                If Math.Abs(sngSHA) < 0.3 Then
                    MessageBox.Show("Margin of error high. Please move farther away from Position 1.")
                End If
            End If

        Else
            MessageBox.Show("One or more fields are empty.")
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txbPos1X.Text = String.Empty
        txbPos1Z.Text = String.Empty
        txbPos1A.Text = String.Empty
        txbPos2X.Text = String.Empty
        txbPos2Z.Text = String.Empty
        txbPos2A.Text = String.Empty

        lblLegADistance.Text = String.Empty
        lblLegBDistance.Text = String.Empty

        lblSHX.Text = String.Empty
        lblSHZ.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Public Function MinecraftDegreesToRadians(ByVal Degree As Single) As Single

        If (Degree >= 90) Then
            Degree = 180 - (Degree - 90)

        ElseIf (Degree >= 0) Then
            Degree = 270 - Degree

        ElseIf (Degree >= -90) Then
            Degree = 270 + -1 * Degree

        Else
            Degree = -1 * Degree - 90

        End If

        Degree = CSng(Degree * Math.PI / 180)

        Return Degree
    End Function

    Public Function FindAngle(ByVal Declination As Single, ByVal Angle As Single) As Single

        If Declination < 0 Then
            Declination = CSng(Declination + (Math.PI * 2))
        End If

        If Declination > Angle + Math.PI Then
            Return CSng((Math.PI * 2 - Declination) + Angle)

        ElseIf Declination > Angle Then
            Return Declination - Angle

        ElseIf Angle > Declination + Math.PI Then
            Return CSng((Math.PI * 2 - Angle) + Declination)

        Else
            Return Angle - Declination

        End If

    End Function

    Private Sub lblLegADistance_Click(sender As Object, e As EventArgs) Handles lblLegADistance.Click
        shrtTop = 1
        shrtBot = 0
    End Sub

    Private Sub lblLegBDistance_Click(sender As Object, e As EventArgs) Handles lblLegBDistance.Click
        shrtBot = 1

        If shrtTop = 1 And shrtBot = 1 Then
            MessageBox.Show("Quack!")
            shrtBot = 0
            shrtTop = 0
        End If
    End Sub

    Private Sub menuUpdate_Click(sender As Object, e As EventArgs) Handles menuUpdate.Click

        Dim web As New WebClient 'To be able to download the content from the latest version file you have stored.
        Dim shrtError As Short = 0

        web.Proxy() = Nothing
        AddHandler web.DownloadStringCompleted, AddressOf ProcessServerResponse

        Try
            web.DownloadStringAsync(New Uri("http://shk.qc.to/msf_version.txt"))
        Catch ex As Exception
            MessageBox.Show("Error. Could not reach the server.")
        End Try


    End Sub

    Private Sub menuExit_Click(sender As Object, e As EventArgs) Handles menuExit.Click
        Me.Close()
    End Sub

    Private Sub menuAbout_Click(sender As Object, e As EventArgs) Handles menuAbout.Click
        FormAbout.Show()
    End Sub

    Private Sub menuInstructions_Click(sender As Object, e As EventArgs) Handles menuInstructions.Click
        FormInstructions.Show()
    End Sub

    Private Sub txbPos1A_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txbPos1A.Validating

        Dim sngAngle As Single

        If Not Single.TryParse(txbPos1A.Text, sngAngle) OrElse (sngAngle <= -180 Or sngAngle >= 180) Then
            MessageBox.Show("Position angle must be a real number between -180 and 180. Please check your input.")
            txbPos1A.SelectAll()
            txbPos1A.Focus()
        End If
    End Sub

    Private Sub txbPos2A_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txbPos2A.Validating

        Dim sngAngle As Single

        If Not Single.TryParse(txbPos2A.Text, sngAngle) OrElse (sngAngle <= -180 Or sngAngle >= 180) Then
            MessageBox.Show("Position angle must be a real number between -180 and 180. Please check your input.")
            txbPos2A.SelectAll()
            txbPos2A.Focus()
        End If
    End Sub

    Public Sub ProcessServerResponse(ByVal sender As Object, ByVal e As DownloadStringCompletedEventArgs)

        Dim LatestVersion As String = e.Result 'To download the Lastest Version from a specified URL.
        Dim CurrentApp As String 'Gets the applications current version
        CurrentApp = My.Application.Info.Version.ToString

        If CurrentApp < LatestVersion Then 'If the applications current version is less than the Latest version Then it will update, otherwise just do nothing or w/e you want.

            If MessageBox.Show("A new update is available!" & vbNewLine & "Would you like to update?", "Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then 'Message box dialog asking the user if they wish to update or not.
                My.Computer.Network.DownloadFile("http://shk.qc.to/MinecraftStrongholdFinder.exe", Application.StartupPath & "\Updated\MinecraftStrongholdFinder.exe") 'If they choose Yes, it will download the latest version exe
                MsgBox("The update has been downloaded!" & vbNewLine & "The application will now Exit.") 'telling the user the app will close
                End 'exits application
            Else
                'If they choose No
            End If

        ElseIf CurrentApp = LatestVersion Then
            MsgBox("Program is up to date.", , "") 'anything other than the current applications version being less than the latest version.
        End If
    End Sub
End Class

