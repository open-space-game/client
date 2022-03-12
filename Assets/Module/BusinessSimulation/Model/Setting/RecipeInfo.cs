using System;

namespace Module.BusinessSimulation.Model.Setting
{
    [Serializable]
    public class RecipeInfo
    {
        public string label;
        public string factory;
        public int sizeIn;
        public int sizeOut;
        public string[] categories;
        public int sizeBox;
        public float time;
    }
}