Public Class Form1
    Inherits System.Windows.Forms.Form
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()

        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写 dispose 以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        MyBase.Dispose(disposing)
    End Sub

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.Timer1 = New System.Windows.Forms.Timer
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Size = New System.Drawing.Size(224, 168)
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 189)
        Me.StatusBar1.Size = New System.Drawing.Size(234, 22)
        Me.StatusBar1.Text = "StatusBar1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 168)
        Me.ProgressBar1.Size = New System.Drawing.Size(216, 20)
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(234, 211)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Text = "木鱼"

    End Sub

    Public Shared Sub Main()
        Application.Run(New Form1)
    End Sub

#End Region
    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        a = a + 1
        b = b + 1
        ProgressBar1.Value = b
        If b = 100 Then
            b = 0
            c = c + 1
            MsgBox("功德已满" + "集满次数：" + Str(c))


        End If

        Beep()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        StatusBar1.Text = "时间：" + Now + "总功德：" + Str(a)

    End Sub

    
End Class
