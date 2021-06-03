using System.Drawing;

namespace RayTracing
{
    public class Material
    {
        public Color DiffuseColor { get; }

        public Material(Color diffuseColor)
        {
            DiffuseColor = diffuseColor;
        }
    }
}