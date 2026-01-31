using UnityEngine;
using UnityEngine.AI;

public class HintPath : MonoBehaviour
{
    [Header("References")]
    public Transform player;
    public Transform playerParent;
    public LineRenderer line;
    public Transform[] checkpoints;

    [Header("Wave")]
    public float waveSpeed = 2f;
    public float waveHeight = 0.12f;

    [Header("Heights")]
    public float baseHeight = 0.7f;   // высота старта от игрока
    public float anchorHeight = 0.6f;   // высота линии над NavMesh
    public int heightBlendPoints = 8; // переход высоты

    [Header("Detach from NavMesh")]
    public float detachDistance = 0f;
    public int detachPoints = 2;

    [Header("Smoothing")]
    public float smoothFollowSpeed = 6f;

    private NavMeshPath path;
    private int currentIndex = 0;
    private bool hintActive = false;
    private float updateTimer;

    private Vector3[] targetPositions;
    private Vector3[] currentPositions;

    void Awake()
    {
        path = new NavMeshPath();
        line.enabled = false;
    }

    void Update()
    {
        // Toggle
        if (UserInput.instance.HintPressed)
        {
            hintActive = !hintActive;
            line.enabled = hintActive;

            if (!hintActive)
            {
                line.positionCount = 0;
                targetPositions = null;
                currentPositions = null;
            }
        }

        if (!hintActive) return;
        if (currentIndex >= checkpoints.Length) return;

        // NavMesh обновляем не каждый кадр
        updateTimer -= Time.deltaTime;
        if (updateTimer > 0f) return;
        updateTimer = 0.01f;

        NavMesh.CalculatePath(
            GetNavMeshPoint(player.position),
            GetNavMeshPoint(checkpoints[currentIndex].position),
            NavMesh.AllAreas,
            path
        );

        if (path.status != NavMeshPathStatus.PathComplete || path.corners.Length < 2)
            return;

        Vector3[] smooth = SmoothPath(path.corners, 12);
        targetPositions = BuildTargetPath(smooth);
    }

    void LateUpdate()
    {
        if (!hintActive || targetPositions == null) return;

        if (currentPositions == null || currentPositions.Length != targetPositions.Length)
        {
            currentPositions = (Vector3[])targetPositions.Clone();
            line.positionCount = currentPositions.Length;
        }

        for (int i = 0; i < currentPositions.Length; i++)
        {
            currentPositions[i] = Vector3.Lerp(
                currentPositions[i],
                targetPositions[i],
                Time.deltaTime * smoothFollowSpeed
            );

            line.SetPosition(i, currentPositions[i]);
        }
    }

    Vector3[] BuildTargetPath(Vector3[] navPoints)
    {
        Vector3 playerStart = playerParent.position + Vector3.up * baseHeight;

        Vector3 navAnchor = LiftFromNavMesh(navPoints[0]);
        navAnchor.y += anchorHeight;

        Vector3 dir = (navAnchor - playerStart).normalized;
        Vector3 detachedStart = playerStart + dir * detachDistance;

        int total = detachPoints + navPoints.Length;
        Vector3[] result = new Vector3[total];

        for (int i = 0; i < detachPoints; i++)
        {
            float t = i / (float)(detachPoints - 1);
            result[i] = Vector3.Lerp(playerStart, detachedStart, t);
        }

        for (int i = 0; i < navPoints.Length; i++)
        {
            Vector3 nav = LiftFromNavMesh(navPoints[i]);
            nav.y += anchorHeight;

            float blend = Mathf.Clamp01((i + detachPoints) / (float)heightBlendPoints);
            Vector3 pos = Vector3.Lerp(detachedStart, nav, blend);

            float t = (i + detachPoints) / (float)(total - 1);
            float envelope = Mathf.Sin(Mathf.PI * t);
            float wave = Mathf.Sin(Time.time * waveSpeed - i * 0.45f) * waveHeight * envelope;

            pos.y += wave;
            result[i + detachPoints] = pos;
        }

        return result;
    }

    Vector3[] SmoothPath(Vector3[] corners, int subdivisions)
    {
        var points = new System.Collections.Generic.List<Vector3>();

        for (int i = 0; i < corners.Length - 1; i++)
        {
            Vector3 a = corners[i];
            Vector3 b = corners[i + 1];

            for (int j = 0; j < subdivisions; j++)
            {
                float t = j / (float)subdivisions;
                points.Add(Vector3.Lerp(a, b, t));
            }
        }

        points.Add(corners[corners.Length - 1]);
        return points.ToArray();
    }

    public void GoNextCheckpoint()
    {
        currentIndex++;

        if (currentIndex >= checkpoints.Length)
        {
            hintActive = false;
            line.enabled = false;
            line.positionCount = 0;
            targetPositions = null;
            currentPositions = null;
        }
    }

    Vector3 GetNavMeshPoint(Vector3 position)
    {
        if (NavMesh.SamplePosition(position, out NavMeshHit hit, 2f, NavMesh.AllAreas))
            return hit.position;

        return position;
    }

    Vector3 LiftFromNavMesh(Vector3 point)
    {
        if (NavMesh.SamplePosition(point, out NavMeshHit hit, 1f, NavMesh.AllAreas))
            return hit.position;

        return point;
    }
}

