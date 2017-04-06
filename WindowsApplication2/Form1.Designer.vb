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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Car1 = New System.Windows.Forms.PictureBox()
        Me.Car2 = New System.Windows.Forms.PictureBox()
        Me.Car3 = New System.Windows.Forms.PictureBox()
        Me.Van = New System.Windows.Forms.PictureBox()
        Me.Man = New System.Windows.Forms.PictureBox()
        Me.TrafficTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GameOverTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btStop = New System.Windows.Forms.Button()
        Me.BtGo = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Van, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Man, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox1.Location = New System.Drawing.Point(2, 232)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(764, 10)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox2.Location = New System.Drawing.Point(2, 248)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(764, 10)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Car1
        '
        Me.Car1.Image = CType(resources.GetObject("Car1.Image"), System.Drawing.Image)
        Me.Car1.Location = New System.Drawing.Point(729, 65)
        Me.Car1.Name = "Car1"
        Me.Car1.Size = New System.Drawing.Size(108, 51)
        Me.Car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Car1.TabIndex = 1
        Me.Car1.TabStop = False
        '
        'Car2
        '
        Me.Car2.Image = CType(resources.GetObject("Car2.Image"), System.Drawing.Image)
        Me.Car2.Location = New System.Drawing.Point(-83, 151)
        Me.Car2.Name = "Car2"
        Me.Car2.Size = New System.Drawing.Size(108, 51)
        Me.Car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Car2.TabIndex = 1
        Me.Car2.TabStop = False
        '
        'Car3
        '
        Me.Car3.Image = CType(resources.GetObject("Car3.Image"), System.Drawing.Image)
        Me.Car3.Location = New System.Drawing.Point(729, 276)
        Me.Car3.Name = "Car3"
        Me.Car3.Size = New System.Drawing.Size(108, 51)
        Me.Car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Car3.TabIndex = 1
        Me.Car3.TabStop = False
        '
        'Van
        '
        Me.Van.Image = CType(resources.GetObject("Van.Image"), System.Drawing.Image)
        Me.Van.Location = New System.Drawing.Point(729, 400)
        Me.Van.Name = "Van"
        Me.Van.Size = New System.Drawing.Size(108, 51)
        Me.Van.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Van.TabIndex = 1
        Me.Van.TabStop = False
        '
        'Man
        '
        Me.Man.Image = CType(resources.GetObject("Man.Image"), System.Drawing.Image)
        Me.Man.Location = New System.Drawing.Point(284, 455)
        Me.Man.Name = "Man"
        Me.Man.Size = New System.Drawing.Size(80, 50)
        Me.Man.TabIndex = 2
        Me.Man.TabStop = False
        '
        'TrafficTimer
        '
        Me.TrafficTimer.Enabled = True
        Me.TrafficTimer.Interval = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(266, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "GAME OVER"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(266, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "RSET GAME??"
        Me.Label2.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(-5, -3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(749, 20)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'GameOverTimer
        '
        '
        'btStop
        '
        Me.btStop.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btStop.CausesValidation = False
        Me.btStop.Enabled = False
        Me.btStop.Location = New System.Drawing.Point(576, 485)
        Me.btStop.Name = "btStop"
        Me.btStop.Size = New System.Drawing.Size(58, 20)
        Me.btStop.TabIndex = 5
        Me.btStop.Text = "Stop"
        Me.btStop.UseVisualStyleBackColor = True
        '
        'BtGo
        '
        Me.BtGo.CausesValidation = False
        Me.BtGo.Enabled = False
        Me.BtGo.Location = New System.Drawing.Point(640, 485)
        Me.BtGo.Name = "BtGo"
        Me.BtGo.Size = New System.Drawing.Size(58, 20)
        Me.BtGo.TabIndex = 5
        Me.BtGo.Text = "Go"
        Me.BtGo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 511)
        Me.Controls.Add(Me.Man)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Van)
        Me.Controls.Add(Me.Car3)
        Me.Controls.Add(Me.Car2)
        Me.Controls.Add(Me.Car1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtGo)
        Me.Controls.Add(Me.btStop)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Van, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Man, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Car1 As System.Windows.Forms.PictureBox
    Friend WithEvents Car2 As System.Windows.Forms.PictureBox
    Friend WithEvents Car3 As System.Windows.Forms.PictureBox
    Friend WithEvents Van As System.Windows.Forms.PictureBox
    Friend WithEvents Man As System.Windows.Forms.PictureBox
    Friend WithEvents TrafficTimer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents GameOverTimer As System.Windows.Forms.Timer
    Friend WithEvents btStop As System.Windows.Forms.Button
    Friend WithEvents BtGo As System.Windows.Forms.Button

End Class
