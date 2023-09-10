
using UnityEngine;

public class MoveTheBlock : MonoBehaviour
{

    public Transform blockposition;
    void Update()
    {
        blockposition.position = blockposition.position + Vector3.back * 0.5f * Time.deltaTime;
        
    }
}
