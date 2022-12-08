using UnityEngine;

public class OnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "obstacle")
        {
            
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
