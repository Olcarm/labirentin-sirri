using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayPiano : MonoBehaviour
{
    public List<string> notaListesi=new List<string>();

    public GameObject Menu;
    public List<string> basilanTusListesi=new List<string>();
    private void OnCollisionEnter(Collision collision)
    {
        string notaName=collision.gameObject.GetComponent<Nota>().GetNotaTusu();
        basilanTusListesi.Add(notaName);
    }
    void Update(){
        SarkiKontrol();
    }

    public void SarkiKontrol(){

          if (notaListesi.Count >= 6 && basilanTusListesi.Count >= 6)
        {
            for (int i = 0; i <= basilanTusListesi.Count - 6; i++)
            {
                bool uyumlu = true;
                for (int j = 0; j < 6; j++)
                {
                    if (basilanTusListesi[i + j] != notaListesi[j])
                    {
                        uyumlu = false;
                        break;
                    }
                }
                if (uyumlu)
                {
                    Menu.SetActive(true);
                    break;
                }
            }
        }
    }
}
