//--- Aura Custom Script -----------------------------------------------------------
// Collect Cheap Leather
//--- Description -----------------------------------------------------------
// Collection quest for Cheap Leather.
//---------------------------------------------------------------------------

public class Collect5CheapLeathersQuestScript : QuestScript
{
	public override void Load()
	{
		SetId(1101);
		SetScrollId(70023);
		SetName(L("Collect Cheap Leather"));
		SetDescription(L("Please [collect 5 Cheap Leathers]. Leathers are quite abundant as a tailoring material from monsters such as goblins and kobolds, along with other thick-skinned beasts. The local tailors want to have these leathers as they themselves can't fight well enough. You'll find the leather if you [fight monsters] from the local dungeons."));
		SetType(QuestType.Collect);

		SetIcon(QuestIcon.Collect);
		if (IsEnabled("QuestViewRenewal"))
			SetCategory(QuestCategory.Repeat);

		AddObjective("collect", L("Collect 5 Cheap Leather"), 0, 0, 0, Collect(60023, 5));

		AddReward(Item(60027, 3)); // Cheap Leather Strap
	}
}