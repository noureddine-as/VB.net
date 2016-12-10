Public Class Options_Form

#Region "Gestions Des Thèmes"

    Private Sub CB_Theme_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Theme.SelectedIndexChanged
        With My.Settings
            If CB_Theme.Text = ("Office 2007 Bleu") Then
                Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
                .Office2007Blue = ("Selected")
                .Office2007Black = ("Office2007Black")
                .Save()
            ElseIf CB_Theme.Text = ("Office 2007 Noir") Then
                Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black
                .Office2007Blue = ("Office2007Blue")
                .Office2007Black = ("Selected")
                .Save()
            End If
        End With
    End Sub

#End Region

    Private Sub Options_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With My.Settings
            If .Office2007Blue = ("Selected") Then
                Me.CB_Theme.SelectedIndex = 0
            ElseIf .Office2007Black = ("Selected") Then
                Me.CB_Theme.SelectedIndex = 1
            End If
        End With
    End Sub
End Class