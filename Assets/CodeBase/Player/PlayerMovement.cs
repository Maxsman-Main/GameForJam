using System;
using CodeBase.Scriptable.Movement;
using CodeBase.Services.Input;
using UnityEngine;
using Zenject;

namespace CodeBase.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [Inject] private IInputService _inputService;

        [SerializeField] private Movement movement;

        private Rigidbody2D _rigidbody;
        
        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            movement.Move(_inputService.Axis, _rigidbody);
        }
    }
}