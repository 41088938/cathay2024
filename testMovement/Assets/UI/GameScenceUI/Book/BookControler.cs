using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookControler : MonoBehaviour
{
    [SerializeField] GameObject[] books;//[0][1]=REQ, [2][3]=NonRadio
    [SerializeField]GameObject[] box;
    [SerializeField]Animator book_animator;
    [SerializeField] AnserControler ac_controler;
    [SerializeField] BookZoomFieldController boxZoomF_controler;

    private GameObject calledBook;
    private bool isOpen = false;

    private void Start()
    {
       
        ResetBook();
    }
     void CallBook()
    {
        bool onZoomF = boxZoomF_controler.boxZoomField.active;
        
        if (isOpen)
        {
            if (onZoomF)
            {
                boxZoomF_controler.boxZoomField.SetActive(true); 
            }
            ControlBook();

            isOpen = false;
        }
        else if(!isOpen) 
        {
            boxZoomF_controler.OutZoomVeiw();
            ControlBook();
            isOpen =true;
        }
    }
    private void ActiveBook()
    {
         if (ac_controler.GetCrentBox() == box[0] || ac_controler.GetCrentBox() == box[1])
         {
            books[0].SetActive(true);
         }else if(ac_controler.GetCrentBox() == box[2] || ac_controler.GetCrentBox() == box[3])
        {
            books[1].SetActive(true);
        }
            
        
    }
    private void OffBook()
    {
        for (int i = 0; i < books.Length; i++)
        {
            books[i].SetActive(false );
        }
    }
    public  void ResetBook()
    {
        OffBook();
        ActiveBook();
        isOpen = false;
        Debug.Log("BookResetActive");
    }
    private void ControlBook()
    {
        
        if (ac_controler.GetCrentBox() == box[0] || ac_controler.GetCrentBox() == box[1])//ICE
        {
            if (isOpen)
            {
                
                book_animator.Play("EQ_Out_animation");

                Debug.Log("BookOpen"+ac_controler.GetCrentBox());
            }else if (!isOpen)
            {
                book_animator.Play("EQ_In_animation");
            }

        }
        if (ac_controler.GetCrentBox() == box[2] || ac_controler.GetCrentBox() == box[3])
        {
            if (!isOpen)
            {
                book_animator.Play("BookNonRadio_Animation");

            }
            else if (isOpen)
            {
                book_animator.Play("BookNonRadio_Out_Animation");
            }
        }
        

        
    }
}
