using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class oyunBitisTriger : MonoBehaviour
{
    public Text oyunBitisZaman;
    public GameObject bitisekran;
    public GameObject araba;

    public GameObject silincek;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "araba")
        {

            bitisekran.SetActive(true);

            araba.SetActive(false);
            silincek.SetActive(false);

}



    }


    public void Update()
    {
        oyunBitisZaman.text = zaman.gel.ToString();
    }


}
