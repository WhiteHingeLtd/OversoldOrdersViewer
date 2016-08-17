Imports WHLClasses
Public Class UserInfoWindow
    Public Sub PopulateTables(pickingEmps As List(Of KeyValuePair(Of Integer, Integer)), packingEmps As List(Of KeyValuePair(Of Integer, Integer)), emps As EmployeeCollection)
        PickingTable.Rows.Clear()
        PackingTable.Rows.Clear()

        For Each pickingrecord As KeyValuePair(Of Integer, Integer) In pickingEmps
            Dim empName As String = emps.FindEmployeeByID(pickingrecord.Key).FullName
            Dim empStats As Integer = pickingrecord.Value

            If empStats > 0 Then
                PickingTable.Rows.Add({empName, empStats.ToString})
            End If
        Next

        For Each packingrecord As KeyValuePair(Of Integer, Integer) In packingEmps
            Dim empName As String = emps.FindEmployeeByID(packingrecord.Key).FullName
            Dim empStats As Integer = packingrecord.Value

            If empStats > 0 Then
                PackingTable.Rows.Add({empName, empStats.ToString})
            End If
        Next
    End Sub
End Class