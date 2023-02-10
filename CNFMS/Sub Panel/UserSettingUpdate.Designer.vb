<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserSettingUpdate
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserSettingUpdate))
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.newPassTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.confirmPwTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.oldtPassTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.saveButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.jobTxt = New System.Windows.Forms.Label()
        Me.nameFullTxt = New System.Windows.Forms.Label()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.White
        Me.GunaPanel1.Controls.Add(Me.Label2)
        Me.GunaPanel1.Controls.Add(Me.Label10)
        Me.GunaPanel1.Controls.Add(Me.Label9)
        Me.GunaPanel1.Controls.Add(Me.newPassTxt)
        Me.GunaPanel1.Controls.Add(Me.confirmPwTxt)
        Me.GunaPanel1.Controls.Add(Me.oldtPassTxt)
        Me.GunaPanel1.Controls.Add(Me.saveButton)
        Me.GunaPanel1.Controls.Add(Me.Label1)
        Me.GunaPanel1.Controls.Add(Me.jobTxt)
        Me.GunaPanel1.Controls.Add(Me.nameFullTxt)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1691, 1032)
        Me.GunaPanel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(588, 450)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 23)
        Me.Label2.TabIndex = 154
        Me.Label2.Text = "New Password"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(588, 524)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 23)
        Me.Label10.TabIndex = 154
        Me.Label10.Text = "Confirm Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(588, 374)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 23)
        Me.Label9.TabIndex = 155
        Me.Label9.Text = "Old Password"
        '
        'newPassTxt
        '
        Me.newPassTxt.BackColor = System.Drawing.Color.Transparent
        Me.newPassTxt.BaseColor = System.Drawing.Color.White
        Me.newPassTxt.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.newPassTxt.BorderSize = 1
        Me.newPassTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.newPassTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.newPassTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.newPassTxt.FocusedForeColor = System.Drawing.Color.Black
        Me.newPassTxt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newPassTxt.ForeColor = System.Drawing.Color.Black
        Me.newPassTxt.Location = New System.Drawing.Point(592, 476)
        Me.newPassTxt.MaxLength = 999999
        Me.newPassTxt.Name = "newPassTxt"
        Me.newPassTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.newPassTxt.Radius = 5
        Me.newPassTxt.Size = New System.Drawing.Size(515, 37)
        Me.newPassTxt.TabIndex = 153
        Me.newPassTxt.TextOffsetX = 5
        Me.newPassTxt.UseSystemPasswordChar = True
        '
        'confirmPwTxt
        '
        Me.confirmPwTxt.BackColor = System.Drawing.Color.Transparent
        Me.confirmPwTxt.BaseColor = System.Drawing.Color.White
        Me.confirmPwTxt.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.confirmPwTxt.BorderSize = 1
        Me.confirmPwTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.confirmPwTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.confirmPwTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.confirmPwTxt.FocusedForeColor = System.Drawing.Color.Black
        Me.confirmPwTxt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmPwTxt.ForeColor = System.Drawing.Color.Black
        Me.confirmPwTxt.Location = New System.Drawing.Point(592, 550)
        Me.confirmPwTxt.MaxLength = 999999
        Me.confirmPwTxt.Name = "confirmPwTxt"
        Me.confirmPwTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.confirmPwTxt.Radius = 5
        Me.confirmPwTxt.Size = New System.Drawing.Size(515, 37)
        Me.confirmPwTxt.TabIndex = 153
        Me.confirmPwTxt.TextOffsetX = 5
        Me.confirmPwTxt.UseSystemPasswordChar = True
        '
        'oldtPassTxt
        '
        Me.oldtPassTxt.BackColor = System.Drawing.Color.Transparent
        Me.oldtPassTxt.BaseColor = System.Drawing.Color.White
        Me.oldtPassTxt.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.oldtPassTxt.BorderSize = 1
        Me.oldtPassTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.oldtPassTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.oldtPassTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.oldtPassTxt.FocusedForeColor = System.Drawing.Color.Black
        Me.oldtPassTxt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oldtPassTxt.ForeColor = System.Drawing.Color.Black
        Me.oldtPassTxt.Location = New System.Drawing.Point(592, 400)
        Me.oldtPassTxt.MaxLength = 999999
        Me.oldtPassTxt.Name = "oldtPassTxt"
        Me.oldtPassTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.oldtPassTxt.Radius = 5
        Me.oldtPassTxt.Size = New System.Drawing.Size(515, 37)
        Me.oldtPassTxt.TabIndex = 152
        Me.oldtPassTxt.TextOffsetX = 5
        Me.oldtPassTxt.UseSystemPasswordChar = True
        '
        'saveButton
        '
        Me.saveButton.AnimationHoverSpeed = 0.07!
        Me.saveButton.AnimationSpeed = 0.03!
        Me.saveButton.BackColor = System.Drawing.Color.Transparent
        Me.saveButton.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.saveButton.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.saveButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.saveButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.saveButton.FocusedColor = System.Drawing.Color.Empty
        Me.saveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.ForeColor = System.Drawing.Color.White
        Me.saveButton.Image = CType(resources.GetObject("saveButton.Image"), System.Drawing.Image)
        Me.saveButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.saveButton.ImageSize = New System.Drawing.Size(22, 22)
        Me.saveButton.Location = New System.Drawing.Point(493, 664)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.saveButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.saveButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.saveButton.OnHoverForeColor = System.Drawing.Color.White
        Me.saveButton.OnHoverImage = Nothing
        Me.saveButton.OnPressedColor = System.Drawing.Color.Black
        Me.saveButton.Radius = 6
        Me.saveButton.Size = New System.Drawing.Size(190, 50)
        Me.saveButton.TabIndex = 151
        Me.saveButton.Text = "Submit  Changes"
        Me.saveButton.TextOffsetX = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(485, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 45)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "Account"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'jobTxt
        '
        Me.jobTxt.BackColor = System.Drawing.Color.White
        Me.jobTxt.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jobTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.jobTxt.Location = New System.Drawing.Point(6, 184)
        Me.jobTxt.Name = "jobTxt"
        Me.jobTxt.Size = New System.Drawing.Size(1688, 40)
        Me.jobTxt.TabIndex = 150
        Me.jobTxt.Text = "ROLE"
        Me.jobTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nameFullTxt
        '
        Me.nameFullTxt.BackColor = System.Drawing.Color.White
        Me.nameFullTxt.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameFullTxt.ForeColor = System.Drawing.Color.Black
        Me.nameFullTxt.Location = New System.Drawing.Point(3, 128)
        Me.nameFullTxt.Name = "nameFullTxt"
        Me.nameFullTxt.Size = New System.Drawing.Size(1688, 56)
        Me.nameFullTxt.TabIndex = 149
        Me.nameFullTxt.Text = "NAME"
        Me.nameFullTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserSettingUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GunaPanel1)
        Me.Name = "UserSettingUpdate"
        Me.Size = New System.Drawing.Size(1691, 1032)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents saveButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents jobTxt As Label
    Friend WithEvents nameFullTxt As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents confirmPwTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents oldtPassTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents newPassTxt As Guna.UI.WinForms.GunaTextBox
End Class
