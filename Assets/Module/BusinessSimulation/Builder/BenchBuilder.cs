using System.Collections.Generic;
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
            initOutIcon(bench.IconsBox, recipe.OutStreams, bench.IconPrefab, bench.IconRepository);
            
            // recipe.info.sizeIn;
            // recipe.info.sizeOut;
            
            return bench;
        }

        private void initScaleBox(GameObject benchBox, int sizeBox)
        {
            benchBox.transform.localScale = extractScaleBox(sizeBox);
        }

        private void initOutIcon(
            GameObject benchIconsBox, 
            List<Stream> outStreamRecipe, 
            GameObject IconPrefab, 
            GameObject IconRepository)
        {
            var count = outStreamRecipe.Count;
            var index = 1;
            foreach (var stream in outStreamRecipe)
            {
                var icon = GameObject.Instantiate(IconPrefab, benchIconsBox.transform, true);
                
                var sprite = IconRepository.transform.Find($"img_{stream.itemId}").GetComponent<SpriteRenderer>().sprite;
                icon.transform.GetComponentInChildren<SpriteRenderer>().sprite = sprite;
                
                icon.transform.localPosition = Vector3.zero + Vector3.left * (index - 1 ) * 10 - Vector3.left * (count - 1) * 5 ;
                icon.transform.localRotation = Quaternion.Euler(Vector3.zero);
                icon.transform.localScale = Vector3.one;
                index++;
            }
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