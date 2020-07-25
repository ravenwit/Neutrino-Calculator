Public Class Neutrino_Calculator

        Dim Clearlbl1 As Boolean = True
        Dim Clearlbl2 As Boolean = True
        Dim Number1
        Dim Number2
        Dim Result
        Dim CalcMemory
        Dim calcOperator As String
        Dim HcalcOperator As String = vbNullString
        Dim IsOperator As Boolean = False
        Dim IsContinue As Boolean = False
        Dim IsInitial As Boolean = True
        Dim IsInverse As Boolean = False
        Dim isMinus As Boolean = False
        Dim IsDot As Boolean = False
        Dim IsEqual As Boolean = False
    Dim dmsinterval As Integer = 0
    Dim DateCalcType As Integer = 0
    'Date Calculation

    Public years As Integer
    Public months As Integer
    Public days As Integer

    <System.Runtime.InteropServices.DllImport("user32.dll")> _
    Private Shared Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short
    End Function

    Private Function CalcKeysActivate()
        On Error Resume Next
        Dim CalcKeys(4) As Boolean
        CalcKeys(0) = GetAsyncKeyState(Keys.Add)
        CalcKeys(1) = GetAsyncKeyState(Keys.Subtract)
        CalcKeys(2) = GetAsyncKeyState(Keys.Multiply)
        CalcKeys(3) = GetAsyncKeyState(Keys.Divide)


        If CalcKeys(0) = True Then
            btnAddition.PerformClick()

        ElseIf CalcKeys(1) = True Then
            btnSubtraction.PerformClick()

        ElseIf CalcKeys(2) = True Then
            btnMultiplication.PerformClick()

        ElseIf CalcKeys(3) = True Then
            btnDivision.PerformClick()

        End If

    End Function

    Public Function DateCalc(ByVal Date1 As Date, ByVal Date2 As Date, Optional ByVal AddSubtract As String = vbNullString, Optional ByVal Year As Integer = 0, Optional ByVal Month As Integer = 0, Optional ByVal Day As Integer = 0)
        If AddSubtract = vbNullString Then
            Dim fDate As Date
            Dim sDate As Date

            If Date1 < Date2 Then
                fDate = Date1
                sDate = Date2
            ElseIf Date1 > Date2 Then
                fDate = Date2
                sDate = Date1
            End If

            '''''''''''''''''' Date Calculation ''''''''''''''''''''''

            If sDate.Date.Month < fDate.Date.Month Then
                years = DateDiff(DateInterval.Year, fDate, sDate) - 1
                If sDate.Date.Day < fDate.Date.Day Then
                    months = DateDiff(DateInterval.Month, DateSerial(fDate.Date.Year + years, fDate.Date.Month, fDate.Date.Day), sDate) - 1
                    days = DateDiff(DateInterval.Day, DateSerial(sDate.Date.Year, sDate.Date.Month - 1, fDate.Date.Day), sDate)
                ElseIf sDate.Date.Day = fDate.Date.Day Then
                    months = DateDiff(DateInterval.Month, DateSerial(sDate.Date.Year - 1, fDate.Date.Month, fDate.Date.Day), sDate)
                    days = 0
                ElseIf sDate.Date.Day > fDate.Date.Day Then
                    months = DateDiff(DateInterval.Month, DateSerial(sDate.Date.Year - 1, fDate.Date.Month, fDate.Date.Day), sDate)
                    days = DateDiff(DateInterval.Day, DateSerial(sDate.Date.Year, sDate.Date.Month, fDate.Date.Day), sDate)
                End If
            ElseIf sDate.Date.Month = fDate.Date.Month Then
                If sDate.Date.Day < fDate.Date.Day Then
                    years = DateDiff(DateInterval.Year, fDate, sDate) - 1
                    months = DateDiff(DateInterval.Month, DateSerial(sDate.Date.Year - 1, fDate.Date.Month, fDate.Date.Day), sDate) - 1
                    days = DateDiff(DateInterval.Day, DateSerial(sDate.Date.Year, sDate.Date.Month - 1, fDate.Date.Day), sDate)
                ElseIf sDate.Date.Day = fDate.Date.Day Then
                    years = DateDiff(DateInterval.Year, fDate, sDate)
                    months = 0
                    days = 0
                ElseIf sDate.Date.Day > fDate.Date.Day Then
                    years = DateDiff(DateInterval.Year, fDate, sDate)
                    months = DateDiff(DateInterval.Month, DateSerial(sDate.Date.Year, fDate.Month, fDate.Date.Day), sDate)
                    days = DateDiff(DateInterval.Day, DateSerial(sDate.Date.Year, sDate.Date.Month, fDate.Date.Day), sDate)
                End If
            ElseIf sDate.Date.Month > fDate.Date.Month Then
                years = DateDiff(DateInterval.Year, fDate, sDate)
                If sDate.Date.Day < fDate.Date.Day Then
                    months = DateDiff(DateInterval.Month, DateSerial(sDate.Date.Year, fDate.Date.Month, fDate.Date.Day), sDate) - 1
                    days = DateDiff(DateInterval.Day, DateSerial(sDate.Date.Year, sDate.Date.Month - 1, fDate.Date.Day), sDate)
                ElseIf sDate.Date.Day = fDate.Date.Day Then
                    months = DateDiff(DateInterval.Month, DateSerial(sDate.Date.Year, fDate.Date.Month, fDate.Date.Day), sDate)
                    days = 0
                ElseIf sDate.Date.Day > fDate.Date.Day Then
                    months = DateDiff(DateInterval.Month, DateSerial(fDate.Date.Year + years, fDate.Date.Month, fDate.Date.Day), sDate)
                    days = DateDiff(DateInterval.Day, DateSerial(fDate.Date.Year + years, sDate.Date.Month, fDate.Date.Day), sDate)
                End If
            End If
            Return 0
        ElseIf AddSubtract <> vbNullString Then
            Dim yearResult, monthResult As Integer
            Dim returnDate As Date
            Dim i = 0
            Select Case AddSubtract
                Case "add"
                    yearResult = Date1.Year + Year
                    monthResult = Date1.Month + Month
                    Do Until monthResult < 12
                        monthResult -= 12
                        i += 1
                    Loop
                    yearResult += i
                    returnDate = DateSerial(yearResult, monthResult, Date1.Day)
                    returnDate = DateAdd(DateInterval.Day, Day, returnDate)
                    i = 0
                    Return FormatDateTime(returnDate, DateFormat.LongDate)
                Case "sub"
                    yearResult = Date1.Year - Year
                    monthResult = Date1.Month + Month
                    Do Until monthResult < 12
                        monthResult -= 12
                        i += 1
                    Loop
                    yearResult -= i
                    returnDate = DateSerial(Year, Month, Date1.Day)
                    returnDate = DateAdd(DateInterval.Day, (-CInt(Day)), returnDate)
                    i = 0
                    Return FormatDateTime(returnDate, DateFormat.LongDate)
            End Select

        End If
        Return True
    End Function


    Private Function CheckTrigUnit(ByVal Input As Double, Optional ByVal Isverse As Boolean = False) As Double
        Dim ConvertedResult As Double
        If radDegree.Checked = True Then
            If Isverse = True Then
                ConvertedResult = ((180 / Math.PI)) * Input
            ElseIf Isverse = False Then
                ConvertedResult = ((Math.PI / 180)) * Input
            End If
        ElseIf radRadian.Checked = True Then
            ConvertedResult = Input
        ElseIf radGradient.Checked = True Then
            If Isverse = True Then
                ConvertedResult = ((200 / Math.PI)) * Input
            ElseIf Isverse = False Then
                ConvertedResult = ((Math.PI / 200)) * Input
            End If
        End If
        Return ConvertedResult
    End Function

    Private Function CombinatoricsCalc(ByVal n As Double, ByVal r As Double, ByVal Operation As String) As Double
        Dim i = 1
        Dim calcResult, Numerator, Denominator, Factorial_r, Factorial_nr
        Numerator = 1
        Denominator = 1
        Factorial_nr = 1
        Factorial_r = 1

        For i = 1 To n
            Numerator = Numerator * i
        Next

        For i = 1 To r
            Factorial_r = Factorial_r * i
        Next

        For i = 1 To (n - r)
            Factorial_nr = Factorial_nr * i
        Next

        Select Case Operation
            Case "perm"
                calcResult = Numerator / (Factorial_nr)
            Case "comb"
                calcResult = Numerator / (Factorial_nr * Factorial_r)
        End Select

        Return calcResult
        GoTo DisposeAll

DisposeAll:
        i = 0
        calcResult = 0
        Numerator = 1
        Denominator = 1
        Factorial_nr = 1
        Factorial_r = 1
    End Function


    Private Function CheckNumber() As Double
        Dim CheckedNumber As Double
        Number2 = Val(lblDisplay.Text.Replace("x10", "E"))
        Select Case HcalcOperator
            Case "pow"
                CheckedNumber = Math.Pow(Number1, Number2)
            Case "yroot"
                CheckedNumber = Math.Pow(Number1, 1 / Number2)
            Case "mod"
                CheckedNumber = Number1 Mod Number2
            Case "perm"
                CheckedNumber = CombinatoricsCalc(Number1, Number2, "perm")
            Case "comb"
                CheckedNumber = CombinatoricsCalc(Number1, Number2, "comb")
            Case "exp"
                CheckedNumber = Number1 * Math.Pow(10, Number2)
            Case "log"
                CheckedNumber = (Math.Log(Number2)) / (Math.Log(Number1))
            Case vbNullString
                CheckedNumber = Val(lblDisplay.Text.Replace("x10", "E"))
        End Select
        HcalcOperator = vbNullString
        Return CheckedNumber
    End Function

    Private Function Calculate(ByVal Order As String)

        If IsOperator = False Then
            Clearlbl1 = True
            If IsInitial = True Then
                Number1 = CheckNumber()
                Result = Number1
                lblDisplay.Text = Result
                GoTo ExitArg
            ElseIf IsInitial = False Then

                Number2 = CheckNumber()
                Select Case calcOperator
                    Case "+"
                        Result = Result + Number2
                    Case "-"
                        Result = Result - Number2
                    Case "*"
                        Result = Result * Number2
                    Case "/"
                        Result = Result / Number2
                End Select

                lblDisplay.Text = Result
                Number1 = Val(lblDisplay.Text)

                GoTo ExitArg
            ElseIf IsContinue = True Then
                Result = Val(lblDisplay.Text)

                IsContinue = False
                IsInitial = False
                IsOperator = True
                calcOperator = Order
            End If
            IsInitial = False
            IsOperator = True
        End If

ExitArg:
        IsContinue = True
        IsInitial = False
        IsOperator = True
        calcOperator = Order
        Return 0
        Exit Function
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        Dim ConvertExp As String = lblDisplay.Text
        ConvertExp = ConvertExp.Replace("E", "x10")
        ConvertExp = ConvertExp.Replace("NaN", "Undefined")
        lblDisplay.Text = ConvertExp

        If lblDisplay.Text.Length > 23 Then
            lblDisplay.Font = New Font(lblDisplay.Font.OriginalFontName, 14)
        Else
            lblDisplay.Font = New Font(lblDisplay.Font.OriginalFontName, 18)
        End If
        If CalcMemory <> 0 Then lblM.Text = "M"
        If lblDisplay.Text = vbNullString Then lblDisplay.Text = 0
    End Sub

    Private Sub Neutrino_Calculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnSin.ImageLarge = My.Resources.sinx
        btnCos.ImageLarge = My.Resources.cosx
        btnTan.ImageLarge = My.Resources.tanx
        btnSec.ImageLarge = My.Resources.secx
        btnCsc.ImageLarge = My.Resources.cscx
        btnCot.ImageLarge = My.Resources.cotx

        btnSinh.ImageLarge = My.Resources.sinhz
        btnCosh.ImageLarge = My.Resources.coshz
        btnTanh.ImageLarge = My.Resources.tanhz
        btnSech.ImageLarge = My.Resources.sechz
        btnCosech.ImageLarge = My.Resources.cschz
        btnCoth.ImageLarge = My.Resources.cothz

        btnSin.ImageSmall = My.Resources.sinx
        btnCos.ImageSmall = My.Resources.cosx
        btnTan.ImageSmall = My.Resources.tanx
        btnSec.ImageSmall = My.Resources.secx
        btnCsc.ImageSmall = My.Resources.cscx
        btnCot.ImageSmall = My.Resources.cotx

        btnSinh.ImageSmall = My.Resources.sinhz
        btnCosh.ImageSmall = My.Resources.coshz
        btnTanh.ImageSmall = My.Resources.tanhz
        btnSech.ImageSmall = My.Resources.sechz
        btnCosech.ImageSmall = My.Resources.cschz
        btnCoth.ImageSmall = My.Resources.cothz

        grpStatistics.Visible = False
        lstboxStatistics.Items.Clear()

        riblinFrom.Visible = False
        riblinTo.Visible = False
        riblinAddSubtract.Visible = False
        riblinYear.Visible = False
        riblinMonth.Visible = False
        riblinDay.Visible = False

        HcalcOperator = vbNullString
        calcOperator = vbNullString

        Result = 0
        CalcMemory = 0
        Clearlbl1 = True
        Clearlbl2 = True
        IsInitial = True
        IsInverse = False
        ribchkInverse.Checked = False
        lblDisplay.Text = vbNullString

    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click, btn00.Click, btndot.Click
        IsOperator = False
        IsEqual = False
        If Clearlbl1 = True Then
            If sender.text.ToString.Replace("&", "") = "." Then
                lblDisplay.Text = "0" + sender.text.ToString.Replace("&", "")
                IsDot = True
            Else
                lblDisplay.Text = sender.text.ToString.Replace("&", "")
                IsDot = False
            End If
            Clearlbl1 = False
        ElseIf Clearlbl1 = False Then
            If sender.text.ToString.Replace("&", "") = "." Then
                If IsDot = False Then
                    lblDisplay.Text = lblDisplay.Text + sender.text.ToString.Replace("&", "")
                    IsDot = True
                End If
            Else
                lblDisplay.Text = lblDisplay.Text + sender.text.ToString.Replace("&", "")

            End If
        End If

    End Sub

    Private Sub btnPM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPM.Click
        If isMinus = False Then
            If lblDisplay.Text <> vbNullString Then
                lblDisplay.Text = "-" + lblDisplay.Text
                Clearlbl1 = True
                isMinus = True
            End If
        ElseIf isMinus = True Then
            If lblDisplay.Text <> vbNullString Then
                lblDisplay.Text.Replace("-", "")
                Clearlbl1 = True
                isMinus = False
            End If
        End If
    End Sub

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
        CalcMemory = Val(lblDisplay.Text.Replace("x10", "E"))
    End Sub

    Private Sub btnMS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMS.Click
        CalcMemory = Val(lblDisplay.Text.Replace("x10", "E"))
    End Sub

    Private Sub KryptonButton1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles KryptonButton1.DoubleClick
        My.Settings.Memory = CalcMemory
    End Sub

    Private Sub KryptonButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton4.Click
        CalcMemory = CalcMemory + Val(lblDisplay.Text.Replace("x10", "E"))
    End Sub

    Private Sub btnMadd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMadd.Click
        CalcMemory = CalcMemory + Val(lblDisplay.Text.Replace("x10", "E"))
    End Sub

    Private Sub KryptonButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton6.Click
        CalcMemory = CalcMemory - Val(lblDisplay.Text.Replace("x10", "E"))
    End Sub

    Private Sub btnMsubtract_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMsubtract.Click
        CalcMemory = CalcMemory - Val(lblDisplay.Text.Replace("x10", "E"))
    End Sub

    Private Sub KryptonButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton5.Click
        CalcMemory = CalcMemory * Val(lblDisplay.Text.Replace("x10", "E"))
    End Sub

    Private Sub btnMmultiple_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMmultiple.Click
        CalcMemory = CalcMemory * Val(lblDisplay.Text.Replace("x10", "E"))
    End Sub

    Private Sub KryptonButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton7.Click
        CalcMemory = CalcMemory / Val(lblDisplay.Text.Replace("x10", "E"))
    End Sub

    Private Sub btnMdivide_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMdivide.Click
        CalcMemory = CalcMemory / Val(lblDisplay.Text.Replace("x10", "E"))
    End Sub

    Private Sub KryptonButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton8.Click
        lblDisplay.Text = CalcMemory.ToString.Replace("E", "x10")
    End Sub

    Private Sub btnMR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMR.Click
        lblDisplay.Text = CalcMemory.ToString.Replace("E", "x10")
    End Sub

    Private Sub KryptonButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton9.Click
        CalcMemory = 0
    End Sub

    Private Sub btnMC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMC.Click
        CalcMemory = 0
    End Sub

    Private Sub KryptonButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton11.Click
        On Error Resume Next
        If lblDisplay.Text <> vbNullString Then
            Dim backspacestring As String = lblDisplay.Text.Remove(Len(lblDisplay.Text) - 1, 1)
            'Dim backspacestring2 As String = lblDispalyOperation.Text.Remove(Len(lblDispalyOperation.Text) - 1, 1)
            lblDisplay.Text = backspacestring
            'lblDispalyOperation.Text = backspacestring2

        End If
    End Sub

    Private Sub KryptonButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton2.Click
        Try
            Clipboard.SetText(lblDisplay.Text)
        Catch es As Exception
            MsgBox(es.Message)
        End Try
    End Sub

    Private Sub KryptonButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton3.Click
        Try
            lblDisplay.Text = Clipboard.GetText()
        Catch es As Exception
            MsgBox(es.Message)
        End Try
    End Sub

    Private Sub KryptonButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton10.Click
        Try
            lblDisplay.Text = vbNullString
        Catch es As Exception
            MsgBox(es.Message)
        End Try
    End Sub


    Private Sub ribchkInverse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ribchkInverse.Click
        If ribchkInverse.Checked = True Then
            IsInverse = True
            btnSin.ImageLarge = My.Resources.arcsiny
            btnCos.ImageLarge = My.Resources.arccosy
            btnTan.ImageLarge = My.Resources.arctany
            btnSec.ImageLarge = My.Resources.arcsecy
            btnCsc.ImageLarge = My.Resources.arccscy
            btnCot.ImageLarge = My.Resources.arccotx

            btnSinh.ImageLarge = My.Resources.arcsinhx
            btnCosh.ImageLarge = My.Resources.arccoshx
            btnTanh.ImageLarge = My.Resources.arctanhx
            btnSech.ImageLarge = My.Resources.arcsechx
            btnCosech.ImageLarge = My.Resources.arccschx
            btnCoth.ImageLarge = My.Resources.arccothx

            btnSin.ImageSmall = My.Resources.arcsiny
            btnCos.ImageSmall = My.Resources.arccosy
            btnTan.ImageSmall = My.Resources.arctany
            btnSec.ImageSmall = My.Resources.arcsecy
            btnCsc.ImageSmall = My.Resources.arccscy
            btnCot.ImageSmall = My.Resources.arccotx

            btnSinh.ImageSmall = My.Resources.arcsinhx
            btnCosh.ImageSmall = My.Resources.arccoshx
            btnTanh.ImageSmall = My.Resources.arctanhx
            btnSech.ImageSmall = My.Resources.arcsechx
            btnCosech.ImageSmall = My.Resources.arccschx
            btnCoth.ImageSmall = My.Resources.arccothx

            btnSin.TextLine1 = "Sinˉ¹(y)"
            btnCos.TextLine1 = "Cosˉ¹(y)"
            btnTan.TextLine1 = "Tanˉ¹(y)"
            btnSec.TextLine1 = "Secˉ¹(y)"
            btnCsc.TextLine1 = "Cscˉ¹(y)"
            btnCot.TextLine1 = "Cotˉ¹(x)"

            btnSinh.TextLine1 = "Sinhˉ¹(x)"
            btnCosh.TextLine1 = "Coshˉ¹(x)"
            btnTanh.TextLine1 = "Tanhˉ¹(x)"
            btnSech.TextLine1 = "Sechˉ¹(x)"
            btnCosech.TextLine1 = "Cosechˉ¹(x)"
            btnCoth.TextLine1 = "Cothˉ¹(x)"
        ElseIf ribchkInverse.Checked = False Then
            IsInverse = False
            btnSin.ImageLarge = My.Resources.sinx
            btnCos.ImageLarge = My.Resources.cosx
            btnTan.ImageLarge = My.Resources.tanx
            btnSec.ImageLarge = My.Resources.secx
            btnCsc.ImageLarge = My.Resources.cscx
            btnCot.ImageLarge = My.Resources.cotx

            btnSinh.ImageLarge = My.Resources.sinhz
            btnCosh.ImageLarge = My.Resources.coshz
            btnTanh.ImageLarge = My.Resources.tanhz
            btnSech.ImageLarge = My.Resources.sechz
            btnCosech.ImageLarge = My.Resources.cschz
            btnCoth.ImageLarge = My.Resources.cothz

            btnSin.ImageSmall = My.Resources.sinx
            btnCos.ImageSmall = My.Resources.cosx
            btnTan.ImageSmall = My.Resources.tanx
            btnSec.ImageSmall = My.Resources.secx
            btnCsc.ImageSmall = My.Resources.cscx
            btnCot.ImageSmall = My.Resources.cotx

            btnSinh.ImageSmall = My.Resources.sinhz
            btnCosh.ImageSmall = My.Resources.coshz
            btnTanh.ImageSmall = My.Resources.tanhz
            btnSech.ImageSmall = My.Resources.sechz
            btnCosech.ImageSmall = My.Resources.cschz
            btnCoth.ImageSmall = My.Resources.cothz

            btnSin.TextLine1 = "Sin (x)"
            btnCos.TextLine1 = "Cos (x)"
            btnTan.TextLine1 = "Tan (x)"
            btnSec.TextLine1 = "Sec (x)"
            btnCsc.TextLine1 = "Csc (x)"
            btnCot.TextLine1 = "Cot (x)"

            btnSinh.TextLine1 = "Sinh (z)"
            btnCosh.TextLine1 = "Cosh (z)"
            btnTanh.TextLine1 = "Tanh (z)"
            btnSech.TextLine1 = "Sech (z)"
            btnCosech.TextLine1 = "Cosech (z)"
            btnCoth.TextLine1 = "Coth (z)"
        End If
    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        Try
            Clipboard.SetText(lblDisplay.Text)
        Catch es As Exception
            MsgBox(es.Message)
        End Try
    End Sub

    Private Sub btnAddition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddition.Click
        Calculate("+")

    End Sub

    Private Sub btnSubtraction_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubtraction.Click
        Calculate("-")
    End Sub

    Private Sub btnMultiplication_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMultiplication.Click
        Calculate("*")
    End Sub

    Private Sub btnDivision_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDivision.Click
        Calculate("/")
    End Sub

    Private Sub btnEqual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEqual.Click
        IsInitial = True
        IsEqual = True
        IsOperator = False

        Number2 = CheckNumber()

        Select Case calcOperator
            Case "+"
                Result = Result + Number2
            Case "-"
                Result = Result - Number2
            Case "*"
                Result = Result * Number2
            Case "/"
                Result = Result / Number2
            Case vbNullString
                Result = Number2
            Case Else
                Result = Number2
        End Select

        lblDisplay.Text = CDbl(Result)
        Result = 0
        Clearlbl1 = True
        Clearlbl2 = True
        Number1 = 0
    End Sub


    Private Sub KryptonButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAC.Click

        HcalcOperator = vbNullString
        calcOperator = vbNullString

        Result = 0
        Clearlbl1 = True
        Clearlbl2 = True
        IsDot = False
        isMinus = False
        IsInitial = True
        lblDisplay.Text = vbNullString


    End Sub

    Private Sub btnSquareRoot_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSquareRoot.Click

        Number1 = Val(lblDisplay.Text)
        lblDisplay.Text = Math.Sqrt(Number1)
        Clearlbl1 = True
        Clearlbl2 = True
    End Sub

    Private Sub btnPercent_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPercent.Click

        Number1 = Val(lblDisplay.Text)

        lblDisplay.Text = Number1 / 100
        Clearlbl1 = True
        Clearlbl2 = True
    End Sub

    Private Sub btnInverse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInverse.Click

        Number1 = Val(lblDisplay.Text)

        lblDisplay.Text = 1 / Number1
        Clearlbl1 = True
        Clearlbl2 = True
    End Sub


    Private Sub btnX2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnX2.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        lblDisplay.Text = Number1 * Number1
        Clearlbl1 = True

    End Sub

    Private Sub btnX3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnX3.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        lblDisplay.Text = Number1 * Number1 * Number1
        Clearlbl1 = True
    End Sub

    Private Sub btnXpowY_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnXpowY.Click

        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        HcalcOperator = "pow"
        Clearlbl1 = True
    End Sub

    Private Sub btn2rootX_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn2rootX.Click

        Number1 = Val(lblDisplay.Text)
        lblDisplay.Text = Math.Sqrt(Number1)
        Clearlbl1 = True
        Clearlbl2 = True
    End Sub

    Private Sub btn3rootX_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn3rootX.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        lblDisplay.Text = Math.Pow(Number1, 1 / 3)
        Clearlbl1 = True
    End Sub

    Private Sub btnYrootX_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnYrootX.Click

        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        HcalcOperator = "yroot"
        Clearlbl1 = True
    End Sub

    Private Sub btn10toX_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn10toX.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        lblDisplay.Text = Math.Pow(10, Number1)
        Clearlbl1 = True
    End Sub

    Private Sub btnetoX_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnetoX.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        lblDisplay.Text = Math.Exp(Number1)
        Clearlbl1 = True
    End Sub

    Private Sub btnExp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExp.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        lblDisplay.Text += "x10"
        HcalcOperator = "exp"
        Clearlbl1 = True
    End Sub

    Private Sub btnLog_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLog.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        lblDisplay.Text = Math.Log10(Number1)
        Clearlbl1 = True
    End Sub

    Private Sub btnLogab_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogab.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        HcalcOperator = "log"
        Clearlbl1 = True
    End Sub

    Private Sub btnLn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLn.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        lblDisplay.Text = Math.Log(Number1)
        Clearlbl1 = True
    End Sub

    Private Sub btnFactorialn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFactorialn.Click
        Dim factn = 1
        Dim i = 1
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        For i = 1 To Number1
            factn = i * factn
        Next
        lblDisplay.Text = factn
        Clearlbl1 = True
    End Sub

    Private Sub btnnPr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnPr.Click

        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        HcalcOperator = "perm"
        Clearlbl1 = True
    End Sub

    Private Sub btnnCr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnCr.Click

        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        HcalcOperator = "comb"
        Clearlbl1 = True
    End Sub

    Private Sub btnSin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSin.Click
        Number1 = CheckTrigUnit(Val(lblDisplay.Text.Replace("x10", "E")))
        If IsInverse = False Then lblDisplay.Text = Math.Sin(Number1)
        If IsInverse = True Then lblDisplay.Text = CheckTrigUnit(Math.Asin(Val(lblDisplay.Text.Replace("x10", "E"))), True)
        Clearlbl1 = True
    End Sub

    Private Sub btnCos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCos.Click
        Number1 = CheckTrigUnit(Val(lblDisplay.Text.Replace("x10", "E")))
        If IsInverse = False Then lblDisplay.Text = Math.Cos(Number1)
        If IsInverse = True Then lblDisplay.Text = CheckTrigUnit(Math.Acos(Val(lblDisplay.Text.Replace("x10", "E"))), True)
        Clearlbl1 = True
    End Sub

    Private Sub btnTan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTan.Click
        Number1 = CheckTrigUnit(Val(lblDisplay.Text.Replace("x10", "E")))
        If IsInverse = False Then lblDisplay.Text = Math.Sin(Number1) / Math.Cos(Number1)
        If IsInverse = True Then lblDisplay.Text = CheckTrigUnit(Math.Atan(Val(lblDisplay.Text.Replace("x10", "E"))), True)
        Clearlbl1 = True
    End Sub

    Private Sub btnCsc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCsc.Click
        Number1 = CheckTrigUnit(Val(lblDisplay.Text.Replace("x10", "E")))
        If IsInverse = False Then lblDisplay.Text = 1 / Math.Sin(Number1)
        If IsInverse = True Then lblDisplay.Text = CheckTrigUnit(Math.Asin(1 / Val(lblDisplay.Text.Replace("x10", "E"))), True)
        Clearlbl1 = True
    End Sub

    Private Sub btnSec_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSec.Click
        Number1 = CheckTrigUnit(Val(lblDisplay.Text.Replace("x10", "E")))
        If IsInverse = False Then lblDisplay.Text = 1 / Math.Cos(Number1)
        If IsInverse = True Then lblDisplay.Text = CheckTrigUnit(Math.Acos(1 / Val(lblDisplay.Text.Replace("x10", "E"))), True)
        Clearlbl1 = True
    End Sub

    Private Sub btnCot_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCot.Click
        Number1 = CheckTrigUnit(Val(lblDisplay.Text.Replace("x10", "E")))
        If IsInverse = False Then lblDisplay.Text = 1 / (Math.Sin(Number1) / Math.Cos(Number1))
        If IsInverse = True Then lblDisplay.Text = CheckTrigUnit(Math.Atan(Val(1 / lblDisplay.Text.Replace("x10", "E"))), True)
        Clearlbl1 = True
    End Sub

    Private Sub btnSinh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSinh.Click
        Number1 = CheckTrigUnit(Val(lblDisplay.Text.Replace("x10", "E")))
        If IsInverse = False Then lblDisplay.Text = Math.Sinh(Number1)
        If IsInverse = True Then lblDisplay.Text = Math.Log((Val(lblDisplay.Text.Replace("x10", "E")) + Math.Sqrt((Val(lblDisplay.Text.Replace("x10", "E"))) ^ 2 + 1)))
        Clearlbl1 = True
    End Sub

    Private Sub btnCosh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCosh.Click
        Number1 = CheckTrigUnit(Val(lblDisplay.Text.Replace("x10", "E")))
        If IsInverse = False Then lblDisplay.Text = Math.Cosh(Number1)
        If IsInverse = True Then lblDisplay.Text = Math.Log((Val(lblDisplay.Text.Replace("x10", "E")) + Math.Sqrt((Val(lblDisplay.Text.Replace("x10", "E"))) ^ 2 - 1)))
        Clearlbl1 = True
    End Sub

    Private Sub btnTanh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTanh.Click
        Number1 = CheckTrigUnit(Val(lblDisplay.Text.Replace("x10", "E")))
        If IsInverse = False Then lblDisplay.Text = Math.Tanh(Number1)
        If IsInverse = True Then lblDisplay.Text = (1 / 2 * (Math.Log((1 + Val(lblDisplay.Text.Replace("x10", "E"))) / (1 - Val(lblDisplay.Text.Replace("x10", "E"))))))
        Clearlbl1 = True
    End Sub

    Private Sub btnCosech_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCosech.Click
        Number1 = CheckTrigUnit(Val(lblDisplay.Text.Replace("x10", "E")))
        If IsInverse = False Then lblDisplay.Text = 1 / Math.Sinh(Number1)
        If IsInverse = True Then lblDisplay.Text = Math.Log((1 / Val(lblDisplay.Text.Replace("x10", "E")) + Math.Sqrt((1 / Val(lblDisplay.Text.Replace("x10", "E"))) ^ 2 + 1)))
        Clearlbl1 = True
    End Sub

    Private Sub btnSech_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSech.Click
        Number1 = CheckTrigUnit(Val(lblDisplay.Text.Replace("x10", "E")))
        If IsInverse = False Then lblDisplay.Text = 1 / Math.Cosh(Number1)
        If IsInverse = True Then lblDisplay.Text = Math.Log((1 / Val(lblDisplay.Text.Replace("x10", "E")) + Math.Sqrt((1 / Val(lblDisplay.Text.Replace("x10", "E"))) ^ 2 - 1)))
        Clearlbl1 = True
    End Sub

    Private Sub btnCoth_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCoth.Click
        Number1 = CheckTrigUnit(Val(lblDisplay.Text.Replace("x10", "E")))
        If IsInverse = False Then lblDisplay.Text = 1 / Math.Tanh(Number1)
        If IsInverse = True Then lblDisplay.Text = (1 / 2 * (Math.Log((1 + (1 / Val(lblDisplay.Text.Replace("x10", "E")))) / (1 - (1 / Val(lblDisplay.Text.Replace("x10", "E")))))))
        Clearlbl1 = True
    End Sub

    Private Sub btnInt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInt.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        lblDisplay.Text = Math.Truncate(Number1)
        Clearlbl1 = True
    End Sub

    Private Sub btnFrac_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFrac.Click
        Dim Fraction
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        Fraction = Number1 - Math.Truncate(Number1)
        lblDisplay.Text = Fraction
        Clearlbl1 = True
    End Sub

    Private Sub btnMod_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMod.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        HcalcOperator = "mod"
        lblDisplay.Text = Math.Truncate(Number1)
        Clearlbl1 = True
    End Sub

    Private Sub btnRnd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRnd.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        lblDisplay.Text = Math.Round(Number1)
        Clearlbl1 = True
    End Sub

    Private Sub btnRndr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRndr.Click
        lblDisplay.Text = Rnd()
        Clearlbl1 = True
    End Sub

    Private Sub btnDMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDMS.Click
        Dim deg, min, sec, a, b, c, d
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        deg = Math.Truncate(Number1)
        a = Number1 - deg
        b = a * 60
        min = Math.Truncate(b)
        c = b - min
        d = c * 60
        sec = d
        lblDisplay.Text = (deg.ToString + "˚" + min.ToString + "'" + sec.ToString + "''").ToString
        Clearlbl1 = True
    End Sub

    Private Sub btnDeg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeg.Click

    End Sub

    Private Sub btnDegreeMinuteSecond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDegreeMinuteSecond.Click

    End Sub

    Private Sub ribcmbDateSelectTyype_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ribcmbDateSelectTyype.SelectedIndexChanged
        DateCalcType = ribcmbDateSelectTyype.SelectedIndex

        Select Case ribcmbDateSelectTyype.SelectedIndex
            Case 0
                ribcmbDateSelectTyype.Visible = True
                lblFrom.TextLine1 = "From :"
                riblinFrom.Visible = True
                riblinTo.Visible = False
                riblinAddSubtract.Visible = True
                riblinYear.Visible = True
                riblinMonth.Visible = True
                riblinDay.Visible = True

            Case 1
                ribcmbDateSelectTyype.Visible = True
                lblFrom.TextLine1 = "Birthdate :"
                riblinFrom.Visible = True
                riblinTo.Visible = False
                riblinAddSubtract.Visible = False
                riblinYear.Visible = False
                riblinMonth.Visible = False
                riblinDay.Visible = False

            Case 2
                ribcmbDateSelectTyype.Visible = True
                lblFrom.TextLine1 = "From :"
                riblinFrom.Visible = True
                riblinTo.Visible = True
                riblinAddSubtract.Visible = False
                riblinYear.Visible = False
                riblinMonth.Visible = False
                riblinDay.Visible = False

        End Select

    End Sub

    Private Sub ribbtnDateCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ribbtnDateCalculate.Click
        Select Case DateCalcType
            Case 0
                If ribradAdd.Checked = True Then
                    lblDisplay.Text = (DateCalc(ribdtpFrom.Value, Today, "add", ribnudYear.Value, ribnudMonth.Value, ribnudDay.Value)).ToString
                ElseIf ribradSubtract.Checked = True Then
                    lblDisplay.Text = (DateCalc(ribdtpFrom.Value, Today, "sub", ribnudYear.Value, ribnudMonth.Value, ribnudDay.Value)).ToString
                End If

            Case 1
                Dim CurrentDate As Date = My.Computer.Clock.LocalTime.Date
                Dim tdays As Integer = DateDiff(DateInterval.Day, ribdtpFrom.Value, CurrentDate)
                DateCalc(ribdtpFrom.Value, CurrentDate)
                lblDisplay.Text = ("Age : " & years & " Year(s), " & months & " Month(s), " & days & " Day(s)" & "  ; " & " Difference(Days): " & tdays).ToString

            Case 2
                Dim date1, date2 As Date
                If ribdtpFrom.Value < ribdtpTo.Value Then
                    date1 = ribdtpFrom.Value
                    date2 = ribdtpTo.Value
                ElseIf ribdtpFrom.Value > ribdtpTo.Value Then
                    date1 = ribdtpTo.Value
                    date2 = ribdtpFrom.Value
                End If
                DateCalc(date1, date2)
                lblDisplay.Text = ("Difference : " & years & " Year(s), " & months & " Month(s), " & days & " Day(s)" & "  ; " & " Difference(Days): " & CInt(DateDiff(DateInterval.Day, date1, date2))).ToString

        End Select
        Clearlbl1 = True
    End Sub

    Private Sub btnPi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPi.Click
        lblDisplay.Text = Math.PI.ToString
        Clearlbl1 = True
    End Sub

    Private Sub btne_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btne.Click
        lblDisplay.Text = Math.E.ToString
        Clearlbl1 = True
    End Sub

    Private Sub btn2pi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn2pi.Click
        lblDisplay.Text = (Math.Pow(2, Math.PI)).ToString
    End Sub

    Private Sub btnGR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGR.Click
        Dim gr
        gr = ((1 + Math.Sqrt(5)) / 2)
        lblDisplay.Text = gr.ToString
        Clearlbl1 = True
    End Sub

    Private Sub btnG_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnG.Click
        Dim g
        g = ((6.6742) * 10 ^ (-11))
        lblDisplay.Text = g.ToString
        Clearlbl1 = True
    End Sub

    Private Sub btnga_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnga.Click
        Dim ga
        ga = 9.80665
        lblDisplay.Text = ga.ToString
        Clearlbl1 = True
    End Sub

    Private Sub btnh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnh.Click
        Dim h
        h = ((6.6260693) * 10 ^ (-34))
        lblDisplay.Text = h.ToString
        Clearlbl1 = True

    End Sub

    Private Sub btnrh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnrh.Click
        Dim rh
        rh = (((6.6260693) * 10 ^ (-11)) / (Math.PI * 2))
        lblDisplay.Text = rh.ToString
        Clearlbl1 = True

    End Sub

    Private Sub btnQATDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQATDelete.Click
        Try
            lblDisplay.Text = vbNullString
        Catch es As Exception
            MsgBox(es.Message)
        End Try
    End Sub

    Private Sub NeutrinoRibbon1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeutrinoRibbon1.SelectedTabChanged

    End Sub

    Private Sub btnPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaste.Click
        Try
            lblDisplay.Text = Clipboard.GetText()
        Catch es As Exception
            MsgBox(es.Message)
        End Try
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        CalcKeysActivate()

    End Sub


    Private Sub btnComAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnComAdd.Click
        Dim ap, bp
        Dim s As String = vbNullString
        ap = Val(txtComA.Text.ToString.Replace("x10", "E")) + Val(txtComX.Text.ToString.Replace("x10", "E"))
        bp = Val(txtComB.Text.ToString.Replace("x10", "E")) + Val(txtComY.Text.ToString.Replace("x10", "E"))
        If Math.Sign(bp) = 1 Then s = "+"
        If bp <> 0 Then lblDisplay.Text = (ap & " " & s & " " & bp & " i").ToString Else lblDisplay.Text = ap
        Clearlbl1 = True
    End Sub

    Private Sub btnComSubtraction_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnComSubtraction.Click
        Dim ap, bp
        Dim s As String = vbNullString
        ap = Val(txtComA.Text.ToString.Replace("x10", "E")) - Val(txtComX.Text.ToString.Replace("x10", "E"))
        bp = Val(txtComB.Text.ToString.Replace("x10", "E")) - Val(txtComY.Text.ToString.Replace("x10", "E"))
        If Math.Sign(bp) = 1 Then s = "+"
        If bp <> 0 Then lblDisplay.Text = (ap & " " & s & " " & bp & " i").ToString Else lblDisplay.Text = ap
        Clearlbl1 = True
    End Sub

   
    Private Sub btnComMultiple_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnComMultiple.Click
        Dim ap, bp
        Dim s As String = vbNullString
        ap = (Val(txtComA.Text.ToString.Replace("x10", "E")) * Val(txtComX.Text.ToString.Replace("x10", "E"))) - (Val(txtComB.Text.ToString.Replace("x10", "E")) * Val(txtComY.Text.ToString.Replace("x10", "E")))
        bp = (Val(txtComA.Text.ToString.Replace("x10", "E")) * Val(txtComY.Text.ToString.Replace("x10", "E"))) + (Val(txtComB.Text.ToString.Replace("x10", "E")) * Val(txtComX.Text.ToString.Replace("x10", "E")))
        If Math.Sign(bp) = 1 Then s = "+"
        If bp <> 0 Then lblDisplay.Text = (ap & " " & s & " " & bp & " i").ToString Else lblDisplay.Text = ap
        Clearlbl1 = True
    End Sub

    Private Sub btnComDivision_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnComDivision.Click
        Dim ap, bp, mods
        Dim s As String = vbNullString
        mods = Math.Sqrt(Math.Pow(Val(txtComX.Text.ToString.Replace("x10", "E")), 2) + Math.Pow(Val(txtComY.Text.ToString.Replace("x10", "E")), 2))
        ap = ((Val(txtComA.Text.ToString.Replace("x10", "E")) * Val(txtComX.Text.ToString.Replace("x10", "E"))) + (Val(txtComB.Text.ToString.Replace("x10", "E")) * Val(txtComY.Text.ToString.Replace("x10", "E")))) / mods
        bp = ((Val(txtComB.Text.ToString.Replace("x10", "E")) * Val(txtComX.Text.ToString.Replace("x10", "E"))) - (Val(txtComA.Text.ToString.Replace("x10", "E")) * Val(txtComY.Text.ToString.Replace("x10", "E")))) / mods
        If Math.Sign(bp) = 1 Then s = "+"
        If bp <> 0 Then lblDisplay.Text = (ap & " " & s & " " & bp & " i").ToString Else lblDisplay.Text = ap
        Clearlbl1 = True
    End Sub

    Private Sub btnComModulus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnComModulus.Click
        Dim r
        r = Math.Sqrt((Math.Pow(Val(txtComA.Text.ToString.Replace("x10", "E")), 2) + Math.Pow(Val(txtComB.Text.ToString.Replace("x10", "E")), 2)))
        lblDisplay.Text = r
        Clearlbl1 = True
    End Sub

    Private Sub btnComArgument_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnComArgument.Click
        Dim boa
        boa = (Val(txtComB.Text.ToString.Replace("x10", "E")) / Val(txtComA.Text.ToString.Replace("x10", "E")))
        lblDisplay.Text = CheckTrigUnit(Math.Atan(boa), True)
        Clearlbl1 = True
    End Sub

    Private Sub btnPolar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPolar.Click
        Dim r, theta
        r = Math.Sqrt((Math.Pow(Val(txtComA.Text.ToString.Replace("x10", "E")), 2) + Math.Pow(Val(txtComB.Text.ToString.Replace("x10", "E")), 2)))
        theta = CheckTrigUnit(Math.Atan((Val(txtComB.Text.ToString.Replace("x10", "E")) / Val(txtComA.Text.ToString.Replace("x10", "E")))), True)
        lblDisplay.Text = (r & " <" & theta).ToString
        Clearlbl1 = True
    End Sub

    Private Sub btnCartes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCartes.Click
        Dim a, b
        Dim s As String = vbNullString
        a = (Val(txtComA.Text.ToString.Replace("x10", "E")) * Math.Cos(txtComB.Text.ToString.Replace("x10", "E")))
        b = (Val(txtComA.Text.ToString.Replace("x10", "E")) * Math.Sin(txtComB.Text.ToString.Replace("x10", "E")))
        If Math.Sign(b) = 1 Then s = "+"
        If b <> 0 Then lblDisplay.Text = (a & " " & s & " " & b & " i").ToString Else lblDisplay.Text = a
        Clearlbl1 = True
    End Sub

    Private Sub btnComPower_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnComPower.Click
        Dim a, b, r1, theta, infrac, outfrac
        Dim s As String = vbNullString
        r1 = Math.Sqrt((Math.Pow(Val(txtComA.Text.ToString.Replace("x10", "E")), 2) + Math.Pow(Val(txtComB.Text.ToString.Replace("x10", "E")), 2)))
        theta = Math.Atan((Val(txtComB.Text.ToString.Replace("x10", "E")) / Val(txtComA.Text.ToString.Replace("x10", "E"))))
        outfrac = ((Math.Pow(r1, Val(txtComX.Text.ToString.Replace("x10", "E")))) / (Math.Pow(Math.E, (theta * Val(txtComY.Text.ToString.Replace("x10", "E"))))))
        infrac = (theta * Val(txtComX.Text.ToString.Replace("x10", "E"))) + (Val(txtComY.Text.ToString.Replace("x10", "E")) * (Math.Log(r1)))
        a = outfrac * Math.Cos(infrac)
        b = outfrac * Math.Sin(infrac)
        If Math.Sign(b) = 1 Then s = "+"
        If b <> 0 Then lblDisplay.Text = (a & " " & s & " " & b & " i").ToString Else lblDisplay.Text = a
        Clearlbl1 = True
    End Sub

    Private Sub btnComExp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnComExp.Click
        Dim a, b, r1, theta, infrac, outfrac
        Dim s As String = vbNullString
        r1 = Math.Sqrt((Math.Pow(Val(txtComA.Text.ToString.Replace("x10", "E")), 2) + Math.Pow(Val(txtComB.Text.ToString.Replace("x10", "E")), 2)))
        theta = Math.Atan((Val(txtComB.Text.ToString.Replace("x10", "E")) / Val(txtComA.Text.ToString.Replace("x10", "E"))))
        outfrac = ((Math.Pow(r1, Val(txtComX.Text.ToString.Replace("x10", "E")))) / (Math.Pow(Math.E, (theta * Val(txtComY.Text.ToString.Replace("x10", "E"))))))
        infrac = (theta * Val(txtComX.Text.ToString.Replace("x10", "E"))) + (Val(txtComY.Text.ToString.Replace("x10", "E")) * (Math.Log(r1)))
        a = outfrac * Math.Cos(infrac)
        b = outfrac * Math.Sin(infrac)
        If Math.Sign(b) = 1 Then s = "+"
        If b <> 0 Then lblDisplay.Text = (a & " " & s & " " & b & " i").ToString Else lblDisplay.Text = a
        Clearlbl1 = True
    End Sub

    Private Sub btnComRoot_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnComRoot.Click
        Dim a, b, r1, r2, theta, ninfrac, noutfrac, infrac, outfrac
        Dim s As String = vbNullString
        r1 = Math.Sqrt((Math.Pow(Val(txtComA.Text.ToString.Replace("x10", "E")), 2) + Math.Pow(Val(txtComB.Text.ToString.Replace("x10", "E")), 2)))
        r2 = Math.Sqrt((Math.Pow(Val(txtComX.Text.ToString.Replace("x10", "E")), 2) + Math.Pow(Val(txtComY.Text.ToString.Replace("x10", "E")), 2)))
        theta = Math.Atan((Val(txtComB.Text.ToString.Replace("x10", "E")) / Val(txtComA.Text.ToString.Replace("x10", "E"))))
        noutfrac = (Math.Pow(r1, Val(txtComX.Text.ToString.Replace("x10", "E"))) * Math.Pow(Math.E, (theta * Val(txtComY.Text.ToString.Replace("x10", "E")))))
        outfrac = Math.Pow(noutfrac, (1 / (Math.Pow(r2, 2))))
        ninfrac = (Val(txtComX.Text.ToString.Replace("x10", "E")) * theta) - (Val(txtComY.Text.ToString.Replace("x10", "E")) * Math.Log(r1))
        infrac = (ninfrac) / (Math.Pow(r2, 2))
        a = outfrac * Math.Cos(infrac)
        b = outfrac * Math.Sin(infrac)
        If Math.Sign(b) = 1 Then s = "+"
        If b <> 0 Then lblDisplay.Text = (a & " " & s & " " & b & " i").ToString Else lblDisplay.Text = a
        Clearlbl1 = True
    End Sub

    Private Sub btnComLog_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnComLog.Click
        Dim a, b, r1, r2, theta, phi, dinominator, numerator1, numerator2
        Dim s As String = vbNullString
        r1 = Math.Sqrt((Math.Pow(Val(txtComA.Text.ToString.Replace("x10", "E")), 2) + Math.Pow(Val(txtComB.Text.ToString.Replace("x10", "E")), 2)))
        r2 = Math.Sqrt((Math.Pow(Val(txtComX.Text.ToString.Replace("x10", "E")), 2) + Math.Pow(Val(txtComY.Text.ToString.Replace("x10", "E")), 2)))
        theta = Math.Atan((Val(txtComB.Text.ToString.Replace("x10", "E")) / Val(txtComA.Text.ToString.Replace("x10", "E"))))
        phi = Math.Atan((Val(txtComY.Text.ToString.Replace("x10", "E")) / Val(txtComX.Text.ToString.Replace("x10", "E"))))
        numerator1 = Math.Log(r1) * Math.Log(r2)
        numerator2 = (phi * Math.Log(r1)) - (theta * Math.Log(r2))
        dinominator = (Math.Pow((Math.Log(r1)), 2)) + Math.Pow(theta, 2)
        a = numerator1 / dinominator
        b = numerator2 / dinominator
        If Math.Sign(b) = 1 Then s = "+"
        If b <> 0 Then lblDisplay.Text = (a & " " & s & " " & b & " i").ToString Else lblDisplay.Text = a
        Clearlbl1 = True
    End Sub

    Private Sub btnSComLog_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSComLog.Click
        Dim a, b, r1, r2, theta, phi, dinominator, numerator1, numerator2
        Dim s As String = vbNullString
        r1 = Math.Sqrt((Math.Pow(Val(txtComA.Text.ToString.Replace("x10", "E")), 2) + Math.Pow(Val(txtComB.Text.ToString.Replace("x10", "E")), 2)))
        r2 = Math.Sqrt((Math.Pow(Val(txtComX.Text.ToString.Replace("x10", "E")), 2) + Math.Pow(Val(txtComY.Text.ToString.Replace("x10", "E")), 2)))
        theta = Math.Atan((Val(txtComB.Text.ToString.Replace("x10", "E")) / Val(txtComA.Text.ToString.Replace("x10", "E"))))
        phi = Math.Atan((Val(txtComY.Text.ToString.Replace("x10", "E")) / Val(txtComX.Text.ToString.Replace("x10", "E"))))
        numerator1 = Math.Log(r1) * Math.Log(r2)
        numerator2 = (phi * Math.Log(r1)) - (theta * Math.Log(r2))
        dinominator = (Math.Pow((Math.Log(r1)), 2)) + Math.Pow(theta, 2)
        a = numerator1 / dinominator
        b = numerator2 / dinominator
        If Math.Sign(b) = 1 Then s = "+"
        If b <> 0 Then lblDisplay.Text = (a & " " & s & " " & b & " i").ToString Else lblDisplay.Text = a
        Clearlbl1 = True
    End Sub

    Private Sub btnComLn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnComLn.Click
        Dim a, b, phi, r2
        Dim s As String = vbNullString
        r2 = Math.Sqrt((Math.Pow(Val(txtComX.Text.ToString.Replace("x10", "E")), 2) + Math.Pow(Val(txtComY.Text.ToString.Replace("x10", "E")), 2)))
        phi = Math.Atan((Val(txtComY.Text.ToString.Replace("x10", "E")) / Val(txtComX.Text.ToString.Replace("x10", "E"))))
        a = Math.Log(r2)
        b = (phi)
        If Math.Sign(b) = 1 Then s = "+"
        If b <> 0 Then lblDisplay.Text = (a & " " & s & " " & b & " i").ToString Else lblDisplay.Text = a
        Clearlbl1 = True
    End Sub

    Private Sub ribchkStat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ribchkStat.Click
        If ribchkStat.Checked = True Then
            grpStatistics.Visible = True
        ElseIf ribchkStat.Checked = False Then
            grpStatistics.Visible = False
        End If
    End Sub

    Private Sub btnStatEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatEnter.Click
        Try
            lstboxStatistics.Items.Add(Val(txtStatistics.Text))
            txtStatistics.Text = Nothing
            txtStatistics.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnStatRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatRemove.Click
        Try
            lstboxStatistics.Items.RemoveAt(lstboxStatistics.SelectedIndex)
            txtStatistics.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub KryptonButton12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton12.Click
        Try
            lstboxStatistics.Items.Clear()
            txtStatistics.Focus()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnStatSx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatSx.Click
        Dim x(7000) As Double
        Dim i As Integer = 0
        Dim c As Integer
        Dim StatResult As Double = 0

        For Each Item As Double In lstboxStatistics.Items
            x(i) = Item
            i += 1
        Next
        For c = 0 To i
            StatResult = StatResult + x(c)
        Next
        lblDisplay.Text = StatResult
        Clearlbl1 = True
    End Sub

    Private Sub btnStatSx2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatSx2.Click
        Dim x(7000) As Double
        Dim i As Integer = 0
        Dim c As Integer
        Dim StatResult As Double = 0

        For Each Item As Double In lstboxStatistics.Items
            x(i) = Item
            i += 1
        Next
        For c = 0 To i
            StatResult = StatResult + x(c) * x(c)
        Next
        lblDisplay.Text = StatResult
        Clearlbl1 = True
    End Sub

    Private Sub btnStatSxx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatSxx.Click
        Dim x(7000) As Double
        Dim i As Integer = 0
        Dim c As Integer
        Dim StatResult As Double = 1

        For Each Item As Double In lstboxStatistics.Items
            x(i) = Item
            i += 1
        Next
        For c = 0 To lstboxStatistics.Items.Count - 1
            StatResult = StatResult * x(c)
        Next
        lblDisplay.Text = StatResult
        Clearlbl1 = True
    End Sub

    Private Sub btnStatXbar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatXbar.Click
        Dim x(7000) As Double
        Dim i As Integer = 0
        Dim c As Integer
        Dim StatResult As Double = 0

        For Each Item As Double In lstboxStatistics.Items
            x(i) = Item
            i += 1
        Next
        For c = 0 To i
            StatResult = StatResult + x(c)
        Next
        StatResult = StatResult / i
        lblDisplay.Text = StatResult
        Clearlbl1 = True
    End Sub

    Private Sub btnStatX2bar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatX2bar.Click
        Dim x(7000) As Double
        Dim i As Integer = 0
        Dim c As Integer
        Dim StatResult As Double = 0

        For Each Item As Double In lstboxStatistics.Items
            x(i) = Item
            i += 1
        Next
        For c = 0 To i
            StatResult = StatResult + x(c) * x(c)
        Next
        StatResult = StatResult / i
        lblDisplay.Text = StatResult
        Clearlbl1 = True
    End Sub

    Private Sub btnStatSigmaN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatSigmaN.Click
        Dim x(7000) As Double
        Dim i As Integer = 0
        Dim c As Integer
        Dim Average As Double = 0
        Dim StatResult As Double = 0

        For Each Item As Double In lstboxStatistics.Items
            x(i) = Item
            i += 1
        Next
        For c = 0 To i
            Average = Average + x(c)
        Next
        Average = Average / i

        For c = 0 To i
            StatResult = StatResult + (Math.Pow((x(c) - Average), 2))
        Next
        StatResult = StatResult / i
        lblDisplay.Text = Math.Sqrt(StatResult)
        Clearlbl1 = True
    End Sub

    Private Sub btnStatSigmaN1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatSigmaN1.Click
        Dim x(7000) As Double
        Dim i As Integer = 0
        Dim c As Integer
        Dim Average As Double = 0
        Dim StatResult As Double = 0

        For Each Item As Double In lstboxStatistics.Items
            x(i) = Item
            i += 1
        Next
        For c = 0 To i
            Average = Average + x(c)
        Next
        Average = Average / i

        For c = 0 To i
            StatResult = StatResult + (Math.Pow((x(c) - Average), 2))
        Next
        StatResult = StatResult / (i - 1)
        lblDisplay.Text = Math.Sqrt(StatResult)
        Clearlbl1 = True
    End Sub

   
End Class
