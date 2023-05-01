using UnityEngine;

namespace CodeBase.Services.Input
{
    public interface IInputService
    {
        public Vector3 Axis { get; }
        public float HorizontalRaw { get; }
        public float VerticalRaw { get; }
    }
}