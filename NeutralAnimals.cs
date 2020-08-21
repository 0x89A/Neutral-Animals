using UnityEngine;

using Newtonsoft.Json;

namespace Oxide.Plugins
{
    [Info("Neutral Animals", "0x89A", "1.0.7")]
    class NeutralAnimals : RustPlugin
    {
        private const string canuse = "neutralanimals.use";

        void Init() => permission.RegisterPermission(canuse, this);

        protected override void LoadConfig()
        {
            base.LoadConfig();
            try
            {
                _config = Config.ReadObject<Configuration>();
                if (_config == null) throw new System.Exception();
                SaveConfig();
            }
            catch
            {
                PrintWarning("Error loading config, using default values");
                LoadDefaultConfig();
            }
        }

        protected override void LoadDefaultConfig() => _config = new Configuration();

        protected override void SaveConfig() => Config.WriteObject(_config);

        private Configuration _config;

        private class Configuration
        {
            [JsonProperty(PropertyName = "Animal forget time")]
            public float forgetTime = 30f;
        }

        object OnNpcTarget(BaseAnimalNPC animal, BaseEntity entity)
        {
            if (entity.IsNpc || animal.lastAttacker == null || !permission.UserHasPermission(entity.net.connection.userid.ToString(), canuse) || (animal.lastAttacker == entity && (Time.time - animal.lastAttackedTime) < _config.forgetTime)) return null;
            else return true;
        }
    }
}
