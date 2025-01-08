using UnityEngine;

public class Dropper : MonoBehaviour
{
   
   
    void Update()
    {
       float DropTime = 3;
        if(Time.time > DropTime)
        {
            Debug.Log("Lookout Below"!);
        }
    }
}
