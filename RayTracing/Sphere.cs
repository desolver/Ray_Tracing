using System;
using System.Numerics;

namespace RayTracing
{
    public class Sphere
    {
        public Vector3 Center { get; }
        public float Radius { get; }

        public Sphere(Vector3 center, float radius)
        {
            Center = center;
            Radius = radius;
        }
        
        public bool IsIntersectWithRay(Vector3 origin, Vector3 originDirection, ref float t0)
        {
            var directionToCenter = Center - origin;
            var tca = directionToCenter.GetCoordPermutationsWith(originDirection);
            var d2 = directionToCenter.GetCoordPermutationsWith(directionToCenter) - tca * tca;

            if (d2 > Radius * Radius) 
                return false;

            var thc = (float) Math.Sqrt(Radius * Radius - d2);
            t0 = tca - thc;
            
            var t1 = tca + thc;
            if (t0 < 0) t0 = t1;
            if (t0 < 0) return false;
            return true;
        }
    }
}