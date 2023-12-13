using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    public GameObject InputPanel;
    public GameObject OutputPanel;
    public GameObject LoginPanel;
    public GameObject InOutPanel;
    public GameObject ErrorPanel;
    public GameObject SignPanel;

    public static GameManager I;
     void Awake()
    {
        I = this;
        DontDestroyOnLoad(this.gameObject);
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
