using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class TriggerBehaviour:ScriptableBehaviour
{
    [SerializeField] protected TagFilter detectableTag;
    [SerializeField] protected TagFilter ignorableTag;

    public override void Init(Unit _unit)
    {
    }

    public virtual void AddDetectableTag(string tag)
    {
        TagsList parsedTag = Enum.Parse<TagsList>(tag);
        detectableTag.tags.Add(parsedTag);
    }
    public virtual void AddDetectableTag(TagsList tag)
    {
        detectableTag.tags.Add(tag);
    }

    public virtual void AddIgnorableTag(string tag)
    {
        TagsList parsedTag = Enum.Parse<TagsList>(tag);
        ignorableTag.tags.Add(parsedTag);
    }
    public virtual void AddIgnorableTag(TagsList tag)
    {
        ignorableTag.tags.Add(tag);
    }

    public virtual bool CompareTag(TagsList tag)
    {
        if(ignorableTag.HasTag(tag))
        {
            return false;
        }
        if(detectableTag.HasTag(tag))
        {
            return true;
        }
        return false;
    }

    public virtual bool CompareTag(string tag)
    {
        TagsList parsedTag = Enum.Parse<TagsList>(tag);
        if(ignorableTag.HasTag(parsedTag))
        {
            return false;
        }
        if(detectableTag.HasTag(parsedTag))
        {
            return true;
        }
        return false;
    }
}