using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.MirControls
{
    public class ControlConfigOverride
    {
        static ControlConfigOverride()
        {
            LoadConfig();
        }

        public static Dictionary<string, ControlConfigOverride> Overrides = new Dictionary<string, ControlConfigOverride>();
        public static string ConfigFile = "./override.ini";

        public static void SaveConfig()
        {
            var writer = new InIReader(ConfigFile);
            foreach (var _override in Overrides)
            {
                writer.Write(_override.Key, nameof(_override.Value.PositionX), _override.Value.PositionX);
                writer.Write(_override.Key, nameof(_override.Value.PositionY), _override.Value.PositionY);
                writer.Write(_override.Key, nameof(_override.Value.LibFile), _override.Value.LibFile);
                writer.Write(_override.Key, nameof(_override.Value.Index), _override.Value.Index);
            }
        }

        public static void LoadConfig()
        {
            var reader = new InIReader(ConfigFile);
            var sections = reader.GetAllSections();
            foreach (var section in sections)
            {
                var _override = new ControlConfigOverride();
                _override.PositionX = reader.ReadInt32(section, nameof(_override.PositionX), _override.PositionX);
                _override.PositionY = reader.ReadInt32(section, nameof(_override.PositionY), _override.PositionY);
                _override.LibFile = reader.ReadString(section, nameof(_override.LibFile), _override.LibFile);
                _override.Index = reader.ReadInt32(section, nameof(_override.Index), _override.Index);
                Overrides[section] = _override;
            }
        }

        public static void AddOverride(string key, ControlConfigOverride _override)
        {
            Overrides[key] = _override;
        }

        public static ControlConfigOverride GetOverride(string key)
        {
            return Overrides.ContainsKey(key) ? Overrides[key] : null;
        }

        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public string LibFile { get; set; }
        public int Index { get; set; }
    }
}
