<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderInfoWindow
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
        Me.OrderPanel = New System.Windows.Forms.Panel()
        Me.DateDownloadedText = New System.Windows.Forms.Label()
        Me.PostClassText = New System.Windows.Forms.Label()
        Me.OrderIDText = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerPanel = New System.Windows.Forms.Panel()
        Me.CPostCodeText = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CAd2Text = New System.Windows.Forms.Label()
        Me.CAd1Text = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CAd3Text = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CNameText = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ItemPanel = New System.Windows.Forms.Panel()
        Me.ItemDistText = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ItemLocationText = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ItemSkuText = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ItemAmountText = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ItemNameText = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PreviousItemBTN = New System.Windows.Forms.Button()
        Me.NextItemBTN = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ItemsInOrderText = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SelectedItemText = New System.Windows.Forms.Label()
        Me.OrderPanel.SuspendLayout()
        Me.CustomerPanel.SuspendLayout()
        Me.ItemPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'OrderPanel
        '
        Me.OrderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OrderPanel.Controls.Add(Me.DateDownloadedText)
        Me.OrderPanel.Controls.Add(Me.PostClassText)
        Me.OrderPanel.Controls.Add(Me.OrderIDText)
        Me.OrderPanel.Controls.Add(Me.Label4)
        Me.OrderPanel.Controls.Add(Me.Label2)
        Me.OrderPanel.Controls.Add(Me.Label1)
        Me.OrderPanel.Location = New System.Drawing.Point(6, 5)
        Me.OrderPanel.Name = "OrderPanel"
        Me.OrderPanel.Size = New System.Drawing.Size(337, 62)
        Me.OrderPanel.TabIndex = 0
        '
        'DateDownloadedText
        '
        Me.DateDownloadedText.AutoSize = True
        Me.DateDownloadedText.Location = New System.Drawing.Point(113, 25)
        Me.DateDownloadedText.Name = "DateDownloadedText"
        Me.DateDownloadedText.Size = New System.Drawing.Size(55, 13)
        Me.DateDownloadedText.TabIndex = 7
        Me.DateDownloadedText.Text = "##-##-##"
        '
        'PostClassText
        '
        Me.PostClassText.AutoSize = True
        Me.PostClassText.Location = New System.Drawing.Point(113, 42)
        Me.PostClassText.Name = "PostClassText"
        Me.PostClassText.Size = New System.Drawing.Size(100, 13)
        Me.PostClassText.TabIndex = 5
        Me.PostClassText.Text = "POST TYPE HERE"
        '
        'OrderIDText
        '
        Me.OrderIDText.AutoSize = True
        Me.OrderIDText.Location = New System.Drawing.Point(113, 8)
        Me.OrderIDText.Name = "OrderIDText"
        Me.OrderIDText.Size = New System.Drawing.Size(56, 13)
        Me.OrderIDText.TabIndex = 4
        Me.OrderIDText.Text = "#######"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date Downloaded:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Post Type:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order ID:"
        '
        'CustomerPanel
        '
        Me.CustomerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerPanel.Controls.Add(Me.CPostCodeText)
        Me.CustomerPanel.Controls.Add(Me.Label13)
        Me.CustomerPanel.Controls.Add(Me.CAd2Text)
        Me.CustomerPanel.Controls.Add(Me.CAd1Text)
        Me.CustomerPanel.Controls.Add(Me.Label12)
        Me.CustomerPanel.Controls.Add(Me.CAd3Text)
        Me.CustomerPanel.Controls.Add(Me.Label11)
        Me.CustomerPanel.Controls.Add(Me.CNameText)
        Me.CustomerPanel.Controls.Add(Me.Label10)
        Me.CustomerPanel.Controls.Add(Me.Label9)
        Me.CustomerPanel.Location = New System.Drawing.Point(6, 72)
        Me.CustomerPanel.Name = "CustomerPanel"
        Me.CustomerPanel.Size = New System.Drawing.Size(337, 92)
        Me.CustomerPanel.TabIndex = 1
        '
        'CPostCodeText
        '
        Me.CPostCodeText.AutoSize = True
        Me.CPostCodeText.Location = New System.Drawing.Point(113, 73)
        Me.CPostCodeText.Name = "CPostCodeText"
        Me.CPostCodeText.Size = New System.Drawing.Size(21, 13)
        Me.CPostCodeText.TabIndex = 17
        Me.CPostCodeText.Text = "PC"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Post Code:"
        '
        'CAd2Text
        '
        Me.CAd2Text.AutoSize = True
        Me.CAd2Text.Location = New System.Drawing.Point(113, 39)
        Me.CAd2Text.Name = "CAd2Text"
        Me.CAd2Text.Size = New System.Drawing.Size(28, 13)
        Me.CAd2Text.TabIndex = 15
        Me.CAd2Text.Text = "AD2"
        '
        'CAd1Text
        '
        Me.CAd1Text.AutoSize = True
        Me.CAd1Text.Location = New System.Drawing.Point(113, 21)
        Me.CAd1Text.Name = "CAd1Text"
        Me.CAd1Text.Size = New System.Drawing.Size(28, 13)
        Me.CAd1Text.TabIndex = 14
        Me.CAd1Text.Text = "AD1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Customer Name:"
        '
        'CAd3Text
        '
        Me.CAd3Text.AutoSize = True
        Me.CAd3Text.Location = New System.Drawing.Point(113, 56)
        Me.CAd3Text.Name = "CAd3Text"
        Me.CAd3Text.Size = New System.Drawing.Size(28, 13)
        Me.CAd3Text.TabIndex = 13
        Me.CAd3Text.Text = "AD3"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Address 3:"
        '
        'CNameText
        '
        Me.CNameText.AutoSize = True
        Me.CNameText.Location = New System.Drawing.Point(113, 4)
        Me.CNameText.Name = "CNameText"
        Me.CNameText.Size = New System.Drawing.Size(71, 13)
        Me.CNameText.TabIndex = 12
        Me.CNameText.Text = "NAME HERE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Address 1:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Address 2:"
        '
        'ItemPanel
        '
        Me.ItemPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ItemPanel.Controls.Add(Me.ItemDistText)
        Me.ItemPanel.Controls.Add(Me.Label16)
        Me.ItemPanel.Controls.Add(Me.ItemLocationText)
        Me.ItemPanel.Controls.Add(Me.Label14)
        Me.ItemPanel.Controls.Add(Me.ItemSkuText)
        Me.ItemPanel.Controls.Add(Me.Label8)
        Me.ItemPanel.Controls.Add(Me.ItemAmountText)
        Me.ItemPanel.Controls.Add(Me.Label7)
        Me.ItemPanel.Controls.Add(Me.ItemNameText)
        Me.ItemPanel.Controls.Add(Me.Label6)
        Me.ItemPanel.Location = New System.Drawing.Point(6, 198)
        Me.ItemPanel.Name = "ItemPanel"
        Me.ItemPanel.Size = New System.Drawing.Size(337, 94)
        Me.ItemPanel.TabIndex = 2
        '
        'ItemDistText
        '
        Me.ItemDistText.AutoSize = True
        Me.ItemDistText.Location = New System.Drawing.Point(113, 69)
        Me.ItemDistText.Name = "ItemDistText"
        Me.ItemDistText.Size = New System.Drawing.Size(144, 13)
        Me.ItemDistText.TabIndex = 22
        Me.ItemDistText.Text = "[ITEM DISTINCTION HERE]"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 69)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Item Distinction:"
        '
        'ItemLocationText
        '
        Me.ItemLocationText.AutoSize = True
        Me.ItemLocationText.Location = New System.Drawing.Point(113, 38)
        Me.ItemLocationText.Name = "ItemLocationText"
        Me.ItemLocationText.Size = New System.Drawing.Size(129, 13)
        Me.ItemLocationText.TabIndex = 21
        Me.ItemLocationText.Text = "[ITEM LOCATION HERE]"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 54)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Item Quantity:"
        '
        'ItemSkuText
        '
        Me.ItemSkuText.AutoSize = True
        Me.ItemSkuText.Location = New System.Drawing.Point(113, 22)
        Me.ItemSkuText.Name = "ItemSkuText"
        Me.ItemSkuText.Size = New System.Drawing.Size(84, 13)
        Me.ItemSkuText.TabIndex = 20
        Me.ItemSkuText.Text = "###########"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Item Location:"
        '
        'ItemAmountText
        '
        Me.ItemAmountText.AutoSize = True
        Me.ItemAmountText.Location = New System.Drawing.Point(113, 54)
        Me.ItemAmountText.Name = "ItemAmountText"
        Me.ItemAmountText.Size = New System.Drawing.Size(28, 13)
        Me.ItemAmountText.TabIndex = 19
        Me.ItemAmountText.Text = "###"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Item Name:"
        '
        'ItemNameText
        '
        Me.ItemNameText.AutoSize = True
        Me.ItemNameText.Location = New System.Drawing.Point(113, 5)
        Me.ItemNameText.Name = "ItemNameText"
        Me.ItemNameText.Size = New System.Drawing.Size(106, 13)
        Me.ItemNameText.TabIndex = 18
        Me.ItemNameText.Text = "[ITEM NAME HERE]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Item SKU:"
        '
        'PreviousItemBTN
        '
        Me.PreviousItemBTN.Location = New System.Drawing.Point(6, 170)
        Me.PreviousItemBTN.Name = "PreviousItemBTN"
        Me.PreviousItemBTN.Size = New System.Drawing.Size(89, 23)
        Me.PreviousItemBTN.TabIndex = 3
        Me.PreviousItemBTN.Text = "Previous Item"
        Me.PreviousItemBTN.UseVisualStyleBackColor = True
        '
        'NextItemBTN
        '
        Me.NextItemBTN.Location = New System.Drawing.Point(254, 170)
        Me.NextItemBTN.Name = "NextItemBTN"
        Me.NextItemBTN.Size = New System.Drawing.Size(89, 23)
        Me.NextItemBTN.TabIndex = 4
        Me.NextItemBTN.Text = "Next Item"
        Me.NextItemBTN.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(108, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Total Items in Order:"
        '
        'ItemsInOrderText
        '
        Me.ItemsInOrderText.AutoSize = True
        Me.ItemsInOrderText.Location = New System.Drawing.Point(214, 182)
        Me.ItemsInOrderText.Name = "ItemsInOrderText"
        Me.ItemsInOrderText.Size = New System.Drawing.Size(28, 13)
        Me.ItemsInOrderText.TabIndex = 6
        Me.ItemsInOrderText.Text = "###"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(108, 168)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 13)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Selected Item:"
        '
        'SelectedItemText
        '
        Me.SelectedItemText.AutoSize = True
        Me.SelectedItemText.Location = New System.Drawing.Point(214, 168)
        Me.SelectedItemText.Name = "SelectedItemText"
        Me.SelectedItemText.Size = New System.Drawing.Size(28, 13)
        Me.SelectedItemText.TabIndex = 8
        Me.SelectedItemText.Text = "###"
        '
        'OrderInfoWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 298)
        Me.Controls.Add(Me.SelectedItemText)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ItemsInOrderText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NextItemBTN)
        Me.Controls.Add(Me.PreviousItemBTN)
        Me.Controls.Add(Me.ItemPanel)
        Me.Controls.Add(Me.CustomerPanel)
        Me.Controls.Add(Me.OrderPanel)
        Me.Name = "OrderInfoWindow"
        Me.Text = "Order Info"
        Me.OrderPanel.ResumeLayout(False)
        Me.OrderPanel.PerformLayout()
        Me.CustomerPanel.ResumeLayout(False)
        Me.CustomerPanel.PerformLayout()
        Me.ItemPanel.ResumeLayout(False)
        Me.ItemPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OrderPanel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CustomerPanel As Panel
    Friend WithEvents ItemPanel As Panel
    Friend WithEvents DateDownloadedText As Label
    Friend WithEvents PostClassText As Label
    Friend WithEvents OrderIDText As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PreviousItemBTN As Button
    Friend WithEvents NextItemBTN As Button
    Friend WithEvents CPostCodeText As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents CAd2Text As Label
    Friend WithEvents CAd1Text As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CAd3Text As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents CNameText As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ItemDistText As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents ItemLocationText As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents ItemSkuText As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ItemAmountText As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ItemNameText As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ItemsInOrderText As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents SelectedItemText As Label
End Class
