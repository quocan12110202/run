using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int score;
    public TextMeshProUGUI scoreText;
    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.SetText(score.ToString());
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.SetText(score.ToString());
    }
}
