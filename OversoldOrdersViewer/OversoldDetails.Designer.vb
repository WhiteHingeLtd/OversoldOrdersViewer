<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OversoldDetails
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ItemNameText = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CompleteBTN = New System.Windows.Forms.Button()
        Me.OrderedBTN = New System.Windows.Forms.Button()
        Me.MoreInfoBTN = New System.Windows.Forms.Button()
        Me.Reminder = New System.Windows.Forms.Label()
        Me.TotalPanel = New WHLClasses.Controls.BPanel()
        Me.SupplierText = New System.Windows.Forms.TextBox()
        Me.SuppCodeText = New System.Windows.Forms.TextBox()
        Me.ExtraInfoBtn = New System.Windows.Forms.Button()
        Me.ExtraInfoText = New System.Windows.Forms.TextBox()
        Me.TotalPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ItemNameText
        '
        Me.ItemNameText.AutoSize = True
        Me.ItemNameText.Location = New System.Drawing.Point(15, 4)
        Me.ItemNameText.Name = "ItemNameText"
        Me.ItemNameText.Size = New System.Drawing.Size(61, 20)
        Me.ItemNameText.TabIndex = 7
        Me.ItemNameText.Text = "[NAME]"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Sup. Code:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Supplier:"
        '
        'CompleteBTN
        '
        Me.CompleteBTN.Location = New System.Drawing.Point(144, 86)
        Me.CompleteBTN.Name = "CompleteBTN"
        Me.CompleteBTN.Size = New System.Drawing.Size(90, 39)
        Me.CompleteBTN.TabIndex = 9
        Me.CompleteBTN.Text = "Complete"
        Me.CompleteBTN.UseVisualStyleBackColor = True
        '
        'OrderedBTN
        '
        Me.OrderedBTN.Location = New System.Drawing.Point(235, 86)
        Me.OrderedBTN.Name = "OrderedBTN"
        Me.OrderedBTN.Size = New System.Drawing.Size(86, 39)
        Me.OrderedBTN.TabIndex = 10
        Me.OrderedBTN.Text = "Ordered"
        Me.OrderedBTN.UseVisualStyleBackColor = True
        '
        'MoreInfoBTN
        '
        Me.MoreInfoBTN.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoreInfoBTN.Location = New System.Drawing.Point(24, 86)
        Me.MoreInfoBTN.Name = "MoreInfoBTN"
        Me.MoreInfoBTN.Size = New System.Drawing.Size(45, 39)
        Me.MoreInfoBTN.TabIndex = 12
        Me.MoreInfoBTN.Text = "More Info"
        Me.MoreInfoBTN.UseVisualStyleBackColor = True
        '
        'Reminder
        '
        Me.Reminder.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Reminder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Reminder.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reminder.ForeColor = System.Drawing.SystemColors.Info
        Me.Reminder.Location = New System.Drawing.Point(73, 87)
        Me.Reminder.Name = "Reminder"
        Me.Reminder.Size = New System.Drawing.Size(67, 37)
        Me.Reminder.TabIndex = 13
        Me.Reminder.Text = "Remember" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to save"
        Me.Reminder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Reminder.Visible = False
        '
        'TotalPanel
        '
        Me.TotalPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalPanel.BorderWidth = 1
        Me.TotalPanel.Controls.Add(Me.ExtraInfoText)
        Me.TotalPanel.Controls.Add(Me.ExtraInfoBtn)
        Me.TotalPanel.Controls.Add(Me.SupplierText)
        Me.TotalPanel.Controls.Add(Me.OrderedBTN)
        Me.TotalPanel.Controls.Add(Me.SuppCodeText)
        Me.TotalPanel.Controls.Add(Me.CompleteBTN)
        Me.TotalPanel.Controls.Add(Me.Label8)
        Me.TotalPanel.Controls.Add(Me.Label5)
        Me.TotalPanel.Controls.Add(Me.Reminder)
        Me.TotalPanel.Controls.Add(Me.ItemNameText)
        Me.TotalPanel.Controls.Add(Me.MoreInfoBTN)
        Me.TotalPanel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPanel.HighlightBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TotalPanel.HighlightBorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.TotalPanel.HighlightNotBackgroundColor = System.Drawing.Color.Empty
        Me.TotalPanel.HighlightNotBorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.TotalPanel.HighlightOnFocus = True
        Me.TotalPanel.Location = New System.Drawing.Point(2, 2)
        Me.TotalPanel.Margin = New System.Windows.Forms.Padding(10)
        Me.TotalPanel.Name = "TotalPanel"
        Me.TotalPanel.Padding = New System.Windows.Forms.Padding(21, 8, 8, 8)
        Me.TotalPanel.Size = New System.Drawing.Size(332, 171)
        Me.TotalPanel.TabIndex = 14
        Me.TotalPanel.Title = "Better Group"
        '
        'SupplierText
        '
        Me.SupplierText.Location = New System.Drawing.Point(102, 24)
        Me.SupplierText.Name = "SupplierText"
        Me.SupplierText.ReadOnly = True
        Me.SupplierText.Size = New System.Drawing.Size(219, 27)
        Me.SupplierText.TabIndex = 18
        '
        'SuppCodeText
        '
        Me.SuppCodeText.Location = New System.Drawing.Point(102, 53)
        Me.SuppCodeText.Name = "SuppCodeText"
        Me.SuppCodeText.ReadOnly = True
        Me.SuppCodeText.Size = New System.Drawing.Size(219, 27)
        Me.SuppCodeText.TabIndex = 17
        '
        'ExtraInfoBtn
        '
        Me.ExtraInfoBtn.Location = New System.Drawing.Point(235, 127)
        Me.ExtraInfoBtn.Name = "ExtraInfoBtn"
        Me.ExtraInfoBtn.Size = New System.Drawing.Size(86, 39)
        Me.ExtraInfoBtn.TabIndex = 19
        Me.ExtraInfoBtn.Text = "Add Info"
        Me.ExtraInfoBtn.UseVisualStyleBackColor = True
        '
        'ExtraInfoText
        '
        Me.ExtraInfoText.Location = New System.Drawing.Point(24, 133)
        Me.ExtraInfoText.MaxLength = 300
        Me.ExtraInfoText.Name = "ExtraInfoText"
        Me.ExtraInfoText.Size = New System.Drawing.Size(210, 27)
        Me.ExtraInfoText.TabIndex = 20
        '
        'OversoldDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TotalPanel)
        Me.Name = "OversoldDetails"
        Me.Size = New System.Drawing.Size(336, 175)
        Me.TotalPanel.ResumeLayout(False)
        Me.TotalPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ItemNameText As Label
    Friend WithEvents CompleteBTN As Button
    Friend WithEvents OrderedBTN As Button
    Friend WithEvents MoreInfoBTN As Button
    Friend WithEvents Reminder As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TotalPanel As WHLClasses.Controls.BPanel
    Friend WithEvents SupplierText As TextBox
    Friend WithEvents SuppCodeText As TextBox
    Friend WithEvents ExtraInfoText As TextBox
    Friend WithEvents ExtraInfoBtn As Button
End Class
