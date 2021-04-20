using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;

public class MainMenuWindow : MonoBehaviour
{

    private enum SubMenu
    {
        Main,
        HowToPlay
    }

    private void Awake()
    {
        transform.Find("HowToPlaySubMenu").GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
        transform.Find("MainSubMenu").GetComponent<RectTransform>().anchoredPosition = Vector2.zero;

        transform.Find("MainSubMenu").Find("PlayButton").GetComponent<Button_UI>().ClickFunc = () => Loader.Load(Loader.Scene.GameSnake);

        transform.Find("MainSubMenu").Find("HowToPlayButton").GetComponent<Button_UI>().ClickFunc = () => ShowSubMenu(SubMenu.HowToPlay);

        transform.Find("MainSubMenu").Find("QuitButton").GetComponent<Button_UI>().ClickFunc = () => Application.Quit();

        transform.Find("HowToPlaySubMenu").Find("BackButton").GetComponent<Button_UI>().ClickFunc = () => ShowSubMenu(SubMenu.Main);

        ShowSubMenu(SubMenu.Main);
    }

    private void ShowSubMenu(SubMenu subMenu)
    {
        transform.Find("MainSubMenu").gameObject.SetActive(false);
        transform.Find("HowToPlaySubMenu").gameObject.SetActive(false);

        switch (subMenu)
        {
            case SubMenu.Main:
                transform.Find("MainSubMenu").gameObject.SetActive(true);
                break;
            case SubMenu.HowToPlay:
                transform.Find("HowToPlaySubMenu").gameObject.SetActive(true);
                break;
        }
    }

}
