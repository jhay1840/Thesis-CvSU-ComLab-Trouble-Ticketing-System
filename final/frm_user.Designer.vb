<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_user
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_user))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_minimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_addtkt = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_mytkt = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_dash = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lbl_greet = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tkt_dgv = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btn_closes = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_prio = New System.Windows.Forms.Label()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lbl_cat = New System.Windows.Forms.Label()
        Me.lbl_ticket = New System.Windows.Forms.Label()
        Me.lbl_duedate = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.tkt_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.BunifuTransition1.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(89, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "CvSU Com-Lab Trouble Ticketing System"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.BunifuTransition1.SetDecoration(Me.Panel5, BunifuAnimatorNS.DecorationType.None)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(883, 60)
        Me.Panel5.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label8, BunifuAnimatorNS.DecorationType.None)
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(802, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 22)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Date"
        Me.Label8.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BunifuFlatButton1)
        Me.Panel3.Controls.Add(Me.btn_close)
        Me.Panel3.Controls.Add(Me.btn_minimize)
        Me.BunifuTransition1.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
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
        Me.BunifuTransition1.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
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
        Me.BunifuTransition1.SetDecoration(Me.btn_close, BunifuAnimatorNS.DecorationType.None)
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
        Me.BunifuTransition1.SetDecoration(Me.btn_minimize, BunifuAnimatorNS.DecorationType.None)
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
        Me.BunifuTransition1.SetDecoration(Me.btn_addtkt, BunifuAnimatorNS.DecorationType.None)
        Me.btn_addtkt.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addtkt.ForeColor = System.Drawing.Color.Black
        Me.btn_addtkt.IdleBorderThickness = 1
        Me.btn_addtkt.IdleCornerRadius = 10
        Me.btn_addtkt.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_addtkt.IdleForecolor = System.Drawing.Color.White
        Me.btn_addtkt.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_addtkt.Location = New System.Drawing.Point(239, 67)
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
        Me.BunifuTransition1.SetDecoration(Me.btn_mytkt, BunifuAnimatorNS.DecorationType.None)
        Me.btn_mytkt.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mytkt.ForeColor = System.Drawing.Color.Black
        Me.btn_mytkt.IdleBorderThickness = 1
        Me.btn_mytkt.IdleCornerRadius = 10
        Me.btn_mytkt.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_mytkt.IdleForecolor = System.Drawing.Color.Black
        Me.btn_mytkt.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_mytkt.Location = New System.Drawing.Point(118, 67)
        Me.btn_mytkt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_mytkt.Name = "btn_mytkt"
        Me.btn_mytkt.Size = New System.Drawing.Size(115, 36)
        Me.btn_mytkt.TabIndex = 2
        Me.btn_mytkt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_dash)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.btn_addtkt)
        Me.Panel1.Controls.Add(Me.btn_mytkt)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 94)
        Me.Panel1.TabIndex = 23
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
        Me.BunifuTransition1.SetDecoration(Me.btn_dash, BunifuAnimatorNS.DecorationType.None)
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
        Me.btn_dash.TabIndex = 14
        Me.btn_dash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_greet
        '
        Me.lbl_greet.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_greet, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_greet.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_greet.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_greet.ForeColor = System.Drawing.Color.Black
        Me.lbl_greet.Location = New System.Drawing.Point(919, 0)
        Me.lbl_greet.Name = "lbl_greet"
        Me.lbl_greet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_greet.Size = New System.Drawing.Size(81, 30)
        Me.lbl_greet.TabIndex = 11
        Me.lbl_greet.Text = "Greet"
        Me.lbl_greet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.Panel2.Controls.Add(Me.lbl_greet)
        Me.BunifuTransition1.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1000, 111)
        Me.Panel2.TabIndex = 24
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.BunifuMaterialTextbox1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox1.HintText = "Search"
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.CornflowerBlue
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue
        Me.BunifuMaterialTextbox1.LineThickness = 3
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(13, 71)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(379, 33)
        Me.BunifuMaterialTextbox1.TabIndex = 12
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tkt_dgv
        '
        Me.tkt_dgv.AllowUserToAddRows = False
        Me.tkt_dgv.AllowUserToDeleteRows = False
        Me.tkt_dgv.AllowUserToResizeColumns = False
        Me.tkt_dgv.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tkt_dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.tkt_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tkt_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.tkt_dgv.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.tkt_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tkt_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tkt_dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.tkt_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tkt_dgv.ColumnHeadersVisible = False
        Me.BunifuTransition1.SetDecoration(Me.tkt_dgv, BunifuAnimatorNS.DecorationType.None)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tkt_dgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.tkt_dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tkt_dgv.DoubleBuffered = True
        Me.tkt_dgv.EnableHeadersVisualStyles = False
        Me.tkt_dgv.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.tkt_dgv.HeaderForeColor = System.Drawing.Color.Honeydew
        Me.tkt_dgv.Location = New System.Drawing.Point(0, 233)
        Me.tkt_dgv.MultiSelect = False
        Me.tkt_dgv.Name = "tkt_dgv"
        Me.tkt_dgv.ReadOnly = True
        Me.tkt_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.tkt_dgv.RowHeadersVisible = False
        Me.tkt_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tkt_dgv.Size = New System.Drawing.Size(1000, 367)
        Me.tkt_dgv.TabIndex = 25
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.SeaGreen
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 0)
        Me.BunifuTransition1.SetDecoration(Me.TableLayoutPanel1, BunifuAnimatorNS.DecorationType.None)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 205)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1000, 28)
        Me.TableLayoutPanel1.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label10, BunifuAnimatorNS.DecorationType.None)
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(628, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 28)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "ComLab No."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label9, BunifuAnimatorNS.DecorationType.None)
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(503, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 28)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Category"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(878, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 28)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Due Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(753, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 28)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Date"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(128, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 28)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Subject"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 28)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Ticket ID"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(378, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 28)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Status"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label11, BunifuAnimatorNS.DecorationType.None)
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(253, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 28)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Priority"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel5
        Me.BunifuDragControl1.Vertical = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.btn_closes)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.RichTextBox1)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.BunifuTransition1.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.Panel4.Location = New System.Drawing.Point(0, 205)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1000, 66)
        Me.Panel4.TabIndex = 27
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label17, BunifuAnimatorNS.DecorationType.None)
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label17.Location = New System.Drawing.Point(133, 159)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 22)
        Me.Label17.TabIndex = 79
        Me.Label17.Text = "Closed by:"
        '
        'btn_closes
        '
        Me.btn_closes.ActiveBorderThickness = 1
        Me.btn_closes.ActiveCornerRadius = 20
        Me.btn_closes.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_closes.ActiveForecolor = System.Drawing.Color.White
        Me.btn_closes.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_closes.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_closes.BackgroundImage = CType(resources.GetObject("btn_closes.BackgroundImage"), System.Drawing.Image)
        Me.btn_closes.ButtonText = "Close"
        Me.btn_closes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btn_closes, BunifuAnimatorNS.DecorationType.None)
        Me.btn_closes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_closes.ForeColor = System.Drawing.Color.Black
        Me.btn_closes.IdleBorderThickness = 1
        Me.btn_closes.IdleCornerRadius = 20
        Me.btn_closes.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_closes.IdleForecolor = System.Drawing.Color.Black
        Me.btn_closes.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_closes.Location = New System.Drawing.Point(466, 332)
        Me.btn_closes.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_closes.Name = "btn_closes"
        Me.btn_closes.Size = New System.Drawing.Size(133, 38)
        Me.btn_closes.TabIndex = 78
        Me.btn_closes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label16, BunifuAnimatorNS.DecorationType.None)
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label16.Location = New System.Drawing.Point(398, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 22)
        Me.Label16.TabIndex = 77
        Me.Label16.Text = "Category"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label13, BunifuAnimatorNS.DecorationType.None)
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label13.Location = New System.Drawing.Point(97, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 22)
        Me.Label13.TabIndex = 76
        Me.Label13.Text = "Ticket ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(681, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 22)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Date Finished:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label12, BunifuAnimatorNS.DecorationType.None)
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label12.Location = New System.Drawing.Point(162, 191)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 22)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "Details:"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.RichTextBox1, BunifuAnimatorNS.DecorationType.None)
        Me.RichTextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.RichTextBox1.Location = New System.Drawing.Point(272, 191)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox1.Size = New System.Drawing.Size(572, 117)
        Me.RichTextBox1.TabIndex = 73
        Me.RichTextBox1.Text = "Details adbhaudgauyhdauhduyshaduyhadhaudahduah"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label14, BunifuAnimatorNS.DecorationType.None)
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label14.Location = New System.Drawing.Point(133, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 22)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "Action Taken:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label15, BunifuAnimatorNS.DecorationType.None)
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label15.Location = New System.Drawing.Point(97, 71)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(139, 22)
        Me.Label15.TabIndex = 71
        Me.Label15.Text = "Transaction ID"
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
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
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label18)
        Me.Panel6.Controls.Add(Me.RichTextBox3)
        Me.Panel6.Controls.Add(Me.lbl_date)
        Me.Panel6.Controls.Add(Me.lbl_prio)
        Me.Panel6.Controls.Add(Me.lbl_status)
        Me.Panel6.Controls.Add(Me.BunifuThinButton21)
        Me.Panel6.Controls.Add(Me.lbl_cat)
        Me.Panel6.Controls.Add(Me.lbl_ticket)
        Me.Panel6.Controls.Add(Me.lbl_duedate)
        Me.Panel6.Controls.Add(Me.Label22)
        Me.Panel6.Controls.Add(Me.RichTextBox2)
        Me.BunifuTransition1.SetDecoration(Me.Panel6, BunifuAnimatorNS.DecorationType.None)
        Me.Panel6.Location = New System.Drawing.Point(0, 205)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1000, 395)
        Me.Panel6.TabIndex = 80
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label18, BunifuAnimatorNS.DecorationType.None)
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label18.Location = New System.Drawing.Point(114, 275)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(118, 22)
        Me.Label18.TabIndex = 84
        Me.Label18.Text = "User Action:"
        '
        'RichTextBox3
        '
        Me.RichTextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.RichTextBox3, BunifuAnimatorNS.DecorationType.None)
        Me.RichTextBox3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox3.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.RichTextBox3.Location = New System.Drawing.Point(240, 282)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.ReadOnly = True
        Me.RichTextBox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox3.Size = New System.Drawing.Size(578, 49)
        Me.RichTextBox3.TabIndex = 83
        Me.RichTextBox3.Text = "Details adbhaudgauyhdauhduyshaduyhadhaudahduah"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_date, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_date.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_date.Location = New System.Drawing.Point(223, 93)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(149, 22)
        Me.lbl_date.TabIndex = 82
        Me.lbl_date.Text = "Date Created :"
        '
        'lbl_prio
        '
        Me.lbl_prio.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_prio, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_prio.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prio.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_prio.Location = New System.Drawing.Point(223, 124)
        Me.lbl_prio.Name = "lbl_prio"
        Me.lbl_prio.Size = New System.Drawing.Size(69, 22)
        Me.lbl_prio.TabIndex = 81
        Me.lbl_prio.Text = "Priority"
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_status, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_status.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_status.Location = New System.Drawing.Point(649, 124)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(70, 22)
        Me.lbl_status.TabIndex = 79
        Me.lbl_status.Text = "Status:"
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
        Me.BunifuThinButton21.ButtonText = "Close"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuThinButton21, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.Black
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuThinButton21.Location = New System.Drawing.Point(466, 343)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(133, 38)
        Me.BunifuThinButton21.TabIndex = 78
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_cat
        '
        Me.lbl_cat.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_cat, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_cat.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cat.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_cat.Location = New System.Drawing.Point(97, 59)
        Me.lbl_cat.Name = "lbl_cat"
        Me.lbl_cat.Size = New System.Drawing.Size(99, 22)
        Me.lbl_cat.TabIndex = 77
        Me.lbl_cat.Text = "Category"
        '
        'lbl_ticket
        '
        Me.lbl_ticket.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_ticket, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_ticket.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ticket.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_ticket.Location = New System.Drawing.Point(97, 28)
        Me.lbl_ticket.Name = "lbl_ticket"
        Me.lbl_ticket.Size = New System.Drawing.Size(86, 22)
        Me.lbl_ticket.TabIndex = 76
        Me.lbl_ticket.Text = "Ticket ID"
        '
        'lbl_duedate
        '
        Me.lbl_duedate.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_duedate, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_duedate.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_duedate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_duedate.Location = New System.Drawing.Point(649, 93)
        Me.lbl_duedate.Name = "lbl_duedate"
        Me.lbl_duedate.Size = New System.Drawing.Size(109, 22)
        Me.lbl_duedate.TabIndex = 75
        Me.lbl_duedate.Text = "Due Date :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label22, BunifuAnimatorNS.DecorationType.None)
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label22.Location = New System.Drawing.Point(130, 156)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(74, 22)
        Me.Label22.TabIndex = 74
        Me.Label22.Text = "Details:"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.RichTextBox2, BunifuAnimatorNS.DecorationType.None)
        Me.RichTextBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.RichTextBox2.Location = New System.Drawing.Point(240, 156)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox2.Size = New System.Drawing.Size(572, 117)
        Me.RichTextBox2.TabIndex = 73
        Me.RichTextBox2.Text = "Details adbhaudgauyhdauhduyshaduyhadhaudahduah"
        '
        'frm_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.tkt_dgv)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_user"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CvSU Trouble Ticket"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.tkt_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_minimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_addtkt As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_mytkt As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_greet As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tkt_dgv As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_dash As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_closes As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Label17 As Label
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_prio As Label
    Friend WithEvents lbl_status As Label
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lbl_cat As Label
    Friend WithEvents lbl_ticket As Label
    Friend WithEvents lbl_duedate As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents RichTextBox3 As RichTextBox
End Class
