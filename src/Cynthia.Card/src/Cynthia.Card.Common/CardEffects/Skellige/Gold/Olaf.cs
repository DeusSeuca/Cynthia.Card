using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
	[CardEffectId("62001")]//奥拉夫
	public class Olaf : CardEffect
	{//对自身造成10点伤害。本次对局己方每打出过1只“野兽”，伤害便减少2点。
		public Olaf(GameCard card) : base(card){}
		public override async Task<int> CardPlayEffect(bool isSpying,bool isReveal)
		{
			return 0;
		}
	}
}