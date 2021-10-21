﻿using SuchByte.MacroDeck;
using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using SuchByte.MacroDeck.Plugins;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using WindowsInput;

namespace MediaControls_Plugin
{
    public class MediaControlsPlugin : MacroDeckPlugin
    {
        public override string Description => "This plugin can control media applications e.g. Spotify, Windows Media Player etc.";
        public override List<PluginAction> Actions { get; set; }
        public override void Enable()
        {
            this.Actions = new List<PluginAction>
            {
                new MediaPlayPauseAction(),
                new MediaNextAction(),
                new MediaPrevAction(),
            };
        }
    }

    public class MediaPlayPauseAction : PluginAction
    {
        public override string Name => "Media Play/Pause";
        public override string Description => "Pauses or resume the current track on a media player.";
        public override string DisplayName { get; set; } = "Media Play/Pause";
        public override void Trigger(string clientId, ActionButton actionButton)
        {
            new InputSimulator().Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.MEDIA_PLAY_PAUSE);
        }
    }

    public class MediaNextAction : PluginAction
    {
        public override string Name => "Media Next";
        public override string Description => "Plays the next track on a media player.";
        public override string DisplayName { get; set; } = "Media Next";
        public override void Trigger(string clientId, ActionButton actionButton)
        {
            new InputSimulator().Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.MEDIA_NEXT_TRACK);
        }
    }

    public class MediaPrevAction : PluginAction
    {
        public override string Name => "Media Prev";
        public override string Description => "Plays the previous track on a media player.\n\r\n\rConfiguration: no";
        public override string DisplayName { get; set; } = "Media Prev";
        public override void Trigger(string clientId, ActionButton actionButton)
        {
            new InputSimulator().Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.MEDIA_PREV_TRACK);
        }
    }


}
