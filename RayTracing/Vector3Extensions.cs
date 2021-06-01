using System;
using System.Numerics;

namespace RayTracing
{
    public static class Vector3Extensions
    {
        public static float GetCoordPermutationsWith(this Vector3 v1, Vector3 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }
        
        public static Vector3 Normalize(this Vector3 v1) 
        {
            return v1 / (float) Math.Sqrt(v1.X * v1.X + v1.Y * v1.Y + v1.Z * v1.Z);
        }
    }
}