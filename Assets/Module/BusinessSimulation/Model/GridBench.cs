using System.Collections.ObjectModel;
using Module.BusinessSimulation.Behaviour;
using UnityEngine;

namespace Module.BusinessSimulation.Model
{
    public class GridBench: Collection<Bench>
    {
        public float Scale = 20;

        public void Update()
        {
            var count = 0.0f;
            var sizeX = (int)Mathf.Sqrt(Count);
            
            Debug.Log(sizeX);
            foreach (var item in Items)
            {
                SetPosition(item, new Vector2(
                    count % sizeX, 
                    count / sizeX
                ));
                
                count++;
            }    
        }

        private void SetPosition(Bench item, Vector2 position)
        {
            item.transform.position = new Vector3(
                position.x * Scale,
                0,
                position.y * Scale
            );
        }
    }
}