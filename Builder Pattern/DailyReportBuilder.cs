using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class DailyReportBuilder : IFurnitureInventoryBuilder
    {
        private InventoryReport _report;
        private IEnumerable<FurnitureItem> _items;
        public DailyReportBuilder(IEnumerable<FurnitureItem> items)
        {
            Reset();
            _items = items;
        }
       
        public void AddDimensions()
        {
            _report.DimensionsSection = String.Join(Environment.NewLine, _items.Select(product => 
                $"Product: {product.Name} \nPrice: {product.Price} \n" +
                $"Height: {product.Height} x Width: {product.Width} -> Weight: {product.Weight}\n"));
        }
        public void AddLogistics(DateTime dateTime)
        {
            _report.LogisticsSection = $"Report generated on {dateTime}";
        }
        public void AddTitle()
        {
            _report.TitleSection = "------ Daily Inventory Report ------ \n\n";
        }
        public InventoryReport GetDailyReport()
        {
            InventoryReport finishedReport = _report;
            Reset();

            return finishedReport;
        }

        public void Reset()
        {
            _report = new InventoryReport();
        }
    }
}
