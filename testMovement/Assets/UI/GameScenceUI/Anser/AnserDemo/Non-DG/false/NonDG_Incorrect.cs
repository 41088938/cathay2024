using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NonDG_Incorrect : MonoBehaviour
{
    [SerializeField] InputFieldControler inputField_controler;
    private bool correctText=false;
   private void Update()
    {
        CheckingInputField_NonDG_Incorrect();
    }
    private void CheckingInputField_NonDG_Incorrect()
    {
        if (inputField_controler.getStickerInput()=="Net Quantity 2kg")
        {
            correctText= true;
            Debug.Log("CorrectText="+ inputField_controler.getStickerInput());
        }
    }
        
    
    
}
