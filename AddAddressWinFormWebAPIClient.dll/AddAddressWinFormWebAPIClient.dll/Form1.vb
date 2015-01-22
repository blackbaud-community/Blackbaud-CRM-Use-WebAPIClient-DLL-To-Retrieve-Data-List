Imports Blackbaud.AppFx.Constituent.Catalog.WebApiClient
Imports Blackbaud.AppFx.WebAPI

Public Class Form1
    Dim ConstituentID As String
    Dim ServiceProvider As AppFxWebServiceProvider

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Initialize()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ResetForm()
        RetrieveConstituent()
        RetrieveAddress()
        EvalAddressDisplay()
    End Sub

    Private Sub btnAddAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAddress.Click
        'Create a new form data object
        Dim AddressAddForm2Data As AddForms.Address.AddressAddForm2Data

        'Load defaults via LoadData
        AddressAddForm2Data = AddForms.Address.AddressAddForm2.LoadData(ServiceProvider, ConstituentID)

        'Update data from control on the UI
        AddressAddForm2Data.ADDRESSBLOCK = Me.txtAddress.Text.ToString
        If Me.cboState.SelectedIndex = -1 Then
        Else
            AddressAddForm2Data.STATEID = New System.Guid(CType(Me.cboState.SelectedItem, SimpleState).StateID)
        End If

        If Me.cboAddressType.SelectedIndex = -1 Then
        Else
            AddressAddForm2Data.ADDRESSTYPECODEID = CType(Me.cboAddressType.SelectedItem, SimpleAddressType).AddressType
        End If


        AddressAddForm2Data.Save(ServiceProvider)
        RetrieveAddress()
        EvalAddressDisplay()
    End Sub

    Private Sub txtAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddress.TextChanged
        Me.btnAddAddress.Enabled = EvalAddressCriteriaDisplay()
    End Sub

    Private Sub btnDeleteAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteAddress.Click
        Try
            If DataGridViewAddress.RowCount = 0 Then

            ElseIf DataGridViewAddress.RowCount > 0 Then

                If DataGridViewAddress.SelectedRows.Count > 0 Then
                    For Each Row As Windows.Forms.DataGridViewRow In DataGridViewAddress.SelectedRows
                        RecordOperations.Address.AddressDelete.ExecuteOperation(ServiceProvider, Row.Cells(0).Value.ToString)
                    Next
                End If

            End If

        Catch ex As Blackbaud.AppFx.WebAPI.AppFxWebServiceException
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Primary Address")
        Catch ex As Exception
           
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error Deleting Address")
        Finally
            RetrieveAddress()
            EvalAddressDisplay()
        End Try

    End Sub

