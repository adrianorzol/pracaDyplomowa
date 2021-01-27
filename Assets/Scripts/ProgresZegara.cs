using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class ProgresZegara
{
    public float czasWBiB;
    public bool czyWBiB;
    public float czasWBZ;
    public bool czyWBZ;
    public float czasWG;
    public bool czyWG;
    public float czasWH;
    public bool czyWH;
    public float czasWMiI;
    public bool czyWMiI;
    public float czasWMW;
    public bool czyWMW;
    public float czasWNE;
    public bool czyWNE;
    public float czasWNoZ;
    public bool czyWNoZ;
    public float czasWNT;
    public bool czyWNT;
    public float czasWPiA;
    public bool czyWPiA;
    public float czasWRiL;
    public bool czyWRiL;
    public ProgresZegara (Zegar WBiB, Zegar WBZ, Zegar WG, Zegar WH, Zegar WMiI, Zegar WMW, Zegar WNE, Zegar WNoZ, Zegar WNT, Zegar WPiA, Zegar WRiL)
    {
        czasWBiB = WBiB.timeRemaining;
        czyWBiB = WBiB.timerIsRunning;
        czasWBZ = WBZ.timeRemaining;
        czyWBZ = WBZ.timerIsRunning;
        czasWG = WG.timeRemaining;
        czyWG = WG.timerIsRunning;
        czasWH = WH.timeRemaining;
        czyWH = WH.timerIsRunning;
        czasWMiI = WMiI.timeRemaining;
        czyWMiI = WMiI.timerIsRunning;
        czasWMW = WMW.timeRemaining;
        czyWMW = WMW.timerIsRunning;
        czasWNE = WNE.timeRemaining;
        czyWNE = WNE.timerIsRunning;
        czasWNoZ = WNoZ.timeRemaining;
        czyWNoZ = WNoZ.timerIsRunning;
        czasWNT = WNT.timeRemaining;
        czyWNT = WNT.timerIsRunning;
        czasWPiA = WPiA.timeRemaining;
        czyWPiA = WPiA.timerIsRunning;
        czasWRiL = WRiL.timeRemaining;
        czyWRiL = WRiL.timerIsRunning;
    }
}
