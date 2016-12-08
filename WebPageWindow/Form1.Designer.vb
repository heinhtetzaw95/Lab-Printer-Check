<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrinterCheckWindow
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
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.BWRL = New System.Windows.Forms.TabPage()
        Me.BWRR = New System.Windows.Forms.TabPage()
        Me.color = New System.Windows.Forms.TabPage()
        Me.LofR = New System.Windows.Forms.WebBrowser()
        Me.RofR = New System.Windows.Forms.WebBrowser()
        Me.dellcolor = New System.Windows.Forms.WebBrowser()
        Me.LofL = New System.Windows.Forms.WebBrowser()
        Me.BWLL = New System.Windows.Forms.TabPage()
        Me.RofL = New System.Windows.Forms.WebBrowser()
        Me.BWLR = New System.Windows.Forms.TabPage()
        Me.TabControl.SuspendLayout()
        Me.BWRL.SuspendLayout()
        Me.BWRR.SuspendLayout()
        Me.color.SuspendLayout()
        Me.BWLL.SuspendLayout()
        Me.BWLR.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.BWLL)
        Me.TabControl.Controls.Add(Me.BWLR)
        Me.TabControl.Controls.Add(Me.BWRL)
        Me.TabControl.Controls.Add(Me.BWRR)
        Me.TabControl.Controls.Add(Me.color)
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1012, 731)
        Me.TabControl.TabIndex = 1
        '
        'BWRL
        '
        Me.BWRL.Controls.Add(Me.LofR)
        Me.BWRL.Location = New System.Drawing.Point(4, 22)
        Me.BWRL.Name = "BWRL"
        Me.BWRL.Size = New System.Drawing.Size(780, 537)
        Me.BWRL.TabIndex = 2
        Me.BWRL.Text = "B&W (Left of Right)"
        Me.BWRL.UseVisualStyleBackColor = True
        '
        'BWRR
        '
        Me.BWRR.Controls.Add(Me.RofR)
        Me.BWRR.Location = New System.Drawing.Point(4, 22)
        Me.BWRR.Name = "BWRR"
        Me.BWRR.Size = New System.Drawing.Size(780, 537)
        Me.BWRR.TabIndex = 3
        Me.BWRR.Text = "B&W (Right of Right)"
        Me.BWRR.UseVisualStyleBackColor = True
        '
        'color
        '
        Me.color.Controls.Add(Me.dellcolor)
        Me.color.Location = New System.Drawing.Point(4, 22)
        Me.color.Name = "color"
        Me.color.Size = New System.Drawing.Size(1004, 705)
        Me.color.TabIndex = 4
        Me.color.Text = "Color (at Back)"
        Me.color.UseVisualStyleBackColor = True
        '
        'LofR
        '
        Me.LofR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LofR.Location = New System.Drawing.Point(0, 0)
        Me.LofR.Margin = New System.Windows.Forms.Padding(0)
        Me.LofR.MinimumSize = New System.Drawing.Size(20, 20)
        Me.LofR.Name = "LofR"
        Me.LofR.Size = New System.Drawing.Size(780, 537)
        Me.LofR.TabIndex = 0
        Me.LofR.Url = New System.Uri("http://10.13.20.7", System.UriKind.Absolute)
        '
        'RofR
        '
        Me.RofR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RofR.Location = New System.Drawing.Point(0, 0)
        Me.RofR.Margin = New System.Windows.Forms.Padding(0)
        Me.RofR.MinimumSize = New System.Drawing.Size(20, 20)
        Me.RofR.Name = "RofR"
        Me.RofR.Size = New System.Drawing.Size(780, 537)
        Me.RofR.TabIndex = 0
        Me.RofR.Url = New System.Uri("http://10.13.20.6", System.UriKind.Absolute)
        '
        'dellcolor
        '
        Me.dellcolor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dellcolor.Location = New System.Drawing.Point(0, 0)
        Me.dellcolor.Margin = New System.Windows.Forms.Padding(0)
        Me.dellcolor.MinimumSize = New System.Drawing.Size(20, 20)
        Me.dellcolor.Name = "dellcolor"
        Me.dellcolor.ScrollBarsEnabled = False
        Me.dellcolor.Size = New System.Drawing.Size(1004, 705)
        Me.dellcolor.TabIndex = 0
        Me.dellcolor.Url = New System.Uri("http://www.google.com", System.UriKind.Absolute)
        '
        'LofL
        '
        Me.LofL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LofL.Location = New System.Drawing.Point(0, 0)
        Me.LofL.Margin = New System.Windows.Forms.Padding(0)
        Me.LofL.MinimumSize = New System.Drawing.Size(20, 20)
        Me.LofL.Name = "LofL"
        Me.LofL.Size = New System.Drawing.Size(780, 537)
        Me.LofL.TabIndex = 0
        Me.LofL.Url = New System.Uri("http://10.13.20.9", System.UriKind.Absolute)
        '
        'BWLL
        '
        Me.BWLL.Controls.Add(Me.LofL)
        Me.BWLL.Location = New System.Drawing.Point(4, 22)
        Me.BWLL.Name = "BWLL"
        Me.BWLL.Size = New System.Drawing.Size(780, 537)
        Me.BWLL.TabIndex = 0
        Me.BWLL.Text = "B&W (Left of Left)"
        Me.BWLL.UseVisualStyleBackColor = True
        '
        'RofL
        '
        Me.RofL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RofL.Location = New System.Drawing.Point(0, 0)
        Me.RofL.Margin = New System.Windows.Forms.Padding(0)
        Me.RofL.MinimumSize = New System.Drawing.Size(20, 20)
        Me.RofL.Name = "RofL"
        Me.RofL.Size = New System.Drawing.Size(980, 737)
        Me.RofL.TabIndex = 0
        Me.RofL.Url = New System.Uri("http://10.13.20.8", System.UriKind.Absolute)
        '
        'BWLR
        '
        Me.BWLR.Controls.Add(Me.RofL)
        Me.BWLR.Location = New System.Drawing.Point(4, 22)
        Me.BWLR.Name = "BWLR"
        Me.BWLR.Size = New System.Drawing.Size(980, 737)
        Me.BWLR.TabIndex = 1
        Me.BWLR.Text = "B&W (Right of Left)"
        Me.BWLR.UseVisualStyleBackColor = True
        '
        'PrinterCheckWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "PrinterCheckWindow"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab Printer Check"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl.ResumeLayout(False)
        Me.BWRL.ResumeLayout(False)
        Me.BWRR.ResumeLayout(False)
        Me.color.ResumeLayout(False)
        Me.BWLL.ResumeLayout(False)
        Me.BWLR.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents BWRL As TabPage
    Friend WithEvents LofR As WebBrowser
    Friend WithEvents BWRR As TabPage
    Friend WithEvents RofR As WebBrowser
    Friend WithEvents color As TabPage
    Friend WithEvents dellcolor As WebBrowser
    Friend WithEvents BWLL As TabPage
    Friend WithEvents LofL As WebBrowser
    Friend WithEvents BWLR As TabPage
    Friend WithEvents RofL As WebBrowser
End Class
