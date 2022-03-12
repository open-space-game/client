using Module.BusinessSimulation.Model.Setting;
using UnityEngine;

namespace Module.BusinessSimulation
{
    public class Settings : MonoBehaviour
    {
        public Recipe[] Recipeis;
        
        public void Start()
        {
            TextAsset jsonTextFile = Resources.Load<TextAsset>("Data/recipe");
            var setting = JsonUtility.FromJson<Setting>(jsonTextFile.text);

            Recipeis = setting.recipeis;
        }
    }
}
