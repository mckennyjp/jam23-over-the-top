using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseMenus : MonoBehaviour
{
    [SerializeField] private GameObject winMenu;

    void Start(){
        winMenu.SetActive(false);
    }
    
    public void ShowWinMenu(){
        winMenu.SetActive(true);
    }
}
