using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int _score;
    public List<GameObject> enemy;
    private float spawnRate = 2f;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    public Button restartButton;
    public GameObject titleScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartGame(int difficulty)
    {
        isGameActive = true;
        _score = 0;
        spawnRate /= difficulty;
        StartCoroutine(SpawnEnemy());
        UpdateScore(0);
        titleScreen.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnEnemy()
    {
        
        while (isGameActive)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-18, 18), 0, 18);
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, enemy.Count);
            Instantiate(enemy[index], spawnPos, enemy[index].transform.rotation);

            
        }
    }
    
    public void UpdateScore(int addScore)
    {
        _score += addScore;
        scoreText.text = "Score: " + _score;
    }

    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
