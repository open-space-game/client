using Module.BusinessSimulation.Behaviour;
using Module.BusinessSimulation.Model.Setting;
using UnityEngine;

namespace Module.BusinessSimulation.Builder
{
    public class BenchBuilder
    {
        public GameObject BenchPrefab;
        
        public Bench create(Recipe recipe)
        {
            var cube = GameObject.Instantiate(BenchPrefab);
            cube.name = $"bench_{recipe.id}";
            var bench = cube.transform.GetComponent<Bench>();
            bench.Recipe = recipe;
            
            initScaleBox( bench.Box, recipe.info.sizeBox);
            
            // recipe.info.sizeIn;
            // recipe.info.sizeOut;
            
            return bench;
        }

        private void initScaleBox(GameObject benchBox, int sizeBox)
        {
            benchBox.transform.localScale = extractScaleBox(sizeBox);
            
        }

        private Vector3 extractScaleBox(int sizeBox)
        {
            switch (sizeBox)
            {
                case 2: 
                    return new Vector3(1, 1, 2);
                case 4:
                    return new Vector3(2, 1, 2);
                case 6:
                    return new Vector3(2, 1, 3);
                case 8:
                    return new Vector3(2, 1, 4);
                case 12:
                    return new Vector3(3, 1, 4);
                default:
                    Debug.Log(sizeBox);
                    return  new Vector3(1, 1, 2);
            }
        }
    }
}