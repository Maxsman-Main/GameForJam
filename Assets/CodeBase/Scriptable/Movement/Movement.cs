using UnityEngine;

namespace CodeBase.Scriptable.Movement
{
    [CreateAssetMenu(fileName = FileName, menuName = MenuName)]
    public class Movement : ScriptableObject
    {
        private const string FileName = "NormalMovement";
        private const string MenuName = "Movement/NormalMovement";

        public float movementSpeed;
        
        public void Move(Vector3 input, Rigidbody2D rigidbody)
        {
            Vector2 newVelocity = new Vector2(input.x * movementSpeed, input.y * movementSpeed); 
            rigidbody.velocity = newVelocity;
        }
    }
}