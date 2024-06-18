using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comida : MonoBehaviour
{
    public GameObject[] Arraycomida;
    public int currentIndex = -1;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= Arraycomida.Length; i++)
        {
            Arraycomida[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentIndex++;
            if(currentIndex<Arraycomida.Length)
            {
                desactivateByIndex();
                activateByIndex();
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentIndex--;
            if (currentIndex > -1)
            {

            }
        }
     }
    void desactivateByIndex()
    {
        Arraycomida[currentIndex + 1].SetActive(false);
    }
    void activateByIndex()
    {
        Arraycomida[currentIndex + 1].SetActive(true);
    }

}