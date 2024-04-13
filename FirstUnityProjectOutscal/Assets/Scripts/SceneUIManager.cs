using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneUIManager : MonoBehaviour
{
    [SerializeField]
    private string scene1Name;


    [SerializeField]
    private Button backButton;
    // Start is called before the first frame update
    void Start()
    {
        backButton.onClick.AddListener(OnBackButtonClicked);
    }

    private void OnBackButtonClicked()
    {
        SceneManager.LoadScene(scene1Name);
    }
}
