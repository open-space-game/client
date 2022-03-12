using System;
using Module.BusinessSimulation.Behaviour;
using Module.BusinessSimulation.Model;
using Module.BusinessSimulation.Model.Setting;
using UnityEngine;

namespace Module.BusinessSimulation
{
    public class Settings : MonoBehaviour
    {
        public Recipe[] Recipeis;
        public GridBench GridBench;

        public void Awake()
        {
            LoadSettings();
            InitGridBench();
        }

        public void Start()
        {
            foreach (var recipe in Recipeis)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.name = $"item_{recipe.id}";
                var bench = cube.AddComponent<Bench>();
                bench.Recipe = recipe;
                GridBench.Add(bench);
            }

            GridBench.Update();
        }
        
        private void InitGridBench()
        {
            GridBench = new GridBench();
            GridBench.Scale = 5;
        }

        private void LoadSettings()
        {
            TextAsset jsonTextFile = Resources.Load<TextAsset>("Data/recipe");
            var setting = JsonUtility.FromJson<Setting>(jsonTextFile.text);

            Recipeis = setting.recipeis;
        }
    }
}
