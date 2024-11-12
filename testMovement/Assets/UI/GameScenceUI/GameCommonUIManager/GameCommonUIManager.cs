using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameCommonUIManager : MonoBehaviour
{
    #region Variables
    [SerializeField] GameObject gameOverUI;


    [SerializeField] GameObject totalUI;
    [SerializeField] Timer timer;
    [SerializeField] private Text complectBox;
    [SerializeField] private Text score;
    [SerializeField] private Text timeText;
    [SerializeField] private Text result;
    [SerializeField] private Text sp;

    [SerializeField] Animator gameOverAnimator;
    [SerializeField] Animator anyButtonAnimtor;
    [SerializeField] Animator totalAnimator;
    [SerializeField] GameObject boxZoomView;
    [SerializeField] Animator van_animtor;


    [SerializeField] GameObject stageClearUI;


    [SerializeField] GameObject back_closeZoomButton;
    [SerializeField] GetAnser_1 getAnser;
    // [SerializeField] float stageClearBackWaitTime = 3;


    #endregion
    private void Start()
    {
        gameOverUI.SetActive(false);
        totalUI.SetActive(false);
        van_animtor.Play("van_GoBack");
        back_closeZoomButton.SetActive(false);

        gameOverAnimator.SetBool("gameOverContinue", false);

    }
    public void gameOver()
    {

        gameOverUI.SetActive(true);
        gameOverAnimator.Play("GameOverIn_Animation");
        anyButtonAnimtor.Play("GameOver_PressAnyKey_Animtion");
        boxZoomView.SetActive(false);


    }
    private void Update()
    {
        if (boxZoomView.active == true)
        {
            back_closeZoomButton.SetActive(true);
        }
        else { back_closeZoomButton.SetActive(false); }

        if (gameOverUI == true)
        {
            if (Input.anyKey)
            {
                gameOverAnimator.SetBool("gameOverContinue", true);

                gameOverAnimator.SetBool("gameOverEnd", true);
            }
        }
        if (gameOverAnimator.GetBool("gameOverEnd") == true)
        {
            totalUI.SetActive(true);
            //gameOverUI.SetActive(false);
            complectBox.text = PlayerPrefs.GetInt("boxComplection").ToString("0/5");
            score.text = PlayerPrefs.GetInt("TotalScore").ToString("0/25");
            timeText.text = timer.getFinishTime();
            result.text = "FAIL";
            sp.text = "... AGAIN ?";

            totalAnimator.Play("totalIn_animation");


        }
        if (getAnser.GetAnserIsCorrected() == true)
        {
            boxZoomView.SetActive(false);
            getAnser.setAnserIsCorrected();
        }
        if (stageClearUI.active == true)
        {

            if (Input.anyKey)
            {
                SceneManager.LoadScene("LevelManuel");
            }
        }




    }
    public void BackToLeveManuel()
    {
        SceneManager.LoadScene("LevelManuel");
    }

    public void StageClear()
    {
        stageClearUI.SetActive(true);
        boxZoomView.SetActive(false);


    }

}