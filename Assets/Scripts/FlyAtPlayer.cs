using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] Transform player;
    Vector3 playerPos;

    void Start()
    {
        playerPos = player.transform.position;
    }

    void Update()
    {
        MoveTowardsPlayer();
        DestroyWhenReachedPlayer();
    }

    void MoveTowardsPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPos, Time.deltaTime * speed);
    }

    void DestroyWhenReachedPlayer()
    {
        if (transform.position == playerPos)
        {
            Destroy(gameObject);
        }
    }
}
