Public Class Form1
    Inherits System.Windows.Forms.Form
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

#Region " Windows ������������ɵĴ��� "

    Public Sub New()

        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    '������д dispose ����������б�
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        MyBase.Dispose(disposing)
    End Sub

    'ע��: ���¹����� Windows ����������������
    '����ʹ�� Windows ����������޸Ĵ˹��̡�
    '��Ҫʹ�ô���༭���޸�����
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
        Me.Text = "ľ��"

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
            MsgBox("��������" + "����������" + Str(c))


        End If

        Beep()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        StatusBar1.Text = "ʱ�䣺" + Now + "�ܹ��£�" + Str(a)

    End Sub

    
End Class
