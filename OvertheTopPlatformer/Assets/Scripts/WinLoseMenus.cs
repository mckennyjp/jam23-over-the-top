using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseMenus : MonoBehaviour
{
    [SerializeField] GameObject winMenu;

    void Start(){
        winMenu.SetActive(false);
    }
    
    public void ShowWinMenu(){
        winMenu.SetActive(true);
        //for(int i = 0; i < winMenu.Length; i++){
        //    winMenu[i].SetActive(true);
        //}
        Debug.Log("show win menu");
    }
}
