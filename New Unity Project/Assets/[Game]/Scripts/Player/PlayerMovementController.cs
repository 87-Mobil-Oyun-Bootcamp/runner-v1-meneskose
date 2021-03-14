using System;
using System.Collections;
using System.Collections.Generic;
using Runner.Managers;
using UnityEngine;

namespace Runner.Player
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private PlayerSettings _playerSettings;
        private bool _isRunning;

        [SerializeField] private InputManagers _swerveInputSystem;
        [SerializeField] private float _swerveSpeed = 0.5f;
        [SerializeField] private float _maxSwerveAmount =1f;

       private void OnEnable()
        {
            EventManager.GameStarted += StartRunning;
        }

        private void OnDisable()
        {
            EventManager.GameStarted -= StartRunning;
        }

        private void Update()
        {
            if (_isRunning)
            {
               float swerveAmount = Time.deltaTime * _swerveSpeed * _swerveInputSystem.MoveFactorX;
                var transformPosition = transform.position;
                transformPosition.x = Mathf.Clamp(transformPosition.x, -_maxSwerveAmount, _maxSwerveAmount);
                transform.position = transformPosition;
                transform.Translate(swerveAmount, 0, (_playerSettings.Speed * Time.deltaTime));
            }
        }

        private void StartRunning()
        {
            _playerSettings.Speed = 3.75f;
            _isRunning = true;
            EventManager.PlayerRunning?.Invoke(_isRunning);
        }

        private void OnTriggerEnter(Collider other)
        {
            ICollectableObject obje = other.GetComponent<ICollectableObject>();
            obje?.Interaction();
        }
    }
}