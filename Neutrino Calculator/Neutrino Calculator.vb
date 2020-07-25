
Public Class NeutrinoCalculator
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

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
            Case "Mod"
                CheckedNumber = Number1 Mod Number2
            Case "perm"
                CheckedNumber = CombinatoricsCalc(Number1, Number2, "perm")
            Case "comb"
                CheckedNumber = CombinatoricsCalc(Number1, Number2, "comb")
            Case "exp"
                CheckedNumber = Number1 * Math.Pow(10, Number2)
            Case vbNullString
                CheckedNumber = Val(lblDisplay.Text.Replace("x10", "E"))
        End Select
        HcalcOperator = vbNullString
        Return CheckedNumber
    End Function


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDisplay.Click



    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click, btn00.Click, btnDot.Click
        IsOperator = False
        IsEqual = False
        If Clearlbl1 = True Then
            If sender.text = "." Then
                lblDisplay.Text = "0" + sender.text
                IsDot = True
            Else
                lblDisplay.Text = sender.text
                IsDot = False
            End If
            Clearlbl1 = False
        ElseIf Clearlbl1 = False Then
            If sender.text = "." Then
                If IsDot = False Then
                    lblDisplay.Text = lblDisplay.Text + sender.text
                    IsDot = True
                End If
            Else
                lblDisplay.Text = lblDisplay.Text + sender.text

            End If
        End If
        If Clearlbl2 = True Then
            lblDispalyOperation.Text = vbNullString
            Clearlbl2 = False
        End If

        lblDispalyOperation.Text = lblDispalyOperation.Text + sender.text
    End Sub

    Private Sub btnAC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAC.Click

        HcalcOperator = vbNullString
        calcOperator = vbNullString

        Result = 0
        Clearlbl1 = True
        Clearlbl2 = True
        IsDot = False
        IsInitial = True
        lblDisplay.Text = vbNullString
        lblDispalyOperation.Text = vbNullString


    End Sub

    Private Sub btnPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus.Click

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
                calcOperator = "+"
            End If
            IsInitial = False
            IsOperator = True
        End If

ExitArg:
        IsContinue = True
        IsInitial = False
        IsOperator = True
        calcOperator = "+"
        lblDispalyOperation.Text = lblDispalyOperation.Text + " + "
        Exit Sub

    End Sub

    Private Sub btnMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus.Click

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
                calcOperator = "-"
            End If
            IsInitial = False
            IsOperator = True
        End If

ExitArg:
        IsContinue = True
        IsInitial = False
        IsOperator = True
        calcOperator = "-"
        lblDispalyOperation.Text = lblDispalyOperation.Text + " -"
        Exit Sub

    End Sub

    Private Sub btnMultiplication_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiplication.Click

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
                calcOperator = "*"
            End If
            IsInitial = False
            IsOperator = True
        End If

ExitArg:
        IsContinue = True
        IsInitial = False
        IsOperator = True
        calcOperator = "*"
        lblDispalyOperation.Text = lblDispalyOperation.Text + " * "
        Exit Sub

    End Sub

    Private Sub btnDivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivision.Click
        On Error Resume Next

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
                calcOperator = "/"
            End If
            IsInitial = False
            IsOperator = True
        End If

