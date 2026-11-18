using UnityEngine;

public class CompletedTrigger : MonoBehaviour
{
    [SerializeField] private GameManager gameManagerScript;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            gameManagerScript.CompleteLevel();
        }
    }
}
