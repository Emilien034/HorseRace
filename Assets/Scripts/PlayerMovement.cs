using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rbPlayer;
    [SerializeField] private float speed = 5.0f;
    

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        rbPlayer.AddForce(0.0f, 0.0f, speed);
    }
}
