using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
	[CardEffectId("64010")]//图尔赛克家族弓箭手
	public class TuirseachArcher : CardEffect
	{//对3个单位各造成1点伤害。
		public TuirseachArcher(GameCard card) : base(card){}
		public override async Task<int> CardPlayEffect(bool isSpying,bool isReveal)
		{
			return 0;
		}
	}
}