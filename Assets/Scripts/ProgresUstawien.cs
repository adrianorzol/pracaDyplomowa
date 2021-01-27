using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ProgresUstawien 
{
    public bool dzwiek;
    public bool wibracje;
    public ProgresUstawien(ZamykanieAplikacji ustawienia)
    {
        dzwiek = ustawienia.czyDzwiek;
        wibracje = ustawienia.czyWibracje;
    }
}
