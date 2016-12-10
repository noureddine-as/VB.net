Public Class Form1

    Private Sub Resoudre_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Resoudre_btn.Click
        ' التحقق من أن المعطيات عبارة عن أرقام

        If IsNumeric(Me.a_txt.Text) = False Then Me.a_txt.Text = "0"
        If IsNumeric(Me.b_txt.Text) = False Then Me.b_txt.Text = "0"

        ' SolveEquation حل المعادلة انطلاقا من استدعاء الإجراء
        ' module المندرج ضمن
        ' Equation المسمى
        SolveEquation(Me.a_txt.Text, Me.b_txt.Text)

        'إلغاء المجموعة
        Me.GroupBox3.Enabled = True
    End Sub

    Private Sub reprsentation_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reprsentation_btn.Click
        ' تغيير قيمتي
        ' a و b
        ' إلى القيمة الحالية
        Equation._a = Val(Me.a_txt.Text)
        Equation._b = Val(Me.b_txt.Text)

        ' إظهار الفورم الخاص بالتمثيل المبياني للدالة
        Form2.ShowDialog(Me)
        
    End Sub

    ' تم تحميل هذا الملف من منتديات ستار تايمز
    ' منتدى لغات البرمجة
    ' VB/VB.Netعصابة ال
    ' جميع الحقوق محفوظة ©
    ' المؤلف
    ' a-s نورالدين

End Class
