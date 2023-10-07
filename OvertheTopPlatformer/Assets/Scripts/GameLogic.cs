using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    //public UnityEvent WinScreen;

    [SerializeField] private TextMeshProUGUI timerText;
    private bool timerActive = true;
    
    private float currentTime;

    void Update()
    {
        if(timerActive){
            currentTime += Time.deltaTime;
            timerText.text = ("Time:" + currentTime.ToString("0.00"));
        }
    }

    public void OnWin(){
        Debug.Log("You Won");
        timerActive = false;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //WinScreen.Invoke();
    }
}
