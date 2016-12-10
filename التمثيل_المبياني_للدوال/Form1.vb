Public Class Form1

    Private Sub Resoudre_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Resoudre_btn.Click
        ' التحقق من أن المعطيات عبارة عن أرقام

        If IsNumeric(Me.a_txt.Text) = False Then Me.a_txt.Text = "0"
        If IsNumeric(Me.b_txt.Text) = False Then Me.b_txt.Text = "0"

        ' إسناد القيم
        ' a و b
        ' إلى المتغيرات المتواجدة في الموديل للتعامل معها مباشرة
        ' SolveEquation حل المعادلة انطلاقا من استدعاء الإجراء
        ' module المندرج ضمن
        ' Equation المسمى

        Equation._a = Me.a_txt.Text
        Equation._b = Me.b_txt.Text

        SolveEquation(Equation._a, Equation._b)

        'إلغاء المجموعة
        Me.GroupBox3.Enabled = True
    End Sub

    Private Sub reprsentation_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reprsentation_btn.Click

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
