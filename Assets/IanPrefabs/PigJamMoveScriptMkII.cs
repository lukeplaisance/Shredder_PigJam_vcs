using UnityEngine;

public class PigJamMoveScriptMkII : MonoBehaviour
{
    public Rigidbody Pigjamplayer;
    public Transform Pigjamposition;
    public float Pigjamxtracker=0f;
    public float Pigjamxtarget=0f;
    public bool ChangingLeft = false;
    public bool ChangingRight = false;
    //public float LaneChangeSpeed = 8f;
    //public float LaneChangeElapsed = 0f;
    void Start()
    {
        Pigjamplayer.AddForce(0,0,250);
    }
    void Update()
    {
        if(Input.GetKeyDown("left") && Pigjamxtracker > -2 && ChangingLeft == false && ChangingRight == false /* Pigjamtracker - Pigjamtarget < 0.05f && Pigjamtracker - Pigjamtarget > -0.05f*/)
        {
            Pigjamxtarget--;
            ChangingLeft = true;
        }
        if(Input.GetKeyDown("right") && Pigjamxtracker < 2 && ChangingLeft == false && ChangingRight == false /*Pigjamtracker - Pigjamtarget < 0.05f && Pigjamtracker - Pigjamtarget > -0.05f*/)
        {
            Pigjamxtarget++;
            ChangingRight = true;
        }
        if(ChangingLeft == true) 
        {    
            if(Pigjamxtracker > Pigjamxtarget) 
            {      
            Pigjamposition.position += Vector3.left * 0.04f;
            Pigjamxtracker = Pigjamxtracker - 0.04f;
            }
            else{ChangingLeft = false;}
        }
       /* else if(ChangingLeft == true && Pigjamxtracker <= Pigjamxtarget)
        {
            ChangingLeft = false;
        }   */
        if(ChangingRight == true) 
        {
            if(Pigjamxtracker < Pigjamxtarget)
            {
            Pigjamposition.position += Vector3.right * 0.04f; 
            Pigjamxtracker = Pigjamxtracker + 0.04f;
            }
            else{ChangingRight = false;}
        }
        /*else if(ChangingLeft == true && Pigjamxtracker >= Pigjamxtarget)
        {
            ChangingRight = false;
        }*/
    }
}
