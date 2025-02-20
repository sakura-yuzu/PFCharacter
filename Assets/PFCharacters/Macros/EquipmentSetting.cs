using UnityEngine;

namespace PFCharacters.Macros
{
	[CreateAssetMenu]
	[SerializeField]
	class EquipmentSetting : ScriptableObject
	{
		public Equipment Head;
		public Equipment Ears;
		public Equipment Body;
		public Equipment Arms;
		public Equipment Hands;
		public Equipment Legs;
		public Equipment Feet;
	}
}
