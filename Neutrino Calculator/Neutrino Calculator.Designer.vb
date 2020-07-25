<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NeutrinoCalculator
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NeutrinoCalculator))
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.lblDispalyOperation = New System.Windows.Forms.Label()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnPlusMinus = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnMultiplication = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnRoot2 = New System.Windows.Forms.Button()
        Me.btnPercent = New System.Windows.Forms.Button()
        Me.btnInverseX = New System.Windows.Forms.Button()
        Me.btnEqual = New System.Windows.Forms.Button()
        Me.btnDot = New System.Windows.Forms.Button()
        Me.btn00 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btnBackS = New System.Windows.Forms.Button()
        Me.btnAC = New System.Windows.Forms.Button()
        Me.btnFactorial = New System.Windows.Forms.Button()
        Me.btnYrootX = New System.Windows.Forms.Button()
        Me.btn3RootX = New System.Windows.Forms.Button()
        Me.btn10X = New System.Windows.Forms.Button()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnExp = New System.Windows.Forms.Button()
        Me.btnQube = New System.Windows.Forms.Button()
        Me.btnXY = New System.Windows.Forms.Button()
        Me.btnSquare = New System.Windows.Forms.Button()
        Me.btnSin = New System.Windows.Forms.Button()
        Me.btnCos = New System.Windows.Forms.Button()
        Me.btnTan = New System.Windows.Forms.Button()
        Me.btnSinh = New System.Windows.Forms.Button()
        Me.btnCosh = New System.Windows.Forms.Button()
        Me.btnTanh = New System.Windows.Forms.Button()
        Me.btnInt = New System.Windows.Forms.Button()
        Me.btnFrac = New System.Windows.Forms.Button()
        Me.btnPi = New System.Windows.Forms.Button()
        Me.btneX = New System.Windows.Forms.Button()
        Me.btnLn = New System.Windows.Forms.Button()
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.btnRnd = New System.Windows.Forms.Button()
        Me.btnnPr = New System.Windows.Forms.Button()
        Me.btnnCr = New System.Windows.Forms.Button()
        Me.btnE = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.radGradient = New System.Windows.Forms.RadioButton()
        Me.radRadian = New System.Windows.Forms.RadioButton()
        Me.radDegree = New System.Windows.Forms.RadioButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.chkInverse = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassicModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BasicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScientificToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeutrinoModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KryptonManager2 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDisplay
        '
        Me.lblDisplay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDisplay.BackColor = System.Drawing.Color.Snow
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplay.Font = New System.Drawing.Font("Century Schoolbook", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.ForeColor = System.Drawing.Color.Black
        Me.lblDisplay.Location = New System.Drawing.Point(0, 52)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(518, 49)
        Me.lblDisplay.TabIndex = 0
        Me.lblDisplay.Text = "1234567890"
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDispalyOperation
        '
        Me.lblDispalyOperation.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.lblDispalyOperation.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDispalyOperation.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispalyOperation.ForeColor = System.Drawing.Color.Black
        Me.lblDispalyOperation.Location = New System.Drawing.Point(0, 24)
        Me.lblDispalyOperation.Name = "lblDispalyOperation"
        Me.lblDispalyOperation.Size = New System.Drawing.Size(518, 28)
        Me.lblDispalyOperation.TabIndex = 2
        Me.lblDispalyOperation.Text = "1234567890"
        Me.lblDispalyOperation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPlus
        '
        Me.btnPlus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPlus.BackColor = System.Drawing.SystemColors.Control
        Me.btnPlus.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.ForeColor = System.Drawing.Color.Black
        Me.btnPlus.Location = New System.Drawing.Point(420, 308)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(34, 37)
        Me.btnPlus.TabIndex = 3
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnPlusMinus
        '
        Me.btnPlusMinus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPlusMinus.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnPlusMinus.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlusMinus.ForeColor = System.Drawing.Color.Black
        Me.btnPlusMinus.Location = New System.Drawing.Point(420, 156)
        Me.btnPlusMinus.Name = "btnPlusMinus"
        Me.btnPlusMinus.Size = New System.Drawing.Size(34, 33)
        Me.btnPlusMinus.TabIndex = 4
        Me.btnPlusMinus.Text = "±"
        Me.btnPlusMinus.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDivision.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnDivision.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivision.ForeColor = System.Drawing.Color.Black
        Me.btnDivision.Location = New System.Drawing.Point(420, 195)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(34, 33)
        Me.btnDivision.TabIndex = 5
        Me.btnDivision.Text = "/"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'btnMultiplication
        '
        Me.btnMultiplication.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMultiplication.BackColor = System.Drawing.SystemColors.Control
        Me.btnMultiplication.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplication.ForeColor = System.Drawing.Color.Black
        Me.btnMultiplication.Location = New System.Drawing.Point(420, 233)
        Me.btnMultiplication.Name = "btnMultiplication"
        Me.btnMultiplication.Size = New System.Drawing.Size(34, 33)
        Me.btnMultiplication.TabIndex = 6
        Me.btnMultiplication.Text = "*"
        Me.btnMultiplication.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinus.BackColor = System.Drawing.SystemColors.Control
        Me.btnMinus.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinus.ForeColor = System.Drawing.Color.Black
        Me.btnMinus.Location = New System.Drawing.Point(420, 269)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(34, 33)
        Me.btnMinus.TabIndex = 7
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnRoot2
        '
        Me.btnRoot2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRoot2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnRoot2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoot2.ForeColor = System.Drawing.Color.Black
        Me.btnRoot2.Location = New System.Drawing.Point(460, 156)
        Me.btnRoot2.Name = "btnRoot2"
        Me.btnRoot2.Size = New System.Drawing.Size(46, 33)
        Me.btnRoot2.TabIndex = 8
        Me.btnRoot2.Text = "√"
        Me.btnRoot2.UseVisualStyleBackColor = True
        '
        'btnPercent
        '
        Me.btnPercent.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPercent.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnPercent.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPercent.ForeColor = System.Drawing.Color.Black
        Me.btnPercent.Location = New System.Drawing.Point(460, 195)
        Me.btnPercent.Name = "btnPercent"
        Me.btnPercent.Size = New System.Drawing.Size(46, 33)
        Me.btnPercent.TabIndex = 9
        Me.btnPercent.Text = "%"
        Me.btnPercent.UseVisualStyleBackColor = True
        '
        'btnInverseX
        '
        Me.btnInverseX.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInverseX.BackColor = System.Drawing.SystemColors.Control
        Me.btnInverseX.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInverseX.ForeColor = System.Drawing.Color.Black
        Me.btnInverseX.Location = New System.Drawing.Point(460, 234)
        Me.btnInverseX.Name = "btnInverseX"
        Me.btnInverseX.Size = New System.Drawing.Size(46, 33)
        Me.btnInverseX.TabIndex = 10
        Me.btnInverseX.Text = "1/x"
        Me.btnInverseX.UseVisualStyleBackColor = True
        '
        'btnEqual
        '
        Me.btnEqual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEqual.BackColor = System.Drawing.SystemColors.Control
        Me.btnEqual.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEqual.ForeColor = System.Drawing.Color.Black
        Me.btnEqual.Location = New System.Drawing.Point(460, 273)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(46, 72)
        Me.btnEqual.TabIndex = 11
        Me.btnEqual.Text = "="
        Me.btnEqual.UseVisualStyleBackColor = True
        '
        'btnDot
        '
        Me.btnDot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDot.BackColor = System.Drawing.SystemColors.Control
        Me.btnDot.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDot.ForeColor = System.Drawing.Color.Black
        Me.btnDot.Location = New System.Drawing.Point(380, 310)
        Me.btnDot.Name = "btnDot"
        Me.btnDot.Size = New System.Drawing.Size(34, 35)
        Me.btnDot.TabIndex = 12
        Me.btnDot.Text = "."
        Me.btnDot.UseVisualStyleBackColor = True
        '
        'btn00
        '
        Me.btn00.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn00.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn00.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn00.ForeColor = System.Drawing.Color.Black
        Me.btn00.Location = New System.Drawing.Point(298, 310)
        Me.btn00.Name = "btn00"
        Me.btn00.Size = New System.Drawing.Size(36, 35)
        Me.btn00.TabIndex = 14
        Me.btn00.Text = "00"
        Me.btn00.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn0.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn0.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.ForeColor = System.Drawing.Color.Black
        Me.btn0.Location = New System.Drawing.Point(340, 310)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(34, 35)
        Me.btn0.TabIndex = 15
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn3.BackColor = System.Drawing.SystemColors.Control
        Me.btn3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.ForeColor = System.Drawing.Color.Black
        Me.btn3.Location = New System.Drawing.Point(380, 271)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(34, 33)
        Me.btn3.TabIndex = 16
        Me.btn3.Tag = "3"
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn9.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn9.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.ForeColor = System.Drawing.Color.Black
        Me.btn9.Location = New System.Drawing.Point(380, 195)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(34, 33)
        Me.btn9.TabIndex = 17
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn8.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.ForeColor = System.Drawing.Color.Black
        Me.btn8.Location = New System.Drawing.Point(340, 195)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(34, 33)
        Me.btn8.TabIndex = 18
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn7.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.ForeColor = System.Drawing.Color.Black
        Me.btn7.Location = New System.Drawing.Point(297, 195)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(34, 33)
        Me.btn7.TabIndex = 19
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn4.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.ForeColor = System.Drawing.Color.Black
        Me.btn4.Location = New System.Drawing.Point(298, 232)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(34, 33)
        Me.btn4.TabIndex = 20
        Me.btn4.Tag = ""
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn5.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.ForeColor = System.Drawing.Color.Black
        Me.btn5.Location = New System.Drawing.Point(340, 232)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(34, 33)
        Me.btn5.TabIndex = 21
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn6.BackColor = System.Drawing.SystemColors.Control
        Me.btn6.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.ForeColor = System.Drawing.Color.Black
        Me.btn6.Location = New System.Drawing.Point(380, 232)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(34, 33)
        Me.btn6.TabIndex = 22
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.Color.Black
        Me.btn1.Location = New System.Drawing.Point(298, 271)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(36, 33)
        Me.btn1.TabIndex = 23
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.Color.Black
        Me.btn2.Location = New System.Drawing.Point(340, 271)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(34, 33)
        Me.btn2.TabIndex = 24
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btnBackS
        '
        Me.btnBackS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBackS.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBackS.Font = New System.Drawing.Font("Courier New", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackS.ForeColor = System.Drawing.Color.Black
        Me.btnBackS.Image = CType(resources.GetObject("btnBackS.Image"), System.Drawing.Image)
        Me.btnBackS.Location = New System.Drawing.Point(297, 156)
        Me.btnBackS.Name = "btnBackS"
        Me.btnBackS.Size = New System.Drawing.Size(77, 34)
        Me.btnBackS.TabIndex = 25
        Me.btnBackS.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBackS.UseVisualStyleBackColor = True
        '
        'btnAC
        '
        Me.btnAC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAC.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAC.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAC.ForeColor = System.Drawing.Color.Black
        Me.btnAC.Location = New System.Drawing.Point(380, 156)
        Me.btnAC.Name = "btnAC"
        Me.btnAC.Size = New System.Drawing.Size(34, 33)
        Me.btnAC.TabIndex = 27
        Me.btnAC.Text = "AC"
        Me.btnAC.UseVisualStyleBackColor = True
        '
        'btnFactorial
        '
        Me.btnFactorial.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFactorial.Font = New System.Drawing.Font("Courier New", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactorial.ForeColor = System.Drawing.Color.Black
        Me.btnFactorial.Location = New System.Drawing.Point(244, 197)
        Me.btnFactorial.Name = "btnFactorial"
        Me.btnFactorial.Size = New System.Drawing.Size(34, 33)
        Me.btnFactorial.TabIndex = 28
        Me.btnFactorial.Tag = ""
        Me.btnFactorial.Text = "n!"
        Me.btnFactorial.UseVisualStyleBackColor = True
        '
        'btnYrootX
        '
        Me.btnYrootX.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnYrootX.Font = New System.Drawing.Font("Courier New", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYrootX.ForeColor = System.Drawing.Color.Black
        Me.btnYrootX.Location = New System.Drawing.Point(244, 235)
        Me.btnYrootX.Name = "btnYrootX"
        Me.btnYrootX.Size = New System.Drawing.Size(34, 33)
        Me.btnYrootX.TabIndex = 29
        Me.btnYrootX.Tag = ""
        Me.btnYrootX.Text = "y√x"
        Me.btnYrootX.UseVisualStyleBackColor = True
        '
        'btn3RootX
        '
        Me.btn3RootX.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn3RootX.Font = New System.Drawing.Font("Courier New", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3RootX.ForeColor = System.Drawing.Color.Black
        Me.btn3RootX.Location = New System.Drawing.Point(243, 273)
        Me.btn3RootX.Name = "btn3RootX"
        Me.btn3RootX.Size = New System.Drawing.Size(34, 33)
        Me.btn3RootX.TabIndex = 30
        Me.btn3RootX.Tag = ""
        Me.btn3RootX.Text = "3√x"
        Me.btn3RootX.UseVisualStyleBackColor = True
        '
        'btn10X
        '
        Me.btn10X.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn10X.Font = New System.Drawing.Font("Courier New", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn10X.ForeColor = System.Drawing.Color.Black
        Me.btn10X.Location = New System.Drawing.Point(243, 311)
        Me.btn10X.Name = "btn10X"
        Me.btn10X.Size = New System.Drawing.Size(34, 35)
        Me.btn10X.TabIndex = 31
        Me.btn10X.Tag = ""
        Me.btn10X.Text = "10^x"
        Me.btn10X.UseVisualStyleBackColor = True
        '
        'btnLog
        '
        Me.btnLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLog.Font = New System.Drawing.Font("Courier New", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLog.ForeColor = System.Drawing.Color.Black
        Me.btnLog.Location = New System.Drawing.Point(157, 310)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(43, 36)
        Me.btnLog.TabIndex = 32
        Me.btnLog.Tag = ""
        Me.btnLog.Text = "log"
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMod.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMod.ForeColor = System.Drawing.Color.Black
        Me.btnMod.Location = New System.Drawing.Point(13, 199)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(44, 33)
        Me.btnMod.TabIndex = 33
        Me.btnMod.Tag = ""
        Me.btnMod.Text = "Mod"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnExp
        '
        Me.btnExp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExp.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExp.ForeColor = System.Drawing.Color.Black
        Me.btnExp.Location = New System.Drawing.Point(13, 237)
        Me.btnExp.Name = "btnExp"
        Me.btnExp.Size = New System.Drawing.Size(44, 33)
        Me.btnExp.TabIndex = 34
        Me.btnExp.Tag = ""
        Me.btnExp.Text = "Exp"
        Me.btnExp.UseVisualStyleBackColor = True
        '
        'btnQube
        '
        Me.btnQube.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnQube.Font = New System.Drawing.Font("Courier New", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQube.ForeColor = System.Drawing.Color.Black
        Me.btnQube.Location = New System.Drawing.Point(205, 273)
        Me.btnQube.Name = "btnQube"
        Me.btnQube.Size = New System.Drawing.Size(34, 33)
        Me.btnQube.TabIndex = 35
        Me.btnQube.Tag = ""
        Me.btnQube.Text = "x³"
        Me.btnQube.UseVisualStyleBackColor = True
        '
        'btnXY
        '
        Me.btnXY.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnXY.Font = New System.Drawing.Font("Courier New", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXY.ForeColor = System.Drawing.Color.Black
        Me.btnXY.Location = New System.Drawing.Point(205, 235)
        Me.btnXY.Name = "btnXY"
        Me.btnXY.Size = New System.Drawing.Size(34, 33)
        Me.btnXY.TabIndex = 36
        Me.btnXY.Tag = ""
        Me.btnXY.Text = "x^y"
        Me.btnXY.UseVisualStyleBackColor = True
        '
        'btnSquare
        '
        Me.btnSquare.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSquare.Font = New System.Drawing.Font("Courier New", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSquare.ForeColor = System.Drawing.Color.Black
        Me.btnSquare.Location = New System.Drawing.Point(205, 197)
        Me.btnSquare.Name = "btnSquare"
        Me.btnSquare.Size = New System.Drawing.Size(34, 33)
        Me.btnSquare.TabIndex = 37
        Me.btnSquare.Tag = ""
        Me.btnSquare.Text = "x²"
        Me.btnSquare.UseVisualStyleBackColor = True
        '
        'btnSin
        '
        Me.btnSin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSin.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSin.ForeColor = System.Drawing.Color.Black
        Me.btnSin.Location = New System.Drawing.Point(157, 198)
        Me.btnSin.Name = "btnSin"
        Me.btnSin.Size = New System.Drawing.Size(43, 33)
        Me.btnSin.TabIndex = 38
        Me.btnSin.Tag = ""
        Me.btnSin.Text = "sin"
        Me.btnSin.UseVisualStyleBackColor = True
        '
        'btnCos
        '
        Me.btnCos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCos.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCos.ForeColor = System.Drawing.Color.Black
        Me.btnCos.Location = New System.Drawing.Point(157, 236)
        Me.btnCos.Name = "btnCos"
        Me.btnCos.Size = New System.Drawing.Size(43, 33)
        Me.btnCos.TabIndex = 39
        Me.btnCos.Tag = ""
        Me.btnCos.Text = "cos"
        Me.btnCos.UseVisualStyleBackColor = True
        '
        'btnTan
        '
        Me.btnTan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTan.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTan.ForeColor = System.Drawing.Color.Black
        Me.btnTan.Location = New System.Drawing.Point(157, 273)
        Me.btnTan.Name = "btnTan"
        Me.btnTan.Size = New System.Drawing.Size(43, 33)
        Me.btnTan.TabIndex = 40
        Me.btnTan.Tag = ""
        Me.btnTan.Text = "tan"
        Me.btnTan.UseVisualStyleBackColor = True
        '
        'btnSinh
        '
        Me.btnSinh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSinh.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSinh.ForeColor = System.Drawing.Color.Black
        Me.btnSinh.Location = New System.Drawing.Point(109, 198)
        Me.btnSinh.Name = "btnSinh"
        Me.btnSinh.Size = New System.Drawing.Size(43, 34)
        Me.btnSinh.TabIndex = 41
        Me.btnSinh.Tag = ""
        Me.btnSinh.Text = "sinh"
        Me.btnSinh.UseVisualStyleBackColor = True
        '
        'btnCosh
        '
        Me.btnCosh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCosh.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCosh.ForeColor = System.Drawing.Color.Black
        Me.btnCosh.Location = New System.Drawing.Point(109, 235)
        Me.btnCosh.Name = "btnCosh"
        Me.btnCosh.Size = New System.Drawing.Size(43, 33)
        Me.btnCosh.TabIndex = 42
        Me.btnCosh.Tag = ""
        Me.btnCosh.Text = "cosh"
        Me.btnCosh.UseVisualStyleBackColor = True
        '
        'btnTanh
        '
        Me.btnTanh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTanh.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTanh.ForeColor = System.Drawing.Color.Black
        Me.btnTanh.Location = New System.Drawing.Point(109, 273)
        Me.btnTanh.Name = "btnTanh"
        Me.btnTanh.Size = New System.Drawing.Size(43, 33)
        Me.btnTanh.TabIndex = 43
        Me.btnTanh.Tag = ""
        Me.btnTanh.Text = "tanh"
        Me.btnTanh.UseVisualStyleBackColor = True
        '
        'btnInt
        '
        Me.btnInt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnInt.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInt.ForeColor = System.Drawing.Color.Black
        Me.btnInt.Location = New System.Drawing.Point(60, 198)
        Me.btnInt.Name = "btnInt"
        Me.btnInt.Size = New System.Drawing.Size(44, 33)
        Me.btnInt.TabIndex = 44
        Me.btnInt.Tag = ""
        Me.btnInt.Text = "Int"
        Me.btnInt.UseVisualStyleBackColor = True
        '
        'btnFrac
        '
        Me.btnFrac.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFrac.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrac.ForeColor = System.Drawing.Color.Black
        Me.btnFrac.Location = New System.Drawing.Point(60, 236)
        Me.btnFrac.Name = "btnFrac"
        Me.btnFrac.Size = New System.Drawing.Size(44, 33)
        Me.btnFrac.TabIndex = 45
        Me.btnFrac.Tag = ""
        Me.btnFrac.Text = "Frac"
        Me.btnFrac.UseVisualStyleBackColor = True
        '
        'btnPi
        '
        Me.btnPi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPi.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPi.ForeColor = System.Drawing.Color.Black
        Me.btnPi.Location = New System.Drawing.Point(244, 156)
        Me.btnPi.Name = "btnPi"
        Me.btnPi.Size = New System.Drawing.Size(33, 33)
        Me.btnPi.TabIndex = 46
        Me.btnPi.Tag = ""
        Me.btnPi.Text = "π"
        Me.btnPi.UseVisualStyleBackColor = True
        '
        'btneX
        '
        Me.btneX.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btneX.Font = New System.Drawing.Font("Courier New", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneX.ForeColor = System.Drawing.Color.Black
        Me.btneX.Location = New System.Drawing.Point(205, 310)
        Me.btneX.Name = "btneX"
        Me.btneX.Size = New System.Drawing.Size(33, 36)
        Me.btneX.TabIndex = 47
        Me.btneX.Tag = ""
        Me.btneX.Text = "e^x"
        Me.btneX.UseVisualStyleBackColor = True
        '
        'btnLn
        '
        Me.btnLn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLn.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLn.ForeColor = System.Drawing.Color.Black
        Me.btnLn.Location = New System.Drawing.Point(109, 310)
        Me.btnLn.Name = "btnLn"
        Me.btnLn.Size = New System.Drawing.Size(43, 36)
        Me.btnLn.TabIndex = 49
        Me.btnLn.Tag = ""
        Me.btnLn.Text = "ln"
        Me.btnLn.UseVisualStyleBackColor = True
        '
        'btnRandom
        '
        Me.btnRandom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRandom.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRandom.ForeColor = System.Drawing.Color.Black
        Me.btnRandom.Location = New System.Drawing.Point(60, 312)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(44, 34)
        Me.btnRandom.TabIndex = 50
        Me.btnRandom.Tag = ""
        Me.btnRandom.Text = "Rnd#"
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'btnRnd
        '
        Me.btnRnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRnd.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRnd.ForeColor = System.Drawing.Color.Black
        Me.btnRnd.Location = New System.Drawing.Point(13, 313)
        Me.btnRnd.Name = "btnRnd"
        Me.btnRnd.Size = New System.Drawing.Size(44, 33)
        Me.btnRnd.TabIndex = 51
        Me.btnRnd.Tag = ""
        Me.btnRnd.Text = "Rnd"
        Me.btnRnd.UseVisualStyleBackColor = True
        '
        'btnnPr
        '
        Me.btnnPr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnnPr.Font = New System.Drawing.Font("Courier New", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnPr.ForeColor = System.Drawing.Color.Black
        Me.btnnPr.Location = New System.Drawing.Point(60, 273)
        Me.btnnPr.Name = "btnnPr"
        Me.btnnPr.Size = New System.Drawing.Size(44, 33)
        Me.btnnPr.TabIndex = 52
        Me.btnnPr.Tag = ""
        Me.btnnPr.Text = "nPr"
        Me.btnnPr.UseVisualStyleBackColor = True
        '
        'btnnCr
        '
        Me.btnnCr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnnCr.Font = New System.Drawing.Font("Courier New", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnCr.ForeColor = System.Drawing.Color.Black
        Me.btnnCr.Location = New System.Drawing.Point(13, 272)
        Me.btnnCr.Name = "btnnCr"
        Me.btnnCr.Size = New System.Drawing.Size(44, 33)
        Me.btnnCr.TabIndex = 53
        Me.btnnCr.Tag = ""
        Me.btnnCr.Text = "nCr"
        Me.btnnCr.UseVisualStyleBackColor = True
        '
        'btnE
        '
        Me.btnE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnE.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnE.ForeColor = System.Drawing.Color.Black
        Me.btnE.Location = New System.Drawing.Point(206, 156)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(33, 33)
        Me.btnE.TabIndex = 54
        Me.btnE.Tag = ""
        Me.btnE.Text = "e"
        Me.btnE.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.radGradient)
        Me.Panel1.Controls.Add(Me.radRadian)
        Me.Panel1.Controls.Add(Me.radDegree)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(13, 115)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(187, 34)
        Me.Panel1.TabIndex = 55
        '
        'radGradient
        '
        Me.radGradient.AutoSize = True
        Me.radGradient.Location = New System.Drawing.Point(132, 7)
        Me.radGradient.Name = "radGradient"
        Me.radGradient.Size = New System.Drawing.Size(53, 17)
        Me.radGradient.TabIndex = 2
        Me.radGradient.TabStop = True
        Me.radGradient.Text = "Grads"
        Me.radGradient.UseVisualStyleBackColor = True
        '
        'radRadian
        '
        Me.radRadian.AutoSize = True
        Me.radRadian.Location = New System.Drawing.Point(68, 8)
        Me.radRadian.Name = "radRadian"
        Me.radRadian.Size = New System.Drawing.Size(64, 17)
        Me.radRadian.TabIndex = 1
        Me.radRadian.TabStop = True
        Me.radRadian.Text = "Radians"
        Me.radRadian.UseVisualStyleBackColor = True
        '
        'radDegree
        '
        Me.radDegree.AutoSize = True
        Me.radDegree.Location = New System.Drawing.Point(3, 7)
        Me.radDegree.Name = "radDegree"
        Me.radDegree.Size = New System.Drawing.Size(65, 17)
        Me.radDegree.TabIndex = 0
        Me.radDegree.TabStop = True
        Me.radDegree.Text = "Degrees"
        Me.radDegree.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(518, 353)
        Me.ShapeContainer1.TabIndex = 56
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 287
        Me.LineShape1.X2 = 287
        Me.LineShape1.Y1 = 161
        Me.LineShape1.Y2 = 344
        '
        'chkInverse
        '
        Me.chkInverse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkInverse.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkInverse.CheckAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.chkInverse.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInverse.ForeColor = System.Drawing.Color.Black
        Me.chkInverse.Location = New System.Drawing.Point(11, 156)
        Me.chkInverse.Name = "chkInverse"
        Me.chkInverse.Size = New System.Drawing.Size(188, 33)
        Me.chkInverse.TabIndex = 57
        Me.chkInverse.Text = "Inverse Trigonometry"
        Me.chkInverse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkInverse.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(420, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 34)
        Me.Button1.TabIndex = 58
        Me.Button1.Tag = ""
        Me.Button1.Text = "M+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(463, 115)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 34)
        Me.Button2.TabIndex = 59
        Me.Button2.Tag = ""
        Me.Button2.Text = "MS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(380, 115)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(34, 34)
        Me.Button3.TabIndex = 60
        Me.Button3.Tag = ""
        Me.Button3.Text = "M-"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button4.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(337, 115)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(34, 35)
        Me.Button4.TabIndex = 61
        Me.Button4.Tag = ""
        Me.Button4.Text = "M*"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button5.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(297, 115)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(34, 36)
        Me.Button5.TabIndex = 62
        Me.Button5.Tag = ""
        Me.Button5.Text = "M/"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button6.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(206, 115)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(32, 36)
        Me.Button6.TabIndex = 63
        Me.Button6.Tag = ""
        Me.Button6.Text = "MC"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button7.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Location = New System.Drawing.Point(244, 115)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(33, 36)
        Me.Button7.TabIndex = 64
        Me.Button7.Tag = ""
        Me.Button7.Text = "MR"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ModeToolStripMenuItem
        '
        Me.ModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClassicModeToolStripMenuItem, Me.NeutrinoModeToolStripMenuItem})
        Me.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem"
        Me.ModeToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.ModeToolStripMenuItem.Text = "Mode"
        '
        'ClassicModeToolStripMenuItem
        '
        Me.ClassicModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BasicToolStripMenuItem, Me.ScientificToolStripMenuItem})
        Me.ClassicModeToolStripMenuItem.Name = "ClassicModeToolStripMenuItem"
        Me.ClassicModeToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ClassicModeToolStripMenuItem.Text = "Classic Mode"
        '
        'BasicToolStripMenuItem
        '
        Me.BasicToolStripMenuItem.Name = "BasicToolStripMenuItem"
        Me.BasicToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.BasicToolStripMenuItem.Text = "Basic"
        '
        'ScientificToolStripMenuItem
        '
        Me.ScientificToolStripMenuItem.Name = "ScientificToolStripMenuItem"
        Me.ScientificToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ScientificToolStripMenuItem.Text = "Scientific"
        '
        'NeutrinoModeToolStripMenuItem
        '
        Me.NeutrinoModeToolStripMenuItem.Name = "NeutrinoModeToolStripMenuItem"
        Me.NeutrinoModeToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.NeutrinoModeToolStripMenuItem.Text = "Neutrino Mode"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ModeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(518, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NeutrinoCalculator
        '
        Me.AcceptButton = Me.btnAC
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(518, 353)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkInverse)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnE)
        Me.Controls.Add(Me.btnnCr)
        Me.Controls.Add(Me.btnnPr)
        Me.Controls.Add(Me.btnRnd)
        Me.Controls.Add(Me.btnRandom)
        Me.Controls.Add(Me.btnLn)
        Me.Controls.Add(Me.btneX)
        Me.Controls.Add(Me.btnPi)
        Me.Controls.Add(Me.btnFrac)
        Me.Controls.Add(Me.btnInt)
        Me.Controls.Add(Me.btnTanh)
        Me.Controls.Add(Me.btnCosh)
        Me.Controls.Add(Me.btnSinh)
        Me.Controls.Add(Me.btnTan)
        Me.Controls.Add(Me.btnCos)
        Me.Controls.Add(Me.btnSin)
        Me.Controls.Add(Me.btnSquare)
        Me.Controls.Add(Me.btnXY)
        Me.Controls.Add(Me.btnQube)
        Me.Controls.Add(Me.btnExp)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnLog)
        Me.Controls.Add(Me.btn10X)
        Me.Controls.Add(Me.btn3RootX)
        Me.Controls.Add(Me.btnYrootX)
        Me.Controls.Add(Me.btnFactorial)
        Me.Controls.Add(Me.btnAC)
        Me.Controls.Add(Me.btnBackS)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn00)
        Me.Controls.Add(Me.btnDot)
        Me.Controls.Add(Me.btnEqual)
        Me.Controls.Add(Me.btnInverseX)
        Me.Controls.Add(Me.btnPercent)
        Me.Controls.Add(Me.btnRoot2)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnMultiplication)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnPlusMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.lblDispalyOperation)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "NeutrinoCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Neutrino Calculator"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents lblDispalyOperation As System.Windows.Forms.Label
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents btnPlusMinus As System.Windows.Forms.Button
    Friend WithEvents btnDivision As System.Windows.Forms.Button
    Friend WithEvents btnMultiplication As System.Windows.Forms.Button
    Friend WithEvents btnMinus As System.Windows.Forms.Button
    Friend WithEvents btnRoot2 As System.Windows.Forms.Button
    Friend WithEvents btnPercent As System.Windows.Forms.Button
    Friend WithEvents btnInverseX As System.Windows.Forms.Button
    Friend WithEvents btnEqual As System.Windows.Forms.Button
    Friend WithEvents btnDot As System.Windows.Forms.Button
    Friend WithEvents btn00 As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btnBackS As System.Windows.Forms.Button
    Friend WithEvents btnAC As System.Windows.Forms.Button
    Friend WithEvents btnFactorial As System.Windows.Forms.Button
    Friend WithEvents btnYrootX As System.Windows.Forms.Button
    Friend WithEvents btn3RootX As System.Windows.Forms.Button
    Friend WithEvents btn10X As System.Windows.Forms.Button
    Friend WithEvents btnLog As System.Windows.Forms.Button
    Friend WithEvents btnMod As System.Windows.Forms.Button
    Friend WithEvents btnExp As System.Windows.Forms.Button
    Friend WithEvents btnQube As System.Windows.Forms.Button
    Friend WithEvents btnXY As System.Windows.Forms.Button
    Friend WithEvents btnSquare As System.Windows.Forms.Button
    Friend WithEvents btnSin As System.Windows.Forms.Button
    Friend WithEvents btnCos As System.Windows.Forms.Button
    Friend WithEvents btnTan As System.Windows.Forms.Button
    Friend WithEvents btnSinh As System.Windows.Forms.Button
    Friend WithEvents btnCosh As System.Windows.Forms.Button
    Friend WithEvents btnTanh As System.Windows.Forms.Button
    Friend WithEvents btnInt As System.Windows.Forms.Button
    Friend WithEvents btnFrac As System.Windows.Forms.Button
    Friend WithEvents btnPi As System.Windows.Forms.Button
    Friend WithEvents btneX As System.Windows.Forms.Button
    Friend WithEvents btnLn As System.Windows.Forms.Button
    Friend WithEvents btnRandom As System.Windows.Forms.Button
    Friend WithEvents btnRnd As System.Windows.Forms.Button
    Friend WithEvents btnnPr As System.Windows.Forms.Button
    Friend WithEvents btnnCr As System.Windows.Forms.Button
    Friend WithEvents btnE As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents radGradient As System.Windows.Forms.RadioButton
    Friend WithEvents radRadian As System.Windows.Forms.RadioButton
    Friend WithEvents radDegree As System.Windows.Forms.RadioButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents chkInverse As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassicModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BasicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScientificToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NeutrinoModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents KryptonManager2 As ComponentFactory.Krypton.Toolkit.KryptonManager

End Class
