<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_userAddtkt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_userAddtkt))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_dash = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_addtkt = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_mytkt = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_minimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.txt_pc = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txt_cl = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txt_cat = New Bunifu.Framework.UI.BunifuDropdown()
        Me.lbl_subject = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn_confirm = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txt_subject = New Bunifu.Framework.UI.BunifuDropdown()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_greet = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_dash)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.btn_addtkt)
        Me.Panel1.Controls.Add(Me.btn_mytkt)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 94)
        Me.Panel1.TabIndex = 50
        '
        'btn_dash
        '
        Me.btn_dash.ActiveBorderThickness = 1
        Me.btn_dash.ActiveCornerRadius = 10
        Me.btn_dash.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_dash.ActiveForecolor = System.Drawing.Color.Black
        Me.btn_dash.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_dash.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_dash.BackgroundImage = CType(resources.GetObject("btn_dash.BackgroundImage"), System.Drawing.Image)
        Me.btn_dash.ButtonText = "Dashboard"
        Me.btn_dash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_dash.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dash.ForeColor = System.Drawing.Color.Black
        Me.btn_dash.IdleBorderThickness = 1
        Me.btn_dash.IdleCornerRadius = 10
        Me.btn_dash.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_dash.IdleForecolor = System.Drawing.Color.White
        Me.btn_dash.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_dash.Location = New System.Drawing.Point(0, 67)
        Me.btn_dash.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_dash.Name = "btn_dash"
        Me.btn_dash.Size = New System.Drawing.Size(115, 36)
        Me.btn_dash.TabIndex = 15
        Me.btn_dash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.Title)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(883, 60)
        Me.Panel5.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Title.Location = New System.Drawing.Point(89, 16)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(373, 22)
        Me.Title.TabIndex = 6
        Me.Title.Text = "CvSU Com-Lab Trouble Ticketing System"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(804, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 22)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Date"
        Me.Label8.Visible = False
        '
        'btn_addtkt
        '
        Me.btn_addtkt.ActiveBorderThickness = 1
        Me.btn_addtkt.ActiveCornerRadius = 10
        Me.btn_addtkt.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_addtkt.ActiveForecolor = System.Drawing.Color.Black
        Me.btn_addtkt.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_addtkt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_addtkt.BackgroundImage = CType(resources.GetObject("btn_addtkt.BackgroundImage"), System.Drawing.Image)
        Me.btn_addtkt.ButtonText = "Add Ticket"
        Me.btn_addtkt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addtkt.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addtkt.ForeColor = System.Drawing.Color.Black
        Me.btn_addtkt.IdleBorderThickness = 1
        Me.btn_addtkt.IdleCornerRadius = 10
        Me.btn_addtkt.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_addtkt.IdleForecolor = System.Drawing.Color.Black
        Me.btn_addtkt.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_addtkt.Location = New System.Drawing.Point(242, 67)
        Me.btn_addtkt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_addtkt.Name = "btn_addtkt"
        Me.btn_addtkt.Size = New System.Drawing.Size(115, 36)
        Me.btn_addtkt.TabIndex = 3
        Me.btn_addtkt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_mytkt
        '
        Me.btn_mytkt.ActiveBorderThickness = 1
        Me.btn_mytkt.ActiveCornerRadius = 10
        Me.btn_mytkt.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_mytkt.ActiveForecolor = System.Drawing.Color.Black
        Me.btn_mytkt.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_mytkt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_mytkt.BackgroundImage = CType(resources.GetObject("btn_mytkt.BackgroundImage"), System.Drawing.Image)
        Me.btn_mytkt.ButtonText = "My Tickets"
        Me.btn_mytkt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mytkt.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mytkt.ForeColor = System.Drawing.Color.Black
        Me.btn_mytkt.IdleBorderThickness = 1
        Me.btn_mytkt.IdleCornerRadius = 10
        Me.btn_mytkt.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_mytkt.IdleForecolor = System.Drawing.Color.White
        Me.btn_mytkt.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_mytkt.Location = New System.Drawing.Point(121, 67)
        Me.btn_mytkt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_mytkt.Name = "btn_mytkt"
        Me.btn_mytkt.Size = New System.Drawing.Size(115, 36)
        Me.btn_mytkt.TabIndex = 2
        Me.btn_mytkt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BunifuFlatButton1)
        Me.Panel3.Controls.Add(Me.btn_close)
        Me.Panel3.Controls.Add(Me.btn_minimize)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(883, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(117, 94)
        Me.Panel3.TabIndex = 10
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Log Out"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 70.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(0, 59)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(117, 35)
        Me.BunifuFlatButton1.TabIndex = 13
        Me.BunifuFlatButton1.Text = "Log Out"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.Image = Global.final.My.Resources.Resources.Close1
        Me.btn_close.ImageActive = Nothing
        Me.btn_close.Location = New System.Drawing.Point(79, 3)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(35, 35)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_close.TabIndex = 9
        Me.btn_close.TabStop = False
        Me.btn_close.Zoom = 20
        '
        'btn_minimize
        '
        Me.btn_minimize.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimize.Image = CType(resources.GetObject("btn_minimize.Image"), System.Drawing.Image)
        Me.btn_minimize.ImageActive = Nothing
        Me.btn_minimize.Location = New System.Drawing.Point(45, 3)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(35, 35)
        Me.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_minimize.TabIndex = 7
        Me.btn_minimize.TabStop = False
        Me.btn_minimize.Zoom = 20
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.BunifuCustomLabel5)
        Me.Panel4.Controls.Add(Me.RichTextBox2)
        Me.Panel4.Controls.Add(Me.txt_pc)
        Me.Panel4.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel4.Controls.Add(Me.txt_cl)
        Me.Panel4.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel4.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel4.Controls.Add(Me.txt_cat)
        Me.Panel4.Controls.Add(Me.lbl_subject)
        Me.Panel4.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel4.Controls.Add(Me.btn_confirm)
        Me.Panel4.Controls.Add(Me.txt_subject)
        Me.Panel4.Controls.Add(Me.RichTextBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(0, 132)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1000, 468)
        Me.Panel4.TabIndex = 58
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(54, 269)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(128, 24)
        Me.BunifuCustomLabel5.TabIndex = 77
        Me.BunifuCustomLabel5.Text = "User Action:"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(189, 281)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(638, 78)
        Me.RichTextBox2.TabIndex = 6
        Me.RichTextBox2.Text = ""
        '
        'txt_pc
        '
        Me.txt_pc.Location = New System.Drawing.Point(726, 76)
        Me.txt_pc.Name = "txt_pc"
        Me.txt_pc.Size = New System.Drawing.Size(93, 23)
        Me.txt_pc.TabIndex = 4
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(583, 75)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(77, 24)
        Me.BunifuCustomLabel4.TabIndex = 75
        Me.BunifuCustomLabel4.Text = "PC no."
        '
        'txt_cl
        '
        Me.txt_cl.BackColor = System.Drawing.Color.Transparent
        Me.txt_cl.BorderRadius = 3
        Me.txt_cl.DisabledColor = System.Drawing.Color.Gray
        Me.txt_cl.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cl.ForeColor = System.Drawing.Color.White
        Me.txt_cl.Items = New String() {"Hardware", "Software", "Network", "Others"}
        Me.txt_cl.Location = New System.Drawing.Point(726, 29)
        Me.txt_cl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_cl.Name = "txt_cl"
        Me.txt_cl.NomalColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cl.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cl.selectedIndex = -1
        Me.txt_cl.Size = New System.Drawing.Size(101, 30)
        Me.txt_cl.TabIndex = 3
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(583, 35)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(136, 24)
        Me.BunifuCustomLabel3.TabIndex = 73
        Me.BunifuCustomLabel3.Text = "Comlab No."
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(89, 153)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(82, 24)
        Me.BunifuCustomLabel1.TabIndex = 57
        Me.BunifuCustomLabel1.Text = "Details:"
        '
        'txt_cat
        '
        Me.txt_cat.BackColor = System.Drawing.Color.Transparent
        Me.txt_cat.BorderRadius = 3
        Me.txt_cat.DisabledColor = System.Drawing.Color.Gray
        Me.txt_cat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cat.ForeColor = System.Drawing.Color.White
        Me.txt_cat.Items = New String() {"Hardware", "Software", "Network", "Others"}
        Me.txt_cat.Location = New System.Drawing.Point(189, 29)
        Me.txt_cat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_cat.Name = "txt_cat"
        Me.txt_cat.NomalColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cat.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cat.selectedIndex = -1
        Me.txt_cat.Size = New System.Drawing.Size(270, 30)
        Me.txt_cat.TabIndex = 1
        '
        'lbl_subject
        '
        Me.lbl_subject.AutoSize = True
        Me.lbl_subject.BackColor = System.Drawing.Color.Transparent
        Me.lbl_subject.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subject.Location = New System.Drawing.Point(71, 75)
        Me.lbl_subject.Name = "lbl_subject"
        Me.lbl_subject.Size = New System.Drawing.Size(90, 24)
        Me.lbl_subject.TabIndex = 52
        Me.lbl_subject.Text = "Subject:"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(70, 35)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(112, 24)
        Me.BunifuCustomLabel2.TabIndex = 71
        Me.BunifuCustomLabel2.Text = "Category:"
        '
        'btn_confirm
        '
        Me.btn_confirm.ActiveBorderThickness = 1
        Me.btn_confirm.ActiveCornerRadius = 20
        Me.btn_confirm.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_confirm.ActiveForecolor = System.Drawing.Color.White
        Me.btn_confirm.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_confirm.BackColor = System.Drawing.SystemColors.Control
        Me.btn_confirm.BackgroundImage = CType(resources.GetObject("btn_confirm.BackgroundImage"), System.Drawing.Image)
        Me.btn_confirm.ButtonText = "Confirm"
        Me.btn_confirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_confirm.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirm.ForeColor = System.Drawing.Color.Black
        Me.btn_confirm.IdleBorderThickness = 1
        Me.btn_confirm.IdleCornerRadius = 20
        Me.btn_confirm.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_confirm.IdleForecolor = System.Drawing.Color.Black
        Me.btn_confirm.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_confirm.Location = New System.Drawing.Point(779, 377)
        Me.btn_confirm.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(159, 48)
        Me.btn_confirm.TabIndex = 70
        Me.btn_confirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_subject
        '
        Me.txt_subject.BackColor = System.Drawing.Color.Transparent
        Me.txt_subject.BorderRadius = 3
        Me.txt_subject.DisabledColor = System.Drawing.Color.Gray
        Me.txt_subject.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subject.ForeColor = System.Drawing.Color.White
        Me.txt_subject.Items = New String(-1) {}
        Me.txt_subject.Location = New System.Drawing.Point(189, 69)
        Me.txt_subject.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_subject.Name = "txt_subject"
        Me.txt_subject.NomalColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_subject.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_subject.selectedIndex = -1
        Me.txt_subject.Size = New System.Drawing.Size(270, 30)
        Me.txt_subject.TabIndex = 2
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(189, 168)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(638, 105)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbl_greet)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1000, 38)
        Me.Panel2.TabIndex = 51
        '
        'lbl_greet
        '
        Me.lbl_greet.AutoSize = True
        Me.lbl_greet.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_greet.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_greet.ForeColor = System.Drawing.Color.Black
        Me.lbl_greet.Location = New System.Drawing.Point(831, 0)
        Me.lbl_greet.Name = "lbl_greet"
        Me.lbl_greet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_greet.Size = New System.Drawing.Size(169, 30)
        Me.lbl_greet.TabIndex = 11
        Me.lbl_greet.Text = "awdwadawd"
        Me.lbl_greet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_greet.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel5
        Me.BunifuDragControl1.Vertical = True
        '
        'frm_userAddtkt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_userAddtkt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CvSU Trouble Ticket"
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents btn_addtkt As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_mytkt As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_minimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_subject As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txt_subject As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents btn_dash As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents btn_confirm As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txt_pc As TextBox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txt_cl As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txt_cat As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_greet As Label
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents RichTextBox2 As RichTextBox
End Class
