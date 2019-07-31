<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_userdash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_userdash))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.tkt_dgv = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.lbl_newt = New System.Windows.Forms.Label()
        Me.BunifuImageButton5 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lbl_greet = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_mytkt = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_addtkt = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_dash = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_minimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.lbl_unread = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_cmp = New System.Windows.Forms.Label()
        Me.BunifuCards4 = New Bunifu.Framework.UI.BunifuCards()
        Me.lbl_inp = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        Me.lbl_pend = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tkt_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        Me.BunifuCards4.SuspendLayout()
        Me.BunifuCards3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.lbl_newt)
        Me.Panel2.Controls.Add(Me.BunifuImageButton5)
        Me.Panel2.Controls.Add(Me.lbl_greet)
        Me.BunifuTransition1.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1000, 111)
        Me.Panel2.TabIndex = 28
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel4.Controls.Add(Me.BunifuImageButton1)
        Me.Panel4.Controls.Add(Me.tkt_dgv)
        Me.BunifuTransition1.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(691, 111)
        Me.Panel4.TabIndex = 14
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.Image = Global.final.My.Resources.Resources.Close1
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(650, 6)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(35, 35)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuImageButton1.TabIndex = 27
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 20
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
        Me.tkt_dgv.Dock = System.Windows.Forms.DockStyle.Left
        Me.tkt_dgv.DoubleBuffered = True
        Me.tkt_dgv.EnableHeadersVisualStyles = False
        Me.tkt_dgv.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.tkt_dgv.HeaderForeColor = System.Drawing.Color.Honeydew
        Me.tkt_dgv.Location = New System.Drawing.Point(0, 0)
        Me.tkt_dgv.MultiSelect = False
        Me.tkt_dgv.Name = "tkt_dgv"
        Me.tkt_dgv.ReadOnly = True
        Me.tkt_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.tkt_dgv.RowHeadersVisible = False
        Me.tkt_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tkt_dgv.Size = New System.Drawing.Size(609, 111)
        Me.tkt_dgv.TabIndex = 26
        '
        'lbl_newt
        '
        Me.lbl_newt.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_newt, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_newt.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_newt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_newt.Location = New System.Drawing.Point(152, 42)
        Me.lbl_newt.Name = "lbl_newt"
        Me.lbl_newt.Size = New System.Drawing.Size(237, 22)
        Me.lbl_newt.TabIndex = 13
        Me.lbl_newt.Text = "0 New tickets completed"
        '
        'BunifuImageButton5
        '
        Me.BunifuImageButton5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuImageButton5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton5.Image = Global.final.My.Resources.Resources.Notification_48px
        Me.BunifuImageButton5.ImageActive = Nothing
        Me.BunifuImageButton5.Location = New System.Drawing.Point(74, 16)
        Me.BunifuImageButton5.Name = "BunifuImageButton5"
        Me.BunifuImageButton5.Size = New System.Drawing.Size(71, 71)
        Me.BunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton5.TabIndex = 12
        Me.BunifuImageButton5.TabStop = False
        Me.BunifuImageButton5.Zoom = 10
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_mytkt)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.btn_addtkt)
        Me.Panel1.Controls.Add(Me.btn_dash)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 94)
        Me.Panel1.TabIndex = 27
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
        Me.btn_mytkt.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_mytkt.IdleForecolor = System.Drawing.Color.White
        Me.btn_mytkt.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_mytkt.Location = New System.Drawing.Point(121, 67)
        Me.btn_mytkt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_mytkt.Name = "btn_mytkt"
        Me.btn_mytkt.Size = New System.Drawing.Size(115, 36)
        Me.btn_mytkt.TabIndex = 12
        Me.btn_mytkt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.Label1)
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
        Me.Label8.Location = New System.Drawing.Point(695, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 22)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Date"
        Me.Label8.Visible = False
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
        Me.btn_addtkt.Location = New System.Drawing.Point(242, 67)
        Me.btn_addtkt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_addtkt.Name = "btn_addtkt"
        Me.btn_addtkt.Size = New System.Drawing.Size(115, 36)
        Me.btn_addtkt.TabIndex = 3
        Me.btn_addtkt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btn_dash.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_dash.IdleForecolor = System.Drawing.Color.Black
        Me.btn_dash.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_dash.Location = New System.Drawing.Point(0, 67)
        Me.btn_dash.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_dash.Name = "btn_dash"
        Me.btn_dash.Size = New System.Drawing.Size(115, 36)
        Me.btn_dash.TabIndex = 2
        Me.btn_dash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BunifuImageButton2)
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
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton2.Image = Global.final.My.Resources.Resources.Account_50px
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(-5, 4)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(51, 37)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 12
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
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
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel5
        Me.BunifuDragControl1.Vertical = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.20408!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.65306!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.20408!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.65306!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.Controls.Add(Me.BunifuCards1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BunifuCards2, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BunifuCards4, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.BunifuCards3, 3, 3)
        Me.BunifuTransition1.SetDecoration(Me.TableLayoutPanel1, BunifuAnimatorNS.DecorationType.None)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 205)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.006654!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.93671!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.47515!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.244337!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1000, 395)
        Me.TableLayoutPanel1.TabIndex = 29
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.BunifuCards1.Controls.Add(Me.lbl_unread)
        Me.BunifuCards1.Controls.Add(Me.Label2)
        Me.BunifuTransition1.SetDecoration(Me.BunifuCards1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(105, 18)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(320, 132)
        Me.BunifuCards1.TabIndex = 18
        '
        'lbl_unread
        '
        Me.lbl_unread.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_unread, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_unread.Font = New System.Drawing.Font("Bookman Old Style", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_unread.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lbl_unread.Location = New System.Drawing.Point(139, 29)
        Me.lbl_unread.Name = "lbl_unread"
        Me.lbl_unread.Size = New System.Drawing.Size(43, 45)
        Me.lbl_unread.TabIndex = 9
        Me.lbl_unread.Text = "0"
        Me.lbl_unread.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(113, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 22)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Unread "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.White
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BunifuCards2.Controls.Add(Me.Label3)
        Me.BunifuCards2.Controls.Add(Me.lbl_cmp)
        Me.BunifuTransition1.SetDecoration(Me.BunifuCards2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCards2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(533, 18)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(320, 132)
        Me.BunifuCards2.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(113, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 22)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Completed"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_cmp
        '
        Me.lbl_cmp.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_cmp, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_cmp.Font = New System.Drawing.Font("Bookman Old Style", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cmp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.lbl_cmp.Location = New System.Drawing.Point(151, 29)
        Me.lbl_cmp.Name = "lbl_cmp"
        Me.lbl_cmp.Size = New System.Drawing.Size(43, 45)
        Me.lbl_cmp.TabIndex = 8
        Me.lbl_cmp.Text = "0"
        Me.lbl_cmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCards4
        '
        Me.BunifuCards4.BackColor = System.Drawing.Color.White
        Me.BunifuCards4.BorderRadius = 5
        Me.BunifuCards4.BottomSahddow = True
        Me.BunifuCards4.color = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.BunifuCards4.Controls.Add(Me.lbl_inp)
        Me.BunifuCards4.Controls.Add(Me.Label4)
        Me.BunifuTransition1.SetDecoration(Me.BunifuCards4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCards4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuCards4.LeftSahddow = False
        Me.BunifuCards4.Location = New System.Drawing.Point(105, 235)
        Me.BunifuCards4.Name = "BunifuCards4"
        Me.BunifuCards4.RightSahddow = True
        Me.BunifuCards4.ShadowDepth = 20
        Me.BunifuCards4.Size = New System.Drawing.Size(320, 138)
        Me.BunifuCards4.TabIndex = 21
        '
        'lbl_inp
        '
        Me.lbl_inp.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_inp, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_inp.Font = New System.Drawing.Font("Bookman Old Style", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lbl_inp.Location = New System.Drawing.Point(139, 40)
        Me.lbl_inp.Name = "lbl_inp"
        Me.lbl_inp.Size = New System.Drawing.Size(43, 45)
        Me.lbl_inp.TabIndex = 10
        Me.lbl_inp.Text = "0"
        Me.lbl_inp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(99, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 22)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "In progress"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCards3
        '
        Me.BunifuCards3.BackColor = System.Drawing.Color.White
        Me.BunifuCards3.BorderRadius = 5
        Me.BunifuCards3.BottomSahddow = True
        Me.BunifuCards3.color = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.BunifuCards3.Controls.Add(Me.lbl_pend)
        Me.BunifuCards3.Controls.Add(Me.Label5)
        Me.BunifuTransition1.SetDecoration(Me.BunifuCards3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCards3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuCards3.LeftSahddow = False
        Me.BunifuCards3.Location = New System.Drawing.Point(533, 235)
        Me.BunifuCards3.Name = "BunifuCards3"
        Me.BunifuCards3.RightSahddow = True
        Me.BunifuCards3.ShadowDepth = 20
        Me.BunifuCards3.Size = New System.Drawing.Size(320, 138)
        Me.BunifuCards3.TabIndex = 20
        '
        'lbl_pend
        '
        Me.lbl_pend.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_pend, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_pend.Font = New System.Drawing.Font("Bookman Old Style", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pend.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lbl_pend.Location = New System.Drawing.Point(151, 40)
        Me.lbl_pend.Name = "lbl_pend"
        Me.lbl_pend.Size = New System.Drawing.Size(43, 45)
        Me.lbl_pend.TabIndex = 11
        Me.lbl_pend.Text = "0"
        Me.lbl_pend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(132, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 22)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Pending"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'frm_userdash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_userdash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CvSU Trouble Ticket"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tkt_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards2.PerformLayout()
        Me.BunifuCards4.ResumeLayout(False)
        Me.BunifuCards4.PerformLayout()
        Me.BunifuCards3.ResumeLayout(False)
        Me.BunifuCards3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_greet As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_addtkt As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_dash As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_minimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_mytkt As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lbl_unread As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_cmp As Label
    Friend WithEvents BunifuCards4 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lbl_inp As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lbl_pend As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuImageButton5 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lbl_newt As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents tkt_dgv As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label8 As Label
End Class
