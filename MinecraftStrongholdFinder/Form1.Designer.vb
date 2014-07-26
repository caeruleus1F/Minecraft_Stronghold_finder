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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txbPos1X = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txbPos1Z = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txbPos1A = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txbPos2A = New System.Windows.Forms.TextBox()
        Me.txbPos2Z = New System.Windows.Forms.TextBox()
        Me.txbPos2X = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblSHZ = New System.Windows.Forms.Label()
        Me.lblSHX = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblLegADistance = New System.Windows.Forms.Label()
        Me.lblLegBDistance = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuInstructions = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txbPos1X
        '
        Me.txbPos1X.Location = New System.Drawing.Point(37, 23)
        Me.txbPos1X.Margin = New System.Windows.Forms.Padding(4)
        Me.txbPos1X.Name = "txbPos1X"
        Me.txbPos1X.Size = New System.Drawing.Size(63, 22)
        Me.txbPos1X.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "X:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(109, 26)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Z:"
        '
        'txbPos1Z
        '
        Me.txbPos1Z.Location = New System.Drawing.Point(131, 23)
        Me.txbPos1Z.Margin = New System.Windows.Forms.Padding(4)
        Me.txbPos1Z.Name = "txbPos1Z"
        Me.txbPos1Z.Size = New System.Drawing.Size(63, 22)
        Me.txbPos1Z.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(204, 26)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Angle:"
        '
        'txbPos1A
        '
        Me.txbPos1A.Location = New System.Drawing.Point(253, 23)
        Me.txbPos1A.Margin = New System.Windows.Forms.Padding(4)
        Me.txbPos1A.Name = "txbPos1A"
        Me.txbPos1A.Size = New System.Drawing.Size(63, 22)
        Me.txbPos1A.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.txbPos1A)
        Me.GroupBox1.Controls.Add(Me.txbPos1X)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txbPos1Z)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(13, 32)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(341, 62)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Position 1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txbPos2A)
        Me.GroupBox2.Controls.Add(Me.txbPos2Z)
        Me.GroupBox2.Controls.Add(Me.txbPos2X)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 102)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(341, 60)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Position 2"
        '
        'txbPos2A
        '
        Me.txbPos2A.Location = New System.Drawing.Point(253, 23)
        Me.txbPos2A.Margin = New System.Windows.Forms.Padding(4)
        Me.txbPos2A.Name = "txbPos2A"
        Me.txbPos2A.Size = New System.Drawing.Size(63, 22)
        Me.txbPos2A.TabIndex = 5
        '
        'txbPos2Z
        '
        Me.txbPos2Z.Location = New System.Drawing.Point(131, 23)
        Me.txbPos2Z.Margin = New System.Windows.Forms.Padding(4)
        Me.txbPos2Z.Name = "txbPos2Z"
        Me.txbPos2Z.Size = New System.Drawing.Size(63, 22)
        Me.txbPos2Z.TabIndex = 4
        '
        'txbPos2X
        '
        Me.txbPos2X.Location = New System.Drawing.Point(37, 23)
        Me.txbPos2X.Margin = New System.Windows.Forms.Padding(4)
        Me.txbPos2X.Name = "txbPos2X"
        Me.txbPos2X.Size = New System.Drawing.Size(63, 22)
        Me.txbPos2X.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(204, 26)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Angle:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(109, 26)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Z:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "X:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblSHZ)
        Me.GroupBox3.Controls.Add(Me.lblSHX)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 236)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(404, 68)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Estimated Stronghold Location"
        '
        'lblSHZ
        '
        Me.lblSHZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSHZ.Location = New System.Drawing.Point(236, 27)
        Me.lblSHZ.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSHZ.Name = "lblSHZ"
        Me.lblSHZ.Size = New System.Drawing.Size(133, 20)
        Me.lblSHZ.TabIndex = 3
        '
        'lblSHX
        '
        Me.lblSHX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSHX.Location = New System.Drawing.Point(48, 27)
        Me.lblSHX.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSHX.Name = "lblSHX"
        Me.lblSHX.Size = New System.Drawing.Size(133, 20)
        Me.lblSHX.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(205, 28)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Z:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 27)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "X:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(363, 53)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(100, 92)
        Me.btnCalc.TabIndex = 10
        Me.btnCalc.Text = "&Calculate!"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(469, 53)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 92)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(469, 212)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 92)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 178)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(199, 17)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Distance from Pos1 and Pos2:"
        '
        'lblLegADistance
        '
        Me.lblLegADistance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLegADistance.Location = New System.Drawing.Point(221, 178)
        Me.lblLegADistance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLegADistance.Name = "lblLegADistance"
        Me.lblLegADistance.Size = New System.Drawing.Size(133, 20)
        Me.lblLegADistance.TabIndex = 14
        '
        'lblLegBDistance
        '
        Me.lblLegBDistance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLegBDistance.Location = New System.Drawing.Point(221, 204)
        Me.lblLegBDistance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLegBDistance.Name = "lblLegBDistance"
        Me.lblLegBDistance.Size = New System.Drawing.Size(133, 20)
        Me.lblLegBDistance.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 204)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(186, 17)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Distance from Pos2 and SH:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(425, 315)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(146, 17)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Release: 05MAR2014"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(580, 28)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuMenu
        '
        Me.menuMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuUpdate, Me.menuInstructions, Me.menuAbout, Me.ToolStripSeparator1, Me.menuExit})
        Me.menuMenu.Name = "menuMenu"
        Me.menuMenu.Size = New System.Drawing.Size(58, 24)
        Me.menuMenu.Text = "&Menu"
        '
        'menuUpdate
        '
        Me.menuUpdate.Name = "menuUpdate"
        Me.menuUpdate.Size = New System.Drawing.Size(200, 24)
        Me.menuUpdate.Text = "Check for &update..."
        '
        'menuInstructions
        '
        Me.menuInstructions.Name = "menuInstructions"
        Me.menuInstructions.Size = New System.Drawing.Size(200, 24)
        Me.menuInstructions.Text = "Instructions..."
        '
        'menuAbout
        '
        Me.menuAbout.Name = "menuAbout"
        Me.menuAbout.Size = New System.Drawing.Size(200, 24)
        Me.menuAbout.Text = "&About..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(197, 6)
        '
        'menuExit
        '
        Me.menuExit.Name = "menuExit"
        Me.menuExit.Size = New System.Drawing.Size(200, 24)
        Me.menuExit.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 342)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblLegBDistance)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblLegADistance)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Minecraft Stronghold Finder"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txbPos1X As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txbPos1Z As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txbPos1A As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txbPos2A As System.Windows.Forms.TextBox
    Friend WithEvents txbPos2Z As System.Windows.Forms.TextBox
    Friend WithEvents txbPos2X As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblSHZ As System.Windows.Forms.Label
    Friend WithEvents lblSHX As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblLegADistance As System.Windows.Forms.Label
    Friend WithEvents lblLegBDistance As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menuMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuUpdate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuInstructions As System.Windows.Forms.ToolStripMenuItem

End Class
