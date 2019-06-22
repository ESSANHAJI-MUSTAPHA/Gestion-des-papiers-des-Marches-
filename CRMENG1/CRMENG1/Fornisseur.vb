Public Class Fornisseur

    Private Sub Fornisseur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO : cette ligne de code charge les données dans la table 'PlancontaDataSet1.T_fornisseur1'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.T_fornisseur1TableAdapter.Fill(Me.PlancontaDataSet1.T_fornisseur1)

    End Sub
End Class