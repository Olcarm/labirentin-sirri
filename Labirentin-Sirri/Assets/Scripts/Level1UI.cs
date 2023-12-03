using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering.Universal;

public class Level1UI : MonoBehaviour
{
    
    [Header("UI Pages")]
    public GameObject levelMenu;
    public GameObject selectLevel;
    public GameObject completeLevel;
    public TMPro.TMP_Dropdown ddLevels;

    [Header("Main Menu Buttons")]
    public Button nextButton;
    public Button restartButton;
    public Button mainMenuButton;
    public Button selectLevelButton;
    public Button startLevelButton;

    [Header("Socket Interactors")]
    public GameObject object1;
    public GameObject socket1;
    public GameObject object2;
    public GameObject socket2;
    public GameObject object3;
    public GameObject socket3;
    public GameObject object4;
    public GameObject socket4;

    [Header("Next Level Index")]
    public int nextIndex;

    public List<Button> returnButtons;
    private bool check = false;


    void Start()
    {
        EnableLevelMenu();

        nextButton.onClick.AddListener(NextLevel);
        restartButton.onClick.AddListener(RestartLevel);
        mainMenuButton.onClick.AddListener(ReturnToMain);
        selectLevelButton.onClick.AddListener(SelectLevels);
        startLevelButton.onClick.AddListener(SwitchToSelectedLevel);

        foreach (var item in returnButtons)
        {
            item.onClick.AddListener(EnableLevelMenu);
            check = false;
        }


    }
    void Update()
    {

        if (object1.transform.position == socket1.transform.position && object2.transform.position == socket2.transform.position
            && object3.transform.position == socket3.transform.position && object4.transform.position == socket4.transform.position)
        {
            if(check == false)
            {
                EnableLevelMenu();
                completeLevel.SetActive(true);
            }
            
        }
        else
        {
            //HideAll();
            check = false;
            completeLevel.SetActive(false);
        }

    }
    public void HideAll()
    {
        levelMenu.SetActive(false);
        selectLevel.SetActive(false);
        check = false;
    }

    public void EnableLevelMenu()
    {
        levelMenu.SetActive(true);
        selectLevel.SetActive(false);
        check = true;
        
    }
    public void SelectLevels()
    {
        levelMenu.SetActive(false);
        selectLevel.SetActive(true);
    }
    public void RestartLevel()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToSceneAsync(1);
    }
    public void NextLevel()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToSceneAsync(nextIndex);
    }
    public void ReturnToMain()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToSceneAsync(0);
    }
    public void SwitchToSelectedLevel()
    {
        if (ddLevels.value == 0) {
            HideAll();
            SceneTransitionManager.singleton.GoToSceneAsync(1);
        }
        
        else if (ddLevels.value == 1)
        {
            HideAll();
            SceneTransitionManager.singleton.GoToSceneAsync(2);

        }
        else if (ddLevels.value == 2)
        {
            HideAll();
            SceneTransitionManager.singleton.GoToSceneAsync(3);

        }
        else if (ddLevels.value == 3)
        {
            HideAll();
            SceneTransitionManager.singleton.GoToSceneAsync(4);

        }
        else if (ddLevels.value == 4)
        {
            HideAll();
            SceneTransitionManager.singleton.GoToSceneAsync(5);

        }
    }
}
