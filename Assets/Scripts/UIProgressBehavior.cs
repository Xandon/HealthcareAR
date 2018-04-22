using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIProgressBehavior : MonoBehaviour {

    [SerializeField] private GameObject logInPanel;
    [SerializeField] private GameObject instructionsPanel;

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
    }
}
