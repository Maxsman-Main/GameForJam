using UnityEngine;

namespace CodeBase.Services.Input
{
    public class StandaloneInputService : IInputService
    {
        private const string HorizontalAxisName = "Horizontal";
        private const string VerticalAxisName = "Vertical";
    
        public Vector3 Axis => new(UnityEngine.Input.GetAxis(HorizontalAxisName), UnityEngine.Input.GetAxis(VerticalAxisName));
        public float HorizontalRaw => UnityEngine.Input.GetAxisRaw(HorizontalAxisName);
        public float VerticalRaw => UnityEngine.Input.GetAxisRaw(VerticalAxisName);
    }
}