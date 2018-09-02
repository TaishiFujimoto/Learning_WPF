Imports System.Text.RegularExpressions
Class MainWindow
    Private rgx As Regex = New Regex("^[0-9]*$")

    Private Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。


    End Sub


    Private Sub textBox_PreviewTextInput(sender As Object, e As TextCompositionEventArgs) Handles textBox.PreviewTextInput
        If (Not rgx.IsMatch(e.Text)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub textBox_PreviewKeyDown(sender As Object, e As KeyEventArgs) Handles textBox.PreviewKeyDown

        If (e.Key = Key.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub textBox_PreviewExecuted(sender As Object, e As ExecutedRoutedEventArgs)
        If (e.Command.ToString = ApplicationCommands.Paste.ToString) Then
            e.Handled = True
        End If
    End Sub

    'Private Sub PastingHandler(sender As Object, e As DataObjectPastingEventArgs)
    '    Dim isText = e.SourceDataObject.GetDataPresent(DataFormats.UnicodeText, True)
    '    If (Not isText) Then
    '        Return
    '    End If

    '    Dim text As String = e.SourceDataObject.GetData(DataFormats.UnicodeText)

    '    If (Not rgx.IsMatch(text)) Then
    '        e.CancelCommand()
    '        e.Handled = True
    '    End If


    'End Sub

End Class
