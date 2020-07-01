﻿Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillComboBox()
    End Sub
    '''
    ''' Button1_Click
    '''
    Private Sub FillComboBox()
        Dim enumType As System.Type = GetType(System.Drawing.RotateFlipType)
        Dim EnumValues As System.Array = System.Enum.GetValues(enumType)
        Dim Enumerator As System.Collections.IEnumerator = EnumValues.GetEnumerator()

        While Enumerator.MoveNext
            ComboBox1.Items.Add(Enumerator.Current)
        End While
        ComboBox1.SelectedIndex = 0
    End Sub
    '''
    ''' Button1_Click
    '''

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ImageControl1.InvertColors()
    End Sub
    '''
    ''' Button2_Click
    '''
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.ImageControl1.ZoomIn()
    End Sub
    '''
    ''' Button3_Click
    '''
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.ImageControl1.ZoomOut()
    End Sub
    '''
    ''' ComboBox1_SelectedIndexChanged
    '''
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.ImageControl1.RotateFlip(Me.ComboBox1.SelectedItem)
    End Sub
    '''
    ''' Button4_Click
    '''
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.ImageControl1.Image = Nothing
    End Sub
    '''
    ''' CheckBox2_CheckedChanged
    '''
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Me.ImageControl1.StretchImageToFit = CheckBox2.Checked
    End Sub
    '''
    ''' Button5_Click
    '''
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.ImageControl1.fittoscreen()
    End Sub
    '''
    ''' Button6_Click
    '''
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        With OpenFileDialog1
            Dim bmp As Bitmap
            .CheckFileExists = True
            .CheckPathExists = True
            .InitialDirectory = "c:\"
            .Multiselect = False
            .Filter = "*.* Wybierz zdjęcie| *.*"
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                bmp = New Bitmap(.FileName)
                Me.ImageControl1.Image = bmp
            End If
        End With

    End Sub
    '''
    ''' RadioButton1_CheckedChanged
    '''
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        Me.ImageControl1.PanMode = RadioButton1.Checked
    End Sub
    '''
    ''' Button7_Click
    '''
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'Me.ImageControl1.StretchImageToFit = False
        Me.CheckBox2.Checked = False
        Me.ImageControl1.Origin = New Point(0, 0)
        Me.ImageControl1.ZoomFactor = 1
    End Sub
End Class
