using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
	[CardEffectId("63005")]//莫克瓦格
	public class Morkvarg : CardEffect
	{//进入墓场时，复活自身，但战力削弱一半。
		public Morkvarg(GameCard card) : base(card){}
		public override async Task<int> CardPlayEffect(bool isSpying,bool isReveal)
		{
			return 0;
		}
	}
}