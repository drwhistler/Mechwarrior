<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SystemName = New System.Windows.Forms.TextBox()
        Me.MissionType = New System.Windows.Forms.ComboBox()
        Me.Employer = New System.Windows.Forms.ComboBox()
        Me.Target = New System.Windows.Forms.ComboBox()
        Me.Limit = New System.Windows.Forms.ComboBox()
        Me.Difficulty = New System.Windows.Forms.TextBox()
        Me.SaveMission = New System.Windows.Forms.Button()
        Me.MissionDetails = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Result = New System.Windows.Forms.ComboBox()
        Me.SaveLog = New System.Windows.Forms.Button()
        Me.Reload = New System.Windows.Forms.Button()
        Me.NewFactionName = New System.Windows.Forms.TextBox()
        Me.SaveNewFaction = New System.Windows.Forms.Button()
        Me.NewMissionType = New System.Windows.Forms.TextBox()
        Me.SaveMissonType = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SystemName
        '
        Me.SystemName.Location = New System.Drawing.Point(49, 87)
        Me.SystemName.Name = "SystemName"
        Me.SystemName.Size = New System.Drawing.Size(100, 20)
        Me.SystemName.TabIndex = 0
        Me.SystemName.Text = "System"
        '
        'MissionType
        '
        Me.MissionType.FormattingEnabled = True
        Me.MissionType.Location = New System.Drawing.Point(49, 114)
        Me.MissionType.Name = "MissionType"
        Me.MissionType.Size = New System.Drawing.Size(121, 21)
        Me.MissionType.TabIndex = 1
        Me.MissionType.Text = "Mission Type"
        '
        'Employer
        '
        Me.Employer.FormattingEnabled = True
        Me.Employer.Location = New System.Drawing.Point(49, 142)
        Me.Employer.Name = "Employer"
        Me.Employer.Size = New System.Drawing.Size(121, 21)
        Me.Employer.TabIndex = 2
        Me.Employer.Text = "Employer"
        '
        'Target
        '
        Me.Target.FormattingEnabled = True
        Me.Target.Location = New System.Drawing.Point(49, 170)
        Me.Target.Name = "Target"
        Me.Target.Size = New System.Drawing.Size(121, 21)
        Me.Target.TabIndex = 3
        Me.Target.Text = "Target"
        '
        'Limit
        '
        Me.Limit.FormattingEnabled = True
        Me.Limit.Location = New System.Drawing.Point(49, 198)
        Me.Limit.Name = "Limit"
        Me.Limit.Size = New System.Drawing.Size(121, 21)
        Me.Limit.TabIndex = 4
        Me.Limit.Text = "Limit"
        '
        'Difficulty
        '
        Me.Difficulty.Location = New System.Drawing.Point(49, 226)
        Me.Difficulty.Name = "Difficulty"
        Me.Difficulty.Size = New System.Drawing.Size(100, 20)
        Me.Difficulty.TabIndex = 5
        Me.Difficulty.Text = "Difficulty"
        '
        'SaveMission
        '
        Me.SaveMission.Location = New System.Drawing.Point(49, 252)
        Me.SaveMission.Name = "SaveMission"
        Me.SaveMission.Size = New System.Drawing.Size(75, 23)
        Me.SaveMission.TabIndex = 6
        Me.SaveMission.Text = "Save"
        Me.SaveMission.UseVisualStyleBackColor = True
        '
        'MissionDetails
        '
        Me.MissionDetails.AutoSize = True
        Me.MissionDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MissionDetails.Location = New System.Drawing.Point(27, 49)
        Me.MissionDetails.Name = "MissionDetails"
        Me.MissionDetails.Size = New System.Drawing.Size(159, 26)
        Me.MissionDetails.TabIndex = 7
        Me.MissionDetails.Text = "Mission Details"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(547, 97)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'Result
        '
        Me.Result.FormattingEnabled = True
        Me.Result.Location = New System.Drawing.Point(655, 123)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(92, 21)
        Me.Result.TabIndex = 9
        Me.Result.Text = "Result"
        '
        'SaveLog
        '
        Me.SaveLog.Location = New System.Drawing.Point(672, 151)
        Me.SaveLog.Name = "SaveLog"
        Me.SaveLog.Size = New System.Drawing.Size(75, 23)
        Me.SaveLog.TabIndex = 10
        Me.SaveLog.Text = "Save Log"
        Me.SaveLog.UseVisualStyleBackColor = True
        '
        'Reload
        '
        Me.Reload.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reload.Location = New System.Drawing.Point(576, 444)
        Me.Reload.Name = "Reload"
        Me.Reload.Size = New System.Drawing.Size(171, 42)
        Me.Reload.TabIndex = 17
        Me.Reload.Text = "Reload"
        Me.Reload.UseVisualStyleBackColor = True
        '
        'NewFactionName
        '
        Me.NewFactionName.Location = New System.Drawing.Point(617, 198)
        Me.NewFactionName.Name = "NewFactionName"
        Me.NewFactionName.Size = New System.Drawing.Size(129, 20)
        Me.NewFactionName.TabIndex = 18
        '
        'SaveNewFaction
        '
        Me.SaveNewFaction.Location = New System.Drawing.Point(637, 222)
        Me.SaveNewFaction.Name = "SaveNewFaction"
        Me.SaveNewFaction.Size = New System.Drawing.Size(108, 23)
        Me.SaveNewFaction.TabIndex = 19
        Me.SaveNewFaction.Text = "Save New Faction"
        Me.SaveNewFaction.UseVisualStyleBackColor = True
        '
        'NewMissionType
        '
        Me.NewMissionType.Location = New System.Drawing.Point(617, 274)
        Me.NewMissionType.Name = "NewMissionType"
        Me.NewMissionType.Size = New System.Drawing.Size(127, 20)
        Me.NewMissionType.TabIndex = 20
        '
        'SaveMissonType
        '
        Me.SaveMissonType.Location = New System.Drawing.Point(637, 301)
        Me.SaveMissonType.Name = "SaveMissonType"
        Me.SaveMissonType.Size = New System.Drawing.Size(106, 23)
        Me.SaveMissonType.TabIndex = 21
        Me.SaveMissonType.Text = "Save New Mission"
        Me.SaveMissonType.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(798, 507)
        Me.Controls.Add(Me.SaveMissonType)
        Me.Controls.Add(Me.NewMissionType)
        Me.Controls.Add(Me.SaveNewFaction)
        Me.Controls.Add(Me.NewFactionName)
        Me.Controls.Add(Me.Reload)
        Me.Controls.Add(Me.SaveLog)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.MissionDetails)
        Me.Controls.Add(Me.SaveMission)
        Me.Controls.Add(Me.Difficulty)
        Me.Controls.Add(Me.Limit)
        Me.Controls.Add(Me.Target)
        Me.Controls.Add(Me.Employer)
        Me.Controls.Add(Me.MissionType)
        Me.Controls.Add(Me.SystemName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Mechwarrior"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MissionDetails As Label
    Friend WithEvents SystemName As TextBox
    Friend WithEvents MissionType As ComboBox
    Friend WithEvents Employer As ComboBox
    Friend WithEvents Target As ComboBox
    Friend WithEvents Limit As ComboBox
    Friend WithEvents Difficulty As TextBox
    Friend WithEvents SaveMission As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Result As ComboBox
    Friend WithEvents SaveLog As Button
    Friend WithEvents Reload As Button
    Friend WithEvents NewFactionName As TextBox
    Friend WithEvents SaveNewFaction As Button
    Friend WithEvents NewMissionType As TextBox
    Friend WithEvents SaveMissonType As Button
End Class
