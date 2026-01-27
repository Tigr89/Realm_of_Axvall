using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class scr_node : MonoBehaviour
{
    public Node camefrom;
    public List<Node> connections;

    public float Gscore;
    public float Hscore;

    public float Fscore()
    {
        return Gscore + Hscore;
    }
    
}
