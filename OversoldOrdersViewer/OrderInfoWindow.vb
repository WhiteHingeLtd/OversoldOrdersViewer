Imports WHLClasses

Public Class OrderInfoWindow

    Dim CurrentItemNumber As Integer
    Dim TotalItemCount As Integer
    Dim ItemList As List(Of LinnworksAPI.OrderItem)
    Dim theMainWindow As MainForm

    Public Sub SetMainWindow(mainwin As MainForm)
        theMainWindow = mainwin
    End Sub

    'Use once, on loading the window
    Public Sub SetOrderData(OrderIDNumber As String, DateOrderDownloaded As DateTime, FirstSecondClass As String)
        OrderIDText.Text = OrderIDNumber
        DateDownloadedText.Text = DateOrderDownloaded.ToString
        PostClassText.Text = FirstSecondClass
    End Sub

    'Use once, on loading the window
    Public Sub SetCustomerData(CustomerName As String, Address1 As String, Address2 As String, Address3 As String, CustomerPostCode As String)
        'Dim CustomerName As String
        'Dim Address1 As String
        'Dim Address2 As String
        'Dim Address3 As String
        'Dim CustomerPostCode As String


        CNameText.Text = CustomerName
        CAd1Text.Text = Address1
        CAd2Text.Text = Address2
        CAd3Text.Text = Address3
        CPostCodeText.Text = CustomerPostCode
    End Sub

    'Use once, on loading the window
    Public Sub SetUpItemListData(ListOfItems As List(Of LinnworksAPI.OrderItem))
        ItemList = ListOfItems
        If ItemList.Count > 0 Then
            CurrentItemNumber = 0
            TotalItemCount = ItemList.Count - 1 'If we have one item in the list, this will now be 0. Let's keep things uniform with the system's weird 1=0 thing
            SetItemData(ItemList(0))

            SelectedItemText.Text = (CurrentItemNumber + 1).ToString
            ItemsInOrderText.Text = ItemList.Count.ToString
        End If
    End Sub

    'Use whenever a new item is loaded - this will happen on load, and on opening new items in the order
    Public Sub SetItemData(NewItem As LinnworksAPI.OrderItem)
        ItemNameText.Text = NewItem.Title
        ItemSkuText.Text = NewItem.SKU
        Dim theitemsku As WhlSKU = theMainWindow.SkuColl.SearchSKUS(NewItem.SKU)(0)
        ItemLocationText.Text = theitemsku.Locations(0).LocalLocationName
        ItemAmountText.Text = NewItem.Quantity.ToString + " packs of " + theitemsku.PackSize.ToString 'NewItem.OrderQuantity.ToString + " packs of " + NewItem.PackQuantity.ToString
        ItemDistText.Text = theitemsku.Title.Distinguish
    End Sub

    Private Sub PreviousItemBTN_Click(sender As Object, e As EventArgs) Handles PreviousItemBTN.Click
        'Reduce active item by 1, refresh item panel
        If CurrentItemNumber > 0 Then
            Dim SelectedNumber As Integer = CurrentItemNumber - 1
            If Not ItemList(SelectedNumber) Is Nothing Then
                'So we have verified that the item exists. Get its data.
                CurrentItemNumber = SelectedNumber
                SetItemData(ItemList(CurrentItemNumber))

                SelectedItemText.Text = (CurrentItemNumber + 1).ToString
            Else
                MsgBox("An error occurred. The current number was higher than 0, but going down the list led to a nonexistent item.")
            End If

        Else
            MsgBox("There are no more items before this one")
        End If
    End Sub

    Private Sub NextItemBTN_Click(sender As Object, e As EventArgs) Handles NextItemBTN.Click
        'Increase active item by 1, refresh item panel
        If CurrentItemNumber < TotalItemCount Then
            Dim SelectedNumber As Integer = CurrentItemNumber + 1
            If Not ItemList(SelectedNumber) Is Nothing Then
                'So we have verified that the item exists. Get its data.
                CurrentItemNumber = SelectedNumber
                SetItemData(ItemList(CurrentItemNumber))

                SelectedItemText.Text = CurrentItemNumber.ToString
            Else
                MsgBox("An error occurred. The current number was less than the acquired maximum, but going up the list led to a nonexistent item.")
            End If

        Else
            MsgBox("There are no more items after this one")
        End If
    End Sub
End Class