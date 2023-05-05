using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SwinAdventure
{
    public class LookCommand : Command
    {
        public LookCommand() : base(new string[] { "look" }) { }

        public override string Execute(Player p, string[] text)
        {
            IHaveInventory container;
            string item;
            string err = "Error in look input";
            string lookat = "What do you want to look at?";
            string lookin = "What do you want to look in?";

            if (text[0].ToLower() != "look")
                return err;

            switch (text.Length)
            {
                case 3:
                    if (text[1].ToLower() != "at")
                        return lookat;
                    container = p;
                    item = text[2];
                    if (container.Locate(item) == null)
                        return $"I can't find the {item}";

                    break;
                case 5:
                    if (text[3].ToLower() != "in")
                        return lookin;
                    container = FetchContainer(p, text[4]);
                    if (container == null)
                        return $"I can\'t find the {text[4]}";
                    item = text[2];// item id
                    break;
                default:
                    return err;
            }

            return LookAtIn(item, container);
        }


        private IHaveInventory FetchContainer(Player p, string containerID)
        {
            return p.Locate(containerID) as IHaveInventory;
        }
        private string LookAtIn(string thingID, IHaveInventory container)
        {
            if (container.Locate(thingID) != null)
                return container.Locate(thingID).FullDescription;

            return $"I can't find the {thingID} in {container.Name}";
        }

    }
}

