using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Malee;
using Malee.List;

[CreateAssetMenu()]//able to create database list

public class AnserDatabase : ScriptableObject
{
    [Reorderable]
    public AnserArray gameAnser;//able to create database list

    [System.Serializable]
    public class AnserArray : ReorderableArray<Anser> { }
}
