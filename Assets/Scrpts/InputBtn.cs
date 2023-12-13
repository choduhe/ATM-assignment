using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class input : MonoBehaviour
{
    public void OnClickButton()
    {
        GameManager.I.InputPanel.SetActive(true);
        GameManager.I.InOutPanel.SetActive(false);
    }
   
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
 
              
    }
}
