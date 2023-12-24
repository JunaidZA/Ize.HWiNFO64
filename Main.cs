using SuchByte.MacroDeck;
using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using SuchByte.MacroDeck.Logging;
using SuchByte.MacroDeck.Plugins;
using SuchByte.MacroDeck.Variables;
using System;
using System.Collections.Generic;
using System.Drawing;
using Microsoft.Win32;
using System.Timers;
using HWiNFO64_Plugin;

namespace Ize.HWiNFO64_Plugin
{
    public class HWiNFO64Plugin : MacroDeckPlugin
    {
        public override bool CanConfigure => true;

        public static int sensors = 0;

        int refreshTime = 2000;

        Microsoft.Win32.RegistryKey registryPath = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\HWiNFO64\VSB"); //HWiNFO64 Values get stored here;

        internal static MacroDeckPlugin Instance { get; set; }

        public HWiNFO64Plugin()
        {
            Instance = this;
        }

        public override void Enable()
        {
            sensors = registryPath.ValueCount / 5; //each sensor has 5 values in registry: Color, Label, Sensor, Value, ValueRaw; counting starts at 0

            var myTime = SuchByte.MacroDeck.Plugins.PluginConfiguration.GetValue(HWiNFO64Plugin.Instance, "refreshTime");

            if (myTime == "" | myTime == null)
            {
                refreshTime = 2000;
            }
            else
            {
                refreshTime = int.Parse(myTime);
            }

            Timer sensorTimer = new Timer()
            {
                Enabled = true,
                Interval = refreshTime, //Default HWiNFO64 Interval, shouldn't be changed to not cause unnecessary load
            };

            sensorTimer.Elapsed += SensorTimer_Elapsed;
            sensorTimer.Start();

        }

        private void SensorTimer_Elapsed(object sender, ElapsedEventArgs e)
        {

            for (int i = 0; i < sensors; i++)
            {
                //set all values as string cause HWiNFO64 already formatted them for us
                var variableName = "hwi64_" + (string)registryPath.GetValue("Label" + i);
                var regexSpecialChars = new Regex("[()]");
                variableName = regexSpecialChars.Replace(variableName, string.Empty);
                VariableManager.SetValue(variableName, (string)registryPath.GetValue("Value" + i), VariableType.String, HWiNFO64Plugin.Instance, true);
            }
        }

        public override void OpenConfigurator()
        {
            using (var configurator = new PluginConfigurationView())
            {
                configurator.ShowDialog();
            }
        }
    }

}
