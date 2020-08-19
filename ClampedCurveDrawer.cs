using UnityEditor;
using UnityEngine;

namespace AnimationCurveClamped
{
    [CustomPropertyDrawer(typeof(ClampedCurveAttribute))]
    public class ClampedCurveDrawer : PropertyDrawer
    {
        private float _height = -1;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            ClampedCurveAttribute clampedCurve = attribute as ClampedCurveAttribute;

            if (clampedCurve == null)
            {
                return;
            }
            if (property.propertyType == SerializedPropertyType.AnimationCurve)
            {
                if (clampedCurve.screenHeight > 0)
                {
                    position.height = clampedCurve.screenHeight;
                    _height = clampedCurve.screenHeight;
                }
            

                EditorGUI.CurveField(position, property, Color.red, clampedCurve.boundsRect);
            }
            else
            {
                EditorGUI.LabelField(position, label.text, "Use ClampedCurve with AnimationCurve.");
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return _height <= -1 ? base.GetPropertyHeight(property, label) : _height;
        }
    }
}