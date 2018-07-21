<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ThemeForm1 = New Mad_USB.BlackShadesNetForm()
        Me.BlackShadesNetGroupBox3 = New Mad_USB.BlackShadesNetGroupBox()
        Me.txtLog = New System.Windows.Forms.RichTextBox()
        Me.chkObf = New Mad_USB.BlackShadesNetCheckBox()
        Me.btnBuild = New Mad_USB.BlackShadesNetButton()
        Me.BlackShadesNetGroupBox2 = New Mad_USB.BlackShadesNetGroupBox()
        Me.btnIcon = New Mad_USB.BlackShadesNetButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtIcon = New Mad_USB.BlackShadesNetTextBox()
        Me.BlackShadesNetGroupBox1 = New Mad_USB.BlackShadesNetGroupBox()
        Me.btPayload = New Mad_USB.BlackShadesNetButton()
        Me.txtPayload = New Mad_USB.BlackShadesNetTextBox()
        Me.ThemeForm1.SuspendLayout()
        Me.BlackShadesNetGroupBox3.SuspendLayout()
        Me.BlackShadesNetGroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BlackShadesNetGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ThemeForm1
        '
        Me.ThemeForm1.CloseButtonExitsApp = False
        Me.ThemeForm1.Controls.Add(Me.BlackShadesNetGroupBox3)
        Me.ThemeForm1.Controls.Add(Me.BlackShadesNetGroupBox2)
        Me.ThemeForm1.Controls.Add(Me.BlackShadesNetGroupBox1)
        Me.ThemeForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ThemeForm1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ThemeForm1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.ThemeForm1.Location = New System.Drawing.Point(0, 0)
        Me.ThemeForm1.MinimizeButton = True
        Me.ThemeForm1.Name = "ThemeForm1"
        Me.ThemeForm1.Size = New System.Drawing.Size(648, 536)
        Me.ThemeForm1.TabIndex = 0
        Me.ThemeForm1.Text = "MadUSB [NYAN CAT]"
        '
        'BlackShadesNetGroupBox3
        '
        Me.BlackShadesNetGroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BlackShadesNetGroupBox3.Controls.Add(Me.txtLog)
        Me.BlackShadesNetGroupBox3.Controls.Add(Me.chkObf)
        Me.BlackShadesNetGroupBox3.Controls.Add(Me.btnBuild)
        Me.BlackShadesNetGroupBox3.Location = New System.Drawing.Point(13, 371)
        Me.BlackShadesNetGroupBox3.Name = "BlackShadesNetGroupBox3"
        Me.BlackShadesNetGroupBox3.Size = New System.Drawing.Size(623, 114)
        Me.BlackShadesNetGroupBox3.TabIndex = 4
        Me.BlackShadesNetGroupBox3.Text = "Build"
        '
        'txtLog
        '
        Me.txtLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtLog.Location = New System.Drawing.Point(116, 20)
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.Size = New System.Drawing.Size(334, 79)
        Me.txtLog.TabIndex = 9
        Me.txtLog.Text = ""
        '
        'chkObf
        '
        Me.chkObf.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.chkObf.Checked = False
        Me.chkObf.ForeColor = System.Drawing.Color.White
        Me.chkObf.Location = New System.Drawing.Point(470, 20)
        Me.chkObf.Name = "chkObf"
        Me.chkObf.Size = New System.Drawing.Size(139, 14)
        Me.chkObf.TabIndex = 8
        Me.chkObf.Text = "Obfuscation"
        '
        'btnBuild
        '
        Me.btnBuild.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnBuild.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuild.ForeColor = System.Drawing.Color.White
        Me.btnBuild.Location = New System.Drawing.Point(21, 49)
        Me.btnBuild.Name = "btnBuild"
        Me.btnBuild.Size = New System.Drawing.Size(89, 31)
        Me.btnBuild.TabIndex = 6
        Me.btnBuild.Text = "..."
        Me.btnBuild.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'BlackShadesNetGroupBox2
        '
        Me.BlackShadesNetGroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BlackShadesNetGroupBox2.Controls.Add(Me.btnIcon)
        Me.BlackShadesNetGroupBox2.Controls.Add(Me.PictureBox1)
        Me.BlackShadesNetGroupBox2.Controls.Add(Me.txtIcon)
        Me.BlackShadesNetGroupBox2.Location = New System.Drawing.Point(13, 217)
        Me.BlackShadesNetGroupBox2.Name = "BlackShadesNetGroupBox2"
        Me.BlackShadesNetGroupBox2.Size = New System.Drawing.Size(623, 114)
        Me.BlackShadesNetGroupBox2.TabIndex = 3
        Me.BlackShadesNetGroupBox2.Text = "Select Icon"
        '
        'btnIcon
        '
        Me.btnIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnIcon.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnIcon.ForeColor = System.Drawing.Color.White
        Me.btnIcon.Location = New System.Drawing.Point(21, 55)
        Me.btnIcon.Name = "btnIcon"
        Me.btnIcon.Size = New System.Drawing.Size(89, 31)
        Me.btnIcon.TabIndex = 5
        Me.btnIcon.Text = "..."
        Me.btnIcon.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(513, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtIcon
        '
        Me.txtIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtIcon.Location = New System.Drawing.Point(116, 55)
        Me.txtIcon.MaxLength = 32767
        Me.txtIcon.Name = "txtIcon"
        Me.txtIcon.Size = New System.Drawing.Size(334, 31)
        Me.txtIcon.TabIndex = 4
        Me.txtIcon.Text = "..."
        Me.txtIcon.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtIcon.UseSystemPasswordChar = False
        '
        'BlackShadesNetGroupBox1
        '
        Me.BlackShadesNetGroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BlackShadesNetGroupBox1.Controls.Add(Me.btPayload)
        Me.BlackShadesNetGroupBox1.Controls.Add(Me.txtPayload)
        Me.BlackShadesNetGroupBox1.Location = New System.Drawing.Point(13, 63)
        Me.BlackShadesNetGroupBox1.Name = "BlackShadesNetGroupBox1"
        Me.BlackShadesNetGroupBox1.Size = New System.Drawing.Size(623, 114)
        Me.BlackShadesNetGroupBox1.TabIndex = 2
        Me.BlackShadesNetGroupBox1.Text = "Select File"
        '
        'btPayload
        '
        Me.btPayload.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btPayload.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btPayload.ForeColor = System.Drawing.Color.White
        Me.btPayload.Location = New System.Drawing.Point(21, 48)
        Me.btPayload.Name = "btPayload"
        Me.btPayload.Size = New System.Drawing.Size(89, 31)
        Me.btPayload.TabIndex = 3
        Me.btPayload.Text = "..."
        Me.btPayload.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtPayload
        '
        Me.txtPayload.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtPayload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtPayload.Location = New System.Drawing.Point(116, 48)
        Me.txtPayload.MaxLength = 32767
        Me.txtPayload.Name = "txtPayload"
        Me.txtPayload.Size = New System.Drawing.Size(483, 31)
        Me.txtPayload.TabIndex = 0
        Me.txtPayload.Text = "..."
        Me.txtPayload.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPayload.UseSystemPasswordChar = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 536)
        Me.Controls.Add(Me.ThemeForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "MadUSB [NYAN CAT]"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ThemeForm1.ResumeLayout(False)
        Me.BlackShadesNetGroupBox3.ResumeLayout(False)
        Me.BlackShadesNetGroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BlackShadesNetGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ThemeForm1 As BlackShadesNetForm
    Friend WithEvents BlackShadesNetGroupBox1 As BlackShadesNetGroupBox
    Friend WithEvents btPayload As BlackShadesNetButton
    Friend WithEvents txtPayload As BlackShadesNetTextBox
    Friend WithEvents BlackShadesNetGroupBox2 As BlackShadesNetGroupBox
    Friend WithEvents btnIcon As BlackShadesNetButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtIcon As BlackShadesNetTextBox
    Friend WithEvents BlackShadesNetGroupBox3 As BlackShadesNetGroupBox
    Friend WithEvents btnBuild As BlackShadesNetButton
    Friend WithEvents chkObf As BlackShadesNetCheckBox
    Friend WithEvents txtLog As RichTextBox
End Class
