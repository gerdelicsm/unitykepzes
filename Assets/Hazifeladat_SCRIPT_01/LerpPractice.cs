using UnityEngine;

public class LerpPractice : MonoBehaviour
{
    [SerializeField] Color colorA, colorB;
    [SerializeField, Range(0,1)] float t;
    [SerializeField] Vector3 posA, posB;

    [SerializeField] Color lerpColor;
    [SerializeField] Vector3 lerpPos;

    void OnValidate()
    {
        lerpColor = Color.Lerp(colorA, colorB, t);   
        lerpPos = Vector3.Lerp(posA, posB, t);   
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = colorA;
        Gizmos.DrawWireSphere(posA, 0.1f);
        Gizmos.color = colorB;
        Gizmos.DrawWireSphere(posB, 0.1f);
        Gizmos.color = lerpColor;
        Gizmos.DrawWireSphere(lerpPos, 0.1f);

    }

}
