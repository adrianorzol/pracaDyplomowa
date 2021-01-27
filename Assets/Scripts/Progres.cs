using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Progres 
{
    public float[] WBiB;
    public float[] WBZ;
    public float[] WG;
    public float[] WH;
    public float[] WMiI;
    public float[] WMW;
    public float[] WNE;
    public float[] WNoZ;
    public float[] WNT;
    public float[] WPiA;
    public float[] WRiL;
    public string ocenaWBiB;
    public string ocenaWBZ;
    public string ocenaWG;
    public string ocenaWH;
    public string ocenaWMiI;
    public string ocenaWMW;
    public string ocenaWNE;
    public string ocenaWNoZ;
    public string ocenaWNT;
    public string ocenaWPiA;
    public string ocenaWRiL;
    public Progres (UsuwanieWydzialu wydzialWBiB, UsuwanieWydzialu wydzialWBZ, UsuwanieWydzialu wydzialWG, UsuwanieWydzialu wydzialWH, UsuwanieWydzialu wydzialWMiI, UsuwanieWydzialu wydzialWMW, UsuwanieWydzialu wydzialWNE, UsuwanieWydzialu wydzialWNoZ, UsuwanieWydzialu wydzialWNT, UsuwanieWydzialu wydzialWPiA, UsuwanieWydzialu wydzialWRiL)
    {
        WBiB = new float[3];
        WBiB[0] = wydzialWBiB.transform.position.x;
        WBiB[1] = wydzialWBiB.transform.position.y;
        WBiB[2] = wydzialWBiB.transform.position.z;
        WBZ = new float[3];
        WBZ[0] = wydzialWBZ.transform.position.x;
        WBZ[1] = wydzialWBZ.transform.position.y;
        WBZ[2] = wydzialWBZ.transform.position.z;
        WG = new float[3];
        WG[0] = wydzialWG.transform.position.x;
        WG[1] = wydzialWG.transform.position.y;
        WG[2] = wydzialWG.transform.position.z;
        WH = new float[3];
        WH[0] = wydzialWH.transform.position.x;
        WH[1] = wydzialWH.transform.position.y;
        WH[2] = wydzialWH.transform.position.z;
        WMiI = new float[3];
        WMiI[0] = wydzialWMiI.transform.position.x;
        WMiI[1] = wydzialWMiI.transform.position.y;
        WMiI[2] = wydzialWMiI.transform.position.z;
        WMW = new float[3];
        WMW[0] = wydzialWMW.transform.position.x;
        WMW[1] = wydzialWMW.transform.position.y;
        WMW[2] = wydzialWMW.transform.position.z;
        WNE = new float[3];
        WNE[0] = wydzialWNE.transform.position.x;
        WNE[1] = wydzialWNE.transform.position.y;
        WNE[2] = wydzialWNE.transform.position.z;
        WNoZ = new float[3];
        WNoZ[0] = wydzialWNoZ.transform.position.x;
        WNoZ[1] = wydzialWNoZ.transform.position.y;
        WNoZ[2] = wydzialWNoZ.transform.position.z;
        WNT = new float[3];
        WNT[0] = wydzialWNT.transform.position.x;
        WNT[1] = wydzialWNT.transform.position.y;
        WNT[2] = wydzialWNT.transform.position.z;
        WPiA = new float[3];
        WPiA[0] = wydzialWPiA.transform.position.x;
        WPiA[1] = wydzialWPiA.transform.position.y;
        WPiA[2] = wydzialWPiA.transform.position.z;
        WRiL = new float[3];
        WRiL[0] = wydzialWRiL.transform.position.x;
        WRiL[1] = wydzialWRiL.transform.position.y;
        WRiL[2] = wydzialWRiL.transform.position.z;

        ocenaWBiB = wydzialWBiB.ocena;
        ocenaWBZ = wydzialWBZ.ocena;
        ocenaWG = wydzialWG.ocena;
        ocenaWH = wydzialWH.ocena;
        ocenaWMiI = wydzialWMiI.ocena;
        ocenaWMW = wydzialWMW.ocena;
        ocenaWNE = wydzialWNE.ocena;
        ocenaWNoZ = wydzialWNoZ.ocena;
        ocenaWNT = wydzialWNT.ocena;
        ocenaWPiA = wydzialWPiA.ocena;
        ocenaWRiL = wydzialWRiL.ocena;
    }
}
