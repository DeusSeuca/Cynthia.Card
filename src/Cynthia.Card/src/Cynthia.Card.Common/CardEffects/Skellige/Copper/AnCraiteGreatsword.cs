using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
	[CardEffectId("64009")]//奎特家族巨剑士
	public class AnCraiteGreatsword : CardEffect
	{//每2回合，若受伤，则在回合开始时治愈自身，并获得2点强化。
		public AnCraiteGreatsword(GameCard card) : base(card){}
		public override async Task<int> CardPlayEffect(bool isSpying,bool isReveal)
		{
			return 0;
		}
	}
}