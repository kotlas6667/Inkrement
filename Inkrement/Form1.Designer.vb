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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCesta = New System.Windows.Forms.TextBox()
        Me.btnVyberCestu = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numInkrement = New System.Windows.Forms.NumericUpDown()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.folderOpen = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAdresar = New System.Windows.Forms.TextBox()
        Me.txtNajvysieCislo = New System.Windows.Forms.TextBox()
        Me.txtKopiAdresar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.numInkrement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vyber cestu :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCesta
        '
        Me.txtCesta.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtCesta.Location = New System.Drawing.Point(120, 12)
        Me.txtCesta.Name = "txtCesta"
        Me.txtCesta.Size = New System.Drawing.Size(272, 24)
        Me.txtCesta.TabIndex = 1
        Me.txtCesta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnVyberCestu
        '
        Me.btnVyberCestu.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnVyberCestu.Location = New System.Drawing.Point(398, 12)
        Me.btnVyberCestu.Name = "btnVyberCestu"
        Me.btnVyberCestu.Size = New System.Drawing.Size(83, 24)
        Me.btnVyberCestu.TabIndex = 2
        Me.btnVyberCestu.Text = "Vyber"
        Me.btnVyberCestu.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Inkrement o :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'numInkrement
        '
        Me.numInkrement.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.numInkrement.Location = New System.Drawing.Point(125, 93)
        Me.numInkrement.Name = "numInkrement"
        Me.numInkrement.Size = New System.Drawing.Size(41, 26)
        Me.numInkrement.TabIndex = 4
        Me.numInkrement.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnStart.Location = New System.Drawing.Point(12, 141)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(83, 24)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnExit.Location = New System.Drawing.Point(398, 141)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 24)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'folderOpen
        '
        Me.folderOpen.SelectedPath = "C:\Users\horvatma\OneDrive - Schaeffler\Programing\VB_NET\SAP_MATRIX\TEST"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Vybraný adr :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAdresar
        '
        Me.txtAdresar.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtAdresar.Location = New System.Drawing.Point(120, 45)
        Me.txtAdresar.Name = "txtAdresar"
        Me.txtAdresar.Size = New System.Drawing.Size(207, 24)
        Me.txtAdresar.TabIndex = 8
        Me.txtAdresar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNajvysieCislo
        '
        Me.txtNajvysieCislo.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtNajvysieCislo.Location = New System.Drawing.Point(360, 75)
        Me.txtNajvysieCislo.Name = "txtNajvysieCislo"
        Me.txtNajvysieCislo.Size = New System.Drawing.Size(65, 24)
        Me.txtNajvysieCislo.TabIndex = 9
        Me.txtNajvysieCislo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtKopiAdresar
        '
        Me.txtKopiAdresar.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtKopiAdresar.Location = New System.Drawing.Point(360, 105)
        Me.txtKopiAdresar.Name = "txtKopiAdresar"
        Me.txtKopiAdresar.Size = New System.Drawing.Size(118, 24)
        Me.txtKopiAdresar.TabIndex = 10
        Me.txtKopiAdresar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(255, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Kopirovany :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(255, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Najvyší adr :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 177)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtKopiAdresar)
        Me.Controls.Add(Me.txtNajvysieCislo)
        Me.Controls.Add(Me.txtAdresar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.numInkrement)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnVyberCestu)
        Me.Controls.Add(Me.txtCesta)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kopirník"
        CType(Me.numInkrement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCesta As TextBox
    Friend WithEvents btnVyberCestu As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents numInkrement As NumericUpDown
    Friend WithEvents btnStart As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents folderOpen As FolderBrowserDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAdresar As TextBox
    Friend WithEvents txtNajvysieCislo As TextBox
    Friend WithEvents txtKopiAdresar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
