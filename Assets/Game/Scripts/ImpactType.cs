using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactType : MonoBehaviour
{
    public enum collsionType { obstacle, keyNote };

    public collsionType colType;

    private Collider _collider;

   /* private void Awake()
    {
        _collider = GetComponent<Collider>();
        VFXManager.RegisterHit(_collider, colType);
    }
    private void OnDestroy()
    {
        VFXManager.DeregisterHit(_collider, colType);
    }*/

}
