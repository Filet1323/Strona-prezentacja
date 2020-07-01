<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DrawingBoard
    Inherits System.Windows.Forms.UserControl

    '''UserControl1 zastepuje dispose, aby wyczyscic liste komponentow.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    '''Wymagane przez projektanta formularzy Windows
    Private components As System.ComponentModel.IContainer

    '''UWAGA: Projektant formularzy Windows wymaga nastepującej procedury
    '''Mozna go zmodyfikowac za pomoca Projektanta formularzy Windows.
    '''Nie modyfikuj go za pomoca edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '''
        '''DrawingBoard
        '''
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "DrawingBoard"
        Me.Size = New System.Drawing.Size(189, 165)
        Me.ResumeLayout(False)

    End Sub
End Class
