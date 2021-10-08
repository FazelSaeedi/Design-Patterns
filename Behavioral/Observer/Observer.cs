using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Observer
{
    public abstract class Observer
    {
        protected Observable Observable;
        public abstract void Update();
    }
}
