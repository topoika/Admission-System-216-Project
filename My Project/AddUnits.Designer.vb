﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUnits
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lectureres = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ExitAddUnits = New System.Windows.Forms.Button()
        Me.AddUnit = New System.Windows.Forms.Button()
        Me.Credits = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Description = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UnitName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Lectureres)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ExitAddUnits)
        Me.GroupBox1.Controls.Add(Me.AddUnit)
        Me.GroupBox1.Controls.Add(Me.Credits)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Description)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.UnitName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(950, 642)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ADD UNITS"
        '
        'Lectureres
        '
        Me.Lectureres.FormattingEnabled = True
        Me.Lectureres.Location = New System.Drawing.Point(125, 189)
        Me.Lectureres.Name = "Lectureres"
        Me.Lectureres.Size = New System.Drawing.Size(416, 30)
        Me.Lectureres.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(555, 21)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "You can enter the courses on offer for the students to enroll to classes"
        '
        'ExitAddUnits
        '
        Me.ExitAddUnits.Location = New System.Drawing.Point(368, 296)
        Me.ExitAddUnits.Name = "ExitAddUnits"
        Me.ExitAddUnits.Size = New System.Drawing.Size(173, 55)
        Me.ExitAddUnits.TabIndex = 28
        Me.ExitAddUnits.Text = "Exit"
        Me.ExitAddUnits.UseVisualStyleBackColor = True
        '
        'AddUnit
        '
        Me.AddUnit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AddUnit.ForeColor = System.Drawing.Color.White
        Me.AddUnit.Location = New System.Drawing.Point(125, 296)
        Me.AddUnit.Name = "AddUnit"
        Me.AddUnit.Size = New System.Drawing.Size(173, 55)
        Me.AddUnit.TabIndex = 27
        Me.AddUnit.Text = "Add Unit"
        Me.AddUnit.UseVisualStyleBackColor = False
        '
        'Credits
        '
        Me.Credits.Location = New System.Drawing.Point(125, 236)
        Me.Credits.Name = "Credits"
        Me.Credits.Size = New System.Drawing.Size(416, 29)
        Me.Credits.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 21)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Credits"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 21)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Lecturer"
        '
        'Description
        '
        Me.Description.Location = New System.Drawing.Point(125, 142)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(416, 29)
        Me.Description.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 21)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Description"
        '
        'UnitName
        '
        Me.UnitName.Location = New System.Drawing.Point(125, 96)
        Me.UnitName.Name = "UnitName"
        Me.UnitName.Size = New System.Drawing.Size(416, 29)
        Me.UnitName.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 21)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Name"
        '
        'AddUnits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 646)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AddUnits"
        Me.Text = "AddUnits"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AddUnit As Button
    Friend WithEvents Credits As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Description As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents UnitName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ExitAddUnits As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Lectureres As ComboBox
End Class
