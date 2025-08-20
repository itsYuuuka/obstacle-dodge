using UnityEngine;

public class Scorer : MonoBehaviour
{
   int hits = 0; 

   private void OnCollisionEnter(Collision other)
    {
        hits++;
        Debug.Log("Player bumped " + hits + " times into an obstacle!");
    }
}
