using System;
using System.Collections.Generic;
using System.Linq;

namespace Module.BusinessSimulation.Model.Setting
{
    [Serializable]
    public class Recipe
    {
        public int id;
        public string type;
        public RecipeInfo info;
        public Stream[] streams;
        public List<Stream> OutStreams => streams.Where(stream => stream.type == "out").ToList();
    }
}