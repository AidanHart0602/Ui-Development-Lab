using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class LoadingBar : MonoBehaviour
{
    [SerializeField] private Slider _progressBar;
    [SerializeField] private TMP_Text _text;
    private bool _loadingStart = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_loadingStart == false && Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(LoadLevelAsync());
            _loadingStart = true;
        }
    }

    IEnumerator LoadLevelAsync()
    {
        AsyncOperation loadingOperation = SceneManager.LoadSceneAsync("Main Menu Scene");

        while(loadingOperation.isDone == false)
        {
            _progressBar.value = loadingOperation.progress;
            _text.text = _progressBar.value + "%";
            yield return null;
        }
    }
}
