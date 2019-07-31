<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TicketsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SystemdbDataSet = New final.systemdbDataSet()
        Me.TicketsTableAdapter = New final.systemdbDataSetTableAdapters.ticketsTableAdapter()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
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
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_minimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_maximize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuCircleProgressbar1 = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_ann = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_mont = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.tkt_dgv = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.btn_export = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.TicketsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SystemdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_maximize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.tkt_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(32, 337)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 22)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Pending tickets:"
        '
        'TicketsBindingSource1
        '
        Me.TicketsBindingSource1.DataMember = "tickets"
        Me.TicketsBindingSource1.DataSource = Me.SystemdbDataSet
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
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
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
        Me.Panel1.TabIndex = 51
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
        Me.BunifuThinButton21.TabIndex = 18
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
        Me.btn_reports.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_reports.IdleForecolor = System.Drawing.Color.Black
        Me.btn_reports.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BunifuFlatButton3)
        Me.Panel3.Controls.Add(Me.btn_close)
        Me.Panel3.Controls.Add(Me.btn_minimize)
        Me.Panel3.Controls.Add(Me.btn_maximize)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(883, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(117, 94)
        Me.Panel3.TabIndex = 10
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "Log Out"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = CType(resources.GetObject("BunifuFlatButton3.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 70.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(0, 59)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(117, 35)
        Me.BunifuFlatButton3.TabIndex = 13
        Me.BunifuFlatButton3.Text = "Log Out"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(32, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 22)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Total tasks:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(32, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 22)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Total tasks completed:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(673, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 22)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Total tasks Completed"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(101, 174)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(32, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 22)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "From"
        '
        'BunifuCircleProgressbar1
        '
        Me.BunifuCircleProgressbar1.animated = False
        Me.BunifuCircleProgressbar1.animationIterval = 5
        Me.BunifuCircleProgressbar1.animationSpeed = 300
        Me.BunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCircleProgressbar1.BackgroundImage = CType(resources.GetObject("BunifuCircleProgressbar1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuCircleProgressbar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.BunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuCircleProgressbar1.LabelVisible = True
        Me.BunifuCircleProgressbar1.LineProgressThickness = 8
        Me.BunifuCircleProgressbar1.LineThickness = 5
        Me.BunifuCircleProgressbar1.Location = New System.Drawing.Point(439, 137)
        Me.BunifuCircleProgressbar1.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.BunifuCircleProgressbar1.MaxValue = 100
        Me.BunifuCircleProgressbar1.Name = "BunifuCircleProgressbar1"
        Me.BunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.BunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen
        Me.BunifuCircleProgressbar1.Size = New System.Drawing.Size(201, 201)
        Me.BunifuCircleProgressbar1.TabIndex = 54
        Me.BunifuCircleProgressbar1.Value = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(342, 143)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 56
        Me.TextBox1.Visible = False
        '
        'btn_ann
        '
        Me.btn_ann.Activecolor = System.Drawing.Color.LimeGreen
        Me.btn_ann.BackColor = System.Drawing.Color.Transparent
        Me.btn_ann.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ann.BorderRadius = 0
        Me.btn_ann.ButtonText = "Annual Report"
        Me.btn_ann.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ann.DisabledColor = System.Drawing.Color.Gray
        Me.btn_ann.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_ann.ForeColor = System.Drawing.Color.Black
        Me.btn_ann.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_ann.Iconimage = Nothing
        Me.btn_ann.Iconimage_right = Nothing
        Me.btn_ann.Iconimage_right_Selected = Nothing
        Me.btn_ann.Iconimage_Selected = Nothing
        Me.btn_ann.IconMarginLeft = 0
        Me.btn_ann.IconMarginRight = 0
        Me.btn_ann.IconRightVisible = True
        Me.btn_ann.IconRightZoom = 0R
        Me.btn_ann.IconVisible = True
        Me.btn_ann.IconZoom = 90.0R
        Me.btn_ann.IsTab = False
        Me.btn_ann.Location = New System.Drawing.Point(175, 0)
        Me.btn_ann.Name = "btn_ann"
        Me.btn_ann.Normalcolor = System.Drawing.Color.Transparent
        Me.btn_ann.OnHovercolor = System.Drawing.Color.LimeGreen
        Me.btn_ann.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_ann.selected = False
        Me.btn_ann.Size = New System.Drawing.Size(144, 43)
        Me.btn_ann.TabIndex = 1
        Me.btn_ann.Text = "Annual Report"
        Me.btn_ann.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_ann.Textcolor = System.Drawing.Color.Black
        Me.btn_ann.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BunifuFlatButton2)
        Me.Panel2.Controls.Add(Me.BunifuFlatButton1)
        Me.Panel2.Controls.Add(Me.btn_ann)
        Me.Panel2.Controls.Add(Me.btn_mont)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1000, 43)
        Me.Panel2.TabIndex = 52
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.LimeGreen
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Action Taken log"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuFlatButton2.ForeColor = System.Drawing.Color.Black
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Nothing
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 90.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(463, 0)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.LimeGreen
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(144, 43)
        Me.BunifuFlatButton2.TabIndex = 5
        Me.BunifuFlatButton2.Text = "Action Taken log"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.LimeGreen
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.LimeGreen
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Specific Date"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuFlatButton1.ForeColor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(319, 0)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.LimeGreen
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.LimeGreen
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(144, 43)
        Me.BunifuFlatButton1.TabIndex = 2
        Me.BunifuFlatButton1.Text = "Specific Date"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_mont
        '
        Me.btn_mont.Activecolor = System.Drawing.Color.LimeGreen
        Me.btn_mont.BackColor = System.Drawing.Color.Transparent
        Me.btn_mont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_mont.BorderRadius = 0
        Me.btn_mont.ButtonText = "Monthly Report"
        Me.btn_mont.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mont.DisabledColor = System.Drawing.Color.Gray
        Me.btn_mont.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_mont.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mont.ForeColor = System.Drawing.Color.Black
        Me.btn_mont.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_mont.Iconimage = Nothing
        Me.btn_mont.Iconimage_right = Nothing
        Me.btn_mont.Iconimage_right_Selected = Nothing
        Me.btn_mont.Iconimage_Selected = Nothing
        Me.btn_mont.IconMarginLeft = 0
        Me.btn_mont.IconMarginRight = 0
        Me.btn_mont.IconRightVisible = True
        Me.btn_mont.IconRightZoom = 0R
        Me.btn_mont.IconVisible = True
        Me.btn_mont.IconZoom = 90.0R
        Me.btn_mont.IsTab = False
        Me.btn_mont.Location = New System.Drawing.Point(0, 0)
        Me.btn_mont.Name = "btn_mont"
        Me.btn_mont.Normalcolor = System.Drawing.Color.Transparent
        Me.btn_mont.OnHovercolor = System.Drawing.Color.LimeGreen
        Me.btn_mont.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_mont.selected = False
        Me.btn_mont.Size = New System.Drawing.Size(175, 43)
        Me.btn_mont.TabIndex = 0
        Me.btn_mont.Text = "Monthly Report"
        Me.btn_mont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_mont.Textcolor = System.Drawing.Color.Black
        Me.btn_mont.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(32, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 22)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "To"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(101, 219)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 62
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(748, 152)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 63
        Me.TextBox2.Visible = False
        '
        'tkt_dgv
        '
        Me.tkt_dgv.AllowUserToAddRows = False
        Me.tkt_dgv.AllowUserToDeleteRows = False
        Me.tkt_dgv.AllowUserToResizeColumns = False
        Me.tkt_dgv.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tkt_dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.tkt_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.tkt_dgv.Location = New System.Drawing.Point(0, 376)
        Me.tkt_dgv.MultiSelect = False
        Me.tkt_dgv.Name = "tkt_dgv"
        Me.tkt_dgv.ReadOnly = True
        Me.tkt_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.tkt_dgv.RowHeadersVisible = False
        Me.tkt_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tkt_dgv.Size = New System.Drawing.Size(1000, 224)
        Me.tkt_dgv.TabIndex = 64
        '
        'btn_export
        '
        Me.btn_export.ActiveBorderThickness = 1
        Me.btn_export.ActiveCornerRadius = 20
        Me.btn_export.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_export.ActiveForecolor = System.Drawing.Color.White
        Me.btn_export.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_export.BackColor = System.Drawing.SystemColors.Control
        Me.btn_export.BackgroundImage = CType(resources.GetObject("btn_export.BackgroundImage"), System.Drawing.Image)
        Me.btn_export.ButtonText = "Export File"
        Me.btn_export.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_export.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_export.ForeColor = System.Drawing.Color.Black
        Me.btn_export.IdleBorderThickness = 1
        Me.btn_export.IdleCornerRadius = 20
        Me.btn_export.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_export.IdleForecolor = System.Drawing.Color.Black
        Me.btn_export.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_export.Location = New System.Drawing.Point(677, 300)
        Me.btn_export.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(175, 47)
        Me.btn_export.TabIndex = 40
        Me.btn_export.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.btn_export)
        Me.Controls.Add(Me.tkt_dgv)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BunifuCircleProgressbar1)
        Me.Controls.Add(Me.TextBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form5"
        Me.Text = "CvSU Trouble Ticket"
        CType(Me.TicketsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SystemdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_maximize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.tkt_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents TicketsBindingSource1 As BindingSource
    Friend WithEvents SystemdbDataSet As systemdbDataSet
    Friend WithEvents TicketsTableAdapter As systemdbDataSetTableAdapters.ticketsTableAdapter
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_dashboard As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_accounts As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_reports As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_tickets As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_minimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_maximize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuCircleProgressbar1 As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_ann As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_mont As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents tkt_dgv As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents btn_export As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
