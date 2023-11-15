namespace Shapes
{
    public abstract class ShapeBase
    {
        public string Name { get; }

        protected ShapeBase(string name)
        {
            Name = name;
        }

        public abstract double GetArea();
    }

}