using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    float direction = 0.08f;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        Movestop();
        Move();
        transform.position += new Vector3(direction, 0, 0);
    }
    private void Move()
    {
        if (gameObject.transform.position.x > 4)
    {
        GameManager.I.LoginPanel.SetActive(true);
    }
}

private void Movestop()
    {
    if (gameObject.transform.position.x > 5)
    {   
        direction = 0;
    }
    }
}