#Region "Helper Functions"
    Private Sub Initialize()

        ServiceProvider = New AppFxWebServiceProvider("<provide appfxwebservice.asmx url>", _
                                                     "<provide database key name>", _
                                                     "<provide a name for your client app>")
        ServiceProvider.Credentials = System.Net.CredentialCache.DefaultCredentials

        Me.btnSearch.Enabled = EvalSearchCriteriaDisplay()

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Initialize States
        'Using the GUID that identifies the State Abbreviation List (Simple Data List_
        'Retrieve a listing of states and populate the combo box with a key, value pair.
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim States() As SimpleDataListsData
        States = SimpleDataLists.LoadSimpleDataList(ServiceProvider, New System.Guid("7fa91401-596c-4f7c-936d-6e41683121d7"))

        For Each State As SimpleDataListsData In States
            Me.cboState.Items.Add(New SimpleState(State.Value, State.Label))
        Next

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Initialize Address Types
        'Grab a list of address types from the AddressType code table
        'Populate the address types combo box with a key, value pair
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim AddressTypes() As Blackbaud.AppFx.WebAPI.CodeTableEntryItem
        AddressTypes = CodeTables.AddressType.GetList(ServiceProvider, CodeTableEntryIncludeOption.IncludeActiveOnly)

        For Each AddressType As CodeTableEntryItem In AddressTypes
            Me.cboAddressType.Items.Add(New SimpleAddressType(AddressType.EntryID, AddressType.Description))
        Next
    End Sub

    Private Sub ResetForm()
        Me.txtAddress.Text = ""
        Me.cboAddressType.SelectedIndex = -1
        Me.cboState.SelectedIndex = -1
        ConstituentID = Nothing
        Me.DataGridViewAddress.DataSource = Nothing

    End Sub

    Private Function EvalSearchCriteriaDisplay() As Boolean
        Return CBool(Len(Me.txtLookupID.Text.ToString) > 0)
    End Function

    Private Function EvalAddressCriteriaDisplay() As Boolean
        Dim AddressLength As Integer = Me.txtAddress.TextLength
        Dim SearchResults As Integer = Me.txtSearchResults.TextLength

        If AddressLength > 0 And SearchResults > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub EvalAddressDisplay()
        If DataGridViewAddress.RowCount = 0 Then
            Me.btnDeleteAddress.Enabled = False
        ElseIf DataGridViewAddress.RowCount > 0 Then

            DataGridViewAddress.Rows(0).Selected = True
            Me.btnDeleteAddress.Enabled = True
        End If
    End Sub

    Private Sub RetrieveConstituent()
        Dim SearchFilter As New SearchLists.Constituent.IndividualSearchFilterData
        Dim SearchResultsIDs As String()
        SearchFilter.LOOKUPID = Me.txtLookupID.Text.ToString
        SearchFilter.INCLUDEINDIVIDUALS = True
        SearchFilter.INCLUDEGROUPS = False
        SearchFilter.INCLUDEINACTIVE = False
        SearchFilter.INCLUDENONCONSTITUENTRECORDS = False
        SearchFilter.INCLUDEDECEASED = False
        SearchFilter.INCLUDEORGANIZATIONS = False

        SearchResultsIDs = SearchLists.Constituent.IndividualSearch.GetIDs(ServiceProvider, _
                                                                           SearchFilter)
        If SearchResultsIDs.Count = 0 Then
            Me.txtSearchResults.Text = "Constituent Not Found"
            Return
        ElseIf SearchResultsIDs.Count > 1 Then
            Me.txtSearchResults.Text = "Too Many Constituents Found"
            Return
        ElseIf SearchResultsIDs.Count = 1 Then
            ConstituentID = SearchResultsIDs(0).ToString
        End If

        Dim ConstituentNameData As ViewForms.Constituent.ConstituentFirstNameLastNameViewFormData
        ConstituentNameData = ViewForms.Constituent.ConstituentFirstNameLastNameViewForm.LoadData(ServiceProvider, ConstituentID)

        Me.txtSearchResults.Text = ConstituentNameData.FIRSTNAME & " " & ConstituentNameData.KEYNAME
    End Sub

    Private Sub RetrieveAddress()
        If ConstituentID = Nothing Then
            DataGridViewAddress.DataSource = Nothing
            DataGridViewAddress.Refresh()
        Else
            Dim AddressItems() As DataLists.Constituent.ContactInformationListRow
            Dim Filter As New DataLists.Constituent.ContactInformationListFilterData

            Filter.INCLUDEADDRESSES = True
            Filter.INCLUDEFORMER = True
            Filter.INCLUDEEMAIL = False
            Filter.INCLUDEPHONES = False

            AddressItems = DataLists.Constituent.ContactInformationList.GetRows(ServiceProvider, ConstituentID, Filter)

            ' Fill in the data grid with a List
            Dim list = New List(Of Address)
            For Each AddressItem As DataLists.Constituent.ContactInformationListRow In AddressItems
                list.Add(New Address(AddressItem.ID.ToString, AddressItem.CONTACTINFO, AddressItem.TYPE))
            Next

            DataGridViewAddress.DataSource = list
            DataGridViewAddress.Columns(0).Visible = False
            DataGridViewAddress.Columns(1).Width = 210
            DataGridViewAddress.Columns(2).Width = 115
            DataGridViewAddress.Refresh()
        End If
    End Sub

    

#End Region

    
End Class

#Region "Helper Classes for States and Addresses"

Public Class SimpleState
    Private _key As Object ' Guid for the state
    Private _value As String ' State Abbrev
    Public Sub New(ByVal StateGUID As Object, ByVal StateAbbrev As String)
        _key = StateGUID
        _value = StateAbbrev
    End Sub

    Public ReadOnly Property StateID() As String
        Get
            Return _key.ToString
        End Get
    End Property

    Public ReadOnly Property StateAbbrev() As String
        Get
            Return _value
        End Get
    End Property


    Public Overrides Function ToString() As String
        Return _value
    End Function

End Class

Public Class SimpleAddressType
    Private _key As Object ' Guid for the address type
    Private _value As String ' address type description
    Public Sub New(ByVal Key As Object, ByVal Value As String)
        _key = Key
        _value = Value
    End Sub

    Public ReadOnly Property AddressType() As System.Guid
        Get
            Return New System.Guid(_key.ToString)
        End Get
    End Property

    Public ReadOnly Property AddressTypeDesc() As String
        Get
            Return _value
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return _value
    End Function

End Class

''' <summary>
''' This class contains two properties.
''' </summary>
Public Class Address
    Dim _StreetAddress As String
    Dim _AddressTypeDesc As String
    Dim _AddressID As String

    Public Sub New(ByVal AddressID As String, ByVal StreetAddress As String, ByVal AddressTypeDesc As String)
        _AddressID = AddressID
        _StreetAddress = StreetAddress
        _AddressTypeDesc = AddressTypeDesc
    End Sub

    Public ReadOnly Property AddressID() As String
        Get
            Return _AddressID
        End Get
    End Property

    Public ReadOnly Property StreetAddress() As String
        Get
            Return _StreetAddress
        End Get
    End Property

    Public ReadOnly Property AddressTypeDesc() As String
        Get
            Return _AddressTypeDesc
        End Get
    End Property
End Class

#End Region







