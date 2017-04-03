﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEquipment : BaseStatItem 
{
	public enum EquipmentTypes
	{
		HEAD,
		CHEST,
		FEET
	}

	private EquipmentTypes equipmentType;
	private int spellEffectID;

	public EquipmentTypes EquipmentType
	{
		get { return equipmentType; }
		set { equipmentType = value; }
	}

	public int SpellEffectID
	{
		get { return spellEffectID; }
		set { spellEffectID = value; }
	}
}