Public Class Form1

    
    
   
   
   
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDateSous.Text = Today()
        LblMontGob.Text = 0
    End Sub

    Private Sub RdbJourna_CheckedChanged(sender As Object, e As EventArgs) Handles RdbJourna.CheckedChanged
        CboDureSous.Items.Clear()
        If RdbJourna.Checked = True Then
            CboDureSous.Items.Add("3")
            CboDureSous.Items.Add("6")
        End If
    End Sub

    Private Sub RdbContract_CheckedChanged(sender As Object, e As EventArgs) Handles RdbContract.CheckedChanged
        CboDureSous.Items.Clear()
        If RdbContract.Checked = True Then
            CboDureSous.Items.Add("6")
            CboDureSous.Items.Add("12")
        End If
    End Sub

    Private Sub RdbEmbauch_CheckedChanged(sender As Object, e As EventArgs) Handles RdbEmbauch.CheckedChanged
        CboDureSous.Items.Clear()
        If RdbEmbauch.Checked = True Then
            CboDureSous.Items.Add("6")
            CboDureSous.Items.Add("12")
            CboDureSous.Items.Add("3")
        End If
    End Sub

    Private Sub CboDureSous_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboDureSous.SelectedIndexChanged
        If RdbEmbauch.Checked = True And CboDureSous.Text = "3" Then
            Lblm.Text = "ans"
        Else
            Lblm.Text = "mois"
        End If
        If Lblm.Text = "mois" Then
            LblFinSous.Text = DateAdd("m", Val(CboDureSous.Text), Today())
        Else
            LblFinSous.Text = DateAdd("yyyy", Val(CboDureSous.Text), Today())
        End If
    End Sub

    Private Sub chBTrav_CheckedChanged(sender As Object, e As EventArgs) Handles chBTrav.CheckedChanged
        If chBTrav.Checked = True Then
            If DateDiff("m", Today(), CDate(LblFinSous.Text)) < 6 Then
                MsgBox("Veuillez choisir une durée supérieure à 3mois svp", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Avertissement")
                chBTrav.Checked = False
            Else
                LblMontGob.Text = Val(LblMontGob.Text) + 25000
            End If
        Else
            LblMontGob.Text = Val(LblMontGob.Text) - 25000
        End If
    End Sub

    Private Sub ChBMaladie_CheckedChanged(sender As Object, e As EventArgs) Handles ChBMaladie.CheckedChanged
        If ChBMaladie.Checked = True Then
            If DateDiff("m", Today(), CDate(LblFinSous.Text)) < 6 Then
                MsgBox("Veuillez choisir une durée supérieure à 3mois svp", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Avertissement")
                ChBMaladie.Checked = False
            Else
                LblMontGob.Text = Val(LblMontGob.Text) + 100000
            End If
        Else
            LblMontGob.Text = Val(LblMontGob.Text) - 100000
        End If
    End Sub

    Private Sub ChBVoy_CheckedChanged(sender As Object, e As EventArgs) Handles ChBVoy.CheckedChanged
        If ChBVoy.Checked = True Then
            If DateDiff("m", Today(), CDate(LblFinSous.Text)) < 6 Then
                MsgBox("Veuillez choisir une durée supérieure à 3mois svp", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Avertissement")
                ChBVoy.Checked = False
            Else
                LblMontGob.Text = Val(LblMontGob.Text) + 750000
            End If
        Else
            LblMontGob.Text = Val(LblMontGob.Text) - 750000
        End If
    End Sub

    Private Sub ChBAutre_CheckedChanged(sender As Object, e As EventArgs) Handles ChBAutre.CheckedChanged
        If ChBAutre.Checked = True Then
            If DateDiff("m", Today(), CDate(LblFinSous.Text)) < 6 Then
                MsgBox("Veuillez choisir une durée supérieure à 3mois svp", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Avertissement")
                ChBAutre.Checked = False
            Else
                LblMontGob.Text = Val(LblMontGob.Text) + 250000
            End If
        Else
            LblMontGob.Text = Val(LblMontGob.Text) - 250000
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim cont As Boolean
      
        cont = True
        If TxtVal.Text = "" Or TxtAdres.Text = "" Or TxtName.Text = "" Or TxtPren.Text = "" Or TxtTel.Text = "" Then
            MsgBox("Veuillez remplir le(s) champ(s) vide(s)", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Avertissement")
            cont = False

        End If
        If RdbContract.Checked = False Or RdbEmbauch.Checked = False Or RdbJourna.Checked = False Then
            MsgBox("Veuillez choisir une nature de souscription", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Avertissement")
            cont = False
        End If
        If CboDureSous.Text = "" Then
            MsgBox("Veuillez donner une durée", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Avertissement")
            cont = False
        End If
        If cont = True Then
            MsgBox("Enregistrement effectué avec succés", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Information")

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim resp As Integer
        resp = MsgBox("Voulez vous vraiment quitter", MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, "Avertissement")
        If resp = 1 Then
            Me.Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TxtAdres.Text = ""
        TxtName.Text = ""
        TxtPren.Text = ""
        TxtTel.Text = ""
        TxtVal.Text = ""
        CboDureSous.Text = ""
    End Sub
End Class
