using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInteract : MonoBehaviour
{
    // Start is called before the first frame update
    public Button yourButton
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.conClick.AddListened(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        //add move camera to next screen here 
    }
}
