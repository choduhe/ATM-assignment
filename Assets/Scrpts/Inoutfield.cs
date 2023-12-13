using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InOutField: MonoBehaviour
{
    [SerializeField] private Text Banlance;
    [SerializeField] private InputField Inoutmoney;

    private int Currnetmoney = 50000;
    private int Btn1 = 10000;
    private int Btn3 = 30000;

    public void In()
    {
        Currnetmoney += int.Parse(Inoutmoney.text);
        Banlance.text = Currnetmoney.ToString();
    }

    public void Out()
    {
        Currnetmoney -= int.Parse(Inoutmoney.text);
        Banlance.text = Currnetmoney.ToString();
    }

    
    private void Update()
    {
        notmoney();
    }

    public void notmoney()
    {
        if(Currnetmoney<=0)
        {
            Currnetmoney = 0;
            
            GameManager.I.ErrorPanel.SetActive(true);   
        }
    }

    public void outmoney()
    {
        Currnetmoney -= Btn1;
    }

}
