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

            this.Actions = new List<PluginAction>
            {
                new ShowSensors(),
            };
        }

        private void SensorTimer_Elapsed(object sender, ElapsedEventArgs e)
        {

            for (int i = 0; i < sensors; i++)
            {
                //set all values as string cause HWiNFO64 already formatted them for us
                VariableManager.SetValue("hwi64_" + (string)registryPath.GetValue("Label" + i), (string)registryPath.GetValue("Value" + i), VariableType.String, HWiNFO64Plugin.Instance, true);
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

    public class ShowSensors : PluginAction
    {
        public override string Name => "Show Sensors";
        public override string Description => "Displays the currently available sensors.";
        public override void Trigger(string clientId, ActionButton actionButton)
        {
            //VariableManager.SetValue("SpeedtestActive", true, VariableType.Bool, SpeedtestPlugin.Instance, true);
            DisplaySensors();
        }

        private async void DisplaySensors()
        {
            try
            {
                MacroDeckLogger.Error(HWiNFO64Plugin.Instance, "Geht");
                //generate html overview here...
            }
            catch (System.Exception ex)
            {
                MacroDeckLogger.Error(HWiNFO64Plugin.Instance, ex.Message);
            }
        }
    }



}
