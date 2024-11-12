using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LeveController : MonoBehaviour
{
    #region Variables
    [SerializeField] public GameObject infoUI;
    private int level=0;


    #endregion 
    public void Start()
    {
        infoUI.SetActive(false);
    }
    public void EasyLevel()
    {
        level=1;
        
    }

    public void ShowInfoUI()
    {
        if (infoUI != null)
        {
            infoUI.SetActive(true); // 顯示 UI
        }
        else
        {
            Debug.LogError("infoUI has not been assigned!");
        }
    }
    public void BackButton()
    {
        SceneManager.LoadScene("HomePage");
    }
    public void applyLevel()
    {
       
                SceneManager.LoadScene("GameScene_tester_non");//chang the scens name part to get to the right scens
              
        
    }
    public void CloseInfoPage()
    {
        infoUI.SetActive(false);
    }
    public void InfoButton()
    {
        infoUI.SetActive(true);
    }
}
