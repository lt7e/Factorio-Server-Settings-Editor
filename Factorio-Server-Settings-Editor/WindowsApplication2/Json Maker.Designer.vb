<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Factorio_Json_Editor
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblTags = New System.Windows.Forms.Label()
        Me.lblPlayers = New System.Windows.Forms.Label()
        Me.lblVisibility = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblGamePassword = New System.Windows.Forms.Label()
        Me.lblUserVarification = New System.Windows.Forms.Label()
        Me.lblUploadSpd = New System.Windows.Forms.Label()
        Me.lnlMinLatency = New System.Windows.Forms.Label()
        Me.lblPlayerLimitIgnore = New System.Windows.Forms.Label()
        Me.lblAllowCommands = New System.Windows.Forms.Label()
        Me.lblAutosaveInterval = New System.Windows.Forms.Label()
        Me.lblAutosaveSlots = New System.Windows.Forms.Label()
        Me.lblAFKKickTime = New System.Windows.Forms.Label()
        Me.lblAutoPause = New System.Windows.Forms.Label()
        Me.lblAdminPause = New System.Windows.Forms.Label()
        Me.lblAutosaveLocation = New System.Windows.Forms.Label()
        Me.lblAdmins = New System.Windows.Forms.Label()
        Me.tbServerName = New System.Windows.Forms.TextBox()
        Me.tbDescription = New System.Windows.Forms.TextBox()
        Me.tbTags = New System.Windows.Forms.TextBox()
        Me.tbMaxPlayers = New System.Windows.Forms.TextBox()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.tbGamePassword = New System.Windows.Forms.TextBox()
        Me.tbUploadSpd = New System.Windows.Forms.TextBox()
        Me.tbMinLatency = New System.Windows.Forms.TextBox()
        Me.tbAutosaveInterval = New System.Windows.Forms.TextBox()
        Me.tbAdmins = New System.Windows.Forms.TextBox()
        Me.cbVisibility = New System.Windows.Forms.ComboBox()
        Me.cbUserVarification = New System.Windows.Forms.ComboBox()
        Me.cbIgnorePLayerLimit = New System.Windows.Forms.ComboBox()
        Me.cbAllowCommands = New System.Windows.Forms.ComboBox()
        Me.cbAutosaveSlot = New System.Windows.Forms.ComboBox()
        Me.cbAFKKick = New System.Windows.Forms.ComboBox()
        Me.cbAutoPause = New System.Windows.Forms.ComboBox()
        Me.cbAdminPause = New System.Windows.Forms.ComboBox()
        Me.cbAutosaveServer = New System.Windows.Forms.ComboBox()
        Me.btnMake = New System.Windows.Forms.Button()
        Me.lblServerJsonLocation = New System.Windows.Forms.Label()
        Me.tbJsonLocation = New System.Windows.Forms.TextBox()
        Me.tbJsonName = New System.Windows.Forms.TextBox()
        Me.lblJsonName = New System.Windows.Forms.Label()
        Me.lblServerJsonLocDesc = New System.Windows.Forms.Label()
        Me.lblJsonNameDesc = New System.Windows.Forms.Label()
        Me.lblServerNameDesc = New System.Windows.Forms.Label()
        Me.lblDescriptionDesc = New System.Windows.Forms.Label()
        Me.lblTagsDesc = New System.Windows.Forms.Label()
        Me.lblMaxPlayersDesc = New System.Windows.Forms.Label()
        Me.lblVisibilityDesc = New System.Windows.Forms.Label()
        Me.lblUsernameDesc = New System.Windows.Forms.Label()
        Me.lblGamePassDesc = New System.Windows.Forms.Label()
        Me.lblUserVarificationDesc = New System.Windows.Forms.Label()
        Me.lblUploadSpeedDesc = New System.Windows.Forms.Label()
        Me.lblLatencyDesc = New System.Windows.Forms.Label()
        Me.lblPlayerLimitIgnoreDesc = New System.Windows.Forms.Label()
        Me.lblCommandDecs = New System.Windows.Forms.Label()
        Me.lblAutosaveIntervalDesc = New System.Windows.Forms.Label()
        Me.lblAutoSaveSlotDesc = New System.Windows.Forms.Label()
        Me.lblAFKKickDesc = New System.Windows.Forms.Label()
        Me.lblAutoPauseDesc = New System.Windows.Forms.Label()
        Me.lblAdminPauseDesc = New System.Windows.Forms.Label()
        Me.lblAutosaveLocDesc = New System.Windows.Forms.Label()
        Me.lblAdminDesc = New System.Windows.Forms.Label()
        Me.tbSteamLoc = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(15, 72)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(69, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Server Name"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(15, 98)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = "Description"
        '
        'lblTags
        '
        Me.lblTags.AutoSize = True
        Me.lblTags.Location = New System.Drawing.Point(15, 124)
        Me.lblTags.Name = "lblTags"
        Me.lblTags.Size = New System.Drawing.Size(31, 13)
        Me.lblTags.TabIndex = 2
        Me.lblTags.Text = "Tags"
        '
        'lblPlayers
        '
        Me.lblPlayers.AutoSize = True
        Me.lblPlayers.Location = New System.Drawing.Point(15, 150)
        Me.lblPlayers.Name = "lblPlayers"
        Me.lblPlayers.Size = New System.Drawing.Size(64, 13)
        Me.lblPlayers.TabIndex = 3
        Me.lblPlayers.Text = "Max Players"
        '
        'lblVisibility
        '
        Me.lblVisibility.AutoSize = True
        Me.lblVisibility.Location = New System.Drawing.Point(15, 176)
        Me.lblVisibility.Name = "lblVisibility"
        Me.lblVisibility.Size = New System.Drawing.Size(43, 13)
        Me.lblVisibility.TabIndex = 4
        Me.lblVisibility.Text = "Visibility"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(15, 213)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername.TabIndex = 5
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(15, 239)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Text = "Password"
        '
        'lblGamePassword
        '
        Me.lblGamePassword.AutoSize = True
        Me.lblGamePassword.Location = New System.Drawing.Point(15, 265)
        Me.lblGamePassword.Name = "lblGamePassword"
        Me.lblGamePassword.Size = New System.Drawing.Size(84, 13)
        Me.lblGamePassword.TabIndex = 8
        Me.lblGamePassword.Text = "Game Password"
        '
        'lblUserVarification
        '
        Me.lblUserVarification.AutoSize = True
        Me.lblUserVarification.Location = New System.Drawing.Point(15, 291)
        Me.lblUserVarification.Name = "lblUserVarification"
        Me.lblUserVarification.Size = New System.Drawing.Size(124, 13)
        Me.lblUserVarification.TabIndex = 9
        Me.lblUserVarification.Text = "Require User Varification"
        '
        'lblUploadSpd
        '
        Me.lblUploadSpd.AutoSize = True
        Me.lblUploadSpd.Location = New System.Drawing.Point(15, 318)
        Me.lblUploadSpd.Name = "lblUploadSpd"
        Me.lblUploadSpd.Size = New System.Drawing.Size(118, 13)
        Me.lblUploadSpd.TabIndex = 10
        Me.lblUploadSpd.Text = "Max Upload Speed kps"
        '
        'lnlMinLatency
        '
        Me.lnlMinLatency.AutoSize = True
        Me.lnlMinLatency.Location = New System.Drawing.Point(15, 344)
        Me.lnlMinLatency.Name = "lnlMinLatency"
        Me.lnlMinLatency.Size = New System.Drawing.Size(129, 13)
        Me.lnlMinLatency.TabIndex = 11
        Me.lnlMinLatency.Text = "Minimum Latency in Ticks"
        '
        'lblPlayerLimitIgnore
        '
        Me.lblPlayerLimitIgnore.AutoSize = True
        Me.lblPlayerLimitIgnore.Location = New System.Drawing.Point(15, 370)
        Me.lblPlayerLimitIgnore.Name = "lblPlayerLimitIgnore"
        Me.lblPlayerLimitIgnore.Size = New System.Drawing.Size(184, 13)
        Me.lblPlayerLimitIgnore.TabIndex = 12
        Me.lblPlayerLimitIgnore.Text = "Ignore Player limit for returning players"
        '
        'lblAllowCommands
        '
        Me.lblAllowCommands.AutoSize = True
        Me.lblAllowCommands.Location = New System.Drawing.Point(15, 397)
        Me.lblAllowCommands.Name = "lblAllowCommands"
        Me.lblAllowCommands.Size = New System.Drawing.Size(87, 13)
        Me.lblAllowCommands.TabIndex = 13
        Me.lblAllowCommands.Text = "Allow Commands"
        '
        'lblAutosaveInterval
        '
        Me.lblAutosaveInterval.AutoSize = True
        Me.lblAutosaveInterval.Location = New System.Drawing.Point(15, 421)
        Me.lblAutosaveInterval.Name = "lblAutosaveInterval"
        Me.lblAutosaveInterval.Size = New System.Drawing.Size(90, 13)
        Me.lblAutosaveInterval.TabIndex = 14
        Me.lblAutosaveInterval.Text = "Autosave Interval"
        '
        'lblAutosaveSlots
        '
        Me.lblAutosaveSlots.AutoSize = True
        Me.lblAutosaveSlots.Location = New System.Drawing.Point(15, 450)
        Me.lblAutosaveSlots.Name = "lblAutosaveSlots"
        Me.lblAutosaveSlots.Size = New System.Drawing.Size(78, 13)
        Me.lblAutosaveSlots.TabIndex = 15
        Me.lblAutosaveSlots.Text = "Autosave Slots"
        '
        'lblAFKKickTime
        '
        Me.lblAFKKickTime.AutoSize = True
        Me.lblAFKKickTime.Location = New System.Drawing.Point(15, 477)
        Me.lblAFKKickTime.Name = "lblAFKKickTime"
        Me.lblAFKKickTime.Size = New System.Drawing.Size(106, 13)
        Me.lblAFKKickTime.TabIndex = 16
        Me.lblAFKKickTime.Text = "AFK Kick Time Ticks"
        '
        'lblAutoPause
        '
        Me.lblAutoPause.AutoSize = True
        Me.lblAutoPause.Location = New System.Drawing.Point(15, 504)
        Me.lblAutoPause.Name = "lblAutoPause"
        Me.lblAutoPause.Size = New System.Drawing.Size(62, 13)
        Me.lblAutoPause.TabIndex = 17
        Me.lblAutoPause.Text = "Auto Pause"
        '
        'lblAdminPause
        '
        Me.lblAdminPause.AutoSize = True
        Me.lblAdminPause.Location = New System.Drawing.Point(15, 531)
        Me.lblAdminPause.Name = "lblAdminPause"
        Me.lblAdminPause.Size = New System.Drawing.Size(118, 13)
        Me.lblAdminPause.TabIndex = 18
        Me.lblAdminPause.Text = "Only Admins can pause"
        '
        'lblAutosaveLocation
        '
        Me.lblAutosaveLocation.AutoSize = True
        Me.lblAutosaveLocation.Location = New System.Drawing.Point(15, 558)
        Me.lblAutosaveLocation.Name = "lblAutosaveLocation"
        Me.lblAutosaveLocation.Size = New System.Drawing.Size(121, 13)
        Me.lblAutosaveLocation.TabIndex = 19
        Me.lblAutosaveLocation.Text = "Autosave on server only"
        '
        'lblAdmins
        '
        Me.lblAdmins.AutoSize = True
        Me.lblAdmins.Location = New System.Drawing.Point(15, 585)
        Me.lblAdmins.Name = "lblAdmins"
        Me.lblAdmins.Size = New System.Drawing.Size(41, 13)
        Me.lblAdmins.TabIndex = 20
        Me.lblAdmins.Text = "Admins"
        '
        'tbServerName
        '
        Me.tbServerName.Location = New System.Drawing.Point(198, 69)
        Me.tbServerName.Name = "tbServerName"
        Me.tbServerName.Size = New System.Drawing.Size(191, 20)
        Me.tbServerName.TabIndex = 21
        Me.tbServerName.Text = "Example Server"
        '
        'tbDescription
        '
        Me.tbDescription.Location = New System.Drawing.Point(198, 95)
        Me.tbDescription.Name = "tbDescription"
        Me.tbDescription.Size = New System.Drawing.Size(191, 20)
        Me.tbDescription.TabIndex = 22
        Me.tbDescription.Text = "This is an example"
        '
        'tbTags
        '
        Me.tbTags.Location = New System.Drawing.Point(198, 121)
        Me.tbTags.Name = "tbTags"
        Me.tbTags.Size = New System.Drawing.Size(191, 20)
        Me.tbTags.TabIndex = 23
        Me.tbTags.Text = """Tag 1"", ""Tag2"""
        '
        'tbMaxPlayers
        '
        Me.tbMaxPlayers.Location = New System.Drawing.Point(198, 147)
        Me.tbMaxPlayers.Name = "tbMaxPlayers"
        Me.tbMaxPlayers.Size = New System.Drawing.Size(191, 20)
        Me.tbMaxPlayers.TabIndex = 24
        Me.tbMaxPlayers.Text = "0"
        '
        'tbUsername
        '
        Me.tbUsername.Location = New System.Drawing.Point(198, 210)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(191, 20)
        Me.tbUsername.TabIndex = 25
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(198, 236)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(191, 20)
        Me.tbPassword.TabIndex = 26
        '
        'tbGamePassword
        '
        Me.tbGamePassword.Location = New System.Drawing.Point(198, 262)
        Me.tbGamePassword.Name = "tbGamePassword"
        Me.tbGamePassword.Size = New System.Drawing.Size(191, 20)
        Me.tbGamePassword.TabIndex = 28
        '
        'tbUploadSpd
        '
        Me.tbUploadSpd.Location = New System.Drawing.Point(198, 315)
        Me.tbUploadSpd.Name = "tbUploadSpd"
        Me.tbUploadSpd.Size = New System.Drawing.Size(191, 20)
        Me.tbUploadSpd.TabIndex = 29
        Me.tbUploadSpd.Text = "0"
        '
        'tbMinLatency
        '
        Me.tbMinLatency.Location = New System.Drawing.Point(198, 341)
        Me.tbMinLatency.Name = "tbMinLatency"
        Me.tbMinLatency.Size = New System.Drawing.Size(191, 20)
        Me.tbMinLatency.TabIndex = 30
        Me.tbMinLatency.Text = "0"
        '
        'tbAutosaveInterval
        '
        Me.tbAutosaveInterval.Location = New System.Drawing.Point(198, 421)
        Me.tbAutosaveInterval.Name = "tbAutosaveInterval"
        Me.tbAutosaveInterval.Size = New System.Drawing.Size(191, 20)
        Me.tbAutosaveInterval.TabIndex = 31
        Me.tbAutosaveInterval.Text = "15"
        '
        'tbAdmins
        '
        Me.tbAdmins.Location = New System.Drawing.Point(198, 582)
        Me.tbAdmins.Name = "tbAdmins"
        Me.tbAdmins.Size = New System.Drawing.Size(191, 20)
        Me.tbAdmins.TabIndex = 32
        Me.tbAdmins.Text = """Admin 1"", ""Admin 2"""
        '
        'cbVisibility
        '
        Me.cbVisibility.FormattingEnabled = True
        Me.cbVisibility.Items.AddRange(New Object() {"Public", "LAN"})
        Me.cbVisibility.Location = New System.Drawing.Point(198, 173)
        Me.cbVisibility.Name = "cbVisibility"
        Me.cbVisibility.Size = New System.Drawing.Size(191, 21)
        Me.cbVisibility.TabIndex = 33
        Me.cbVisibility.Text = "Public"
        '
        'cbUserVarification
        '
        Me.cbUserVarification.FormattingEnabled = True
        Me.cbUserVarification.Items.AddRange(New Object() {"True", "False"})
        Me.cbUserVarification.Location = New System.Drawing.Point(198, 288)
        Me.cbUserVarification.Name = "cbUserVarification"
        Me.cbUserVarification.Size = New System.Drawing.Size(191, 21)
        Me.cbUserVarification.TabIndex = 34
        Me.cbUserVarification.Text = "True"
        '
        'cbIgnorePLayerLimit
        '
        Me.cbIgnorePLayerLimit.FormattingEnabled = True
        Me.cbIgnorePLayerLimit.Items.AddRange(New Object() {"True", "False"})
        Me.cbIgnorePLayerLimit.Location = New System.Drawing.Point(198, 367)
        Me.cbIgnorePLayerLimit.Name = "cbIgnorePLayerLimit"
        Me.cbIgnorePLayerLimit.Size = New System.Drawing.Size(191, 21)
        Me.cbIgnorePLayerLimit.TabIndex = 35
        Me.cbIgnorePLayerLimit.Text = "False"
        '
        'cbAllowCommands
        '
        Me.cbAllowCommands.FormattingEnabled = True
        Me.cbAllowCommands.Items.AddRange(New Object() {"True", "False", "Admins Only"})
        Me.cbAllowCommands.Location = New System.Drawing.Point(198, 394)
        Me.cbAllowCommands.Name = "cbAllowCommands"
        Me.cbAllowCommands.Size = New System.Drawing.Size(191, 21)
        Me.cbAllowCommands.TabIndex = 36
        Me.cbAllowCommands.Text = "Admins Only"
        '
        'cbAutosaveSlot
        '
        Me.cbAutosaveSlot.FormattingEnabled = True
        Me.cbAutosaveSlot.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cbAutosaveSlot.Location = New System.Drawing.Point(198, 447)
        Me.cbAutosaveSlot.Name = "cbAutosaveSlot"
        Me.cbAutosaveSlot.Size = New System.Drawing.Size(191, 21)
        Me.cbAutosaveSlot.TabIndex = 37
        Me.cbAutosaveSlot.Text = "4"
        '
        'cbAFKKick
        '
        Me.cbAFKKick.FormattingEnabled = True
        Me.cbAFKKick.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cbAFKKick.Location = New System.Drawing.Point(198, 474)
        Me.cbAFKKick.Name = "cbAFKKick"
        Me.cbAFKKick.Size = New System.Drawing.Size(191, 21)
        Me.cbAFKKick.TabIndex = 38
        Me.cbAFKKick.Text = "5"
        '
        'cbAutoPause
        '
        Me.cbAutoPause.FormattingEnabled = True
        Me.cbAutoPause.Items.AddRange(New Object() {"True", "False"})
        Me.cbAutoPause.Location = New System.Drawing.Point(198, 501)
        Me.cbAutoPause.Name = "cbAutoPause"
        Me.cbAutoPause.Size = New System.Drawing.Size(191, 21)
        Me.cbAutoPause.TabIndex = 39
        Me.cbAutoPause.Text = "True"
        '
        'cbAdminPause
        '
        Me.cbAdminPause.FormattingEnabled = True
        Me.cbAdminPause.Items.AddRange(New Object() {"True", "False"})
        Me.cbAdminPause.Location = New System.Drawing.Point(198, 528)
        Me.cbAdminPause.Name = "cbAdminPause"
        Me.cbAdminPause.Size = New System.Drawing.Size(191, 21)
        Me.cbAdminPause.TabIndex = 40
        Me.cbAdminPause.Text = "True"
        '
        'cbAutosaveServer
        '
        Me.cbAutosaveServer.FormattingEnabled = True
        Me.cbAutosaveServer.Items.AddRange(New Object() {"True", "False"})
        Me.cbAutosaveServer.Location = New System.Drawing.Point(198, 555)
        Me.cbAutosaveServer.Name = "cbAutosaveServer"
        Me.cbAutosaveServer.Size = New System.Drawing.Size(191, 21)
        Me.cbAutosaveServer.TabIndex = 41
        Me.cbAutosaveServer.Text = "True"
        '
        'btnMake
        '
        Me.btnMake.Location = New System.Drawing.Point(18, 622)
        Me.btnMake.Name = "btnMake"
        Me.btnMake.Size = New System.Drawing.Size(75, 35)
        Me.btnMake.TabIndex = 42
        Me.btnMake.Text = "Make Json"
        Me.btnMake.UseVisualStyleBackColor = True
        '
        'lblServerJsonLocation
        '
        Me.lblServerJsonLocation.AutoSize = True
        Me.lblServerJsonLocation.Location = New System.Drawing.Point(15, 13)
        Me.lblServerJsonLocation.Name = "lblServerJsonLocation"
        Me.lblServerJsonLocation.Size = New System.Drawing.Size(173, 13)
        Me.lblServerJsonLocation.TabIndex = 43
        Me.lblServerJsonLocation.Text = "Where you want the Json to be put"
        '
        'tbJsonLocation
        '
        Me.tbJsonLocation.Location = New System.Drawing.Point(198, 10)
        Me.tbJsonLocation.Name = "tbJsonLocation"
        Me.tbJsonLocation.Size = New System.Drawing.Size(191, 20)
        Me.tbJsonLocation.TabIndex = 44
        Me.tbJsonLocation.Text = "C:\Program Files\Factorio\bin\x64\"
        '
        'tbJsonName
        '
        Me.tbJsonName.Location = New System.Drawing.Point(198, 43)
        Me.tbJsonName.Name = "tbJsonName"
        Me.tbJsonName.Size = New System.Drawing.Size(191, 20)
        Me.tbJsonName.TabIndex = 45
        Me.tbJsonName.Text = "server-settings.json"
        '
        'lblJsonName
        '
        Me.lblJsonName.AutoSize = True
        Me.lblJsonName.Location = New System.Drawing.Point(15, 46)
        Me.lblJsonName.Name = "lblJsonName"
        Me.lblJsonName.Size = New System.Drawing.Size(60, 13)
        Me.lblJsonName.TabIndex = 46
        Me.lblJsonName.Text = "Json Name"
        '
        'lblServerJsonLocDesc
        '
        Me.lblServerJsonLocDesc.AutoSize = True
        Me.lblServerJsonLocDesc.Location = New System.Drawing.Point(423, 13)
        Me.lblServerJsonLocDesc.Name = "lblServerJsonLocDesc"
        Me.lblServerJsonLocDesc.Size = New System.Drawing.Size(392, 26)
        Me.lblServerJsonLocDesc.TabIndex = 47
        Me.lblServerJsonLocDesc.Text = "The Location the example.json file.  Currently shows the default for the .exe ins" &
    "tall." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Steam default install is"
        '
        'lblJsonNameDesc
        '
        Me.lblJsonNameDesc.AutoSize = True
        Me.lblJsonNameDesc.Location = New System.Drawing.Point(423, 46)
        Me.lblJsonNameDesc.Name = "lblJsonNameDesc"
        Me.lblJsonNameDesc.Size = New System.Drawing.Size(255, 13)
        Me.lblJsonNameDesc.TabIndex = 48
        Me.lblJsonNameDesc.Text = "The name of the Json File.  Shows the default name."
        '
        'lblServerNameDesc
        '
        Me.lblServerNameDesc.AutoSize = True
        Me.lblServerNameDesc.Location = New System.Drawing.Point(423, 72)
        Me.lblServerNameDesc.Name = "lblServerNameDesc"
        Me.lblServerNameDesc.Size = New System.Drawing.Size(223, 13)
        Me.lblServerNameDesc.TabIndex = 49
        Me.lblServerNameDesc.Text = "The name other players will see for the server."
        '
        'lblDescriptionDesc
        '
        Me.lblDescriptionDesc.AutoSize = True
        Me.lblDescriptionDesc.Location = New System.Drawing.Point(423, 98)
        Me.lblDescriptionDesc.Name = "lblDescriptionDesc"
        Me.lblDescriptionDesc.Size = New System.Drawing.Size(712, 13)
        Me.lblDescriptionDesc.TabIndex = 50
        Me.lblDescriptionDesc.Text = "A basic description of what you want done on the server.  Also can be used for (u" &
    "nclickable) links to Discord or teamspeak servers for communication."
        '
        'lblTagsDesc
        '
        Me.lblTagsDesc.AutoSize = True
        Me.lblTagsDesc.Location = New System.Drawing.Point(423, 124)
        Me.lblTagsDesc.Name = "lblTagsDesc"
        Me.lblTagsDesc.Size = New System.Drawing.Size(508, 13)
        Me.lblTagsDesc.TabIndex = 51
        Me.lblTagsDesc.Text = "Searchable descriptors such as Vanilla, or Discord, Teamspeak, etc.  Please put a" &
    "ll tags like the examples."
        '
        'lblMaxPlayersDesc
        '
        Me.lblMaxPlayersDesc.AutoSize = True
        Me.lblMaxPlayersDesc.Location = New System.Drawing.Point(423, 147)
        Me.lblMaxPlayersDesc.Name = "lblMaxPlayersDesc"
        Me.lblMaxPlayersDesc.Size = New System.Drawing.Size(308, 13)
        Me.lblMaxPlayersDesc.TabIndex = 52
        Me.lblMaxPlayersDesc.Text = "The maximum ammount of players on your server.  0 is unlimited."
        '
        'lblVisibilityDesc
        '
        Me.lblVisibilityDesc.AutoSize = True
        Me.lblVisibilityDesc.Location = New System.Drawing.Point(423, 176)
        Me.lblVisibilityDesc.Name = "lblVisibilityDesc"
        Me.lblVisibilityDesc.Size = New System.Drawing.Size(334, 26)
        Me.lblVisibilityDesc.TabIndex = 53
        Me.lblVisibilityDesc.Text = "public: Game will be published on the official Factorio matching server" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LAN: Gam" &
    "e will be broadcast on LAN"
        '
        'lblUsernameDesc
        '
        Me.lblUsernameDesc.AutoSize = True
        Me.lblUsernameDesc.Location = New System.Drawing.Point(423, 213)
        Me.lblUsernameDesc.Name = "lblUsernameDesc"
        Me.lblUsernameDesc.Size = New System.Drawing.Size(368, 13)
        Me.lblUsernameDesc.TabIndex = 54
        Me.lblUsernameDesc.Text = "Your Factorio Login information this is required for servers with Public Visibili" &
    "ty"
        '
        'lblGamePassDesc
        '
        Me.lblGamePassDesc.AutoSize = True
        Me.lblGamePassDesc.Location = New System.Drawing.Point(423, 265)
        Me.lblGamePassDesc.Name = "lblGamePassDesc"
        Me.lblGamePassDesc.Size = New System.Drawing.Size(141, 13)
        Me.lblGamePassDesc.TabIndex = 55
        Me.lblGamePassDesc.Text = "The password for you server"
        '
        'lblUserVarificationDesc
        '
        Me.lblUserVarificationDesc.AutoSize = True
        Me.lblUserVarificationDesc.Location = New System.Drawing.Point(423, 291)
        Me.lblUserVarificationDesc.Name = "lblUserVarificationDesc"
        Me.lblUserVarificationDesc.Size = New System.Drawing.Size(218, 13)
        Me.lblUserVarificationDesc.TabIndex = 56
        Me.lblUserVarificationDesc.Text = "Do you want to make sure they own Factorio"
        '
        'lblUploadSpeedDesc
        '
        Me.lblUploadSpeedDesc.AutoSize = True
        Me.lblUploadSpeedDesc.Location = New System.Drawing.Point(423, 318)
        Me.lblUploadSpeedDesc.Name = "lblUploadSpeedDesc"
        Me.lblUploadSpeedDesc.Size = New System.Drawing.Size(550, 13)
        Me.lblUploadSpeedDesc.TabIndex = 57
        Me.lblUploadSpeedDesc.Text = "The max speed a player can download the map when joining.  0 means unlimited.  Mo" &
    "st servers ar around 2000kbs."
        '
        'lblLatencyDesc
        '
        Me.lblLatencyDesc.AutoSize = True
        Me.lblLatencyDesc.Location = New System.Drawing.Point(423, 344)
        Me.lblLatencyDesc.Name = "lblLatencyDesc"
        Me.lblLatencyDesc.Size = New System.Drawing.Size(283, 13)
        Me.lblLatencyDesc.TabIndex = 58
        Me.lblLatencyDesc.Text = "Time it takes for data to get to players.  0 Imeans unlimited."
        '
        'lblPlayerLimitIgnoreDesc
        '
        Me.lblPlayerLimitIgnoreDesc.AutoSize = True
        Me.lblPlayerLimitIgnoreDesc.Location = New System.Drawing.Point(423, 370)
        Me.lblPlayerLimitIgnoreDesc.Name = "lblPlayerLimitIgnoreDesc"
        Me.lblPlayerLimitIgnoreDesc.Size = New System.Drawing.Size(239, 13)
        Me.lblPlayerLimitIgnoreDesc.TabIndex = 59
        Me.lblPlayerLimitIgnoreDesc.Text = "Allow returning players to join even if server is full."
        '
        'lblCommandDecs
        '
        Me.lblCommandDecs.AutoSize = True
        Me.lblCommandDecs.Location = New System.Drawing.Point(423, 397)
        Me.lblCommandDecs.Name = "lblCommandDecs"
        Me.lblCommandDecs.Size = New System.Drawing.Size(122, 13)
        Me.lblCommandDecs.TabIndex = 60
        Me.lblCommandDecs.Text = "Are commands allowed?"
        '
        'lblAutosaveIntervalDesc
        '
        Me.lblAutosaveIntervalDesc.AutoSize = True
        Me.lblAutosaveIntervalDesc.Location = New System.Drawing.Point(423, 421)
        Me.lblAutosaveIntervalDesc.Name = "lblAutosaveIntervalDesc"
        Me.lblAutosaveIntervalDesc.Size = New System.Drawing.Size(195, 13)
        Me.lblAutosaveIntervalDesc.TabIndex = 61
        Me.lblAutosaveIntervalDesc.Text = "How often the server will save.  Minutes"
        '
        'lblAutoSaveSlotDesc
        '
        Me.lblAutoSaveSlotDesc.AutoSize = True
        Me.lblAutoSaveSlotDesc.Location = New System.Drawing.Point(423, 450)
        Me.lblAutoSaveSlotDesc.Name = "lblAutoSaveSlotDesc"
        Me.lblAutoSaveSlotDesc.Size = New System.Drawing.Size(403, 13)
        Me.lblAutoSaveSlotDesc.TabIndex = 62
        Me.lblAutoSaveSlotDesc.Text = "How many different AutoSave slots will it use.  Good for backup file incase of gr" &
    "iefer."
        '
        'lblAFKKickDesc
        '
        Me.lblAFKKickDesc.AutoSize = True
        Me.lblAFKKickDesc.Location = New System.Drawing.Point(423, 477)
        Me.lblAFKKickDesc.Name = "lblAFKKickDesc"
        Me.lblAFKKickDesc.Size = New System.Drawing.Size(250, 13)
        Me.lblAFKKickDesc.TabIndex = 63
        Me.lblAFKKickDesc.Text = "The Length of time someone can be idle in minutes."
        '
        'lblAutoPauseDesc
        '
        Me.lblAutoPauseDesc.AutoSize = True
        Me.lblAutoPauseDesc.Location = New System.Drawing.Point(426, 503)
        Me.lblAutoPauseDesc.Name = "lblAutoPauseDesc"
        Me.lblAutoPauseDesc.Size = New System.Drawing.Size(234, 13)
        Me.lblAutoPauseDesc.TabIndex = 64
        Me.lblAutoPauseDesc.Text = "If true the server will pause when no one is on it."
        '
        'lblAdminPauseDesc
        '
        Me.lblAdminPauseDesc.AutoSize = True
        Me.lblAdminPauseDesc.Location = New System.Drawing.Point(423, 531)
        Me.lblAdminPauseDesc.Name = "lblAdminPauseDesc"
        Me.lblAdminPauseDesc.Size = New System.Drawing.Size(537, 13)
        Me.lblAdminPauseDesc.TabIndex = 65
        Me.lblAdminPauseDesc.Text = "Allows admins to pause the game with people on it.  Mainly used as a way to stop " &
    "griefers until the can ban them."
        '
        'lblAutosaveLocDesc
        '
        Me.lblAutosaveLocDesc.AutoSize = True
        Me.lblAutosaveLocDesc.Location = New System.Drawing.Point(426, 557)
        Me.lblAutosaveLocDesc.Name = "lblAutosaveLocDesc"
        Me.lblAutosaveLocDesc.Size = New System.Drawing.Size(333, 13)
        Me.lblAutosaveLocDesc.TabIndex = 66
        Me.lblAutosaveLocDesc.Text = "If true the server will be the only one keeping a copy of the autosave."
        '
        'lblAdminDesc
        '
        Me.lblAdminDesc.AutoSize = True
        Me.lblAdminDesc.Location = New System.Drawing.Point(429, 584)
        Me.lblAdminDesc.Name = "lblAdminDesc"
        Me.lblAdminDesc.Size = New System.Drawing.Size(484, 26)
        Me.lblAdminDesc.TabIndex = 67
        Me.lblAdminDesc.Text = "A list of all players that will have admin permissions upon start.  Players can a" &
    "lso be promoted in game." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please put all Admins like the examples."
        '
        'tbSteamLoc
        '
        Me.tbSteamLoc.BackColor = System.Drawing.SystemColors.Control
        Me.tbSteamLoc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbSteamLoc.Location = New System.Drawing.Point(534, 26)
        Me.tbSteamLoc.Name = "tbSteamLoc"
        Me.tbSteamLoc.Size = New System.Drawing.Size(351, 13)
        Me.tbSteamLoc.TabIndex = 68
        Me.tbSteamLoc.TabStop = False
        Me.tbSteamLoc.Text = " C:\Program Files (x86)\Steam\steamapps\common\Factorio\bin\x64"
        '
        'Factorio_Json_Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1171, 700)
        Me.Controls.Add(Me.tbSteamLoc)
        Me.Controls.Add(Me.lblAdminDesc)
        Me.Controls.Add(Me.lblAutosaveLocDesc)
        Me.Controls.Add(Me.lblAdminPauseDesc)
        Me.Controls.Add(Me.lblAutoPauseDesc)
        Me.Controls.Add(Me.lblAFKKickDesc)
        Me.Controls.Add(Me.lblAutoSaveSlotDesc)
        Me.Controls.Add(Me.lblAutosaveIntervalDesc)
        Me.Controls.Add(Me.lblCommandDecs)
        Me.Controls.Add(Me.lblPlayerLimitIgnoreDesc)
        Me.Controls.Add(Me.lblLatencyDesc)
        Me.Controls.Add(Me.lblUploadSpeedDesc)
        Me.Controls.Add(Me.lblUserVarificationDesc)
        Me.Controls.Add(Me.lblGamePassDesc)
        Me.Controls.Add(Me.lblUsernameDesc)
        Me.Controls.Add(Me.lblVisibilityDesc)
        Me.Controls.Add(Me.lblMaxPlayersDesc)
        Me.Controls.Add(Me.lblTagsDesc)
        Me.Controls.Add(Me.lblDescriptionDesc)
        Me.Controls.Add(Me.lblServerNameDesc)
        Me.Controls.Add(Me.lblJsonNameDesc)
        Me.Controls.Add(Me.lblServerJsonLocDesc)
        Me.Controls.Add(Me.lblJsonName)
        Me.Controls.Add(Me.tbJsonName)
        Me.Controls.Add(Me.tbJsonLocation)
        Me.Controls.Add(Me.lblServerJsonLocation)
        Me.Controls.Add(Me.btnMake)
        Me.Controls.Add(Me.cbAutosaveServer)
        Me.Controls.Add(Me.cbAdminPause)
        Me.Controls.Add(Me.cbAutoPause)
        Me.Controls.Add(Me.cbAFKKick)
        Me.Controls.Add(Me.cbAutosaveSlot)
        Me.Controls.Add(Me.cbAllowCommands)
        Me.Controls.Add(Me.cbIgnorePLayerLimit)
        Me.Controls.Add(Me.cbUserVarification)
        Me.Controls.Add(Me.cbVisibility)
        Me.Controls.Add(Me.tbAdmins)
        Me.Controls.Add(Me.tbAutosaveInterval)
        Me.Controls.Add(Me.tbMinLatency)
        Me.Controls.Add(Me.tbUploadSpd)
        Me.Controls.Add(Me.tbGamePassword)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.tbMaxPlayers)
        Me.Controls.Add(Me.tbTags)
        Me.Controls.Add(Me.tbDescription)
        Me.Controls.Add(Me.tbServerName)
        Me.Controls.Add(Me.lblAdmins)
        Me.Controls.Add(Me.lblAutosaveLocation)
        Me.Controls.Add(Me.lblAdminPause)
        Me.Controls.Add(Me.lblAutoPause)
        Me.Controls.Add(Me.lblAFKKickTime)
        Me.Controls.Add(Me.lblAutosaveSlots)
        Me.Controls.Add(Me.lblAutosaveInterval)
        Me.Controls.Add(Me.lblAllowCommands)
        Me.Controls.Add(Me.lblPlayerLimitIgnore)
        Me.Controls.Add(Me.lnlMinLatency)
        Me.Controls.Add(Me.lblUploadSpd)
        Me.Controls.Add(Me.lblUserVarification)
        Me.Controls.Add(Me.lblGamePassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblVisibility)
        Me.Controls.Add(Me.lblPlayers)
        Me.Controls.Add(Me.lblTags)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Factorio_Json_Editor"
        Me.Text = "Factorio(0.14.21) Server Settings Json Maker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblTags As Label
    Friend WithEvents lblPlayers As Label
    Friend WithEvents lblVisibility As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblGamePassword As Label
    Friend WithEvents lblUserVarification As Label
    Friend WithEvents lblUploadSpd As Label
    Friend WithEvents lnlMinLatency As Label
    Friend WithEvents lblPlayerLimitIgnore As Label
    Friend WithEvents lblAllowCommands As Label
    Friend WithEvents lblAutosaveInterval As Label
    Friend WithEvents lblAutosaveSlots As Label
    Friend WithEvents lblAFKKickTime As Label
    Friend WithEvents lblAutoPause As Label
    Friend WithEvents lblAdminPause As Label
    Friend WithEvents lblAutosaveLocation As Label
    Friend WithEvents lblAdmins As Label
    Friend WithEvents tbServerName As TextBox
    Friend WithEvents tbDescription As TextBox
    Friend WithEvents tbTags As TextBox
    Friend WithEvents tbMaxPlayers As TextBox
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents tbGamePassword As TextBox
    Friend WithEvents tbUploadSpd As TextBox
    Friend WithEvents tbMinLatency As TextBox
    Friend WithEvents tbAutosaveInterval As TextBox
    Friend WithEvents tbAdmins As TextBox
    Friend WithEvents cbVisibility As ComboBox
    Friend WithEvents cbUserVarification As ComboBox
    Friend WithEvents cbIgnorePLayerLimit As ComboBox
    Friend WithEvents cbAllowCommands As ComboBox
    Friend WithEvents cbAutosaveSlot As ComboBox
    Friend WithEvents cbAFKKick As ComboBox
    Friend WithEvents cbAutoPause As ComboBox
    Friend WithEvents cbAdminPause As ComboBox
    Friend WithEvents cbAutosaveServer As ComboBox
    Friend WithEvents btnMake As Button
    Friend WithEvents lblServerJsonLocation As Label
    Friend WithEvents tbJsonLocation As TextBox
    Friend WithEvents tbJsonName As TextBox
    Friend WithEvents lblJsonName As Label
    Friend WithEvents lblServerJsonLocDesc As Label
    Friend WithEvents lblJsonNameDesc As Label
    Friend WithEvents lblServerNameDesc As Label
    Friend WithEvents lblDescriptionDesc As Label
    Friend WithEvents lblTagsDesc As Label
    Friend WithEvents lblMaxPlayersDesc As Label
    Friend WithEvents lblVisibilityDesc As Label
    Friend WithEvents lblUsernameDesc As Label
    Friend WithEvents lblGamePassDesc As Label
    Friend WithEvents lblUserVarificationDesc As Label
    Friend WithEvents lblUploadSpeedDesc As Label
    Friend WithEvents lblLatencyDesc As Label
    Friend WithEvents lblPlayerLimitIgnoreDesc As Label
    Friend WithEvents lblCommandDecs As Label
    Friend WithEvents lblAutosaveIntervalDesc As Label
    Friend WithEvents lblAutoSaveSlotDesc As Label
    Friend WithEvents lblAFKKickDesc As Label
    Friend WithEvents lblAutoPauseDesc As Label
    Friend WithEvents lblAdminPauseDesc As Label
    Friend WithEvents lblAutosaveLocDesc As Label
    Friend WithEvents lblAdminDesc As Label
    Friend WithEvents tbSteamLoc As TextBox
End Class
