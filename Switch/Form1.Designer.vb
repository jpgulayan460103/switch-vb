<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim Panel1 As System.Windows.Forms.Panel
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.onpb = New System.Windows.Forms.PictureBox()
        Me.offpb = New System.Windows.Forms.PictureBox()
        Me.header_pnl = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Panel1 = New System.Windows.Forms.Panel()
        Panel1.SuspendLayout()
        CType(Me.onpb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.offpb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.header_pnl.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Panel1.Controls.Add(Me.onpb)
        Panel1.Controls.Add(Me.offpb)
        Panel1.Location = New System.Drawing.Point(12, 92)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(499, 563)
        Panel1.TabIndex = 2
        '
        'onpb
        '
        Me.onpb.BackgroundImage = Global.Switch.My.Resources.Resources.Untitled_1
        Me.onpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.onpb.Image = Global.Switch.My.Resources.Resources.Untitled_1
        Me.onpb.Location = New System.Drawing.Point(78, 343)
        Me.onpb.Name = "onpb"
        Me.onpb.Size = New System.Drawing.Size(338, 219)
        Me.onpb.TabIndex = 1
        Me.onpb.TabStop = False
        '
        'offpb
        '
        Me.offpb.BackgroundImage = Global.Switch.My.Resources.Resources.off1
        Me.offpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.offpb.Image = Global.Switch.My.Resources.Resources.off1
        Me.offpb.Location = New System.Drawing.Point(77, 344)
        Me.offpb.Name = "offpb"
        Me.offpb.Size = New System.Drawing.Size(338, 219)
        Me.offpb.TabIndex = 0
        Me.offpb.TabStop = False
        '
        'header_pnl
        '
        Me.header_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.header_pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.header_pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.header_pnl.Controls.Add(Me.Label2)
        Me.header_pnl.Controls.Add(Me.Label1)
        Me.header_pnl.Controls.Add(Me.PictureBox1)
        Me.header_pnl.Location = New System.Drawing.Point(-8, -2)
        Me.header_pnl.Name = "header_pnl"
        Me.header_pnl.Size = New System.Drawing.Size(1252, 77)
        Me.header_pnl.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(1187, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 35)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Location = New System.Drawing.Point(528, 354)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(685, 241)
        Me.Panel2.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Location = New System.Drawing.Point(8, 248)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(685, 51)
        Me.Panel4.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(528, 92)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(685, 240)
        Me.Panel3.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Location = New System.Drawing.Point(528, 607)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(685, 39)
        Me.Panel5.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Location = New System.Drawing.Point(8, 248)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(685, 51)
        Me.Panel6.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Vineta BT", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(141, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 54)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "00:00:00:00"
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 66)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "wednesday"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1225, 667)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Panel1)
        Me.Controls.Add(Me.header_pnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Switch"
        Panel1.ResumeLayout(False)
        CType(Me.onpb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.offpb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.header_pnl.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents header_pnl As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents onpb As PictureBox
    Friend WithEvents offpb As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
End Class
