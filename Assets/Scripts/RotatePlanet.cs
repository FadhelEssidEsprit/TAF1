using UnityEngine;

public class RotatePlanet : MonoBehaviour
{
    public float speed = 0f;
   
    //Forward Direction
    public bool x = false;
    public bool y = false;
    public bool z = false;
   
    //Reverse Direction
    public bool ReverseX = false;
    public bool ReverseY = false;
    public bool ReverseZ = false;
   
    void Update ()
    {
        
        if(x == true)
        {
            transform.Rotate(Time.deltaTime * speed, 0, 0, Space.Self);
        }
        if(y == true)
        {
            transform.Rotate(0, Time.deltaTime * speed,  0, Space.Self);
        }
        if(z == true)
        {
            transform.Rotate(0, 0, Time.deltaTime * speed, Space.Self);
        }
        //Reverse 
        if(ReverseX == true)
        {
            transform.Rotate(-Time.deltaTime * speed, 0, 0, Space.Self);
        }
        if(ReverseY == true)
        {
            transform.Rotate(0, -Time.deltaTime * speed,  0, Space.Self);
        }
        if(ReverseZ == true)
        {
            transform.Rotate(0, 0, -Time.deltaTime * speed, Space.Self);
        }
       
    }
}
