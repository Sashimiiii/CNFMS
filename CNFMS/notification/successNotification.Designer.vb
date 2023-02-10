<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class successNotification
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(successNotification))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaCirclePictureBox5 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaElipsePanel1.SuspendLayout()
        CType(Me.GunaCirclePictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.SeaGreen
        Me.GunaElipsePanel1.Controls.Add(Me.GunaControlBox1)
        Me.GunaElipsePanel1.Controls.Add(Me.Label13)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaCirclePictureBox5)
        Me.GunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(411, 94)
        Me.GunaElipsePanel1.TabIndex = 0
        '
        'GunaCirclePictureBox5
        '
        Me.GunaCirclePictureBox5.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox5.Image = CType(resources.GetObject("GunaCirclePictureBox5.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox5.Location = New System.Drawing.Point(77, 20)
        Me.GunaCirclePictureBox5.Name = "GunaCirclePictureBox5"
        Me.GunaCirclePictureBox5.Size = New System.Drawing.Size(55, 53)
        Me.GunaCirclePictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox5.TabIndex = 14
        Me.GunaCirclePictureBox5.TabStop = False
        Me.GunaCirclePictureBox5.UseTransfarantBackground = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(144, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 33)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Success"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.White
        Me.GunaControlBox1.IconSize = 50.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(363, 0)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox1.TabIndex = 16
        '
        'successNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 94)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "successNotification"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "successNotification"
        Me.TopMost = True
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        CType(Me.GunaCirclePictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaCirclePictureBox5 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
End Class
