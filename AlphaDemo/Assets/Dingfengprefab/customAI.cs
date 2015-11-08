using RAIN.Core;
using RAIN.Serialization;
using UnityEngine;

[RAINSerializableClass]
public class customAI : CustomAIElement
{
	public Transform player;

	public override void AIInit()
	{
		base.AIInit();

		// This is equivilent to an Awake call
	}
	
	public override void Pre()
	{
		base.Pre();
		
		// This is the very first step, usually at the beginning of the Update call
		// This happens right after the Motor calls UpdateMotionTransforms




	}
	
	public override void Sense()
	{
		base.Sense();
		
		// This happens right after the the Senses have updated any detected Aspects
	}
	
	public override void Think()
	{
		base.Think();
		
		// This happens right after the Mind has decided what actions to take
	}
	
	public override void Act()
	{
		base.Act();
		
		// This happens right after the Motor has applied any movement changes to the AI
	}
	
	public override void Post()
	{
		base.Post();
		
		// This is the last step, usually at the end of the LateUpdate call
		// This happens right after the Motor and Animator have updated animations
	}
}