using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class InventoryBuildDirector
    {
        private IFurnitureInventoryBuilder _builder;
        public InventoryBuildDirector(IFurnitureInventoryBuilder concreteBuilder)
        {
            _builder = concreteBuilder;
        }
        public void BuildCompleteReport()
        {
            _builder.AddTitle();
            _builder.AddDimensions();
            _builder.AddLogistics(DateTime.Now);
        }
    }
}
