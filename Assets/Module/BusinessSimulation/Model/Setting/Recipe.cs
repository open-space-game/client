using System;

namespace Module.BusinessSimulation.Model.Setting
{
    [Serializable]
    public class Recipe
    {
        public int id;
        public string type;
        public RecipeInfo info;
        public Stream[] streams;
    }
}