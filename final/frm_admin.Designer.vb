<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_admin
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_admin))
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tkt_dgv = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.btn_dashboard = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_accounts = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_reports = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_tickets = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_maximize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_minimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.TicketsTableAdapter = New final.systemdbDataSetTableAdapters.ticketsTableAdapter()
        Me.SystemdbDataSet = New final.systemdbDataSet()
        Me.TicketsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_clab = New System.Windows.Forms.Label()
        Me.btn_edit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtbox_cat = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btn_save2 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txt_addcat = New Bunifu.Framework.UI.BunifuDropdown()
        Me.label111 = New System.Windows.Forms.Label()
        Me.txt_addsub = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_save = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cl = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BunifuTransition2 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tkt_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_maximize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.SystemdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(51, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 22)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Total Computer Laboratories"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.BunifuTransition2.SetDecoration(Me.Panel5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel5, BunifuAnimatorNS.DecorationType.None)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(883, 60)
        Me.Panel5.TabIndex = 14
        '
        'PictureBox1
        '
        Me.BunifuTransition1.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
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
        Me.BunifuTransition2.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(89, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "CvSU Com-Lab Trouble Ticketing System"
        '
        'tkt_dgv
        '
        Me.tkt_dgv.AllowUserToAddRows = False
        Me.tkt_dgv.AllowUserToDeleteRows = False
        Me.tkt_dgv.AllowUserToResizeColumns = False
        Me.tkt_dgv.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BunifuTransition2.SetDecoration(Me.tkt_dgv, BunifuAnimatorNS.DecorationType.None)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tkt_dgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.tkt_dgv.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tkt_dgv.DoubleBuffered = True
        Me.tkt_dgv.EnableHeadersVisualStyles = False
        Me.tkt_dgv.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.tkt_dgv.HeaderForeColor = System.Drawing.Color.Honeydew
        Me.tkt_dgv.Location = New System.Drawing.Point(327, 376)
        Me.tkt_dgv.MultiSelect = False
        Me.tkt_dgv.Name = "tkt_dgv"
        Me.tkt_dgv.ReadOnly = True
        Me.tkt_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.tkt_dgv.RowHeadersVisible = False
        Me.tkt_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tkt_dgv.Size = New System.Drawing.Size(673, 224)
        Me.tkt_dgv.TabIndex = 41
        '
        'btn_dashboard
        '
        Me.btn_dashboard.ActiveBorderThickness = 1
        Me.btn_dashboard.ActiveCornerRadius = 10
        Me.btn_dashboard.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_dashboard.ActiveForecolor = System.Drawing.Color.Black
        Me.btn_dashboard.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_dashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_dashboard.BackgroundImage = CType(resources.GetObject("btn_dashboard.BackgroundImage"), System.Drawing.Image)
        Me.btn_dashboard.ButtonText = "Dashboard"
        Me.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition2.SetDecoration(Me.btn_dashboard, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn_dashboard, BunifuAnimatorNS.DecorationType.None)
        Me.btn_dashboard.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dashboard.ForeColor = System.Drawing.Color.Black
        Me.btn_dashboard.IdleBorderThickness = 1
        Me.btn_dashboard.IdleCornerRadius = 10
        Me.btn_dashboard.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_dashboard.IdleForecolor = System.Drawing.Color.White
        Me.btn_dashboard.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_dashboard.Location = New System.Drawing.Point(-5, 67)
        Me.btn_dashboard.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_dashboard.Name = "btn_dashboard"
        Me.btn_dashboard.Size = New System.Drawing.Size(115, 36)
        Me.btn_dashboard.TabIndex = 11
        Me.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_accounts
        '
        Me.btn_accounts.ActiveBorderThickness = 1
        Me.btn_accounts.ActiveCornerRadius = 10
        Me.btn_accounts.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_accounts.ActiveForecolor = System.Drawing.Color.Black
        Me.btn_accounts.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_accounts.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_accounts.BackgroundImage = CType(resources.GetObject("btn_accounts.BackgroundImage"), System.Drawing.Image)
        Me.btn_accounts.ButtonText = "Accounts"
        Me.btn_accounts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition2.SetDecoration(Me.btn_accounts, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn_accounts, BunifuAnimatorNS.DecorationType.None)
        Me.btn_accounts.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_accounts.ForeColor = System.Drawing.Color.Black
        Me.btn_accounts.IdleBorderThickness = 1
        Me.btn_accounts.IdleCornerRadius = 10
        Me.btn_accounts.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_accounts.IdleForecolor = System.Drawing.Color.White
        Me.btn_accounts.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_accounts.Location = New System.Drawing.Point(360, 67)
        Me.btn_accounts.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_accounts.Name = "btn_accounts"
        Me.btn_accounts.Size = New System.Drawing.Size(115, 36)
        Me.btn_accounts.TabIndex = 5
        Me.btn_accounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_reports
        '
        Me.btn_reports.ActiveBorderThickness = 1
        Me.btn_reports.ActiveCornerRadius = 10
        Me.btn_reports.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_reports.ActiveForecolor = System.Drawing.Color.Black
        Me.btn_reports.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_reports.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_reports.BackgroundImage = CType(resources.GetObject("btn_reports.BackgroundImage"), System.Drawing.Image)
        Me.btn_reports.ButtonText = "Reports"
        Me.btn_reports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition2.SetDecoration(Me.btn_reports, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn_reports, BunifuAnimatorNS.DecorationType.None)
        Me.btn_reports.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reports.ForeColor = System.Drawing.Color.Black
        Me.btn_reports.IdleBorderThickness = 1
        Me.btn_reports.IdleCornerRadius = 10
        Me.btn_reports.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_reports.IdleForecolor = System.Drawing.Color.White
        Me.btn_reports.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_reports.Location = New System.Drawing.Point(240, 67)
        Me.btn_reports.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_reports.Name = "btn_reports"
        Me.btn_reports.Size = New System.Drawing.Size(115, 36)
        Me.btn_reports.TabIndex = 4
        Me.btn_reports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_tickets
        '
        Me.btn_tickets.ActiveBorderThickness = 1
        Me.btn_tickets.ActiveCornerRadius = 10
        Me.btn_tickets.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_tickets.ActiveForecolor = System.Drawing.Color.Black
        Me.btn_tickets.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_tickets.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_tickets.BackgroundImage = CType(resources.GetObject("btn_tickets.BackgroundImage"), System.Drawing.Image)
        Me.btn_tickets.ButtonText = "Tickets"
        Me.btn_tickets.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition2.SetDecoration(Me.btn_tickets, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn_tickets, BunifuAnimatorNS.DecorationType.None)
        Me.btn_tickets.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tickets.ForeColor = System.Drawing.Color.Black
        Me.btn_tickets.IdleBorderThickness = 1
        Me.btn_tickets.IdleCornerRadius = 10
        Me.btn_tickets.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_tickets.IdleForecolor = System.Drawing.Color.White
        Me.btn_tickets.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_tickets.Location = New System.Drawing.Point(115, 67)
        Me.btn_tickets.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_tickets.Name = "btn_tickets"
        Me.btn_tickets.Size = New System.Drawing.Size(115, 36)
        Me.btn_tickets.TabIndex = 3
        Me.btn_tickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuTransition2.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1000, 43)
        Me.Panel2.TabIndex = 40
        '
        'btn_maximize
        '
        Me.btn_maximize.BackColor = System.Drawing.Color.Transparent
        Me.btn_maximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition2.SetDecoration(Me.btn_maximize, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn_maximize, BunifuAnimatorNS.DecorationType.None)
        Me.btn_maximize.Image = CType(resources.GetObject("btn_maximize.Image"), System.Drawing.Image)
        Me.btn_maximize.ImageActive = Nothing
        Me.btn_maximize.Location = New System.Drawing.Point(45, 3)
        Me.btn_maximize.Name = "btn_maximize"
        Me.btn_maximize.Size = New System.Drawing.Size(35, 35)
        Me.btn_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_maximize.TabIndex = 8
        Me.btn_maximize.TabStop = False
        Me.btn_maximize.Zoom = 20
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BunifuFlatButton1)
        Me.Panel3.Controls.Add(Me.btn_close)
        Me.Panel3.Controls.Add(Me.btn_minimize)
        Me.Panel3.Controls.Add(Me.btn_maximize)
        Me.BunifuTransition2.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
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
        Me.BunifuTransition2.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
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
        Me.BunifuTransition2.SetDecoration(Me.btn_close, BunifuAnimatorNS.DecorationType.None)
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
        Me.BunifuTransition2.SetDecoration(Me.btn_minimize, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn_minimize, BunifuAnimatorNS.DecorationType.None)
        Me.btn_minimize.Image = CType(resources.GetObject("btn_minimize.Image"), System.Drawing.Image)
        Me.btn_minimize.ImageActive = Nothing
        Me.btn_minimize.Location = New System.Drawing.Point(10, 3)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(35, 35)
        Me.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_minimize.TabIndex = 7
        Me.btn_minimize.TabStop = False
        Me.btn_minimize.Zoom = 20
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BunifuThinButton21)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.btn_dashboard)
        Me.Panel1.Controls.Add(Me.btn_accounts)
        Me.Panel1.Controls.Add(Me.btn_reports)
        Me.Panel1.Controls.Add(Me.btn_tickets)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.BunifuTransition2.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 94)
        Me.Panel1.TabIndex = 39
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 10
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Admin Settings"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition2.SetDecoration(Me.BunifuThinButton21, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuThinButton21, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.Black
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 10
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuThinButton21.Location = New System.Drawing.Point(481, 67)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(139, 36)
        Me.BunifuThinButton21.TabIndex = 15
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'TicketsTableAdapter
        '
        Me.TicketsTableAdapter.ClearBeforeFill = True
        '
        'SystemdbDataSet
        '
        Me.SystemdbDataSet.DataSetName = "systemdbDataSet"
        Me.SystemdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TicketsBindingSource1
        '
        Me.TicketsBindingSource1.DataMember = "tickets"
        Me.TicketsBindingSource1.DataSource = Me.SystemdbDataSet
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Tomato
        Me.BunifuCards1.Controls.Add(Me.Panel4)
        Me.BunifuCards1.Controls.Add(Me.Label2)
        Me.BunifuTransition2.SetDecoration(Me.BunifuCards1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuCards1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(375, 153)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(390, 174)
        Me.BunifuCards1.TabIndex = 43
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lbl_clab)
        Me.BunifuTransition2.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.Panel4.Location = New System.Drawing.Point(158, 75)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(142, 64)
        Me.Panel4.TabIndex = 40
        '
        'lbl_clab
        '
        Me.lbl_clab.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_clab, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.lbl_clab, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_clab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_clab.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_clab.Location = New System.Drawing.Point(0, 0)
        Me.lbl_clab.Name = "lbl_clab"
        Me.lbl_clab.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_clab.Size = New System.Drawing.Size(41, 44)
        Me.lbl_clab.TabIndex = 39
        Me.lbl_clab.Text = "0"
        Me.lbl_clab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_edit
        '
        Me.btn_edit.ActiveBorderThickness = 1
        Me.btn_edit.ActiveCornerRadius = 20
        Me.btn_edit.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_edit.ActiveForecolor = System.Drawing.Color.White
        Me.btn_edit.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_edit.BackColor = System.Drawing.SystemColors.Control
        Me.btn_edit.BackgroundImage = CType(resources.GetObject("btn_edit.BackgroundImage"), System.Drawing.Image)
        Me.btn_edit.ButtonText = "Edit ComLab"
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition2.SetDecoration(Me.btn_edit, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn_edit, BunifuAnimatorNS.DecorationType.None)
        Me.btn_edit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.Black
        Me.btn_edit.IdleBorderThickness = 1
        Me.btn_edit.IdleCornerRadius = 20
        Me.btn_edit.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_edit.IdleForecolor = System.Drawing.Color.Black
        Me.btn_edit.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_edit.Location = New System.Drawing.Point(773, 212)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(212, 45)
        Me.btn_edit.TabIndex = 44
        Me.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbox_cat
        '
        Me.txtbox_cat.BackColor = System.Drawing.Color.Transparent
        Me.txtbox_cat.BorderRadius = 3
        Me.BunifuTransition1.SetDecoration(Me.txtbox_cat, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.txtbox_cat, BunifuAnimatorNS.DecorationType.None)
        Me.txtbox_cat.DisabledColor = System.Drawing.Color.Gray
        Me.txtbox_cat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_cat.ForeColor = System.Drawing.Color.White
        Me.txtbox_cat.Items = New String() {"Hardware", "Software", "Network", "Others"}
        Me.txtbox_cat.Location = New System.Drawing.Point(509, 338)
        Me.txtbox_cat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbox_cat.Name = "txtbox_cat"
        Me.txtbox_cat.NomalColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbox_cat.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbox_cat.selectedIndex = -1
        Me.txtbox_cat.Size = New System.Drawing.Size(270, 30)
        Me.txtbox_cat.TabIndex = 60
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Add Subject"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition2.SetDecoration(Me.BunifuThinButton22, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuThinButton22, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.Black
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuThinButton22.Location = New System.Drawing.Point(795, 333)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(133, 38)
        Me.BunifuThinButton22.TabIndex = 61
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.btn_save2)
        Me.Panel6.Controls.Add(Me.txt_addcat)
        Me.Panel6.Controls.Add(Me.label111)
        Me.Panel6.Controls.Add(Me.txt_addsub)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.btn_save)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.txt_cl)
        Me.BunifuTransition2.SetDecoration(Me.Panel6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel6, BunifuAnimatorNS.DecorationType.None)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 137)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(327, 463)
        Me.Panel6.TabIndex = 64
        '
        'Panel7
        '
        Me.BunifuTransition2.SetDecoration(Me.Panel7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel7, BunifuAnimatorNS.DecorationType.None)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 237)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(327, 226)
        Me.Panel7.TabIndex = 69
        '
        'btn_save2
        '
        Me.btn_save2.ActiveBorderThickness = 1
        Me.btn_save2.ActiveCornerRadius = 20
        Me.btn_save2.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_save2.ActiveForecolor = System.Drawing.Color.White
        Me.btn_save2.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_save2.BackColor = System.Drawing.Color.White
        Me.btn_save2.BackgroundImage = CType(resources.GetObject("btn_save2.BackgroundImage"), System.Drawing.Image)
        Me.btn_save2.ButtonText = "Save"
        Me.btn_save2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition2.SetDecoration(Me.btn_save2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn_save2, BunifuAnimatorNS.DecorationType.None)
        Me.btn_save2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save2.ForeColor = System.Drawing.Color.Black
        Me.btn_save2.IdleBorderThickness = 1
        Me.btn_save2.IdleCornerRadius = 20
        Me.btn_save2.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_save2.IdleForecolor = System.Drawing.Color.Black
        Me.btn_save2.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_save2.Location = New System.Drawing.Point(112, 411)
        Me.btn_save2.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_save2.Name = "btn_save2"
        Me.btn_save2.Size = New System.Drawing.Size(133, 38)
        Me.btn_save2.TabIndex = 68
        Me.btn_save2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_save2.Visible = False
        '
        'txt_addcat
        '
        Me.txt_addcat.BackColor = System.Drawing.Color.Transparent
        Me.txt_addcat.BorderRadius = 3
        Me.BunifuTransition1.SetDecoration(Me.txt_addcat, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.txt_addcat, BunifuAnimatorNS.DecorationType.None)
        Me.txt_addcat.DisabledColor = System.Drawing.Color.Gray
        Me.txt_addcat.Enabled = False
        Me.txt_addcat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_addcat.ForeColor = System.Drawing.Color.White
        Me.txt_addcat.Items = New String() {"Hardware", "Software", "Network", "Others"}
        Me.txt_addcat.Location = New System.Drawing.Point(145, 351)
        Me.txt_addcat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_addcat.Name = "txt_addcat"
        Me.txt_addcat.NomalColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_addcat.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_addcat.selectedIndex = -1
        Me.txt_addcat.Size = New System.Drawing.Size(169, 30)
        Me.txt_addcat.TabIndex = 64
        '
        'label111
        '
        Me.label111.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.label111, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.label111, BunifuAnimatorNS.DecorationType.None)
        Me.label111.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label111.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label111.Location = New System.Drawing.Point(22, 351)
        Me.label111.Name = "label111"
        Me.label111.Size = New System.Drawing.Size(99, 22)
        Me.label111.TabIndex = 67
        Me.label111.Text = "Category"
        '
        'txt_addsub
        '
        Me.txt_addsub.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition2.SetDecoration(Me.txt_addsub, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.txt_addsub, BunifuAnimatorNS.DecorationType.None)
        Me.txt_addsub.Enabled = False
        Me.txt_addsub.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_addsub.ForeColor = System.Drawing.Color.Transparent
        Me.txt_addsub.HintForeColor = System.Drawing.Color.Empty
        Me.txt_addsub.HintText = ""
        Me.txt_addsub.isPassword = False
        Me.txt_addsub.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.txt_addsub.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_addsub.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.txt_addsub.LineThickness = 4
        Me.txt_addsub.Location = New System.Drawing.Point(139, 294)
        Me.txt_addsub.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_addsub.Name = "txt_addsub"
        Me.txt_addsub.Size = New System.Drawing.Size(175, 35)
        Me.txt_addsub.TabIndex = 66
        Me.txt_addsub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(10, 307)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 22)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Add subject"
        '
        'btn_save
        '
        Me.btn_save.ActiveBorderThickness = 1
        Me.btn_save.ActiveCornerRadius = 20
        Me.btn_save.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_save.ActiveForecolor = System.Drawing.Color.White
        Me.btn_save.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_save.BackColor = System.Drawing.Color.White
        Me.btn_save.BackgroundImage = CType(resources.GetObject("btn_save.BackgroundImage"), System.Drawing.Image)
        Me.btn_save.ButtonText = "Save"
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition2.SetDecoration(Me.btn_save, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn_save, BunifuAnimatorNS.DecorationType.None)
        Me.btn_save.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.IdleBorderThickness = 1
        Me.btn_save.IdleCornerRadius = 20
        Me.btn_save.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_save.IdleForecolor = System.Drawing.Color.Black
        Me.btn_save.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_save.Location = New System.Drawing.Point(112, 184)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(133, 38)
        Me.btn_save.TabIndex = 64
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_save.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(1, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(326, 22)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Please specify number of Com Lab"
        '
        'txt_cl
        '
        Me.txt_cl.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition2.SetDecoration(Me.txt_cl, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.txt_cl, BunifuAnimatorNS.DecorationType.None)
        Me.txt_cl.Enabled = False
        Me.txt_cl.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cl.ForeColor = System.Drawing.Color.Transparent
        Me.txt_cl.HintForeColor = System.Drawing.Color.Empty
        Me.txt_cl.HintText = ""
        Me.txt_cl.isPassword = False
        Me.txt_cl.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.txt_cl.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_cl.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.txt_cl.LineThickness = 4
        Me.txt_cl.Location = New System.Drawing.Point(79, 140)
        Me.txt_cl.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cl.Name = "txt_cl"
        Me.txt_cl.Size = New System.Drawing.Size(196, 35)
        Me.txt_cl.TabIndex = 62
        Me.txt_cl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(403, 341)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 22)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Category"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(769, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(216, 17)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "? Double click to remove a subject"
        '
        'BunifuTransition2
        '
        Me.BunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.Transparent
        Me.BunifuTransition2.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 1.0!
        Me.BunifuTransition2.DefaultAnimation = Animation2
        '
        'frm_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tkt_dgv)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.BunifuThinButton22)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbox_cat)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CvSU Trouble Ticket"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tkt_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_maximize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.SystemdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tkt_dgv As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents btn_dashboard As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_accounts As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_reports As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_tickets As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_maximize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_minimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents TicketsTableAdapter As systemdbDataSetTableAdapters.ticketsTableAdapter
    Friend WithEvents SystemdbDataSet As systemdbDataSet
    Friend WithEvents TicketsBindingSource1 As BindingSource
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lbl_clab As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btn_edit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtbox_cat As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btn_save2 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txt_addcat As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents label111 As Label
    Friend WithEvents txt_addsub As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_save As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cl As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuTransition2 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
End Class
