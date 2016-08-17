<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OversoldList = New System.Windows.Forms.FlowLayoutPanel()
        Me.SaveBTN = New System.Windows.Forms.Button()
        Me.OrderedCheck = New System.Windows.Forms.CheckBox()
        Me.CompleteCheck = New System.Windows.Forms.CheckBox()
        Me.RefreshBTN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InfoText = New System.Windows.Forms.Label()
        Me.CheckboxTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BootTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GetUserInfoBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.OversoldList)
        Me.Panel1.Controls.Add(Me.SaveBTN)
        Me.Panel1.Controls.Add(Me.OrderedCheck)
        Me.Panel1.Controls.Add(Me.CompleteCheck)
        Me.Panel1.Controls.Add(Me.RefreshBTN)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(371, 637)
        Me.Panel1.TabIndex = 0
        '
        'OversoldList
        '
        Me.OversoldList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OversoldList.AutoScroll = True
        Me.OversoldList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OversoldList.Location = New System.Drawing.Point(3, 23)
        Me.OversoldList.Name = "OversoldList"
        Me.OversoldList.Size = New System.Drawing.Size(362, 564)
        Me.OversoldList.TabIndex = 6
        '
        'SaveBTN
        '
        Me.SaveBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveBTN.Location = New System.Drawing.Point(317, 591)
        Me.SaveBTN.Name = "SaveBTN"
        Me.SaveBTN.Size = New System.Drawing.Size(49, 39)
        Me.SaveBTN.TabIndex = 5
        Me.SaveBTN.Text = "Save"
        Me.SaveBTN.UseVisualStyleBackColor = True
        '
        'OrderedCheck
        '
        Me.OrderedCheck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OrderedCheck.AutoSize = True
        Me.OrderedCheck.Location = New System.Drawing.Point(85, 590)
        Me.OrderedCheck.Name = "OrderedCheck"
        Me.OrderedCheck.Size = New System.Drawing.Size(95, 17)
        Me.OrderedCheck.TabIndex = 4
        Me.OrderedCheck.Text = "Stock Ordered"
        Me.CheckboxTooltip.SetToolTip(Me.OrderedCheck, "This will turn on / off finding records of orders which" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "have previously been mar" &
        "ked as ordered. Useful for" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "reducing a large list to just the new oversold items" &
        ".")
        Me.OrderedCheck.UseVisualStyleBackColor = True
        '
        'CompleteCheck
        '
        Me.CompleteCheck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CompleteCheck.AutoSize = True
        Me.CompleteCheck.Location = New System.Drawing.Point(3, 590)
        Me.CompleteCheck.Name = "CompleteCheck"
        Me.CompleteCheck.Size = New System.Drawing.Size(76, 17)
        Me.CompleteCheck.TabIndex = 3
        Me.CompleteCheck.Text = "Completed"
        Me.CheckboxTooltip.SetToolTip(Me.CompleteCheck, "This will turn on / off finding records of orders which" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "have previously been mar" &
        "ked as complete. This" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "option will always be available should it be needed." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.CompleteCheck.UseVisualStyleBackColor = True
        '
        'RefreshBTN
        '
        Me.RefreshBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RefreshBTN.Location = New System.Drawing.Point(3, 607)
        Me.RefreshBTN.Name = "RefreshBTN"
        Me.RefreshBTN.Size = New System.Drawing.Size(170, 23)
        Me.RefreshBTN.TabIndex = 2
        Me.RefreshBTN.Text = "Loading, please wait."
        Me.RefreshBTN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Oversold Orders List"
        '
        'InfoText
        '
        Me.InfoText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoText.AutoSize = True
        Me.InfoText.Location = New System.Drawing.Point(24, 642)
        Me.InfoText.Name = "InfoText"
        Me.InfoText.Size = New System.Drawing.Size(268, 13)
        Me.InfoText.TabIndex = 2
        Me.InfoText.Text = "This list will always display unprocessed oversold orders"
        '
        'BootTimer
        '
        Me.BootTimer.Enabled = True
        Me.BootTimer.Interval = 1000
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GetUserInfoBtn)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(374, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(141, 637)
        Me.Panel2.TabIndex = 3
        '
        'GetUserInfoBtn
        '
        Me.GetUserInfoBtn.Location = New System.Drawing.Point(3, 24)
        Me.GetUserInfoBtn.Name = "GetUserInfoBtn"
        Me.GetUserInfoBtn.Size = New System.Drawing.Size(133, 39)
        Me.GetUserInfoBtn.TabIndex = 1
        Me.GetUserInfoBtn.Text = "Get Warehouse Stats"
        Me.GetUserInfoBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Extra Stuff"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 661)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.InfoText)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MainForm"
        Me.Text = "Oversold Order Viewer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents OrderedCheck As CheckBox
    Friend WithEvents CompleteCheck As CheckBox
    Friend WithEvents RefreshBTN As Button
    Friend WithEvents InfoText As Label
    Friend WithEvents SaveBTN As Button
    Friend WithEvents OversoldList As FlowLayoutPanel
    Friend WithEvents CheckboxTooltip As ToolTip
    Friend WithEvents BootTimer As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GetUserInfoBtn As Button
    Friend WithEvents Label2 As Label
End Class
