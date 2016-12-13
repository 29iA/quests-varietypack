//--- Aura Custom Script -----------------------------------------------------------
// Collect Fine Leather
//--- Description -----------------------------------------------------------
// Collection quest for Fine Leather.
//---------------------------------------------------------------------------

public class Collect5FineLeathersQuestScript : QuestScript
{
	public override void Load()
	{
		SetId(1103);
		SetScrollId(70023);
		SetName(L("Collect Fine Leather"));
		SetDescription(L("Please [collect 5 Fine Leathers]. Leathers are quite abundant as a tailoring material from monsters such as goblins and kobolds, along with other thick-skinned beasts. The local tailors want to have these leathers as they themselves can't fight well enough. You'll find the leather if you [fight monsters] from the local dungeons."));
		SetType(QuestType.Collect);

		SetIcon(QuestIcon.Collect);
		if (IsEnabled("QuestViewRenewal"))
			SetCategory(QuestCategory.Repeat);

		AddObjective("collect", L("Collect 5 Fine Leather"), 0, 0, 0, Collect(60025, 5));

		AddReward(Item(60029, 3)); // Fine Leather Strap
	}
}