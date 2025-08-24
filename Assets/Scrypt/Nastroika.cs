using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nastroika : MonoBehaviour
{
    [SerializeField] private Scrollbar _scrollBar;
    [SerializeField] private Scrollbar _scroolBarVoice;

    public static float Zvuk;
    public static float ZvukVoice;

    public void ZvukIzmen()
    {
        Zvuk = _scrollBar.value;
        ZvukVoice = _scroolBarVoice.value;
    }



}
