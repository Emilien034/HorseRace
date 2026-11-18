using System;
using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private Transform playerTransform;
    void Update()
    {
        scoreText.text = "Score: "+Convert.ToInt32(playerTransform.position.z);
    }
}
