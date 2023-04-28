using System;
namespace SwinAdventure;

public class IdentifiableObject
{

    //Fields
    private List<string> _identifiers;

    // Constructor
    public IdentifiableObject(string[] idents)
    {
        _identifiers = new List<string>();

        foreach (string s in idents)
        {
            _identifiers.Add(s.ToLower());
        }

    }

    // Function
    public void AddIdentifier(string id)
    {
        _identifiers.Add(id.ToLower());
    }

    // Properties
    public bool AreYou(string id)
    {
        return _identifiers.Contains(id.ToLower());
    }

    public string FirstID
    {
        get
        {

            if (_identifiers.Count() == 0)
            {
                return "";
            }
            else
            {

                return _identifiers[0];
            }
        }
    }

}


