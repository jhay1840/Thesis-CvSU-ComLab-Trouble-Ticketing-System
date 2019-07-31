<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_tickets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tickets))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_dashboard = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_accounts = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_reports = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_tickets = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_minimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_maximize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btn_solved = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_new = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_duetoday = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_all = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.SystemdbDataSet = New final.systemdbDataSet()
        Me.TicketsTableAdapter = New final.systemdbDataSetTableAdapters.ticketsTableAdapter()
        Me.TicketsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tkt_dgv = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_maximize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.SystemdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.tkt_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 94)
        Me.Panel1.TabIndex = 16
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
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 10
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BunifuThinButton21.Location = New System.Drawing.Point(481, 67)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(139, 36)
        Me.BunifuThinButton21.TabIndex = 17
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(883, 60)
        Me.Panel5.TabIndex = 14
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(89, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "CvSU Com-Lab Trouble Ticketing System"
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
        Me.btn_reports.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reports.ForeColor = System.Drawing.Color.Black
        Me.btn_reports.IdleBorderThickness = 1
        Me.btn_reports.IdleCornerRadius = 10
        Me.btn_reports.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_reports.IdleForecolor = System.Drawing.Color.White
        Me.btn_reports.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
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
        Me.btn_tickets.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tickets.ForeColor = System.Drawing.Color.Black
        Me.btn_tickets.IdleBorderThickness = 1
        Me.btn_tickets.IdleCornerRadius = 10
        Me.btn_tickets.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_tickets.IdleForecolor = System.Drawing.Color.Black
        Me.btn_tickets.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_tickets.Location = New System.Drawing.Point(115, 67)
        Me.btn_tickets.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_tickets.Name = "btn_tickets"
        Me.btn_tickets.Size = New System.Drawing.Size(115, 36)
        Me.btn_tickets.TabIndex = 3
        Me.btn_tickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BunifuFlatButton1)
        Me.Panel3.Controls.Add(Me.btn_close)
        Me.Panel3.Controls.Add(Me.btn_minimize)
        Me.Panel3.Controls.Add(Me.btn_maximize)
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
        Me.btn_minimize.Location = New System.Drawing.Point(10, 3)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(35, 35)
        Me.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_minimize.TabIndex = 7
        Me.btn_minimize.TabStop = False
        Me.btn_minimize.Zoom = 20
        '
        'btn_maximize
        '
        Me.btn_maximize.BackColor = System.Drawing.Color.Transparent
        Me.btn_maximize.Cursor = System.Windows.Forms.Cursors.Hand
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.Panel2.Controls.Add(Me.btn_solved)
        Me.Panel2.Controls.Add(Me.btn_new)
        Me.Panel2.Controls.Add(Me.btn_duetoday)
        Me.Panel2.Controls.Add(Me.btn_all)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1000, 43)
        Me.Panel2.TabIndex = 17
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox1.HintText = "Search"
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.CornflowerBlue
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue
        Me.BunifuMaterialTextbox1.LineThickness = 3
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(608, 6)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(379, 33)
        Me.BunifuMaterialTextbox1.TabIndex = 4
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_solved
        '
        Me.btn_solved.Activecolor = System.Drawing.Color.LimeGreen
        Me.btn_solved.BackColor = System.Drawing.Color.Transparent
        Me.btn_solved.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_solved.BorderRadius = 0
        Me.btn_solved.ButtonText = "Pending Tickets"
        Me.btn_solved.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_solved.DisabledColor = System.Drawing.Color.Gray
        Me.btn_solved.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_solved.ForeColor = System.Drawing.Color.Black
        Me.btn_solved.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_solved.Iconimage = Nothing
        Me.btn_solved.Iconimage_right = Nothing
        Me.btn_solved.Iconimage_right_Selected = Nothing
        Me.btn_solved.Iconimage_Selected = Nothing
        Me.btn_solved.IconMarginLeft = 0
        Me.btn_solved.IconMarginRight = 0
        Me.btn_solved.IconRightVisible = True
        Me.btn_solved.IconRightZoom = 0R
        Me.btn_solved.IconVisible = True
        Me.btn_solved.IconZoom = 90.0R
        Me.btn_solved.IsTab = False
        Me.btn_solved.Location = New System.Drawing.Point(286, 0)
        Me.btn_solved.Name = "btn_solved"
        Me.btn_solved.Normalcolor = System.Drawing.Color.Transparent
        Me.btn_solved.OnHovercolor = System.Drawing.Color.LimeGreen
        Me.btn_solved.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_solved.selected = False
        Me.btn_solved.Size = New System.Drawing.Size(120, 43)
        Me.btn_solved.TabIndex = 3
        Me.btn_solved.Text = "Pending Tickets"
        Me.btn_solved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_solved.Textcolor = System.Drawing.Color.Black
        Me.btn_solved.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_new
        '
        Me.btn_new.Activecolor = System.Drawing.Color.LimeGreen
        Me.btn_new.BackColor = System.Drawing.Color.Transparent
        Me.btn_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_new.BorderRadius = 0
        Me.btn_new.ButtonText = "New Tickets"
        Me.btn_new.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new.DisabledColor = System.Drawing.Color.Gray
        Me.btn_new.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_new.ForeColor = System.Drawing.Color.Black
        Me.btn_new.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_new.Iconimage = Nothing
        Me.btn_new.Iconimage_right = Nothing
        Me.btn_new.Iconimage_right_Selected = Nothing
        Me.btn_new.Iconimage_Selected = Nothing
        Me.btn_new.IconMarginLeft = 0
        Me.btn_new.IconMarginRight = 0
        Me.btn_new.IconRightVisible = True
        Me.btn_new.IconRightZoom = 0R
        Me.btn_new.IconVisible = True
        Me.btn_new.IconZoom = 90.0R
        Me.btn_new.IsTab = False
        Me.btn_new.Location = New System.Drawing.Point(181, 0)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Normalcolor = System.Drawing.Color.Transparent
        Me.btn_new.OnHovercolor = System.Drawing.Color.LimeGreen
        Me.btn_new.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_new.selected = False
        Me.btn_new.Size = New System.Drawing.Size(105, 43)
        Me.btn_new.TabIndex = 2
        Me.btn_new.Text = "New Tickets"
        Me.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_new.Textcolor = System.Drawing.Color.Black
        Me.btn_new.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_duetoday
        '
        Me.btn_duetoday.Activecolor = System.Drawing.Color.LimeGreen
        Me.btn_duetoday.BackColor = System.Drawing.Color.Transparent
        Me.btn_duetoday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_duetoday.BorderRadius = 0
        Me.btn_duetoday.ButtonText = "Due Today"
        Me.btn_duetoday.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_duetoday.DisabledColor = System.Drawing.Color.Gray
        Me.btn_duetoday.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_duetoday.ForeColor = System.Drawing.Color.Black
        Me.btn_duetoday.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_duetoday.Iconimage = Nothing
        Me.btn_duetoday.Iconimage_right = Nothing
        Me.btn_duetoday.Iconimage_right_Selected = Nothing
        Me.btn_duetoday.Iconimage_Selected = Nothing
        Me.btn_duetoday.IconMarginLeft = 0
        Me.btn_duetoday.IconMarginRight = 0
        Me.btn_duetoday.IconRightVisible = True
        Me.btn_duetoday.IconRightZoom = 0R
        Me.btn_duetoday.IconVisible = True
        Me.btn_duetoday.IconZoom = 90.0R
        Me.btn_duetoday.IsTab = False
        Me.btn_duetoday.Location = New System.Drawing.Point(76, 0)
        Me.btn_duetoday.Name = "btn_duetoday"
        Me.btn_duetoday.Normalcolor = System.Drawing.Color.Transparent
        Me.btn_duetoday.OnHovercolor = System.Drawing.Color.LimeGreen
        Me.btn_duetoday.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_duetoday.selected = False
        Me.btn_duetoday.Size = New System.Drawing.Size(105, 43)
        Me.btn_duetoday.TabIndex = 1
        Me.btn_duetoday.Text = "Due Today"
        Me.btn_duetoday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_duetoday.Textcolor = System.Drawing.Color.Black
        Me.btn_duetoday.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_all
        '
        Me.btn_all.Activecolor = System.Drawing.Color.LimeGreen
        Me.btn_all.BackColor = System.Drawing.Color.Transparent
        Me.btn_all.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_all.BorderRadius = 0
        Me.btn_all.ButtonText = "All"
        Me.btn_all.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_all.DisabledColor = System.Drawing.Color.Gray
        Me.btn_all.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_all.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_all.ForeColor = System.Drawing.Color.Black
        Me.btn_all.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_all.Iconimage = Nothing
        Me.btn_all.Iconimage_right = Nothing
        Me.btn_all.Iconimage_right_Selected = Nothing
        Me.btn_all.Iconimage_Selected = Nothing
        Me.btn_all.IconMarginLeft = 0
        Me.btn_all.IconMarginRight = 0
        Me.btn_all.IconRightVisible = True
        Me.btn_all.IconRightZoom = 0R
        Me.btn_all.IconVisible = True
        Me.btn_all.IconZoom = 90.0R
        Me.btn_all.IsTab = False
        Me.btn_all.Location = New System.Drawing.Point(0, 0)
        Me.btn_all.Name = "btn_all"
        Me.btn_all.Normalcolor = System.Drawing.Color.Transparent
        Me.btn_all.OnHovercolor = System.Drawing.Color.LimeGreen
        Me.btn_all.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_all.selected = False
        Me.btn_all.Size = New System.Drawing.Size(76, 43)
        Me.btn_all.TabIndex = 0
        Me.btn_all.Text = "All"
        Me.btn_all.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_all.Textcolor = System.Drawing.Color.Black
        Me.btn_all.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'SystemdbDataSet
        '
        Me.SystemdbDataSet.DataSetName = "systemdbDataSet"
        Me.SystemdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TicketsTableAdapter
        '
        Me.TicketsTableAdapter.ClearBeforeFill = True
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.SeaGreen
        Me.TableLayoutPanel1.ColumnCount = 9
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 137)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1000, 38)
        Me.TableLayoutPanel1.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(669, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 38)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "ComLab No."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(558, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 38)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Category"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(891, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 38)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Due Date"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(780, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 38)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Date"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(447, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 38)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Status"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(114, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 38)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Reported By:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 38)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Ticket ID"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(336, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 38)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Priority"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(225, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 38)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Subject"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.tkt_dgv.ColumnHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.tkt_dgv.Location = New System.Drawing.Point(0, 175)
        Me.tkt_dgv.MultiSelect = False
        Me.tkt_dgv.Name = "tkt_dgv"
        Me.tkt_dgv.ReadOnly = True
        Me.tkt_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.tkt_dgv.RowHeadersVisible = False
        Me.tkt_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tkt_dgv.Size = New System.Drawing.Size(1000, 425)
        Me.tkt_dgv.TabIndex = 20
        '
        'frm_tickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.tkt_dgv)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_tickets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CvSU Trouble Ticket"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_maximize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.SystemdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.tkt_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_accounts As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_reports As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_tickets As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_minimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_maximize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents btn_all As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_dashboard As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_duetoday As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_solved As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_new As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents SystemdbDataSet As systemdbDataSet
    Friend WithEvents TicketsTableAdapter As systemdbDataSetTableAdapters.ticketsTableAdapter
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TicketsBindingSource1 As BindingSource
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tkt_dgv As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
End Class
