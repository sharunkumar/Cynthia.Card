using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
    [CardEffectId("15006")]//话篓子：捣蛋鬼
    public class FieldMarshalDudaAgitator : CardEffect
    {//对左右各2格内的单位造成2点伤害。
        public FieldMarshalDudaAgitator(GameCard card) : base(card) { }
        public override async Task<int> CardPlayEffect(bool isSpying, bool isReveal)
        {

            return 0;
        }
    }
}