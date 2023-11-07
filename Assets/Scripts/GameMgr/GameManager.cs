using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//lives; if ball goes past player lose a life
public class GameManager : MonoBehaviour
{
    //Scriptable Object
    public int totalLives;
    public int bricksDestroyed = 0;
    public int AmntBricksDestroy=32;
    public GameState gameState;
    public Scene nextScene;
    public Scene endScene;

    private int lives;
    void Start()
    {
        gameState = GameState.Gameplay;
        lives = totalLives;

    }

    // Update is called once per frame
    void Update()
    {
        if (bricksDestroyed == AmntBricksDestroy)
        { 
            TransitionLevel();
        }
        //If lives 0 game over, not too sure how lives system will work, one life/ multiple?
        if (lives <= 0)
        {
            gameState = GameState.GameOver;
        }

        if (gameState == GameState.GameOver)
        {
            SceneManager.LoadScene(endScene.name);
        }
    }

    public GameState GetGameState()
    {
        return gameState;
    }

    private void SpawnInBricks()
    {
        if (gameState == GameState.Gameplay)
        {
            //Start Brick Spawning
        }
    }

    private void TransitionLevel()
    {
        SceneManager.LoadScene(nextScene.name);
    }


}
