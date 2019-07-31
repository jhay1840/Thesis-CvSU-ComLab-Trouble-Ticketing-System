<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pass
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pass))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.lbl_first = New System.Windows.Forms.Label()
        Me.lbl_last = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_edit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.curr_pass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.new_pass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_save = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_close)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(658, 38)
        Me.Panel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 22)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "CvSU Com-Lab Trouble Ticketing System"
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.Image = Global.final.My.Resources.Resources.Close1
        Me.btn_close.ImageActive = Nothing
        Me.btn_close.Location = New System.Drawing.Point(622, 1)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(35, 35)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_close.TabIndex = 10
        Me.btn_close.TabStop = False
        Me.btn_close.Zoom = 20
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_user.Location = New System.Drawing.Point(123, 139)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(106, 22)
        Me.lbl_user.TabIndex = 17
        Me.lbl_user.Text = "Username:"
        '
        'lbl_first
        '
        Me.lbl_first.AutoSize = True
        Me.lbl_first.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_first.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_first.Location = New System.Drawing.Point(123, 181)
        Me.lbl_first.Name = "lbl_first"
        Me.lbl_first.Size = New System.Drawing.Size(101, 22)
        Me.lbl_first.TabIndex = 18
        Me.lbl_first.Text = "Firstname:"
        '
        'lbl_last
        '
        Me.lbl_last.AutoSize = True
        Me.lbl_last.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_last.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_last.Location = New System.Drawing.Point(123, 222)
        Me.lbl_last.Name = "lbl_last"
        Me.lbl_last.Size = New System.Drawing.Size(105, 22)
        Me.lbl_last.TabIndex = 19
        Me.lbl_last.Text = "Lastname:"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_email.Location = New System.Drawing.Point(123, 267)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(61, 22)
        Me.lbl_email.TabIndex = 20
        Me.lbl_email.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(60, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(202, 22)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Account Information"
        '
        'btn_edit
        '
        Me.btn_edit.ActiveBorderThickness = 1
        Me.btn_edit.ActiveCornerRadius = 20
        Me.btn_edit.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_edit.ActiveForecolor = System.Drawing.Color.White
        Me.btn_edit.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_edit.BackgroundImage = CType(resources.GetObject("btn_edit.BackgroundImage"), System.Drawing.Image)
        Me.btn_edit.ButtonText = "Change Password"
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.Black
        Me.btn_edit.IdleBorderThickness = 1
        Me.btn_edit.IdleCornerRadius = 20
        Me.btn_edit.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_edit.IdleForecolor = System.Drawing.Color.Black
        Me.btn_edit.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_edit.Location = New System.Drawing.Point(230, 318)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(212, 45)
        Me.btn_edit.TabIndex = 25
        Me.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'curr_pass
        '
        Me.curr_pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.curr_pass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.curr_pass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.curr_pass.HintForeColor = System.Drawing.Color.Gray
        Me.curr_pass.HintText = ""
        Me.curr_pass.isPassword = True
        Me.curr_pass.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.curr_pass.LineIdleColor = System.Drawing.Color.Gray
        Me.curr_pass.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.curr_pass.LineThickness = 3
        Me.curr_pass.Location = New System.Drawing.Point(158, 105)
        Me.curr_pass.Margin = New System.Windows.Forms.Padding(4)
        Me.curr_pass.Name = "curr_pass"
        Me.curr_pass.Size = New System.Drawing.Size(379, 33)
        Me.curr_pass.TabIndex = 16
        Me.curr_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(60, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(170, 22)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Current Password"
        '
        'new_pass
        '
        Me.new_pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.new_pass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.new_pass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.new_pass.HintForeColor = System.Drawing.Color.Gray
        Me.new_pass.HintText = ""
        Me.new_pass.isPassword = True
        Me.new_pass.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.new_pass.LineIdleColor = System.Drawing.Color.Gray
        Me.new_pass.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.new_pass.LineThickness = 3
        Me.new_pass.Location = New System.Drawing.Point(158, 188)
        Me.new_pass.Margin = New System.Windows.Forms.Padding(4)
        Me.new_pass.Name = "new_pass"
        Me.new_pass.Size = New System.Drawing.Size(379, 33)
        Me.new_pass.TabIndex = 18
        Me.new_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(60, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 22)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "New Password"
        '
        'btn_save
        '
        Me.btn_save.ActiveBorderThickness = 1
        Me.btn_save.ActiveCornerRadius = 20
        Me.btn_save.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_save.ActiveForecolor = System.Drawing.Color.White
        Me.btn_save.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_save.BackgroundImage = CType(resources.GetObject("btn_save.BackgroundImage"), System.Drawing.Image)
        Me.btn_save.ButtonText = "Save"
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.IdleBorderThickness = 1
        Me.btn_save.IdleCornerRadius = 20
        Me.btn_save.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_save.IdleForecolor = System.Drawing.Color.Black
        Me.btn_save.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_save.Location = New System.Drawing.Point(230, 280)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(212, 45)
        Me.btn_save.TabIndex = 25
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.new_pass)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.curr_pass)
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(658, 376)
        Me.Panel2.TabIndex = 26
        '
        'frm_pass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(658, 414)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_last)
        Me.Controls.Add(Me.lbl_first)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_pass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CvSU Trouble Ticket"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lbl_user As Label
    Friend WithEvents lbl_first As Label
    Friend WithEvents lbl_last As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_edit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents curr_pass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents new_pass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_save As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel2 As Panel
End Class
