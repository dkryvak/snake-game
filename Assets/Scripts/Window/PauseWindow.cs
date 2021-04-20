using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class PauseWindow : MonoBehaviour
{

    private static PauseWindow i;

    public static void ShowStatic()
    {
        i.Show();
    }

    public static void HideStatic()
    {
        i.Hide();
    }

    private void Awake()
    {
        i = this;

        transform.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
        transform.GetComponent<RectTransform>().sizeDelta = Vector2.zero;

        transform.Find("ResumeButton").GetComponent<Button_UI>().ClickFunc = () => GameHandler.ResumeGame();

        transform.Find("MainMenuButton").GetComponent<Button_UI>().ClickFunc = () => Loader.Load(Loader.Scene.MainMenu);

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
