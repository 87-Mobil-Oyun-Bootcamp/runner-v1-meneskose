using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Runner.Managers
{
    public class GameManager : MonoBehaviour
    {
        private bool _isGameStarted;
        public static int ShurikenAmount;

        private void Start()
        {
            ShurikenAmount = 0;
        }

        private void Update()
        {
            if (!_isGameStarted)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    EventManager.GameStarted?.Invoke();
                    _isGameStarted = true;
                }
            }
        }
    }
}

