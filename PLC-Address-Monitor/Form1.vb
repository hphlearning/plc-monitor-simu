Public Class Form1
    ' 实例化随机数生成器，用于模拟 PLC 数据
    Private rand As New Random()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 初始化 Timer 设置
        tmrMonitor.Interval = 500 ' 设置为500毫秒刷新一次
        tmrMonitor.Enabled = False ' 初始状态不运行
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        tmrMonitor.Start()
        btnStart.Enabled = False ' 防止重复点击
        btnStart.Text = "监视运行中..."
    End Sub

    Private Sub lblTemp_Click(sender As Object, e As EventArgs) Handles lblTemp.Click

    End Sub

    Private Sub lblPress_Click(sender As Object, e As EventArgs) Handles lblPress.Click

    End Sub

    Private Sub lblVolt_Click(sender As Object, e As EventArgs) Handles lblVolt.Click

    End Sub

    Private Sub tmrMonitor_Tick(sender As Object, e As EventArgs) Handles tmrMonitor.Tick
        ' 1. 模拟获取 PLC 数据 (生成随机数)
        Dim currentTemp As Double = rand.Next(20, 100) ' 模拟温度 20-100度
        Dim currentPress As Double = rand.NextDouble() * 10 ' 模拟压力 0-10Mpa
        Dim currentVolt As Double = rand.Next(210, 230) ' 模拟电压 210-230V

        ' 2. 更新界面显示
        lblTemp.Text = $"温度: {currentTemp:F1} ℃"
        lblPress.Text = $"压力: {currentPress:F2} Mpa"
        lblVolt.Text = $"电压: {currentVolt:F1} V"

        ' 3. 报警逻辑判断 (核心考点)
        If currentTemp > 80 Then
            ' 超过 80 度，触发红色背景报警
            lblTemp.BackColor = Color.Red
            lblTemp.ForeColor = Color.White
        Else
            ' 正常范围内，恢复默认颜色
            lblTemp.BackColor = SystemColors.Control
            lblTemp.ForeColor = Color.Black
        End If
    End Sub
End Class
