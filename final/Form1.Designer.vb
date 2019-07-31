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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_user = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_last = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_first = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btn_create = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.AccountsTableAdapter1 = New final.systemdbDataSetTableAdapters.accountsTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_password = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.pass_admin = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_email = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_cat = New Bunifu.Framework.UI.BunifuDropdown()
        Me.txt_secret = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BunifuiOSSwitch1 = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.user_edit = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.fn_edit = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.ln_edit = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btn_edit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.email_edit = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.secret_edit = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.cat_edit = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_close)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(661, 38)
        Me.Panel1.TabIndex = 11
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
        'txt_user
        '
        Me.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_user.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_user.HintForeColor = System.Drawing.Color.Gray
        Me.txt_user.HintText = "Username"
        Me.txt_user.isPassword = False
        Me.txt_user.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.txt_user.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_user.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.txt_user.LineThickness = 3
        Me.txt_user.Location = New System.Drawing.Point(153, 99)
        Me.txt_user.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(379, 33)
        Me.txt_user.TabIndex = 12
        Me.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(74, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 22)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(74, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 22)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(74, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 22)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(74, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 22)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "First Name"
        '
        'txt_last
        '
        Me.txt_last.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_last.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_last.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_last.HintForeColor = System.Drawing.Color.Gray
        Me.txt_last.HintText = "Last Name"
        Me.txt_last.isPassword = False
        Me.txt_last.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.txt_last.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_last.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.txt_last.LineThickness = 3
        Me.txt_last.Location = New System.Drawing.Point(153, 211)
        Me.txt_last.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_last.Name = "txt_last"
        Me.txt_last.Size = New System.Drawing.Size(379, 33)
        Me.txt_last.TabIndex = 18
        Me.txt_last.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_first
        '
        Me.txt_first.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_first.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_first.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_first.HintForeColor = System.Drawing.Color.Gray
        Me.txt_first.HintText = "First Name"
        Me.txt_first.isPassword = False
        Me.txt_first.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.txt_first.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_first.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.txt_first.LineThickness = 3
        Me.txt_first.Location = New System.Drawing.Point(153, 269)
        Me.txt_first.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_first.Name = "txt_first"
        Me.txt_first.Size = New System.Drawing.Size(379, 33)
        Me.txt_first.TabIndex = 20
        Me.txt_first.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_create
        '
        Me.btn_create.ActiveBorderThickness = 1
        Me.btn_create.ActiveCornerRadius = 20
        Me.btn_create.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_create.ActiveForecolor = System.Drawing.Color.White
        Me.btn_create.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_create.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_create.BackgroundImage = CType(resources.GetObject("btn_create.BackgroundImage"), System.Drawing.Image)
        Me.btn_create.ButtonText = "Create"
        Me.btn_create.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_create.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_create.ForeColor = System.Drawing.Color.Black
        Me.btn_create.IdleBorderThickness = 1
        Me.btn_create.IdleCornerRadius = 20
        Me.btn_create.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_create.IdleForecolor = System.Drawing.Color.Black
        Me.btn_create.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_create.Location = New System.Drawing.Point(217, 455)
        Me.btn_create.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(212, 45)
        Me.btn_create.TabIndex = 21
        Me.btn_create.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'AccountsTableAdapter1
        '
        Me.AccountsTableAdapter1.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(354, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Username already exist"
        Me.Label6.Visible = False
        '
        'txt_password
        '
        Me.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_password.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_password.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.txt_password.HintForeColor = System.Drawing.SystemColors.ControlDark
        Me.txt_password.HintText = "Password"
        Me.txt_password.isPassword = False
        Me.txt_password.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txt_password.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_password.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txt_password.LineThickness = 3
        Me.txt_password.Location = New System.Drawing.Point(153, 155)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(379, 33)
        Me.txt_password.TabIndex = 14
        Me.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.BunifuThinButton21)
        Me.Panel2.Controls.Add(Me.pass_admin)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(603, 223)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(69, 59)
        Me.Panel2.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label8.Location = New System.Drawing.Point(121, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(436, 22)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Are you sure you want to delete this account?"
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Proceed"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.Black
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuThinButton21.Location = New System.Drawing.Point(216, 184)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(212, 45)
        Me.BunifuThinButton21.TabIndex = 23
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pass_admin
        '
        Me.pass_admin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pass_admin.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.pass_admin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pass_admin.HintForeColor = System.Drawing.Color.Gray
        Me.pass_admin.HintText = "Password"
        Me.pass_admin.isPassword = False
        Me.pass_admin.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.pass_admin.LineIdleColor = System.Drawing.Color.Gray
        Me.pass_admin.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.pass_admin.LineThickness = 3
        Me.pass_admin.Location = New System.Drawing.Point(128, 140)
        Me.pass_admin.Margin = New System.Windows.Forms.Padding(4)
        Me.pass_admin.Name = "pass_admin"
        Me.pass_admin.Size = New System.Drawing.Size(379, 33)
        Me.pass_admin.TabIndex = 22
        Me.pass_admin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label7.Location = New System.Drawing.Point(162, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(341, 22)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Please input administrator password "
        '
        'txt_email
        '
        Me.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_email.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_email.HintForeColor = System.Drawing.Color.Gray
        Me.txt_email.HintText = "Sample@example.com"
        Me.txt_email.isPassword = False
        Me.txt_email.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.txt_email.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_email.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.txt_email.LineThickness = 3
        Me.txt_email.Location = New System.Drawing.Point(153, 329)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(379, 33)
        Me.txt_email.TabIndex = 27
        Me.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(74, 303)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(134, 22)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Email Address"
        '
        'txt_cat
        '
        Me.txt_cat.BackColor = System.Drawing.Color.Transparent
        Me.txt_cat.BorderRadius = 3
        Me.txt_cat.DisabledColor = System.Drawing.Color.Gray
        Me.txt_cat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cat.ForeColor = System.Drawing.Color.White
        Me.txt_cat.Items = New String() {"Favorite Pet's name?", "Favorite Movie?", "Father's Middle Name?", "Favorite Teacher's Name?", "Favorite Sport's Team?", "High School Name?"}
        Me.txt_cat.Location = New System.Drawing.Point(243, 376)
        Me.txt_cat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_cat.Name = "txt_cat"
        Me.txt_cat.NomalColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cat.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cat.selectedIndex = -1
        Me.txt_cat.Size = New System.Drawing.Size(270, 30)
        Me.txt_cat.TabIndex = 76
        '
        'txt_secret
        '
        Me.txt_secret.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_secret.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_secret.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_secret.HintForeColor = System.Drawing.Color.Gray
        Me.txt_secret.HintText = ""
        Me.txt_secret.isPassword = False
        Me.txt_secret.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.txt_secret.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_secret.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.txt_secret.LineThickness = 3
        Me.txt_secret.Location = New System.Drawing.Point(153, 415)
        Me.txt_secret.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_secret.Name = "txt_secret"
        Me.txt_secret.Size = New System.Drawing.Size(379, 33)
        Me.txt_secret.TabIndex = 75
        Me.txt_secret.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(75, 376)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(155, 22)
        Me.Label16.TabIndex = 74
        Me.Label16.Text = "Secret Question"
        '
        'BunifuiOSSwitch1
        '
        Me.BunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuiOSSwitch1.BackgroundImage = CType(resources.GetObject("BunifuiOSSwitch1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuiOSSwitch1.Location = New System.Drawing.Point(301, 49)
        Me.BunifuiOSSwitch1.Name = "BunifuiOSSwitch1"
        Me.BunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray
        Me.BunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BunifuiOSSwitch1.Size = New System.Drawing.Size(35, 20)
        Me.BunifuiOSSwitch1.TabIndex = 77
        Me.BunifuiOSSwitch1.Value = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(42, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(227, 22)
        Me.Label17.TabIndex = 78
        Me.Label17.Text = "Create Admin Account"
        '
        'user_edit
        '
        Me.user_edit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.user_edit.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.user_edit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.user_edit.HintForeColor = System.Drawing.Color.Gray
        Me.user_edit.HintText = ""
        Me.user_edit.isPassword = False
        Me.user_edit.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.user_edit.LineIdleColor = System.Drawing.Color.Gray
        Me.user_edit.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.user_edit.LineThickness = 3
        Me.user_edit.Location = New System.Drawing.Point(147, 53)
        Me.user_edit.Margin = New System.Windows.Forms.Padding(4)
        Me.user_edit.Name = "user_edit"
        Me.user_edit.Size = New System.Drawing.Size(379, 33)
        Me.user_edit.TabIndex = 14
        Me.user_edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(49, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 22)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Username"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(49, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 22)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "First Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(49, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 22)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Last Name"
        '
        'fn_edit
        '
        Me.fn_edit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fn_edit.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.fn_edit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.fn_edit.HintForeColor = System.Drawing.Color.Gray
        Me.fn_edit.HintText = ""
        Me.fn_edit.isPassword = False
        Me.fn_edit.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.fn_edit.LineIdleColor = System.Drawing.Color.Gray
        Me.fn_edit.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.fn_edit.LineThickness = 3
        Me.fn_edit.Location = New System.Drawing.Point(147, 116)
        Me.fn_edit.Margin = New System.Windows.Forms.Padding(4)
        Me.fn_edit.Name = "fn_edit"
        Me.fn_edit.Size = New System.Drawing.Size(379, 33)
        Me.fn_edit.TabIndex = 22
        Me.fn_edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'ln_edit
        '
        Me.ln_edit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ln_edit.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.ln_edit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ln_edit.HintForeColor = System.Drawing.Color.Gray
        Me.ln_edit.HintText = ""
        Me.ln_edit.isPassword = False
        Me.ln_edit.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.ln_edit.LineIdleColor = System.Drawing.Color.Gray
        Me.ln_edit.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.ln_edit.LineThickness = 3
        Me.ln_edit.Location = New System.Drawing.Point(147, 179)
        Me.ln_edit.Margin = New System.Windows.Forms.Padding(4)
        Me.ln_edit.Name = "ln_edit"
        Me.ln_edit.Size = New System.Drawing.Size(379, 33)
        Me.ln_edit.TabIndex = 23
        Me.ln_edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.btn_edit.ButtonText = "Save"
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.Black
        Me.btn_edit.IdleBorderThickness = 1
        Me.btn_edit.IdleCornerRadius = 20
        Me.btn_edit.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_edit.IdleForecolor = System.Drawing.Color.Black
        Me.btn_edit.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_edit.Location = New System.Drawing.Point(216, 384)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(212, 45)
        Me.btn_edit.TabIndex = 24
        Me.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(250, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(178, 20)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Username already exist"
        Me.Label11.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(49, 216)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(134, 22)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Email Address"
        '
        'email_edit
        '
        Me.email_edit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email_edit.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.email_edit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.email_edit.HintForeColor = System.Drawing.Color.Gray
        Me.email_edit.HintText = ""
        Me.email_edit.isPassword = False
        Me.email_edit.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.email_edit.LineIdleColor = System.Drawing.Color.Gray
        Me.email_edit.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.email_edit.LineThickness = 3
        Me.email_edit.Location = New System.Drawing.Point(147, 235)
        Me.email_edit.Margin = New System.Windows.Forms.Padding(4)
        Me.email_edit.Name = "email_edit"
        Me.email_edit.Size = New System.Drawing.Size(379, 33)
        Me.email_edit.TabIndex = 28
        Me.email_edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(53, 290)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(155, 22)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Secret Question"
        '
        'secret_edit
        '
        Me.secret_edit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.secret_edit.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.secret_edit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.secret_edit.HintForeColor = System.Drawing.Color.Gray
        Me.secret_edit.HintText = ""
        Me.secret_edit.isPassword = False
        Me.secret_edit.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.secret_edit.LineIdleColor = System.Drawing.Color.Gray
        Me.secret_edit.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.secret_edit.LineThickness = 3
        Me.secret_edit.Location = New System.Drawing.Point(147, 329)
        Me.secret_edit.Margin = New System.Windows.Forms.Padding(4)
        Me.secret_edit.Name = "secret_edit"
        Me.secret_edit.Size = New System.Drawing.Size(379, 33)
        Me.secret_edit.TabIndex = 32
        Me.secret_edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cat_edit
        '
        Me.cat_edit.BackColor = System.Drawing.Color.Transparent
        Me.cat_edit.BorderRadius = 3
        Me.cat_edit.DisabledColor = System.Drawing.Color.Gray
        Me.cat_edit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cat_edit.ForeColor = System.Drawing.Color.White
        Me.cat_edit.Items = New String() {"Favorite Pet's name?", "Favorite Movie?", "Father's Middle Name?", "Favorite Teacher's Name?", "Favorite Sport's Team?", "High School Name?"}
        Me.cat_edit.Location = New System.Drawing.Point(221, 290)
        Me.cat_edit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cat_edit.Name = "cat_edit"
        Me.cat_edit.NomalColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cat_edit.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cat_edit.selectedIndex = -1
        Me.cat_edit.Size = New System.Drawing.Size(270, 30)
        Me.cat_edit.TabIndex = 73
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cat_edit)
        Me.Panel3.Controls.Add(Me.secret_edit)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.email_edit)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.btn_edit)
        Me.Panel3.Controls.Add(Me.ln_edit)
        Me.Panel3.Controls.Add(Me.fn_edit)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.user_edit)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(661, 477)
        Me.Panel3.TabIndex = 25
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(661, 515)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txt_cat)
        Me.Controls.Add(Me.txt_secret)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.txt_first)
        Me.Controls.Add(Me.txt_last)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.BunifuiOSSwitch1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CvSU Trouble Ticket"
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_user As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_last As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_first As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btn_create As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents AccountsTableAdapter1 As systemdbDataSetTableAdapters.accountsTableAdapter
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_password As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents pass_admin As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents txt_email As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_cat As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents txt_secret As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label16 As Label
    Friend WithEvents BunifuiOSSwitch1 As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents Label17 As Label
    Friend WithEvents user_edit As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents fn_edit As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents ln_edit As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btn_edit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents email_edit As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label15 As Label
    Friend WithEvents secret_edit As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents cat_edit As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Panel3 As Panel
End Class
