using System.Diagnostics.CodeAnalysis;

namespace Class27102020
{
    public class Building : IHasValue
    {
        public string Type { get; set; }

        public float Area { get; set; }

        public float Value { get; }

        public Building(string type, float area, float value)
        {
            Type = type;
            Area = area;
            Value = value;
        }

        public bool Equals(IHasValue other)
        {
            if (other is null) return false;
            return Value == other.Value;
        }

        public override string ToString() => $"{Type,-20}{Value,8:f2}{Area,8:f2}";
    }
}