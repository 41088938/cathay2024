using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BookZoomFieldController : MonoBehaviour
{
    [SerializeField]public GameObject boxZoomField;
    
    // Start is called before the first frame update
    void Start()
    {
       
        boxZoomField.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {

                if (hit.transform.tag == "vanInside")
                    Debug.Log("hitedVan");
                {
                    boxZoomField.SetActive(true);
                }
            }
        }
        
    }
    public void OutZoomVeiw()
    {
        boxZoomField.SetActive(false);
    }
}
