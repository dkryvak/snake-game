using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;

public class GameOverWindow : MonoBehaviour
{

    private static GameOverWindow i;

    public static void ShowStatic()
    {
        i.Show();
    }

    private void Awake()
    {
        i = this;

        transform.Find("RetryButton").GetComponent<Button_UI>().ClickFunc = () =>
        {
            Loader.Load(Loader.Scene.GameSnake);
        };

        Hide();
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }

}
