﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fllocker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fllocker))
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.HuraForm1 = New Computer_Helper.HuraForm()
        Me.HuraGroupBox1 = New Computer_Helper.HuraGroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HuraTextBox2 = New Computer_Helper.HuraTextBox()
        Me.HuraTextBox1 = New Computer_Helper.HuraTextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.HuraButton5 = New Computer_Helper.HuraButton()
        Me.HuraButton4 = New Computer_Helper.HuraButton()
        Me.HuraButton3 = New Computer_Helper.HuraButton()
        Me.HuraButton2 = New Computer_Helper.HuraButton()
        Me.HuraButton1 = New Computer_Helper.HuraButton()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HuraForm1.SuspendLayout()
        Me.HuraGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HuraForm1
        '
        Me.HuraForm1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.ColorScheme = Computer_Helper.HuraForm.ColorSchemes.Dark
        Me.HuraForm1.Controls.Add(Me.HuraGroupBox1)
        Me.HuraForm1.Controls.Add(Me.ListView1)
        Me.HuraForm1.Controls.Add(Me.HuraButton5)
        Me.HuraForm1.Controls.Add(Me.HuraButton4)
        Me.HuraForm1.Controls.Add(Me.HuraButton3)
        Me.HuraForm1.Controls.Add(Me.HuraButton2)
        Me.HuraForm1.Controls.Add(Me.HuraButton1)
        Me.HuraForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HuraForm1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraForm1.ForeColor = System.Drawing.Color.Gray
        Me.HuraForm1.Location = New System.Drawing.Point(0, 0)
        Me.HuraForm1.Name = "HuraForm1"
        Me.HuraForm1.Size = New System.Drawing.Size(529, 341)
        Me.HuraForm1.TabIndex = 0
        Me.HuraForm1.Text = "File Locker"
        '
        'HuraGroupBox1
        '
        Me.HuraGroupBox1.BackColor = System.Drawing.Color.White
        Me.HuraGroupBox1.Controls.Add(Me.Label2)
        Me.HuraGroupBox1.Controls.Add(Me.Label1)
        Me.HuraGroupBox1.Controls.Add(Me.HuraTextBox2)
        Me.HuraGroupBox1.Controls.Add(Me.HuraTextBox1)
        Me.HuraGroupBox1.Location = New System.Drawing.Point(12, 257)
        Me.HuraGroupBox1.Name = "HuraGroupBox1"
        Me.HuraGroupBox1.Size = New System.Drawing.Size(405, 72)
        Me.HuraGroupBox1.TabIndex = 8
        Me.HuraGroupBox1.Text = "HuraGroupBox1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Folder Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Folder Dir:"
        '
        'HuraTextBox2
        '
        Me.HuraTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.HuraTextBox2.BackgroundColour = System.Drawing.Color.White
        Me.HuraTextBox2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.HuraTextBox2.Location = New System.Drawing.Point(93, 38)
        Me.HuraTextBox2.MaxLength = 32767
        Me.HuraTextBox2.Multiline = False
        Me.HuraTextBox2.Name = "HuraTextBox2"
        Me.HuraTextBox2.ReadOnly = False
        Me.HuraTextBox2.Size = New System.Drawing.Size(309, 29)
        Me.HuraTextBox2.Style = Computer_Helper.HuraTextBox.Styles.Normal
        Me.HuraTextBox2.TabIndex = 1
        Me.HuraTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.HuraTextBox2.TextColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraTextBox2.UseSystemPasswordChar = False
        '
        'HuraTextBox1
        '
        Me.HuraTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.HuraTextBox1.BackgroundColour = System.Drawing.Color.White
        Me.HuraTextBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.HuraTextBox1.Location = New System.Drawing.Point(93, 3)
        Me.HuraTextBox1.MaxLength = 32767
        Me.HuraTextBox1.Multiline = False
        Me.HuraTextBox1.Name = "HuraTextBox1"
        Me.HuraTextBox1.ReadOnly = False
        Me.HuraTextBox1.Size = New System.Drawing.Size(309, 29)
        Me.HuraTextBox1.Style = Computer_Helper.HuraTextBox.Styles.Normal
        Me.HuraTextBox1.TabIndex = 0
        Me.HuraTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.HuraTextBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraTextBox1.UseSystemPasswordChar = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.Location = New System.Drawing.Point(12, 29)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(405, 217)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'HuraButton5
        '
        Me.HuraButton5.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton5.BaseColour = System.Drawing.Color.White
        Me.HuraButton5.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton5.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton5.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton5.Location = New System.Drawing.Point(442, 101)
        Me.HuraButton5.Name = "HuraButton5"
        Me.HuraButton5.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton5.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton5.Size = New System.Drawing.Size(75, 30)
        Me.HuraButton5.TabIndex = 6
        Me.HuraButton5.Text = "Browse"
        '
        'HuraButton4
        '
        Me.HuraButton4.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton4.BaseColour = System.Drawing.Color.White
        Me.HuraButton4.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton4.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton4.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton4.Location = New System.Drawing.Point(442, 65)
        Me.HuraButton4.Name = "HuraButton4"
        Me.HuraButton4.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton4.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton4.Size = New System.Drawing.Size(75, 30)
        Me.HuraButton4.TabIndex = 5
        Me.HuraButton4.Text = "Unlock"
        '
        'HuraButton3
        '
        Me.HuraButton3.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton3.BaseColour = System.Drawing.Color.White
        Me.HuraButton3.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton3.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton3.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton3.Location = New System.Drawing.Point(442, 29)
        Me.HuraButton3.Name = "HuraButton3"
        Me.HuraButton3.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton3.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton3.Size = New System.Drawing.Size(75, 30)
        Me.HuraButton3.TabIndex = 4
        Me.HuraButton3.Text = "Lock"
        '
        'HuraButton2
        '
        Me.HuraButton2.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton2.BaseColour = System.Drawing.Color.White
        Me.HuraButton2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.HuraButton2.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton2.ForeColor = System.Drawing.Color.Black
        Me.HuraButton2.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton2.Location = New System.Drawing.Point(469, 3)
        Me.HuraButton2.Name = "HuraButton2"
        Me.HuraButton2.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton2.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton2.Size = New System.Drawing.Size(23, 20)
        Me.HuraButton2.TabIndex = 3
        Me.HuraButton2.Text = "-"
        '
        'HuraButton1
        '
        Me.HuraButton1.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton1.BaseColour = System.Drawing.Color.White
        Me.HuraButton1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.HuraButton1.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton1.ForeColor = System.Drawing.Color.Black
        Me.HuraButton1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton1.Location = New System.Drawing.Point(498, 3)
        Me.HuraButton1.Name = "HuraButton1"
        Me.HuraButton1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton1.Size = New System.Drawing.Size(23, 20)
        Me.HuraButton1.TabIndex = 2
        Me.HuraButton1.Text = "X"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "File Name"
        Me.ColumnHeader1.Width = 169
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "File Path"
        Me.ColumnHeader2.Width = 232
        '
        'fllocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 341)
        Me.Controls.Add(Me.HuraForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fllocker"
        Me.Text = "File Locker"
        Me.HuraForm1.ResumeLayout(False)
        Me.HuraGroupBox1.ResumeLayout(False)
        Me.HuraGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HuraForm1 As HuraForm
    Friend WithEvents HuraButton2 As HuraButton
    Friend WithEvents HuraButton1 As HuraButton
    Friend WithEvents ListView1 As ListView
    Friend WithEvents HuraButton5 As HuraButton
    Friend WithEvents HuraButton4 As HuraButton
    Friend WithEvents HuraButton3 As HuraButton
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents HuraGroupBox1 As HuraGroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents HuraTextBox2 As HuraTextBox
    Friend WithEvents HuraTextBox1 As HuraTextBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
End Class
