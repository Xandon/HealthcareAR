using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIProgressBehavior : MonoBehaviour {

    [SerializeField] private GameObject logInPanel;
    [SerializeField] private GameObject instructionsPanel;
    [SerializeField] private GameObject equipmentPanel;
    [SerializeField] private GameObject confirmationPanel;
    [SerializeField] private GameObject splashScreenPanel;

    public void Start()
    {
        StartCoroutine(FadeOutSplashScreen());
    }

    public void LoadInstructionsUI()
    {
        // Hide Login Panel
        logInPanel.SetActive(false);

        // Show Instructions Panel
        instructionsPanel.SetActive(true);
    }

    public void LoadMainUI()
    {
        // Hide Instructions Panel
        instructionsPanel.SetActive(false);
        equipmentPanel.SetActive(true);
    }

    public void LoadConfirmationUI()
    {
        // Hide Equipment Panel
        equipmentPanel.SetActive(false);

        // Show Confirmation Panel
        confirmationPanel.SetActive(true);
    }

    public void RestartScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    IEnumerator FadeOutSplashScreen()
    {
        yield return new WaitForSeconds(3);
        GameObject splashScreen = GameObject.Find("SplashPanel");
        splashScreen.GetComponent<Fade>().FadeOut();
        yield return new WaitForSeconds(3);
        splashScreenPanel.SetActive(false);
        logInPanel.SetActive(true);
    }
}
