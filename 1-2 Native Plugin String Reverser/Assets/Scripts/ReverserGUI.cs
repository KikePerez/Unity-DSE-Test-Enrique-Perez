using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ReverserGUI : MonoBehaviour
{
    [SerializeField]
    private InputField txt_input;
    [SerializeField]
    private Text txt_output;
    [SerializeField]
    private StringReverser reverser;

    public void Btn_Reverse_Callback()
    {
        txt_output.text = reverser.CallReverseText(txt_input.text);
    }


}
