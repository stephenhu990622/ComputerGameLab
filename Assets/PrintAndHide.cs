using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    int i = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        i++;
        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }

        if (gameObject.tag == "Blue" && i== Random.Range(150,251))
        {
            
            rend = GetComponent<MeshRenderer>();
            rend.enabled = false;
            
        }
        Debug.Log(gameObject.name+":" + i);
        

        


    }
}
