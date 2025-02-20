using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace PFCharacters.Macros
{
  [CreateAssetMenu]
  [SerializeField]
  public class Equipment : ScriptableObject
  {
	
	  // 表示名
		public string displayName;
		// 説明文
		public string description;
		// プレハブ
		public string prefabAddress;
		// 防御力
		public int defense;
		// 攻撃力
		public int attack;
		// 素早さ
		public int speed;
		// 回避率
		public int dodgeRate;
		// 毒耐性
		public bool poisonResist;
		// 麻痺耐性
		public bool paralysisResist;
		// 眠り耐性
		public bool sleepResist;
		// 幻惑耐性
		public bool confusionResist;
		// 暗闇耐性
		public bool blindResist;
		// 呪い耐性
		public bool curseResist;
		// 火傷耐性
		public bool burnResist;
		// 凍傷耐性
		public bool freezeResist;
		// 火強化
		public bool fireEnhance;
		// 水強化
		public bool waterEnhance;
		// 風強化
		public bool windEnhance;
		// 土強化
		public bool earthEnhance;
		public enum EquipmentSlot
		{
			Head,
			Ear,
			Body,
			Arm,
			Leg,
			Hand,
			Foot
		}
		// 装備スロット
		public EquipmentSlot slot;
  }
}