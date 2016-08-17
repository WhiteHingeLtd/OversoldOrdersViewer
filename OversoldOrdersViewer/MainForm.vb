Imports WHLClasses
Imports WHLClasses.Linnworks.Orders
Imports WHLClasses.Orders

Public Class MainForm

    Public SkuColl As SkuCollection
    Dim Loader As New GenericDataController
    Dim SKULoader As New WHLClasses.SkusDataController
    Dim Orddef As WHLClasses.Orders.OrderDefinition = Nothing

    Private Sub LoadTheProgram() Handles MyBase.Load
        'RefreshBTN_Click()
        InfoText.Text = "This list will always display unprocessed oversold orders"
    End Sub

    Private Sub BootTimerTick() Handles BootTimer.Tick
        BootTimer.Enabled = False
        DisableButtons()
        RefreshBTN_Click()
    End Sub

    Private Function SkuCollCheck() As Boolean
        If SkuColl Is Nothing Then
            InfoText.Text = "Please wait while the program loads a sku collection."
            Application.DoEvents()
            SkuColl = Loader.SmartSkuCollLoad(True)
            Application.DoEvents()
            RefreshBTN.Text = "Refresh List"
            EnableButtons()
            Return True
        Else
            Return True
        End If
        Return False
    End Function

    Public Sub LoadOrderDetails(OrderID As String)
        'Lets find our order
        Dim RequestedOrder As Linnworks.Orders.ExtendedOrder = Nothing
        Dim theOrddefOrder As Order = Nothing
        'Dim Orddef As WHLClasses.Orders.OrderDefinition = Nothing
        Dim tryPast As Boolean = False
        Dim tryPastExtraMsg As String = ""
        Try
            RequestedOrder = Loader.LoadOrdex("T:\AppData\Orders\" + OrderID + ".ordex")
            If Orddef Is Nothing Then
                Orddef = Loader.LoadOrddef("T:\AppData\Orders\.orddef", True)
            End If
            theOrddefOrder = FindOrderIdInDefinition(OrderID)
        Catch ex As Exception
            tryPast = True
            tryPastExtraMsg = ex.Message
        End Try

        If tryPast Then
            Try
                Dim listOfFiles As List(Of String) = My.Computer.FileSystem.GetFiles("T:\AppData\Orders\Past\", FileIO.SearchOption.SearchAllSubDirectories, OrderID + ".ordex").ToList
                If listOfFiles.Count > 0 Then
                    RequestedOrder = Loader.LoadOrdex(listOfFiles(0))
                    If Orddef Is Nothing Then
                        Orddef = Loader.LoadOrddef("T:\AppData\Orders\.orddef", True)
                    End If
                    theOrddefOrder = FindOrderIdInDefinition(OrderID)
                Else
                    MsgBox("Order not found in current or past folders")
                End If

            Catch ex As Exception
                MsgBox("Load Failed:" + vbNewLine + vbNewLine + tryPastExtraMsg + vbNewLine + vbNewLine + ex.Message)
            End Try
        End If

        If Not RequestedOrder Is Nothing And Not Orddef Is Nothing Then

            'We have our order, now we get our order data, customer data, and items from it, then fill the data in the window.
            Dim newInfoWindow As New OrderInfoWindow
            newInfoWindow.SetMainWindow(Me)

            'Order Stuff
            Dim PostService As String = RequestedOrder.LinnOpenOrder.ShippingInfo.PostalServiceName
            newInfoWindow.SetOrderData(OrderID, RequestedOrder.Downloaded, PostService)

            'Customer Stuff
            newInfoWindow.SetCustomerData(RequestedOrder.LinnOpenOrder.CustomerInfo.Address.FullName, RequestedOrder.LinnOpenOrder.CustomerInfo.Address.Address1,
                                          RequestedOrder.LinnOpenOrder.CustomerInfo.Address.Address2, RequestedOrder.LinnOpenOrder.CustomerInfo.Address.Address3,
                                          RequestedOrder.LinnOpenOrder.CustomerInfo.Address.PostCode)

            'Item Stuff
            Dim aTemporaryListOfItems As New List(Of LinnworksAPI.OrderItem)
            For Each itemInOrder As LinnworksAPI.OrderItem In RequestedOrder.LinnOpenOrder.Items
                aTemporaryListOfItems.Add(itemInOrder)
            Next
            If Not aTemporaryListOfItems Is Nothing Then

                newInfoWindow.SetUpItemListData(aTemporaryListOfItems)
            End If
            newInfoWindow.Show()
        End If

    End Sub

    Private Function FindOrderIdInDefinition(OrderId As String) As Order
        For Each item As Order In Orddef
            If item.OrderId = OrderId Then
                Return item
            End If
        Next
        Return Nothing
    End Function

    Private Sub RefreshBTN_Click() Handles RefreshBTN.Click
        If SkuCollCheck() Then

            OversoldList.Controls.Clear()
            'We want to load all of the items in the oversold database and create an oversolddetails object for each one, then add that to the list view object
            Dim oversolds As ArrayList
            Dim displayText As String = ""
            If Not CompleteCheck.Checked And Not OrderedCheck.Checked Then
                oversolds = MySql.SelectData("SELECT * FROM whldata.oversoldorders WHERE (CompletedState='FALSE' AND AwaitingStock='FALSE');")
                displayText = "New oversold orders: "
            ElseIf Not CompleteCheck.Checked And OrderedCheck.Checked Then
                oversolds = MySql.SelectData("SELECT * FROM whldata.oversoldorders WHERE CompletedState='FALSE';")
                displayText = "Oversold orders, including items already ordered: "
            ElseIf CompleteCheck.Checked Then
                oversolds = MySql.SelectData("SELECT * FROM whldata.oversoldorders;")
                displayText = "All oversold orders, including items already completed: "
            End If

            If oversolds Is Nothing Then
                MsgBox("It seems something broke. Please tell the developer that the database couldn't collect data while the complete checkbox was " + CompleteCheck.Checked.ToString + " and the ordered checkbox was " + OrderedCheck.Checked.ToString + ".")
            Else
                For Each oversolditem As ArrayList In oversolds
                    'So we have items in the list. Now we set up OversoldDetails objects.
                    Dim theNewOversoldItem As New OversoldDetails
                    theNewOversoldItem.SetDetailsData(oversolditem(0), oversolditem(1), oversolditem(2), oversolditem(3), oversolditem(4), oversolditem(6), Me)
                    OversoldList.Controls.Add(theNewOversoldItem)
                Next
                displayText += oversolds.Count.ToString
                InfoText.Text = displayText
            End If
        Else
            InfoText.Text = "Sku collection didn't load. To try again, click the retry button."
            RefreshBTN.Text = "Retry loading Sku Collection"
            RefreshBTN.Enabled = True
        End If
    End Sub

    Private Sub SaveBTN_Click(sender As Object, e As EventArgs) Handles SaveBTN.Click
        'We want to get each oversolddetails object in the list view and run its save function, provided it has been changed.
        If MsgBox("Are you sure you want to save?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If OversoldList.Controls.Count > 0 Then
                InfoText.Text = "Depending on how many items were saved, this may take a while."
                Application.DoEvents()
                Try
                    For Each oversoldItem As OversoldDetails In OversoldList.Controls
                        If oversoldItem.GetChangesMade Then
                            oversoldItem.SaveOrder()
                        End If
                    Next
                    InfoText.Text = "Items saved successfully."
                Catch ex As Exception
                    MsgBox(ex.Message)
                    InfoText.Text = "Some items may not have saved correctly."
                End Try
            End If
        End If
    End Sub

    Private Sub CompleteCheck_CheckedChanged(sender As Object, e As EventArgs) Handles CompleteCheck.CheckedChanged
        If CompleteCheck.Checked Then
            OrderedCheck.Checked = True
        End If
    End Sub

    Private Sub OrderedCheck_CheckedChanged(sender As Object, e As EventArgs) Handles OrderedCheck.CheckedChanged
        If Not OrderedCheck.Checked Then
            CompleteCheck.Checked = False
        End If
    End Sub

    Private Sub GetEmployeeStats() Handles GetUserInfoBtn.Click
        'First, make 2 lists of arrays. Both will be names, followed by amounts. - a list of pickers and items picked, and a list of packers and items packed.
        If Orddef Is Nothing Then
            Try
                Orddef = Loader.LoadOrddef("T:\AppData\Orders\.orddef")
            Catch ioex As System.IO.IOException
                MsgBox("The Orddef file was busy. Try again in a moment.")
            End Try
        End If
        If Not Orddef Is Nothing Then
            DisableButtons()
            InfoText.Text = "Loading warehouse stat lists. Please wait."
            Try
                WarehouseStatLists()
            Catch ex As Exception
                InfoText.Text = "An error occured in loading warehouse stat lists."
            End Try
        End If
    End Sub

    Private Sub EnableButtons()
        'RefreshBTN.Enabled = True
        'SaveBTN.Enabled = True
        'GetUserInfoBtn.Enabled = True

        Me.Enabled = True
    End Sub

    Private Sub DisableButtons()
        'RefreshBTN.Enabled = False
        'SaveBTN.Enabled = False
        'GetUserInfoBtn.Enabled = False

        Me.Enabled = False
    End Sub

    Dim Emps As New EmployeeCollection

    Private Sub WarehouseStatLists()
        Application.DoEvents()
        Dim pickingEmps As New Dictionary(Of Integer, Integer)
        Dim packingEmps As New Dictionary(Of Integer, Integer)
        Dim startingNumber As Integer = 0
        'Set up employee lists
        For Each emp As Employee In Emps.Employees
            If emp.Visible Then
                pickingEmps.Add(emp.PayrollId, startingNumber)
                packingEmps.Add(emp.PayrollId, startingNumber)
            End If
        Next

        'For every order
        For Each order As Order In Orddef
            Try
                If order.LastUpdateTime >= Today Then
                    Dim tempOrder As ExtendedOrder = Loader.LoadOrdex(order.Filename)
                    'Check each previous state for packed or picked. We then know exactly how many times a person picked / packed an item.
                    For Each prevstate As PreviousState In tempOrder.PreviousStates


                        'If picked
                        If prevstate.State = OrderStatus._Picked And Not prevstate.UserId = 0 Then
                            'Get employee ID, get the employee from the ID, and check if their name is in the PICKING list. If not, add it.
                            pickingEmps(prevstate.UserId) += 1
                            'If packed
                        ElseIf prevstate.State = OrderStatus._Packed And Not prevstate.UserId = 0 Then
                            'Get employee ID, get the employee from the ID, And check if their name Is in the PACKING list. If Not, add it.
                            packingEmps(prevstate.UserId) += 1
                        End If
                    Next
                End If
            Catch nre As NullReferenceException

            End Try
        Next
        Dim SortedPickingEmps As List(Of KeyValuePair(Of Integer, Integer)) = pickingEmps.ToList.OrderByDescending(Function(x) x.Value).ToList
        Dim SortedPackingEmps As List(Of KeyValuePair(Of Integer, Integer)) = packingEmps.ToList.OrderByDescending(Function(x) x.Value).ToList

        'After the for loops end, and the lists are complete, set up the window and display the info.
        SetUpEmployeeStatLists(SortedPickingEmps, SortedPackingEmps)
    End Sub

    Private Sub SetUpEmployeeStatLists(pickingEmps As List(Of KeyValuePair(Of Integer, Integer)), packingEmps As List(Of KeyValuePair(Of Integer, Integer)))
        'Set up a region of the control window / make a new window to appear and display this information.
        Dim endOfDayWindow As New UserInfoWindow

        endOfDayWindow.PopulateTables(pickingEmps, packingEmps, Emps)
        endOfDayWindow.Show()

        EnableButtons()
        InfoText.Text = "Employee stats loaded successfully."
    End Sub

    Private Sub GetEmployeeStats(sender As Object, e As EventArgs) Handles GetUserInfoBtn.Click

    End Sub

End Class
