using System.Numerics;

namespace RayTracing
{
    public class Light
    {
        public Vector3 Position { get; }
        public float Intensity { get; }
        
        public Light(Vector3 position, float intensity)
        {
            Position = position;
            Intensity = intensity;
        }
    }
}