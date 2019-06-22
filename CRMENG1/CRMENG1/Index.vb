Imports System.IO
Imports Microsoft.Office.Interop
Imports System.Data.OleDb
Public Class Index


    Private Sub cbcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbcode.SelectedIndexChanged

        Try
            Dim Trove As Boolean = False
            'Dim code As String = InputBox(" Saisir cin a rechercher ")
            For i As Integer = 0 To ds.Tables("plan").Rows.Count - 1
                If ds.Tables("plan").Rows(i)(0) = cbcode.Text Then
                    cbcode.Text = ds.Tables("plan").Rows(i)(0)
                    rtline.Text = ds.Tables("plan").Rows(i)(1)

                    Trove = True

                End If
            Next
            If Trove = False Then
                MsgBox("n'exists pas")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
                'MsgBox("bien reussi")
                da.Fill(ds, "plan")
                da1.Fill(ds1, "Fornisseur")
                Cn.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        '----------------------------
        'txtguercflePV.Text = Date.Now
        txtguercifle.Text = Date.Now
        TxtguercifleNOTIFICATION.Text = Date.Now
        txtguercifleOrder.Text = Date.Now
        '----------------------------
        'Try
        '    If Cn1.State = ConnectionState.Closed Then
        '        Cn1.Open()
        '        MsgBox("bien reussi")
        '        da1.Fill(ds1, "Fornisseur")
        '        Cn1.Close()
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub


    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBPetat.Click
        TXTNETATA.Text = txtmarchéN.Text
        RTOBJ.Text = RTBobjet.Text
        rtli.Text = rtline.Text
        txtcode.Text = cbcode.Text
        Label92.Text = CBVILLE.Text
        Label93.Text = MSKDATE.Text
        txtmo.Text = TxtTTC.Text
        txttitulaireMarcheETAT.Text = cbAM.Text
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbvisa.CheckedChanged
        If rbvisa.Checked = True Then
            Textvisaa.Visible = True
        Else
            Textvisaa.Visible = False

        End If
    End Sub

    Private Sub rbapprobation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbapprobation.CheckedChanged
        If rbapprobation.Checked Then
            Textapprobation.Visible = True
        Else
            Textapprobation.Visible = False
        End If
    End Sub

    Private Sub BTNOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNOK.Click
        Try
            Dim oWord As New Word.Application
            Dim oDoc As Word.Document
            oDoc = oWord.Documents.Open("D:\parprasse du marché.doc")
            oDoc.Bookmarks.Item("marcheN").Range.Text = txtmarchéN.Text
            oDoc.Bookmarks("attm").Range.Text = cbAM.Text
            oDoc.Bookmarks("objetm").Range.Text = RTBobjet.Text
            oDoc.Bookmarks("Modepm").Range.Text = cbMPM.Text
            oDoc.Bookmarks("assurer").Range.Text = RTBobjet.Text
            oDoc.Bookmarks("HT").Range.Text = TXTMHT.Text
            oDoc.Bookmarks("tva").Range.Text = txtTVA.Text
            oDoc.Bookmarks("ttc").Range.Text = TxtTTC.Text
            oDoc.Bookmarks("line").Range.Text = rtline.Text
            oDoc.Bookmarks("code").Range.Text = cbcode.Text
            oDoc.Bookmarks("ville").Range.Text = CBVILLE.Text
            oDoc.Bookmarks("date").Range.Text = MSKDATE.Text
            oWord.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub TabPage10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage10.Click
        Txtmarcheatteste.Text = txtmarchéN.Text
        Txtvilleattes.Text = CBVILLE.Text
        txtdateattes.Text = MSKDATE.Text
        Txtnom1att.Text = txtnom1PV.Text
        txtnom2att.Text = txtnom2PV.Text
        txtnom3att.Text = txtnom3PV.Text
        txtfonct1att.Text = txtfonction1PV.Text
        txtfonction2att.Text = txtfonction2PV.Text
        txtfonction3att.Text = txtfonction3PV.Text

    End Sub

    Private Sub TabPage4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage4.Click
        Txtmarchebullet.Text = txtmarchéN.Text
        rtobjetmarbulletin.Text = RTBobjet.Text
        txtguercifle.Text = Date.Now
    End Sub

    Private Sub Lbltotaldroitbullrtin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbltotaldroitbullrtin.Click
        Lbltotaldroitbullrtin.Text = Val(Txtnbfebulletin.Text) * Val(Txttarifbulletin.Text)
    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBPnotification.Click
        LBLnmarchN.Text = txtmarchéN.Text
        txtobjetmarcheNOTI.Text = RTBobjet.Text
        txtnomsocieteN.Text = cbAM.Text
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        'Try
        '    Dim Trove As Boolean = False
        '    'Dim code As String = InputBox(" Saisir cin a rechercher ")
        '    For i As Integer = 0 To ds1.Tables("Fornisseur").Rows.Count - 1
        '        If ds1.Tables("Fornisseur").Rows(i)(1) = cbAM.Text Then
        '            cbAM.Text = ds1.Tables("Fornisseur").Rows(i)(1)
        '            txtattributaireDecomp.Text = ds1.Tables("Fornisseur").Rows(i)(1)
        '            txtnomsocieteN.Text = ds1.Tables("Fornisseur").Rows(i)(1)
        '            txtsocietePV.Text = ds1.Tables("Fornisseur").Rows(i)(1)
        '            txtsocietePVD.Text = ds1.Tables("Fornisseur").Rows(i)(1)
        '            txtnomSoOrder.Text = ds1.Tables("Fornisseur").Rows(i)(1)
        '            CBnomdirN.Text = ds1.Tables("Fornisseur").Rows(i)(2)
        '            txtnomdirORDER.Text = ds1.Tables("Fornisseur").Rows(i)(2)
        '            rtadressN.Text = ds1.Tables("Fornisseur").Rows(i)(3)
        '            rtadressDecomp.Text = ds1.Tables("Fornisseur").Rows(i)(3)
        '            rtadresseOrder.Text = ds1.Tables("Fornisseur").Rows(i)(3)
        '            rtadressePV.Text = ds1.Tables("Fornisseur").Rows(i)(3)
        '            txtregestrecom.Text = ds1.Tables("Fornisseur").Rows(i)(4)
        '            txtcnss.Text = ds1.Tables("Fornisseur").Rows(i)(5)
        '            txtcmpt.Text = ds1.Tables("Fornisseur").Rows(i)(6)
        '            txtpatente.Text = ds1.Tables("Fornisseur").Rows(i)(8)
        '            'TextBox8.Text = ds1.Tables("Fornisseur").Rows(i)(9)
        '            'TextBox9.Text = ds1.Tables("Fornisseur").Rows(i)(10)
        '            Trove = True
        '        End If
        '    Next
        '    If Trove = False Then
        '        MsgBox("n'exists pas")
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click
        txtnmarcheDecomp.Text = txtmarchéN.Text
    End Sub


    Private Sub TabPage5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage5.Click
        rtobjetOrder.Text = RTBobjet.Text
        LBLMarcheNOrders.Text = txtmarchéN.Text
        txtguercifleOrder.Text = txtguercifle.Text
        txtNOrder.Text = TXTNETATA.Text
    End Sub

    Private Sub TabPage6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage6.Click
        RTobjetmarPV.Text = RTBobjet.Text
        txtNmarchePV.Text = txtmarchéN.Text
    End Sub

    Private Sub TabPage7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage7.Click
        txtmarcheNPVDE.Text = txtmarchéN.Text
        rtObjetPVD.Text = RTBobjet.Text
        txtnom1pvd.Text = txtnom1PV.Text
        txtnom2pvd.Text = txtnom2PV.Text
        txtnom3pvd.Text = txtnom3PV.Text
        txtfonction1pvd.Text = txtfonction1PV.Text
        txtfonction2pvd.Text = txtfonction2PV.Text
        txtfonction3pvd.Text = txtfonction3PV.Text


    End Sub

    Private Sub cbAM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAM.SelectedIndexChanged
        Try
            Dim Trove As Boolean = False
            'Dim code As String = InputBox(" Saisir cin a rechercher ")
            For i As Integer = 0 To ds1.Tables("Fornisseur").Rows.Count - 1
                If ds1.Tables("Fornisseur").Rows(i)(1) = cbAM.Text Then
                    cbAM.Text = ds1.Tables("Fornisseur").Rows(i)(1)
                    txtattributaireDecomp.Text = ds1.Tables("Fornisseur").Rows(i)(1)
                    txtnomsocieteN.Text = ds1.Tables("Fornisseur").Rows(i)(1)
                    txtsocietePV.Text = ds1.Tables("Fornisseur").Rows(i)(1)
                    txtsocietePVD.Text = ds1.Tables("Fornisseur").Rows(i)(1)
                    txtnomSoOrder.Text = ds1.Tables("Fornisseur").Rows(i)(1)
                    txtFornisseurDecomptDefi.Text = ds1.Tables("Fornisseur").Rows(i)(1)
                    CBnomdirN.Text = ds1.Tables("Fornisseur").Rows(i)(2)
                    txtnomdirORDER.Text = ds1.Tables("Fornisseur").Rows(i)(2)
                    rtadressN.Text = ds1.Tables("Fornisseur").Rows(i)(3)
                    rtadressDecomp.Text = ds1.Tables("Fornisseur").Rows(i)(3)
                    rtadresseOrder.Text = ds1.Tables("Fornisseur").Rows(i)(3)
                    rtadressePV.Text = ds1.Tables("Fornisseur").Rows(i)(3)
                    rtadresseDecomptDefi.Text = ds1.Tables("Fornisseur").Rows(i)(3)
                    txtregestrecom.Text = ds1.Tables("Fornisseur").Rows(i)(4)
                    txtcnss.Text = ds1.Tables("Fornisseur").Rows(i)(5)
                    txtcnssNDecomptDefinitif.Text = ds1.Tables("Fornisseur").Rows(i)(5)
                    txtcmpt.Text = ds1.Tables("Fornisseur").Rows(i)(6)
                    txtcbanquedecompDefi.Text = ds1.Tables("Fornisseur").Rows(i)(6)
                    txtpatente.Text = ds1.Tables("Fornisseur").Rows(i)(8)
                    'TextBox8.Text = ds1.Tables("Fornisseur").Rows(i)(9)
                    'TextBox9.Text = ds1.Tables("Fornisseur").Rows(i)(10)
                    Trove = True
                End If
            Next
            If Trove = False Then
                MsgBox("n'exists pas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TabPage8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage8.Click
        txtmarcheNdecomDéf.Text = txtmarchéN.Text
        txtobjetmarchdecomptDefi.Text = RTBobjet.Text
        txtregdecomptDefi.Text = txtregestrecom.Text
        txtpatentedecomtDefi.Text = txtpatente.Text
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            Dim oWord As New Word.Application
            Dim oDoc As Word.Document
            oDoc = oWord.Documents.Open("D:\parprasse du marché.doc")
            oDoc.Bookmarks.Item("ETmarcheN").Range.Text = TXTNETATA.Text
            oDoc.Bookmarks("ETobejtMarche").Range.Text = RTOBJ.Text
            oDoc.Bookmarks("ETforniss").Range.Text = txttitulaireMarcheETAT.Text
            oDoc.Bookmarks("ETmontanM").Range.Text = txtmo.Text
            oDoc.Bookmarks("ETVILLE").Range.Text = Label92.Text
            oDoc.Bookmarks("ETDATE").Range.Text = Label93.Text
            'oDoc.Bookmarks("tva").Range.Text = txtTVA.Text
            'oDoc.Bookmarks("ttc").Range.Text = TxtTTC.Text
            'oDoc.Bookmarks("line").Range.Text = rtline.Text
            'oDoc.Bookmarks("code").Range.Text = cbcode.Text
            'oDoc.Bookmarks("ville").Range.Text = CBVILLE.Text
            'oDoc.Bookmarks("date").Range.Text = MSKDATE.Text
            oWord.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim oWord As New Word.Application
            Dim oDoc As Word.Document
            oDoc = oWord.Documents.Open("D:\parprasse du marché.doc")
            oDoc.Bookmarks.Item("NOmarchéN").Range.Text = LBLnmarchN.Text
            oDoc.Bookmarks("NOobjet").Range.Text = txtobjetmarcheNOTI.Text
            oDoc.Bookmarks("NOgerant").Range.Text = CBnomdirN.Text
            'oDoc.Bookmarks("ETmontanM").Range.Text = txtmo.Text
            'oDoc.Bookmarks("ETVILLE").Range.Text = Label92.Text
            'oDoc.Bookmarks("ETDATE").Range.Text = Label93.Text
            ''oDoc.Bookmarks("tva").Range.Text = txtTVA.Text
            'oDoc.Bookmarks("ttc").Range.Text = TxtTTC.Text
            'oDoc.Bookmarks("line").Range.Text = rtline.Text
            'oDoc.Bookmarks("code").Range.Text = cbcode.Text
            'oDoc.Bookmarks("ville").Range.Text = CBVILLE.Text
            'oDoc.Bookmarks("date").Range.Text = MSKDATE.Text
            oWord.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FermerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FermerToolStripMenuItem.Click
        confirmation.Show()
    End Sub

    Private Sub RAPPORTDEPRESENTATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RAPPORTDEPRESENTATIONToolStripMenuItem.Click
        TBPraporte.Show()
    End Sub

    Private Sub ETATDENGAGEMENTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ETATDENGAGEMENTToolStripMenuItem.Click
        TBPetat.Show()
    End Sub

    Private Sub NOTIFICATIONDELAPPROBATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NOTIFICATIONDELAPPROBATIONToolStripMenuItem.Click
        TBPnotification.Show()
    End Sub

    Private Sub ETATDENGAGEMENTToolStripMenuItem_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ETATDENGAGEMENTToolStripMenuItem.MouseUp
        TBPetat.Show()
    End Sub

    Private Sub AProposeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AProposeToolStripMenuItem.Click
        apropose.Show()
    End Sub

    Private Sub DataBaseFornisseurToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataBaseFornisseurToolStripMenuItem.Click
        Fornisseur.Show()
    End Sub

    Private Sub DataBaseBudgetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataBaseBudgetToolStripMenuItem.Click
        budget.Show()
    End Sub

 

End Class