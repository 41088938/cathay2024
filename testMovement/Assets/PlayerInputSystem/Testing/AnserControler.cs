using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnserControler : MonoBehaviour
{
    [SerializeField]public GameObject cager1_corr;
    [SerializeField] public GameObject cager2_corr;
    [SerializeField] public GameObject cager3;
    [SerializeField] public GameObject cager4;
    [SerializeField] public GameObject cager5;

    private GameObject crentCager;

    [SerializeField] private int crencatNumber = 0;

    #region random 

    [SerializeField] RandomControler randomControler;
    private GameObject[] catOrder = new GameObject[5];

    public void StartGetAnser()
    {
        randomControler.AddRandomNumberList();
        cager1_corr.SetActive(false);
        cager2_corr.SetActive(false);
        cager3.SetActive(false);
        cager4.SetActive(false);
        cager5.SetActive(false);
        catOrder[randomControler.RandomNumber()] = cager1_corr;
        catOrder[randomControler.RandomNumber()] = cager2_corr;
        catOrder[randomControler.RandomNumber()] = cager3;
        catOrder[randomControler.RandomNumber()] = cager4;
        catOrder[randomControler.RandomNumber()] = cager5;



        
        for (int i = 0; i < catOrder.Length; i++)
        {
            Debug.Log(i + ": " + catOrder[i].name);
        }

        crentCager = catOrder[crencatNumber];
        crencatNumber = 0;
    }
    #endregion
    #region Random


    public void updateCrentCager()
    {
        crencatNumber++;
        crentCager = catOrder[crencatNumber];

        Debug.Log("crencat=" + crencatNumber);
        CagerRandomOutPut();
    }
    public void CagerRandomOutPut()
    {



        if (crentCager == cager1_corr)
        {
            cager2_corr.SetActive(false);
            cager3.SetActive(false);
            cager4.SetActive(false);
            cager5.SetActive(false);
        }
        else if (crentCager == cager2_corr)
        {
            cager1_corr.SetActive(false);
            cager3.SetActive(false);
            cager4.SetActive(false);
            cager5.SetActive(false);
        }
        else if (crentCager == cager3)
        {
            cager1_corr.SetActive(false);
            cager2_corr.SetActive(false);
            cager4.SetActive(false);
            cager5.SetActive(false);
        }
        else if (crentCager == cager4)
        {
            cager1_corr.SetActive(false);
            cager2_corr.SetActive(false);
            cager3.SetActive(false);
            cager5.SetActive(false);
        }
        else if (crentCager == cager5)
        {
            cager1_corr.SetActive(false);
            cager2_corr.SetActive(false);
            cager3.SetActive(false);
            cager4.SetActive(false);

        }
        UnityEngine.Debug.Log(crentCager);



    }
    #endregion
    public int GetCrentCatNumber()
    {
        return crencatNumber;
    }
    public GameObject GetCrentBox()
    {
        return crentCager;
        Debug.Log("crentCrentBox=" + crentCager.name);
    }
    public void SetCrentBox(bool isAtive)
    {
        crentCager.SetActive(isAtive);
    }
}
