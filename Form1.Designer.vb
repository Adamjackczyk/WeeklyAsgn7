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
        Me.pnlKaraoke = New System.Windows.Forms.Panel()
        Me.cboUserChoice = New System.Windows.Forms.ComboBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.btnTotalCost = New System.Windows.Forms.Button()
        Me.lblShowCost = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblHourlyOrSong = New System.Windows.Forms.Label()
        Me.lblKaraokeNight = New System.Windows.Forms.Label()
        Me.pnlKaraoke.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlKaraoke
        '
        Me.pnlKaraoke.BackColor = System.Drawing.Color.Black
        Me.pnlKaraoke.Controls.Add(Me.cboUserChoice)
        Me.pnlKaraoke.Controls.Add(Me.txtNum)
        Me.pnlKaraoke.Controls.Add(Me.BtnClear)
        Me.pnlKaraoke.Controls.Add(Me.btnTotalCost)
        Me.pnlKaraoke.Controls.Add(Me.lblShowCost)
        Me.pnlKaraoke.Controls.Add(Me.lblTotalCost)
        Me.pnlKaraoke.Controls.Add(Me.lblHourlyOrSong)
        Me.pnlKaraoke.Controls.Add(Me.lblKaraokeNight)
        Me.pnlKaraoke.Location = New System.Drawing.Point(292, -2)
        Me.pnlKaraoke.Name = "pnlKaraoke"
        Me.pnlKaraoke.Size = New System.Drawing.Size(510, 453)
        Me.pnlKaraoke.TabIndex = 0
        '
        'cboUserChoice
        '
        Me.cboUserChoice.FormattingEnabled = True
        Me.cboUserChoice.Items.AddRange(New Object() {"Individual Song ($2.99/song)", "Karaoke Room ($8.99/hour)"})
        Me.cboUserChoice.Location = New System.Drawing.Point(91, 117)
        Me.cboUserChoice.Name = "cboUserChoice"
        Me.cboUserChoice.Size = New System.Drawing.Size(343, 24)
        Me.cboUserChoice.TabIndex = 7
        Me.cboUserChoice.Text = "Select hourly or per song:"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(215, 258)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(100, 22)
        Me.txtNum.TabIndex = 6
        Me.txtNum.Visible = False
        '
        'BtnClear
        '
        Me.BtnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClear.Location = New System.Drawing.Point(306, 310)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(91, 35)
        Me.BtnClear.TabIndex = 5
        Me.BtnClear.Text = "Clear Form"
        Me.BtnClear.UseVisualStyleBackColor = True
        Me.BtnClear.Visible = False
        '
        'btnTotalCost
        '
        Me.btnTotalCost.Location = New System.Drawing.Point(132, 310)
        Me.btnTotalCost.Name = "btnTotalCost"
        Me.btnTotalCost.Size = New System.Drawing.Size(96, 34)
        Me.btnTotalCost.TabIndex = 4
        Me.btnTotalCost.Text = "Total Cost"
        Me.btnTotalCost.UseVisualStyleBackColor = True
        Me.btnTotalCost.Visible = False
        '
        'lblShowCost
        '
        Me.lblShowCost.AutoSize = True
        Me.lblShowCost.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowCost.ForeColor = System.Drawing.Color.White
        Me.lblShowCost.Location = New System.Drawing.Point(349, 385)
        Me.lblShowCost.Name = "lblShowCost"
        Me.lblShowCost.Size = New System.Drawing.Size(65, 25)
        Me.lblShowCost.TabIndex = 3
        Me.lblShowCost.Text = "Label4"
        Me.lblShowCost.Visible = False
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.Color.White
        Me.lblTotalCost.Location = New System.Drawing.Point(72, 385)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(271, 25)
        Me.lblTotalCost.TabIndex = 2
        Me.lblTotalCost.Text = "Total Cost of Karaoke Night - "
        Me.lblTotalCost.Visible = False
        '
        'lblHourlyOrSong
        '
        Me.lblHourlyOrSong.AutoSize = True
        Me.lblHourlyOrSong.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourlyOrSong.ForeColor = System.Drawing.Color.White
        Me.lblHourlyOrSong.Location = New System.Drawing.Point(141, 202)
        Me.lblHourlyOrSong.Name = "lblHourlyOrSong"
        Me.lblHourlyOrSong.Size = New System.Drawing.Size(379, 35)
        Me.lblHourlyOrSong.TabIndex = 1
        Me.lblHourlyOrSong.Text = "Hourly Rental of Karaoke Room"
        Me.lblHourlyOrSong.Visible = False
        '
        'lblKaraokeNight
        '
        Me.lblKaraokeNight.AutoSize = True
        Me.lblKaraokeNight.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKaraokeNight.ForeColor = System.Drawing.Color.White
        Me.lblKaraokeNight.Location = New System.Drawing.Point(96, 42)
        Me.lblKaraokeNight.Name = "lblKaraokeNight"
        Me.lblKaraokeNight.Size = New System.Drawing.Size(318, 41)
        Me.lblKaraokeNight.TabIndex = 0
        Me.lblKaraokeNight.Text = "Karaoke Music Night"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnTotalCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.BtnClear
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlKaraoke)
        Me.Name = "Form1"
        Me.Text = "Karaoke Music Night"
        Me.pnlKaraoke.ResumeLayout(False)
        Me.pnlKaraoke.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlKaraoke As Panel
    Friend WithEvents cboUserChoice As ComboBox
    Friend WithEvents txtNum As TextBox
    Friend WithEvents BtnClear As Button
    Friend WithEvents btnTotalCost As Button
    Friend WithEvents lblShowCost As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblHourlyOrSong As Label
    Friend WithEvents lblKaraokeNight As Label
End Class
