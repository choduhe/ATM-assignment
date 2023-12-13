using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class SignPanel: MonoBehaviour
{
    public void OnClickButtonSign()
    {
        GameManager.I.LoginPanel.SetActive(false);
        GameManager.I.SignPanel.SetActive(true);
        
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
