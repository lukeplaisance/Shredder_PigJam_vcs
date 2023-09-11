using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviroScroll : MonoBehaviour
{
    [SerializeField] private SongManager songManager;

    double timeInstantiated;

    private void Start()
    {
       
    }
    private void Update()
    {
        float t = songManager.songPosition;

            if(songManager.audio.isPlaying)
            transform.localPosition = Vector3.Lerp(new Vector3(0,0,0) , new Vector3(0,0,-1200f), t/100);  
            
        
    }
}
