using System;

namespace Module.BusinessSimulation.Model.Setting
{
    [Serializable]
    public class StreamInfo
    {
        public string label;
        public string message;
        public string countTimeType;
        //TODO:: convert to float
        public string countTime;
        public int count;
        public string itemType;
        public float time;
        public float weight;
        public float countCell;
    }
}