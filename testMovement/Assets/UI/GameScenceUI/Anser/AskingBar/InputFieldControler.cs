using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InputFieldControler : MonoBehaviour
{
    [SerializeField] InputField stickerInputField;
    [SerializeField] Text askingBarText;
    [SerializeField] Text stickerText;
    [SerializeField] Button inputFeildEnterButton;
    [SerializeField] Animator askingDetailBar_aimator;
    private bool isOpenDetailBar=false;
    private void Start()
    {
        isOpenDetailBar = false;
    }
    private void Update()
    {
        askingBarText.text = stickerInputField.text;
        askingBarText.text = stickerText.text;
    }
    public string getStickerInput()
    {
        return stickerInputField.text.ToString();
    }
    public void EnterInputField()
    {
        if (!isOpenDetailBar)
        {
            askingDetailBar_aimator.Play("MissingBarDetalTable_In_Animtion");
            isOpenDetailBar=true;
        }
        else if(isOpenDetailBar){
            askingDetailBar_aimator.Play("MissingBarDetalTable_Out_Animtion");
            isOpenDetailBar=false;
        }

    }
}
