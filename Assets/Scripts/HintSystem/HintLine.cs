using UnityEngine.AI;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class HintLine : MonoBehaviour
{
    public float waveAmplitude = 0.3f;
    public float waveFrequency = 2f;
    public float waveSpeed = 2f;

    LineRenderer line;
    Vector3[] basePoints;

    void Awake()
    {
        line = GetComponent<LineRenderer>();

        if (line == null)
        {
            Debug.LogError("LineRenderer НЕ найден на HintLine!");
        }
    }

    public void DrawPath(NavMeshPath path)
    {
        if (path == null || path.corners.Length == 0)
        {
            Debug.LogWarning("Путь не найден");
            return;
        }

        basePoints = path.corners;
        line.positionCount = basePoints.Length;
        line.SetPositions(basePoints);
    }

    void Update()
    {
        if (basePoints == null) return;

        Vector3[] animated = new Vector3[basePoints.Length];

        for (int i = 0; i < basePoints.Length; i++)
        {
            Vector3 dir = Vector3.Cross(Vector3.up, GetDirection(i));
            float wave = Mathf.Sin(Time.time * waveSpeed + i * waveFrequency) * waveAmplitude;
            animated[i] = basePoints[i] + dir * wave;
        }

        line.SetPositions(animated);
    }

    Vector3 GetDirection(int i)
    {
        if (i == basePoints.Length - 1)
            return basePoints[i] - basePoints[i - 1];
        return basePoints[i + 1] - basePoints[i];
    }
}