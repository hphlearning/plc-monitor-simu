<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblTemp = New Label()
        lblPress = New Label()
        lblVolt = New Label()
        tmrMonitor = New Timer(components)
        btnStart = New Button()
        SuspendLayout()
        ' 
        ' lblTemp
        ' 
        lblTemp.AutoSize = True
        lblTemp.Location = New Point(261, 127)
        lblTemp.Name = "lblTemp"
        lblTemp.Size = New Size(104, 24)
        lblTemp.TabIndex = 0
        lblTemp.Text = "温度: 0.0 ℃"
        ' 
        ' lblPress
        ' 
        lblPress.AutoSize = True
        lblPress.Location = New Point(261, 169)
        lblPress.Name = "lblPress"
        lblPress.Size = New Size(126, 24)
        lblPress.TabIndex = 1
        lblPress.Text = "压力: 0.0 Mpa"
        ' 
        ' lblVolt
        ' 
        lblVolt.AutoSize = True
        lblVolt.Location = New Point(261, 216)
        lblVolt.Name = "lblVolt"
        lblVolt.Size = New Size(98, 24)
        lblVolt.TabIndex = 2
        lblVolt.Text = "电压: 0.0 V"
        ' 
        ' tmrMonitor
        ' 
        tmrMonitor.Interval = 500
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(544, 157)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(112, 34)
        btnStart.TabIndex = 3
        btnStart.Text = "开始监视"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 24F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnStart)
        Controls.Add(lblVolt)
        Controls.Add(lblPress)
        Controls.Add(lblTemp)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTemp As Label
    Friend WithEvents lblPress As Label
    Friend WithEvents lblVolt As Label
    Friend WithEvents tmrMonitor As Timer
    Friend WithEvents btnStart As Button

End Class
