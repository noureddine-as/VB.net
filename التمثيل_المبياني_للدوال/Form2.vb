Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles representation_btn.Click
        ' رسم المعلم بكل مراحله:
        ' رسم المحاور
        ' تدريج المعلم
        ' إنشاء المنحنى

        TracerRepere()
    End Sub

    ' رسم المعلم بكل أجزائه
    Sub TracerRepere()

        ' تعريف عدد سيكون بمثابة قيمة تكبير المعلم
        Dim z As Integer = Me.TrackBar1.Value

        Dim G As Graphics = Graphics.FromHwnd(Me.rep_pb.Handle)

        ' PictureBoxتفيد الخطوة القادمة في جعل أصل المعلم في منتصف ال
        G.TranslateTransform(Me.rep_pb.Width / 2, Me.rep_pb.Height / 2)

        ' تحسين جودة الرسم
        G.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

        G.Clear(Color.WhiteSmoke)

        ' Ox إنشاء أقلام لرسم محور الأفاصيل
        ' Oy و محور الأراتيب
        Dim Ox_pen As New Pen(Color.Red, 1.2)
        Dim Oy_pen As New Pen(Color.Green, 1.2)

        ' جعل نهاية كل محور على شكل سهم ثم رسمه
        Ox_pen.EndCap = Drawing2D.LineCap.ArrowAnchor
        Oy_pen.EndCap = Drawing2D.LineCap.ArrowAnchor

        G.DrawLine(Ox_pen, -180, 0, 180, 0)
        G.DrawLine(Oy_pen, 0, 180, 0, -180)

        ' كتابة أسماء المحاور بجانب كل واحد
        G.DrawString("x", Me.Font, Brushes.Black, 184, 0)
        G.DrawString("y", Me.Font, Brushes.Black, 0, -194)

        ' التدريجات
        Graduations(z, G)

        ' O المربع الصغير الذي سنتمكن من خلاله من رسم نقطة أصل المعلم
        Dim O_rect As New Rectangle(-2, -2, 4, 4)
        G.FillEllipse(Brushes.Black, O_rect)

        ' رسم المنحنى
        TracerCourbe(z, G)

        G.Dispose()
    End Sub

    ' تدريج المعلم
    Sub Graduations(ByVal z As Integer, ByVal G As Graphics)

        ' تعريف القلم المستعمل لتدريج و تقسيم المعلم
        Dim MyPen As New Pen(Color.FromArgb(120, Color.Gray))

        ' Ox تدريج محور الأفاصيل

        ' تعيين عدد التدريجات الذي يمكن تقسيم المحور إليه
        ' يعني عدد تدريجات المحور المموافقة للحجم التكبير الذي تم اختياره
        Dim n As Integer = 180 / z

        ' تدريجات محور الأفاصيل يكون لها نفس الأفاصيل
        Dim X As Integer = 0

        ' أما الأرتوب فيتغير بين النقطة السفلية و النقطة العلوية
        Dim Y_top As Integer = -180
        Dim Y_bottom As Integer = +180

        ' رسم خط التدريجات الموجبة من النقطة العلوية إلى النقطة السفلية
        For i = 1 To n
            ' كما قلنا .. الأفاصيل فقط هي التي تتغير (بنفس القيمة) عند تقسيم محور الأراتيب
            X += z

            ' النقطة العلوية و السفلية من التدريجة
            Dim Ox_top As New Point(X, Y_top)
            Dim Ox_bottom As New Point(X, Y_bottom)

            'رسم خط التدريجة
            G.DrawLine(MyPen, Ox_top, Ox_bottom)

            ' إفراغ الذاكرة
            Ox_top = Nothing
            Ox_bottom = Nothing
        Next

        ' البدء مجددا من الصفر للشروع في تدريج الأفاصيل السالبة
        X = 0

        ' نفس الشيء بالنسبة لتدريجات الأفاصيل السالبة
        For i = 1 To n
            X -= z
            Dim Ox_top As New Point(X, Y_top)
            Dim Ox_bottom As New Point(X, Y_bottom)

            G.DrawLine(MyPen, Ox_top, Ox_bottom)

            Ox_top = Nothing
            Ox_bottom = Nothing
        Next

        ' إفراغ الذاكرة من هذه القيم
        X = Nothing
        Y_top = Nothing
        Y_bottom = Nothing

        '-------------------------------------------
        ' Oy تدريج محور الأراتيب

        ' تدريجات محور الأراتيب يكون لها نفس الأراتيب
        Dim Y As Integer = 0

        ' أما الأفاصيل فتتغير بين النقطة اليمنى و اليسرى
        Dim X_right As Integer = 180
        Dim X_left As Integer = -180

        ' تدريج محور الأراتيب في الجهة السفلى
        ' أي الأراتيب السالبة
        For i = 1 To n
            Y -= z
            Dim Oy_right As New Point(X_right, Y)
            Dim Oy_left As New Point(X_left, Y)

            G.DrawLine(MyPen, Oy_left, Oy_right)

            Oy_left = Nothing
            Oy_right = Nothing
        Next

        ' العودة إلى أصل المعلم من أجل البدء في تدريج الجهة العلوية
        ' أي الأراتيب الموجبة
        Y = 0

        ' تدريج الأراتيب الموجبة
        For i = 1 To n
            Y += z
            Dim Oy_right As New Point(X_right, Y)
            Dim Oy_left As New Point(X_left, Y)

            G.DrawLine(MyPen, Oy_left, Oy_right)

            Oy_left = Nothing
            Oy_right = Nothing
        Next

        ' إفراغ الذاكرة من هذه القيم
        Y = Nothing
        X_right = Nothing
        X_left = Nothing

    End Sub

    ' رسم منحنى الدالة
    Sub TracerCourbe(ByVal z As Integer, ByVal g As Graphics)
        ' تعيين مصفوفة من النقط التي تشكل المنحنى
        Dim Pts(36) As Point

        ' تهدف هذه الحلقة التكرارية إلى إيجاد الأرتوب الموافق لكل أفصول
        ' و بالتالي نحصل على مجوعة النقط المنتمية إلى المنحنى لنقوم فيما بعد بوصلها مع بعضها

        Dim j As Integer = 0
        For i = -18 To 18

            ' نقوم بإيجاد الأرتوب الموافق لكل أفصول في المنحنى لتشكيل سلسلة النقط
            ' المكونة للمنحنى
            Pts(j) = New Point((i * z), -(GetY(i) * z))

            j += 1

        Next

        ' رسم المنحنى اعتمادا على سلسلة النقط التي تم الحصول عليها في البداية
        g.DrawCurve(Pens.Blue, Pts)

    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        ' رسم المنحنى
        ' ملحوظة: يؤدي تغير قيمة التراكبار إلى تغيير قيمة التكبير في الإجراء أعلاه
        ' و هذا ما يؤدي بدوره إلى تكبير المعلم

        TracerRepere()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' نقوم بكتابة الدالة في المكان المخصص

        Me.equation_lbl.Text = GetFunction(_a, _b)
    End Sub

    ' تم تحميل هذا الملف من منتديات ستار تايمز
    ' منتدى لغات البرمجة
    ' VB/VB.Netعصابة ال
    ' جميع الحقوق محفوظة ©
    ' المؤلف
    ' a-s نورالدين

End Class