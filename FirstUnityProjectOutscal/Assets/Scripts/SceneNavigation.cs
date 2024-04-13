using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneNavigation : MonoBehaviour
{

    [SerializeField]
    private string scene1Name;
    [SerializeField]
    private string scene2Name;
    [SerializeField]
    private string scene3Name;

    [SerializeField]
    private Button button1;
    [SerializeField]
    private Button button2;
    [SerializeField]
    private Button button3;

    // Start is called before the first frame update
    void Start()
    {
        button1.onClick.AddListener(OnButton1Clicked);
        button2.onClick.AddListener(OnButton2Clicked);
        button3.onClick.AddListener(OnButton3Clicked);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnButton1Clicked()
    {
        SceneManager.LoadScene(scene1Name);
    }

    private void OnButton2Clicked()
    {
        SceneManager.LoadScene(scene2Name);
    }

    private void OnButton3Clicked()
    {
        SceneManager.LoadScene(scene3Name);
    }
}
