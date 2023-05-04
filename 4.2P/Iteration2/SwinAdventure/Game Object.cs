using System;
namespace SwinAdventure
{
	public abstract class GameObject : Identifiable_Object
	{

		// Fields
		private string _description;
		private string _name;
		//Constructor
		public GameObject(string[] ids, string name, string desc) : base(ids)
		{
			_name = name;
			_description = desc;
		}


		// Properties
		public string Name
		{
			get
			{
				return _name;
			}
		}
		public string ShortDescription
		{
			get
			{
				return "a " + _name + " " + "(" +FirstID +")";
			}
		}
		public virtual string FullDescription
		{
			get
			{
				return _description;
			}
		}

		
		
	}
}

