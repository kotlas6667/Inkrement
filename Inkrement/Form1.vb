Imports System.IO

Public Class Form1
    Private chybaCopyrovania As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCesta.Text = My.Application.Info.DirectoryPath
        'txtCesta.Text = Directory.GetParent(txtCesta.Text).FullName
        NacitajVsetkyHodnoty()
    End Sub
    Private Sub NacitajVsetkyHodnoty()
        txtNajvysieCislo.Text = ""
        txtKopiAdresar.Text = ""


        txtAdresar.Text = New DirectoryInfo(txtCesta.Text).FullName 'Directory.GetParent(txtCesta.Text).FullName 'new DirectoryInfo(txtCesta.Text).Name
        NaplnHodnoty(txtAdresar.Text)
    End Sub
    Private Sub btnVyberCestu_Click(sender As Object, e As EventArgs) Handles btnVyberCestu.Click
        Try
            txtNajvysieCislo.Text = ""
            txtKopiAdresar.Text = ""
            If folderOpen.ShowDialog = DialogResult.OK Then
                txtCesta.Text = folderOpen.SelectedPath
                txtAdresar.Text = New DirectoryInfo(txtCesta.Text).FullName
                NaplnHodnoty(txtAdresar.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub NaplnHodnoty(ByVal adr As String)
        Dim najvysieCisloAdresar As String = String.Empty
        Dim adresare As New List(Of String)
        Dim adresareCisla As New Dictionary(Of Integer, String)
        Try
            For Each Dir As String In Directory.GetDirectories(adr)
                adresare.Add(Dir)
            Next

            If adresare.Count > 0 Then
                adresareCisla = NajdiNajvysieCislozFolderu(adresare)

                'If adresareCisla.Count > 0 Then
                For Each hodnoty As KeyValuePair(Of Integer, String) In adresareCisla
                        txtNajvysieCislo.Text = hodnoty.Key
                        txtKopiAdresar.Text = New DirectoryInfo(hodnoty.Value).Name
                    Next
                    txtAdresar.Text = New DirectoryInfo(txtCesta.Text).Name
                'End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Function NajdiNajvysieCislozFolderu(ByVal foldere As List(Of String)) As Dictionary(Of Integer, String)
        Dim vratHodnoty As New Dictionary(Of Integer, String)
        Dim largest As Integer = Integer.MinValue
        Dim i As Integer = 0
        Dim vrat As New Dictionary(Of Integer, String)
        Dim zhoda As Boolean = True
        Try
            For Each nazov As String In foldere
                If Len(nazov) > 1 Then
                    If (Not (IsNumeric(Mid(nazov, Len(nazov) - i)))) Then zhoda = False
                    While zhoda
                        If Not (IsNumeric(Mid(nazov, Len(nazov) - i))) Then
                            Dim pomocna = Mid(nazov, Len(nazov) - i)
                            zhoda = False
                            Dim nazovAdr = Trim(Mid(nazov, 1, Len(nazov) - i))
                            Dim c = Trim(CInt(Mid(nazov, Len(nazov) - (i - 1))))
                            vratHodnoty.Add(c, nazovAdr)
                        Else
                            i += 1
                        End If
                    End While
                    i = 0
                    zhoda = True
                End If
            Next

            If vratHodnoty.Count = 0 Then
                vratHodnoty.Add(0, foldere(0))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        For Each element As KeyValuePair(Of Integer, String) In vratHodnoty
            largest = Math.Max(largest, element.Key)
        Next

        For Each value As KeyValuePair(Of Integer, String) In vratHodnoty
            If value.Key = largest Then
                vrat.Add(value.Key, value.Value)
                Exit For
            End If
        Next

        Return vrat
    End Function

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim hodnotaNajIndexu As Integer = cislo(txtNajvysieCislo.Text)
        Dim cestaKopie As String = String.Empty
        Dim cielKopie As String = String.Empty

        If txtKopiAdresar.Text = "" Then
            MessageBox.Show("Nemam adresare na kopirovanie !", "Kopia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("Vytvoriť kopiu adresára " & txtKopiAdresar.Text & " s indexom " & (hodnotaNajIndexu + numInkrement.Value) & " ?", "Kopia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = MsgBoxResult.Yes Then
            Cursor = Cursors.WaitCursor
            'Dim cesta = (New DirectoryInfo(txtCesta.Text).FullName)
            cestaKopie = (txtCesta.Text & "\" & txtKopiAdresar.Text & txtNajvysieCislo.Text) '(cesta & "\" & txtKopiAdresar.Text & txtNajvysieCislo.Text)
            cielKopie = (txtCesta.Text) & "\" & txtKopiAdresar.Text & (hodnotaNajIndexu + numInkrement.Value)
            CopyDirectory(cestaKopie, cielKopie)
            Cursor = Cursors.Default
            If Not chybaCopyrovania Then
                MessageBox.Show("Done", "Kopia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                NacitajVsetkyHodnoty()
            End If
        End If
    End Sub
    Public Sub CopyDirectory(ByVal sourcePath As String, ByVal destinationPath As String)
        Dim sourceDirectoryInfo As New System.IO.DirectoryInfo(sourcePath)

        Try
            ' If the destination folder don't exist then create it
            If Not System.IO.Directory.Exists(destinationPath) Then
                System.IO.Directory.CreateDirectory(destinationPath)
            End If

            Dim fileSystemInfo As System.IO.FileSystemInfo
            For Each fileSystemInfo In sourceDirectoryInfo.GetFileSystemInfos
                Dim destinationFileName As String = System.IO.Path.Combine(destinationPath, fileSystemInfo.Name)

                ' Now check whether its a file or a folder and take action accordingly
                If TypeOf fileSystemInfo Is System.IO.FileInfo Then
                    System.IO.File.Copy(fileSystemInfo.FullName, destinationFileName, True)
                Else
                    ' Recursively call the mothod to copy all the neste folders
                    CopyDirectory(fileSystemInfo.FullName, destinationFileName)
                End If
            Next

        Catch ex As Exception
            chybaCopyrovania = True
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function cislo(ByVal hod As String) As Integer
        Dim vrat As Integer = 0
        If hod <> "" Then vrat = CInt(hod) Else vrat = 0
        Return vrat
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
