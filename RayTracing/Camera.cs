using System.Numerics;

namespace RayTracing
{
    public class Camera
    {
        public int Width { get; }
        public int Height { get; }
        public float FOV { get; }
        public Vector3 Position { get; }
        public Vector3 Direction { get; }

        public Camera(int width, int height, float fov, Vector3 position, Vector3 direction)
        {
            Width = width;
            Height = height;
            FOV = fov;
            Position = position;
            Direction = direction;
        }
    }
}