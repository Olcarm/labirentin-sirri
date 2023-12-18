using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CiftKapi : MonoBehaviour
{
    [Header("UI Pages")]
    public GameObject levelMenu;
    public GameObject selectLevel;

    [Header("Main Menu Buttons")]
    public Button nextButton;
    public Button restartButton;
    public Button mainMenuButton;
    public Button selectLevelButton;
    public Button tekrarDeneButton;
    public Button restartHandMenu;
    [Header("Level Index")]
    public int nextIndex;
    public int currentIndex;
    public List<Button> returnButtons;

    [Header("Level Buttons")]
    public Button Level1Button;
    public Button Level2Button;
    public Button Level3Button;
    public Button Level4Button;
    public Button Level5Button;

    void Start()
    {
        EnableLevelMenu();

        nextButton.onClick.AddListener(NextLevel);
        restartButton.onClick.AddListener(RestartLevel);
        mainMenuButton.onClick.AddListener(ReturnToMain);
        selectLevelButton.onClick.AddListener(SelectLevels);
        tekrarDeneButton.onClick.AddListener(RestartLevel);
        Level1Button.onClick.AddListener(ChangeLevelto1);
        Level2Button.onClick.AddListener(ChangeLevelto2);
        Level3Button.onClick.AddListener(ChangeLevelto3);
        Level4Button.onClick.AddListener(ChangeLevelto4);
        Level5Button.onClick.AddListener(ChangeLevelto5);
        restartHandMenu.onClick.AddListener(RestartLevel);
        foreach (var item in returnButtons)
        {
            item.onClick.AddListener(EnableLevelMenu);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HideAll()
    {
        levelMenu.SetActive(false);
        selectLevel.SetActive(false);
    }

    public void EnableLevelMenu()
    {
        levelMenu.SetActive(true);
        selectLevel.SetActive(false);

    }
    public void SelectLevels()
    {
        levelMenu.SetActive(false);
        selectLevel.SetActive(true);
    }
    public void RestartLevel()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToSceneAsync(3);
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
    public void ChangeLevelto1()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToScene(1);
    }
    public void ChangeLevelto2()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToScene(2);
    }
    public void ChangeLevelto3()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToScene(3);
    }
    public void ChangeLevelto4()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToScene(4);
    }
    public void ChangeLevelto5()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToScene(5);
    }
}