ExitArg:
        IsContinue = True
        IsInitial = False
        IsOperator = True
        calcOperator = "/"
        lblDispalyOperation.Text = lblDispalyOperation.Text + " / "
        Exit Sub

    End Sub

    Private Sub btnPlusMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlusMinus.Click
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

    Private Sub btnInverseX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInverseX.Click
        'calcOperator = "1/x"
        Number1 = Val(lblDisplay.Text)
        lblDispalyOperation.Text = "1/" + Number1.ToString

        lblDisplay.Text = 1 / Number1
        Clearlbl1 = True
        Clearlbl2 = True
    End Sub

    Private Sub btnPercent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPercent.Click
        'calcOperator = "%"

        Number1 = Val(lblDisplay.Text)
        lblDispalyOperation.Text = Number1.ToString + " %"

        lblDisplay.Text = Number1 / 100
        Clearlbl1 = True
        Clearlbl2 = True
    End Sub

    Private Sub btnRoot2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoot2.Click

        Number1 = Val(lblDisplay.Text)


        lblDisplay.Text = Math.Sqrt(Number1)
        lblDispalyOperation.Text = lblDispalyOperation.Text + " √ (" + Number1.ToString + ")"
        Clearlbl1 = True
        Clearlbl2 = True
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

        lblDisplay.Text = Result
        Result = 0
        lblDispalyOperation.Text = lblDispalyOperation.Text + " ="
        Clearlbl1 = True
        Clearlbl2 = True
        Number1 = 0
    End Sub

    Private Sub NeutrinoCalculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IsInverse = False
        btnSin.Font = New Font(btnSin.Font.Name, 8)
        btnSin.Text = "sin"
        btnSinh.Font = New Font(btnSin.Font.Name, 8)
        btnSinh.Text = "sinh"
        btnCos.Font = New Font(btnSin.Font.Name, 8)
        btnCos.Text = "cos"
        btnCosh.Font = New Font(btnSin.Font.Name, 8)
        btnCosh.Text = "cosh"
        btnTan.Font = New Font(btnSin.Font.Name, 8)
        btnTan.Text = "tan"
        btnTanh.Font = New Font(btnSin.Font.Name, 8)
        btnTanh.Text = "tanh"
        radDegree.Checked = True

        HcalcOperator = vbNullString
        calcOperator = vbNullString

        Result = 0
        CalcMemory = 0
        Clearlbl1 = True
        Clearlbl2 = True
        IsInitial = True
        lblDisplay.Text = vbNullString
        lblDispalyOperation.Text = vbNullString

       
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInverse.CheckedChanged
        If chkInverse.Checked = True Then
            IsInverse = True
            btnSin.Font = New Font(btnSin.Font.Name, 7)
            btnSin.Text = "sinˉ¹"
            btnSinh.Font = New Font(btnSin.Font.Name, 6)
            btnSinh.Text = "sinhˉ¹"
            btnCos.Font = New Font(btnSin.Font.Name, 7)
            btnCos.Text = "cosˉ¹"
            btnCosh.Font = New Font(btnSin.Font.Name, 6)
            btnCosh.Text = "coshˉ¹"
            btnTan.Font = New Font(btnSin.Font.Name, 7)
            btnTan.Text = "tanˉ¹"
            btnTanh.Font = New Font(btnSin.Font.Name, 6)
            btnTanh.Text = "tanhˉ¹"

        ElseIf chkInverse.Checked = False Then
            IsInverse = False
            btnSin.Font = New Font(btnSin.Font.Name, 8)
            btnSin.Text = "sin"
            btnSinh.Font = New Font(btnSin.Font.Name, 8)
            btnSinh.Text = "sinh"
            btnCos.Font = New Font(btnSin.Font.Name, 8)
            btnCos.Text = "cos"
            btnCosh.Font = New Font(btnSin.Font.Name, 8)
            btnCosh.Text = "cosh"
            btnTan.Font = New Font(btnSin.Font.Name, 8)
            btnTan.Text = "tan"
            btnTanh.Font = New Font(btnSin.Font.Name, 8)
            btnTanh.Text = "tanh"
        End If
    End Sub

    Private Sub btnFactorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFactorial.Click
        Dim Factorial As String = 1, i
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        If Number1 = 0 Then Factorial = 1
        For i = 1 To Number1
            Factorial = Factorial * i

        Next
        lblDisplay.Text = CDbl(Factorial)
        Clearlbl1 = True
    End Sub

    Private Sub btnSquare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSquare.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        lblDisplay.Text = Number1 * Number1
        Clearlbl1 = True
    End Sub

    Private Sub btnBackS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackS.Click
        On Error Resume Next
        If lblDisplay.Text <> vbNullString Then
            Dim backspacestring As String = lblDisplay.Text.Remove(Len(lblDisplay.Text) - 1, 1)
            'Dim backspacestring2 As String = lblDispalyOperation.Text.Remove(Len(lblDispalyOperation.Text) - 1, 1)
            lblDisplay.Text = backspacestring
            'lblDispalyOperation.Text = backspacestring2

        End If
    End Sub

    Private Sub btnE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnE.Click
        lblDisplay.Text = Math.E
        Clearlbl1 = True
    End Sub

    Private Sub btnPi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPi.Click
        lblDisplay.Text = Math.PI
        Clearlbl1 = True
    End Sub

    Private Sub btnYrootX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYrootX.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))

        HcalcOperator = "yroot"
        Clearlbl1 = True
    End Sub

    Private Sub btn3RootX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3RootX.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        lblDisplay.Text = Math.Pow(Number1, 1 / 3)
        Clearlbl1 = True
    End Sub

    Private Sub btn10X_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn10X.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        lblDisplay.Text = Math.Pow(10, Number1)
        Clearlbl1 = True
    End Sub

    Private Sub btnXY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXY.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))

        HcalcOperator = "pow"
        Clearlbl1 = True
    End Sub

    Private Sub btnQube_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQube.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        lblDisplay.Text = Number1 * Number1 * Number1
        Clearlbl1 = True
    End Sub

    Private Sub btneX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneX.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        lblDisplay.Text = Math.Exp(Number1)
        Clearlbl1 = True
    End Sub

    Private Sub btnLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLog.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        lblDisplay.Text = Math.Log10(Number1)
        Clearlbl1 = True
    End Sub

    Private Sub btnLn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLn.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        lblDisplay.Text = Math.Log(Number1)
        Clearlbl1 = True
    End Sub

    Private Sub btnRandom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRandom.Click
        lblDisplay.Text = Rnd()
        Clearlbl1 = True
    End Sub

    Private Sub btnRnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRnd.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        lblDisplay.Text = Math.Round(Number1)
        Clearlbl1 = True
    End Sub

    Private Sub btnSin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSin.Click
        Number1 = CheckTrigUnit(Val(lblDisplay.Text.Replace("x10", "E")))
        If IsInverse = False Then lblDisplay.Text = Math.Sin(Number1)
        If IsInverse = True Then lblDisplay.Text = CheckTrigUnit(Math.Asin(Val(lblDisplay.Text.Replace("x10", "E"))), True)
        Clearlbl1 = True
    End Sub

    Private Sub btnCos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCos.Click
        Number1 = CheckTrigUnit(Val(lblDisplay.Text.Replace("x10", "E")))
        If IsInverse = False Then lblDisplay.Text = Math.Cos(Number1)
        If IsInverse = True Then lblDisplay.Text = CheckTrigUnit(Math.Acos(Val(lblDisplay.Text.Replace("x10", "E"))), True)
        Clearlbl1 = True
    End Sub

    Private Sub btnTan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTan.Click
        Number1 = CheckTrigUnit(Val(lblDisplay.Text.Replace("x10", "E")))
        If IsInverse = False Then lblDisplay.Text = Math.Sin(Number1) / Math.Cos(Number1)
        If IsInverse = True Then lblDisplay.Text = CheckTrigUnit(Math.Atan(Val(lblDisplay.Text.Replace("x10", "E"))), True)
        Clearlbl1 = True
    End Sub

    Private Sub btnSinh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSinh.Click
        Number1 = CheckTrigUnit(Val(lblDisplay.Text.Replace("x10", "E")))
        If IsInverse = False Then lblDisplay.Text = Math.Sinh(Number1)
        If IsInverse = True Then lblDisplay.Text = Math.Log((Val(lblDisplay.Text.Replace("x10", "E")) + Math.Sqrt((Val(lblDisplay.Text.Replace("x10", "E"))) ^ 2 + 1)))
        Clearlbl1 = True
    End Sub

    Private Sub btnCosh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCosh.Click
        Number1 = CheckTrigUnit(Val(lblDisplay.Text.Replace("x10", "E")))
        If IsInverse = False Then lblDisplay.Text = Math.Cosh(Number1)
        If IsInverse = True Then lblDisplay.Text = Math.Log((Val(lblDisplay.Text.Replace("x10", "E")) + Math.Sqrt((Val(lblDisplay.Text.Replace("x10", "E"))) ^ 2 - 1)))
        Clearlbl1 = True
    End Sub

    Private Sub btnTanh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTanh.Click
        Number1 = CheckTrigUnit(Val(lblDisplay.Text.Replace("x10", "E")))
        If IsInverse = False Then lblDisplay.Text = Math.Tanh(Number1)
        If IsInverse = True Then lblDisplay.Text = (1 / 2 * (Math.Log((1 + Val(lblDisplay.Text.Replace("x10", "E"))) / (1 - Val(lblDisplay.Text.Replace("x10", "E"))))))
        Clearlbl1 = True
    End Sub

    Private Sub btnInt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInt.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        lblDisplay.Text = Math.Truncate(Number1)
        Clearlbl1 = True
    End Sub

    Private Sub btnFrac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrac.Click
        Dim Fraction
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        Fraction = lblDisplay.Text.Replace(Math.Truncate(Number1), "0")
        lblDisplay.Text = Fraction
        Clearlbl1 = True
    End Sub

    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        lblDisplay.Text = Math.Truncate(Number1)
        Clearlbl1 = True
    End Sub

    Private Sub btnnPr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnPr.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))

        HcalcOperator = "perm"
        Clearlbl1 = True
    End Sub

    Private Sub btnExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExp.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))
        lblDisplay.Text += "x10"
        HcalcOperator = "exp"
        Clearlbl1 = True
    End Sub

    Private Sub btnnCr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnCr.Click
        Number1 = Val(lblDisplay.Text.Replace("x10", "E"))

        HcalcOperator = "comb"
        Clearlbl1 = True
    End Sub

    Private Sub radDegree_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radDegree.CheckedChanged

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        Dim ConvertExp As String = lblDisplay.Text
        ConvertExp = ConvertExp.Replace("E", "x10")
        lblDisplay.Text = ConvertExp

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CalcMemory = Val(lblDisplay.Text.Replace("x10", "E"))

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CalcMemory = CalcMemory + Val(lblDisplay.Text.Replace("x10", "E"))

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CalcMemory = CalcMemory - Val(lblDisplay.Text.Replace("x10", "E"))
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        CalcMemory = CalcMemory * Val(lblDisplay.Text.Replace("x10", "E"))
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        CalcMemory = CalcMemory / Val(lblDisplay.Text.Replace("x10", "E"))
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        lblDisplay.Text = CalcMemory.ToString.Replace("E", "x10")

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        CalcMemory = 0

    End Sub

    Private Sub Button2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.DoubleClick
        My.Settings.Memory = CalcMemory

    End Sub
End Class
