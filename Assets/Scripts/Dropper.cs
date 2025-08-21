using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float droptTime = 2f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Time.time > droptTime)
        {
            Debug.Log("Dropping object after 3 seconds");
        }
    }
}
