using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
	[CardEffectId("64006")]//海玫家族诗人
	public class HeymaeySkald : CardEffect
	{//使所选“家族”的所有友军单位获得1点增益。
		public HeymaeySkald(GameCard card) : base(card){}
		public override async Task<int> CardPlayEffect(bool isSpying,bool isReveal)
		{
			return 0;
		}
	}
}