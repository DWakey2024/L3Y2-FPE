using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    GameManager gmSc;

    // Start is called before the first frame update
    void Start()
    {
        gmSc = GameObject.Find("GameManager").GetComponent<GameManager>();
        gmSc.infoText.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            gmSc.hasKey = true;
            Destroy(other.gameObject);
        }
    }
}
