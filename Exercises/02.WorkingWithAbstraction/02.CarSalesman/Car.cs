using System.Linq;
using System.Text;

namespace CarsSalesman
{
    public class Car
    {
        private const string offset = "  ";

        private string model;
        private Engine engine;
        private string weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = "n/a";
            this.Color = "n/a";
        }

        public string Model { get => model; set => model = value; }

        public Engine Engine { get => engine; set => engine = value; }

        public string Weight { get => weight; set => weight = value; }

        public string Color { get => color; set => color = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}:\n", this.Model);
            sb.Append(this.Engine.ToString());
            sb.AppendFormat("{0}Weight: {1}\n", offset, this.Weight);
            sb.AppendFormat("{0}Color: {1}", offset, this.Color);

            return sb.ToString();
        }
    }

}
