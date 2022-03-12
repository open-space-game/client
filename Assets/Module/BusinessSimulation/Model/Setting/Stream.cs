using System;

namespace Module.BusinessSimulation.Model.Setting
{
    [Serializable]
    public class Stream
    {
        public int id;
        public string type;
        public string item;
        public int itemId;
        public StreamInfo info;
    }
}