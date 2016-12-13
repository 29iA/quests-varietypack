//--- Aura Custom Script -----------------------------------------------------------
// Collect Common Leather
//--- Description -----------------------------------------------------------
// Collection quest for Common Leather.
//---------------------------------------------------------------------------

public class Collect5CommonLeathersQuestScript : QuestScript
{
	public override void Load()
	{
		SetId(1102);
		SetScrollId(70023);
		SetName(L("Collect Common Leather"));
		SetDescription(L("Please [collect 5 Common Leathers]. Leathers are quite abundant as a tailoring material from monsters such as goblins and kobolds, along with other thick-skinned beasts. The local tailors want to have these leathers as they themselves can't fight well enough. You'll find the leather if you [fight monsters] from the local dungeons."));
		SetType(QuestType.Collect);

		SetIcon(QuestIcon.Collect);
		if (IsEnabled("QuestViewRenewal"))
			SetCategory(QuestCategory.Repeat);

		AddObjective("collect", L("Collect 5 Common Leather"), 0, 0, 0, Collect(60024, 5));

		AddReward(Item(60028, 3)); // Common Leather Strap
	}
}