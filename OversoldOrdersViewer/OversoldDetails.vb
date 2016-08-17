Imports WHLClasses

Public Class OversoldDetails
    Dim theOrderID As String
    Dim TheCompletedState As Boolean
    Dim CompletedBroken As Boolean = False
    Dim TheOrderedState As Boolean
    Dim OrderedBroken As Boolean = False
    Dim TheItemSku As WhlSKU
    Dim ThePK As Integer
    Private ChangesMade As Boolean = False
    Dim theMainForm As MainForm

    Public Sub SetDetailsData(Primary As Integer, OrderID As String, CompletedState As String, AwaitingDeliveryState As String, ItemSku As String, extraInfo As String, creator As MainForm)
        'Primary Key
        ThePK = Primary
        '--------------
        'OrderID
        TotalPanel.Title = OrderID
        theOrderID = OrderID
        '--------------
        'Completed state
        If CompletedState.ToUpper = "TRUE" Then
            TheCompletedState = True
            CompleteBTN.Enabled = False

        ElseIf CompletedState.ToUpper = "FALSE" Then
            TheCompletedState = False

        Else
            MsgBox("Data was recorded incorrectly. Completed state not found.")
            CompletedBroken = True
            CompleteBTN.Enabled = False
        End If
        '--------------
        'Ordered items?
        If AwaitingDeliveryState.ToUpper = "TRUE" Then
            TheOrderedState = True
            OrderedBTN.Enabled = False

        ElseIf AwaitingDeliveryState.ToUpper = "FALSE" Then
            TheOrderedState = False

        Else
            MsgBox("Data was recorded incorrectly. Ordered state not found.")
            OrderedBroken = True
            OrderedBTN.Enabled = False
        End If
        '--------------
        'For sku coll references and such
        theMainForm = creator
        '--------------
        'Item Sku
        'ItemSkuText.Text = ItemSku
        TheItemSku = theMainForm.SkuColl.SearchSKUSReturningSingleSku(ItemSku)
        ItemNameText.Text = TheItemSku.Title.Label
        '--------------
        'Supplier
        SupplierText.Text = TheItemSku.Suppliers(0).Name
        SuppCodeText.Text = TheItemSku.Suppliers(0).ReOrderCode

        ExtraInfoText.Text = extraInfo

    End Sub

    Private Sub CompleteBTN_Click(sender As Object, e As EventArgs) Handles CompleteBTN.Click
        If TheCompletedState = True Then
            If MsgBox("Are you sure you want to change this back to incomplete?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                TheCompletedState = False
                CompleteBTN.Text = "Complete"
            End If
        ElseIf TheCompletedState = False Then
            If MsgBox("Are you sure you want to mark this item as complete? You cannot change this back after pressing the save button.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                TheCompletedState = True
                CompleteBTN.Text = "Change back"
            End If
            ChangesMade = True
        Reminder.Visible = True
        End If
    End Sub

    Private Sub OrderedBTN_Click(sender As Object, e As EventArgs) Handles OrderedBTN.Click
        If TheOrderedState = True Then
            If MsgBox("Are you sure you want to change this back to unordered?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                TheOrderedState = False
                OrderedBTN.Text = "Ordered"
            End If
        ElseIf TheOrderedState = False Then
            If MsgBox("Are you sure you want to mark this item as ordered? You cannot change this back after pressing the save button.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                TheOrderedState = True
                OrderedBTN.Text = "Change back"
            End If
        End If
        ChangesMade = True
        Reminder.Visible = True
    End Sub

    Public Function GetChangesMade() As Boolean
        Return ChangesMade
    End Function

    Public Sub SaveOrder()
        'Using an update query to change data in the database rather than add a new row. This will keep things making sense, we don't wanna have duplicates of the same issue
        Dim InputQuery As String = "UPDATE whldata.oversoldorders SET CompletedState='" + TheCompletedState.ToString.ToUpper + "', AwaitingStock='" + TheOrderedState.ToString.ToUpper + "' WHERE ID='" + ThePK.ToString + "';"

        MySql.insertupdate(InputQuery)
    End Sub

    Private Sub MoreInfoBTN_Click(sender As Object, e As EventArgs) Handles MoreInfoBTN.Click
        theMainForm.LoadOrderDetails(theOrderID)
    End Sub

    Private Sub ExtraInfoBtn_Click(sender As Object, e As EventArgs) Handles ExtraInfoBtn.Click
        If ExtraInfoText.Text = "" Then
            MsgBox("Please give information as to why the item cannot be ordered.")
        Else
            Dim extraInfo As String = ExtraInfoText.Text

            Dim InputQuery As String = "UPDATE whldata.oversoldorders SET ExtraInfo='" + extraInfo + "' WHERE ID='" + ThePK.ToString + "';"

        End If
    End Sub
End Class
