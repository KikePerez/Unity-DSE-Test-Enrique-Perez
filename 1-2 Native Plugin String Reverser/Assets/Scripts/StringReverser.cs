using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Text;

public class StringReverser : MonoBehaviour
{
    [DllImport("StringReverser", CallingConvention = CallingConvention.Cdecl)]
    static extern void ReverseText(string input, StringBuilder output, int len);

    public string CallReverseText(string input)
    {
        if (input.Length>0 && input!=null)
        {
            StringBuilder sb = new StringBuilder(input.Length);

            ReverseText(input, sb, sb.Capacity);
            Debug.Log(sb);
            return sb.ToString();
        }
        else
        {
            return "ERROR: input is empty or Null";
        }
    }
}
