using System;
using Module.BusinessSimulation.Model;
using Module.BusinessSimulation.Model.Setting;
using UnityEngine;

namespace Module.BusinessSimulation.Behaviour
{
    public class Bench : MonoBehaviour
    {
        public Recipe Recipe;
        public GameObject Box => transform.Find("Box").gameObject;
        public GameObject InBox => transform.Find("InBox").gameObject;
        public GameObject OutBox => transform.Find("OutBox").gameObject;
    }
}