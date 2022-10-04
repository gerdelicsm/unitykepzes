using UnityEngine;

public class GradientDrawer : MonoBehaviour
{
    [SerializeField, Min(2)] int segmentCount = 5;
    [SerializeField] Color colorA, colorB;
    [SerializeField] Vector3 pointA, pointB;

    void OnDrawGizmos()
    {
        for (int i = 0; i < segmentCount; i++)
        {
            float tColor = (float)i / (segmentCount - 1);
            Gizmos.color = Color.Lerp(colorA, colorB, tColor);

            Vector3 start = Vector3.Lerp(pointA, pointB, (float)i / segmentCount);
            Vector3 end = Vector3.Lerp(pointA, pointB, (float)(i + 1) / segmentCount);

            Gizmos.DrawLine(start, end);
        }
    }
}
