using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class colorchange : MonoBehaviour
{
    public Material nMaterial;
    public void setcolor(){
        nMaterial.DOColor(Color.black,10);
    }
}
