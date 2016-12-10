Module Equation

    Private a As Double
    Public Property _a() As Double
        Get
            Return a
        End Get
        Set(ByVal value As Double)
            a = value
        End Set
    End Property

    Private b As Double
    Public Property _b() As Double
        Get
            Return b
        End Get
        Set(ByVal value As Double)
            b = value
        End Set
    End Property

    ''' <summary>
    ''' الحصول على التعبير الكتابي للمعادلة
    ''' </summary>
    ''' <param name="E_a">العدد a</param>
    ''' <param name="E_b">العدد b</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetEquation(ByVal E_a As Double, ByVal E_b As Double) As String
        ' التعبير الكتابي للمعادلة
        Dim EqString As String = Nothing

        ' إذا كان العدد 
        ' يخالف الصفر a
        If E_a <> 0 Then

            If E_b = 0 Then
                ' تكتب على شكل
                ' ax = 0
                EqString = E_a & "x = 0"
            ElseIf E_b > 0 Then
                ' تكتب على شكل
                ' ax + b = 0
                EqString = E_a & "x + " & E_b & " = 0"
            ElseIf E_b < 0 Then
                ' تكتب على شكل
                ' ax - b = 0
                EqString = E_a & "x " & E_b & " = 0"
            End If

            Return EqString

        Else
            Return ""
        End If
    End Function

    ''' <summary>
    ''' الحصول على التعبير الكتابي للدالة
    ''' </summary>
    ''' <param name="E_a">العدد a</param>
    ''' <param name="E_b">العدد b</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetFunction(ByVal E_a As Double, ByVal E_b As Double) As String
        ' التعبير الكتابي للدالة
        Dim FunctionString As String = Nothing

        ' نفس خطوات الدالة السابقة لكن هذه المرة نريد الحصول على دالة و ليس على معادلة
        If E_a <> 0 Then

            If E_b = 0 Then
                ' تكتب على شكل
                ' y = ax
                FunctionString = "y = " & E_a & "x"
            ElseIf E_b > 0 Then
                ' تكتب على شكل
                ' y = ax + b
                FunctionString = "y = " & E_a & "x + " & E_b
            ElseIf E_b < 0 Then
                ' تكتب على شكل
                ' y = ax - b
                FunctionString = "y = " & E_a & "x " & E_b
            End If

            Return FunctionString
        Else
            Return ""
        End If
    End Function

    ''' <summary>
    ''' حساب الأرتوب الموافق لأفصول أو متغير معين
    ''' </summary>
    ''' <param name="x">الأفصول أو المتغير</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetY(ByVal x As Double) As Double
        Dim y As Double = a * x + b

        Return y
    End Function

    ''' <summary>
    ''' حل المعادلة و وضع النتيجة في الفورم الأول
    ''' </summary>
    ''' <param name="a">العدد a</param>
    ''' <param name="b">العدد a</param>
    ''' <remarks></remarks>
    Sub SolveEquation(ByVal a As Double, ByVal b As Double)
        ' المجهول الذي نبحث عنه
        Dim x As Double = Nothing
        ' ملاحظة
        Dim Observation As String = Nothing
        ' الحل النهائي
        Dim Solution As String = Nothing

        ' هنا نطبق المراحل العادية التي نعتمدها في حل معادلات الدرجة الأولى
        If a <> 0 Then

            x = -b / a

            Observation = "ملاحظة: هذه المعادلة لها حل وحيد"

            Solution = "X = " & x & ""

            Form1.reprsentation_btn.Enabled = True


        ElseIf a = 0 Then

            If b = 0 Then

                Observation = "ملاحظة: كل عدد حقيقي هو حل لهذه المعادلة"
                Solution = ("S = IR")

                Form1.reprsentation_btn.Enabled = True

            ElseIf b <> 0 Then

                Observation = "ملاحظة: هذه المعادلة ليس لها حل"
                Solution = ("S = Ø")

                Form1.reprsentation_btn.Enabled = False
            End If

        End If

        ' وضع الملاحظة و الحل النهائي في الأماكن الخاصة بها
        Form1.observ_lbl.Text = Observation
        Form1.solution_txt.Text = Solution

    End Sub

    ' تم تحميل هذا الملف من منتديات ستار تايمز
    ' منتدى لغات البرمجة
    ' VB/VB.Netعصابة ال
    ' جميع الحقوق محفوظة ©
    ' المؤلف
    ' a-s نورالدين

End Module
