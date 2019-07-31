<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login
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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txt_user = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_pass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btn_forgot = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn_login = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_newpass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_verify = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.for_user = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.drop_sec = New Bunifu.Framework.UI.BunifuDropdown()
        Me.for_ans = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_edit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.btn_proceed = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_reset = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(263, 404)
        Me.Panel1.TabIndex = 0
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(30, 252)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(209, 30)
        Me.BunifuCustomLabel3.TabIndex = 11
        Me.BunifuCustomLabel3.Text = "Ticketing System"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(18, 205)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(232, 36)
        Me.BunifuCustomLabel2.TabIndex = 10
        Me.BunifuCustomLabel2.Text = "CvSU Com-Lab"
        '
        'PictureBox3
        '
        Me.BunifuTransition1.SetDecoration(Me.PictureBox3, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox3.Image = Global.final.My.Resources.Resources.logo
        Me.PictureBox3.Location = New System.Drawing.Point(49, 55)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(175, 169)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.btn_close, BunifuAnimatorNS.DecorationType.None)
        Me.btn_close.Image = Global.final.My.Resources.Resources.btn_close
        Me.btn_close.ImageActive = Global.final.My.Resources.Resources.btn_close_active
        Me.btn_close.Location = New System.Drawing.Point(631, 6)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(35, 32)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_close.TabIndex = 12
        Me.btn_close.TabStop = False
        Me.btn_close.Zoom = 30
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(279, 75)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(102, 39)
        Me.BunifuCustomLabel1.TabIndex = 1
        Me.BunifuCustomLabel1.Text = "Login"
        '
        'txt_user
        '
        Me.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txt_user, BunifuAnimatorNS.DecorationType.None)
        Me.txt_user.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_user.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.txt_user.HintForeColor = System.Drawing.SystemColors.ControlDark
        Me.txt_user.HintText = "Username"
        Me.txt_user.isPassword = False
        Me.txt_user.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txt_user.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_user.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txt_user.LineThickness = 3
        Me.txt_user.Location = New System.Drawing.Point(314, 158)
        Me.txt_user.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(336, 33)
        Me.txt_user.TabIndex = 1
        Me.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_pass
        '
        Me.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txt_pass, BunifuAnimatorNS.DecorationType.None)
        Me.txt_pass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_pass.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.txt_pass.HintForeColor = System.Drawing.SystemColors.ControlDark
        Me.txt_pass.HintText = "Password"
        Me.txt_pass.isPassword = False
        Me.txt_pass.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txt_pass.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_pass.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txt_pass.LineThickness = 3
        Me.txt_pass.Location = New System.Drawing.Point(314, 226)
        Me.txt_pass.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(336, 33)
        Me.txt_pass.TabIndex = 2
        Me.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_forgot
        '
        Me.btn_forgot.AutoSize = True
        Me.btn_forgot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btn_forgot, BunifuAnimatorNS.DecorationType.None)
        Me.btn_forgot.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_forgot.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.btn_forgot.Location = New System.Drawing.Point(504, 328)
        Me.btn_forgot.Name = "btn_forgot"
        Me.btn_forgot.Size = New System.Drawing.Size(146, 21)
        Me.btn_forgot.TabIndex = 4
        Me.btn_forgot.Text = "Forgot Password?"
        '
        'btn_login
        '
        Me.btn_login.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_login.BorderRadius = 0
        Me.btn_login.ButtonText = "Login"
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btn_login, BunifuAnimatorNS.DecorationType.None)
        Me.btn_login.DisabledColor = System.Drawing.Color.Gray
        Me.btn_login.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_login.Iconimage = CType(resources.GetObject("btn_login.Iconimage"), System.Drawing.Image)
        Me.btn_login.Iconimage_right = Nothing
        Me.btn_login.Iconimage_right_Selected = Nothing
        Me.btn_login.Iconimage_Selected = Nothing
        Me.btn_login.IconMarginLeft = 0
        Me.btn_login.IconMarginRight = 0
        Me.btn_login.IconRightVisible = True
        Me.btn_login.IconRightZoom = 0R
        Me.btn_login.IconVisible = False
        Me.btn_login.IconZoom = 90.0R
        Me.btn_login.IsTab = False
        Me.btn_login.Location = New System.Drawing.Point(283, 279)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.btn_login.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_login.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_login.selected = False
        Me.btn_login.Size = New System.Drawing.Size(136, 48)
        Me.btn_login.TabIndex = 3
        Me.btn_login.Text = "Login"
        Me.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_login.Textcolor = System.Drawing.Color.White
        Me.btn_login.TextFont = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox2
        '
        Me.BunifuTransition1.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = Global.final.My.Resources.Resources.Lock_52px
        Me.PictureBox2.Location = New System.Drawing.Point(283, 239)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(21, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.BunifuTransition1.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = Global.final.My.Resources.Resources.User_50px
        Me.PictureBox1.Location = New System.Drawing.Point(276, 166)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.BunifuTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.BunifuTransition1.DefaultAnimation = Animation1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.BunifuImageButton1)
        Me.Panel2.Controls.Add(Me.for_user)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.drop_sec)
        Me.Panel2.Controls.Add(Me.for_ans)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.btn_edit)
        Me.BunifuTransition1.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(263, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(403, 404)
        Me.Panel2.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.btn_proceed)
        Me.Panel3.Controls.Add(Me.txt_newpass)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txt_verify)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.btn_reset)
        Me.BunifuTransition1.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.Panel3.Location = New System.Drawing.Point(0, 46)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(403, 346)
        Me.Panel3.TabIndex = 82
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(142, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 22)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Resend Email?"
        '
        'txt_newpass
        '
        Me.txt_newpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txt_newpass, BunifuAnimatorNS.DecorationType.None)
        Me.txt_newpass.Enabled = False
        Me.txt_newpass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_newpass.ForeColor = System.Drawing.Color.White
        Me.txt_newpass.HintForeColor = System.Drawing.Color.White
        Me.txt_newpass.HintText = ""
        Me.txt_newpass.isPassword = False
        Me.txt_newpass.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.txt_newpass.LineIdleColor = System.Drawing.Color.Black
        Me.txt_newpass.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.txt_newpass.LineThickness = 3
        Me.txt_newpass.Location = New System.Drawing.Point(71, 225)
        Me.txt_newpass.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_newpass.Name = "txt_newpass"
        Me.txt_newpass.Size = New System.Drawing.Size(301, 33)
        Me.txt_newpass.TabIndex = 84
        Me.txt_newpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(39, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 22)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "New Password"
        '
        'txt_verify
        '
        Me.txt_verify.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txt_verify, BunifuAnimatorNS.DecorationType.None)
        Me.txt_verify.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_verify.ForeColor = System.Drawing.Color.White
        Me.txt_verify.HintForeColor = System.Drawing.Color.White
        Me.txt_verify.HintText = ""
        Me.txt_verify.isPassword = False
        Me.txt_verify.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.txt_verify.LineIdleColor = System.Drawing.Color.Black
        Me.txt_verify.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.txt_verify.LineThickness = 3
        Me.txt_verify.Location = New System.Drawing.Point(67, 42)
        Me.txt_verify.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_verify.Name = "txt_verify"
        Me.txt_verify.Size = New System.Drawing.Size(301, 33)
        Me.txt_verify.TabIndex = 82
        Me.txt_verify.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(35, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 22)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Verification Code"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label11, BunifuAnimatorNS.DecorationType.None)
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(124, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(173, 20)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "Username does'nt Exist"
        Me.Label11.Visible = False
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.Image = Global.final.My.Resources.Resources.Close1
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(365, 3)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(35, 35)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuImageButton1.TabIndex = 80
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 20
        '
        'for_user
        '
        Me.for_user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.for_user, BunifuAnimatorNS.DecorationType.None)
        Me.for_user.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.for_user.ForeColor = System.Drawing.Color.White
        Me.for_user.HintForeColor = System.Drawing.Color.White
        Me.for_user.HintText = ""
        Me.for_user.isPassword = False
        Me.for_user.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.for_user.LineIdleColor = System.Drawing.Color.Black
        Me.for_user.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.for_user.LineThickness = 3
        Me.for_user.Location = New System.Drawing.Point(51, 121)
        Me.for_user.Margin = New System.Windows.Forms.Padding(4)
        Me.for_user.Name = "for_user"
        Me.for_user.Size = New System.Drawing.Size(301, 33)
        Me.for_user.TabIndex = 79
        Me.for_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(19, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 22)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Username"
        '
        'drop_sec
        '
        Me.drop_sec.BackColor = System.Drawing.Color.Transparent
        Me.drop_sec.BorderRadius = 3
        Me.BunifuTransition1.SetDecoration(Me.drop_sec, BunifuAnimatorNS.DecorationType.None)
        Me.drop_sec.DisabledColor = System.Drawing.Color.Gray
        Me.drop_sec.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drop_sec.ForeColor = System.Drawing.Color.White
        Me.drop_sec.Items = New String() {"Favorite Pet's name?", "Favorite Movie?", "Father's Middle Name?", "Favorite Teacher's Name?", "Favorite Sport's Team?", "High School Name?"}
        Me.drop_sec.Location = New System.Drawing.Point(82, 200)
        Me.drop_sec.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.drop_sec.Name = "drop_sec"
        Me.drop_sec.NomalColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.drop_sec.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.drop_sec.selectedIndex = -1
        Me.drop_sec.Size = New System.Drawing.Size(270, 30)
        Me.drop_sec.TabIndex = 77
        '
        'for_ans
        '
        Me.for_ans.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.for_ans, BunifuAnimatorNS.DecorationType.None)
        Me.for_ans.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.for_ans.ForeColor = System.Drawing.Color.White
        Me.for_ans.HintForeColor = System.Drawing.Color.White
        Me.for_ans.HintText = ""
        Me.for_ans.isPassword = False
        Me.for_ans.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.for_ans.LineIdleColor = System.Drawing.Color.Black
        Me.for_ans.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.for_ans.LineThickness = 3
        Me.for_ans.Location = New System.Drawing.Point(51, 239)
        Me.for_ans.Margin = New System.Windows.Forms.Padding(4)
        Me.for_ans.Name = "for_ans"
        Me.for_ans.Size = New System.Drawing.Size(301, 33)
        Me.for_ans.TabIndex = 76
        Me.for_ans.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label15, BunifuAnimatorNS.DecorationType.None)
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(19, 158)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(160, 22)
        Me.Label15.TabIndex = 75
        Me.Label15.Text = "Secret Question:"
        '
        'btn_edit
        '
        Me.btn_edit.ActiveBorderThickness = 1
        Me.btn_edit.ActiveCornerRadius = 20
        Me.btn_edit.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_edit.ActiveForecolor = System.Drawing.Color.White
        Me.btn_edit.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_edit.BackColor = System.Drawing.Color.DimGray
        Me.btn_edit.BackgroundImage = CType(resources.GetObject("btn_edit.BackgroundImage"), System.Drawing.Image)
        Me.btn_edit.ButtonText = "Send Email"
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btn_edit, BunifuAnimatorNS.DecorationType.None)
        Me.btn_edit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.Black
        Me.btn_edit.IdleBorderThickness = 1
        Me.btn_edit.IdleCornerRadius = 20
        Me.btn_edit.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_edit.IdleForecolor = System.Drawing.Color.Black
        Me.btn_edit.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_edit.Location = New System.Drawing.Point(90, 295)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(212, 45)
        Me.btn_edit.TabIndex = 74
        Me.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "wew"
        Me.NotifyIcon1.BalloonTipTitle = "wew"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        '
        'btn_proceed
        '
        Me.btn_proceed.ActiveBorderThickness = 1
        Me.btn_proceed.ActiveCornerRadius = 20
        Me.btn_proceed.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_proceed.ActiveForecolor = System.Drawing.Color.White
        Me.btn_proceed.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_proceed.BackColor = System.Drawing.Color.DimGray
        Me.btn_proceed.BackgroundImage = CType(resources.GetObject("btn_proceed.BackgroundImage"), System.Drawing.Image)
        Me.btn_proceed.ButtonText = "Proceed"
        Me.btn_proceed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btn_proceed, BunifuAnimatorNS.DecorationType.None)
        Me.btn_proceed.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_proceed.ForeColor = System.Drawing.Color.Black
        Me.btn_proceed.IdleBorderThickness = 1
        Me.btn_proceed.IdleCornerRadius = 20
        Me.btn_proceed.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_proceed.IdleForecolor = System.Drawing.Color.Black
        Me.btn_proceed.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_proceed.Location = New System.Drawing.Point(104, 89)
        Me.btn_proceed.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_proceed.Name = "btn_proceed"
        Me.btn_proceed.Size = New System.Drawing.Size(212, 45)
        Me.btn_proceed.TabIndex = 85
        Me.btn_proceed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_reset
        '
        Me.btn_reset.ActiveBorderThickness = 1
        Me.btn_reset.ActiveCornerRadius = 20
        Me.btn_reset.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_reset.ActiveForecolor = System.Drawing.Color.White
        Me.btn_reset.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_reset.BackColor = System.Drawing.Color.DimGray
        Me.btn_reset.BackgroundImage = CType(resources.GetObject("btn_reset.BackgroundImage"), System.Drawing.Image)
        Me.btn_reset.ButtonText = "Reset Password"
        Me.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btn_reset, BunifuAnimatorNS.DecorationType.None)
        Me.btn_reset.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset.ForeColor = System.Drawing.Color.Black
        Me.btn_reset.IdleBorderThickness = 1
        Me.btn_reset.IdleCornerRadius = 20
        Me.btn_reset.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_reset.IdleForecolor = System.Drawing.Color.Black
        Me.btn_reset.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_reset.Location = New System.Drawing.Point(104, 282)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(212, 45)
        Me.btn_reset.TabIndex = 80
        Me.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_reset.Visible = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(672, 404)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_forgot)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.btn_close)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txt_user As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_pass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_login As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_forgot As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Panel2 As Panel
    Friend WithEvents drop_sec As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents for_ans As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_edit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents for_user As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_newpass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_verify As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents btn_proceed As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_reset As Bunifu.Framework.UI.BunifuThinButton2
End Class
