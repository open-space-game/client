using System;
using System.Linq;
using Module.BusinessSimulation.Behaviour;
using Module.BusinessSimulation.Builder;
using Module.BusinessSimulation.Model;
using Module.BusinessSimulation.Model.Setting;
using UnityEngine;

namespace Module.BusinessSimulation
{
    public class Settings : MonoBehaviour
    {
        public Recipe[] Recipeis;
        public GridBench GridBench;
        public GameObject BenchPrefab;
        private BenchBuilder BenchBuilder;

        public void Awake()
        {
            LoadSettings();
            InitGridBench();
            InitBenchBuilder();
        }

        private void InitBenchBuilder()
        {
            BenchBuilder = new BenchBuilder();
            BenchBuilder.BenchPrefab = BenchPrefab;
        }

        public void Start()
        {
            foreach (var recipe in Recipeis)
            {
                var bench = BenchBuilder.create(recipe);
                GridBench.Add(bench);
            }

            GridBench.Update();
        }

        private void InitGridBench()
        {
            GridBench = new GridBench();
            GridBench.Scale = 3;
        }

        private void LoadSettings()
        {
            TextAsset jsonTextFile = Resources.Load<TextAsset>("Data/recipe");
            var setting = JsonUtility.FromJson<Setting>(jsonTextFile.text);

            Recipeis = setting.recipeis;
        }
    }
}
