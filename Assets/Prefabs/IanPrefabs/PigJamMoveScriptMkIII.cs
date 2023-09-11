using UnityEngine;

public class PigJamMoveScriptMkIII : MonoBehaviour
{
    public Rigidbody Pigjamplayer;
    public Transform Pigjamposition;
    public float Lanechangespeed = 10f;
    public float Pigjamxtarget = 0f;
    public bool ChangingLeft = false;
    public bool ChangingRight = false;
    
    /*void Start()
    {
        Pigjamplayer.AddForce(0, 0, 250);
    }*/
    void Update()
    {
        if (Input.GetKeyDown("left") && Pigjamxtarget > -1 && ChangingLeft == false && ChangingRight == false)
        {
            Pigjamxtarget--;
            ChangingLeft = true;
        }
        if (Input.GetKeyDown("right") && Pigjamxtarget < 2 && ChangingLeft == false && ChangingRight == false)
        {
            Pigjamxtarget++;
            ChangingRight = true;
        }
        if (ChangingLeft == true)
        {
            if (Pigjamposition.position.x > Pigjamxtarget)
            {
                Pigjamposition.position = Vector3.Lerp(Pigjamposition.position, Pigjamposition.position + Vector3.left, Lanechangespeed * Time.deltaTime);
            }
            else { ChangingLeft = false; }
        }
        
        if (ChangingRight == true)
        {
            if (Pigjamposition.position.x < Pigjamxtarget)
            {
                Pigjamposition.position = Vector3.Lerp(Pigjamposition.position, Pigjamposition.position + Vector3.right, Lanechangespeed * Time.deltaTime);
            }
            else { ChangingRight = false; }
        }
    }
}
