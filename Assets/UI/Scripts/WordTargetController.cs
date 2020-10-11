﻿using System;
using System.Linq;
using UnityEngine;

namespace UI.Scripts
{
    public class WordTargetController : MonoBehaviour
    {
        public GameObject Target;
        private RectTransform _rectTransform;
        private UIController _uiController;

        private void Start()
        {
            _rectTransform = GetComponent<RectTransform>();
            if (!(Camera.main is null)) _uiController = Camera.main.GetComponent<UIController>();
            _rectTransform.anchoredPosition = Input.mousePosition;
        }

        private void Update()
        {
            _rectTransform.anchoredPosition = _uiController.WorldToScreenPoint(Target.transform.position);
        }
    }
}