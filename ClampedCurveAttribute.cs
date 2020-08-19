using UnityEngine;

namespace AnimationCurveClamped
{
    public class ClampedCurveAttribute : PropertyAttribute
    {
        public float screenHeight = -1;
        public Rect boundsRect;

        public ClampedCurveAttribute()
        {
            boundsRect = new Rect(0, 0, 1, 1);
        }

        public ClampedCurveAttribute(float x, float y)
        {
            boundsRect = new Rect(0, 0, x, y);
        }


        public ClampedCurveAttribute(float x, float y, float screenHeight)
        {
            boundsRect = new Rect(0, 0, x, y);
            this.screenHeight = screenHeight;
        }

        public ClampedCurveAttribute(float xMin, float yMin, float xMax, float yMax)
        {
            boundsRect = new Rect(xMin, yMin, xMax - xMin, yMax - yMin);
        }

        public ClampedCurveAttribute(float xMin, float yMin, float xMax, float yMax, float screenHeight)
        {
            boundsRect = new Rect(xMin, yMin, xMax - xMin, yMax - yMin);

            this.screenHeight = screenHeight;
        }
    }
}