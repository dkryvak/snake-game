using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;

public class GameHandler : MonoBehaviour
{

    [SerializeField] private Snake snake;

    private static GameHandler i;
    private static int score;

    private LevelGrid levelGrid;

    private void Awake()
    {
        i = this;

        InitializeStatic();
    }

    private void Start()
    {
        levelGrid = new LevelGrid(20, 20);

        snake.Setup(levelGrid);
        levelGrid.Setup(snake);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsGamePaused())
            {
                GameHandler.ResumeGame();
            }
            else
            {
                GameHandler.PauseGame();
            }
        }
    }

    private static void InitializeStatic()
    {
        score = 0;
    }

    public static int GetScore()
    {
        return score;
    }

    public static void AddScore()
    {
        score += 100;
    }

    public static void SnakeDied()
    {
        GameOverWindow.ShowStatic();
    }

    public static void ResumeGame()
    {
        PauseWindow.HideStatic();
        Time.timeScale = 1f;
    }

    public static void PauseGame()
    {
        PauseWindow.ShowStatic();
        Time.timeScale = 0f;
    }

    public static bool IsGamePaused()
    {
        return Time.timeScale == 0f;
    }

}
