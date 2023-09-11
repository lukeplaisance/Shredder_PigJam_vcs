
using UnityEngine;

public class MoveTheBlock : MonoBehaviour
{
    public float TrackMoveSpeed = 5f;
    public Transform blockposition;
    void Update()
    {
        blockposition.position = blockposition.position + Vector3.back * TrackMoveSpeed * Time.deltaTime;
        
    }
}
