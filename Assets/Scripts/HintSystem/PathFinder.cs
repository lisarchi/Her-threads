using UnityEngine;
using UnityEngine.AI;

public class PathFinder : MonoBehaviour
{
    public Transform player;
    public Transform checkpoint;

    public NavMeshPath GetPath()
    {
        NavMeshPath path = new NavMeshPath();
        NavMesh.CalculatePath(
            player.position,
            checkpoint.position,
            NavMesh.AllAreas,
            path
        );
        return path;
    }
}