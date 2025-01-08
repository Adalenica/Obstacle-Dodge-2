using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    void OnCollisionEnter(Collision other)   
    {
        hits = hits +1;
        Debug.Log("You've bumped into a thing this many times" + hits);
    }
}
