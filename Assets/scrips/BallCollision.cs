using Unity.VisualScripting;
using UnityEngine;

public class BallCollision
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("De bal raakt: " + collision.gameObject.name);
    }
}
