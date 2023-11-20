using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class helloworld : MonoBehaviour
{
    void bölenlerProjesi(int sayi1, int sayi2)
    {
        sayi1 = 4;
        sayi2 = 77;
        ArrayList liste = new ArrayList();

        for (int i = sayi1; i <= sayi2; i++)
        {
            liste.Add(i);
        }

        string tümListe = "";
        string ikiyeBölünenler = "";
        string üceBölünenler = "";
        string dördeBölünenler = "";
        string beseBölünenler = "";

        foreach (int i in liste)
        {
            tümListe += " - " + i;
            if (i % 2 == 0)
            {
                ikiyeBölünenler += " - " + i;
            }
            if (i % 3 == 0)
            {
                üceBölünenler += " - " + i;
            }
            if (i % 4 == 0)
            {
                dördeBölünenler += " - " + i;
            }
            if (i % 5 == 0)
            {
                beseBölünenler += " - " + i;
            }
        }

        print("Tüm Liste: " + tümListe);
        print("Ýkiye Bölünenler: " + ikiyeBölünenler);
        print("Üçe Bölünenler: " + üceBölünenler);
        print("Dörde Bölünenler: " + dördeBölünenler);
        print("Beþe Bölünenler: " + beseBölünenler);
    }
    void update()
    {
        
    }
}
