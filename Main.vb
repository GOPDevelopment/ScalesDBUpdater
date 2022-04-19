Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationManager

Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'load search type items and set first to default
        cmbSearchType.Items.Add("Product Code")
        cmbSearchType.Items.Add("Product Description")
        cmbSearchType.Items.Add("Label Name")
        cmbSearchType.SelectedIndex = 0

        'load scale types from available list
        Dim oConn As New SqlConnection
        oConn = ConnectSQL(AppSettings("ConnectionString"))
        Dim cmd As New SqlCommand
        cmd = New SqlClient.SqlCommand("SELECT distinct ScaleType FROM ProductInfo Order By ScaleType", oConn)
        Dim rdr As SqlClient.SqlDataReader
        rdr = cmd.ExecuteReader
        If rdr.HasRows Then
            While rdr.Read()
                cmbScaleOptions.Items.Add(rdr("ScaleType"))
            End While
        End If
        cmd.Dispose()
        oConn.Dispose()
        cmbScaleOptions.SelectedIndex = 0

        rdoUpdate.Checked = True
        rdoAddNew.Checked = False

        btnAddNew.Enabled = False



    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        lstSearchResults.Items.Clear()


        'fill list box
        Dim oConn As New SqlConnection
        oConn = ConnectSQL(AppSettings("ConnectionString"))

        'build where statement
        Dim sWhere As String = ""
        If txtSearchText.Text = "" Then
            Select Case cmbSearchType.Text
                Case "Product Code"
                    sWhere = " ProductCode like '%' "
                Case "Product Description"
                    sWhere = " ProductDesc like '%' "
                Case "Label Name"
                    sWhere = " Label like '%' "
                Case Else
                    'default to description
                    sWhere = " ProductDesc like '%' "
            End Select
        Else
            Select Case cmbSearchType.Text
                Case "Product Code"
                    sWhere = " ProductCode like '%" & txtSearchText.Text & "%' "
                Case "Product Description"
                    sWhere = " ProductDesc like '%" & txtSearchText.Text & "%' "
                Case "Label Name"
                    sWhere = " Label like '%" & txtSearchText.Text & "%' "
                Case Else
                    'default to description
                    sWhere = " ProductDesc like '%" & txtSearchText.Text & "%' "
            End Select
        End If

        If cmbScaleOptions.Text <> "" Then
            sWhere = sWhere & " and ScaleType = '" & cmbScaleOptions.Text & "' "
        End If

        Dim cmd As New SqlCommand
        cmd = New SqlClient.SqlCommand("SELECT ProductCode, ProductDesc FROM ProductInfo WHERE " & sWhere & " Order By ProductCode", oConn)
        Dim rdr As SqlClient.SqlDataReader
        rdr = cmd.ExecuteReader
        If rdr.HasRows Then
            While rdr.Read()
                lstSearchResults.Items.Add(rdr("ProductCode") & "-" & rdr("ProductDesc"))
            End While
        Else
            lstSearchResults.Items.Add("No results found")
        End If
        cmd.Dispose()
        oConn.Dispose()

    End Sub

    Private Sub lstSearchResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSearchResults.SelectedIndexChanged
        'fill fields
        Dim oConn As New SqlConnection
        oConn = ConnectSQL(AppSettings("ConnectionString"))
        Dim cmd As New SqlCommand
        Dim getSelectedProductCode As String = lstSearchResults.SelectedItem.ToString.Substring(0, lstSearchResults.SelectedItem.ToString.IndexOf("-"))
        cmd = New SqlClient.SqlCommand("SELECT * FROM ProductInfo WHERE ProductCode = '" & getSelectedProductCode & "' and ScaleType = '" & cmbScaleOptions.Text & "' Order By ProductCode", oConn)
        Dim rdr As SqlClient.SqlDataReader
        rdr = cmd.ExecuteReader
        If rdr.HasRows Then
            While rdr.Read
                lblUUID.Text = rdr("UUID").ToString 'just to hold a place for identifier
                txtScaleType.Text = FixNull(rdr("ScaleType"))
                txtProductCode.Text = FixNull(rdr("ProductCode"))
                txtProductDesc.Text = FixNull(rdr("ProductDesc"))
                txtProductDesc2.Text = FixNull(rdr("ProductDesc2"))
                txtSetWeight.Text = FixNull(rdr("SetWeight"))
                txtProductGrade.Text = FixNull(rdr("ProductGrade"))
                txtProductTare.Text = FixNull(rdr("ProductTare"))
                txtProductTare2.Text = FixNull(rdr("ProductTare2"))
                txtKickoutCount.Text = FixNull(rdr("KickoutCount"))
                txtMinWeight.Text = FixNull(rdr("MinWeight"))
                txtMaxWeight.Text = FixNull(rdr("MaxWeight"))
                txtItemCountPerBox.Text = FixNull(rdr("ItemCountPerBox"))
                txtItemTareEach.Text = FixNull(rdr("ItemTareEach"))
                txtLot.Text = FixNull(rdr("Lot"))
                txtProductType.Text = FixNull(rdr("ProductType"))
                txtAlphaDesc.Text = FixNull(rdr("AlphaDesc"))
                txtTestingDesc.Text = FixNull(rdr("TestingDesc"))
                txtLabel.Text = FixNull(rdr("Label"))
                txtPricePerLb.Text = FixNull(rdr("PricePerLb"))
                txtSellByDate.Text = FixNullDate(rdr("SellByDate"))
                txtKillDate.Text = FixNullDate(rdr("KillDate"))
                txtDiscPerLb.Text = FixNull(rdr("DiscPerLb"))
                txtNormalWeight.Text = FixNull(rdr("NormalWeight"))
            End While

        End If
        cmd.Dispose()
        oConn.Dispose()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'update db
        Try
            Dim bUpdate As Boolean = False

            Dim sSql As String
            If btnSave.Text = "Save" Then
                'check scale type and product code to see if it already exists
                If ScaleProductCodeExists() Then
                    bUpdate = True
                    MsgBox("Product Code for Scale already exists, the info for this code will be updated.", vbOKOnly)
                End If
            Else
                bUpdate = True
            End If


            If bUpdate = True Then
                sSql = "UPDATE ProductInfo
                    SET    ScaleType = @ScaleType, ProductCode = @ProductCode, ProductDesc = @ProductDesc, ProductDesc2 = @ProductDesc2, SetWeight = @SetWeight, ProductGrade = @ProductGrade, 
                           ProductTare = @ProductTare, ProductTare2 = ProductTare2, KickoutCount = @KickoutCount, MinWeight = @MinWeight, MaxWeight = @MaxWeight, ItemCountPerBox = @ItemCountPerBox, 
                           ItemTareEach = @ItemTareEach, Lot = @Lot, ProductType = @ProductType, AlphaDesc = @AlphaDesc, TestingDesc = @TestingDesc, Label = @Label, PricePerLb = @PricePerLb, 
                           SellByDate = @SellByDate, KillDate = @KillDate, DiscPerLb = @DiscPerLb, NormalWeight = @NormalWeight, DateEntered = @DateEntered
                    WHERE UUID = @UUID"
            Else
                sSql = "INSERT INTO ProductInfo (ScaleType, ProductCode, ProductDesc, ProductDesc2, SetWeight, ProductGrade, ProductTare, ProductTare2, KickoutCount, MinWeight, MaxWeight, 
                            ItemCountPerBox, ItemTareEach, Lot, ProductType, AlphaDesc, TestingDesc, Label, PricePerLb, SellByDate, KillDate, DiscPerLb, NormalWeight, DateEntered)
                        VALUES (@ScaleType, @ProductCode, @ProductDesc, @ProductDesc2, @SetWeight, @ProductGrade, @ProductTare, @ProductTare2, @KickoutCount, @MinWeight, @MaxWeight, 
                            @ItemCountPerBox, @ItemTareEach, @Lot, @ProductType, @AlphaDesc, @TestingDesc, @Label, @PricePerLb, @SellByDate, @KillDate, @DiscPerLb, @NormalWeight, @DateEntered)"
            End If


            Dim oConn As New SqlConnection
            oConn = ConnectSQL(AppSettings("ConnectionString"))

            Dim cmd As New SqlCommand
            cmd = New SqlClient.SqlCommand(sSql, oConn)

            If bUpdate Then cmd.Parameters.AddWithValue("@UUID", lblUUID.Text)

            cmd.Parameters.AddWithValue("@ScaleType", txtScaleType.Text)
            cmd.Parameters.AddWithValue("@ProductCode", txtProductCode.Text)
            cmd.Parameters.AddWithValue("@ProductType", txtProductType.Text)
            cmd.Parameters.AddWithValue("@ProductDesc", FixNullString(txtProductDesc.Text))
            cmd.Parameters.AddWithValue("@ProductDesc2", FixNullString(txtProductDesc2.Text))
            cmd.Parameters.AddWithValue("@SetWeight", FixNullDecimal(txtSetWeight.Text))
            cmd.Parameters.AddWithValue("@ProductGrade", FixNullString(txtProductGrade.Text))
            cmd.Parameters.AddWithValue("@ProductTare", FixNullDecimal(txtProductTare.Text))
            cmd.Parameters.AddWithValue("@ProductTare2", FixNullDecimal(txtProductTare2.Text))
            cmd.Parameters.AddWithValue("@KickoutCount", FixNullInteger(txtKickoutCount.Text))
            cmd.Parameters.AddWithValue("@MinWeight", FixNullDecimal(txtMinWeight.Text))
            cmd.Parameters.AddWithValue("@MaxWeight", FixNullDecimal(txtMaxWeight.Text))
            cmd.Parameters.AddWithValue("@ItemCountPerBox", FixNullInteger(txtItemCountPerBox.Text))
            cmd.Parameters.AddWithValue("@ItemTareEach", FixNullDecimal(txtItemTareEach.Text))
            cmd.Parameters.AddWithValue("@Lot", FixNullString(txtLot.Text))
            cmd.Parameters.AddWithValue("@AlphaDesc", FixNullString(txtAlphaDesc.Text))
            cmd.Parameters.AddWithValue("@TestingDesc", FixNullString(txtTestingDesc.Text))
            cmd.Parameters.AddWithValue("@Label", FixNullString(txtLabel.Text))
            cmd.Parameters.AddWithValue("@PricePerLb", FixNullDecimal(txtPricePerLb.Text))
            cmd.Parameters.AddWithValue("@SellByDate", IIf(CheckDate(txtSellByDate.Text) IsNot Nothing, CheckDate(txtSellByDate.Text), DBNull.Value))
            cmd.Parameters.AddWithValue("@KillDate", IIf(CheckDate(txtKillDate.Text) IsNot Nothing, CheckDate(txtKillDate.Text), DBNull.Value))
            cmd.Parameters.AddWithValue("@DiscPerLb", FixNullDecimal(txtDiscPerLb.Text))
            cmd.Parameters.AddWithValue("@NormalWeight", FixNullDecimal(txtNormalWeight.Text))
            cmd.Parameters.AddWithValue("@DateEntered", Now.ToString("MM/dd/yyyy HH:mm"))

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            'WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Function ScaleProductCodeExists() As Boolean
        Dim bReturn = False
        Dim oConn As New SqlConnection
        oConn = ConnectSQL(AppSettings("ConnectionString"))

        Dim cmd As New SqlCommand
        cmd = New SqlClient.SqlCommand("SELECT * FROM ProductInfo WHERE ScaleType = '" & txtScaleType.Text & "' AND ProductCode = '" & txtProductCode.Text & "'", oConn)
        Dim rdr As SqlClient.SqlDataReader
        rdr = cmd.ExecuteReader

        If rdr.HasRows Then
            bReturn = True
        End If
        cmd.Dispose()
        oConn.Dispose()

        Return bReturn
    End Function

    Private Sub rdoUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles rdoUpdate.CheckedChanged
        btnAddNew.Enabled = False
        If rdoAddNew.Checked Then
            rdoAddNew.Checked = False
            btnAddNew.Enabled = False
        Else
            rdoUpdate.Checked = True
            grbSearch.Enabled = True
            txtScaleType.Enabled = False
            txtProductCode.Enabled = False
            btnSave.Text = "Update"
        End If
    End Sub

    Private Sub rdoAddNew_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAddNew.CheckedChanged
        btnAddNew.Enabled = True
        If rdoUpdate.Checked Then
            rdoUpdate.Checked = False
        Else
            rdoAddNew.Checked = True
            btnAddNew.Enabled = True
            grbSearch.Enabled = False
            txtScaleType.Enabled = True
            txtProductCode.Enabled = True
            btnSave.Text = "Save"
            ClearAllFields()
        End If
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        'clear boxes
        ClearAllFields
    End Sub
    Private Sub ClearAllFields()
        lblUUID.Text = ""
        txtScaleType.Text = ""
        txtProductCode.Text = ""
        txtProductDesc.Text = ""
        txtProductDesc2.Text = ""
        txtSetWeight.Text = ""
        txtProductGrade.Text = ""
        txtProductTare.Text = ""
        txtProductTare2.Text = ""
        txtKickoutCount.Text = ""
        txtMinWeight.Text = ""
        txtMaxWeight.Text = ""
        txtItemCountPerBox.Text = ""
        txtItemTareEach.Text = ""
        txtLot.Text = ""
        txtProductType.Text = ""
        txtAlphaDesc.Text = ""
        txtTestingDesc.Text = ""
        txtLabel.Text = ""
        txtPricePerLb.Text = ""
        txtSellByDate.Text = ""
        txtKillDate.Text = ""
        txtDiscPerLb.Text = ""
        txtNormalWeight.Text = ""
    End Sub











    Private Function ConnectSQL(db As String) As SqlConnection
        Dim myConn As SqlConnection
        myConn = New SqlConnection(db)
        myConn.Open()
        Return myConn
    End Function
End Class
