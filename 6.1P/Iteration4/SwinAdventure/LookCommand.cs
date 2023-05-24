using System;

namespace SwinAdventure
{
    public class LookCommand : Command
    {
        public LookCommand() : base(new string[] { "look" }) { }

        public override string Execute(Player p, string[] text)
        {
            if (text.Length != 3 && text.Length != 5)
                return "I don't know how to look like that";

            if (!AreYou(text[0]))
            {
                return "Error in look input";
            }

            if (text[1].ToLower() != "at")
            {
                return "What do you want to look at?";
            }

            IHaveInventory container = p;
            if (text.Length == 5)
            {
                if (text[3].ToLower() != "in")
                    return "What do you want to look in?";

                container = FetchContainer(p, text[4]);
                if (container == null)
                    return $"I can't find the {text[4]}";
            }

            

            return LookAtIn(text[2], container);
        }

        private IHaveInventory FetchContainer(Player p, string containerID)
        {
            return p.Locate(containerID) as IHaveInventory;
        }

        private string LookAtIn(string thingID, IHaveInventory container)
        {
            GameObject foundItem = container.Locate(thingID);
            if (foundItem == null)
            {
                if (container == container.Locate("inventory"))
                {
                    return $"I can't find the {thingID}";
                }
                else
                {
                    return $"I can't find the {thingID} in {container.Name}";
                }
            }
            return foundItem.FullDescription;
        }
    }
}
