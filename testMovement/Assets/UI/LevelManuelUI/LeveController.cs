using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LeveController : MonoBehaviour
{
    #region Variables
    [SerializeField] GameObject infoUI;
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
    public void BackButton()
    {
        SceneManager.LoadScene("HomePage");
    }
    public void applyLevel()
    {
        switch (level){
            case 1:
                SceneManager.LoadScene("GameScene_tester");//chang the scens name part to get to the right scens
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
        }
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
