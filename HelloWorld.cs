using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class helloworld : MonoBehaviour
{
    void b�lenlerProjesi(int sayi1, int sayi2)
    {
        sayi1 = 4;
        sayi2 = 77;
        ArrayList liste = new ArrayList();

        for (int i = sayi1; i <= sayi2; i++)
        {
            liste.Add(i);
        }

        string t�mListe = "";
        string ikiyeB�l�nenler = "";
        string �ceB�l�nenler = "";
        string d�rdeB�l�nenler = "";
        string beseB�l�nenler = "";

        foreach (int i in liste)
        {
            t�mListe += " - " + i;
            if (i % 2 == 0)
            {
                ikiyeB�l�nenler += " - " + i;
            }
            if (i % 3 == 0)
            {
                �ceB�l�nenler += " - " + i;
            }
            if (i % 4 == 0)
            {
                d�rdeB�l�nenler += " - " + i;
            }
            if (i % 5 == 0)
            {
                beseB�l�nenler += " - " + i;
            }
        }

        print("T�m Liste: " + t�mListe);
        print("�kiye B�l�nenler: " + ikiyeB�l�nenler);
        print("��e B�l�nenler: " + �ceB�l�nenler);
        print("D�rde B�l�nenler: " + d�rdeB�l�nenler);
        print("Be�e B�l�nenler: " + beseB�l�nenler);
    }
    void update()
    {
        
    }
}
