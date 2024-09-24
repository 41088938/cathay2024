using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameCommonUIManager : MonoBehaviour
{
    #region Variables
    [SerializeField]GameObject gameOverUI;
    [SerializeField]GameObject totalUI;
    [SerializeField]Animator gameOverAnimator;
    [SerializeField]Animator anyButtonAnimtor;
    [SerializeField] Animator totalAnimator;
    
    

    #endregion
    private void Start()
    {
        gameOverUI.SetActive(false);
        totalUI.SetActive(false);
       
        gameOverAnimator.SetBool("gameOverContinue", false);
        
    }
    public void gameOver()
    {
        
        gameOverUI.SetActive(true);
        gameOverAnimator.Play("GameOverIn_Animation");
        anyButtonAnimtor.Play("GameOver_PressAnyKey_Animtion");
        


    }
    private void Update()
    {
         if (gameOverUI == true)
        {
            if (Input.anyKey)
            {
                gameOverAnimator.SetBool("gameOverContinue", true);
                
                gameOverAnimator.SetBool("gameOverEnd",true);
            }
        }
        if (gameOverAnimator.GetBool("gameOverEnd") == true)
        {
            totalUI.SetActive(true);
            //gameOverUI.SetActive(false);
            totalAnimator.Play("totalIn_animation");
            

        }
        
               
         
       
    }
    public void BackToLeveManuel()
    {
      SceneManager.LoadScene("LevelManuel");
    }



}
