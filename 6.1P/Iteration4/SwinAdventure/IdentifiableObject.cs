﻿using System;
using System.Collections.Generic;

namespace SwinAdventure
{
    public class IdentifiableObject
    {

        // Create list field
        private List<string> _identifiers;
        // Property
        public string FirstID
        {
            get
            {
                //Empty if no identifier
                if (_identifiers.Count == 0)
                {
                    return "";
                }
                else
                {
                    //esle return the first id
                    return _identifiers[0];
                }
            }
        }
        //Constructor
        public IdentifiableObject(string[] idents)
        {
            _identifiers = new List<string>();

            foreach (string s in idents)
            {
                _identifiers.Add(s.ToLower());
            }

        }
        // Method
        public bool AreYou(string id)
        {
            return _identifiers.Contains(id.ToLower());
        }


        public void AddIdentifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }

    }
}
