using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{

    public Vector3 spawnPos;
    public Vector3 removePos;
     public float songPosition;

    //the current position of the song (in beats)
   public float songPosInBeats;
    public float beatOfThisNote;
   public float beatsShownInAdvance;


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(
         spawnPos,
         removePos,
         (beatsShownInAdvance - (beatOfThisNote - songPosInBeats)) / beatsShownInAdvance
     );
    }
}
