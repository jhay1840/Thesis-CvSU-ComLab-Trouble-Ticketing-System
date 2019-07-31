<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.btn_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lbl_tktid = New System.Windows.Forms.Label()
        Me.lbl_subj = New System.Windows.Forms.Label()
        Me.txt_details = New System.Windows.Forms.RichTextBox()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.lbl_prio = New System.Windows.Forms.Label()
        Me.lbl_Date = New System.Windows.Forms.Label()
        Me.lbl_due = New System.Windows.Forms.Label()
        Me.btn_cmp = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_set = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.SystemdbDataSet1 = New final.systemdbDataSet()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.txtbox_pri = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_change = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuDatepicker1 = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.btn_setnow = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_details1 = New System.Windows.Forms.RichTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_markSave = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txt_at1 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.date_fin = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SystemdbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.Image = Global.final.My.Resources.Resources.Close1
        Me.btn_close.ImageActive = Nothing
        Me.btn_close.Location = New System.Drawing.Point(899, 12)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(35, 35)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_close.TabIndex = 10
        Me.btn_close.TabStop = False
        Me.btn_close.Zoom = 20
        '
        'lbl_tktid
        '
        Me.lbl_tktid.AutoSize = True
        Me.lbl_tktid.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tktid.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_tktid.Location = New System.Drawing.Point(51, 59)
        Me.lbl_tktid.Name = "lbl_tktid"
        Me.lbl_tktid.Size = New System.Drawing.Size(86, 22)
        Me.lbl_tktid.TabIndex = 11
        Me.lbl_tktid.Text = "Ticket ID"
        '
        'lbl_subj
        '
        Me.lbl_subj.AutoSize = True
        Me.lbl_subj.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subj.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_subj.Location = New System.Drawing.Point(87, 131)
        Me.lbl_subj.Name = "lbl_subj"
        Me.lbl_subj.Size = New System.Drawing.Size(83, 22)
        Me.lbl_subj.TabIndex = 12
        Me.lbl_subj.Text = "Subject:"
        '
        'txt_details
        '
        Me.txt_details.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txt_details.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_details.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.txt_details.Location = New System.Drawing.Point(187, 166)
        Me.txt_details.Name = "txt_details"
        Me.txt_details.ReadOnly = True
        Me.txt_details.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txt_details.Size = New System.Drawing.Size(600, 122)
        Me.txt_details.TabIndex = 13
        Me.txt_details.Text = "Details adbhaudgauyhdauhduyshaduyhadhaudahduah"
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_user.Location = New System.Drawing.Point(87, 103)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(64, 22)
        Me.lbl_user.TabIndex = 14
        Me.lbl_user.Text = "From: "
        '
        'lbl_prio
        '
        Me.lbl_prio.AutoSize = True
        Me.lbl_prio.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prio.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_prio.Location = New System.Drawing.Point(609, 103)
        Me.lbl_prio.Name = "lbl_prio"
        Me.lbl_prio.Size = New System.Drawing.Size(74, 22)
        Me.lbl_prio.TabIndex = 15
        Me.lbl_prio.Text = "Priority:"
        '
        'lbl_Date
        '
        Me.lbl_Date.AutoSize = True
        Me.lbl_Date.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Date.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_Date.Location = New System.Drawing.Point(609, 131)
        Me.lbl_Date.Name = "lbl_Date"
        Me.lbl_Date.Size = New System.Drawing.Size(61, 22)
        Me.lbl_Date.TabIndex = 16
        Me.lbl_Date.Text = "Date:"
        '
        'lbl_due
        '
        Me.lbl_due.AutoSize = True
        Me.lbl_due.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_due.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_due.Location = New System.Drawing.Point(579, 59)
        Me.lbl_due.Name = "lbl_due"
        Me.lbl_due.Size = New System.Drawing.Size(104, 22)
        Me.lbl_due.TabIndex = 17
        Me.lbl_due.Text = "Due Date:"
        '
        'btn_cmp
        '
        Me.btn_cmp.ActiveBorderThickness = 1
        Me.btn_cmp.ActiveCornerRadius = 20
        Me.btn_cmp.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_cmp.ActiveForecolor = System.Drawing.Color.White
        Me.btn_cmp.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_cmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_cmp.BackgroundImage = CType(resources.GetObject("btn_cmp.BackgroundImage"), System.Drawing.Image)
        Me.btn_cmp.ButtonText = "Mark as Complete"
        Me.btn_cmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cmp.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cmp.ForeColor = System.Drawing.Color.Black
        Me.btn_cmp.IdleBorderThickness = 1
        Me.btn_cmp.IdleCornerRadius = 20
        Me.btn_cmp.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_cmp.IdleForecolor = System.Drawing.Color.Black
        Me.btn_cmp.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_cmp.Location = New System.Drawing.Point(333, 400)
        Me.btn_cmp.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_cmp.Name = "btn_cmp"
        Me.btn_cmp.Size = New System.Drawing.Size(212, 45)
        Me.btn_cmp.TabIndex = 25
        Me.btn_cmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_set
        '
        Me.btn_set.ActiveBorderThickness = 1
        Me.btn_set.ActiveCornerRadius = 20
        Me.btn_set.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_set.ActiveForecolor = System.Drawing.Color.White
        Me.btn_set.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_set.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_set.BackgroundImage = CType(resources.GetObject("btn_set.BackgroundImage"), System.Drawing.Image)
        Me.btn_set.ButtonText = "Set Due Date"
        Me.btn_set.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_set.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_set.ForeColor = System.Drawing.Color.Black
        Me.btn_set.IdleBorderThickness = 1
        Me.btn_set.IdleCornerRadius = 20
        Me.btn_set.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_set.IdleForecolor = System.Drawing.Color.Black
        Me.btn_set.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_set.Location = New System.Drawing.Point(333, 362)
        Me.btn_set.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_set.Name = "btn_set"
        Me.btn_set.Size = New System.Drawing.Size(212, 45)
        Me.btn_set.TabIndex = 26
        Me.btn_set.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SystemdbDataSet1
        '
        Me.SystemdbDataSet1.DataSetName = "systemdbDataSet"
        Me.SystemdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'txtbox_pri
        '
        Me.txtbox_pri.BackColor = System.Drawing.Color.Transparent
        Me.txtbox_pri.BorderRadius = 3
        Me.txtbox_pri.DisabledColor = System.Drawing.Color.Gray
        Me.txtbox_pri.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_pri.ForeColor = System.Drawing.Color.White
        Me.txtbox_pri.Items = New String() {"Low", "High", "Urgent"}
        Me.txtbox_pri.Location = New System.Drawing.Point(681, 100)
        Me.txtbox_pri.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbox_pri.Name = "txtbox_pri"
        Me.txtbox_pri.NomalColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbox_pri.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbox_pri.selectedIndex = -1
        Me.txtbox_pri.Size = New System.Drawing.Size(129, 30)
        Me.txtbox_pri.TabIndex = 61
        Me.txtbox_pri.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(107, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 22)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Details:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(51, 468)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 22)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Transaction ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(87, 525)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 22)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Action Taken:"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.RichTextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.RichTextBox1.Location = New System.Drawing.Point(226, 603)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox1.Size = New System.Drawing.Size(572, 117)
        Me.RichTextBox1.TabIndex = 64
        Me.RichTextBox1.Text = "Details adbhaudgauyhdauhduyshaduyhadhaudahduah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(116, 603)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 22)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Details:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(635, 525)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 22)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Date Finished:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label13.Location = New System.Drawing.Point(431, 460)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 22)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "Completed"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(87, 564)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 22)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Closed by:"
        '
        'btn_change
        '
        Me.btn_change.ActiveBorderThickness = 1
        Me.btn_change.ActiveCornerRadius = 20
        Me.btn_change.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_change.ActiveForecolor = System.Drawing.Color.White
        Me.btn_change.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_change.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_change.BackgroundImage = CType(resources.GetObject("btn_change.BackgroundImage"), System.Drawing.Image)
        Me.btn_change.ButtonText = "Change"
        Me.btn_change.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_change.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_change.ForeColor = System.Drawing.Color.Black
        Me.btn_change.IdleBorderThickness = 1
        Me.btn_change.IdleCornerRadius = 20
        Me.btn_change.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_change.IdleForecolor = System.Drawing.Color.Black
        Me.btn_change.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_change.Location = New System.Drawing.Point(819, 94)
        Me.btn_change.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_change.Name = "btn_change"
        Me.btn_change.Size = New System.Drawing.Size(85, 38)
        Me.btn_change.TabIndex = 72
        Me.btn_change.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuDatepicker1
        '
        Me.BunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuDatepicker1.BorderRadius = 0
        Me.BunifuDatepicker1.ForeColor = System.Drawing.Color.White
        Me.BunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.BunifuDatepicker1.FormatCustom = Nothing
        Me.BunifuDatepicker1.Location = New System.Drawing.Point(134, 67)
        Me.BunifuDatepicker1.Name = "BunifuDatepicker1"
        Me.BunifuDatepicker1.Size = New System.Drawing.Size(303, 36)
        Me.BunifuDatepicker1.TabIndex = 27
        Me.BunifuDatepicker1.Value = New Date(2018, 11, 8, 17, 20, 8, 800)
        '
        'btn_setnow
        '
        Me.btn_setnow.ActiveBorderThickness = 1
        Me.btn_setnow.ActiveCornerRadius = 20
        Me.btn_setnow.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_setnow.ActiveForecolor = System.Drawing.Color.White
        Me.btn_setnow.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_setnow.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_setnow.BackgroundImage = CType(resources.GetObject("btn_setnow.BackgroundImage"), System.Drawing.Image)
        Me.btn_setnow.ButtonText = "Save"
        Me.btn_setnow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_setnow.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_setnow.ForeColor = System.Drawing.Color.White
        Me.btn_setnow.IdleBorderThickness = 1
        Me.btn_setnow.IdleCornerRadius = 20
        Me.btn_setnow.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_setnow.IdleForecolor = System.Drawing.Color.White
        Me.btn_setnow.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_setnow.Location = New System.Drawing.Point(172, 254)
        Me.btn_setnow.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_setnow.Name = "btn_setnow"
        Me.btn_setnow.Size = New System.Drawing.Size(212, 45)
        Me.btn_setnow.TabIndex = 28
        Me.btn_setnow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = Global.final.My.Resources.Resources.btn_close
        Me.BunifuImageButton1.ImageActive = Global.final.My.Resources.Resources.btn_close_active
        Me.BunifuImageButton1.Location = New System.Drawing.Point(523, 9)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(35, 32)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 30
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 30
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(451, 231)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 31
        Me.TextBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(234, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 22)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Set Date:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.BunifuImageButton1)
        Me.Panel1.Controls.Add(Me.btn_setnow)
        Me.Panel1.Controls.Add(Me.BunifuDatepicker1)
        Me.Panel1.Location = New System.Drawing.Point(177, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(564, 327)
        Me.Panel1.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(111, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 22)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Action Taken:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(341, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(177, 22)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Mark as Complete"
        '
        'txt_details1
        '
        Me.txt_details1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txt_details1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_details1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.txt_details1.Location = New System.Drawing.Point(183, 177)
        Me.txt_details1.Name = "txt_details1"
        Me.txt_details1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txt_details1.Size = New System.Drawing.Size(572, 117)
        Me.txt_details1.TabIndex = 66
        Me.txt_details1.Text = "Details adbhaudgauyhdauhduyshaduyhadhaudahduah"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(130, 142)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 22)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "Details:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label12.Location = New System.Drawing.Point(480, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(137, 22)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "Date Finished:"
        '
        'btn_markSave
        '
        Me.btn_markSave.ActiveBorderThickness = 1
        Me.btn_markSave.ActiveCornerRadius = 20
        Me.btn_markSave.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_markSave.ActiveForecolor = System.Drawing.Color.White
        Me.btn_markSave.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_markSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_markSave.BackgroundImage = CType(resources.GetObject("btn_markSave.BackgroundImage"), System.Drawing.Image)
        Me.btn_markSave.ButtonText = "Save"
        Me.btn_markSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_markSave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_markSave.ForeColor = System.Drawing.Color.Black
        Me.btn_markSave.IdleBorderThickness = 1
        Me.btn_markSave.IdleCornerRadius = 20
        Me.btn_markSave.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_markSave.IdleForecolor = System.Drawing.Color.Black
        Me.btn_markSave.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_markSave.Location = New System.Drawing.Point(385, 322)
        Me.btn_markSave.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_markSave.Name = "btn_markSave"
        Me.btn_markSave.Size = New System.Drawing.Size(133, 38)
        Me.btn_markSave.TabIndex = 69
        Me.btn_markSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_at1
        '
        Me.txt_at1.BackColor = System.Drawing.Color.Transparent
        Me.txt_at1.BorderRadius = 0
        Me.txt_at1.DisabledColor = System.Drawing.Color.Gray
        Me.txt_at1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_at1.ForeColor = System.Drawing.Color.White
        Me.txt_at1.Items = New String() {"Repair", "Replace", "Others"}
        Me.txt_at1.Location = New System.Drawing.Point(254, 90)
        Me.txt_at1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_at1.Name = "txt_at1"
        Me.txt_at1.NomalColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_at1.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_at1.selectedIndex = -1
        Me.txt_at1.Size = New System.Drawing.Size(169, 30)
        Me.txt_at1.TabIndex = 70
        '
        'date_fin
        '
        Me.date_fin.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.date_fin.BorderRadius = 0
        Me.date_fin.ForeColor = System.Drawing.Color.White
        Me.date_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.date_fin.FormatCustom = Nothing
        Me.date_fin.Location = New System.Drawing.Point(633, 90)
        Me.date_fin.Name = "date_fin"
        Me.date_fin.Size = New System.Drawing.Size(228, 31)
        Me.date_fin.TabIndex = 71
        Me.date_fin.Value = New Date(2018, 11, 21, 13, 57, 55, 356)
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(662, 149)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 72
        Me.TextBox2.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.date_fin)
        Me.Panel2.Controls.Add(Me.txt_at1)
        Me.Panel2.Controls.Add(Me.btn_markSave)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txt_details1)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(43, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(876, 395)
        Me.Panel2.TabIndex = 69
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.RichTextBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.RichTextBox2.Location = New System.Drawing.Point(187, 295)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox2.Size = New System.Drawing.Size(599, 49)
        Me.RichTextBox2.TabIndex = 73
        Me.RichTextBox2.Text = "Details adbhaudgauyhdauhduyshaduyhadhaudahduah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(63, 295)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 22)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "User Action:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(946, 732)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtbox_pri)
        Me.Controls.Add(Me.btn_set)
        Me.Controls.Add(Me.btn_cmp)
        Me.Controls.Add(Me.lbl_due)
        Me.Controls.Add(Me.lbl_Date)
        Me.Controls.Add(Me.lbl_prio)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.txt_details)
        Me.Controls.Add(Me.lbl_subj)
        Me.Controls.Add(Me.lbl_tktid)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_change)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CvSU Trouble Ticket"
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SystemdbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lbl_tktid As Label
    Friend WithEvents lbl_subj As Label
    Friend WithEvents txt_details As RichTextBox
    Friend WithEvents lbl_user As Label
    Friend WithEvents lbl_prio As Label
    Friend WithEvents lbl_Date As Label
    Friend WithEvents lbl_due As Label
    Friend WithEvents btn_cmp As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_set As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents SystemdbDataSet1 As systemdbDataSet
    Public WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents txtbox_pri As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_change As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents date_fin As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents txt_at1 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents btn_markSave As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_details1 As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_setnow As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuDatepicker1 As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Label2 As Label
End Class
