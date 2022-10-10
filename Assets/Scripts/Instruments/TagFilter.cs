using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TagFilter
{
    public List<TagsList> tags;

    public bool HasTag(TagsList tag)
    {
        foreach(TagsList a in tags)
        {
            if(a==TagsList.all||tag==a)
            {
                return true;
            }
        }
        return false;
    }
}

public enum TagsList
{
    player=0,
    enemy=1,
    other=2,
    shot=3,
    all=-1
}