using System;
using System.Collections;
using System.Collections.Generic;
using Runner.Managers;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Runner.Managers
{
    public class PlayerAnimController : MonoBehaviour
    {
        private Animator _playerAnim;
        private readonly int _runningAnim = Animator.StringToHash("isRunning");

        private void Awake()
        {
            _playerAnim = GetComponent<Animator>();
        }

        private void OnEnable()
        {
            EventManager.PlayerRunning += RunningAnim;
        }

        private void OnDisable()
        {
            EventManager.PlayerRunning -= RunningAnim;
        }

        
        private void RunningAnim(bool isRunning) => _playerAnim.SetBool(_runningAnim, isRunning);

    }
}

