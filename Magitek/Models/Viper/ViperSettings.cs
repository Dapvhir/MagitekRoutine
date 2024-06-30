﻿using Magitek.Models.Roles;
using PropertyChanged;
using System.ComponentModel;
using System.Configuration;

namespace Magitek.Models.Viper
{
    [AddINotifyPropertyChangedInterface]
    public class ViperSettings : PhysicalDpsSettings, IRoutineSettings
    {
        public ViperSettings() : base(CharacterSettingsDirectory + "/Magitek/Viper/ViperSettings.json") { }

        public static ViperSettings Instance { get; set; } = new ViperSettings();

        #region General-Stuff
        [Setting]
        [DefaultValue(false)]
        public bool EnemyIsOmni { get; set; }

        [Setting]
        [DefaultValue(13)]
        public int SaveIfEnemyDyingWithin { get; set; }

        [Setting]
        [DefaultValue(70.0f)]
        public float RestHealthPercent { get; set; }

        [Setting]
        [DefaultValue(false)]
        public bool HidePositionalMessage { get; set; }

        #endregion

        #region SingleTarget-Abilities

        [Setting]
        [DefaultValue(true)]
        public bool UseDreadwinder { get; set; }

        #endregion

        #region AoE-Abilities

        [Setting]
        [DefaultValue(true)]
        public bool UseAoe { get; set; }

        [Setting]
        [DefaultValue(3)]
        public int AoeEnemies { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseSteelDreadMaw { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UsePitOfDread { get; set; }

        #endregion

        #region Cooldowns

        [Setting]
        [DefaultValue(true)]
        public bool UseDeathRattle { get; set; }


        [Setting]
        [DefaultValue(true)]
        public bool UseLastLash { get; set; }
        #endregion

        #region Utility-Abilities
        [Setting]
        [DefaultValue(true)]
        public bool UseSlither { get; set; }
        #endregion

        #region PVP

        #endregion
    }
}